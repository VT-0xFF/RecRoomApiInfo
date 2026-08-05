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
		[Cpp2IlInjected.Address(RVA = "0xABED60", Offset = "0xABDB60", VA = "0x180ABED60")]
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
		[Cpp2IlInjected.Address(RVA = "0x809D210", Offset = "0x809C010", VA = "0x18809D210")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xABFA20", Offset = "0xABE820", VA = "0x180ABFA20")]
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
		[Cpp2IlInjected.Address(RVA = "0xABFA60", Offset = "0xABE860", VA = "0x180ABFA60")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum DOCMGFAFKBE
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
public static class FDPCODBFFPP
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x809A460", Offset = "0x8099260", VA = "0x18809A460")]
	public static string PHMPHGAMBJE(this DOCMGFAFKBE DPDAOJBIEFI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x809A3A0", Offset = "0x80991A0", VA = "0x18809A3A0")]
	public static DOCMGFAFKBE DJNPPCOGPKF(this GMLMPPOPKLD OMNHLLDGHHG)
	{
		return default(DOCMGFAFKBE);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class PKCLGPEAGFL
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x809D290", Offset = "0x809C090", VA = "0x18809D290")]
	public static LHPAAKFFLOC GIJADDNPOJG(this HttpClient CHKHFLBDKJA, HttpMethod BBGEIKGKENC, string PBNGNOCJKEC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class CGJANFHDPJK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct BDBOAPAGBLJ<T> : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x6600920", Offset = "0x65FF720", VA = "0x186600920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x4A52F70", Offset = "0x4A51D70", VA = "0x184A52F70", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3B0A3B0", Offset = "0x3B091B0", VA = "0x183B0A3B0")]
	[AsyncStateMachine(typeof(BDBOAPAGBLJ<>))]
	public static Task<T> GJAAFPILBKG<T>(this HttpContent BOGIEKLHADD, [Optional] JsonSerializerSettings? BFKMDIDPNOG, [Optional] CancellationToken BKHGNHANFKK) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class LHPAAKFFLOC
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct KIPMAMOAOED : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AsyncTaskMethodBuilder<HttpResponseMessage> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public LHPAAKFFLOC <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x809AA60", Offset = "0x8099860", VA = "0x18809AA60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x809B0C0", Offset = "0x8099EC0", VA = "0x18809B0C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct NJNGDNPHBCH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public LHPAAKFFLOC <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x809CBC0", Offset = "0x809B9C0", VA = "0x18809CBC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x809D1B0", Offset = "0x809BFB0", VA = "0x18809D1B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct CELDMDDCEKK<TResult> : IAsyncStateMachine where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public LHPAAKFFLOC <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x6C63D60", Offset = "0x6C62B60", VA = "0x186C63D60", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x6C645D0", Offset = "0x6C633D0", VA = "0x186C645D0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct LEPDHNFDDID : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AsyncTaskMethodBuilder<HttpRequestMessage> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public LHPAAKFFLOC <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x809B130", Offset = "0x8099F30", VA = "0x18809B130", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x809BDB0", Offset = "0x809ABB0", VA = "0x18809BDB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly HttpMethod BBGEIKGKENC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Uri PBNGNOCJKEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private AuthenticationHeaderValue? FJNHKOGEKNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private HttpContent? BOGIEKLHADD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private List<KeyValuePair<string, string>>? GGDBOMBPLMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private List<KeyValuePair<string, string>>? EAMMIPPAKDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private List<(HttpContent content, string key, string filename)>? PMLOMEEBJIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private List<Func<HttpRequestMessage, CancellationToken, Task>>? HJGKCDLGBPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private List<KeyValuePair<string, string>>? DLAFAFOBMAM;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public HttpClient GFBEAAEANKP
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA931F0", Offset = "0xA91FF0", VA = "0x180A931F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x809CAB0", Offset = "0x809B8B0", VA = "0x18809CAB0")]
	public LHPAAKFFLOC(HttpClient CHKHFLBDKJA, HttpMethod BBGEIKGKENC, Uri PBNGNOCJKEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x809C0D0", Offset = "0x809AED0", VA = "0x18809C0D0")]
	public LHPAAKFFLOC FHJPHGHMPGK(string IAKBAIDHBCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7B04EA0", Offset = "0x7B03CA0", VA = "0x187B04EA0")]
	public LHPAAKFFLOC ECPEGPHOCFH(HttpContent BOGIEKLHADD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x809C730", Offset = "0x809B530", VA = "0x18809C730")]
	public LHPAAKFFLOC KAAPNMFLHJA(object HGMAIPELJHM, [Optional] JsonSerializerSettings? BFKMDIDPNOG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x809C2E0", Offset = "0x809B0E0", VA = "0x18809C2E0")]
	public LHPAAKFFLOC GDAOJGFBGMK(string OPGJHIOADCK, string? HGMAIPELJHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x809C710", Offset = "0x809B510", VA = "0x18809C710")]
	public LHPAAKFFLOC HFGKOILJOGI(string OPGJHIOADCK, string? HGMAIPELJHM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x809C160", Offset = "0x809AF60", VA = "0x18809C160")]
	private LHPAAKFFLOC GDAOJGFBGMK(string OPGJHIOADCK, string? HGMAIPELJHM, List<KeyValuePair<string, string>>? ONHEEOKCMKO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x809C620", Offset = "0x809B420", VA = "0x18809C620")]
	public LHPAAKFFLOC GFBIFMCNBMF(string OPGJHIOADCK, byte[] JELGJMCEDHK, string POHGMBGHJPO = "application/octet-stream", string GJJBKNNMHFP = "file.bin")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x809C3C0", Offset = "0x809B1C0", VA = "0x18809C3C0")]
	public LHPAAKFFLOC GFBIFMCNBMF(string OPGJHIOADCK, HttpContent JELGJMCEDHK, string GJJBKNNMHFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x809C830", Offset = "0x809B630", VA = "0x18809C830")]
	public Task<HttpResponseMessage> NKEMECCLEAL([Optional] CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x809C840", Offset = "0x809B640", VA = "0x18809C840")]
	[AsyncStateMachine(typeof(KIPMAMOAOED))]
	public Task<HttpResponseMessage> NKEMECCLEAL(HttpCompletionOption NJFIALKAGPF, [Optional] CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x809BFD0", Offset = "0x809ADD0", VA = "0x18809BFD0")]
	[AsyncStateMachine(typeof(NJNGDNPHBCH))]
	public Task CHINHFBABIF([Optional] CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3DC9680", Offset = "0x3DC8480", VA = "0x183DC9680")]
	[AsyncStateMachine(typeof(CELDMDDCEKK<>))]
	public Task<TResult?>? LNHOGJNKFHH<TResult>([Optional] JsonSerializerSettings? BFKMDIDPNOG, [Optional] CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x809C980", Offset = "0x809B780", VA = "0x18809C980")]
	[AsyncStateMachine(typeof(LEPDHNFDDID))]
	internal Task<HttpRequestMessage> PGENFBENOOF(CancellationToken BKHGNHANFKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x809BE20", Offset = "0x809AC20", VA = "0x18809BE20")]
	private Uri AMIIPLPMJLJ()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class DHMLHPJLJNL
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct GHCMJCOEGMF : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x809A600", Offset = "0x8099400", VA = "0x18809A600", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x809A9F0", Offset = "0x80997F0", VA = "0x18809A9F0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x809A280", Offset = "0x8099080", VA = "0x18809A280")]
	[AsyncStateMachine(typeof(GHCMJCOEGMF))]
	public static Task<HttpResponseMessage> KEOIEGLNMIF(this HttpResponseMessage PNCENNMICLF, [Optional] CancellationToken BKHGNHANFKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class MADOOAFNKDI : StringContent
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x809CB20", Offset = "0x809B920", VA = "0x18809CB20")]
	public MADOOAFNKDI(object HGMAIPELJHM, JsonSerializerSettings? BFKMDIDPNOG)
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
