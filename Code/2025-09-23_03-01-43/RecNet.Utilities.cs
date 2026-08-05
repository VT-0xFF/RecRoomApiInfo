using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using Newtonsoft.Json;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xAD1210", Offset = "0xACF810", VA = "0x180AD1210")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x81F7740", Offset = "0x81F5D40", VA = "0x1881F7740")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAD1900", Offset = "0xACFF00", VA = "0x180AD1900")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAD1940", Offset = "0xACFF40", VA = "0x180AD1940")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum JFFGBMAEAOJ
{
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	ImageJpg,
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	ImagePng,
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	VideoMp4,
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	BinaryData,
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	Json,
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	PlainText,
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	AudioWav
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public static class OMICGEAEANL
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x81F7960", Offset = "0x81F5F60", VA = "0x1881F7960")]
	public static string JHOBHKONENF(this JFFGBMAEAOJ DBAKOFGJILA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x81F78A0", Offset = "0x81F5EA0", VA = "0x1881F78A0")]
	public static JFFGBMAEAOJ GICHAKNCIMB(this ILDLMICPCMD HOMFLHPMAPN)
	{
		return default(JFFGBMAEAOJ);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class OEFBAHPMLKH
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x81F77C0", Offset = "0x81F5DC0", VA = "0x1881F77C0")]
	public static PHHIDFBEGEA CADFPNHJPMJ(this HttpClient FNFIGLJIFKM, HttpMethod HEPPOGGJMKL, string JHDBGOHNHCI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class KFFKPEIFHAD
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct NLCIPLNHLEA<T> : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public AsyncTaskMethodBuilder<T> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public HttpContent content;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public JsonSerializerSettings serializerSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		private ConfiguredTaskAwaitable<string>.ConfiguredTaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5A8CEB0", Offset = "0x5A8B4B0", VA = "0x185A8CEB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x467FED0", Offset = "0x467E4D0", VA = "0x18467FED0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3EA0D10", Offset = "0x3E9F310", VA = "0x183EA0D10")]
	[AsyncStateMachine(typeof(NLCIPLNHLEA<>))]
	public static Task<T> LCDLJIBELOE<T>(this HttpContent ABFDFMCKGAK, [Optional] JsonSerializerSettings? IJIFLDLCHJF, [Optional] CancellationToken PJCIHHKJKBP) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class PHHIDFBEGEA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct MEGECMDBJEG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AsyncTaskMethodBuilder<HttpResponseMessage> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public PHHIDFBEGEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public HttpCompletionOption httpCompletionOption;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private HttpRequestMessage <request>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private ConfiguredTaskAwaitable<HttpRequestMessage>.ConfiguredTaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x81F6FD0", Offset = "0x81F55D0", VA = "0x1881F6FD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x81F7630", Offset = "0x81F5C30", VA = "0x1881F7630", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct GKECPIALACI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public PHHIDFBEGEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private HttpResponseMessage <response>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		private ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private TaskAwaiter<HttpResponseMessage> <>u__2;

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0x81F6860", Offset = "0x81F4E60", VA = "0x1881F6860", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x81F6E50", Offset = "0x81F5450", VA = "0x1881F6E50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct EOKFNHCLFKC<TResult> : IAsyncStateMachine where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public PHHIDFBEGEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		public JsonSerializerSettings serializerSettings;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private HttpResponseMessage <response>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private TaskAwaiter<HttpResponseMessage> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter <>u__3;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x4B720D0", Offset = "0x4B706D0", VA = "0x184B720D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x4B72940", Offset = "0x4B70F40", VA = "0x184B72940", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct FHHLCNJIPDK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AsyncTaskMethodBuilder<HttpRequestMessage> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public PHHIDFBEGEA <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private HttpRequestMessage <message>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private List<Func<HttpRequestMessage, CancellationToken, Task>>.Enumerator <>7__wrap2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x81F5B60", Offset = "0x81F4160", VA = "0x1881F5B60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x81F67F0", Offset = "0x81F4DF0", VA = "0x1881F67F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly HttpMethod HEPPOGGJMKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Uri JHDBGOHNHCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private AuthenticationHeaderValue? BGKIFKOHNPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private HttpContent? ABFDFMCKGAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private List<KeyValuePair<string, string>>? ECBMGGLGOGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private List<KeyValuePair<string, string>>? HILJPNDGMDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private List<(HttpContent content, string key, string filename)>? EGBODGKKNMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private List<Func<HttpRequestMessage, CancellationToken, Task>>? PMOMLBPCBEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private List<KeyValuePair<string, string>>? ALGLFOIFDIC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public HttpClient ABECJOFHLAN
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xAA54C0", Offset = "0xAA3AC0", VA = "0x180AA54C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x81F87B0", Offset = "0x81F6DB0", VA = "0x1881F87B0")]
	public PHHIDFBEGEA(HttpClient FNFIGLJIFKM, HttpMethod HEPPOGGJMKL, Uri JHDBGOHNHCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x81F84D0", Offset = "0x81F6AD0", VA = "0x1881F84D0")]
	public PHHIDFBEGEA MJNCBCANOFI(string LCNMLAGPIDO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7C47250", Offset = "0x7C45850", VA = "0x187C47250")]
	public PHHIDFBEGEA CMOOLHPIPNL(HttpContent ABFDFMCKGAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x81F86B0", Offset = "0x81F6CB0", VA = "0x1881F86B0")]
	public PHHIDFBEGEA NGAIPLCMHCI(object KOPHBHGIACG, [Optional] JsonSerializerSettings? IJIFLDLCHJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x81F82F0", Offset = "0x81F68F0", VA = "0x1881F82F0")]
	public PHHIDFBEGEA DHMEIOGFIEB(string HAELBKGFDIJ, string? KOPHBHGIACG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x81F7E60", Offset = "0x81F6460", VA = "0x1881F7E60")]
	public PHHIDFBEGEA AFGLEAJPPEC(string HAELBKGFDIJ, string? KOPHBHGIACG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x81F8170", Offset = "0x81F6770", VA = "0x1881F8170")]
	private PHHIDFBEGEA DHMEIOGFIEB(string HAELBKGFDIJ, string? KOPHBHGIACG, List<KeyValuePair<string, string>>? ENMBHGMENHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x81F7B00", Offset = "0x81F6100", VA = "0x1881F7B00")]
	public PHHIDFBEGEA ACHIDHMIDIC(string HAELBKGFDIJ, byte[] IAPOIIAAALB, string LKJGPFCBCJG = "application/octet-stream", string GDCFOAHKBOL = "file.bin")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x81F7BF0", Offset = "0x81F61F0", VA = "0x1881F7BF0")]
	public PHHIDFBEGEA ACHIDHMIDIC(string HAELBKGFDIJ, HttpContent IAPOIIAAALB, string GDCFOAHKBOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x81F86A0", Offset = "0x81F6CA0", VA = "0x1881F86A0")]
	public Task<HttpResponseMessage> MLFKDKBAAFJ([Optional] CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x81F8560", Offset = "0x81F6B60", VA = "0x1881F8560")]
	[AsyncStateMachine(typeof(MEGECMDBJEG))]
	public Task<HttpResponseMessage> MLFKDKBAAFJ(HttpCompletionOption LGMEGKOEADD, [Optional] CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x81F83D0", Offset = "0x81F69D0", VA = "0x1881F83D0")]
	[AsyncStateMachine(typeof(GKECPIALACI))]
	public Task IOPBDDGDHFG([Optional] CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3F95530", Offset = "0x3F93B30", VA = "0x183F95530")]
	[AsyncStateMachine(typeof(EOKFNHCLFKC<>))]
	public Task<TResult?>? FBGOAOIAOOB<TResult>([Optional] JsonSerializerSettings? IJIFLDLCHJF, [Optional] CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x81F7E80", Offset = "0x81F6480", VA = "0x1881F7E80")]
	[AsyncStateMachine(typeof(FHHLCNJIPDK))]
	internal Task<HttpRequestMessage> BNDLNAEOJDO(CancellationToken PJCIHHKJKBP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x81F7FB0", Offset = "0x81F65B0", VA = "0x1881F7FB0")]
	private Uri COMNHDDPPCK()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class JBCKDAEGPCO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct AHJLOKENLMO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public AsyncTaskMethodBuilder<HttpResponseMessage> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public HttpResponseMessage response;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public CancellationToken cancellationToken;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private string <errorDetails>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TaskAwaiter<string> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x81F5700", Offset = "0x81F3D00", VA = "0x1881F5700", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x81F5AF0", Offset = "0x81F40F0", VA = "0x1881F5AF0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x81F6EB0", Offset = "0x81F54B0", VA = "0x1881F6EB0")]
	[AsyncStateMachine(typeof(AHJLOKENLMO))]
	public static Task<HttpResponseMessage> BKEDFIOBNEO(this HttpResponseMessage JIEFFLNKFPC, [Optional] CancellationToken PJCIHHKJKBP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class MILFLKIJBBM : StringContent
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x81F76A0", Offset = "0x81F5CA0", VA = "0x1881F76A0")]
	public MILFLKIJBBM(object KOPHBHGIACG, JsonSerializerSettings? IJIFLDLCHJF)
	{
	}
}
namespace Cpp2IlInjected
{
	internal class AddressAttribute : Attribute
	{
		public string RVA;

		public string Offset;

		public string VA;

		public string Slot;
	}
	internal class FieldOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class AttributeAttribute : Attribute
	{
		public string Name;

		public string RVA;

		public string Offset;
	}
	internal class MetadataOffsetAttribute : Attribute
	{
		public string Offset;
	}
	internal class TokenAttribute : Attribute
	{
		public string Token;
	}
	internal class AnalysisFailedException : Exception
	{
		public AnalysisFailedException(string message)
			: base(message)
		{
		}
	}
}
