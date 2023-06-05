namespace StopWatch;

public class StopWatch
{
    //Trường startTime và endTime là private với phương thức getter để trả về giá trị của startTime và endTime.
    public DateTime _startTime;
    public DateTime _endTime;
    
    public DateTime StartTime
    {
        get => _startTime;
    }
    public DateTime EndTime
    {
        get => _endTime;
    }
    //Phương thức khởi tạo không tham số khởi tạo startTime với thời gian hiện tại của hệ thống.
    public StopWatch()
    {
        _startTime = DateTime.Now;
    }
    //Phương thức Start() để reset startTime về thời gian hiện tại của hệ thống.
    public void Start()
    {
        _startTime = DateTime.Now;
    }
    //Phương thức Stop() để thiết đặt endTime về thời gian hiện tại của hệ thống.
    public void Stop()
    {
        _endTime = DateTime.Now;
    }
    //Phương thức GetElapsedTime() trả về thời gian đã trôi qua theo số milisecond giây
    public double GetElapsedTime()
    {
        return (_endTime - _startTime).TotalMilliseconds;
    }
}