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
		[Cpp2IlInjected.Address(RVA = "0xA98EF0", Offset = "0xA982F0", VA = "0x180A98EF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7FBECB0", Offset = "0x7FBE0B0", VA = "0x187FBECB0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA99B00", Offset = "0xA98F00", VA = "0x180A99B00")]
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
		[Cpp2IlInjected.Address(RVA = "0xA99B40", Offset = "0xA98F40", VA = "0x180A99B40")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum AFAHMMHICON
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
public static class NCPJBIMANHG
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7FBEB10", Offset = "0x7FBDF10", VA = "0x187FBEB10")]
	public static string JHGNFHMGBPH(this AFAHMMHICON ABIJIHOCFPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x7FBEA50", Offset = "0x7FBDE50", VA = "0x187FBEA50")]
	public static AFAHMMHICON DLENOOODBJO(this IFBOGFAMLLP LICDBMNOJOB)
	{
		return default(AFAHMMHICON);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class JFNDODJJHHG
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x7FBD810", Offset = "0x7FBCC10", VA = "0x187FBD810")]
	public static GBFDGGLKPAM EMGOBIMNIED(this HttpClient NNCNEAEPODD, HttpMethod GAAAFGHGFFJ, string FDLFPIGANJG)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class LGGEBOBOMIH
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct NDDIBKPPKNK<T> : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x57EDBA0", Offset = "0x57ECFA0", VA = "0x1857EDBA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x49B6E60", Offset = "0x49B6260", VA = "0x1849B6E60", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3DA68D0", Offset = "0x3DA5CD0", VA = "0x183DA68D0")]
	[AsyncStateMachine(typeof(NDDIBKPPKNK<>))]
	public static Task<T> JHMLHNPIIDF<T>(this HttpContent FIABIJABAGB, [Optional] JsonSerializerSettings? OFPKJPDCHHF, [Optional] CancellationToken GMKBGHHNCDJ) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class GBFDGGLKPAM
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct BJDCFMNKJJA : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AsyncTaskMethodBuilder<HttpResponseMessage> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public GBFDGGLKPAM <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x7FBBD40", Offset = "0x7FBB140", VA = "0x187FBBD40", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x7FBC3A0", Offset = "0x7FBB7A0", VA = "0x187FBC3A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct GOEKJKPCCEM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public GBFDGGLKPAM <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x7FBD1C0", Offset = "0x7FBC5C0", VA = "0x187FBD1C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x7FBD7B0", Offset = "0x7FBCBB0", VA = "0x187FBD7B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct LCPDIBNCJPD<TResult> : IAsyncStateMachine where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public GBFDGGLKPAM <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x54F4470", Offset = "0x54F3870", VA = "0x1854F4470", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x54F4CB0", Offset = "0x54F40B0", VA = "0x1854F4CB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct LLKAKNOLEMG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AsyncTaskMethodBuilder<HttpRequestMessage> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public GBFDGGLKPAM <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x7FBD8F0", Offset = "0x7FBCCF0", VA = "0x187FBD8F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x7FBE580", Offset = "0x7FBD980", VA = "0x187FBE580", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly HttpMethod GAAAFGHGFFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Uri FDLFPIGANJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private AuthenticationHeaderValue? PIOPHJHFAEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private HttpContent? FIABIJABAGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private List<KeyValuePair<string, string>>? FGKLNOPOCMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private List<KeyValuePair<string, string>>? GNEHPCBGMGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private List<(HttpContent content, string key, string filename)>? EAPCHGCPPJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private List<Func<HttpRequestMessage, CancellationToken, Task>>? AFDLJIJANPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private List<KeyValuePair<string, string>>? CNDBCDLFCHH;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public HttpClient POPKDEEFOBH
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA703D0", Offset = "0xA6F7D0", VA = "0x180A703D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7FBD150", Offset = "0x7FBC550", VA = "0x187FBD150")]
	public GBFDGGLKPAM(HttpClient NNCNEAEPODD, HttpMethod GAAAFGHGFFJ, Uri FDLFPIGANJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7FBC790", Offset = "0x7FBBB90", VA = "0x187FBC790")]
	public GBFDGGLKPAM FKLEHBEIFBF(string JAILOANDNDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7A1BAC0", Offset = "0x7A1AEC0", VA = "0x187A1BAC0")]
	public GBFDGGLKPAM LKGBLAMFNHF(HttpContent FIABIJABAGB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x7FBC4B0", Offset = "0x7FBB8B0", VA = "0x187FBC4B0")]
	public GBFDGGLKPAM DAABBLCPPCL(object CBMEHPPMEEA, [Optional] JsonSerializerSettings? OFPKJPDCHHF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x7FBD070", Offset = "0x7FBC470", VA = "0x187FBD070")]
	public GBFDGGLKPAM NKEDNNHJMLH(string PEENICAIFOP, string? CBMEHPPMEEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x7FBC770", Offset = "0x7FBBB70", VA = "0x187FBC770")]
	public GBFDGGLKPAM EHODPMBEMNA(string PEENICAIFOP, string? CBMEHPPMEEA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x7FBCEF0", Offset = "0x7FBC2F0", VA = "0x187FBCEF0")]
	private GBFDGGLKPAM NKEDNNHJMLH(string PEENICAIFOP, string? CBMEHPPMEEA, List<KeyValuePair<string, string>>? FGEMBJJOPFK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x7FBCA70", Offset = "0x7FBBE70", VA = "0x187FBCA70")]
	public GBFDGGLKPAM KKHJHBOKPKP(string PEENICAIFOP, byte[] HBDAAHJCJEL, string DIHHNMIGGCD = "application/octet-stream", string AFMPILNIBJI = "file.bin")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x7FBCB60", Offset = "0x7FBBF60", VA = "0x187FBCB60")]
	public GBFDGGLKPAM KKHJHBOKPKP(string PEENICAIFOP, HttpContent HBDAAHJCJEL, string AFMPILNIBJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x7FBC820", Offset = "0x7FBBC20", VA = "0x187FBC820")]
	public Task<HttpResponseMessage> GEDGBPHOLMC([Optional] CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x7FBC830", Offset = "0x7FBBC30", VA = "0x187FBC830")]
	[AsyncStateMachine(typeof(BJDCFMNKJJA))]
	public Task<HttpResponseMessage> GEDGBPHOLMC(HttpCompletionOption ENJHHIKFKDF, [Optional] CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x7FBC970", Offset = "0x7FBBD70", VA = "0x187FBC970")]
	[AsyncStateMachine(typeof(GOEKJKPCCEM))]
	public Task HPHJMFIMBEA([Optional] CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3CAFBF0", Offset = "0x3CAEFF0", VA = "0x183CAFBF0")]
	[AsyncStateMachine(typeof(LCPDIBNCJPD<>))]
	public Task<TResult?>? OJOHFBKGCGF<TResult>([Optional] JsonSerializerSettings? OFPKJPDCHHF, [Optional] CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7FBCDC0", Offset = "0x7FBC1C0", VA = "0x187FBCDC0")]
	[AsyncStateMachine(typeof(LLKAKNOLEMG))]
	internal Task<HttpRequestMessage> LMBCLFPEICI(CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x7FBC5B0", Offset = "0x7FBB9B0", VA = "0x187FBC5B0")]
	private Uri DKLPNLPHFDP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class PIIMBEAPBFB
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct MHGMGNDFOMF : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x7FBE5F0", Offset = "0x7FBD9F0", VA = "0x187FBE5F0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x7FBE9E0", Offset = "0x7FBDDE0", VA = "0x187FBE9E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x7FBED30", Offset = "0x7FBE130", VA = "0x187FBED30")]
	[AsyncStateMachine(typeof(MHGMGNDFOMF))]
	public static Task<HttpResponseMessage> EOCLIAJBKBK(this HttpResponseMessage HGHNDNAANCF, [Optional] CancellationToken GMKBGHHNCDJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class FFAALDKPJEG : StringContent
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x7FBC410", Offset = "0x7FBB810", VA = "0x187FBC410")]
	public FFAALDKPJEG(object CBMEHPPMEEA, JsonSerializerSettings? OFPKJPDCHHF)
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
