using System;
using NAudio.Wave;

namespace FractalAudioGen
{
    public class FractalWaveProvider : WaveProvider32
    {
        private double phaseLeft = 0;
        private double phaseRight = 0;
        private readonly int sampleRate = 44100;
        public double Frequency { get; set; } = 528; // Default to 528 Hz
        public double BinauralOffset { get; set; } = 4; // Default binaural offset
        public string WaveType { get; set; } = "Sine";

        public override int Read(float[] buffer, int offset, int count)
        {
            for (int i = 0; i < count; i += 2)
            {
                buffer[i + offset] = GenerateWaveSample(phaseLeft); // Left ear
                buffer[i + offset + 1] = GenerateWaveSample(phaseRight); // Right ear

                phaseLeft += 2 * Math.PI * Frequency / sampleRate;
                phaseRight += 2 * Math.PI * (Frequency + BinauralOffset) / sampleRate;

                if (phaseLeft > 2 * Math.PI) phaseLeft -= 2 * Math.PI;
                if (phaseRight > 2 * Math.PI) phaseRight -= 2 * Math.PI;
            }
            return count;
        }

        private float GenerateWaveSample(double phase)
        {
            return WaveType switch
            {
                "Sine" => (float)Math.Sin(phase),
                "Square" => (float)(Math.Sign(Math.Sin(phase))),
                "Sawtooth" => (float)((2.0 * (phase / (2 * Math.PI))) - 1.0),
                "Triangle" => (float)(2.0 * Math.Abs(2.0 * (phase / (2 * Math.PI)) - 1.0) - 1.0),
                _ => (float)Math.Sin(phase)
            };
        }
    }
}
