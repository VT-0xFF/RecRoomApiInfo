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
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x81EDBD0", Offset = "0x81EC5D0", VA = "0x1881EDBD0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAD85C0", Offset = "0xAD6FC0", VA = "0x180AD85C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAD8600", Offset = "0xAD7000", VA = "0x180AD8600")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public enum KFDMCGCIAFG
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
public static class PMCJILFCDED
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x81EEB00", Offset = "0x81ED500", VA = "0x1881EEB00")]
	public static string KFLGLIJMBPP(this KFDMCGCIAFG DJPFGOODJDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x81EEA40", Offset = "0x81ED440", VA = "0x1881EEA40")]
	public static KFDMCGCIAFG DEBALKOOFBF(this FCCFPIBEKCB OEPPACJBABC)
	{
		return default(KFDMCGCIAFG);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class OBPBLEABPCI
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x81EDC50", Offset = "0x81EC650", VA = "0x1881EDC50")]
	public static OIMFGMENEBO KHPELAGNFJE(this HttpClient PCEAHCAFAIF, HttpMethod PECFHCNLPEO, string CPNBOGANGLJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public static class CFHGDOPMHEF
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	[CompilerGenerated]
	private struct OEHFCMKHBIL<T> : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x5BA3150", Offset = "0x5BA1B50", VA = "0x185BA3150", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x4B31420", Offset = "0x4B2FE20", VA = "0x184B31420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000008")]
	[Cpp2IlInjected.Address(RVA = "0x3B88BA0", Offset = "0x3B875A0", VA = "0x183B88BA0")]
	[AsyncStateMachine(typeof(OEHFCMKHBIL<>))]
	public static Task<T> LANKPGOPBEK<T>(this HttpContent OCMMOIEMDPA, [Optional] JsonSerializerSettings? MEPOIADFLKK, [Optional] CancellationToken AHOMALKMHKK) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public class OIMFGMENEBO
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	[CompilerGenerated]
	private struct GAKHJGMAFNP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public AsyncTaskMethodBuilder<HttpResponseMessage> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public OIMFGMENEBO <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x81EC110", Offset = "0x81EAB10", VA = "0x1881EC110", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(RVA = "0x81EC770", Offset = "0x81EB170", VA = "0x1881EC770", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private struct HFIDBIGANCM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public OIMFGMENEBO <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x81ED4E0", Offset = "0x81EBEE0", VA = "0x1881ED4E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600001E")]
		[Cpp2IlInjected.Address(RVA = "0x81EDAD0", Offset = "0x81EC4D0", VA = "0x1881EDAD0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[CompilerGenerated]
	private struct GENFOMGCIFB<TResult> : IAsyncStateMachine where TResult : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public AsyncTaskMethodBuilder<TResult> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public OIMFGMENEBO <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x5126970", Offset = "0x5125370", VA = "0x185126970", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x51271E0", Offset = "0x5125BE0", VA = "0x1851271E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[CompilerGenerated]
	private struct HDFMMLAPBMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public AsyncTaskMethodBuilder<HttpRequestMessage> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public OIMFGMENEBO <>4__this;

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
		[Cpp2IlInjected.Address(RVA = "0x81EC7E0", Offset = "0x81EB1E0", VA = "0x1881EC7E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x81ED470", Offset = "0x81EBE70", VA = "0x1881ED470", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	private readonly HttpMethod PECFHCNLPEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Uri CPNBOGANGLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	private AuthenticationHeaderValue? CLMICCNGAJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	private HttpContent? OCMMOIEMDPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	private List<KeyValuePair<string, string>>? EEHAFEDANGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private List<KeyValuePair<string, string>>? EPAKAAOPACA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private List<(HttpContent content, string key, string filename)>? HDGBEGHGIMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private List<Func<HttpRequestMessage, CancellationToken, Task>>? EKOAOPNPCFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private List<KeyValuePair<string, string>>? GKCHNJHLJCC;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public HttpClient CHILCJHNCOM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0xAB4840", Offset = "0xAB3240", VA = "0x180AB4840")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x81EE9D0", Offset = "0x81ED3D0", VA = "0x1881EE9D0")]
	public OIMFGMENEBO(HttpClient PCEAHCAFAIF, HttpMethod PECFHCNLPEO, Uri CPNBOGANGLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x81EE920", Offset = "0x81ED320", VA = "0x1881EE920")]
	public OIMFGMENEBO MJEHNHOOIGB(string OEPOLFGFKOO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x7C40B40", Offset = "0x7C3F540", VA = "0x187C40B40")]
	public OIMFGMENEBO KNMMAKBMBHA(HttpContent OCMMOIEMDPA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x81EDD30", Offset = "0x81EC730", VA = "0x1881EDD30")]
	public OIMFGMENEBO DPALPKLFOMP(object KMAFNKGMDCF, [Optional] JsonSerializerSettings? MEPOIADFLKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x81EE170", Offset = "0x81ECB70", VA = "0x1881EE170")]
	public OIMFGMENEBO IPMICMONIHN(string HPFHOBCPNEF, string? KMAFNKGMDCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x81EE9B0", Offset = "0x81ED3B0", VA = "0x1881EE9B0")]
	public OIMFGMENEBO PDCIPELHEAD(string HPFHOBCPNEF, string? KMAFNKGMDCF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x81EDFF0", Offset = "0x81EC9F0", VA = "0x1881EDFF0")]
	private OIMFGMENEBO IPMICMONIHN(string HPFHOBCPNEF, string? KMAFNKGMDCF, List<KeyValuePair<string, string>>? PDCLAJMPOEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x81EE3A0", Offset = "0x81ECDA0", VA = "0x1881EE3A0")]
	public OIMFGMENEBO LHLAFOKBNEH(string HPFHOBCPNEF, byte[] ANDDNFJKBAJ, string DADKMEEKPHO = "application/octet-stream", string LJJHGOFCFDE = "file.bin")
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x81EE490", Offset = "0x81ECE90", VA = "0x1881EE490")]
	public OIMFGMENEBO LHLAFOKBNEH(string HPFHOBCPNEF, HttpContent ANDDNFJKBAJ, string LJJHGOFCFDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x81EE390", Offset = "0x81ECD90", VA = "0x1881EE390")]
	public Task<HttpResponseMessage> KOPIFEECILM([Optional] CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x81EE250", Offset = "0x81ECC50", VA = "0x1881EE250")]
	[AsyncStateMachine(typeof(GAKHJGMAFNP))]
	public Task<HttpResponseMessage> KOPIFEECILM(HttpCompletionOption ODHKGNNLHMB, [Optional] CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x81EE820", Offset = "0x81ED220", VA = "0x1881EE820")]
	[AsyncStateMachine(typeof(HFIDBIGANCM))]
	public Task LPAINOJDCGG([Optional] CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x3F4DDB0", Offset = "0x3F4C7B0", VA = "0x183F4DDB0")]
	[AsyncStateMachine(typeof(GENFOMGCIFB<>))]
	public Task<TResult?>? GICFHFMEHLN<TResult>([Optional] JsonSerializerSettings? MEPOIADFLKK, [Optional] CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x81EE6F0", Offset = "0x81ED0F0", VA = "0x1881EE6F0")]
	[AsyncStateMachine(typeof(HDFMMLAPBMJ))]
	internal Task<HttpRequestMessage> LMDAOJECCPH(CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x81EDE30", Offset = "0x81EC830", VA = "0x1881EDE30")]
	private Uri EFKLDAGPKKL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public static class AEBHPNDIFDA
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	[CompilerGenerated]
	private struct EKHOCOPBLBB : IAsyncStateMachine
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
		[Cpp2IlInjected.Address(RVA = "0x81EBCB0", Offset = "0x81EA6B0", VA = "0x1881EBCB0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x81EC0A0", Offset = "0x81EAAA0", VA = "0x1881EC0A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x81EBB90", Offset = "0x81EA590", VA = "0x1881EBB90")]
	[AsyncStateMachine(typeof(EKHOCOPBLBB))]
	public static Task<HttpResponseMessage> AGJGJINFIFJ(this HttpResponseMessage EKMCEDIJMDM, [Optional] CancellationToken AHOMALKMHKK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class HOMDMJPJOOF : StringContent
{
	[Cpp2IlInjected.Token(Token = "0x6000029")]
	[Cpp2IlInjected.Address(RVA = "0x81EDB30", Offset = "0x81EC530", VA = "0x1881EDB30")]
	public HOMDMJPJOOF(object KMAFNKGMDCF, JsonSerializerSettings? MEPOIADFLKK)
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
