using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Net;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using Newtonsoft.Json;
using RecRoom.Logging;
using RecRoom.Logging.Attributes;
using RecRoom.Networking;
using RecRoom.NoEngine.Common;
using UJect.Injection;
using Unity.Netcode;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0xD3AE50", Offset = "0xD39850", VA = "0x180D3AE50")]
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
		[Cpp2IlInjected.Address(RVA = "0x9AC9AE0", Offset = "0x9AC84E0", VA = "0x189AC9AE0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD3B3B0", Offset = "0xD39DB0", VA = "0x180D3B3B0")]
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
		[Cpp2IlInjected.Address(RVA = "0xD3B3F0", Offset = "0xD39DF0", VA = "0x180D3B3F0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
namespace _LogRegistration.RecRoom_Networking_PhotonImpl_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	[CompilerGenerated]
	[Obfuscation(ApplyToMembers = false)]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : RecRoom.Logging.LogRegistrationIndex
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x9AC9A20", Offset = "0x9AC8420", VA = "0x189AC9A20", Slot = "4")]
		public override void WSFSWRIEDET()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xD3AE50", Offset = "0xD39850", VA = "0x180D3AE50")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.RoomLoading.PhotonClients
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface BDIUMWEFJNA
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "0")]
		object WLXAMGDYHFG(GUTQAQVNFED a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface RSZVTBXOQJV : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		UINLVNKQAJX GHNBUSAJGWP
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		Task QTAKMRKDRNU
		{
			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "5")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "1")]
		Task Disconnect([Optional] CancellationToken cancellationToken);

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "2")]
		Task<UINLVNKQAJX> JRKKQBSWOQN(UINLVNKQAJX a, object b, [Optional] CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task NSRWFKPPCIA([Optional] CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void CEMKTGNJJCT(DisconnectHandler a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public interface VAERTKPKWRW
	{
		[Cpp2IlInjected.Token(Token = "0x17000003")]
		JOLHGBMRDLK WRTTJVGYDRG
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		string IRNIJQMVXJB
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		string STBRIZPXRDS
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<bool> ZVRLPTUEKQG(string a, string b, string c);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task Disconnect([Optional] CancellationToken cancellationToken);
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	internal static class CDSJKDLMVDD
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class LPZXHRUVEJS<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public TaskCompletionSource<a> QYRNFAFLNPK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public MBQGRUSTSMG UJGZJJPKTEX;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public IIPEJBWGEEG OGUPRCWALTS;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public LPZXHRUVEJS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x68D4DE0", Offset = "0x68D37E0", VA = "0x1868D4DE0")]
			internal void MCDKLJKEMOO(DisconnectCause a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x68D5800", Offset = "0x68D4200", VA = "0x1868D5800")]
			internal void PWTYAGWMPUR(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x68D4920", Offset = "0x68D3320", VA = "0x1868D4920")]
			internal void BMWJKEGTTCQ(Task<a> a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class MWVGGDREEOF<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public TaskCompletionSource<a> QYRNFAFLNPK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public IIPEJBWGEEG OGUPRCWALTS;

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public MWVGGDREEOF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x6F42FD0", Offset = "0x6F419D0", VA = "0x186F42FD0")]
			internal void JPIXCZRLCYK(short a, string b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6F43840", Offset = "0x6F42240", VA = "0x186F43840")]
			internal void UQIEYSSSCAZ(short a, string b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6F43130", Offset = "0x6F41B30", VA = "0x186F43130")]
			internal void LZYGBTZZVVX(Task<a> a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static Log MTKAYXCPQAM;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x381C970", Offset = "0x381B370", VA = "0x18381C970")]
		public static void ARESMZQQCQU<a>(this IIPEJBWGEEG a, TaskCompletionSource<a> b, [NotNull] MBQGRUSTSMG networkClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x381CEE0", Offset = "0x381B8E0", VA = "0x18381CEE0")]
		public static void EHUOVEMPVWL<b>(this IIPEJBWGEEG a, TaskCompletionSource<b> b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface GAWFFPLRNZK
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public delegate Task DisconnectHandler(DisconnectCause disconnectCause);
	[StructLayout((LayoutKind)0, Size = 1)]
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct VoidType : IEquatable<VoidType>
	{
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public static readonly VoidType Default;

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0xD2BB70", Offset = "0xD2A570", VA = "0x180D2BB70", Slot = "4")]
		public bool Equals(VoidType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9ACFE00", Offset = "0x9ACE800", VA = "0x189ACFE00", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class PhotonClientException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9AC9E40", Offset = "0x9AC8840", VA = "0x189AC9E40")]
		public PhotonClientException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class PhotonFailedToConnectToRegionException : PhotonClientException
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class PhotonFailedToConnectToRoomException : PhotonClientException
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public class PhotonUnexpectedLeftRoomException : PhotonClientException
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public class PhotonDisconnectException : PhotonClientException
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public readonly int? LastExceptionStatusCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public readonly DisconnectCause DisconnectCause;

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA170", Offset = "0x9AC8B70", VA = "0x189ACA170")]
		public PhotonDisconnectException(DisconnectCause disconnectCause, Exception innerException, int? lastExceptionStatusCode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9AC9EA0", Offset = "0x9AC88A0", VA = "0x189AC9EA0")]
		public static PhotonDisconnectException HSRYWJOPVQT(DisconnectCause a, MBQGRUSTSMG b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class PhotonAuthException : PhotonClientException
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9AC9E40", Offset = "0x9AC8840", VA = "0x189AC9E40")]
		public PhotonAuthException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class PhotonRoomJoinException : PhotonClientException
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public readonly short ErrorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public readonly string DebugMsg;

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA390", Offset = "0x9AC8D90", VA = "0x189ACA390")]
		public PhotonRoomJoinException(short errorCode, string debugMsg)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public class PhotonRoomCreateException : PhotonClientException
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public readonly short ErrorCode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public readonly string DebugMsg;

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA2B0", Offset = "0x9AC8CB0", VA = "0x189ACA2B0")]
		public PhotonRoomCreateException(short errorCode, string debugMsg)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class PhotonInvalidNetworkQueueStateException : PhotonClientException
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9AC9E40", Offset = "0x9AC8840", VA = "0x189AC9E40")]
		public PhotonInvalidNetworkQueueStateException(string message)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000018")]
	public class PhotonFailedToLeaveRoomException : PhotonClientException
	{
	}
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class PhotonTcsTimeoutException : TcsTimeoutException
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public readonly Dictionary<string, string> AdditionalInfo;
	}
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class GUTQAQVNFED : IEquatable<GUTQAQVNFED>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly string QXWQVDMMHIF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly string? AIQZDXQPZMQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly string? OOTLENRGYEY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly string? GRFJCPWCJRO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public readonly string BDIKACDDNSR;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9AC98E0", Offset = "0x9AC82E0", VA = "0x189AC98E0")]
		public GUTQAQVNFED(string photonRealtimeAppId, string? a, string? b, string? c, string authToken)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9AC9880", Offset = "0x9AC8280", VA = "0x189AC9880", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9AC9700", Offset = "0x9AC8100", VA = "0x189AC9700", Slot = "4")]
		public bool Equals(GUTQAQVNFED? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9AC9670", Offset = "0x9AC8070", VA = "0x189AC9670", Slot = "0")]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9AC9790", Offset = "0x9AC8190", VA = "0x189AC9790", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class UINLVNKQAJX : GUTQAQVNFED, IEquatable<UINLVNKQAJX>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly string XQJORDPVORM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public readonly string? VJNMMFBDSPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public readonly string? TWEWEEFJTVA;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9ACFC30", Offset = "0x9ACE630", VA = "0x189ACFC30")]
		public UINLVNKQAJX(string a, string b, string c, string? photonRegion, string d, string e, string? voiceConnectionInfo, string? voiceServerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9ACFBD0", Offset = "0x9ACE5D0", VA = "0x189ACFBD0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9ACF940", Offset = "0x9ACE340", VA = "0x189ACF940", Slot = "5")]
		public bool Equals(UINLVNKQAJX? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9ACF9C0", Offset = "0x9ACE3C0", VA = "0x189ACF9C0", Slot = "0")]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9ACFA90", Offset = "0x9ACE490", VA = "0x189ACFA90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x15B6100", Offset = "0x15B4B00", VA = "0x1815B6100")]
		public static bool ENWYWLXFHXP(UINLVNKQAJX? a, UINLVNKQAJX? b)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	[RecRoom.NoEngine.Common.Preserve]
	public class AuthPayload
	{
		[Cpp2IlInjected.Token(Token = "0x17000006")]
		[JsonProperty(PropertyName = "AI", Required = Required.Always)]
		[RecRoom.NoEngine.Common.Preserve]
		public string AccountId
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xD11BD0", Offset = "0xD105D0", VA = "0x180D11BD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		[JsonProperty(PropertyName = "AT", Required = Required.Always)]
		[RecRoom.NoEngine.Common.Preserve]
		public byte[] AccessToken
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xD11BB0", Offset = "0xD105B0", VA = "0x180D11BB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		[JsonProperty(PropertyName = "VB", Required = Required.Always)]
		[RecRoom.NoEngine.Common.Preserve]
		public byte[] VerificationBlob
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0xD11BE0", Offset = "0xD105E0", VA = "0x180D11BE0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xD11C10", Offset = "0xD10610", VA = "0x180D11C10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		[JsonProperty(PropertyName = "CKA", Required = Required.Always)]
		[RecRoom.NoEngine.Common.Preserve]
		public byte[] ClientKeyA
		{
			[Cpp2IlInjected.Token(Token = "0x600003B")]
			[Cpp2IlInjected.Address(RVA = "0xD11C00", Offset = "0xD10600", VA = "0x180D11C00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xD12070", Offset = "0xD10A70", VA = "0x180D12070")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		[JsonProperty(PropertyName = "CIA", Required = Required.Always)]
		[RecRoom.NoEngine.Common.Preserve]
		public byte[] ClientIVA
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xD12080", Offset = "0xD10A80", VA = "0x180D12080")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xD11BA0", Offset = "0xD105A0", VA = "0x180D11BA0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		[JsonProperty(PropertyName = "CPK", Required = Required.Always)]
		[RecRoom.NoEngine.Common.Preserve]
		public byte[] ClientPublicKey
		{
			[Cpp2IlInjected.Token(Token = "0x600003F")]
			[Cpp2IlInjected.Address(RVA = "0xD161A0", Offset = "0xD14BA0", VA = "0x180D161A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xD15990", Offset = "0xD14390", VA = "0x180D15990")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public AuthPayload()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	[RecRoom.NoEngine.Common.Preserve]
	public class ConnectionResponsePayload
	{
		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		[JsonProperty(PropertyName = "DR", Required = Required.Always)]
		[RecRoom.NoEngine.Common.Preserve]
		public string Reason
		{
			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xD11BD0", Offset = "0xD105D0", VA = "0x180D11BD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		[JsonProperty(PropertyName = "KT", Required = Required.Default)]
		[RecRoom.NoEngine.Common.Preserve]
		public byte[] SessionKeyB
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xD11BC0", Offset = "0xD105C0", VA = "0x180D11BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xD11BB0", Offset = "0xD105B0", VA = "0x180D11BB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public ConnectionResponsePayload()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class TachyonClient : RSZVTBXOQJV, IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public enum ClientState
		{
			[Cpp2IlInjected.Token(Token = "0x400002F")]
			Disconnected,
			[Cpp2IlInjected.Token(Token = "0x4000030")]
			Connecting,
			[Cpp2IlInjected.Token(Token = "0x4000031")]
			Connected
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000020")]
		[CompilerGenerated]
		private struct <ConnectToRoomInstance>d__42 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			public AsyncTaskMethodBuilder<UINLVNKQAJX> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public TachyonClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public object pauseToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public UINLVNKQAJX targetRoomInstance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			private IDisposable <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			private TaskAwaiter<UINLVNKQAJX> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x9ACEAF0", Offset = "0x9ACD4F0", VA = "0x189ACEAF0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x9ACF700", Offset = "0x9ACE100", VA = "0x189ACF700", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		[CompilerGenerated]
		private struct <LogWhileInRoom>d__43 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400003A")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400003B")]
			public AsyncVoidMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400003C")]
			public Task<VoidType> whileInRoomTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400003D")]
			private TaskAwaiter<VoidType> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x9ACF770", Offset = "0x9ACE170", VA = "0x189ACF770", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xD751F0", Offset = "0xD73BF0", VA = "0x180D751F0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private NetworkManager PLJEAUEGWPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskCompletionSource<UINLVNKQAJX> CYVEURFEXHU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		protected readonly GXLSEMXVYCP OGUPRCWALTS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		protected readonly BDIUMWEFJNA DPARLETKYXU;

		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private static readonly Log MTKAYXCPQAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly HashSet<DisconnectHandler> LXIMWDPLOZD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public ClientState GGILCMMJJBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private UINLVNKQAJX QBGUPELNOJJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private RSACryptoServiceProvider EZIGXWKUOYB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private RSACryptoServiceProvider UKVYRRRPUHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private AesCryptoServiceProvider EQYEQNIQHWQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private byte[] EKZMRFLXGWE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private TaskCompletionSource<VoidType> QIBWQUDBAKH;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public UINLVNKQAJX GHNBUSAJGWP
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xD161C0", Offset = "0xD14BC0", VA = "0x180D161C0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Task QTAKMRKDRNU
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x9ACE220", Offset = "0x9ACCC20", VA = "0x189ACE220", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9ACC4D0", Offset = "0x9ACAED0", VA = "0x189ACC4D0", Slot = "8")]
		public void CEMKTGNJJCT(DisconnectHandler a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9ACE2B0", Offset = "0x9ACCCB0", VA = "0x189ACE2B0", Slot = "11")]
		public bool THKWUKEWOHH(UINLVNKQAJX a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9ACE600", Offset = "0x9ACD000", VA = "0x189ACE600")]
		[RecRoom.NoEngine.Common.Preserve]
		public TachyonClient([Inject(null)] GXLSEMXVYCP networking, [Inject(null)] BDIUMWEFJNA _settingsProvider)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150")]
		private void YVYWEKVHZME(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150")]
		private void XZERRJJZIUZ(RecRoom.Networking.ClientState a, RecRoom.Networking.ClientState b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9ACC7C0", Offset = "0x9ACB1C0", VA = "0x189ACC7C0")]
		private void FQHBWVVQGJT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x9ACE0A0", Offset = "0x9ACCAA0", VA = "0x189ACE0A0")]
		private void OTHMBLKCMJW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9ACD210", Offset = "0x9ACBC10", VA = "0x189ACD210")]
		private void MJBEHLUZQCR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x9ACDF20", Offset = "0x9ACC920", VA = "0x189ACDF20")]
		private void NetworkManager_OnClientDisconnectCallback(ulong obj)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9ACDFA0", Offset = "0x9ACC9A0", VA = "0x189ACDFA0")]
		private void NetworkManager_OnClientStopped(bool isServer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9ACC2B0", Offset = "0x9ACACB0", VA = "0x189ACC2B0")]
		private void AOUYOZCBUBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9ACD860", Offset = "0x9ACC260", VA = "0x189ACD860")]
		private void NetworkManager_OnClientConnectedCallback(ulong obj)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9ACE020", Offset = "0x9ACCA20", VA = "0x189ACE020")]
		private void NetworkManager_OnTransportFailure()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x9ACE2F0", Offset = "0x9ACCCF0", VA = "0x189ACE2F0")]
		private void WZELQTFDOIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x9ACE410", Offset = "0x9ACCE10", VA = "0x189ACE410")]
		private void XKOQLJPAOED()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x9ACD4E0", Offset = "0x9ACBEE0", VA = "0x189ACD4E0")]
		private void MTSFWGUKWJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x9ACC530", Offset = "0x9ACAF30", VA = "0x189ACC530")]
		private static (IPAddress, ushort) CEUPKFXHZAU(string a)
		{
			return default((IPAddress, ushort));
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x9ACCA10", Offset = "0x9ACB410", VA = "0x189ACCA10")]
		private void GXCJEZTJPCF(UINLVNKQAJX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x9ACD0B0", Offset = "0x9ACBAB0", VA = "0x189ACD0B0", Slot = "6")]
		[AsyncStateMachine(typeof(<ConnectToRoomInstance>d__42))]
		public Task<UINLVNKQAJX> JRKKQBSWOQN(UINLVNKQAJX a, object b, [Optional] CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x9ACE360", Offset = "0x9ACCD60", VA = "0x189ACE360")]
		[AsyncStateMachine(typeof(<LogWhileInRoom>d__43))]
		private void XGOXUCJWMAJ(Task<VoidType> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x9ACC660", Offset = "0x9ACB060", VA = "0x189ACC660", Slot = "5")]
		public Task Disconnect([Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9ACD770", Offset = "0x9ACC170", VA = "0x189ACD770", Slot = "7")]
		public Task NSRWFKPPCIA([Optional] CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9ACC750", Offset = "0x9ACB150", VA = "0x189ACC750", Slot = "10")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class TachyonException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x9ACE8C0", Offset = "0x9ACD2C0", VA = "0x189ACE8C0")]
		public TachyonException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x9ACE920", Offset = "0x9ACD320", VA = "0x189ACE920")]
		public TachyonException(string message, Exception innerException)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class TachyonFailedToConnectToVoiceException : TachyonException
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x9ACE990", Offset = "0x9ACD390", VA = "0x189ACE990")]
		public TachyonFailedToConnectToVoiceException([NotNull] Exception innerException)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class TachyonFailedToStartNetworkManagerException : TachyonException
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x9ACEA70", Offset = "0x9ACD470", VA = "0x189ACEA70")]
		public TachyonFailedToStartNetworkManagerException()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class TachyonAlreadyDisconnectedException : TachyonException
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9ACC230", Offset = "0x9ACAC30", VA = "0x189ACC230")]
		public TachyonAlreadyDisconnectedException()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public static class OROJZWSMSBT
	{
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static AesCryptoServiceProvider QICUACOMNZN;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private static readonly string XHUQKJZZYYG;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static readonly string ZACQXWXBTXO;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private static readonly string ERINKEMPXIG;

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x9AC9CB0", Offset = "0x9AC86B0", VA = "0x189AC9CB0")]
		public static string WKVCPHDLQLY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x9AC9C60", Offset = "0x9AC8660", VA = "0x189AC9C60")]
		public static string VPUFIUIEJHU()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9AC9B60", Offset = "0x9AC8560", VA = "0x189AC9B60")]
		public static AesCryptoServiceProvider CPPXIURLCJZ()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class SVKASPGURNP : VAERTKPKWRW
	{
		[Cpp2IlInjected.Token(Token = "0x2000028")]
		public enum ClientState
		{
			[Cpp2IlInjected.Token(Token = "0x400004C")]
			Disconnected,
			[Cpp2IlInjected.Token(Token = "0x400004D")]
			Connecting,
			[Cpp2IlInjected.Token(Token = "0x400004E")]
			Connected
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		private JOLHGBMRDLK OIQVIZCOUUE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private NetworkManager PLJEAUEGWPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		protected readonly BDIUMWEFJNA DPARLETKYXU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskCompletionSource<bool> YTJLEMWUIET;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public ClientState GGILCMMJJBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private RSACryptoServiceProvider EZIGXWKUOYB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private RSACryptoServiceProvider UKVYRRRPUHA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private AesCryptoServiceProvider EQYEQNIQHWQ;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public JOLHGBMRDLK WRTTJVGYDRG
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public string IRNIJQMVXJB
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xD161A0", Offset = "0xD14BA0", VA = "0x180D161A0", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xD15990", Offset = "0xD14390", VA = "0x180D15990")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public string STBRIZPXRDS
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x9ACAF20", Offset = "0x9AC9920", VA = "0x189ACAF20", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x9ACC090", Offset = "0x9ACAA90", VA = "0x189ACC090")]
		[UnityEngine.Scripting.Preserve]
		public SVKASPGURNP([Inject(null)] BDIUMWEFJNA _settingsProvider)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA640", Offset = "0x9AC9040", VA = "0x189ACA640")]
		private void FQHBWVVQGJT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x9ACB680", Offset = "0x9ACA080", VA = "0x189ACB680")]
		private void OTHMBLKCMJW()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x9ACB250", Offset = "0x9AC9C50", VA = "0x189ACB250")]
		private void NetworkManager_OnClientDisconnectCallback(ulong obj)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x9ACB7B0", Offset = "0x9ACA1B0", VA = "0x189ACB7B0")]
		private void QWHMMIPMFKX(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x9ACB100", Offset = "0x9AC9B00", VA = "0x189ACB100")]
		private void NetworkManager_OnClientConnectedCallback(ulong obj)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x9ACB590", Offset = "0x9AC9F90", VA = "0x189ACB590")]
		private void NetworkManager_OnTransportFailure()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x9ACBC50", Offset = "0x9ACA650", VA = "0x189ACBC50")]
		private void WZELQTFDOIF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x9ACB040", Offset = "0x9AC9A40", VA = "0x189ACB040")]
		private void MTSFWGUKWJH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA470", Offset = "0x9AC8E70", VA = "0x189ACA470")]
		private static (IPAddress, ushort) CEUPKFXHZAU(string a)
		{
			return default((IPAddress, ushort));
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA830", Offset = "0x9AC9230", VA = "0x189ACA830")]
		private void GXCJEZTJPCF(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x9ACBCC0", Offset = "0x9ACA6C0", VA = "0x189ACBCC0", Slot = "7")]
		public Task<bool> ZVRLPTUEKQG(string a, string b, string c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x9ACA5A0", Offset = "0x9AC8FA0", VA = "0x189ACA5A0", Slot = "8")]
		public Task Disconnect([Optional] CancellationToken cancellationToken)
		{
			return null;
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
