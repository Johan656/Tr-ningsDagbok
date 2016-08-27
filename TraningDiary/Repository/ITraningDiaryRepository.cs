using System.Collections.Generic;
using TraningDiary.Models;

namespace TraningDiary.Repository
{
    public interface ITraningDiaryRepository
    {
        IEnumerable<Workout> getAllWorkout();
        void addWorkout(Workout newWorkout);
        bool saveAll();
        IEnumerable<Workout> getUserWorkouts(string name);
        Workout getWorkoutById(int id);
        IEnumerable<WorkoutType> getAllWorkoutTypes();
    }
}