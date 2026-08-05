using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net.Http.Headers;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using Microsoft.CodeAnalysis;
using Newtonsoft.Json;
using RecRoom.Utils.Image;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17A40", VA = "0x180D18E40")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x950F880", Offset = "0x950E480", VA = "0x18950F880")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD19810", Offset = "0xD18410", VA = "0x180D19810")]
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
		[Cpp2IlInjected.Address(RVA = "0xD19850", Offset = "0xD18450", VA = "0x180D19850")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace RecNet
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public enum MimeType
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
	public static class EPUAIJOHLDQ
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x950F630", Offset = "0x950E230", VA = "0x18950F630")]
		public static string DIHATSCLGYB(this MimeType a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x950F7C0", Offset = "0x950E3C0", VA = "0x18950F7C0")]
		public static MimeType XQADOEBTRNO(this ImageType a)
		{
			return default(MimeType);
		}
	}
}
namespace System.Net.Http
{
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public static class ZRZJVXNLYVP
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x95126A0", Offset = "0x95112A0", VA = "0x1895126A0")]
		public static YQBEMGSMZYA PTNPURINHQZ(this HttpClient a, HttpMethod b, string c)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public static class QQUYZOAVESX
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private struct <ReadAsJsonAsync>d__0<T> : IAsyncStateMachine
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
			[Cpp2IlInjected.Address(RVA = "0x6A84260", Offset = "0x6A82E60", VA = "0x186A84260", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x69D0F10", Offset = "0x69CFB10", VA = "0x1869D0F10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x3E36D70", Offset = "0x3E35970", VA = "0x183E36D70")]
		[AsyncStateMachine(typeof(<ReadAsJsonAsync>d__0<>))]
		public static Task<T> XPFRPVBRLOK<T>(this HttpContent a, [Optional] JsonSerializerSettings? serializerSettings, [Optional] CancellationToken b) where T : notnull
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class YQBEMGSMZYA
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000C")]
		[CompilerGenerated]
		private struct <Build>d__49 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400001D")]
			public AsyncTaskMethodBuilder<HttpRequestMessage> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			public YQBEMGSMZYA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400001F")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private HttpRequestMessage <message>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private List<Func<HttpRequestMessage, CancellationToken, Task>>.Enumerator <>7__wrap2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private ConfiguredTaskAwaitable.ConfiguredTaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x950FAC0", Offset = "0x950E6C0", VA = "0x18950FAC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x9510710", Offset = "0x950F310", VA = "0x189510710", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000D")]
		[CompilerGenerated]
		private struct <SendRawAsync>d__45 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000023")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000024")]
			public AsyncTaskMethodBuilder<HttpResponseMessage> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000025")]
			public YQBEMGSMZYA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000026")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000027")]
			public HttpCompletionOption httpCompletionOption;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private HttpRequestMessage <request>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private ConfiguredTaskAwaitable<HttpRequestMessage>.ConfiguredTaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x9510BC0", Offset = "0x950F7C0", VA = "0x189510BC0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x9511220", Offset = "0x950FE20", VA = "0x189511220", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000E")]
		[CompilerGenerated]
		private struct <SendWithNoResponseAsync>d__46 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400002B")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400002C")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400002D")]
			public YQBEMGSMZYA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400002E")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			private HttpResponseMessage <response>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			private ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			private TaskAwaiter<HttpResponseMessage> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x9511290", Offset = "0x950FE90", VA = "0x189511290", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x9511880", Offset = "0x9510480", VA = "0x189511880", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200000F")]
		[CompilerGenerated]
		private struct <SendWithRequiredResponseAsync>d__47<TResult> : IAsyncStateMachine where TResult : notnull
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public AsyncTaskMethodBuilder<TResult> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public YQBEMGSMZYA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public JsonSerializerSettings serializerSettings;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			private HttpResponseMessage <response>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			private ConfiguredTaskAwaitable<HttpResponseMessage>.ConfiguredTaskAwaiter <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			private TaskAwaiter<HttpResponseMessage> <>u__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			private ConfiguredTaskAwaitable<TResult>.ConfiguredTaskAwaiter <>u__3;

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6C606E0", Offset = "0x6C5F2E0", VA = "0x186C606E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6C60EE0", Offset = "0x6C5FAE0", VA = "0x186C60EE0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private readonly HttpMethod WXXTTWWYUMZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private readonly Uri CAOQMJYBDSR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		private AuthenticationHeaderValue? KGEIBNILEEZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private HttpContent? BLXTKNDXMEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private List<KeyValuePair<string, string>>? GFKSRVRBCNW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private List<KeyValuePair<string, string>>? LSFPEEBEBTU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		private List<(HttpContent content, string key, string filename)>? CJGEUIINEHY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		private List<Func<HttpRequestMessage, CancellationToken, Task>>? PPETZNLRHYO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		private List<KeyValuePair<string, string>>? XJOYTJHQINQ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public HttpClient SZXCXIRYCSD
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0xCEE150", Offset = "0xCECD50", VA = "0x180CEE150")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9512630", Offset = "0x9511230", VA = "0x189512630")]
		public YQBEMGSMZYA(HttpClient a, HttpMethod b, Uri c)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x9511B90", Offset = "0x9510790", VA = "0x189511B90")]
		public YQBEMGSMZYA APLTBAPZGNB(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x5B44A70", Offset = "0x5B43670", VA = "0x185B44A70")]
		public YQBEMGSMZYA BTBYOBEPWTG(HttpContent a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9511E70", Offset = "0x9510A70", VA = "0x189511E70")]
		public YQBEMGSMZYA GHMKVQYOYLT(object a, [Optional] JsonSerializerSettings? serializerSettings)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x95123F0", Offset = "0x9510FF0", VA = "0x1895123F0")]
		public YQBEMGSMZYA KOZMTEIAUCG(string a, string? value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9511D50", Offset = "0x9510950", VA = "0x189511D50")]
		public YQBEMGSMZYA CYJSZWUDTYA(string a, string? value)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x95124D0", Offset = "0x95110D0", VA = "0x1895124D0")]
		private YQBEMGSMZYA KOZMTEIAUCG(string a, string? value, List<KeyValuePair<string, string>>? parameters)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x95120B0", Offset = "0x9510CB0", VA = "0x1895120B0")]
		public YQBEMGSMZYA KEDTBUCIXFK(string a, byte[] b, string c = "application/octet-stream", string d = "file.bin")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x95121A0", Offset = "0x9510DA0", VA = "0x1895121A0")]
		public YQBEMGSMZYA KEDTBUCIXFK(string a, HttpContent b, string c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x95120A0", Offset = "0x9510CA0", VA = "0x1895120A0")]
		public Task<HttpResponseMessage> GXCSBVMSVOM([Optional] CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x9511F60", Offset = "0x9510B60", VA = "0x189511F60")]
		[AsyncStateMachine(typeof(<SendRawAsync>d__45))]
		public Task<HttpResponseMessage> GXCSBVMSVOM(HttpCompletionOption a, [Optional] CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x9511D70", Offset = "0x9510970", VA = "0x189511D70")]
		[AsyncStateMachine(typeof(<SendWithNoResponseAsync>d__46))]
		public Task DONNVYJABTU([Optional] CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x4133370", Offset = "0x4131F70", VA = "0x184133370")]
		[AsyncStateMachine(typeof(<SendWithRequiredResponseAsync>d__47<>))]
		public Task<a?>? EVUWZJNQBMY<a>([Optional] JsonSerializerSettings? a, [Optional] CancellationToken b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x9511C20", Offset = "0x9510820", VA = "0x189511C20")]
		[AsyncStateMachine(typeof(<Build>d__49))]
		internal Task<HttpRequestMessage> Build(CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x95119F0", Offset = "0x95105F0", VA = "0x1895119F0")]
		private Uri ACHTAMFEHJA()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class RCSXVDBTDQA
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000011")]
		[CompilerGenerated]
		private struct <EnsureSuccessStatusCodeEx>d__0 : IAsyncStateMachine
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
			[Cpp2IlInjected.Address(RVA = "0x9510780", Offset = "0x950F380", VA = "0x189510780", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x9510B50", Offset = "0x950F750", VA = "0x189510B50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x950F9A0", Offset = "0x950E5A0", VA = "0x18950F9A0")]
		[AsyncStateMachine(typeof(<EnsureSuccessStatusCodeEx>d__0))]
		public static Task<HttpResponseMessage> HIIRHMDYGPB(this HttpResponseMessage a, [Optional] CancellationToken b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class OZMHLWOQWWX : StringContent
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x950F900", Offset = "0x950E500", VA = "0x18950F900")]
		public OZMHLWOQWWX(object a, JsonSerializerSettings? serializerSettings)
		{
		}
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
