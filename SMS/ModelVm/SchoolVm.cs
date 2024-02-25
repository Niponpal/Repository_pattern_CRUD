using AutoMapper;
using SMS.Models;

namespace SMS.ModelVm;
[AutoMap(typeof(School),ReverseMap = true)]
public class SchoolVm
{
	public int Id { get; set; }
	public string Name { get; set; }
	public string Age { get; set; }
	public string Address { get; set; }
}
