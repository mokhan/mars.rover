namespace mars.rover
{
    public interface CaptureUserInstructionsView
    {
        void attach_to(CaptureUserInstructionsPresenter presenter);
        void display(uint coordinate, uint coordinate1, string heading);
    }
}