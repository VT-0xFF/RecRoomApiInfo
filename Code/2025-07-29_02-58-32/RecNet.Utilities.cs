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
		[Cpp2IlInjected.Address(RVA = "0xAAFD40", Offset = "0xAAE740", VA = "0x180AAFD40")]
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
		[Cpp2IlInjected.Address(RVA = "0x80207A0", Offset = "0x801F1A0", VA = "0x1880207A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAB0110", Offset = "0xAAEB10", VA = "0x180AB0110")]
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
		[Cpp2IlInjected.Address(RVA = "0xAB0150", Offset = "0xAAEB50", VA = "0x180AB0150")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum FBPNHGHBDHC
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
public static class DDAEGGEMFBK
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x801DDE0", Offset = "0x801C7E0", VA = "0x18801DDE0")]
	public static string OCCEMMNGJEH(this FBPNHGHBDHC EKLKIKNENMK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x801DD20", Offset = "0x801C720", VA = "0x18801DD20")]
	public static FBPNHGHBDHC IBPPMADOBHF(this BLJOLJHKAJJ ELJAIHHCCMI)
	{
		return default(FBPNHGHBDHC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class GMPMCNDJEEP
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x801ECA0", Offset = "0x801D6A0", VA = "0x18801ECA0")]
	public static GIOIIKMLHND AOPKIMAIOPO(this HttpClient IKLICNGEEME, HttpMethod LOHNFJJANPK, string LLKJIOEIEAO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class PPEFOBGOLHN
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct LHCIMEEOBKO<T> : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x559D840", Offset = "0x559C240", VA = "0x18559D840", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x4E09AB0", Offset = "0x4E084B0", VA = "0x184E09AB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3E9F180", Offset = "0x3E9DB80", VA = "0x183E9F180")]
	[AsyncStateMachine(typeof(LHCIMEEOBKO<>))]
	public static Task<T> ICHCIKJIFND<T>(this HttpContent IDFFODEBDMG, [Optional] JsonSerializerSettings? PPDGPHABJBC, [Optional] CancellationToken OMJKEHOJJFF) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class GIOIIKMLHND
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct GPNJLJMFIOK : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AsyncTaskMethodBuilder<HttpResponseMessage> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public GIOIIKMLHND <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x801F3D0", Offset = "0x801DDD0", VA = "0x18801F3D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x801FA30", Offset = "0x801E430", VA = "0x18801FA30", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct GOHIKJEDLPE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public GIOIIKMLHND <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x801ED80", Offset = "0x801D780", VA = "0x18801ED80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x801F370", Offset = "0x801DD70", VA = "0x18801F370", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct NBBJNAAGBAD<TResult> : IAsyncStateMachine where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public GIOIIKMLHND <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x58A1150", Offset = "0x589FB50", VA = "0x1858A1150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x58A19C0", Offset = "0x58A03C0", VA = "0x1858A19C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct KBPPMFCMCMP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AsyncTaskMethodBuilder<HttpRequestMessage> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public GIOIIKMLHND <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x801FAA0", Offset = "0x801E4A0", VA = "0x18801FAA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8020730", Offset = "0x801F130", VA = "0x188020730", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly HttpMethod LOHNFJJANPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Uri LLKJIOEIEAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private AuthenticationHeaderValue? FKNCCIALJHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private HttpContent? IDFFODEBDMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private List<KeyValuePair<string, string>>? FOENKEOBAED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private List<KeyValuePair<string, string>>? NFHHBLJKDBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private List<(HttpContent content, string key, string filename)>? AFBFNFJKDFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private List<Func<HttpRequestMessage, CancellationToken, Task>>? LFJENLJKKHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private List<KeyValuePair<string, string>>? LOFLCJLPNDL;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public HttpClient CFFKOIGCLEK
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xA84200", Offset = "0xA82C00", VA = "0x180A84200")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x801EC30", Offset = "0x801D630", VA = "0x18801EC30")]
	public GIOIIKMLHND(HttpClient IKLICNGEEME, HttpMethod LOHNFJJANPK, Uri LLKJIOEIEAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x801E680", Offset = "0x801D080", VA = "0x18801E680")]
	public GIOIIKMLHND NBGPPHCKHED(string DFDPFEEKECL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7A82030", Offset = "0x7A80A30", VA = "0x187A82030")]
	public GIOIIKMLHND GPPGAGHAPJN(HttpContent IDFFODEBDMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x801E300", Offset = "0x801CD00", VA = "0x18801E300")]
	public GIOIIKMLHND FEIKLLBNLOP(object PDKJBMPOMNC, [Optional] JsonSerializerSettings? PPDGPHABJBC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x801E420", Offset = "0x801CE20", VA = "0x18801E420")]
	public GIOIIKMLHND GMOCFBFHGIC(string LNBCHJPEENA, string? PDKJBMPOMNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x801E400", Offset = "0x801CE00", VA = "0x18801E400")]
	public GIOIIKMLHND GJKIPNOKPHG(string LNBCHJPEENA, string? PDKJBMPOMNC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x801E500", Offset = "0x801CF00", VA = "0x18801E500")]
	private GIOIIKMLHND GMOCFBFHGIC(string LNBCHJPEENA, string? PDKJBMPOMNC, List<KeyValuePair<string, string>>? HKENEGGNMIM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x801E710", Offset = "0x801D110", VA = "0x18801E710")]
	public GIOIIKMLHND NIFBHEFLKKD(string LNBCHJPEENA, byte[] BBJJIPJJFJP, string FFOJCBOJBOG = "application/octet-stream", string PNIDKKDGNMJ = "file.bin")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x801E800", Offset = "0x801D200", VA = "0x18801E800")]
	public GIOIIKMLHND NIFBHEFLKKD(string LNBCHJPEENA, HttpContent BBJJIPJJFJP, string PNIDKKDGNMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x801DF80", Offset = "0x801C980", VA = "0x18801DF80")]
	public Task<HttpResponseMessage> ADIIBEACIOD([Optional] CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x801DF90", Offset = "0x801C990", VA = "0x18801DF90")]
	[AsyncStateMachine(typeof(GPNJLJMFIOK))]
	public Task<HttpResponseMessage> ADIIBEACIOD(HttpCompletionOption NAKELOBKDLN, [Optional] CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x801E0D0", Offset = "0x801CAD0", VA = "0x18801E0D0")]
	[AsyncStateMachine(typeof(GOHIKJEDLPE))]
	public Task ANNLDOFLANA([Optional] CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3C696F0", Offset = "0x3C680F0", VA = "0x183C696F0")]
	[AsyncStateMachine(typeof(NBBJNAAGBAD<>))]
	public Task<TResult?>? JIPKMCNGNBH<TResult>([Optional] JsonSerializerSettings? PPDGPHABJBC, [Optional] CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x801E1D0", Offset = "0x801CBD0", VA = "0x18801E1D0")]
	[AsyncStateMachine(typeof(KBPPMFCMCMP))]
	internal Task<HttpRequestMessage> BNHDINMFIMO(CancellationToken OMJKEHOJJFF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x801EA70", Offset = "0x801D470", VA = "0x18801EA70")]
	private Uri NJNAIKGJEEP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class BMDDPLNAGEK
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct PCIEFFGILFC : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x8020820", Offset = "0x801F220", VA = "0x188020820", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8020C10", Offset = "0x801F610", VA = "0x188020C10", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x801DC00", Offset = "0x801C600", VA = "0x18801DC00")]
	[AsyncStateMachine(typeof(PCIEFFGILFC))]
	public static Task<HttpResponseMessage> BNAKKDIPCEN(this HttpResponseMessage FNAGPCFFJAJ, [Optional] CancellationToken OMJKEHOJJFF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class BKJOBIPCFFN : StringContent
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x801DB60", Offset = "0x801C560", VA = "0x18801DB60")]
	public BKJOBIPCFFN(object PDKJBMPOMNC, JsonSerializerSettings? PPDGPHABJBC)
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
