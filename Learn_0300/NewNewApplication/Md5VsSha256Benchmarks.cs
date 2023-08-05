namespace Application;

public class Md5VsSha256Benchmarks
{
	private System.Security.Cryptography.MD5
		md5 = System.Security.Cryptography.MD5.Create();

	private System.Security.Cryptography.SHA256
		sha256 = System.Security.Cryptography.SHA256.Create();

	private byte[] data;

	[BenchmarkDotNet.Attributes.Params(1_000, 10_000)]
	public int N;

	[BenchmarkDotNet.Attributes.GlobalSetup]
	public void Setup()
	{
		data = new byte[N];
		new System.Random(42).NextBytes(data);
	}

	[BenchmarkDotNet.Attributes.Benchmark]
	public byte[] Md5()
	{
		var result =
			md5.ComputeHash(buffer: data);

		return result;
	}

	[BenchmarkDotNet.Attributes.Benchmark]
	public byte[] Sha256()
	{
		var result =
			sha256.ComputeHash(buffer: data);

		return result;
	}
}
