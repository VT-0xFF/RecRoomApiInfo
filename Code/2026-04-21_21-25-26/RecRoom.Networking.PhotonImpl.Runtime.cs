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
		[Cpp2IlInjected.Address(RVA = "0xD39E50", Offset = "0xD38850", VA = "0x180D39E50")]
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
		[Cpp2IlInjected.Address(RVA = "0x9AC2590", Offset = "0x9AC0F90", VA = "0x189AC2590")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD3A120", Offset = "0xD38B20", VA = "0x180D3A120")]
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
		[Cpp2IlInjected.Address(RVA = "0xD3A160", Offset = "0xD38B60", VA = "0x180D3A160")]
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
		[Cpp2IlInjected.Address(RVA = "0x9AC24D0", Offset = "0x9AC0ED0", VA = "0x189AC24D0", Slot = "4")]
		public override void CBYRPQCEVDS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xD39E50", Offset = "0xD38850", VA = "0x180D39E50")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.RoomLoading.PhotonClients
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface ISYPUZZLNOB
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "0")]
		object HKULEBLRJUR(YWDQBEIJOEE a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface RWCUJOOLKDY : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		WABBHQTINSC SBKQLLCVCMS
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		Task EKXRFZTFJJJ
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
		Task<WABBHQTINSC> QBDEUCYUOYM(WABBHQTINSC a, object b, [Optional] CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task CCECSFRFXJR([Optional] CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void VKMGEYSOSCK(DisconnectHandler a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public interface ERCNSIQRTVN
	{
		[Cpp2IlInjected.Token(Token = "0x17000003")]
		DYNHRMPGIXT QDBPTYDEQPX
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		string KXVOIELCUSI
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		string GRWZMJHKIMX
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<bool> EFJCGNGZDVL(string a, string b, string c);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task Disconnect([Optional] CancellationToken cancellationToken);
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	internal static class HREMTTGMFJG
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class ITOQTWBEUPV<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public TaskCompletionSource<a> UQKVQPZKLZH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public CDPRAJEFKDH OEIUHSTSSRQ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public MZPAUNRNKBF LMVVDSZGPPF;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public ITOQTWBEUPV()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x66586F0", Offset = "0x66570F0", VA = "0x1866586F0")]
			internal void WENYIWCBNQL(DisconnectCause a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x6657E80", Offset = "0x6656880", VA = "0x186657E80")]
			internal void MIZMDAGMUIO(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x6657FC0", Offset = "0x66569C0", VA = "0x186657FC0")]
			internal void NKGNHAVJMOD(Task<a> a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class ZAGAZIDTYHU<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public TaskCompletionSource<a> UQKVQPZKLZH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public MZPAUNRNKBF LMVVDSZGPPF;

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
			public ZAGAZIDTYHU()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x5153D10", Offset = "0x5152710", VA = "0x185153D10")]
			internal void FCGCEPAKAWF(short a, string b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x51543E0", Offset = "0x5152DE0", VA = "0x1851543E0")]
			internal void PKJLQOAJIXQ(short a, string b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x51541B0", Offset = "0x5152BB0", VA = "0x1851541B0")]
			internal void JGVYVWLICVI(Task<a> a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static Log ALDXGIVBEKZ;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3B19400", Offset = "0x3B17E00", VA = "0x183B19400")]
		public static void UOTXMMKBPIT<a>(this MZPAUNRNKBF a, TaskCompletionSource<a> b, [NotNull] CDPRAJEFKDH networkClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3B19970", Offset = "0x3B18370", VA = "0x183B19970")]
		public static void ZOWEUWAYPKM<b>(this MZPAUNRNKBF a, TaskCompletionSource<b> b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface XDTFMJDORLB
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
		[Cpp2IlInjected.Address(RVA = "0xD2AB70", Offset = "0xD29570", VA = "0x180D2AB70", Slot = "4")]
		public bool Equals(VoidType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9AC8110", Offset = "0x9AC6B10", VA = "0x189AC8110", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xD10160", Offset = "0xD0EB60", VA = "0x180D10160", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class PhotonClientException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9AC2610", Offset = "0x9AC1010", VA = "0x189AC2610")]
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
		[Cpp2IlInjected.Address(RVA = "0x9AC2940", Offset = "0x9AC1340", VA = "0x189AC2940")]
		public PhotonDisconnectException(DisconnectCause disconnectCause, Exception innerException, int? lastExceptionStatusCode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9AC2670", Offset = "0x9AC1070", VA = "0x189AC2670")]
		public static PhotonDisconnectException QUHWZPNWYZU(DisconnectCause a, CDPRAJEFKDH b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class PhotonAuthException : PhotonClientException
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9AC2610", Offset = "0x9AC1010", VA = "0x189AC2610")]
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
		[Cpp2IlInjected.Address(RVA = "0x9AC2B60", Offset = "0x9AC1560", VA = "0x189AC2B60")]
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
		[Cpp2IlInjected.Address(RVA = "0x9AC2A80", Offset = "0x9AC1480", VA = "0x189AC2A80")]
		public PhotonRoomCreateException(short errorCode, string debugMsg)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class PhotonInvalidNetworkQueueStateException : PhotonClientException
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9AC2610", Offset = "0x9AC1010", VA = "0x189AC2610")]
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
	public class YWDQBEIJOEE : IEquatable<YWDQBEIJOEE>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly string JGTGNYJONIE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly string? IHOOAENDQTB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly string? GFNTSIGMOEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly string? OHYVGHWYNDR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public readonly string BCEISMZVZVS;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9AC88B0", Offset = "0x9AC72B0", VA = "0x189AC88B0")]
		public YWDQBEIJOEE(string photonRealtimeAppId, string? a, string? b, string? c, string authToken)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9AC8850", Offset = "0x9AC7250", VA = "0x189AC8850", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9AC8640", Offset = "0x9AC7040", VA = "0x189AC8640", Slot = "4")]
		public bool Equals(YWDQBEIJOEE? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9AC86D0", Offset = "0x9AC70D0", VA = "0x189AC86D0", Slot = "0")]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9AC8760", Offset = "0x9AC7160", VA = "0x189AC8760", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class WABBHQTINSC : YWDQBEIJOEE, IEquatable<WABBHQTINSC>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly string LQHSBCNFFMN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public readonly string? KAOCCYWQEIJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public readonly string? OBIAHZGWXZR;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x9AC8470", Offset = "0x9AC6E70", VA = "0x189AC8470")]
		public WABBHQTINSC(string a, string b, string c, string? photonRegion, string d, string e, string? voiceConnectionInfo, string? voiceServerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x9AC8410", Offset = "0x9AC6E10", VA = "0x189AC8410", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9AC8180", Offset = "0x9AC6B80", VA = "0x189AC8180", Slot = "5")]
		public bool Equals(WABBHQTINSC? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9AC8200", Offset = "0x9AC6C00", VA = "0x189AC8200", Slot = "0")]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9AC82D0", Offset = "0x9AC6CD0", VA = "0x189AC82D0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x15B2EF0", Offset = "0x15B18F0", VA = "0x1815B2EF0")]
		public static bool CYAUITUETAA(WABBHQTINSC? a, WABBHQTINSC? b)
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
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
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
			[Cpp2IlInjected.Address(RVA = "0xD12BC0", Offset = "0xD115C0", VA = "0x180D12BC0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xD11520", Offset = "0xD0FF20", VA = "0x180D11520")]
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
			[Cpp2IlInjected.Address(RVA = "0xD11B00", Offset = "0xD10500", VA = "0x180D11B00")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD0FF30", VA = "0x180D11530")]
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
			[Cpp2IlInjected.Address(RVA = "0xD11A20", Offset = "0xD10420", VA = "0x180D11A20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xD17350", Offset = "0xD15D50", VA = "0x180D17350")]
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
			[Cpp2IlInjected.Address(RVA = "0xD12280", Offset = "0xD10C80", VA = "0x180D12280")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xD11B50", Offset = "0xD10550", VA = "0x180D11B50")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
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
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xD117C0", Offset = "0xD101C0", VA = "0x180D117C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xD11B30", Offset = "0xD10530", VA = "0x180D11B30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xD12270", Offset = "0xD10C70", VA = "0x180D12270")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xD16C40", Offset = "0xD15640", VA = "0x180D16C40")]
		public ConnectionResponsePayload()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class TachyonClient : RWCUJOOLKDY, IDisposable
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
			public AsyncTaskMethodBuilder<WABBHQTINSC> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public TachyonClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public object pauseToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public WABBHQTINSC targetRoomInstance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			private IDisposable <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			private TaskAwaiter<WABBHQTINSC> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x9AC72C0", Offset = "0x9AC5CC0", VA = "0x189AC72C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x9AC7ED0", Offset = "0x9AC68D0", VA = "0x189AC7ED0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x9AC7F40", Offset = "0x9AC6940", VA = "0x189AC7F40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xD74370", Offset = "0xD72D70", VA = "0x180D74370", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private NetworkManager MIQOOVOMOMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskCompletionSource<WABBHQTINSC> NAEMLEHAYMZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		protected readonly WHWIROLHRQO LMVVDSZGPPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		protected readonly ISYPUZZLNOB KOKQXLHZDGR;

		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private static readonly Log ALDXGIVBEKZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly HashSet<DisconnectHandler> QUVCGSOCFMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public ClientState BIISUWTDTNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private WABBHQTINSC VQRBFULQSUE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private RSACryptoServiceProvider BUHIHUENSVA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private RSACryptoServiceProvider NRRCIDSTPEZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private AesCryptoServiceProvider GUREWXYEXBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private byte[] RZREDMZDMBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private TaskCompletionSource<VoidType> LLTIIJZELAE;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public WABBHQTINSC SBKQLLCVCMS
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xD11A30", Offset = "0xD10430", VA = "0x180D11A30", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Task EKXRFZTFJJJ
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x9AC67C0", Offset = "0x9AC51C0", VA = "0x189AC67C0", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9AC6B20", Offset = "0x9AC5520", VA = "0x189AC6B20", Slot = "8")]
		public void VKMGEYSOSCK(DisconnectHandler a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9AC5BB0", Offset = "0x9AC45B0", VA = "0x189AC5BB0", Slot = "11")]
		public bool PGELOIVUMEU(WABBHQTINSC a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9AC6DD0", Offset = "0x9AC57D0", VA = "0x189AC6DD0")]
		[RecRoom.NoEngine.Common.Preserve]
		public TachyonClient([Inject(null)] WHWIROLHRQO networking, [Inject(null)] ISYPUZZLNOB _settingsProvider)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150")]
		private void UQPDAJIDNWL(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xD10150", Offset = "0xD0EB50", VA = "0x180D10150")]
		private void KPSFJEQMQMK(RecRoom.Networking.ClientState a, RecRoom.Networking.ClientState b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9AC5D50", Offset = "0x9AC4750", VA = "0x189AC5D50")]
		private void QULNCQJQPFS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x9AC51F0", Offset = "0x9AC3BF0", VA = "0x189AC51F0")]
		private void NXJRQYXFNCZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9AC6850", Offset = "0x9AC5250", VA = "0x189AC6850")]
		private void UZMKYTOEXKQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x9AC5A30", Offset = "0x9AC4430", VA = "0x189AC5A30")]
		private void NetworkManager_OnClientDisconnectCallback(ulong obj)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x9AC5AB0", Offset = "0x9AC44B0", VA = "0x189AC5AB0")]
		private void NetworkManager_OnClientStopped(bool isServer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9AC4F60", Offset = "0x9AC3960", VA = "0x189AC4F60")]
		private void EKDVTRNPUCT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x9AC5370", Offset = "0x9AC3D70", VA = "0x189AC5370")]
		private void NetworkManager_OnClientConnectedCallback(ulong obj)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x9AC5B30", Offset = "0x9AC4530", VA = "0x189AC5B30")]
		private void NetworkManager_OnTransportFailure()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x9AC5180", Offset = "0x9AC3B80", VA = "0x189AC5180")]
		private void GKHQUJMMECO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x9AC6640", Offset = "0x9AC5040", VA = "0x189AC6640")]
		private void SXJIRRGXCLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x9AC4B70", Offset = "0x9AC3570", VA = "0x189AC4B70")]
		private void DRKEILXACRK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x9AC6B80", Offset = "0x9AC5580", VA = "0x189AC6B80")]
		private static (IPAddress, ushort) VWMHVGQRWKN(string a)
		{
			return default((IPAddress, ushort));
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x9AC5FA0", Offset = "0x9AC49A0", VA = "0x189AC5FA0")]
		private void RVHLBMSVTWG(WABBHQTINSC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x9AC5BF0", Offset = "0x9AC45F0", VA = "0x189AC5BF0", Slot = "6")]
		[AsyncStateMachine(typeof(<ConnectToRoomInstance>d__42))]
		public Task<WABBHQTINSC> QBDEUCYUOYM(WABBHQTINSC a, object b, [Optional] CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x9AC6CB0", Offset = "0x9AC56B0", VA = "0x189AC6CB0")]
		[AsyncStateMachine(typeof(<LogWhileInRoom>d__43))]
		private void YHCYSPFDGAO(Task<VoidType> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x9AC4E00", Offset = "0x9AC3800", VA = "0x189AC4E00", Slot = "5")]
		public Task Disconnect([Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9AC4A80", Offset = "0x9AC3480", VA = "0x189AC4A80", Slot = "7")]
		public Task CCECSFRFXJR([Optional] CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9AC4EF0", Offset = "0x9AC38F0", VA = "0x189AC4EF0", Slot = "10")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class TachyonException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x9AC7090", Offset = "0x9AC5A90", VA = "0x189AC7090")]
		public TachyonException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x9AC70F0", Offset = "0x9AC5AF0", VA = "0x189AC70F0")]
		public TachyonException(string message, Exception innerException)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class TachyonFailedToConnectToVoiceException : TachyonException
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x9AC7160", Offset = "0x9AC5B60", VA = "0x189AC7160")]
		public TachyonFailedToConnectToVoiceException([NotNull] Exception innerException)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class TachyonFailedToStartNetworkManagerException : TachyonException
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x9AC7240", Offset = "0x9AC5C40", VA = "0x189AC7240")]
		public TachyonFailedToStartNetworkManagerException()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class TachyonAlreadyDisconnectedException : TachyonException
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9AC4A00", Offset = "0x9AC3400", VA = "0x189AC4A00")]
		public TachyonAlreadyDisconnectedException()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public static class FEYNZXUTVAO
	{
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static AesCryptoServiceProvider UTTBHJNSIXM;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private static readonly string QYRAWBECNHZ;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static readonly string MPDNGAZCAUT;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private static readonly string BBDYRZSWFQH;

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x9AC2160", Offset = "0x9AC0B60", VA = "0x189AC2160")]
		public static string FWXYYVCHBRR()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x9AC21B0", Offset = "0x9AC0BB0", VA = "0x189AC21B0")]
		public static string QDIZCNAHUSV()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9AC2200", Offset = "0x9AC0C00", VA = "0x189AC2200")]
		public static AesCryptoServiceProvider XKCIWPZHJCA()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class SQABOVNBEME : ERCNSIQRTVN
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
		private DYNHRMPGIXT XQBIKLOHMTX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private NetworkManager MIQOOVOMOMI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		protected readonly ISYPUZZLNOB KOKQXLHZDGR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskCompletionSource<bool> HMVYRKDGMWU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public ClientState BIISUWTDTNF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private RSACryptoServiceProvider BUHIHUENSVA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private RSACryptoServiceProvider NRRCIDSTPEZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private AesCryptoServiceProvider GUREWXYEXBD;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public DYNHRMPGIXT QDBPTYDEQPX
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xD117B0", Offset = "0xD101B0", VA = "0x180D117B0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public string KXVOIELCUSI
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xD12280", Offset = "0xD10C80", VA = "0x180D12280", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xD11B50", Offset = "0xD10550", VA = "0x180D11B50")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public string GRWZMJHKIMX
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x9AC2C40", Offset = "0x9AC1640", VA = "0x189AC2C40", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x9AC4860", Offset = "0x9AC3260", VA = "0x189AC4860")]
		[UnityEngine.Scripting.Preserve]
		public SQABOVNBEME([Inject(null)] ISYPUZZLNOB _settingsProvider)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x9AC3E50", Offset = "0x9AC2850", VA = "0x189AC3E50")]
		private void QULNCQJQPFS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x9AC37A0", Offset = "0x9AC21A0", VA = "0x189AC37A0")]
		private void NXJRQYXFNCZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x9AC3A20", Offset = "0x9AC2420", VA = "0x189AC3A20")]
		private void NetworkManager_OnClientDisconnectCallback(ulong obj)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x9AC3300", Offset = "0x9AC1D00", VA = "0x189AC3300")]
		private void LLEMJEODZCK(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x9AC38D0", Offset = "0x9AC22D0", VA = "0x189AC38D0")]
		private void NetworkManager_OnClientConnectedCallback(ulong obj)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x9AC3D60", Offset = "0x9AC2760", VA = "0x189AC3D60")]
		private void NetworkManager_OnTransportFailure()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x9AC3290", Offset = "0x9AC1C90", VA = "0x189AC3290")]
		private void GKHQUJMMECO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x9AC2D60", Offset = "0x9AC1760", VA = "0x189AC2D60")]
		private void DRKEILXACRK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x9AC4730", Offset = "0x9AC3130", VA = "0x189AC4730")]
		private static (IPAddress, ushort) VWMHVGQRWKN(string a)
		{
			return default((IPAddress, ushort));
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x9AC4040", Offset = "0x9AC2A40", VA = "0x189AC4040")]
		private void RVHLBMSVTWG(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x9AC2EC0", Offset = "0x9AC18C0", VA = "0x189AC2EC0", Slot = "7")]
		public Task<bool> EFJCGNGZDVL(string a, string b, string c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x9AC2E20", Offset = "0x9AC1820", VA = "0x189AC2E20", Slot = "8")]
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
