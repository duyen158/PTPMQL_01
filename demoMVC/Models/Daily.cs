namespace demoMVC.Models;

public class Daily
{
    public string? MaDaiLy  { get; set;}
    public string? TenDaiLy { get; set;}
    public string? Diachi { get; set;}
    public string? NguoiDaiDien { get; set;}
    public string? DienThoai { get; set;}
    public string? MaHTTP { get; set;}

    //Optionl:Relationship with HeThongPhanPhoi class
    public required HeThongPhanPhoi HeThongPhanphoi{ get; set;}
    
}
