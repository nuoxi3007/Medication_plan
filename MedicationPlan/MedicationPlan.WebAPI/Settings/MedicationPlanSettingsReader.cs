namespace MedicationPlan.WebAPI.Settings
{
    public class MedicationPlanSettingsReader
    {
        public static MedicationPlanSettings Read(IConfiguration configuration)
        {
            return new MedicationPlanSettings();
        }
    }
}