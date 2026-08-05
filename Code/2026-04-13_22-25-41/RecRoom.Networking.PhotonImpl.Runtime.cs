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
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17840", VA = "0x180D18E40")]
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
		[Cpp2IlInjected.Address(RVA = "0x9958C40", Offset = "0x9957640", VA = "0x189958C40")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xD19810", Offset = "0xD18210", VA = "0x180D19810")]
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
		[Cpp2IlInjected.Address(RVA = "0xD19850", Offset = "0xD18250", VA = "0x180D19850")]
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
		[Cpp2IlInjected.Address(RVA = "0x9958B80", Offset = "0x9957580", VA = "0x189958B80", Slot = "4")]
		public override void SIFQFAPRLAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17840", VA = "0x180D18E40")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace RecRoom.RoomLoading.PhotonClients
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public interface WDFPTPKJYYM
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "0")]
		object CFZWLDTPTNA(ENCTOCDBFMR a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public interface PFLPMHBFCSJ : IDisposable
	{
		[Cpp2IlInjected.Token(Token = "0x17000001")]
		WTHWEQNRTBJ FPBEGOCQCMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		Task ELETPOPMQXG
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
		Task<WTHWEQNRTBJ> MYFFHLFDDYT(WTHWEQNRTBJ a, object b, [Optional] CancellationToken c);

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task AKRBGVFPZEO([Optional] CancellationToken a);

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "4")]
		void OASFMSDWUAR(DisconnectHandler a);
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public interface ZTLEQJPTSUS
	{
		[Cpp2IlInjected.Token(Token = "0x17000003")]
		YZDETVQVLVA SIEERCOAYYO
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		string QWJRPHQUURL
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		string ELZIDLQFDYW
		{
			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "3")]
		Task<bool> GOARBZEANBG(string a, string b, string c);

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "4")]
		Task Disconnect([Optional] CancellationToken cancellationToken);
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	internal static class TYQACIIQAXB
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		[CompilerGenerated]
		private sealed class XCJTOHJAGEC<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			public TaskCompletionSource<a> VRLFPLAXGXU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000005")]
			public TMYXSDLHSTG JHKLDYVTMCJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			public SEVTAIXPQCI ZEPEQNJDATU;

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			public XCJTOHJAGEC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x50BBB60", Offset = "0x50BA560", VA = "0x1850BBB60")]
			internal void QSLRRITZUCU(DisconnectCause a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x50BB940", Offset = "0x50BA340", VA = "0x1850BB940")]
			internal void NTPGCGOAAAH(string a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x50BBDD0", Offset = "0x50BA7D0", VA = "0x1850BBDD0")]
			internal void WVPPZDCKWAG(Task<a> a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		[CompilerGenerated]
		private sealed class XJFHWFZXXQX<a>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			public TaskCompletionSource<a> VRLFPLAXGXU;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			public SEVTAIXPQCI ZEPEQNJDATU;

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
			public XJFHWFZXXQX()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x50C37B0", Offset = "0x50C21B0", VA = "0x1850C37B0")]
			internal void WEZSDIYLNGI(short a, string b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x50C31A0", Offset = "0x50C1BA0", VA = "0x1850C31A0")]
			internal void CSHBMTPMJXJ(short a, string b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x50C2E10", Offset = "0x50C1810", VA = "0x1850C2E10")]
			internal void AXJQLZFWIOD(Task<a> a)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static Log AWZAYZHQABY;

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x3F5FB80", Offset = "0x3F5E580", VA = "0x183F5FB80")]
		public static void KMOFTUYOCZE<a>(this SEVTAIXPQCI a, TaskCompletionSource<a> b, [NotNull] TMYXSDLHSTG networkClient)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x3F5F610", Offset = "0x3F5E010", VA = "0x183F5F610")]
		public static void EUTQIVTCZTX<b>(this SEVTAIXPQCI a, TaskCompletionSource<b> b)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public interface CVPAFACPWQC
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
		[Cpp2IlInjected.Address(RVA = "0xD09BA0", Offset = "0xD085A0", VA = "0x180D09BA0", Slot = "4")]
		public bool Equals(VoidType other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x995CA80", Offset = "0x995B480", VA = "0x18995CA80", Slot = "0")]
		public override bool Equals(object obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF40", Offset = "0xCEE940", VA = "0x180CEFF40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class PhotonClientException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9958CC0", Offset = "0x99576C0", VA = "0x189958CC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9958FE0", Offset = "0x99579E0", VA = "0x189958FE0")]
		public PhotonDisconnectException(DisconnectCause disconnectCause, Exception innerException, int? lastExceptionStatusCode)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9958D20", Offset = "0x9957720", VA = "0x189958D20")]
		public static PhotonDisconnectException EZFNXMRNMIB(DisconnectCause a, TMYXSDLHSTG b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public class PhotonAuthException : PhotonClientException
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9958CC0", Offset = "0x99576C0", VA = "0x189958CC0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9959200", Offset = "0x9957C00", VA = "0x189959200")]
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
		[Cpp2IlInjected.Address(RVA = "0x9959120", Offset = "0x9957B20", VA = "0x189959120")]
		public PhotonRoomCreateException(short errorCode, string debugMsg)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000017")]
	public class PhotonInvalidNetworkQueueStateException : PhotonClientException
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x9958CC0", Offset = "0x99576C0", VA = "0x189958CC0")]
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
	public class ENCTOCDBFMR : IEquatable<ENCTOCDBFMR>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public readonly string JNWZICABEQX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public readonly string? KNONPEOUPIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public readonly string? QGUZTGVZHQS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public readonly string? LKPYNPFNCMS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public readonly string YWPRUTEUAYL;

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x9958A40", Offset = "0x9957440", VA = "0x189958A40")]
		public ENCTOCDBFMR(string photonRealtimeAppId, string? a, string? b, string? c, string authToken)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x99589E0", Offset = "0x99573E0", VA = "0x1899589E0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x9958860", Offset = "0x9957260", VA = "0x189958860", Slot = "4")]
		public bool Equals(ENCTOCDBFMR? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x99587D0", Offset = "0x99571D0", VA = "0x1899587D0", Slot = "0")]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x99588F0", Offset = "0x99572F0", VA = "0x1899588F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class WTHWEQNRTBJ : ENCTOCDBFMR, IEquatable<WTHWEQNRTBJ>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public readonly string VCOVMHXOVCI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public readonly string? UVLTYPGUBBA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public readonly string? TAWXAQZIDSI;

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x995CDE0", Offset = "0x995B7E0", VA = "0x18995CDE0")]
		public WTHWEQNRTBJ(string a, string b, string c, string? photonRegion, string d, string e, string? voiceConnectionInfo, string? voiceServerId)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x995CD80", Offset = "0x995B780", VA = "0x18995CD80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x995CBC0", Offset = "0x995B5C0", VA = "0x18995CBC0", Slot = "5")]
		public bool Equals(WTHWEQNRTBJ? other)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x995CAF0", Offset = "0x995B4F0", VA = "0x18995CAF0", Slot = "0")]
		public override bool Equals(object? obj)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x995CC40", Offset = "0x995B640", VA = "0x18995CC40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x1587D20", Offset = "0x1586720", VA = "0x181587D20")]
		public static bool OOOEUMVNSLV(WTHWEQNRTBJ? a, WTHWEQNRTBJ? b)
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
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2D10", VA = "0x180CF4310")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xCF43C0", Offset = "0xCF2DC0", VA = "0x180CF43C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xCF1A10", Offset = "0xCF0410", VA = "0x180CF1A10")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF1D90", Offset = "0xCF0790", VA = "0x180CF1D90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xCF1770", Offset = "0xCF0170", VA = "0x180CF1770")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4350", Offset = "0xCF2D50", VA = "0x180CF4350")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xCF1780", Offset = "0xCF0180", VA = "0x180CF1780")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4C20", Offset = "0xCF3620", VA = "0x180CF4C20")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xCF64C0", Offset = "0xCF4EC0", VA = "0x180CF64C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4300", Offset = "0xCF2D00", VA = "0x180CF4300")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xCF4530", Offset = "0xCF2F30", VA = "0x180CF4530")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2D10", VA = "0x180CF4310")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xCF43C0", Offset = "0xCF2DC0", VA = "0x180CF43C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF1D40", Offset = "0xCF0740", VA = "0x180CF1D40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xCF1A10", Offset = "0xCF0410", VA = "0x180CF1A10")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF4E50", VA = "0x180CF6450")]
		public ConnectionResponsePayload()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class TachyonClient : PFLPMHBFCSJ, IDisposable
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
			public AsyncTaskMethodBuilder<WTHWEQNRTBJ> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			public TachyonClient <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000035")]
			public object pauseToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x4000036")]
			public WTHWEQNRTBJ targetRoomInstance;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x4000037")]
			public CancellationToken cancellationToken;

			[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
			[Cpp2IlInjected.Token(Token = "0x4000038")]
			private IDisposable <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
			[Cpp2IlInjected.Token(Token = "0x4000039")]
			private TaskAwaiter<WTHWEQNRTBJ> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x995BC30", Offset = "0x995A630", VA = "0x18995BC30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x995C840", Offset = "0x995B240", VA = "0x18995C840", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x995C8B0", Offset = "0x995B2B0", VA = "0x18995C8B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0xD52C30", Offset = "0xD51630", VA = "0x180D52C30", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		private NetworkManager HHXAXJCDZVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		private TaskCompletionSource<WTHWEQNRTBJ> WRCCEJXESAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		protected readonly IDLXRUJKSDP ZEPEQNJDATU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		protected readonly WDFPTPKJYYM HYYSVFJFUUU;

		[Cpp2IlInjected.Token(Token = "0x4000025")]
		private static readonly Log AWZAYZHQABY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		private readonly HashSet<DisconnectHandler> DGIXTHBSIHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public ClientState VPHRCPOWBMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		private WTHWEQNRTBJ NPYUFLZZSMZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private RSACryptoServiceProvider RQYKDMXMCKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		private RSACryptoServiceProvider DBFFDQNRKEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		private AesCryptoServiceProvider GAMLZJPUTYG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private byte[] EGAGVUZNVSG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private TaskCompletionSource<VoidType> PIHIXLGVEIB;

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public WTHWEQNRTBJ FPBEGOCQCMF
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xCF43A0", Offset = "0xCF2DA0", VA = "0x180CF43A0", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public Task ELETPOPMQXG
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x9959660", Offset = "0x9958060", VA = "0x189959660", Slot = "9")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x995ADB0", Offset = "0x99597B0", VA = "0x18995ADB0", Slot = "8")]
		public void OASFMSDWUAR(DisconnectHandler a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x99596F0", Offset = "0x99580F0", VA = "0x1899596F0", Slot = "11")]
		public bool CLQAYEGOEIP(WTHWEQNRTBJ a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x995B740", Offset = "0x995A140", VA = "0x18995B740")]
		[RecRoom.NoEngine.Common.Preserve]
		public TachyonClient([Inject(null)] IDLXRUJKSDP networking, [Inject(null)] WDFPTPKJYYM _settingsProvider)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30")]
		private void JDMQVQGLPQS(bool a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0xCEFF30", Offset = "0xCEE930", VA = "0x180CEFF30")]
		private void NYLPITRVJVF(RecRoom.Networking.ClientState a, RecRoom.Networking.ClientState b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9959900", Offset = "0x9958300", VA = "0x189959900")]
		private void LJCXKXTTOJZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x995B550", Offset = "0x9959F50", VA = "0x18995B550")]
		private void ZSHCOGIJHGS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x995AE10", Offset = "0x9959810", VA = "0x18995AE10")]
		private void RPYWSZLUPBF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x995AC30", Offset = "0x9959630", VA = "0x18995AC30")]
		private void NetworkManager_OnClientDisconnectCallback(ulong obj)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000052")]
		[Cpp2IlInjected.Address(RVA = "0x995ACB0", Offset = "0x99596B0", VA = "0x18995ACB0")]
		private void NetworkManager_OnClientStopped(bool isServer)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0x9959B50", Offset = "0x9958550", VA = "0x189959B50")]
		private void MAWWZFNFBXM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x995A570", Offset = "0x9958F70", VA = "0x18995A570")]
		private void NetworkManager_OnClientConnectedCallback(ulong obj)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x995AD30", Offset = "0x9959730", VA = "0x18995AD30")]
		private void NetworkManager_OnTransportFailure()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x9959890", Offset = "0x9958290", VA = "0x189959890")]
		private void IEGSLBAFBZR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x99593F0", Offset = "0x9957DF0", VA = "0x1899593F0")]
		private void ADRNBBSAYJP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0x995B2C0", Offset = "0x9959CC0", VA = "0x18995B2C0")]
		private void ZEMARUAWHZF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x995B190", Offset = "0x9959B90", VA = "0x18995B190")]
		private static (IPAddress, ushort) XMBESVPAQAC(string a)
		{
			return default((IPAddress, ushort));
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x9959D70", Offset = "0x9958770", VA = "0x189959D70")]
		private void MJZIUALBZCP(WTHWEQNRTBJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x995A410", Offset = "0x9958E10", VA = "0x18995A410", Slot = "6")]
		[AsyncStateMachine(typeof(<ConnectToRoomInstance>d__42))]
		public Task<WTHWEQNRTBJ> MYFFHLFDDYT(WTHWEQNRTBJ a, object b, [Optional] CancellationToken c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x995B0E0", Offset = "0x9959AE0", VA = "0x18995B0E0")]
		[AsyncStateMachine(typeof(<LogWhileInRoom>d__43))]
		private void VXCCQFHVSKT(Task<VoidType> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x9959730", Offset = "0x9958130", VA = "0x189959730", Slot = "5")]
		public Task Disconnect([Optional] CancellationToken cancellationToken)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x9959570", Offset = "0x9957F70", VA = "0x189959570", Slot = "7")]
		public Task AKRBGVFPZEO([Optional] CancellationToken a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x9959820", Offset = "0x9958220", VA = "0x189959820", Slot = "10")]
		public void Dispose()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class TachyonException : Exception
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x995BA00", Offset = "0x995A400", VA = "0x18995BA00")]
		public TachyonException(string message)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x995BA60", Offset = "0x995A460", VA = "0x18995BA60")]
		public TachyonException(string message, Exception innerException)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public class TachyonFailedToConnectToVoiceException : TachyonException
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x995BAD0", Offset = "0x995A4D0", VA = "0x18995BAD0")]
		public TachyonFailedToConnectToVoiceException([NotNull] Exception innerException)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class TachyonFailedToStartNetworkManagerException : TachyonException
	{
		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x995BBB0", Offset = "0x995A5B0", VA = "0x18995BBB0")]
		public TachyonFailedToStartNetworkManagerException()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class TachyonAlreadyDisconnectedException : TachyonException
	{
		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x9959370", Offset = "0x9957D70", VA = "0x189959370")]
		public TachyonAlreadyDisconnectedException()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public static class DQHSYOQWEVN
	{
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private static AesCryptoServiceProvider YZSJTCQSFZP;

		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private static readonly string VGACKSKDAYQ;

		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private static readonly string TRFMREFXYYC;

		[Cpp2IlInjected.Token(Token = "0x4000041")]
		private static readonly string OLPYPJCJGHC;

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(RVA = "0x99584F0", Offset = "0x9956EF0", VA = "0x1899584F0")]
		public static string BGWMUDNVUQQ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x9958540", Offset = "0x9956F40", VA = "0x189958540")]
		public static string GFOGULTUGHO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x9958590", Offset = "0x9956F90", VA = "0x189958590")]
		public static AesCryptoServiceProvider ZUQCDDDKWUR()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public class ALLDKJGLDOD : ZTLEQJPTSUS
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
		private YZDETVQVLVA MUSORYCVIKS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		private NetworkManager HHXAXJCDZVH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		protected readonly WDFPTPKJYYM HYYSVFJFUUU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private TaskCompletionSource<bool> CDJGNSZQFVX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public ClientState VPHRCPOWBMK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private RSACryptoServiceProvider RQYKDMXMCKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private RSACryptoServiceProvider DBFFDQNRKEM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private AesCryptoServiceProvider GAMLZJPUTYG;

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public YZDETVQVLVA SIEERCOAYYO
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2D10", VA = "0x180CF4310", Slot = "4")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public string QWJRPHQUURL
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xCF4300", Offset = "0xCF2D00", VA = "0x180CF4300", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xCF4530", Offset = "0xCF2F30", VA = "0x180CF4530")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public string ELZIDLQFDYW
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x9956C10", Offset = "0x9955610", VA = "0x189956C10", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x9958350", Offset = "0x9956D50", VA = "0x189958350")]
		[UnityEngine.Scripting.Preserve]
		public ALLDKJGLDOD([Inject(null)] WDFPTPKJYYM _settingsProvider)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x9956D30", Offset = "0x9955730", VA = "0x189956D30")]
		private void LJCXKXTTOJZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x9958220", Offset = "0x9956C20", VA = "0x189958220")]
		private void ZSHCOGIJHGS()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x9957760", Offset = "0x9956160", VA = "0x189957760")]
		private void NetworkManager_OnClientDisconnectCallback(ulong obj)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x9957B90", Offset = "0x9956590", VA = "0x189957B90")]
		private void SQDEDARLKHL(ulong a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x9957610", Offset = "0x9956010", VA = "0x189957610")]
		private void NetworkManager_OnClientConnectedCallback(ulong obj)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x9957AA0", Offset = "0x99564A0", VA = "0x189957AA0")]
		private void NetworkManager_OnTransportFailure()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x9956BA0", Offset = "0x99555A0", VA = "0x189956BA0")]
		private void IEGSLBAFBZR()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x9958160", Offset = "0x9956B60", VA = "0x189958160")]
		private void ZEMARUAWHZF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x9958030", Offset = "0x9956A30", VA = "0x189958030")]
		private static (IPAddress, ushort) XMBESVPAQAC(string a)
		{
			return default((IPAddress, ushort));
		}

		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x9956F20", Offset = "0x9955920", VA = "0x189956F20")]
		private void MJZIUALBZCP(string a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x99567D0", Offset = "0x99551D0", VA = "0x1899567D0", Slot = "7")]
		public Task<bool> GOARBZEANBG(string a, string b, string c)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x9956730", Offset = "0x9955130", VA = "0x189956730", Slot = "8")]
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
