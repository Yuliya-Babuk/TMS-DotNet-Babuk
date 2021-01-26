using System;
using System.Collections.Generic;
using System.Text;

namespace FitnessTracker
{
    class Training
    { /// <summary>
        /// Year, month and day of training session.
        /// </summary>
        public DateTime DateTraining { get; set; }

        /// <summary>
        /// Duration of training session.
        /// </summary>
        public TimeSpan Duration { get; set; }

        /// <summary>
        /// Number of steps per training session.
        /// </summary>
        public int Steps { get; set; }

        /// <summary>
        /// Distance covered in training session.
        /// </summary>
        public double Distance { get; set; }

        /// <summary>
        /// Average pulse per training session.
        /// </summary>
        public int AveragePulsePerTrainingSession { get; set; }

        /// <summary>
        /// Constructor with date training, duration, steps, distance, average pulse per training session parameters.
        /// </summary>
        /// <param name="dateTraining">Year, month and day of training session.</param>
        /// <param name="duration">Duration of training session.</param>
        /// <param name="steps">Number of steps per training session.</param>
        /// <param name="distance">Distance covered in training session.param>
        /// <param name="averagePulsePerTraningSession">Average pulse per training session.</param>
        public Training(DateTime dateTraining, TimeSpan duration, int steps, double distance, int averagePulsePerTraningSession)
        {
            DateTraining = dateTraining;
            Duration = duration;
            Steps = steps;
            Distance = distance;
            AveragePulsePerTrainingSession = averagePulsePerTraningSession;
        }
    }
}

