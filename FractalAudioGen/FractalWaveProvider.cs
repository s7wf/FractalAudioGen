using System;
using NAudio.Wave;

namespace FractalAudioGen
{
    public class FractalWaveProvider : WaveProvider32
    {
        private const int SAMPLE_RATE = 44100;

        public double Frequency { get; set; } = 528; // Default to 528 Hz
        public double BinauralOffset { get; set; } = 4; // Default binaural offset
        public FractalWaveType WaveType { get; set; } = FractalWaveType.Sine;

        public override int Read(float[] buffer, int offset, int count)
        {
            double phaseLeft = 0, phaseRight = 0;

            for (int i = 0; i < count; i += 2)
            {
                buffer[offset + i] = GenerateWaveSample(phaseLeft); // Left ear
                buffer[offset + i + 1] = GenerateWaveSample(phaseRight); // Right ear

                phaseLeft += 2 * Math.PI * Frequency / SAMPLE_RATE;
                phaseRight += 2 * Math.PI * (Frequency + BinauralOffset) / SAMPLE_RATE;

                if (phaseLeft > 2 * Math.PI) phaseLeft -= 2 * Math.PI;
                if (phaseRight > 2 * Math.PI) phaseRight -= 2 * Math.PI;
            }
            return count;
        }

        private float GenerateWaveSample(double phase)
        {
            return WaveType switch
            {
                FractalWaveType.Sine => (float)Math.Sin(phase),
                FractalWaveType.Square => Math.Sign(Math.Sin(phase)),
                FractalWaveType.Sawtooth => (float)(2.0 * (phase / (2 * Math.PI)) - 1.0),
                FractalWaveType.Triangle => (float)(2.0 * Math.Abs(2.0 * (phase / (2 * Math.PI)) - 1.0) - 1.0),
                _ => throw new NotSupportedException(WaveType.ToString())
            };
        }
    }
}
