using System;
using System.Buffers;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Circuits.Shared.Api;
using Circuits.Static.EV.Protobuf;
using CircuitsV2.Protobuf;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using Google.Protobuf.WellKnownTypes;
using Microsoft.CodeAnalysis;
using RecRoom.NoEngine.Common;
using RecRoom.NoEngine.DataStructures;
using RecRoom.Protobuf;
using RecRoom.Protobuf.Core;
using RecRoom.Versioning.Framework;
using Unity.Mathematics;

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
		[Cpp2IlInjected.Address(RVA = "0xA5774D0", Offset = "0xA575ED0", VA = "0x18A5774D0")]
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
namespace RecRoom.Versioning
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public static class KSSLZKXRPPF
	{
		[Cpp2IlInjected.Token(Token = "0x2000006")]
		public interface EDIRCJTODTF : DZQZMCFTDKX<PersistedRoomData, DEPRECATED_RoomPersistenceVersion>
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(Slot = "0")]
			bool VLKVWJUHDZT(Guid a);

			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(Slot = "1")]
			int PTMTCOPVGAC(Guid a);

			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(Slot = "2")]
			QPTCXVGOMKO KJLSVJYLCPS(TransformData a, QPTCXVGOMKO b);

			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(Slot = "3")]
			float? JPXAHWAQHTZ(int a);

			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(Slot = "4")]
			int PGIUATSDSLE(int a);

			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(Slot = "5")]
			float OTUZVWBLMYD(int a);

			[Cpp2IlInjected.Token(Token = "0x600000D")]
			[Cpp2IlInjected.Address(Slot = "6")]
			void YASJPZVGQQX(PersistedRoomData a);

			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(Slot = "7")]
			RTOXFLYJUYF YDTGDSJYDMP();
		}

		[Cpp2IlInjected.Token(Token = "0x2000007")]
		public abstract class TOSGPLXPKRG : EDIRCJTODTF, DZQZMCFTDKX<PersistedRoomData, DEPRECATED_RoomPersistenceVersion>
		{
			[Cpp2IlInjected.Token(Token = "0x600000F")]
			[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160", Slot = "12")]
			public DEPRECATED_RoomPersistenceVersion TZHKUUOLFOF()
			{
				return default(DEPRECATED_RoomPersistenceVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000010")]
			[Cpp2IlInjected.Address(RVA = "0xA579DD0", Offset = "0xA5787D0", VA = "0x18A579DD0", Slot = "13")]
			public DEPRECATED_RoomPersistenceVersion QKDXREEQPMH()
			{
				return default(DEPRECATED_RoomPersistenceVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x1B11150", Offset = "0x1B0FB50", VA = "0x181B11150", Slot = "14")]
			public DEPRECATED_RoomPersistenceVersion Increment(DEPRECATED_RoomPersistenceVersion version)
			{
				return default(DEPRECATED_RoomPersistenceVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000012")]
			[Cpp2IlInjected.Address(RVA = "0x2F46980", Offset = "0x2F45380", VA = "0x182F46980", Slot = "15")]
			public bool DNBDBASICLG(DEPRECATED_RoomPersistenceVersion a, DEPRECATED_RoomPersistenceVersion b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xA579E40", Offset = "0xA578840", VA = "0x18A579E40", Slot = "16")]
			public string ToString(DEPRECATED_RoomPersistenceVersion version)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(Slot = "17")]
			public abstract bool VLKVWJUHDZT(Guid a);

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(Slot = "18")]
			public abstract int PTMTCOPVGAC(Guid a);

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xA579D00", Offset = "0xA578700", VA = "0x18A579D00", Slot = "6")]
			public QPTCXVGOMKO KJLSVJYLCPS(TransformData a, QPTCXVGOMKO b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(Slot = "19")]
			public abstract float? JPXAHWAQHTZ(int a);

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(Slot = "20")]
			public abstract int PGIUATSDSLE(int a);

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "21")]
			public abstract float OTUZVWBLMYD(int a);

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(Slot = "22")]
			public abstract void YASJPZVGQQX(PersistedRoomData a);

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(Slot = "23")]
			public abstract RTOXFLYJUYF YDTGDSJYDMP();

			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			protected TOSGPLXPKRG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000008")]
		public static class DWVJJDNSDAG
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		public static class MCBXLTUAWON
		{
			[Cpp2IlInjected.Token(Token = "0x4000004")]
			private static readonly string CWTZPEQGQDX;

			[Cpp2IlInjected.Token(Token = "0x4000005")]
			private static readonly string RKILINEHIPO;

			[Cpp2IlInjected.Token(Token = "0x4000006")]
			private static readonly string OCNAZGZIQFV;

			[Cpp2IlInjected.Token(Token = "0x4000007")]
			private static readonly string IEQUWMUKCZT;

			[Cpp2IlInjected.Token(Token = "0x4000008")]
			private static readonly string MXNHBVHOBYZ;

			[Cpp2IlInjected.Token(Token = "0x4000009")]
			private static readonly string IQYBPLQUJFE;

			[Cpp2IlInjected.Token(Token = "0x400000A")]
			private static readonly string[] HPSICCUXKOT;

			[Cpp2IlInjected.Token(Token = "0x400000B")]
			private static readonly string[] MKODLCAGDIJ;

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xA576310", Offset = "0xA574D10", VA = "0x18A576310")]
			public static void Run(EDIRCJTODTF deps, PersistedRoomData data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xA5756C0", Offset = "0xA5740C0", VA = "0x18A5756C0")]
			private static void NYSCLKRMJEP(PersistedRoomData a)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xA5753F0", Offset = "0xA573DF0", VA = "0x18A5753F0")]
			private static void HMJRWILDLLU(PersistedRoomData a, Func<OIVAIHOALCY, SZVATJHPYQP> b)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xA5751D0", Offset = "0xA573BD0", VA = "0x18A5751D0")]
			private static OIVAIHOALCY GKTXPVPYNRP(PersistedRoomData a, string b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xA575130", Offset = "0xA573B30", VA = "0x18A575130")]
			private static void FUYONWRPDZJ(PersistedRoomData a, string b, Func<OIVAIHOALCY, SZVATJHPYQP> c, bool d)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xA575620", Offset = "0xA574020", VA = "0x18A575620")]
			private static void IWZUMENNJUY(PersistedRoomData a, string b, Func<OIVAIHOALCY, PHRRLRNBRQQ> c, int d)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xA574FF0", Offset = "0xA5739F0", VA = "0x18A574FF0")]
			private static void DNMKGWKDHED(PersistedRoomData a, string b, Func<OIVAIHOALCY, SZVATJHPYQP> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0xA575090", Offset = "0xA573A90", VA = "0x18A575090")]
			private static void DNMKGWKDHED(PersistedRoomData a, string b, Func<OIVAIHOALCY, PHRRLRNBRQQ> c)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0xA574F50", Offset = "0xA573950", VA = "0x18A574F50")]
			private static void CKVOSVCWTIA(PersistedRoomData a, string b, Func<OIVAIHOALCY, SZVATJHPYQP> c)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public static class MBWQONADNDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0xA574B70", Offset = "0xA573570", VA = "0x18A574B70")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000C")]
		public static class MBRJRGGGDRV
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xA5749A0", Offset = "0xA5733A0", VA = "0x18A5749A0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000D")]
		public static class MCWZAUVQIHX
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xA577230", Offset = "0xA575C30", VA = "0x18A577230")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000E")]
		public static class MCRSDOBSYWO
		{
			[Cpp2IlInjected.Token(Token = "0x4000018")]
			private static readonly Guid ROBVRGJXISW;

			[Cpp2IlInjected.Token(Token = "0x4000019")]
			private static readonly ByteString XNBBOYMWQIU;

			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xA576E10", Offset = "0xA575810", VA = "0x18A576E10")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000F")]
		public static class MCMLGHHVPLF
		{
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			private static readonly Guid YJJHAYRRYJO;

			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0xA576AB0", Offset = "0xA5754B0", VA = "0x18A576AB0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000010")]
		public static class MCHEJANYFZW
		{
			[Cpp2IlInjected.Token(Token = "0x600003C")]
			[Cpp2IlInjected.Address(RVA = "0xA5768F0", Offset = "0xA5752F0", VA = "0x18A5768F0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000011")]
		public static class MALUHRQVZBT
		{
			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xA5747E0", Offset = "0xA5731E0", VA = "0x18A5747E0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000012")]
		public static class MAGNKKWYPQK
		{
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			private static readonly Guid CRTEZJKNZUM;

			[Cpp2IlInjected.Token(Token = "0x400001C")]
			private static readonly Guid AVKPSCWCZBK;

			[Cpp2IlInjected.Token(Token = "0x400001D")]
			private static readonly Guid KIGOVIXPBHS;

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0xA573F60", Offset = "0xA572960", VA = "0x18A573F60")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000013")]
		public static class UZVNMYUFEUO
		{
			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0xA58D2F0", Offset = "0xA58BCF0", VA = "0x18A58D2F0")]
			public static void Run(EDIRCJTODTF deps, PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000014")]
		public static class TCTCKMCDMGW
		{
			[Cpp2IlInjected.Token(Token = "0x400001E")]
			private static readonly Guid ATFCGAGFGMK;

			[Cpp2IlInjected.Token(Token = "0x400001F")]
			private static readonly Guid PEUNWZUVJKG;

			[Cpp2IlInjected.Token(Token = "0x4000020")]
			private static readonly Dictionary<int, Guid> VYWRPHJVYVA;

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xA579060", Offset = "0xA577A60", VA = "0x18A579060")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000015")]
		public static class TCYJHSWAVSF
		{
			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0xA579A20", Offset = "0xA578420", VA = "0x18A579A20")]
			public static void Run(EDIRCJTODTF deps, PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000016")]
		public static class TCNVNFIGCVN
		{
			[Cpp2IlInjected.Token(Token = "0x6000044")]
			[Cpp2IlInjected.Address(RVA = "0xA578CC0", Offset = "0xA5776C0", VA = "0x18A578CC0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000017")]
		public static class TBYAVLAOANM
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000018")]
		public static class TCDHSRULJYV
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0xA578A70", Offset = "0xA577470", VA = "0x18A578A70")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000019")]
		public static class TBNNAXMTHQU
		{
			[Cpp2IlInjected.Token(Token = "0x6000047")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public static class TBSTYEGQRCD
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xA578880", Offset = "0xA577280", VA = "0x18A578880")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001B")]
		public static class TBCZGJYYOUC
		{
			[Cpp2IlInjected.Token(Token = "0x4000021")]
			private static readonly Guid TMDARHTDLVQ;

			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xA5778A0", Offset = "0xA5762A0", VA = "0x18A5778A0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001C")]
		public static class TBIGDQSVYFL
		{
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0xA577DD0", Offset = "0xA5767D0", VA = "0x18A577DD0")]
			public static void Run(EDIRCJTODTF deps, PersistedRoomData data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0xA577D20", Offset = "0xA576720", VA = "0x18A577D20")]
			private static quaternion NWXBHTIRKKT(QPTCXVGOMKO a)
			{
				return default(quaternion);
			}

			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0xA577BC0", Offset = "0xA5765C0", VA = "0x18A577BC0")]
			private static QPTCXVGOMKO FBVAFBDZEYO(EDIRCJTODTF a, float3 b, quaternion c, int d)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xA578330", Offset = "0xA576D30", VA = "0x18A578330")]
			private static QPTCXVGOMKO UEJCAEYIBUK(EDIRCJTODTF a, float3 b, quaternion c, int d, bool e)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001D")]
		public static class ZWXUSVXMMAD
		{
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xA58FC70", Offset = "0xA58E670", VA = "0x18A58FC70")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public static class ZWSNVPDPCOU
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0xA58FAA0", Offset = "0xA58E4A0", VA = "0x18A58FAA0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200001F")]
		public static class ZXDBQCRJVLM
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0xA58FEA0", Offset = "0xA58E8A0", VA = "0x18A58FEA0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000020")]
		public static class ZXSWHWZBXTN
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xA5902E0", Offset = "0xA58ECE0", VA = "0x18A5902E0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public static class ZXNPKQFEOIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0xA590090", Offset = "0xA58EA90", VA = "0x18A590090")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000022")]
		public static class ZYDKCKMWQQF
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0xD11150", Offset = "0xD0FB50", VA = "0x180D11150")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public static class ZXYDFDSZHEW
		{
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xA5904A0", Offset = "0xA58EEA0", VA = "0x18A5904A0")]
			public static void Run(EDIRCJTODTF deps, PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		public static class ZYNXWYARJMX
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0xA590730", Offset = "0xA58F130", VA = "0x18A590730")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000025")]
		public static class VAGBHMHZXRG
		{
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			private static readonly Guid TUZZOBRBJMI;

			[Cpp2IlInjected.Token(Token = "0x4000023")]
			private static readonly Guid QKCHILFNCPB;

			[Cpp2IlInjected.Token(Token = "0x4000024")]
			private static readonly Guid RWJRYTRIAHY;

			[Cpp2IlInjected.Token(Token = "0x4000025")]
			private static readonly Guid TMDARHTDLVQ;

			[Cpp2IlInjected.Token(Token = "0x4000026")]
			private static readonly Guid BEBGGLETHDV;

			[Cpp2IlInjected.Token(Token = "0x4000027")]
			private static readonly Guid WJCPFFOWWAV;

			[Cpp2IlInjected.Token(Token = "0x4000028")]
			private static readonly Guid MCVRICYTJPW;

			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0xA58DC60", Offset = "0xA58C660", VA = "0x18A58DC60")]
			public static void Run(PersistedRoomData data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0xA58D8E0", Offset = "0xA58C2E0", VA = "0x18A58D8E0")]
			private static KTASUHXRMNA BLOFESIIMGH(Guid a)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xA58DF00", Offset = "0xA58C900", VA = "0x18A58DF00")]
			private static KTASUHXRMNA VDRRDUDJVWJ(Guid a, bool b)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0xA58DBD0", Offset = "0xA58C5D0", VA = "0x18A58DBD0")]
			private static KTASUHXRMNA GAPGAUQBZQI(Guid a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public static class VALIETBXHCP
		{
			[Cpp2IlInjected.Token(Token = "0x4000029")]
			private static readonly Guid VKSIRRGBUFM;

			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0xA58E140", Offset = "0xA58CB40", VA = "0x18A58E140")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		public static class UYADLPXCXWL
		{
			[Cpp2IlInjected.Token(Token = "0x400002A")]
			private static readonly Guid FLDSKUTATJG;

			[Cpp2IlInjected.Token(Token = "0x400002B")]
			private static readonly Guid KIGOVIXPBHS;

			[Cpp2IlInjected.Token(Token = "0x400002C")]
			private static readonly Guid BPDRDHZWOLH;

			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0xA579F70", Offset = "0xA578970", VA = "0x18A579F70")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		private static Versioner<EDIRCJTODTF, PersistedRoomData, DEPRECATED_RoomPersistenceVersion> IZQDRXDGXEK;

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xA5732A0", Offset = "0xA571CA0", VA = "0x18A5732A0")]
		public static Result<None, XZBQMYIZLTP> ACMCPWSDJUZ(EDIRCJTODTF a, PersistedRoomData b)
		{
			return default(Result<None, XZBQMYIZLTP>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public static class ATYDOOBXOUE
	{
		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0xA572580", Offset = "0xA570F80", VA = "0x18A572580")]
		public static Result<None, XZBQMYIZLTP> ACMCPWSDJUZ(KSSLZKXRPPF.EDIRCJTODTF a, SpawnableTemplateData b)
		{
			return default(Result<None, XZBQMYIZLTP>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000029")]
	public static class YRAYVNZABVG
	{
		[Cpp2IlInjected.Token(Token = "0x200002A")]
		public interface EDIRCJTODTF : DZQZMCFTDKX<PersistedRoomData, PersistedRoomVersion>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x200002B")]
		public sealed class TOSGPLXPKRG : EDIRCJTODTF, DZQZMCFTDKX<PersistedRoomData, PersistedRoomVersion>
		{
			[Cpp2IlInjected.Token(Token = "0x4000032")]
			public static TOSGPLXPKRG UIOXUQVVXGJ;

			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160", Slot = "4")]
			public PersistedRoomVersion TZHKUUOLFOF()
			{
				return default(PersistedRoomVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0xA579DE0", Offset = "0xA5787E0", VA = "0x18A579DE0", Slot = "5")]
			public PersistedRoomVersion QKDXREEQPMH()
			{
				return default(PersistedRoomVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x1B11150", Offset = "0x1B0FB50", VA = "0x181B11150", Slot = "6")]
			public PersistedRoomVersion Increment(PersistedRoomVersion version)
			{
				return default(PersistedRoomVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x2F46980", Offset = "0x2F45380", VA = "0x182F46980", Slot = "7")]
			public bool DNBDBASICLG(PersistedRoomVersion a, PersistedRoomVersion b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xA579DF0", Offset = "0xA5787F0", VA = "0x18A579DF0", Slot = "8")]
			public string ToString(PersistedRoomVersion version)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public TOSGPLXPKRG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002C")]
		public static class UZQGPSAHVJF
		{
			[Cpp2IlInjected.Token(Token = "0x4000033")]
			private static Dictionary<Guid, string[]> AJOJDDIZXNP;

			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0xA57A7F0", Offset = "0xA5791F0", VA = "0x18A57A7F0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002D")]
		public static class IUKVBTLLSPQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xA572E10", Offset = "0xA571810", VA = "0x18A572E10")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002E")]
		public static class IVFWQUNBEJA
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0xA5730D0", Offset = "0xA571AD0", VA = "0x18A5730D0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200002F")]
		public static class BYVGMOGVEUY
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0xA572A20", Offset = "0xA571420", VA = "0x18A572A20")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000030")]
		public static class BZANJVASOGH
		{
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0xA572BE0", Offset = "0xA5715E0", VA = "0x18A572BE0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000031")]
		public static class VZCINLTFWDQ
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xA58E430", Offset = "0xA58CE30", VA = "0x18A58E430")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000032")]
		public static class OZAYGNSVITI
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0xA577550", Offset = "0xA575F50", VA = "0x18A577550")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000033")]
		public static class MCWZAUVQIHX
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xA593AE0", Offset = "0xA5924E0", VA = "0x18A593AE0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public static class MCHEJANYFZW
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0xA593910", Offset = "0xA592310", VA = "0x18A593910")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000035")]
		public static class TCNVNFIGCVN
		{
			[Cpp2IlInjected.Token(Token = "0x4000034")]
			private static readonly Dictionary<Guid, int> AOCIPQGOOFG;

			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0xA5B5130", Offset = "0xA5B3B30", VA = "0x18A5B5130")]
			public static void Run(PersistedRoomData data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000079")]
			[Cpp2IlInjected.Address(RVA = "0xA5B58A0", Offset = "0xA5B42A0", VA = "0x18A5B58A0")]
			private static Dictionary<Guid, OSFDDQIVFJF> XDNCERLWBGN(OSFDDQIVFJF a, Dictionary<Guid, OSFDDQIVFJF> b)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000036")]
		public static class TBIGDQSVYFL
		{
			[Cpp2IlInjected.Token(Token = "0x600007B")]
			[Cpp2IlInjected.Address(RVA = "0xA5B4D50", Offset = "0xA5B3750", VA = "0x18A5B4D50")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000037")]
		public static class VAAUKFOCOFX
		{
			[Cpp2IlInjected.Token(Token = "0x600007C")]
			[Cpp2IlInjected.Address(RVA = "0xA5B7470", Offset = "0xA5B5E70", VA = "0x18A5B7470")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000038")]
		public static class GXOZROFPBSM
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0xA592D80", Offset = "0xA591780", VA = "0x18A592D80")]
			public static void Run(PersistedRoomData data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600007E")]
			[Cpp2IlInjected.Address(RVA = "0xA592D70", Offset = "0xA591770", VA = "0x18A592D70")]
			private static void LKDBSWOEBSZ(InteractionFilterData a, bool b = true)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000039")]
		public static class GXZNMBTJUPE
		{
			[Cpp2IlInjected.Token(Token = "0x600007F")]
			[Cpp2IlInjected.Address(RVA = "0xA593060", Offset = "0xA591A60", VA = "0x18A593060")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003A")]
		public static class GXELXARUIVU
		{
			[Cpp2IlInjected.Token(Token = "0x6000080")]
			[Cpp2IlInjected.Address(RVA = "0xA592980", Offset = "0xA591380", VA = "0x18A592980")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003B")]
		public static class GZFCVQITZFG
		{
			[Cpp2IlInjected.Token(Token = "0x6000081")]
			[Cpp2IlInjected.Address(RVA = "0xA593270", Offset = "0xA591C70", VA = "0x18A593270")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003C")]
		public static class GZKJSXCRIQP
		{
			[Cpp2IlInjected.Token(Token = "0x6000082")]
			[Cpp2IlInjected.Address(RVA = "0xA5935E0", Offset = "0xA591FE0", VA = "0x18A5935E0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003D")]
		public static class VALIETBXHCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000083")]
			[Cpp2IlInjected.Address(RVA = "0xA5B7630", Offset = "0xA5B6030", VA = "0x18A5B7630")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003E")]
		public static class NXVQVSZWYOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0xA5A43B0", Offset = "0xA5A2DB0", VA = "0x18A5A43B0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200003F")]
		public static class NXLDBFMCFRL
		{
			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0xA5A4160", Offset = "0xA5A2B60", VA = "0x18A5A4160")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000040")]
		public static class NXAPGRYHMUT
		{
			[Cpp2IlInjected.Token(Token = "0x2000041")]
			private enum LegacyStableSpawnableToolType
			{
				[Cpp2IlInjected.Token(Token = "0x4000036")]
				INVALID = -1,
				[Cpp2IlInjected.Token(Token = "0x4000037")]
				PAINTBALL_PISTOL,
				[Cpp2IlInjected.Token(Token = "0x4000038")]
				PAINTBALL_SHOTGUN,
				[Cpp2IlInjected.Token(Token = "0x4000039")]
				PAINTBALL_SNIPER_RIFLE,
				[Cpp2IlInjected.Token(Token = "0x400003A")]
				PAINTBALL_ASSAULT_RIFLE,
				[Cpp2IlInjected.Token(Token = "0x400003B")]
				PAINTBALL_GRENADE,
				[Cpp2IlInjected.Token(Token = "0x400003C")]
				PAINTBALL_SHIELD,
				[Cpp2IlInjected.Token(Token = "0x400003D")]
				PADDLEBALL_PADDLE,
				[Cpp2IlInjected.Token(Token = "0x400003E")]
				PAINTBALL_GRENADE_LAUNCHER,
				[Cpp2IlInjected.Token(Token = "0x400003F")]
				MAKER_PEN_CHARADES,
				[Cpp2IlInjected.Token(Token = "0x4000040")]
				SOCCER_SHIELD,
				[Cpp2IlInjected.Token(Token = "0x4000041")]
				ROTJ_PISTOL,
				[Cpp2IlInjected.Token(Token = "0x4000042")]
				ROTJ_RAILGUN,
				[Cpp2IlInjected.Token(Token = "0x4000043")]
				ROTJ_SHOTGUN,
				[Cpp2IlInjected.Token(Token = "0x4000044")]
				ROTJ_GRENADE,
				[Cpp2IlInjected.Token(Token = "0x4000045")]
				ROTJ_SMG,
				[Cpp2IlInjected.Token(Token = "0x4000046")]
				GT_CROSSBOW,
				[Cpp2IlInjected.Token(Token = "0x4000047")]
				GT_BOW,
				[Cpp2IlInjected.Token(Token = "0x4000048")]
				GT_SWORD,
				[Cpp2IlInjected.Token(Token = "0x4000049")]
				CANDLE,
				[Cpp2IlInjected.Token(Token = "0x400004A")]
				BELL,
				[Cpp2IlInjected.Token(Token = "0x400004B")]
				WELCOME_MAT,
				[Cpp2IlInjected.Token(Token = "0x400004C")]
				GT_SHIELD,
				[Cpp2IlInjected.Token(Token = "0x400004D")]
				BASKETBALL,
				[Cpp2IlInjected.Token(Token = "0x400004E")]
				DODGEBALL,
				[Cpp2IlInjected.Token(Token = "0x400004F")]
				DISCGOLF_DISC,
				[Cpp2IlInjected.Token(Token = "0x4000050")]
				SOLOCUP,
				[Cpp2IlInjected.Token(Token = "0x4000051")]
				WATERBOTTLE,
				[Cpp2IlInjected.Token(Token = "0x4000052")]
				DART,
				[Cpp2IlInjected.Token(Token = "0x4000053")]
				DIE,
				[Cpp2IlInjected.Token(Token = "0x4000054")]
				DEPRECATED_FLAG_RED,
				[Cpp2IlInjected.Token(Token = "0x4000055")]
				DEPRECATED_FLAG_BLUE,
				[Cpp2IlInjected.Token(Token = "0x4000056")]
				DEPRECATED_FLAG_YELLOW,
				[Cpp2IlInjected.Token(Token = "0x4000057")]
				DEPRECATED_FLAG_GREEN,
				[Cpp2IlInjected.Token(Token = "0x4000058")]
				STICKY_NOTE,
				[Cpp2IlInjected.Token(Token = "0x4000059")]
				STICKY_POSTER,
				[Cpp2IlInjected.Token(Token = "0x400005A")]
				DRAWABLE_CLIPBOARD,
				[Cpp2IlInjected.Token(Token = "0x400005B")]
				MARKER_BLACK,
				[Cpp2IlInjected.Token(Token = "0x400005C")]
				MARKER_RED,
				[Cpp2IlInjected.Token(Token = "0x400005D")]
				MARKER_BLUE,
				[Cpp2IlInjected.Token(Token = "0x400005E")]
				MARKER_GREEN,
				[Cpp2IlInjected.Token(Token = "0x400005F")]
				MARKER_YELLOW,
				[Cpp2IlInjected.Token(Token = "0x4000060")]
				MARKER_ORANGE,
				[Cpp2IlInjected.Token(Token = "0x4000061")]
				MARKER_PINK,
				[Cpp2IlInjected.Token(Token = "0x4000062")]
				MARKER_PURPLE,
				[Cpp2IlInjected.Token(Token = "0x4000063")]
				MARKER_SKYBLUE,
				[Cpp2IlInjected.Token(Token = "0x4000064")]
				MARKER_BROWN,
				[Cpp2IlInjected.Token(Token = "0x4000065")]
				ERASER,
				[Cpp2IlInjected.Token(Token = "0x4000066")]
				MARKER_ERASER,
				[Cpp2IlInjected.Token(Token = "0x4000067")]
				CHAIR,
				[Cpp2IlInjected.Token(Token = "0x4000068")]
				MICROPHONE,
				[Cpp2IlInjected.Token(Token = "0x4000069")]
				SANDBOX_TOOL_GOAL_SMALL,
				[Cpp2IlInjected.Token(Token = "0x400006A")]
				SANDBOX_TOOL_GOAL_MEDIUM,
				[Cpp2IlInjected.Token(Token = "0x400006B")]
				SANDBOX_TOOL_GOAL_LARGE,
				[Cpp2IlInjected.Token(Token = "0x400006C")]
				SANDBOX_PLAYER_GOAL,
				[Cpp2IlInjected.Token(Token = "0x400006D")]
				CONFETTI_GUN,
				[Cpp2IlInjected.Token(Token = "0x400006E")]
				PING_PONG_PADDLE,
				[Cpp2IlInjected.Token(Token = "0x400006F")]
				PING_PONG_BALL,
				[Cpp2IlInjected.Token(Token = "0x4000070")]
				CC_WAND,
				[Cpp2IlInjected.Token(Token = "0x4000071")]
				CC_HUNTER_CROSSBOW,
				[Cpp2IlInjected.Token(Token = "0x4000072")]
				RADIO,
				[Cpp2IlInjected.Token(Token = "0x4000073")]
				BUCKET,
				[Cpp2IlInjected.Token(Token = "0x4000074")]
				ARENA_EMP,
				[Cpp2IlInjected.Token(Token = "0x4000075")]
				PROPBOX_SQUARE,
				[Cpp2IlInjected.Token(Token = "0x4000076")]
				PROPBOX_RECTANGLE,
				[Cpp2IlInjected.Token(Token = "0x4000077")]
				FLATTREESMALL,
				[Cpp2IlInjected.Token(Token = "0x4000078")]
				FLATTREEMEDIUM,
				[Cpp2IlInjected.Token(Token = "0x4000079")]
				FLATTREELARGE,
				[Cpp2IlInjected.Token(Token = "0x400007A")]
				MARSHMALLOWSTICK,
				[Cpp2IlInjected.Token(Token = "0x400007B")]
				HORIZONTALWALL,
				[Cpp2IlInjected.Token(Token = "0x400007C")]
				VERTICALWALL,
				[Cpp2IlInjected.Token(Token = "0x400007D")]
				BACKSTOPSHORT,
				[Cpp2IlInjected.Token(Token = "0x400007E")]
				WINEBARREL,
				[Cpp2IlInjected.Token(Token = "0x400007F")]
				CONCRETEBLOCK,
				[Cpp2IlInjected.Token(Token = "0x4000080")]
				STONEPILLAR,
				[Cpp2IlInjected.Token(Token = "0x4000081")]
				LOGBENCH,
				[Cpp2IlInjected.Token(Token = "0x4000082")]
				SITTINGLOG,
				[Cpp2IlInjected.Token(Token = "0x4000083")]
				CONE,
				[Cpp2IlInjected.Token(Token = "0x4000084")]
				CAMPFIRE,
				[Cpp2IlInjected.Token(Token = "0x4000085")]
				STOOL,
				[Cpp2IlInjected.Token(Token = "0x4000086")]
				GLOWSTICK_BLUE,
				[Cpp2IlInjected.Token(Token = "0x4000087")]
				GLOWSTICK_RED,
				[Cpp2IlInjected.Token(Token = "0x4000088")]
				GLOWSTICK_PURPLE,
				[Cpp2IlInjected.Token(Token = "0x4000089")]
				GLOWSTICK_ORANGE,
				[Cpp2IlInjected.Token(Token = "0x400008A")]
				COUCH,
				[Cpp2IlInjected.Token(Token = "0x400008B")]
				COUCHCHAIR,
				[Cpp2IlInjected.Token(Token = "0x400008C")]
				ARENA_PISTOL,
				[Cpp2IlInjected.Token(Token = "0x400008D")]
				ARENA_GRENADE,
				[Cpp2IlInjected.Token(Token = "0x400008E")]
				ARENA_SMG,
				[Cpp2IlInjected.Token(Token = "0x400008F")]
				ARENA_SHOTGUN,
				[Cpp2IlInjected.Token(Token = "0x4000090")]
				ARENA_RAILGUN,
				[Cpp2IlInjected.Token(Token = "0x4000091")]
				ARENA_ROCKET_LAUNCHER,
				[Cpp2IlInjected.Token(Token = "0x4000092")]
				RC_CAR_SET,
				[Cpp2IlInjected.Token(Token = "0x4000093")]
				RC_CAR,
				[Cpp2IlInjected.Token(Token = "0x4000094")]
				RC_REMOTE_CONTROL,
				[Cpp2IlInjected.Token(Token = "0x4000095")]
				CC_MEAT_SWORD,
				[Cpp2IlInjected.Token(Token = "0x4000096")]
				CC_FIRE_POTION,
				[Cpp2IlInjected.Token(Token = "0x4000097")]
				D20,
				[Cpp2IlInjected.Token(Token = "0x4000098")]
				D12,
				[Cpp2IlInjected.Token(Token = "0x4000099")]
				D10,
				[Cpp2IlInjected.Token(Token = "0x400009A")]
				D8,
				[Cpp2IlInjected.Token(Token = "0x400009B")]
				D6,
				[Cpp2IlInjected.Token(Token = "0x400009C")]
				D4,
				[Cpp2IlInjected.Token(Token = "0x400009D")]
				DICE_SET,
				[Cpp2IlInjected.Token(Token = "0x400009E")]
				POKERCHAIR,
				[Cpp2IlInjected.Token(Token = "0x400009F")]
				PLANT_FIG,
				[Cpp2IlInjected.Token(Token = "0x40000A0")]
				PLANT_DRACAENA,
				[Cpp2IlInjected.Token(Token = "0x40000A1")]
				PLANT_SNAKE,
				[Cpp2IlInjected.Token(Token = "0x40000A2")]
				TABLE_MEETING,
				[Cpp2IlInjected.Token(Token = "0x40000A3")]
				TABLE_COFFEE_LARGE,
				[Cpp2IlInjected.Token(Token = "0x40000A4")]
				HAM,
				[Cpp2IlInjected.Token(Token = "0x40000A5")]
				TABLE_PINGPONG,
				[Cpp2IlInjected.Token(Token = "0x40000A6")]
				SPEAKER,
				[Cpp2IlInjected.Token(Token = "0x40000A7")]
				MICROPHONE_STAND,
				[Cpp2IlInjected.Token(Token = "0x40000A8")]
				TABLE_TALL,
				[Cpp2IlInjected.Token(Token = "0x40000A9")]
				TABLE_SHORT,
				[Cpp2IlInjected.Token(Token = "0x40000AA")]
				BOOKSHELF_SHORT,
				[Cpp2IlInjected.Token(Token = "0x40000AB")]
				BOOKSHELF_TALL,
				[Cpp2IlInjected.Token(Token = "0x40000AC")]
				LOCKERS,
				[Cpp2IlInjected.Token(Token = "0x40000AD")]
				BOOK_YELLOW,
				[Cpp2IlInjected.Token(Token = "0x40000AE")]
				BOOK_GREEN,
				[Cpp2IlInjected.Token(Token = "0x40000AF")]
				MOCKTAIL_SHAKER,
				[Cpp2IlInjected.Token(Token = "0x40000B0")]
				MOCKTAIL_STEMLESS,
				[Cpp2IlInjected.Token(Token = "0x40000B1")]
				MOCKTAIL_MARTINI,
				[Cpp2IlInjected.Token(Token = "0x40000B2")]
				MOCKTAIL_MILKSHAKE,
				[Cpp2IlInjected.Token(Token = "0x40000B3")]
				MOCKTAIL_GOBLET,
				[Cpp2IlInjected.Token(Token = "0x40000B4")]
				MOCKTAIL_MARGARITA,
				[Cpp2IlInjected.Token(Token = "0x40000B5")]
				MOCKTAIL_TALL,
				[Cpp2IlInjected.Token(Token = "0x40000B6")]
				MINIFRIDGE,
				[Cpp2IlInjected.Token(Token = "0x40000B7")]
				DEPRECATED_ROOM_DOOR,
				[Cpp2IlInjected.Token(Token = "0x40000B8")]
				SNOWBALL,
				[Cpp2IlInjected.Token(Token = "0x40000B9")]
				SNOWBALL_PILE,
				[Cpp2IlInjected.Token(Token = "0x40000BA")]
				POLAROID,
				[Cpp2IlInjected.Token(Token = "0x40000BB")]
				PIRATE_CUTLASS,
				[Cpp2IlInjected.Token(Token = "0x40000BC")]
				PIRATE_RUM_JUG,
				[Cpp2IlInjected.Token(Token = "0x40000BD")]
				PIRATE_BEER_BOTTLE,
				[Cpp2IlInjected.Token(Token = "0x40000BE")]
				OUTPUT_NODE,
				[Cpp2IlInjected.Token(Token = "0x40000BF")]
				COMBINATOR_NODE,
				[Cpp2IlInjected.Token(Token = "0x40000C0")]
				COMPARER_NODE,
				[Cpp2IlInjected.Token(Token = "0x40000C1")]
				VARIABLE_NODE,
				[Cpp2IlInjected.Token(Token = "0x40000C2")]
				TIMER_NODE,
				[Cpp2IlInjected.Token(Token = "0x40000C3")]
				DELAY_NODE,
				[Cpp2IlInjected.Token(Token = "0x40000C4")]
				MESSAGE_NODE,
				[Cpp2IlInjected.Token(Token = "0x40000C5")]
				BOOLEAN_NODE,
				[Cpp2IlInjected.Token(Token = "0x40000C6")]
				IMPULSE_BUTTON,
				[Cpp2IlInjected.Token(Token = "0x40000C7")]
				DISCGOLF_GOAL,
				[Cpp2IlInjected.Token(Token = "0x40000C8")]
				PLAYER_CREATED_SIGN,
				[Cpp2IlInjected.Token(Token = "0x40000C9")]
				GAME_STATE_OUTPUT_NODE,
				[Cpp2IlInjected.Token(Token = "0x40000CA")]
				GAME_STATE_INPUT_NODE,
				[Cpp2IlInjected.Token(Token = "0x40000CB")]
				SCORE_INPUT_NODE,
				[Cpp2IlInjected.Token(Token = "0x40000CC")]
				SET_SCORE_OUTPUT_NODE,
				[Cpp2IlInjected.Token(Token = "0x40000CD")]
				PIRATE_FLINTLOCK,
				[Cpp2IlInjected.Token(Token = "0x40000CE")]
				PIRATE_COCONUT_BOMB,
				[Cpp2IlInjected.Token(Token = "0x40000CF")]
				MOVEABLE_WHITEBOARD,
				[Cpp2IlInjected.Token(Token = "0x40000D0")]
				RANDOM_NODE,
				[Cpp2IlInjected.Token(Token = "0x40000D1")]
				PLAYER_HIT_NODE,
				[Cpp2IlInjected.Token(Token = "0x40000D2")]
				PIRATE_SMALL_LOOT_PILE,
				[Cpp2IlInjected.Token(Token = "0x40000D3")]
				SFX_NODE,
				[Cpp2IlInjected.Token(Token = "0x40000D4")]
				DEPRECATED_HOLOTAR_PROJECTOR,
				[Cpp2IlInjected.Token(Token = "0x40000D5")]
				PIRATE_PUSH_BROOM,
				[Cpp2IlInjected.Token(Token = "0x40000D6")]
				PIRATE_BAR_STOOL,
				[Cpp2IlInjected.Token(Token = "0x40000D7")]
				PIRATE_PLUSH_FISH,
				[Cpp2IlInjected.Token(Token = "0x40000D8")]
				PIRATE_FRYING_PAN,
				[Cpp2IlInjected.Token(Token = "0x40000D9")]
				PIRATE_OAR,
				[Cpp2IlInjected.Token(Token = "0x40000DA")]
				PIRATE_PLATE,
				[Cpp2IlInjected.Token(Token = "0x40000DB")]
				PIRATE_MUG,
				[Cpp2IlInjected.Token(Token = "0x40000DC")]
				PIRATE_LOST_LOOT,
				[Cpp2IlInjected.Token(Token = "0x40000DD")]
				WHITEBOARD_MARKERS,
				[Cpp2IlInjected.Token(Token = "0x40000DE")]
				PIRATE_HOOK_HAND,
				[Cpp2IlInjected.Token(Token = "0x40000DF")]
				PLAYER_RESPAWN_NODE,
				[Cpp2IlInjected.Token(Token = "0x40000E0")]
				SANDBOX_FLOOR,
				[Cpp2IlInjected.Token(Token = "0x40000E1")]
				SANDBOX_WALL,
				[Cpp2IlInjected.Token(Token = "0x40000E2")]
				PLAYER_RESPAWN_POINT,
				[Cpp2IlInjected.Token(Token = "0x40000E3")]
				SANDBOX_CEILING,
				[Cpp2IlInjected.Token(Token = "0x40000E4")]
				SANDBOX_WALL_WINDOW,
				[Cpp2IlInjected.Token(Token = "0x40000E5")]
				AMBIENCE_RADIO,
				[Cpp2IlInjected.Token(Token = "0x40000E6")]
				INDICATOR_LIGHT,
				[Cpp2IlInjected.Token(Token = "0x40000E7")]
				SANDBOX_AUDIO_SAMPLER,
				[Cpp2IlInjected.Token(Token = "0x40000E8")]
				SELECTOR_NODE,
				[Cpp2IlInjected.Token(Token = "0x40000E9")]
				DEPRECATED_SANDBOX_BUTTON,
				[Cpp2IlInjected.Token(Token = "0x40000EA")]
				ROTATOR_GIZMO,
				[Cpp2IlInjected.Token(Token = "0x40000EB")]
				TRIGGER_VOLUME,
				[Cpp2IlInjected.Token(Token = "0x40000EC")]
				ROYALE_ISLAND_MAP,
				[Cpp2IlInjected.Token(Token = "0x40000ED")]
				GAME_GET_SCORE_NODE,
				[Cpp2IlInjected.Token(Token = "0x40000EE")]
				GAME_SET_SCORE_NODE,
				[Cpp2IlInjected.Token(Token = "0x40000EF")]
				GET_PLAYER_STAT_NODE,
				[Cpp2IlInjected.Token(Token = "0x40000F0")]
				SET_PLAYER_STAT_NODE,
				[Cpp2IlInjected.Token(Token = "0x40000F1")]
				PLAYER_TEAM_MAPPING_NODE,
				[Cpp2IlInjected.Token(Token = "0x40000F2")]
				PLAYER_EVENT_NODE,
				[Cpp2IlInjected.Token(Token = "0x40000F3")]
				GAME_SET_STATE_NODE,
				[Cpp2IlInjected.Token(Token = "0x40000F4")]
				ROYALE_HEALTH_POTION,
				[Cpp2IlInjected.Token(Token = "0x40000F5")]
				ROYALE_SHIELD_POTION,
				[Cpp2IlInjected.Token(Token = "0x40000F6")]
				ROYALE_HEALTH_AND_SHIELD_POTION,
				[Cpp2IlInjected.Token(Token = "0x40000F7")]
				CIRCUIT_STAGE_LIGHT,
				[Cpp2IlInjected.Token(Token = "0x40000F8")]
				ROYALE_AMMUNITION_PISTOL,
				[Cpp2IlInjected.Token(Token = "0x40000F9")]
				ROYALE_AMMUNITION_AUTOMATIC,
				[Cpp2IlInjected.Token(Token = "0x40000FA")]
				ROYALE_AMMUNITION_RIFLE,
				[Cpp2IlInjected.Token(Token = "0x40000FB")]
				ROYALE_AMMUNITION_SHOTGUN,
				[Cpp2IlInjected.Token(Token = "0x40000FC")]
				ROYALE_AMMUNITION_EXPLOSIVE,
				[Cpp2IlInjected.Token(Token = "0x40000FD")]
				SMOOTH_LOOK_AT,
				[Cpp2IlInjected.Token(Token = "0x40000FE")]
				PISTON_GIZMO,
				[Cpp2IlInjected.Token(Token = "0x40000FF")]
				MICROPHONE_CONFERENCE,
				[Cpp2IlInjected.Token(Token = "0x4000100")]
				WAVE_NODE,
				[Cpp2IlInjected.Token(Token = "0x4000101")]
				PLAYER_ROLE_MAP_NODE,
				[Cpp2IlInjected.Token(Token = "0x4000102")]
				CLAMP_GIZMO,
				[Cpp2IlInjected.Token(Token = "0x4000103")]
				OBJECT_RESPAWNER,
				[Cpp2IlInjected.Token(Token = "0x4000104")]
				OBJECT_PLAYER_MAP_NODE,
				[Cpp2IlInjected.Token(Token = "0x4000105")]
				ARENA_BEAM_GUN,
				[Cpp2IlInjected.Token(Token = "0x4000106")]
				COFFEE_POT,
				[Cpp2IlInjected.Token(Token = "0x4000107")]
				COFFEE_MUG,
				[Cpp2IlInjected.Token(Token = "0x4000108")]
				CAFE_PLATE,
				[Cpp2IlInjected.Token(Token = "0x4000109")]
				QUEST_POT,
				[Cpp2IlInjected.Token(Token = "0x400010A")]
				QUEST_POT_LARGE,
				[Cpp2IlInjected.Token(Token = "0x400010B")]
				SCIFI_POT,
				[Cpp2IlInjected.Token(Token = "0x400010C")]
				OBJECT_SET_TAGS_NODE,
				[Cpp2IlInjected.Token(Token = "0x400010D")]
				SANDBOX_GAMING_TABLE,
				[Cpp2IlInjected.Token(Token = "0x400010E")]
				SANDBOX_MEEPLE,
				[Cpp2IlInjected.Token(Token = "0x400010F")]
				PAINTBRUSH,
				[Cpp2IlInjected.Token(Token = "0x4000110")]
				SANDBOX_GAMING_TABLE_SMALL,
				[Cpp2IlInjected.Token(Token = "0x4000111")]
				SOCCER_BALL,
				[Cpp2IlInjected.Token(Token = "0x4000112")]
				DRACULA_BONE,
				[Cpp2IlInjected.Token(Token = "0x4000113")]
				PARTICLE_EMITTER,
				[Cpp2IlInjected.Token(Token = "0x4000114")]
				COSTUME_DUMMY,
				[Cpp2IlInjected.Token(Token = "0x4000115")]
				DRACULA_BLUNDERBUSS,
				[Cpp2IlInjected.Token(Token = "0x4000116")]
				DRACULA_MINIBOSS_BONE,
				[Cpp2IlInjected.Token(Token = "0x4000117")]
				DRACULA_SHOVEL,
				[Cpp2IlInjected.Token(Token = "0x4000118")]
				DRACULA_PITCHFORK,
				[Cpp2IlInjected.Token(Token = "0x4000119")]
				DRACULA_RAKE,
				[Cpp2IlInjected.Token(Token = "0x400011A")]
				DRACULA_WHIP,
				[Cpp2IlInjected.Token(Token = "0x400011B")]
				DRACULA_WALL_COLLECTABLE,
				[Cpp2IlInjected.Token(Token = "0x400011C")]
				DRACULA_PUMPKIN_COLLECTABLE,
				[Cpp2IlInjected.Token(Token = "0x400011D")]
				DRACULA_LOOT_SMALL,
				[Cpp2IlInjected.Token(Token = "0x400011E")]
				SHAPE_CONTAINER,
				[Cpp2IlInjected.Token(Token = "0x400011F")]
				DRACULA_CHESTCOINS_SMALL,
				[Cpp2IlInjected.Token(Token = "0x4000120")]
				DRACULA_CHESTCOINS_MEDIUM,
				[Cpp2IlInjected.Token(Token = "0x4000121")]
				DRACULA_CHESTCOINS_LARGE,
				[Cpp2IlInjected.Token(Token = "0x4000122")]
				DRACULA_CROSSBOW,
				[Cpp2IlInjected.Token(Token = "0x4000123")]
				DRACULA_HUNTER_CROSSBOW,
				[Cpp2IlInjected.Token(Token = "0x4000124")]
				DRACULA_MINIBOSSCOINS_BAT,
				[Cpp2IlInjected.Token(Token = "0x4000125")]
				DRACULA_MINIBOSSCOINS_BONETHROWER,
				[Cpp2IlInjected.Token(Token = "0x4000126")]
				DRACULA_MINIBOSSCOINS_MUSKET,
				[Cpp2IlInjected.Token(Token = "0x4000127")]
				DRACULA_MINIBOSSCOINS_WOLF,
				[Cpp2IlInjected.Token(Token = "0x4000128")]
				DRACULA_MINIBOSSCOINS_BONEMELEE,
				[Cpp2IlInjected.Token(Token = "0x4000129")]
				DRACULA_STANDING_COLLECTABLE,
				[Cpp2IlInjected.Token(Token = "0x400012A")]
				DRACULA_SMALL_COLLECTABLE,
				[Cpp2IlInjected.Token(Token = "0x400012B")]
				DRACULA_FLINTLOCK,
				[Cpp2IlInjected.Token(Token = "0x400012C")]
				DRACULA_BOSS_PLUSHY,
				[Cpp2IlInjected.Token(Token = "0x400012D")]
				DRACULA_HOOKSHOT,
				[Cpp2IlInjected.Token(Token = "0x400012E")]
				BOWLING_BALL,
				[Cpp2IlInjected.Token(Token = "0x400012F")]
				BOWLING_PIN,
				[Cpp2IlInjected.Token(Token = "0x4000130")]
				ROYALE_BACKPACK,
				[Cpp2IlInjected.Token(Token = "0x4000131")]
				HANDHELD_STREAMER_CAMERA,
				[Cpp2IlInjected.Token(Token = "0x4000132")]
				STACKABLE_BLOCK,
				[Cpp2IlInjected.Token(Token = "0x4000133")]
				RECROYALE_GRENADE,
				[Cpp2IlInjected.Token(Token = "0x4000134")]
				GAME_CONFIGURATION,
				[Cpp2IlInjected.Token(Token = "0x4000135")]
				BOWLING_GAME_RULE_CIRCUIT,
				[Cpp2IlInjected.Token(Token = "0x4000136")]
				CHARADES_CO_OP_CLASSIC_GAME_RULE_CIRCUIT,
				[Cpp2IlInjected.Token(Token = "0x4000137")]
				CHARADES_TEAM_LIGHTNING_GAME_RULE_CIRCUIT,
				[Cpp2IlInjected.Token(Token = "0x4000138")]
				CRESCENDO_OF_THE_BLOOD_MOON_GAME_RULE_CIRCUIT,
				[Cpp2IlInjected.Token(Token = "0x4000139")]
				DISC_GOLF_GAME_RULE_CIRCUIT,
				[Cpp2IlInjected.Token(Token = "0x400013A")]
				DISC_GOLF_CO_OP_CATCH_GAME_RULE_CIRCUIT,
				[Cpp2IlInjected.Token(Token = "0x400013B")]
				DODGEBALL_GAME_RULE_CIRCUIT,
				[Cpp2IlInjected.Token(Token = "0x400013C")]
				ISLE_OF_LOST_SKULLS_GAME_RULE_CIRCUIT,
				[Cpp2IlInjected.Token(Token = "0x400013D")]
				LASER_TAG_GAME_RULE_CIRCUIT,
				[Cpp2IlInjected.Token(Token = "0x400013E")]
				PADDLEBALL_GAME_RULE_CIRCUIT,
				[Cpp2IlInjected.Token(Token = "0x400013F")]
				PAINTBALL_CAPTURE_THE_FLAG_GAME_RULE_CIRCUIT,
				[Cpp2IlInjected.Token(Token = "0x4000140")]
				PAINTBALL_TEAM_BATTLE_GAME_RULE_CIRCUIT,
				[Cpp2IlInjected.Token(Token = "0x4000141")]
				QUEST_FOR_THE_GOLDEN_TROPHY_GAME_RULE_CIRCUIT,
				[Cpp2IlInjected.Token(Token = "0x4000142")]
				REC_ROYALE_SOLOS_GAME_RULE_CIRCUIT,
				[Cpp2IlInjected.Token(Token = "0x4000143")]
				REC_ROYALE_SQUADS_GAME_RULE_CIRCUIT,
				[Cpp2IlInjected.Token(Token = "0x4000144")]
				RISE_OF_JUMBOTRON_GAME_RULE_CIRCUIT,
				[Cpp2IlInjected.Token(Token = "0x4000145")]
				SOCCER_GAME_RULE_CIRCUIT,
				[Cpp2IlInjected.Token(Token = "0x4000146")]
				CIRCUIT_GROUP,
				[Cpp2IlInjected.Token(Token = "0x4000147")]
				STATE_MACHINE,
				[Cpp2IlInjected.Token(Token = "0x4000148")]
				STATE_MACHINE_STATE,
				[Cpp2IlInjected.Token(Token = "0x4000149")]
				STANDEE_FEMALE_01,
				[Cpp2IlInjected.Token(Token = "0x400014A")]
				STANDEE_MALE_01,
				[Cpp2IlInjected.Token(Token = "0x400014B")]
				STANDEE_FEMALE_02,
				[Cpp2IlInjected.Token(Token = "0x400014C")]
				STANDEE_FEMALE_03,
				[Cpp2IlInjected.Token(Token = "0x400014D")]
				STANDEE_PIRATE_PHOTO,
				[Cpp2IlInjected.Token(Token = "0x400014E")]
				STANDEE_PIRATE_01,
				[Cpp2IlInjected.Token(Token = "0x400014F")]
				STANDEE_PIRATE_02,
				[Cpp2IlInjected.Token(Token = "0x4000150")]
				STANDEE_PIRATE_DRUMMER,
				[Cpp2IlInjected.Token(Token = "0x4000151")]
				STANDEE_PIRATE_FIDDLE,
				[Cpp2IlInjected.Token(Token = "0x4000152")]
				STANDEE_PIRATE_SQUEEZEBOX,
				[Cpp2IlInjected.Token(Token = "0x4000153")]
				STANDEE_BEAR_01,
				[Cpp2IlInjected.Token(Token = "0x4000154")]
				SCOREBOARD_PROJECTOR,
				[Cpp2IlInjected.Token(Token = "0x4000155")]
				CRIMSON_CAULDRON_GAME_RULE_CIRCUIT,
				[Cpp2IlInjected.Token(Token = "0x4000156")]
				SANDBOX_CIRCUIT_BEACON,
				[Cpp2IlInjected.Token(Token = "0x4000157")]
				MAKER_PEN_TROPHY_GOLD,
				[Cpp2IlInjected.Token(Token = "0x4000158")]
				MAKER_PEN_TROPHY_SILVER,
				[Cpp2IlInjected.Token(Token = "0x4000159")]
				MAKER_PEN_TROPHY_BRONZE,
				[Cpp2IlInjected.Token(Token = "0x400015A")]
				PLAYER_REVIVED_NODE,
				[Cpp2IlInjected.Token(Token = "0x400015B")]
				CONTEST_CATEGORY_TROPHY,
				[Cpp2IlInjected.Token(Token = "0x400015C")]
				SCOREBOARD_SETUP_NODE,
				[Cpp2IlInjected.Token(Token = "0x400015D")]
				DYNAMIC_SPOTLIGHT,
				[Cpp2IlInjected.Token(Token = "0x400015E")]
				DYNAMINC_POINT_LIGHT,
				[Cpp2IlInjected.Token(Token = "0x400015F")]
				MARKER_RECOLORABLE,
				[Cpp2IlInjected.Token(Token = "0x4000160")]
				HOLO_HELPER,
				[Cpp2IlInjected.Token(Token = "0x4000161")]
				STUNTRUNNER_GAME_RULE_CIRCUIT,
				[Cpp2IlInjected.Token(Token = "0x4000162")]
				STUNTRUNNER_BUTTON,
				[Cpp2IlInjected.Token(Token = "0x4000163")]
				ANIMATIONGIZMO,
				[Cpp2IlInjected.Token(Token = "0x4000164")]
				TILEABLE_ROPE_NET,
				[Cpp2IlInjected.Token(Token = "0x4000165")]
				LIGHT_STRIP_SHORT,
				[Cpp2IlInjected.Token(Token = "0x4000166")]
				CHECKPOINT_SANDBOX,
				[Cpp2IlInjected.Token(Token = "0x4000167")]
				BOUNCE_PAD,
				[Cpp2IlInjected.Token(Token = "0x4000168")]
				LIGHT_CHEVRONS,
				[Cpp2IlInjected.Token(Token = "0x4000169")]
				LIGHT_MARQUEE,
				[Cpp2IlInjected.Token(Token = "0x400016A")]
				SCAFFOLDING_SHINY,
				[Cpp2IlInjected.Token(Token = "0x400016B")]
				SCAFFOLDING_BLOCK,
				[Cpp2IlInjected.Token(Token = "0x400016C")]
				CRASHPAD_EXTRA_THICK,
				[Cpp2IlInjected.Token(Token = "0x400016D")]
				CRASHPAD_THICK,
				[Cpp2IlInjected.Token(Token = "0x400016E")]
				CRASHPAD_THIN,
				[Cpp2IlInjected.Token(Token = "0x400016F")]
				CRASHPAD_TALL,
				[Cpp2IlInjected.Token(Token = "0x4000170")]
				SPEAKER_CONCERT,
				[Cpp2IlInjected.Token(Token = "0x4000171")]
				STAGELIGHT_CAN,
				[Cpp2IlInjected.Token(Token = "0x4000172")]
				SET_LEADERBOARD_STAT_NODE,
				[Cpp2IlInjected.Token(Token = "0x4000173")]
				GET_LEADERBOARD_STAT_NODE,
				[Cpp2IlInjected.Token(Token = "0x4000174")]
				LEADERBOARD_PROJECTOR,
				[Cpp2IlInjected.Token(Token = "0x4000175")]
				PLAYER_BOOSTER,
				[Cpp2IlInjected.Token(Token = "0x4000176")]
				ART_CANVAS,
				[Cpp2IlInjected.Token(Token = "0x4000177")]
				SPRINGBOARD_STUNTRUNNER,
				[Cpp2IlInjected.Token(Token = "0x4000178")]
				IMPULSE_VOLUME,
				[Cpp2IlInjected.Token(Token = "0x4000179")]
				STUNTRUNNER_JUMBOTRON,
				[Cpp2IlInjected.Token(Token = "0x400017A")]
				STUNTRUNNER_BASEROOM_FLOOR,
				[Cpp2IlInjected.Token(Token = "0x400017B")]
				STUNTRUNNER_BASEROOM_CEILING,
				[Cpp2IlInjected.Token(Token = "0x400017C")]
				STUNTRUNNER_BASEROOM_WALL_SHORT,
				[Cpp2IlInjected.Token(Token = "0x400017D")]
				STUNTRUNNER_BASEROOM_WALL_LONG,
				[Cpp2IlInjected.Token(Token = "0x400017E")]
				ART_CANVAS_SQUARE,
				[Cpp2IlInjected.Token(Token = "0x400017F")]
				STUNTRUNNER_PICKUP,
				[Cpp2IlInjected.Token(Token = "0x4000180")]
				STUNTRUNNER_CHECKPOINT_INVENTION,
				[Cpp2IlInjected.Token(Token = "0x4000181")]
				STUNTRUNNER_COMMENTATOR_BOOTH,
				[Cpp2IlInjected.Token(Token = "0x4000182")]
				STUNTRUNNER_ENDING_GATE,
				[Cpp2IlInjected.Token(Token = "0x4000183")]
				STUNTRUNNER_STARTING_GATE,
				[Cpp2IlInjected.Token(Token = "0x4000184")]
				STUNTRUNNER_COMMENTATOR_CAMERA,
				[Cpp2IlInjected.Token(Token = "0x4000185")]
				STUNTRUNNER_BOOM_MICROPHONE,
				[Cpp2IlInjected.Token(Token = "0x4000186")]
				GAME_ROLE_NODE,
				[Cpp2IlInjected.Token(Token = "0x4000187")]
				JACKOLANTERN,
				[Cpp2IlInjected.Token(Token = "0x4000188")]
				CLAPPERBOARD_VIDEO_TROPHY,
				[Cpp2IlInjected.Token(Token = "0x4000189")]
				SANDBOX_TOGGLE_BUTTON,
				[Cpp2IlInjected.Token(Token = "0x400018A")]
				SANDBOX_TEXT,
				[Cpp2IlInjected.Token(Token = "0x400018B")]
				POOL_TABLE,
				[Cpp2IlInjected.Token(Token = "0x400018C")]
				POOL_CUE,
				[Cpp2IlInjected.Token(Token = "0x400018D")]
				POOL_CUE_RACK,
				[Cpp2IlInjected.Token(Token = "0x400018E")]
				POOL_TRIANGLE,
				[Cpp2IlInjected.Token(Token = "0x400018F")]
				PAINT_THROWER,
				[Cpp2IlInjected.Token(Token = "0x4000190")]
				PROXIMITY_MINE,
				[Cpp2IlInjected.Token(Token = "0x4000191")]
				INVISIBLE_COLLISION,
				[Cpp2IlInjected.Token(Token = "0x4000192")]
				FLAG,
				[Cpp2IlInjected.Token(Token = "0x4000193")]
				FLAG_GOAL,
				[Cpp2IlInjected.Token(Token = "0x4000194")]
				FOG_NODE,
				[Cpp2IlInjected.Token(Token = "0x4000195")]
				SKYDOME_NODE,
				[Cpp2IlInjected.Token(Token = "0x4000196")]
				BLOOM_NODE,
				[Cpp2IlInjected.Token(Token = "0x4000197")]
				COLORGRADING_NODE,
				[Cpp2IlInjected.Token(Token = "0x4000198")]
				SUN_LIGHT,
				[Cpp2IlInjected.Token(Token = "0x4000199")]
				BACKGROUNDOBJECTS_NODE,
				[Cpp2IlInjected.Token(Token = "0x400019A")]
				TABLE_UMBRELLA,
				[Cpp2IlInjected.Token(Token = "0x400019B")]
				ROUND_PICNIC_TABLE,
				[Cpp2IlInjected.Token(Token = "0x400019C")]
				BOOTH_SEAT,
				[Cpp2IlInjected.Token(Token = "0x400019D")]
				TRASH_BAG,
				[Cpp2IlInjected.Token(Token = "0x400019E")]
				CONCRETE_BARRIER,
				[Cpp2IlInjected.Token(Token = "0x400019F")]
				GAS_PUMP,
				[Cpp2IlInjected.Token(Token = "0x40001A0")]
				DRIVEIN_SPEAKER,
				[Cpp2IlInjected.Token(Token = "0x40001A1")]
				CAR_TIRE,
				[Cpp2IlInjected.Token(Token = "0x40001A2")]
				CONCRETE_TUBE,
				[Cpp2IlInjected.Token(Token = "0x40001A3")]
				TELEPHONE_POLE,
				[Cpp2IlInjected.Token(Token = "0x40001A4")]
				MESH_FENCE,
				[Cpp2IlInjected.Token(Token = "0x40001A5")]
				TARGET,
				[Cpp2IlInjected.Token(Token = "0x40001A6")]
				CLASSIC_CAR,
				[Cpp2IlInjected.Token(Token = "0x40001A7")]
				TRUCK,
				[Cpp2IlInjected.Token(Token = "0x40001A8")]
				GUARD_RAIL,
				[Cpp2IlInjected.Token(Token = "0x40001A9")]
				LAWN_CHAIR,
				[Cpp2IlInjected.Token(Token = "0x40001AA")]
				FILM_PROJECTOR,
				[Cpp2IlInjected.Token(Token = "0x40001AB")]
				TRACTOR_TIRE,
				[Cpp2IlInjected.Token(Token = "0x40001AC")]
				STEAM_VENT,
				[Cpp2IlInjected.Token(Token = "0x40001AD")]
				AC_UNIT,
				[Cpp2IlInjected.Token(Token = "0x40001AE")]
				METAL_BARREL,
				[Cpp2IlInjected.Token(Token = "0x40001AF")]
				DINER_SIGN,
				[Cpp2IlInjected.Token(Token = "0x40001B0")]
				DINER_SIGN_LARGE,
				[Cpp2IlInjected.Token(Token = "0x40001B1")]
				DRIVEIN_SIGN,
				[Cpp2IlInjected.Token(Token = "0x40001B2")]
				FRANKIES_FUEL_SIGN,
				[Cpp2IlInjected.Token(Token = "0x40001B3")]
				DUMPSTER,
				[Cpp2IlInjected.Token(Token = "0x40001B4")]
				BOOTH_TABLE,
				[Cpp2IlInjected.Token(Token = "0x40001B5")]
				FENCE_PLANK,
				[Cpp2IlInjected.Token(Token = "0x40001B6")]
				FENCE_FRAME,
				[Cpp2IlInjected.Token(Token = "0x40001B7")]
				PICNIC_TABLE,
				[Cpp2IlInjected.Token(Token = "0x40001B8")]
				TRASH_CAN,
				[Cpp2IlInjected.Token(Token = "0x40001B9")]
				CARDBOARD_BOX,
				[Cpp2IlInjected.Token(Token = "0x40001BA")]
				FLAG_AND_GOAL,
				[Cpp2IlInjected.Token(Token = "0x40001BB")]
				DESKTOP_SHARING_SCREEN,
				[Cpp2IlInjected.Token(Token = "0x40001BC")]
				DEPRECATED_CREATOR_FEEDBACK_BUTTONS,
				[Cpp2IlInjected.Token(Token = "0x40001BD")]
				SANDBOX_BUTTON,
				[Cpp2IlInjected.Token(Token = "0x40001BE")]
				ROOM_DOOR,
				[Cpp2IlInjected.Token(Token = "0x40001BF")]
				HOLOTAR_PROJECTOR,
				[Cpp2IlInjected.Token(Token = "0x40001C0")]
				ROCK_PLATEAU,
				[Cpp2IlInjected.Token(Token = "0x40001C1")]
				ROCK_STUMP,
				[Cpp2IlInjected.Token(Token = "0x40001C2")]
				ROCK_TALL,
				[Cpp2IlInjected.Token(Token = "0x40001C3")]
				ROCK_WALL,
				[Cpp2IlInjected.Token(Token = "0x40001C4")]
				ROCK_WEDGE,
				[Cpp2IlInjected.Token(Token = "0x40001C5")]
				WOODEN_SPOOL,
				[Cpp2IlInjected.Token(Token = "0x40001C6")]
				WOODSTACK,
				[Cpp2IlInjected.Token(Token = "0x40001C7")]
				WOOD_PALLET,
				[Cpp2IlInjected.Token(Token = "0x40001C8")]
				IBEAM_5M,
				[Cpp2IlInjected.Token(Token = "0x40001C9")]
				IBEAM_10M,
				[Cpp2IlInjected.Token(Token = "0x40001CA")]
				IBEAM_BRACKET,
				[Cpp2IlInjected.Token(Token = "0x40001CB")]
				HAY_BALE,
				[Cpp2IlInjected.Token(Token = "0x40001CC")]
				LOG_PILE,
				[Cpp2IlInjected.Token(Token = "0x40001CD")]
				TRASH_BIN,
				[Cpp2IlInjected.Token(Token = "0x40001CE")]
				TREE_STUMP,
				[Cpp2IlInjected.Token(Token = "0x40001CF")]
				WATER_JUG,
				[Cpp2IlInjected.Token(Token = "0x40001D0")]
				PIPE_BRACKET,
				[Cpp2IlInjected.Token(Token = "0x40001D1")]
				PIPE_CURVED,
				[Cpp2IlInjected.Token(Token = "0x40001D2")]
				PIPE_STRAIGHT,
				[Cpp2IlInjected.Token(Token = "0x40001D3")]
				PIPE_STRAIGHT_LONG,
				[Cpp2IlInjected.Token(Token = "0x40001D4")]
				CONTROL_PANEL_SHORT,
				[Cpp2IlInjected.Token(Token = "0x40001D5")]
				CONTROL_PANEL_TALL,
				[Cpp2IlInjected.Token(Token = "0x40001D6")]
				ELECTRICAL_UNIT,
				[Cpp2IlInjected.Token(Token = "0x40001D7")]
				PINE_TREE_DEAD,
				[Cpp2IlInjected.Token(Token = "0x40001D8")]
				SPORTS_CAR,
				[Cpp2IlInjected.Token(Token = "0x40001D9")]
				PVP_WHIP,
				[Cpp2IlInjected.Token(Token = "0x40001DA")]
				CURTAIN_TIED,
				[Cpp2IlInjected.Token(Token = "0x40001DB")]
				CURTAIN_WAVY,
				[Cpp2IlInjected.Token(Token = "0x40001DC")]
				NAPKIN_HOLDER,
				[Cpp2IlInjected.Token(Token = "0x40001DD")]
				BREAKER_BOX,
				[Cpp2IlInjected.Token(Token = "0x40001DE")]
				ROCK_01,
				[Cpp2IlInjected.Token(Token = "0x40001DF")]
				ROCK_04,
				[Cpp2IlInjected.Token(Token = "0x40001E0")]
				ROCK_CLIFF,
				[Cpp2IlInjected.Token(Token = "0x40001E1")]
				ROCK_CONE,
				[Cpp2IlInjected.Token(Token = "0x40001E2")]
				TENNIS_BALL,
				[Cpp2IlInjected.Token(Token = "0x40001E3")]
				DESKTOP_AUDIO_SHARING,
				[Cpp2IlInjected.Token(Token = "0x40001E4")]
				GOBLINBASICFLYINGRANGED,
				[Cpp2IlInjected.Token(Token = "0x40001E5")]
				AIPATHPOINT,
				[Cpp2IlInjected.Token(Token = "0x40001E6")]
				GOBLINBASICGROUNDMELEE,
				[Cpp2IlInjected.Token(Token = "0x40001E7")]
				DRACULABONETHROWER,
				[Cpp2IlInjected.Token(Token = "0x40001E8")]
				SPAWNERCIRCUIT,
				[Cpp2IlInjected.Token(Token = "0x40001E9")]
				NAVMESH_BAKE_VOLUME,
				[Cpp2IlInjected.Token(Token = "0x40001EA")]
				SCFIFGROUNDEXPLOSIVE,
				[Cpp2IlInjected.Token(Token = "0x40001EB")]
				GOBLINKNIGHTSPIN,
				[Cpp2IlInjected.Token(Token = "0x40001EC")]
				GOBLINBASICGROUNDRANGED,
				[Cpp2IlInjected.Token(Token = "0x40001ED")]
				GOBLINBASICMELEEPIKE,
				[Cpp2IlInjected.Token(Token = "0x40001EE")]
				GOBLINELITEGROUNDMELEE,
				[Cpp2IlInjected.Token(Token = "0x40001EF")]
				GOBLINELITEFLYINGRANGED,
				[Cpp2IlInjected.Token(Token = "0x40001F0")]
				SCIFIBASICFLYINGRANGED,
				[Cpp2IlInjected.Token(Token = "0x40001F1")]
				SCIFIBASICGROUNDRANGED,
				[Cpp2IlInjected.Token(Token = "0x40001F2")]
				SCIFIKNIGHTASSASSIN,
				[Cpp2IlInjected.Token(Token = "0x40001F3")]
				SCIFIELITEFLYINGRANGED,
				[Cpp2IlInjected.Token(Token = "0x40001F4")]
				SCIFIELITEGROUNDRANGED,
				[Cpp2IlInjected.Token(Token = "0x40001F5")]
				GOBLINVOLLEY,
				[Cpp2IlInjected.Token(Token = "0x40001F6")]
				PIRATEBASICMELEE,
				[Cpp2IlInjected.Token(Token = "0x40001F7")]
				PIRATEEXPLOSIVETHROWING,
				[Cpp2IlInjected.Token(Token = "0x40001F8")]
				PIRATEBOTTLETHROWING,
				[Cpp2IlInjected.Token(Token = "0x40001F9")]
				PIRATEFLINTLOCK,
				[Cpp2IlInjected.Token(Token = "0x40001FA")]
				PIRATEGIBBET,
				[Cpp2IlInjected.Token(Token = "0x40001FB")]
				DRACULAMELEE,
				[Cpp2IlInjected.Token(Token = "0x40001FC")]
				DRACULAMUSKET,
				[Cpp2IlInjected.Token(Token = "0x40001FD")]
				DRACULABATRANGED,
				[Cpp2IlInjected.Token(Token = "0x40001FE")]
				DRACULABATLUNGING,
				[Cpp2IlInjected.Token(Token = "0x40001FF")]
				GOBLINKNIGHTCHARGE,
				[Cpp2IlInjected.Token(Token = "0x4000200")]
				LINK_BUTTON,
				[Cpp2IlInjected.Token(Token = "0x4000201")]
				RANGEFINDER_GADGET,
				[Cpp2IlInjected.Token(Token = "0x4000202")]
				COSTUME_DUMMY_PLUS,
				[Cpp2IlInjected.Token(Token = "0x4000203")]
				CREATOR_FEEDBACK_BUTTONS,
				[Cpp2IlInjected.Token(Token = "0x4000204")]
				CREATOR_FREEGIFT_BUTTON,
				[Cpp2IlInjected.Token(Token = "0x4000205")]
				BEAN_BAG,
				[Cpp2IlInjected.Token(Token = "0x4000206")]
				CAFE_TABLE_SHORT,
				[Cpp2IlInjected.Token(Token = "0x4000207")]
				CAFE_TABLE_TALL,
				[Cpp2IlInjected.Token(Token = "0x4000208")]
				CAFE_CHAIR_ROUND,
				[Cpp2IlInjected.Token(Token = "0x4000209")]
				COFFEE_TABLE_CURVY,
				[Cpp2IlInjected.Token(Token = "0x400020A")]
				STOOL_WOODEN,
				[Cpp2IlInjected.Token(Token = "0x400020B")]
				BULLETIN_BOARD,
				[Cpp2IlInjected.Token(Token = "0x400020C")]
				CURTAIN_NO_TASSELS,
				[Cpp2IlInjected.Token(Token = "0x400020D")]
				COUCH_WOOD,
				[Cpp2IlInjected.Token(Token = "0x400020E")]
				STOOL_BOWLING_ALLEY,
				[Cpp2IlInjected.Token(Token = "0x400020F")]
				JUKEBOX,
				[Cpp2IlInjected.Token(Token = "0x4000210")]
				LIGHT_PENDANT,
				[Cpp2IlInjected.Token(Token = "0x4000211")]
				ROOT_BEER_BOTTLE,
				[Cpp2IlInjected.Token(Token = "0x4000212")]
				INKSPACE_STAGE,
				[Cpp2IlInjected.Token(Token = "0x4000213")]
				INK_SPACE_ROOM_HULL,
				[Cpp2IlInjected.Token(Token = "0x4000214")]
				AI_MOVE_ORDER,
				[Cpp2IlInjected.Token(Token = "0x4000215")]
				UGC_AREA,
				[Cpp2IlInjected.Token(Token = "0x4000216")]
				SPAWNERCIRCUIT_V2,
				[Cpp2IlInjected.Token(Token = "0x4000217")]
				MODERATOR_PLAQUE_GOLD,
				[Cpp2IlInjected.Token(Token = "0x4000218")]
				MODERATOR_PLAQUE_SILVER,
				[Cpp2IlInjected.Token(Token = "0x4000219")]
				MODERATOR_PLAQUE_BRONZE,
				[Cpp2IlInjected.Token(Token = "0x400021A")]
				SANDBOX_TOGGLE_BUTTON_CV2,
				[Cpp2IlInjected.Token(Token = "0x400021B")]
				TRIGGER_VOLUME_CV2,
				[Cpp2IlInjected.Token(Token = "0x400021C")]
				SANDBOX_BUTTON_CV2,
				[Cpp2IlInjected.Token(Token = "0x400021D")]
				SHOWCASE_POSTER,
				[Cpp2IlInjected.Token(Token = "0x400021E")]
				DRACULA_LUNGING_WOLF,
				[Cpp2IlInjected.Token(Token = "0x400021F")]
				PISTON_GIZMO_V2,
				[Cpp2IlInjected.Token(Token = "0x4000220")]
				ROTATOR_GIZMO_V2,
				[Cpp2IlInjected.Token(Token = "0x4000221")]
				SFX_NODE_V2,
				[Cpp2IlInjected.Token(Token = "0x4000222")]
				SANDBOX_TEXT_V2,
				[Cpp2IlInjected.Token(Token = "0x4000223")]
				LOG_SCREEN,
				[Cpp2IlInjected.Token(Token = "0x4000224")]
				PARTICLE_EMITTER_V2,
				[Cpp2IlInjected.Token(Token = "0x4000225")]
				DYNAMIC_SPOTLIGHT_V2,
				[Cpp2IlInjected.Token(Token = "0x4000226")]
				DYNAMIC_POINTLIGHT_V2,
				[Cpp2IlInjected.Token(Token = "0x4000227")]
				DICE_SET_V2,
				[Cpp2IlInjected.Token(Token = "0x4000228")]
				D4_V2,
				[Cpp2IlInjected.Token(Token = "0x4000229")]
				D6_V2,
				[Cpp2IlInjected.Token(Token = "0x400022A")]
				D8_V2,
				[Cpp2IlInjected.Token(Token = "0x400022B")]
				D12_V2,
				[Cpp2IlInjected.Token(Token = "0x400022C")]
				D20_V2,
				[Cpp2IlInjected.Token(Token = "0x400022D")]
				D10_V2,
				[Cpp2IlInjected.Token(Token = "0x400022E")]
				VECTOR_GADGET,
				[Cpp2IlInjected.Token(Token = "0x400022F")]
				AUDIO_EFFECT_ZONE,
				[Cpp2IlInjected.Token(Token = "0x4000230")]
				SANDBOX_GLASS,
				[Cpp2IlInjected.Token(Token = "0x4000231")]
				GREEN_SCREEN,
				[Cpp2IlInjected.Token(Token = "0x4000232")]
				SANDBOX_MIRROR,
				[Cpp2IlInjected.Token(Token = "0x4000233")]
				STREAMING_CAMERA_POINT,
				[Cpp2IlInjected.Token(Token = "0x4000234")]
				ROOM_CURRENCY_BUTTON,
				[Cpp2IlInjected.Token(Token = "0x4000235")]
				SANDBOX_SEAT,
				[Cpp2IlInjected.Token(Token = "0x4000236")]
				PUNCHING_BAG,
				[Cpp2IlInjected.Token(Token = "0x4000237")]
				VENDING_MACHINE,
				[Cpp2IlInjected.Token(Token = "0x4000238")]
				ICEBREAKERS,
				[Cpp2IlInjected.Token(Token = "0x4000239")]
				MAGIC_DOOR,
				[Cpp2IlInjected.Token(Token = "0x400023A")]
				FULLBODYCOSTUMEDUMMY,
				[Cpp2IlInjected.Token(Token = "0x400023B")]
				SANDBOX_COC_POSTER,
				[Cpp2IlInjected.Token(Token = "0x400023C")]
				FRIENDOTRON,
				[Cpp2IlInjected.Token(Token = "0x400023D")]
				POP_UP_SHOP_1,
				[Cpp2IlInjected.Token(Token = "0x400023E")]
				POP_UP_SHOP_2,
				[Cpp2IlInjected.Token(Token = "0x400023F")]
				ROOM_CONSUMABLE_BUTTON,
				[Cpp2IlInjected.Token(Token = "0x4000240")]
				RALLY_BUGGY,
				[Cpp2IlInjected.Token(Token = "0x4000241")]
				RECRALLY_PICKUP,
				[Cpp2IlInjected.Token(Token = "0x4000242")]
				TRIGGER_HANDLE,
				[Cpp2IlInjected.Token(Token = "0x4000243")]
				COSTUME_TROPHY_GOLD,
				[Cpp2IlInjected.Token(Token = "0x4000244")]
				COSTUME_TROPHY_SILVER,
				[Cpp2IlInjected.Token(Token = "0x4000245")]
				COSTUME_TROPHY_BRONZE
			}

			[Cpp2IlInjected.Token(Token = "0x2000042")]
			private static class PWMEWFNTZSY
			{
				[Cpp2IlInjected.Token(Token = "0x17000001")]
				public static Guid ZQMNZYSSMBD
				{
					[Cpp2IlInjected.Token(Token = "0x6000088")]
					[Cpp2IlInjected.Address(RVA = "0xA5B4B00", Offset = "0xA5B3500", VA = "0x18A5B4B00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000002")]
				public static Guid FXLHBCHBEMD
				{
					[Cpp2IlInjected.Token(Token = "0x6000089")]
					[Cpp2IlInjected.Address(RVA = "0xA5AB280", Offset = "0xA5A9C80", VA = "0x18A5AB280")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000003")]
				public static Guid UALEODXOHZY
				{
					[Cpp2IlInjected.Token(Token = "0x600008A")]
					[Cpp2IlInjected.Address(RVA = "0xA5A5380", Offset = "0xA5A3D80", VA = "0x18A5A5380")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000004")]
				public static Guid JCWVWGDOXSG
				{
					[Cpp2IlInjected.Token(Token = "0x600008B")]
					[Cpp2IlInjected.Address(RVA = "0xA5A8680", Offset = "0xA5A7080", VA = "0x18A5A8680")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000005")]
				public static Guid QUKIOVXVZRU
				{
					[Cpp2IlInjected.Token(Token = "0x600008C")]
					[Cpp2IlInjected.Address(RVA = "0xA5B0580", Offset = "0xA5AEF80", VA = "0x18A5B0580")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000006")]
				public static Guid ERWQHHDMMIC
				{
					[Cpp2IlInjected.Token(Token = "0x600008D")]
					[Cpp2IlInjected.Address(RVA = "0xA5A5980", Offset = "0xA5A4380", VA = "0x18A5A5980")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000007")]
				public static Guid ZZABUPKKJVP
				{
					[Cpp2IlInjected.Token(Token = "0x600008E")]
					[Cpp2IlInjected.Address(RVA = "0xA5AAB80", Offset = "0xA5A9580", VA = "0x18A5AAB80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000008")]
				public static Guid HVLMZBGEHOI
				{
					[Cpp2IlInjected.Token(Token = "0x600008F")]
					[Cpp2IlInjected.Address(RVA = "0xA5AC300", Offset = "0xA5AAD00", VA = "0x18A5AC300")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000009")]
				public static Guid UKRTFFTTCFN
				{
					[Cpp2IlInjected.Token(Token = "0x6000090")]
					[Cpp2IlInjected.Address(RVA = "0xA5B1B80", Offset = "0xA5B0580", VA = "0x18A5B1B80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700000A")]
				public static Guid ACSMOXIWUYC
				{
					[Cpp2IlInjected.Token(Token = "0x6000091")]
					[Cpp2IlInjected.Address(RVA = "0xA5A5100", Offset = "0xA5A3B00", VA = "0x18A5A5100")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700000B")]
				public static Guid QLMSYKIRNUT
				{
					[Cpp2IlInjected.Token(Token = "0x6000092")]
					[Cpp2IlInjected.Address(RVA = "0xA5A9380", Offset = "0xA5A7D80", VA = "0x18A5A9380")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700000C")]
				public static Guid DRGVIWYBFED
				{
					[Cpp2IlInjected.Token(Token = "0x6000093")]
					[Cpp2IlInjected.Address(RVA = "0xA5B1800", Offset = "0xA5B0200", VA = "0x18A5B1800")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700000D")]
				public static Guid CENQLPUSODM
				{
					[Cpp2IlInjected.Token(Token = "0x6000094")]
					[Cpp2IlInjected.Address(RVA = "0xA5A8980", Offset = "0xA5A7380", VA = "0x18A5A8980")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700000E")]
				public static Guid WQUUDUFFXRM
				{
					[Cpp2IlInjected.Token(Token = "0x6000095")]
					[Cpp2IlInjected.Address(RVA = "0xA5ABA00", Offset = "0xA5AA400", VA = "0x18A5ABA00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700000F")]
				public static Guid DTJQRKDKKQG
				{
					[Cpp2IlInjected.Token(Token = "0x6000096")]
					[Cpp2IlInjected.Address(RVA = "0xA5AB500", Offset = "0xA5A9F00", VA = "0x18A5AB500")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000010")]
				public static Guid HASYLQBXUTL
				{
					[Cpp2IlInjected.Token(Token = "0x6000097")]
					[Cpp2IlInjected.Address(RVA = "0xA5A8E00", Offset = "0xA5A7800", VA = "0x18A5A8E00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000011")]
				public static Guid ITRMIVQZOJA
				{
					[Cpp2IlInjected.Token(Token = "0x6000098")]
					[Cpp2IlInjected.Address(RVA = "0xA5AA180", Offset = "0xA5A8B80", VA = "0x18A5AA180")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000012")]
				public static Guid CPDIMDSJLIW
				{
					[Cpp2IlInjected.Token(Token = "0x6000099")]
					[Cpp2IlInjected.Address(RVA = "0xA5A4880", Offset = "0xA5A3280", VA = "0x18A5A4880")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000013")]
				public static Guid RLYNBUPYGBR
				{
					[Cpp2IlInjected.Token(Token = "0x600009A")]
					[Cpp2IlInjected.Address(RVA = "0xA5A7780", Offset = "0xA5A6180", VA = "0x18A5A7780")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000014")]
				public static Guid QMNAQDZVZTJ
				{
					[Cpp2IlInjected.Token(Token = "0x600009B")]
					[Cpp2IlInjected.Address(RVA = "0xA5A8A80", Offset = "0xA5A7480", VA = "0x18A5A8A80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000015")]
				public static Guid LVJQMHCQXTJ
				{
					[Cpp2IlInjected.Token(Token = "0x600009C")]
					[Cpp2IlInjected.Address(RVA = "0xA5AB400", Offset = "0xA5A9E00", VA = "0x18A5AB400")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000016")]
				public static Guid VMMZJRIFEMD
				{
					[Cpp2IlInjected.Token(Token = "0x600009D")]
					[Cpp2IlInjected.Address(RVA = "0xA5AD980", Offset = "0xA5AC380", VA = "0x18A5AD980")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000017")]
				public static Guid FQFEKIDXWCH
				{
					[Cpp2IlInjected.Token(Token = "0x600009E")]
					[Cpp2IlInjected.Address(RVA = "0xA5B4700", Offset = "0xA5B3100", VA = "0x18A5B4700")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000018")]
				public static Guid JECGCJOHJNL
				{
					[Cpp2IlInjected.Token(Token = "0x600009F")]
					[Cpp2IlInjected.Address(RVA = "0xA5A7980", Offset = "0xA5A6380", VA = "0x18A5A7980")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000019")]
				public static Guid MJCPSBKXWMQ
				{
					[Cpp2IlInjected.Token(Token = "0x60000A0")]
					[Cpp2IlInjected.Address(RVA = "0xA5A5580", Offset = "0xA5A3F80", VA = "0x18A5A5580")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700001A")]
				public static Guid CZYCFHWYEQJ
				{
					[Cpp2IlInjected.Token(Token = "0x60000A1")]
					[Cpp2IlInjected.Address(RVA = "0xA5A9A80", Offset = "0xA5A8480", VA = "0x18A5A9A80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700001B")]
				public static Guid MLFTLRWJZKD
				{
					[Cpp2IlInjected.Token(Token = "0x60000A2")]
					[Cpp2IlInjected.Address(RVA = "0xA5A9F00", Offset = "0xA5A8900", VA = "0x18A5A9F00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700001C")]
				public static Guid YJYDFDUEYYF
				{
					[Cpp2IlInjected.Token(Token = "0x60000A3")]
					[Cpp2IlInjected.Address(RVA = "0xA5AB300", Offset = "0xA5A9D00", VA = "0x18A5AB300")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700001D")]
				public static Guid PMUETFODKSH
				{
					[Cpp2IlInjected.Token(Token = "0x60000A4")]
					[Cpp2IlInjected.Address(RVA = "0xA5AF100", Offset = "0xA5ADB00", VA = "0x18A5AF100")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700001E")]
				public static Guid ABPWQMJWMMI
				{
					[Cpp2IlInjected.Token(Token = "0x60000A5")]
					[Cpp2IlInjected.Address(RVA = "0xA5AF400", Offset = "0xA5ADE00", VA = "0x18A5AF400")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700001F")]
				public static Guid KCLNCHRLLZY
				{
					[Cpp2IlInjected.Token(Token = "0x60000A6")]
					[Cpp2IlInjected.Address(RVA = "0xA5AE700", Offset = "0xA5AD100", VA = "0x18A5AE700")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000020")]
				public static Guid OLBAZSONMRZ
				{
					[Cpp2IlInjected.Token(Token = "0x60000A7")]
					[Cpp2IlInjected.Address(RVA = "0xA5AD580", Offset = "0xA5ABF80", VA = "0x18A5AD580")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000021")]
				public static Guid CFDWYKOUBOL
				{
					[Cpp2IlInjected.Token(Token = "0x60000A8")]
					[Cpp2IlInjected.Address(RVA = "0xA5B3880", Offset = "0xA5B2280", VA = "0x18A5B3880")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000022")]
				public static Guid WGUMHRLILIK
				{
					[Cpp2IlInjected.Token(Token = "0x60000A9")]
					[Cpp2IlInjected.Address(RVA = "0xA5AB780", Offset = "0xA5AA180", VA = "0x18A5AB780")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000023")]
				public static Guid EJYTVHQPNDI
				{
					[Cpp2IlInjected.Token(Token = "0x60000AA")]
					[Cpp2IlInjected.Address(RVA = "0xA5ADE80", Offset = "0xA5AC880", VA = "0x18A5ADE80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000024")]
				public static Guid RQWCXOLQHDF
				{
					[Cpp2IlInjected.Token(Token = "0x60000AB")]
					[Cpp2IlInjected.Address(RVA = "0xA5A9700", Offset = "0xA5A8100", VA = "0x18A5A9700")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000025")]
				public static Guid OHJXQPFQRIF
				{
					[Cpp2IlInjected.Token(Token = "0x60000AC")]
					[Cpp2IlInjected.Address(RVA = "0xA5B0E80", Offset = "0xA5AF880", VA = "0x18A5B0E80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000026")]
				public static Guid HABHYWBLFOI
				{
					[Cpp2IlInjected.Token(Token = "0x60000AD")]
					[Cpp2IlInjected.Address(RVA = "0xA5A4E00", Offset = "0xA5A3800", VA = "0x18A5A4E00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000027")]
				public static Guid PQECEDSOFJC
				{
					[Cpp2IlInjected.Token(Token = "0x60000AE")]
					[Cpp2IlInjected.Address(RVA = "0xA5A7C80", Offset = "0xA5A6680", VA = "0x18A5A7C80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000028")]
				public static Guid EHUJIAASNKZ
				{
					[Cpp2IlInjected.Token(Token = "0x60000AF")]
					[Cpp2IlInjected.Address(RVA = "0xA5AFE80", Offset = "0xA5AE880", VA = "0x18A5AFE80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000029")]
				public static Guid XEKMSKFIJWA
				{
					[Cpp2IlInjected.Token(Token = "0x60000B0")]
					[Cpp2IlInjected.Address(RVA = "0xA5A6D80", Offset = "0xA5A5780", VA = "0x18A5A6D80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700002A")]
				public static Guid VNACZHTONVH
				{
					[Cpp2IlInjected.Token(Token = "0x60000B1")]
					[Cpp2IlInjected.Address(RVA = "0xA5B4A00", Offset = "0xA5B3400", VA = "0x18A5B4A00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700002B")]
				public static Guid WNHWKEJTJJR
				{
					[Cpp2IlInjected.Token(Token = "0x60000B2")]
					[Cpp2IlInjected.Address(RVA = "0xA5AA800", Offset = "0xA5A9200", VA = "0x18A5AA800")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700002C")]
				public static Guid ADIVLDNAKYJ
				{
					[Cpp2IlInjected.Token(Token = "0x60000B3")]
					[Cpp2IlInjected.Address(RVA = "0xA5A9080", Offset = "0xA5A7A80", VA = "0x18A5A9080")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700002D")]
				public static Guid TULJSLNRPGT
				{
					[Cpp2IlInjected.Token(Token = "0x60000B4")]
					[Cpp2IlInjected.Address(RVA = "0xA5B2800", Offset = "0xA5B1200", VA = "0x18A5B2800")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700002E")]
				public static Guid BBKTMAADJTA
				{
					[Cpp2IlInjected.Token(Token = "0x60000B5")]
					[Cpp2IlInjected.Address(RVA = "0xA5B2E00", Offset = "0xA5B1800", VA = "0x18A5B2E00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700002F")]
				public static Guid YAJTAQMSHHJ
				{
					[Cpp2IlInjected.Token(Token = "0x60000B6")]
					[Cpp2IlInjected.Address(RVA = "0xA5B1300", Offset = "0xA5AFD00", VA = "0x18A5B1300")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000030")]
				public static Guid RBGSXFMAWDU
				{
					[Cpp2IlInjected.Token(Token = "0x60000B7")]
					[Cpp2IlInjected.Address(RVA = "0xA5B1500", Offset = "0xA5AFF00", VA = "0x18A5B1500")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000031")]
				public static Guid IIQPVNWCSIJ
				{
					[Cpp2IlInjected.Token(Token = "0x60000B8")]
					[Cpp2IlInjected.Address(RVA = "0xA5AD380", Offset = "0xA5ABD80", VA = "0x18A5AD380")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000032")]
				public static Guid OEZOFSTJNBZ
				{
					[Cpp2IlInjected.Token(Token = "0x60000B9")]
					[Cpp2IlInjected.Address(RVA = "0xA5AB200", Offset = "0xA5A9C00", VA = "0x18A5AB200")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000033")]
				public static Guid NEAQBAIVFJE
				{
					[Cpp2IlInjected.Token(Token = "0x60000BA")]
					[Cpp2IlInjected.Address(RVA = "0xA5ABF00", Offset = "0xA5AA900", VA = "0x18A5ABF00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000034")]
				public static Guid BSXASQJLVGO
				{
					[Cpp2IlInjected.Token(Token = "0x60000BB")]
					[Cpp2IlInjected.Address(RVA = "0xA5AA380", Offset = "0xA5A8D80", VA = "0x18A5AA380")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000035")]
				public static Guid QPYEMLJVARG
				{
					[Cpp2IlInjected.Token(Token = "0x60000BC")]
					[Cpp2IlInjected.Address(RVA = "0xA5ADA00", Offset = "0xA5AC400", VA = "0x18A5ADA00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000036")]
				public static Guid KMCGZQOXEJA
				{
					[Cpp2IlInjected.Token(Token = "0x60000BD")]
					[Cpp2IlInjected.Address(RVA = "0xA5A8480", Offset = "0xA5A6E80", VA = "0x18A5A8480")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000037")]
				public static Guid HNHZMPMODXV
				{
					[Cpp2IlInjected.Token(Token = "0x60000BE")]
					[Cpp2IlInjected.Address(RVA = "0xA5AAC00", Offset = "0xA5A9600", VA = "0x18A5AAC00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000038")]
				public static Guid UXXHOTPBSRN
				{
					[Cpp2IlInjected.Token(Token = "0x60000BF")]
					[Cpp2IlInjected.Address(RVA = "0xA5A9D00", Offset = "0xA5A8700", VA = "0x18A5A9D00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000039")]
				public static Guid TISOTQLQMUK
				{
					[Cpp2IlInjected.Token(Token = "0x60000C0")]
					[Cpp2IlInjected.Address(RVA = "0xA5A6700", Offset = "0xA5A5100", VA = "0x18A5A6700")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700003A")]
				public static Guid FLSIWCAKPTR
				{
					[Cpp2IlInjected.Token(Token = "0x60000C1")]
					[Cpp2IlInjected.Address(RVA = "0xA5AF780", Offset = "0xA5AE180", VA = "0x18A5AF780")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700003B")]
				public static Guid AEJVAKNCGWX
				{
					[Cpp2IlInjected.Token(Token = "0x60000C2")]
					[Cpp2IlInjected.Address(RVA = "0xA5B0F00", Offset = "0xA5AF900", VA = "0x18A5B0F00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700003C")]
				public static Guid SLRBQAPOZHK
				{
					[Cpp2IlInjected.Token(Token = "0x60000C3")]
					[Cpp2IlInjected.Address(RVA = "0xA5AE600", Offset = "0xA5AD000", VA = "0x18A5AE600")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700003D")]
				public static Guid REFFEXBUOTP
				{
					[Cpp2IlInjected.Token(Token = "0x60000C4")]
					[Cpp2IlInjected.Address(RVA = "0xA5A8D80", Offset = "0xA5A7780", VA = "0x18A5A8D80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700003E")]
				public static Guid BQILPAEDIBG
				{
					[Cpp2IlInjected.Token(Token = "0x60000C5")]
					[Cpp2IlInjected.Address(RVA = "0xA5B0480", Offset = "0xA5AEE80", VA = "0x18A5B0480")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700003F")]
				public static Guid IAVYIPGHWXS
				{
					[Cpp2IlInjected.Token(Token = "0x60000C6")]
					[Cpp2IlInjected.Address(RVA = "0xA5A7000", Offset = "0xA5A5A00", VA = "0x18A5A7000")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000040")]
				public static Guid XJNTYMEYWTI
				{
					[Cpp2IlInjected.Token(Token = "0x60000C7")]
					[Cpp2IlInjected.Address(RVA = "0xA5B1700", Offset = "0xA5B0100", VA = "0x18A5B1700")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000041")]
				public static Guid GNUFNFARBJQ
				{
					[Cpp2IlInjected.Token(Token = "0x60000C8")]
					[Cpp2IlInjected.Address(RVA = "0xA5B3400", Offset = "0xA5B1E00", VA = "0x18A5B3400")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000042")]
				public static Guid LEUVQVGLRSI
				{
					[Cpp2IlInjected.Token(Token = "0x60000C9")]
					[Cpp2IlInjected.Address(RVA = "0xA5AAA80", Offset = "0xA5A9480", VA = "0x18A5AAA80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000043")]
				public static Guid EFCNRAHEHOC
				{
					[Cpp2IlInjected.Token(Token = "0x60000CA")]
					[Cpp2IlInjected.Address(RVA = "0xA5A9C80", Offset = "0xA5A8680", VA = "0x18A5A9C80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000044")]
				public static Guid ABAXFDXGSKE
				{
					[Cpp2IlInjected.Token(Token = "0x60000CB")]
					[Cpp2IlInjected.Address(RVA = "0xA5B1680", Offset = "0xA5B0080", VA = "0x18A5B1680")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000045")]
				public static Guid MTWNOZNYFFV
				{
					[Cpp2IlInjected.Token(Token = "0x60000CC")]
					[Cpp2IlInjected.Address(RVA = "0xA5A5500", Offset = "0xA5A3F00", VA = "0x18A5A5500")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000046")]
				public static Guid OVDYBEGWXRE
				{
					[Cpp2IlInjected.Token(Token = "0x60000CD")]
					[Cpp2IlInjected.Address(RVA = "0xA5ABC00", Offset = "0xA5AA600", VA = "0x18A5ABC00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000047")]
				public static Guid ZEFPRGZEXCA
				{
					[Cpp2IlInjected.Token(Token = "0x60000CE")]
					[Cpp2IlInjected.Address(RVA = "0xA5AFD80", Offset = "0xA5AE780", VA = "0x18A5AFD80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000048")]
				public static Guid GDGBTEAGSSR
				{
					[Cpp2IlInjected.Token(Token = "0x60000CF")]
					[Cpp2IlInjected.Address(RVA = "0xA5A5480", Offset = "0xA5A3E80", VA = "0x18A5A5480")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000049")]
				public static Guid MBIEAGDDRPV
				{
					[Cpp2IlInjected.Token(Token = "0x60000D0")]
					[Cpp2IlInjected.Address(RVA = "0xA5AF500", Offset = "0xA5ADF00", VA = "0x18A5AF500")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700004A")]
				public static Guid WEVXKKBYYSO
				{
					[Cpp2IlInjected.Token(Token = "0x60000D1")]
					[Cpp2IlInjected.Address(RVA = "0xA5ACE80", Offset = "0xA5AB880", VA = "0x18A5ACE80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700004B")]
				public static Guid EZQDZEDISEL
				{
					[Cpp2IlInjected.Token(Token = "0x60000D2")]
					[Cpp2IlInjected.Address(RVA = "0xA5A8880", Offset = "0xA5A7280", VA = "0x18A5A8880")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700004C")]
				public static Guid RVZOQTUXHAW
				{
					[Cpp2IlInjected.Token(Token = "0x60000D3")]
					[Cpp2IlInjected.Address(RVA = "0xA5B4980", Offset = "0xA5B3380", VA = "0x18A5B4980")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700004D")]
				public static Guid SBQJAMSBQCA
				{
					[Cpp2IlInjected.Token(Token = "0x60000D4")]
					[Cpp2IlInjected.Address(RVA = "0xA5A5A80", Offset = "0xA5A4480", VA = "0x18A5A5A80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700004E")]
				public static Guid XXMLTIZCIDH
				{
					[Cpp2IlInjected.Token(Token = "0x60000D5")]
					[Cpp2IlInjected.Address(RVA = "0xA5B1780", Offset = "0xA5B0180", VA = "0x18A5B1780")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700004F")]
				public static Guid FDURAERDYCX
				{
					[Cpp2IlInjected.Token(Token = "0x60000D6")]
					[Cpp2IlInjected.Address(RVA = "0xA5A5E80", Offset = "0xA5A4880", VA = "0x18A5A5E80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000050")]
				public static Guid LJHFYJRUPAF
				{
					[Cpp2IlInjected.Token(Token = "0x60000D7")]
					[Cpp2IlInjected.Address(RVA = "0xA5AAA00", Offset = "0xA5A9400", VA = "0x18A5AAA00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000051")]
				public static Guid EULQRCYRBHU
				{
					[Cpp2IlInjected.Token(Token = "0x60000D8")]
					[Cpp2IlInjected.Address(RVA = "0xA5A6B80", Offset = "0xA5A5580", VA = "0x18A5A6B80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000052")]
				public static Guid HDRJRKWQGLP
				{
					[Cpp2IlInjected.Token(Token = "0x60000D9")]
					[Cpp2IlInjected.Address(RVA = "0xA5A9300", Offset = "0xA5A7D00", VA = "0x18A5A9300")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000053")]
				public static Guid NCUCVHDUVUA
				{
					[Cpp2IlInjected.Token(Token = "0x60000DA")]
					[Cpp2IlInjected.Address(RVA = "0xA5AF280", Offset = "0xA5ADC80", VA = "0x18A5AF280")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000054")]
				public static Guid GEBYRAKWBAU
				{
					[Cpp2IlInjected.Token(Token = "0x60000DB")]
					[Cpp2IlInjected.Address(RVA = "0xA5A5B80", Offset = "0xA5A4580", VA = "0x18A5A5B80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000055")]
				public static Guid LTVRMMVFGJS
				{
					[Cpp2IlInjected.Token(Token = "0x60000DC")]
					[Cpp2IlInjected.Address(RVA = "0xA5A7180", Offset = "0xA5A5B80", VA = "0x18A5A7180")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000056")]
				public static Guid XDRQLJHHVGZ
				{
					[Cpp2IlInjected.Token(Token = "0x60000DD")]
					[Cpp2IlInjected.Address(RVA = "0xA5B2100", Offset = "0xA5B0B00", VA = "0x18A5B2100")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000057")]
				public static Guid VWOMPLGUJDX
				{
					[Cpp2IlInjected.Token(Token = "0x60000DE")]
					[Cpp2IlInjected.Address(RVA = "0xA5AD200", Offset = "0xA5ABC00", VA = "0x18A5AD200")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000058")]
				public static Guid XJHRFYKCESU
				{
					[Cpp2IlInjected.Token(Token = "0x60000DF")]
					[Cpp2IlInjected.Address(RVA = "0xA5A9000", Offset = "0xA5A7A00", VA = "0x18A5A9000")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000059")]
				public static Guid YAXVVPSRABV
				{
					[Cpp2IlInjected.Token(Token = "0x60000E0")]
					[Cpp2IlInjected.Address(RVA = "0xA5B1900", Offset = "0xA5B0300", VA = "0x18A5B1900")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700005A")]
				public static Guid QPKEJSHCMPC
				{
					[Cpp2IlInjected.Token(Token = "0x60000E1")]
					[Cpp2IlInjected.Address(RVA = "0xA5AF580", Offset = "0xA5ADF80", VA = "0x18A5AF580")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700005B")]
				public static Guid VWMRRBTUMKA
				{
					[Cpp2IlInjected.Token(Token = "0x60000E2")]
					[Cpp2IlInjected.Address(RVA = "0xA5AE680", Offset = "0xA5AD080", VA = "0x18A5AE680")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700005C")]
				public static Guid NNLZPYBVOPZ
				{
					[Cpp2IlInjected.Token(Token = "0x60000E3")]
					[Cpp2IlInjected.Address(RVA = "0xA5A6480", Offset = "0xA5A4E80", VA = "0x18A5A6480")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700005D")]
				public static Guid YZFWRAZVHBN
				{
					[Cpp2IlInjected.Token(Token = "0x60000E4")]
					[Cpp2IlInjected.Address(RVA = "0xA5AC000", Offset = "0xA5AAA00", VA = "0x18A5AC000")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700005E")]
				public static Guid CIAPXQJNYNW
				{
					[Cpp2IlInjected.Token(Token = "0x60000E5")]
					[Cpp2IlInjected.Address(RVA = "0xA5A5880", Offset = "0xA5A4280", VA = "0x18A5A5880")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700005F")]
				public static Guid FOXNJCGGTPA
				{
					[Cpp2IlInjected.Token(Token = "0x60000E6")]
					[Cpp2IlInjected.Address(RVA = "0xA5A8500", Offset = "0xA5A6F00", VA = "0x18A5A8500")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000060")]
				public static Guid BJJFPXZOMIA
				{
					[Cpp2IlInjected.Token(Token = "0x60000E7")]
					[Cpp2IlInjected.Address(RVA = "0xA5B0680", Offset = "0xA5AF080", VA = "0x18A5B0680")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000061")]
				public static Guid EEBLBEIKROJ
				{
					[Cpp2IlInjected.Token(Token = "0x60000E8")]
					[Cpp2IlInjected.Address(RVA = "0xA5B2D00", Offset = "0xA5B1700", VA = "0x18A5B2D00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000062")]
				public static Guid DYTWESTJQRK
				{
					[Cpp2IlInjected.Token(Token = "0x60000E9")]
					[Cpp2IlInjected.Address(RVA = "0xA5AC680", Offset = "0xA5AB080", VA = "0x18A5AC680")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000063")]
				public static Guid YBGAIBGLSUV
				{
					[Cpp2IlInjected.Token(Token = "0x60000EA")]
					[Cpp2IlInjected.Address(RVA = "0xA5AFB80", Offset = "0xA5AE580", VA = "0x18A5AFB80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000064")]
				public static Guid YAVMNNSQZYD
				{
					[Cpp2IlInjected.Token(Token = "0x60000EB")]
					[Cpp2IlInjected.Address(RVA = "0xA5AFB00", Offset = "0xA5AE500", VA = "0x18A5AFB00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000065")]
				public static Guid EHTMRKDDIAK
				{
					[Cpp2IlInjected.Token(Token = "0x60000EC")]
					[Cpp2IlInjected.Address(RVA = "0xA5B2680", Offset = "0xA5B1080", VA = "0x18A5B2680")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000066")]
				public static Guid EIEALXQYAXC
				{
					[Cpp2IlInjected.Token(Token = "0x60000ED")]
					[Cpp2IlInjected.Address(RVA = "0xA5B2600", Offset = "0xA5B1000", VA = "0x18A5B2600")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000067")]
				public static Guid EIOOGLESTTU
				{
					[Cpp2IlInjected.Token(Token = "0x60000EE")]
					[Cpp2IlInjected.Address(RVA = "0xA5B2580", Offset = "0xA5B0F80", VA = "0x18A5B2580")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000068")]
				public static Guid NNNHMPTZVEC
				{
					[Cpp2IlInjected.Token(Token = "0x60000EF")]
					[Cpp2IlInjected.Address(RVA = "0xA5B0100", Offset = "0xA5AEB00", VA = "0x18A5B0100")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000069")]
				public static Guid UJYKSHJTTYQ
				{
					[Cpp2IlInjected.Token(Token = "0x60000F0")]
					[Cpp2IlInjected.Address(RVA = "0xA5A5B00", Offset = "0xA5A4500", VA = "0x18A5A5B00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700006A")]
				public static Guid QTSNWEOZRGG
				{
					[Cpp2IlInjected.Token(Token = "0x60000F1")]
					[Cpp2IlInjected.Address(RVA = "0xA5ACA00", Offset = "0xA5AB400", VA = "0x18A5ACA00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700006B")]
				public static Guid OUYCJXVPRLT
				{
					[Cpp2IlInjected.Token(Token = "0x60000F2")]
					[Cpp2IlInjected.Address(RVA = "0xA5A7A80", Offset = "0xA5A6480", VA = "0x18A5A7A80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700006C")]
				public static Guid GWLKDIVNGLO
				{
					[Cpp2IlInjected.Token(Token = "0x60000F3")]
					[Cpp2IlInjected.Address(RVA = "0xA5A7800", Offset = "0xA5A6200", VA = "0x18A5A7800")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700006D")]
				public static Guid NMTXTLZVABO
				{
					[Cpp2IlInjected.Token(Token = "0x60000F4")]
					[Cpp2IlInjected.Address(RVA = "0xA5AED80", Offset = "0xA5AD780", VA = "0x18A5AED80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700006E")]
				public static Guid HNSSGTSGEBB
				{
					[Cpp2IlInjected.Token(Token = "0x60000F5")]
					[Cpp2IlInjected.Address(RVA = "0xA5B3E80", Offset = "0xA5B2880", VA = "0x18A5B3E80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700006F")]
				public static Guid FTYLMNCRQDW
				{
					[Cpp2IlInjected.Token(Token = "0x60000F6")]
					[Cpp2IlInjected.Address(RVA = "0xA5B2880", Offset = "0xA5B1280", VA = "0x18A5B2880")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000070")]
				public static Guid SGSDKMTCMCN
				{
					[Cpp2IlInjected.Token(Token = "0x60000F7")]
					[Cpp2IlInjected.Address(RVA = "0xA5A8E80", Offset = "0xA5A7880", VA = "0x18A5A8E80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000071")]
				public static Guid ZIICGHDGQKL
				{
					[Cpp2IlInjected.Token(Token = "0x60000F8")]
					[Cpp2IlInjected.Address(RVA = "0xA5B1380", Offset = "0xA5AFD80", VA = "0x18A5B1380")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000072")]
				public static Guid WNUCMZYOBTX
				{
					[Cpp2IlInjected.Token(Token = "0x60000F9")]
					[Cpp2IlInjected.Address(RVA = "0xA5B1F80", Offset = "0xA5B0980", VA = "0x18A5B1F80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000073")]
				public static Guid FPLAHLFSBLO
				{
					[Cpp2IlInjected.Token(Token = "0x60000FA")]
					[Cpp2IlInjected.Address(RVA = "0xA5B2780", Offset = "0xA5B1180", VA = "0x18A5B2780")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000074")]
				public static Guid VEUWVUCKGKD
				{
					[Cpp2IlInjected.Token(Token = "0x60000FB")]
					[Cpp2IlInjected.Address(RVA = "0xA5B2480", Offset = "0xA5B0E80", VA = "0x18A5B2480")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000075")]
				public static Guid TUZKHGGSAKU
				{
					[Cpp2IlInjected.Token(Token = "0x60000FC")]
					[Cpp2IlInjected.Address(RVA = "0xA5B0A80", Offset = "0xA5AF480", VA = "0x18A5B0A80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000076")]
				public static Guid EHBBAZSYWVD
				{
					[Cpp2IlInjected.Token(Token = "0x60000FD")]
					[Cpp2IlInjected.Address(RVA = "0xA5AA880", Offset = "0xA5A9280", VA = "0x18A5AA880")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000077")]
				public static Guid KBFOJIIUBBF
				{
					[Cpp2IlInjected.Token(Token = "0x60000FE")]
					[Cpp2IlInjected.Address(RVA = "0xA5B1100", Offset = "0xA5AFB00", VA = "0x18A5B1100")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000078")]
				public static Guid CIXIBNQYRLS
				{
					[Cpp2IlInjected.Token(Token = "0x60000FF")]
					[Cpp2IlInjected.Address(RVA = "0xA5A7F00", Offset = "0xA5A6900", VA = "0x18A5A7F00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000079")]
				public static Guid EAKNJDMGNIL
				{
					[Cpp2IlInjected.Token(Token = "0x6000100")]
					[Cpp2IlInjected.Address(RVA = "0xA5AC880", Offset = "0xA5AB280", VA = "0x18A5AC880")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700007A")]
				public static Guid OPNZQAJLJWD
				{
					[Cpp2IlInjected.Token(Token = "0x6000101")]
					[Cpp2IlInjected.Address(RVA = "0xA5AD300", Offset = "0xA5ABD00", VA = "0x18A5AD300")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700007B")]
				public static Guid GSINEHESZSX
				{
					[Cpp2IlInjected.Token(Token = "0x6000102")]
					[Cpp2IlInjected.Address(RVA = "0xA5AEE80", Offset = "0xA5AD880", VA = "0x18A5AEE80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700007C")]
				public static Guid UMJFNQSIAET
				{
					[Cpp2IlInjected.Token(Token = "0x6000103")]
					[Cpp2IlInjected.Address(RVA = "0xA5AA900", Offset = "0xA5A9300", VA = "0x18A5AA900")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700007D")]
				public static Guid JJKXKOCJLGO
				{
					[Cpp2IlInjected.Token(Token = "0x6000104")]
					[Cpp2IlInjected.Address(RVA = "0xA5AF900", Offset = "0xA5AE300", VA = "0x18A5AF900")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700007E")]
				public static Guid CBPRGBREODE
				{
					[Cpp2IlInjected.Token(Token = "0x6000105")]
					[Cpp2IlInjected.Address(RVA = "0xA5A4E80", Offset = "0xA5A3880", VA = "0x18A5A4E80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700007F")]
				public static Guid EJLGKDKOMAT
				{
					[Cpp2IlInjected.Token(Token = "0x6000106")]
					[Cpp2IlInjected.Address(RVA = "0xA5AF800", Offset = "0xA5AE200", VA = "0x18A5AF800")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000080")]
				public static Guid ZYVZSSIHRSY
				{
					[Cpp2IlInjected.Token(Token = "0x6000107")]
					[Cpp2IlInjected.Address(RVA = "0xA5A6600", Offset = "0xA5A5000", VA = "0x18A5A6600")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000081")]
				public static Guid WZKMZETTCJO
				{
					[Cpp2IlInjected.Token(Token = "0x6000108")]
					[Cpp2IlInjected.Address(RVA = "0xA5AF600", Offset = "0xA5AE000", VA = "0x18A5AF600")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000082")]
				public static Guid WJSIFAJIGWA
				{
					[Cpp2IlInjected.Token(Token = "0x6000109")]
					[Cpp2IlInjected.Address(RVA = "0xA5A6E80", Offset = "0xA5A5880", VA = "0x18A5A6E80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000083")]
				public static Guid XHFYXPQXCAA
				{
					[Cpp2IlInjected.Token(Token = "0x600010A")]
					[Cpp2IlInjected.Address(RVA = "0xA5AE780", Offset = "0xA5AD180", VA = "0x18A5AE780")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000084")]
				public static Guid XTEBIPPCNXL
				{
					[Cpp2IlInjected.Token(Token = "0x600010B")]
					[Cpp2IlInjected.Address(RVA = "0xA5A9680", Offset = "0xA5A8080", VA = "0x18A5A9680")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000085")]
				public static Guid OSMXTLDJOAO
				{
					[Cpp2IlInjected.Token(Token = "0x600010C")]
					[Cpp2IlInjected.Address(RVA = "0xA5A5200", Offset = "0xA5A3C00", VA = "0x18A5A5200")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000086")]
				public static Guid PMUTKAAFGDD
				{
					[Cpp2IlInjected.Token(Token = "0x600010D")]
					[Cpp2IlInjected.Address(RVA = "0xA5ADA80", Offset = "0xA5AC480", VA = "0x18A5ADA80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000087")]
				public static Guid NVGMLFPJOZL
				{
					[Cpp2IlInjected.Token(Token = "0x600010E")]
					[Cpp2IlInjected.Address(RVA = "0xA5AA480", Offset = "0xA5A8E80", VA = "0x18A5AA480")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000088")]
				public static Guid QVGKAVKYKIX
				{
					[Cpp2IlInjected.Token(Token = "0x600010F")]
					[Cpp2IlInjected.Address(RVA = "0xA5AB700", Offset = "0xA5AA100", VA = "0x18A5AB700")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000089")]
				public static Guid TUVPFNXCOOQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000110")]
					[Cpp2IlInjected.Address(RVA = "0xA5AF200", Offset = "0xA5ADC00", VA = "0x18A5AF200")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008A")]
				public static Guid MBRMABGJRER
				{
					[Cpp2IlInjected.Token(Token = "0x6000111")]
					[Cpp2IlInjected.Address(RVA = "0xA5AE480", Offset = "0xA5ACE80", VA = "0x18A5AE480")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008B")]
				public static Guid HLBQWEZJNEG
				{
					[Cpp2IlInjected.Token(Token = "0x6000112")]
					[Cpp2IlInjected.Address(RVA = "0xA5AAF00", Offset = "0xA5A9900", VA = "0x18A5AAF00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008C")]
				public static Guid ZPQOMYNOKLZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000113")]
					[Cpp2IlInjected.Address(RVA = "0xA5B1980", Offset = "0xA5B0380", VA = "0x18A5B1980")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008D")]
				public static Guid TPOMZQTSSQU
				{
					[Cpp2IlInjected.Token(Token = "0x6000114")]
					[Cpp2IlInjected.Address(RVA = "0xA5A5E00", Offset = "0xA5A4800", VA = "0x18A5A5E00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008E")]
				public static Guid IPIACKNURVA
				{
					[Cpp2IlInjected.Token(Token = "0x6000115")]
					[Cpp2IlInjected.Address(RVA = "0xA5A7D80", Offset = "0xA5A6780", VA = "0x18A5A7D80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700008F")]
				public static Guid FZOGVFVKWVI
				{
					[Cpp2IlInjected.Token(Token = "0x6000116")]
					[Cpp2IlInjected.Address(RVA = "0xA5A6200", Offset = "0xA5A4C00", VA = "0x18A5A6200")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000090")]
				public static Guid QOUNGPBORNV
				{
					[Cpp2IlInjected.Token(Token = "0x6000117")]
					[Cpp2IlInjected.Address(RVA = "0xA5AB800", Offset = "0xA5AA200", VA = "0x18A5AB800")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000091")]
				public static Guid NNQQMRPEMKG
				{
					[Cpp2IlInjected.Token(Token = "0x6000118")]
					[Cpp2IlInjected.Address(RVA = "0xA5A5300", Offset = "0xA5A3D00", VA = "0x18A5A5300")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000092")]
				public static Guid AWLBUTAEMDJ
				{
					[Cpp2IlInjected.Token(Token = "0x6000119")]
					[Cpp2IlInjected.Address(RVA = "0xA5AA100", Offset = "0xA5A8B00", VA = "0x18A5AA100")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000093")]
				public static Guid VVRTTOQSBXK
				{
					[Cpp2IlInjected.Token(Token = "0x600011A")]
					[Cpp2IlInjected.Address(RVA = "0xA5A8800", Offset = "0xA5A7200", VA = "0x18A5A8800")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000094")]
				public static Guid LHEKAMPXEFF
				{
					[Cpp2IlInjected.Token(Token = "0x600011B")]
					[Cpp2IlInjected.Address(RVA = "0xA5B3500", Offset = "0xA5B1F00", VA = "0x18A5B3500")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000095")]
				public static Guid ZHHVDHELHPQ
				{
					[Cpp2IlInjected.Token(Token = "0x600011C")]
					[Cpp2IlInjected.Address(RVA = "0xA5B3800", Offset = "0xA5B2200", VA = "0x18A5B3800")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000096")]
				public static Guid PTGYMDLMXLC
				{
					[Cpp2IlInjected.Token(Token = "0x600011D")]
					[Cpp2IlInjected.Address(RVA = "0xA5B3F00", Offset = "0xA5B2900", VA = "0x18A5B3F00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000097")]
				public static Guid NXXHGOQYLHY
				{
					[Cpp2IlInjected.Token(Token = "0x600011E")]
					[Cpp2IlInjected.Address(RVA = "0xA5A5F80", Offset = "0xA5A4980", VA = "0x18A5A5F80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000098")]
				public static Guid AEDUUJAYVJC
				{
					[Cpp2IlInjected.Token(Token = "0x600011F")]
					[Cpp2IlInjected.Address(RVA = "0xA5B4800", Offset = "0xA5B3200", VA = "0x18A5B4800")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000099")]
				public static Guid NQELPCFISIU
				{
					[Cpp2IlInjected.Token(Token = "0x6000120")]
					[Cpp2IlInjected.Address(RVA = "0xA5AF080", Offset = "0xA5ADA80", VA = "0x18A5AF080")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700009A")]
				public static Guid FKNQGHVSQGP
				{
					[Cpp2IlInjected.Token(Token = "0x6000121")]
					[Cpp2IlInjected.Address(RVA = "0xA5B4500", Offset = "0xA5B2F00", VA = "0x18A5B4500")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700009B")]
				public static Guid WNFCNAYSLLU
				{
					[Cpp2IlInjected.Token(Token = "0x6000122")]
					[Cpp2IlInjected.Address(RVA = "0xA5AAE80", Offset = "0xA5A9880", VA = "0x18A5AAE80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700009C")]
				public static Guid TFCUFPFWOOO
				{
					[Cpp2IlInjected.Token(Token = "0x6000123")]
					[Cpp2IlInjected.Address(RVA = "0xA5AF300", Offset = "0xA5ADD00", VA = "0x18A5AF300")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700009D")]
				public static Guid CGESILUJNFV
				{
					[Cpp2IlInjected.Token(Token = "0x6000124")]
					[Cpp2IlInjected.Address(RVA = "0xA5AC980", Offset = "0xA5AB380", VA = "0x18A5AC980")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700009E")]
				public static Guid IMYFPMOOYUO
				{
					[Cpp2IlInjected.Token(Token = "0x6000125")]
					[Cpp2IlInjected.Address(RVA = "0xA5A7380", Offset = "0xA5A5D80", VA = "0x18A5A7380")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700009F")]
				public static Guid WEOXOEWNBSA
				{
					[Cpp2IlInjected.Token(Token = "0x6000126")]
					[Cpp2IlInjected.Address(RVA = "0xA5B0000", Offset = "0xA5AEA00", VA = "0x18A5B0000")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A0")]
				public static Guid QFTYDXTYVLY
				{
					[Cpp2IlInjected.Token(Token = "0x6000127")]
					[Cpp2IlInjected.Address(RVA = "0xA5B3D80", Offset = "0xA5B2780", VA = "0x18A5B3D80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A1")]
				public static Guid SSUSJWTVOEF
				{
					[Cpp2IlInjected.Token(Token = "0x6000128")]
					[Cpp2IlInjected.Address(RVA = "0xA5AED00", Offset = "0xA5AD700", VA = "0x18A5AED00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A2")]
				public static Guid JARLPPESUZV
				{
					[Cpp2IlInjected.Token(Token = "0x6000129")]
					[Cpp2IlInjected.Address(RVA = "0xA5AF980", Offset = "0xA5AE380", VA = "0x18A5AF980")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A3")]
				public static Guid XWPBMHCXRMV
				{
					[Cpp2IlInjected.Token(Token = "0x600012A")]
					[Cpp2IlInjected.Address(RVA = "0xA5A9900", Offset = "0xA5A8300", VA = "0x18A5A9900")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A4")]
				public static Guid DNKKZXQDCBU
				{
					[Cpp2IlInjected.Token(Token = "0x600012B")]
					[Cpp2IlInjected.Address(RVA = "0xA5B3300", Offset = "0xA5B1D00", VA = "0x18A5B3300")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A5")]
				public static Guid WQPNSMWZUYQ
				{
					[Cpp2IlInjected.Token(Token = "0x600012C")]
					[Cpp2IlInjected.Address(RVA = "0xA5A7A00", Offset = "0xA5A6400", VA = "0x18A5A7A00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A6")]
				public static Guid LXUPKMQYFSH
				{
					[Cpp2IlInjected.Token(Token = "0x600012D")]
					[Cpp2IlInjected.Address(RVA = "0xA5A7580", Offset = "0xA5A5F80", VA = "0x18A5A7580")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A7")]
				public static Guid VDHUCSQMYNX
				{
					[Cpp2IlInjected.Token(Token = "0x600012E")]
					[Cpp2IlInjected.Address(RVA = "0xA5ADB00", Offset = "0xA5AC500", VA = "0x18A5ADB00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A8")]
				public static Guid FHZIMBDKBCR
				{
					[Cpp2IlInjected.Token(Token = "0x600012F")]
					[Cpp2IlInjected.Address(RVA = "0xA5A6080", Offset = "0xA5A4A80", VA = "0x18A5A6080")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000A9")]
				public static Guid AFGLJTYOKWJ
				{
					[Cpp2IlInjected.Token(Token = "0x6000130")]
					[Cpp2IlInjected.Address(RVA = "0xA5B3B00", Offset = "0xA5B2500", VA = "0x18A5B3B00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000AA")]
				public static Guid LXZZYYBCROR
				{
					[Cpp2IlInjected.Token(Token = "0x6000131")]
					[Cpp2IlInjected.Address(RVA = "0xA5A7680", Offset = "0xA5A6080", VA = "0x18A5A7680")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000AB")]
				public static Guid OLTCPIUWHYA
				{
					[Cpp2IlInjected.Token(Token = "0x6000132")]
					[Cpp2IlInjected.Address(RVA = "0xA5B2B80", Offset = "0xA5B1580", VA = "0x18A5B2B80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000AC")]
				public static Guid VHKGTHYTPUO
				{
					[Cpp2IlInjected.Token(Token = "0x6000133")]
					[Cpp2IlInjected.Address(RVA = "0xA5A5400", Offset = "0xA5A3E00", VA = "0x18A5A5400")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000AD")]
				public static Guid RSCKPRGCCNL
				{
					[Cpp2IlInjected.Token(Token = "0x6000134")]
					[Cpp2IlInjected.Address(RVA = "0xA5ADF80", Offset = "0xA5AC980", VA = "0x18A5ADF80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000AE")]
				public static Guid LWUVKKTVMER
				{
					[Cpp2IlInjected.Token(Token = "0x6000135")]
					[Cpp2IlInjected.Address(RVA = "0xA5A4A80", Offset = "0xA5A3480", VA = "0x18A5A4A80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000AF")]
				public static Guid TGHEBTYGPIT
				{
					[Cpp2IlInjected.Token(Token = "0x6000136")]
					[Cpp2IlInjected.Address(RVA = "0xA5B0A00", Offset = "0xA5AF400", VA = "0x18A5B0A00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B0")]
				public static Guid WIBXQNOAYCO
				{
					[Cpp2IlInjected.Token(Token = "0x6000137")]
					[Cpp2IlInjected.Address(RVA = "0xA5A9B80", Offset = "0xA5A8580", VA = "0x18A5A9B80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B1")]
				public static Guid ZRGFIRRNOGU
				{
					[Cpp2IlInjected.Token(Token = "0x6000138")]
					[Cpp2IlInjected.Address(RVA = "0xA5A7700", Offset = "0xA5A6100", VA = "0x18A5A7700")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B2")]
				public static Guid PQCWBPOOVMH
				{
					[Cpp2IlInjected.Token(Token = "0x6000139")]
					[Cpp2IlInjected.Address(RVA = "0xA5B0180", Offset = "0xA5AEB80", VA = "0x18A5B0180")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B3")]
				public static Guid ZLXYSMWUBNC
				{
					[Cpp2IlInjected.Token(Token = "0x600013A")]
					[Cpp2IlInjected.Address(RVA = "0xA5A6900", Offset = "0xA5A5300", VA = "0x18A5A6900")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B4")]
				public static Guid YRBJKSZRHYY
				{
					[Cpp2IlInjected.Token(Token = "0x600013B")]
					[Cpp2IlInjected.Address(RVA = "0xA5A7880", Offset = "0xA5A6280", VA = "0x18A5A7880")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B5")]
				public static Guid QZJMXGTHBFY
				{
					[Cpp2IlInjected.Token(Token = "0x600013C")]
					[Cpp2IlInjected.Address(RVA = "0xA5AB100", Offset = "0xA5A9B00", VA = "0x18A5AB100")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B6")]
				public static Guid MVTXDAVAAXP
				{
					[Cpp2IlInjected.Token(Token = "0x600013D")]
					[Cpp2IlInjected.Address(RVA = "0xA5AA500", Offset = "0xA5A8F00", VA = "0x18A5AA500")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B7")]
				public static Guid CECSVCWEGQF
				{
					[Cpp2IlInjected.Token(Token = "0x600013E")]
					[Cpp2IlInjected.Address(RVA = "0xA5B1A80", Offset = "0xA5B0480", VA = "0x18A5B1A80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B8")]
				public static Guid AHUVJDRBHDR
				{
					[Cpp2IlInjected.Token(Token = "0x600013F")]
					[Cpp2IlInjected.Address(RVA = "0xA5A5900", Offset = "0xA5A4300", VA = "0x18A5A5900")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000B9")]
				public static Guid KVVGDKQBHCH
				{
					[Cpp2IlInjected.Token(Token = "0x6000140")]
					[Cpp2IlInjected.Address(RVA = "0xA5AB180", Offset = "0xA5A9B80", VA = "0x18A5AB180")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000BA")]
				public static Guid WBNNWBWYYXI
				{
					[Cpp2IlInjected.Token(Token = "0x6000141")]
					[Cpp2IlInjected.Address(RVA = "0xA5AE900", Offset = "0xA5AD300", VA = "0x18A5AE900")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000BB")]
				public static Guid OSSOSTDQDLQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000142")]
					[Cpp2IlInjected.Address(RVA = "0xA5A7480", Offset = "0xA5A5E80", VA = "0x18A5A7480")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000BC")]
				public static Guid YUAGUDNMWCF
				{
					[Cpp2IlInjected.Token(Token = "0x6000143")]
					[Cpp2IlInjected.Address(RVA = "0xA5B4780", Offset = "0xA5B3180", VA = "0x18A5B4780")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000BD")]
				public static Guid OAKUCGBYQNT
				{
					[Cpp2IlInjected.Token(Token = "0x6000144")]
					[Cpp2IlInjected.Address(RVA = "0xA5AFC00", Offset = "0xA5AE600", VA = "0x18A5AFC00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000BE")]
				public static Guid XUXYJJYIRDQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000145")]
					[Cpp2IlInjected.Address(RVA = "0xA5B3D00", Offset = "0xA5B2700", VA = "0x18A5B3D00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000BF")]
				public static Guid AIMXQQMTOVF
				{
					[Cpp2IlInjected.Token(Token = "0x6000146")]
					[Cpp2IlInjected.Address(RVA = "0xA5A9180", Offset = "0xA5A7B80", VA = "0x18A5A9180")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C0")]
				public static Guid KVYVXCKFBFM
				{
					[Cpp2IlInjected.Token(Token = "0x6000147")]
					[Cpp2IlInjected.Address(RVA = "0xA5A9B00", Offset = "0xA5A8500", VA = "0x18A5A9B00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C1")]
				public static Guid HLNWZZOTUGT
				{
					[Cpp2IlInjected.Token(Token = "0x6000148")]
					[Cpp2IlInjected.Address(RVA = "0xA5A4980", Offset = "0xA5A3380", VA = "0x18A5A4980")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C2")]
				public static Guid HALDAIOSXGT
				{
					[Cpp2IlInjected.Token(Token = "0x6000149")]
					[Cpp2IlInjected.Address(RVA = "0xA5ADC80", Offset = "0xA5AC680", VA = "0x18A5ADC80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C3")]
				public static Guid IPGETKKOUCE
				{
					[Cpp2IlInjected.Token(Token = "0x600014A")]
					[Cpp2IlInjected.Address(RVA = "0xA5A8000", Offset = "0xA5A6A00", VA = "0x18A5A8000")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C4")]
				public static Guid PAPHYBRHIBA
				{
					[Cpp2IlInjected.Token(Token = "0x600014B")]
					[Cpp2IlInjected.Address(RVA = "0xA5B1400", Offset = "0xA5AFE00", VA = "0x18A5B1400")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C5")]
				public static Guid NFMDGPQCWWL
				{
					[Cpp2IlInjected.Token(Token = "0x600014C")]
					[Cpp2IlInjected.Address(RVA = "0xA5B1580", Offset = "0xA5AFF80", VA = "0x18A5B1580")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C6")]
				public static Guid YMQUCYPHJXR
				{
					[Cpp2IlInjected.Token(Token = "0x600014D")]
					[Cpp2IlInjected.Address(RVA = "0xA5A4C80", Offset = "0xA5A3680", VA = "0x18A5A4C80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C7")]
				public static Guid ZWFDVNCDZLE
				{
					[Cpp2IlInjected.Token(Token = "0x600014E")]
					[Cpp2IlInjected.Address(RVA = "0xA5B2A80", Offset = "0xA5B1480", VA = "0x18A5B2A80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C8")]
				public static Guid ERGNWUFVHXE
				{
					[Cpp2IlInjected.Token(Token = "0x600014F")]
					[Cpp2IlInjected.Address(RVA = "0xA5B1C00", Offset = "0xA5B0600", VA = "0x18A5B1C00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000C9")]
				public static Guid XGZYUTTXBMC
				{
					[Cpp2IlInjected.Token(Token = "0x6000150")]
					[Cpp2IlInjected.Address(RVA = "0xA5ADC00", Offset = "0xA5AC600", VA = "0x18A5ADC00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000CA")]
				public static Guid SRGISPZLEUB
				{
					[Cpp2IlInjected.Token(Token = "0x6000151")]
					[Cpp2IlInjected.Address(RVA = "0xA5A7E00", Offset = "0xA5A6800", VA = "0x18A5A7E00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000CB")]
				public static Guid OGIUPHFNPUI
				{
					[Cpp2IlInjected.Token(Token = "0x6000152")]
					[Cpp2IlInjected.Address(RVA = "0xA5AEB00", Offset = "0xA5AD500", VA = "0x18A5AEB00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000CC")]
				public static Guid VHLXFBQCDYK
				{
					[Cpp2IlInjected.Token(Token = "0x6000153")]
					[Cpp2IlInjected.Address(RVA = "0xA5AEE00", Offset = "0xA5AD800", VA = "0x18A5AEE00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000CD")]
				public static Guid RPUMYWGKDUY
				{
					[Cpp2IlInjected.Token(Token = "0x6000154")]
					[Cpp2IlInjected.Address(RVA = "0xA5ADD00", Offset = "0xA5AC700", VA = "0x18A5ADD00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000CE")]
				public static Guid SWJEBVPWIER
				{
					[Cpp2IlInjected.Token(Token = "0x6000155")]
					[Cpp2IlInjected.Address(RVA = "0xA5AB480", Offset = "0xA5A9E80", VA = "0x18A5AB480")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000CF")]
				public static Guid XANZLCANXHB
				{
					[Cpp2IlInjected.Token(Token = "0x6000156")]
					[Cpp2IlInjected.Address(RVA = "0xA5A7100", Offset = "0xA5A5B00", VA = "0x18A5A7100")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D0")]
				public static Guid RLUCPCYGOOY
				{
					[Cpp2IlInjected.Token(Token = "0x6000157")]
					[Cpp2IlInjected.Address(RVA = "0xA5A9280", Offset = "0xA5A7C80", VA = "0x18A5A9280")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D1")]
				public static Guid ENBIOZKULXM
				{
					[Cpp2IlInjected.Token(Token = "0x6000158")]
					[Cpp2IlInjected.Address(RVA = "0xA5ABF80", Offset = "0xA5AA980", VA = "0x18A5ABF80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D2")]
				public static Guid KGPSBMXOAOW
				{
					[Cpp2IlInjected.Token(Token = "0x6000159")]
					[Cpp2IlInjected.Address(RVA = "0xA5A9800", Offset = "0xA5A8200", VA = "0x18A5A9800")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D3")]
				public static Guid JOBAHVGEKHK
				{
					[Cpp2IlInjected.Token(Token = "0x600015A")]
					[Cpp2IlInjected.Address(RVA = "0xA5A8B80", Offset = "0xA5A7580", VA = "0x18A5A8B80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D4")]
				public static Guid OBXUYITXAAE
				{
					[Cpp2IlInjected.Token(Token = "0x600015B")]
					[Cpp2IlInjected.Address(RVA = "0xA5A7080", Offset = "0xA5A5A80", VA = "0x18A5A7080")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D5")]
				public static Guid TEDOVXYIAKU
				{
					[Cpp2IlInjected.Token(Token = "0x600015C")]
					[Cpp2IlInjected.Address(RVA = "0xA5A8300", Offset = "0xA5A6D00", VA = "0x18A5A8300")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D6")]
				public static Guid YXGUICABNTQ
				{
					[Cpp2IlInjected.Token(Token = "0x600015D")]
					[Cpp2IlInjected.Address(RVA = "0xA5B2900", Offset = "0xA5B1300", VA = "0x18A5B2900")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D7")]
				public static Guid TGROAFRRDIH
				{
					[Cpp2IlInjected.Token(Token = "0x600015E")]
					[Cpp2IlInjected.Address(RVA = "0xA5B3A80", Offset = "0xA5B2480", VA = "0x18A5B3A80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D8")]
				public static Guid OSVMDQLAJOA
				{
					[Cpp2IlInjected.Token(Token = "0x600015F")]
					[Cpp2IlInjected.Address(RVA = "0xA5ABD80", Offset = "0xA5AA780", VA = "0x18A5ABD80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000D9")]
				public static Guid STVELCRKMMS
				{
					[Cpp2IlInjected.Token(Token = "0x6000160")]
					[Cpp2IlInjected.Address(RVA = "0xA5AE580", Offset = "0xA5ACF80", VA = "0x18A5AE580")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000DA")]
				public static Guid IOFEOMGQHYW
				{
					[Cpp2IlInjected.Token(Token = "0x6000161")]
					[Cpp2IlInjected.Address(RVA = "0xA5B0F80", Offset = "0xA5AF980", VA = "0x18A5B0F80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000DB")]
				public static Guid BLXONGVPJMQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000162")]
					[Cpp2IlInjected.Address(RVA = "0xA5A9C00", Offset = "0xA5A8600", VA = "0x18A5A9C00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000DC")]
				public static Guid WKDRZLUMCPN
				{
					[Cpp2IlInjected.Token(Token = "0x6000163")]
					[Cpp2IlInjected.Address(RVA = "0xA5AD280", Offset = "0xA5ABC80", VA = "0x18A5AD280")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000DD")]
				public static Guid KATITJBFQCH
				{
					[Cpp2IlInjected.Token(Token = "0x6000164")]
					[Cpp2IlInjected.Address(RVA = "0xA5B0C00", Offset = "0xA5AF600", VA = "0x18A5B0C00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000DE")]
				public static Guid XJIFNECSHKV
				{
					[Cpp2IlInjected.Token(Token = "0x6000165")]
					[Cpp2IlInjected.Address(RVA = "0xA5A4B80", Offset = "0xA5A3580", VA = "0x18A5A4B80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000DF")]
				public static Guid TRKMFPVHOOT
				{
					[Cpp2IlInjected.Token(Token = "0x6000166")]
					[Cpp2IlInjected.Address(RVA = "0xA5A4700", Offset = "0xA5A3100", VA = "0x18A5A4700")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E0")]
				public static Guid LVDUWRQFIBW
				{
					[Cpp2IlInjected.Token(Token = "0x6000167")]
					[Cpp2IlInjected.Address(RVA = "0xA5B4300", Offset = "0xA5B2D00", VA = "0x18A5B4300")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E1")]
				public static Guid MFMCHJJAXQK
				{
					[Cpp2IlInjected.Token(Token = "0x6000168")]
					[Cpp2IlInjected.Address(RVA = "0xA5AD080", Offset = "0xA5ABA80", VA = "0x18A5AD080")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E2")]
				public static Guid COGBWIDRXKK
				{
					[Cpp2IlInjected.Token(Token = "0x6000169")]
					[Cpp2IlInjected.Address(RVA = "0xA5A6880", Offset = "0xA5A5280", VA = "0x18A5A6880")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E3")]
				public static Guid FOFMENSLMMZ
				{
					[Cpp2IlInjected.Token(Token = "0x600016A")]
					[Cpp2IlInjected.Address(RVA = "0xA5A6980", Offset = "0xA5A5380", VA = "0x18A5A6980")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E4")]
				public static Guid SJACJWDOETG
				{
					[Cpp2IlInjected.Token(Token = "0x600016B")]
					[Cpp2IlInjected.Address(RVA = "0xA5AE080", Offset = "0xA5ACA80", VA = "0x18A5AE080")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E5")]
				public static Guid PEIKXAVRRDV
				{
					[Cpp2IlInjected.Token(Token = "0x600016C")]
					[Cpp2IlInjected.Address(RVA = "0xA5A8900", Offset = "0xA5A7300", VA = "0x18A5A8900")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E6")]
				public static Guid MJYUEQUISXO
				{
					[Cpp2IlInjected.Token(Token = "0x600016D")]
					[Cpp2IlInjected.Address(RVA = "0xA5AA400", Offset = "0xA5A8E00", VA = "0x18A5AA400")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E7")]
				public static Guid DHGEJKXUGHU
				{
					[Cpp2IlInjected.Token(Token = "0x600016E")]
					[Cpp2IlInjected.Address(RVA = "0xA5B0500", Offset = "0xA5AEF00", VA = "0x18A5B0500")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E8")]
				public static Guid RGPFEBHDIDF
				{
					[Cpp2IlInjected.Token(Token = "0x600016F")]
					[Cpp2IlInjected.Address(RVA = "0xA5B4600", Offset = "0xA5B3000", VA = "0x18A5B4600")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000E9")]
				public static Guid ZSUUZASOURZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000170")]
					[Cpp2IlInjected.Address(RVA = "0xA5AB980", Offset = "0xA5AA380", VA = "0x18A5AB980")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000EA")]
				public static Guid IOXAYPESCHG
				{
					[Cpp2IlInjected.Token(Token = "0x6000171")]
					[Cpp2IlInjected.Address(RVA = "0xA5ABE80", Offset = "0xA5AA880", VA = "0x18A5ABE80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000EB")]
				public static Guid LEOSWLNEMQO
				{
					[Cpp2IlInjected.Token(Token = "0x6000172")]
					[Cpp2IlInjected.Address(RVA = "0xA5A6A80", Offset = "0xA5A5480", VA = "0x18A5A6A80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000EC")]
				public static Guid FAKBQFAOCDW
				{
					[Cpp2IlInjected.Token(Token = "0x6000173")]
					[Cpp2IlInjected.Address(RVA = "0xA5A6000", Offset = "0xA5A4A00", VA = "0x18A5A6000")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000ED")]
				public static Guid ZASACGBLXEZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000174")]
					[Cpp2IlInjected.Address(RVA = "0xA5AC700", Offset = "0xA5AB100", VA = "0x18A5AC700")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000EE")]
				public static Guid HHGJDMWYLIQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000175")]
					[Cpp2IlInjected.Address(RVA = "0xA5AC480", Offset = "0xA5AAE80", VA = "0x18A5AC480")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000EF")]
				public static Guid SUKEHGXGFJR
				{
					[Cpp2IlInjected.Token(Token = "0x6000176")]
					[Cpp2IlInjected.Address(RVA = "0xA5A8F00", Offset = "0xA5A7900", VA = "0x18A5A8F00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F0")]
				public static Guid TVZUYIWYZAB
				{
					[Cpp2IlInjected.Token(Token = "0x6000177")]
					[Cpp2IlInjected.Address(RVA = "0xA5AB600", Offset = "0xA5AA000", VA = "0x18A5AB600")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F1")]
				public static Guid NCBDFAZQNSR
				{
					[Cpp2IlInjected.Token(Token = "0x6000178")]
					[Cpp2IlInjected.Address(RVA = "0xA5A7B80", Offset = "0xA5A6580", VA = "0x18A5A7B80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F2")]
				public static Guid ZYIYSCXSHZG
				{
					[Cpp2IlInjected.Token(Token = "0x6000179")]
					[Cpp2IlInjected.Address(RVA = "0xA5A8580", Offset = "0xA5A6F80", VA = "0x18A5A8580")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F3")]
				public static Guid IBJYRBUSFGK
				{
					[Cpp2IlInjected.Token(Token = "0x600017A")]
					[Cpp2IlInjected.Address(RVA = "0xA5AA580", Offset = "0xA5A8F80", VA = "0x18A5AA580")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F4")]
				public static Guid ZDJRROFIGKQ
				{
					[Cpp2IlInjected.Token(Token = "0x600017B")]
					[Cpp2IlInjected.Address(RVA = "0xA5B0B00", Offset = "0xA5AF500", VA = "0x18A5B0B00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F5")]
				public static Guid KAUHJBZUREV
				{
					[Cpp2IlInjected.Token(Token = "0x600017C")]
					[Cpp2IlInjected.Address(RVA = "0xA5A5C80", Offset = "0xA5A4680", VA = "0x18A5A5C80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F6")]
				public static Guid SZNJTIMUOTF
				{
					[Cpp2IlInjected.Token(Token = "0x600017D")]
					[Cpp2IlInjected.Address(RVA = "0xA5B4C50", Offset = "0xA5B3650", VA = "0x18A5B4C50")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F7")]
				public static Guid LTLEJWXDBZM
				{
					[Cpp2IlInjected.Token(Token = "0x600017E")]
					[Cpp2IlInjected.Address(RVA = "0xA5A4900", Offset = "0xA5A3300", VA = "0x18A5A4900")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F8")]
				public static Guid LCXUHAXARKW
				{
					[Cpp2IlInjected.Token(Token = "0x600017F")]
					[Cpp2IlInjected.Address(RVA = "0xA5B0200", Offset = "0xA5AEC00", VA = "0x18A5B0200")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000F9")]
				public static Guid XIFSRLCKGHA
				{
					[Cpp2IlInjected.Token(Token = "0x6000180")]
					[Cpp2IlInjected.Address(RVA = "0xA5B3F80", Offset = "0xA5B2980", VA = "0x18A5B3F80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000FA")]
				public static Guid EKOTBIZVFTY
				{
					[Cpp2IlInjected.Token(Token = "0x6000181")]
					[Cpp2IlInjected.Address(RVA = "0xA5B2380", Offset = "0xA5B0D80", VA = "0x18A5B2380")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000FB")]
				public static Guid MKRQLEJTRPB
				{
					[Cpp2IlInjected.Token(Token = "0x6000182")]
					[Cpp2IlInjected.Address(RVA = "0xA5B1E80", Offset = "0xA5B0880", VA = "0x18A5B1E80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000FC")]
				public static Guid KRZUTZCUMRW
				{
					[Cpp2IlInjected.Token(Token = "0x6000183")]
					[Cpp2IlInjected.Address(RVA = "0xA5A8180", Offset = "0xA5A6B80", VA = "0x18A5A8180")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000FD")]
				public static Guid IDAIQSSDCSU
				{
					[Cpp2IlInjected.Token(Token = "0x6000184")]
					[Cpp2IlInjected.Address(RVA = "0xA5AD480", Offset = "0xA5ABE80", VA = "0x18A5AD480")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000FE")]
				public static Guid CPHQKDJMEPJ
				{
					[Cpp2IlInjected.Token(Token = "0x6000185")]
					[Cpp2IlInjected.Address(RVA = "0xA5B4680", Offset = "0xA5B3080", VA = "0x18A5B4680")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170000FF")]
				public static Guid QEBZOFRAZFH
				{
					[Cpp2IlInjected.Token(Token = "0x6000186")]
					[Cpp2IlInjected.Address(RVA = "0xA5B4900", Offset = "0xA5B3300", VA = "0x18A5B4900")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000100")]
				public static Guid ERAITRXNHQU
				{
					[Cpp2IlInjected.Token(Token = "0x6000187")]
					[Cpp2IlInjected.Address(RVA = "0xA5A8600", Offset = "0xA5A7000", VA = "0x18A5A8600")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000101")]
				public static Guid ZDPBHAYNAIB
				{
					[Cpp2IlInjected.Token(Token = "0x6000188")]
					[Cpp2IlInjected.Address(RVA = "0xA5B0400", Offset = "0xA5AEE00", VA = "0x18A5B0400")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000102")]
				public static Guid KCUUBHNOLMW
				{
					[Cpp2IlInjected.Token(Token = "0x6000189")]
					[Cpp2IlInjected.Address(RVA = "0xA5B3B80", Offset = "0xA5B2580", VA = "0x18A5B3B80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000103")]
				public static Guid PGPXCSWCJTL
				{
					[Cpp2IlInjected.Token(Token = "0x600018A")]
					[Cpp2IlInjected.Address(RVA = "0xA5A8700", Offset = "0xA5A7100", VA = "0x18A5A8700")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000104")]
				public static Guid NAQTHFBOGDA
				{
					[Cpp2IlInjected.Token(Token = "0x600018B")]
					[Cpp2IlInjected.Address(RVA = "0xA5B3180", Offset = "0xA5B1B80", VA = "0x18A5B3180")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000105")]
				public static Guid OMJHTVZRHTH
				{
					[Cpp2IlInjected.Token(Token = "0x600018C")]
					[Cpp2IlInjected.Address(RVA = "0xA5B3280", Offset = "0xA5B1C80", VA = "0x18A5B3280")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000106")]
				public static Guid IPNWZLKVGPM
				{
					[Cpp2IlInjected.Token(Token = "0x600018D")]
					[Cpp2IlInjected.Address(RVA = "0xA5ACA80", Offset = "0xA5AB480", VA = "0x18A5ACA80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000107")]
				public static Guid QQSJKICXNPJ
				{
					[Cpp2IlInjected.Token(Token = "0x600018E")]
					[Cpp2IlInjected.Address(RVA = "0xA5B4400", Offset = "0xA5B2E00", VA = "0x18A5B4400")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000108")]
				public static Guid MJKFBICMCXS
				{
					[Cpp2IlInjected.Token(Token = "0x600018F")]
					[Cpp2IlInjected.Address(RVA = "0xA5AC580", Offset = "0xA5AAF80", VA = "0x18A5AC580")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000109")]
				public static Guid AVNLHNYDOKB
				{
					[Cpp2IlInjected.Token(Token = "0x6000190")]
					[Cpp2IlInjected.Address(RVA = "0xA5AEC80", Offset = "0xA5AD680", VA = "0x18A5AEC80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700010A")]
				public static Guid FOHSQDQGBEH
				{
					[Cpp2IlInjected.Token(Token = "0x6000191")]
					[Cpp2IlInjected.Address(RVA = "0xA5AAF80", Offset = "0xA5A9980", VA = "0x18A5AAF80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700010B")]
				public static Guid UTJCQBCGGQO
				{
					[Cpp2IlInjected.Token(Token = "0x6000192")]
					[Cpp2IlInjected.Address(RVA = "0xA5A5280", Offset = "0xA5A3C80", VA = "0x18A5A5280")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700010C")]
				public static Guid RMSHLTOYDLL
				{
					[Cpp2IlInjected.Token(Token = "0x6000193")]
					[Cpp2IlInjected.Address(RVA = "0xA5AA080", Offset = "0xA5A8A80", VA = "0x18A5AA080")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700010D")]
				public static Guid SKEMJUWTFWW
				{
					[Cpp2IlInjected.Token(Token = "0x6000194")]
					[Cpp2IlInjected.Address(RVA = "0xA5AF480", Offset = "0xA5ADE80", VA = "0x18A5AF480")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700010E")]
				public static Guid EURXXWJXUIJ
				{
					[Cpp2IlInjected.Token(Token = "0x6000195")]
					[Cpp2IlInjected.Address(RVA = "0xA5AB380", Offset = "0xA5A9D80", VA = "0x18A5AB380")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700010F")]
				public static Guid NHSOTFKMDSQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000196")]
					[Cpp2IlInjected.Address(RVA = "0xA5AF380", Offset = "0xA5ADD80", VA = "0x18A5AF380")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000110")]
				public static Guid QHCVAXJDVJZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000197")]
					[Cpp2IlInjected.Address(RVA = "0xA5A5000", Offset = "0xA5A3A00", VA = "0x18A5A5000")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000111")]
				public static Guid ODOMKVLPHXT
				{
					[Cpp2IlInjected.Token(Token = "0x6000198")]
					[Cpp2IlInjected.Address(RVA = "0xA5B0980", Offset = "0xA5AF380", VA = "0x18A5B0980")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000112")]
				public static Guid KPTOKSMVROR
				{
					[Cpp2IlInjected.Token(Token = "0x6000199")]
					[Cpp2IlInjected.Address(RVA = "0xA5B3000", Offset = "0xA5B1A00", VA = "0x18A5B3000")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000113")]
				public static Guid LIWIWNSFYNN
				{
					[Cpp2IlInjected.Token(Token = "0x600019A")]
					[Cpp2IlInjected.Address(RVA = "0xA5A8380", Offset = "0xA5A6D80", VA = "0x18A5A8380")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000114")]
				public static Guid RHOGDQAGXJX
				{
					[Cpp2IlInjected.Token(Token = "0x600019B")]
					[Cpp2IlInjected.Address(RVA = "0xA5B1E00", Offset = "0xA5B0800", VA = "0x18A5B1E00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000115")]
				public static Guid ZXKFHEHGDLA
				{
					[Cpp2IlInjected.Token(Token = "0x600019C")]
					[Cpp2IlInjected.Address(RVA = "0xA5A9780", Offset = "0xA5A8180", VA = "0x18A5A9780")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000116")]
				public static Guid RGYLLVSOVBW
				{
					[Cpp2IlInjected.Token(Token = "0x600019D")]
					[Cpp2IlInjected.Address(RVA = "0xA5B1D80", Offset = "0xA5B0780", VA = "0x18A5B1D80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000117")]
				public static Guid RHDSJCMMENF
				{
					[Cpp2IlInjected.Token(Token = "0x600019E")]
					[Cpp2IlInjected.Address(RVA = "0xA5B1D00", Offset = "0xA5B0700", VA = "0x18A5B1D00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000118")]
				public static Guid RAQDMNLEVQP
				{
					[Cpp2IlInjected.Token(Token = "0x600019F")]
					[Cpp2IlInjected.Address(RVA = "0xA5B2000", Offset = "0xA5B0A00", VA = "0x18A5B2000")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000119")]
				public static Guid YEFVRDSXRJE
				{
					[Cpp2IlInjected.Token(Token = "0x60001A0")]
					[Cpp2IlInjected.Address(RVA = "0xA5AC100", Offset = "0xA5AAB00", VA = "0x18A5AC100")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700011A")]
				public static Guid YEAOTWZAHXV
				{
					[Cpp2IlInjected.Token(Token = "0x60001A1")]
					[Cpp2IlInjected.Address(RVA = "0xA5AC080", Offset = "0xA5AAA80", VA = "0x18A5AC080")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700011B")]
				public static Guid AULZKDMIDTN
				{
					[Cpp2IlInjected.Token(Token = "0x60001A2")]
					[Cpp2IlInjected.Address(RVA = "0xA5B4200", Offset = "0xA5B2C00", VA = "0x18A5B4200")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700011C")]
				public static Guid DIBMVMENREH
				{
					[Cpp2IlInjected.Token(Token = "0x60001A3")]
					[Cpp2IlInjected.Address(RVA = "0xA5AAB00", Offset = "0xA5A9500", VA = "0x18A5AAB00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700011D")]
				public static Guid GZEPXWSTYGU
				{
					[Cpp2IlInjected.Token(Token = "0x60001A4")]
					[Cpp2IlInjected.Address(RVA = "0xA5AA200", Offset = "0xA5A8C00", VA = "0x18A5AA200")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700011E")]
				public static Guid MSLOHRPRTVJ
				{
					[Cpp2IlInjected.Token(Token = "0x60001A5")]
					[Cpp2IlInjected.Address(RVA = "0xA5AF000", Offset = "0xA5ADA00", VA = "0x18A5AF000")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700011F")]
				public static Guid RLJMIYRADTN
				{
					[Cpp2IlInjected.Token(Token = "0x60001A6")]
					[Cpp2IlInjected.Address(RVA = "0xA5B2180", Offset = "0xA5B0B80", VA = "0x18A5B2180")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000120")]
				public static Guid YLMFHUXLWDS
				{
					[Cpp2IlInjected.Token(Token = "0x60001A7")]
					[Cpp2IlInjected.Address(RVA = "0xA5B0B80", Offset = "0xA5AF580", VA = "0x18A5B0B80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000121")]
				public static Guid NVGJSAGUHXQ
				{
					[Cpp2IlInjected.Token(Token = "0x60001A8")]
					[Cpp2IlInjected.Address(RVA = "0xA5A7400", Offset = "0xA5A5E00", VA = "0x18A5A7400")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000122")]
				public static Guid LIHQAMIHNKA
				{
					[Cpp2IlInjected.Token(Token = "0x60001A9")]
					[Cpp2IlInjected.Address(RVA = "0xA5A4580", Offset = "0xA5A2F80", VA = "0x18A5A4580")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000123")]
				public static Guid TTDNXGKINAD
				{
					[Cpp2IlInjected.Token(Token = "0x60001AA")]
					[Cpp2IlInjected.Address(RVA = "0xA5B1080", Offset = "0xA5AFA80", VA = "0x18A5B1080")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000124")]
				public static Guid JGUXBDNOMDA
				{
					[Cpp2IlInjected.Token(Token = "0x60001AB")]
					[Cpp2IlInjected.Address(RVA = "0xA5B1000", Offset = "0xA5AFA00", VA = "0x18A5B1000")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000125")]
				public static Guid UAYSXZGGROU
				{
					[Cpp2IlInjected.Token(Token = "0x60001AC")]
					[Cpp2IlInjected.Address(RVA = "0xA5B0600", Offset = "0xA5AF000", VA = "0x18A5B0600")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000126")]
				public static Guid QTAPTSIJWBE
				{
					[Cpp2IlInjected.Token(Token = "0x60001AD")]
					[Cpp2IlInjected.Address(RVA = "0xA5B2980", Offset = "0xA5B1380", VA = "0x18A5B2980")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000127")]
				public static Guid ZQWWGTUBXPN
				{
					[Cpp2IlInjected.Token(Token = "0x60001AE")]
					[Cpp2IlInjected.Address(RVA = "0xA5A7D00", Offset = "0xA5A6700", VA = "0x18A5A7D00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000128")]
				public static Guid QSPBNZOGDOQ
				{
					[Cpp2IlInjected.Token(Token = "0x60001AF")]
					[Cpp2IlInjected.Address(RVA = "0xA5AE980", Offset = "0xA5AD380", VA = "0x18A5AE980")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000129")]
				public static Guid EFMKECTXRYT
				{
					[Cpp2IlInjected.Token(Token = "0x60001B0")]
					[Cpp2IlInjected.Address(RVA = "0xA5A8C80", Offset = "0xA5A7680", VA = "0x18A5A8C80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700012A")]
				public static Guid TBOUGHDCOLR
				{
					[Cpp2IlInjected.Token(Token = "0x60001B1")]
					[Cpp2IlInjected.Address(RVA = "0xA5A7200", Offset = "0xA5A5C00", VA = "0x18A5A7200")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700012B")]
				public static Guid FVQWTWWDKCH
				{
					[Cpp2IlInjected.Token(Token = "0x60001B2")]
					[Cpp2IlInjected.Address(RVA = "0xA5A6F00", Offset = "0xA5A5900", VA = "0x18A5A6F00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700012C")]
				public static Guid EGNLGPJSZEW
				{
					[Cpp2IlInjected.Token(Token = "0x60001B3")]
					[Cpp2IlInjected.Address(RVA = "0xA5A9400", Offset = "0xA5A7E00", VA = "0x18A5A9400")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700012D")]
				public static Guid RCDSWHXVUXD
				{
					[Cpp2IlInjected.Token(Token = "0x60001B4")]
					[Cpp2IlInjected.Address(RVA = "0xA5A5780", Offset = "0xA5A4180", VA = "0x18A5A5780")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700012E")]
				public static Guid ANBOROMAEEC
				{
					[Cpp2IlInjected.Token(Token = "0x60001B5")]
					[Cpp2IlInjected.Address(RVA = "0xA5B4BD0", Offset = "0xA5B35D0", VA = "0x18A5B4BD0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700012F")]
				public static Guid YZRIRJCPPDV
				{
					[Cpp2IlInjected.Token(Token = "0x60001B6")]
					[Cpp2IlInjected.Address(RVA = "0xA5B0D00", Offset = "0xA5AF700", VA = "0x18A5B0D00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000130")]
				public static Guid DODJOAMVGNQ
				{
					[Cpp2IlInjected.Token(Token = "0x60001B7")]
					[Cpp2IlInjected.Address(RVA = "0xA5A9A00", Offset = "0xA5A8400", VA = "0x18A5A9A00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000131")]
				public static Guid VVYBGESFJTC
				{
					[Cpp2IlInjected.Token(Token = "0x60001B8")]
					[Cpp2IlInjected.Address(RVA = "0xA5AE800", Offset = "0xA5AD200", VA = "0x18A5AE800")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000132")]
				public static Guid IEGOEBTLTHK
				{
					[Cpp2IlInjected.Token(Token = "0x60001B9")]
					[Cpp2IlInjected.Address(RVA = "0xA5A6300", Offset = "0xA5A4D00", VA = "0x18A5A6300")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000133")]
				public static Guid YBEXWIBFRHZ
				{
					[Cpp2IlInjected.Token(Token = "0x60001BA")]
					[Cpp2IlInjected.Address(RVA = "0xA5B4CD0", Offset = "0xA5B36D0", VA = "0x18A5B4CD0")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000134")]
				public static Guid EOGINYVNYBD
				{
					[Cpp2IlInjected.Token(Token = "0x60001BB")]
					[Cpp2IlInjected.Address(RVA = "0xA5AAE00", Offset = "0xA5A9800", VA = "0x18A5AAE00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000135")]
				public static Guid GXQYERTACDC
				{
					[Cpp2IlInjected.Token(Token = "0x60001BC")]
					[Cpp2IlInjected.Address(RVA = "0xA5B3380", Offset = "0xA5B1D80", VA = "0x18A5B3380")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000136")]
				public static Guid HVLDNWQGDKC
				{
					[Cpp2IlInjected.Token(Token = "0x60001BD")]
					[Cpp2IlInjected.Address(RVA = "0xA5ABD00", Offset = "0xA5AA700", VA = "0x18A5ABD00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000137")]
				public static Guid LEOSKIXITMJ
				{
					[Cpp2IlInjected.Token(Token = "0x60001BE")]
					[Cpp2IlInjected.Address(RVA = "0xA5A7600", Offset = "0xA5A6000", VA = "0x18A5A7600")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000138")]
				public static Guid KLJOUKHWASM
				{
					[Cpp2IlInjected.Token(Token = "0x60001BF")]
					[Cpp2IlInjected.Address(RVA = "0xA5B0700", Offset = "0xA5AF100", VA = "0x18A5B0700")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000139")]
				public static Guid YIISQHLVAJK
				{
					[Cpp2IlInjected.Token(Token = "0x60001C0")]
					[Cpp2IlInjected.Address(RVA = "0xA5AFF80", Offset = "0xA5AE980", VA = "0x18A5AFF80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700013A")]
				public static Guid NNVRYBZYUZK
				{
					[Cpp2IlInjected.Token(Token = "0x60001C1")]
					[Cpp2IlInjected.Address(RVA = "0xA5A8200", Offset = "0xA5A6C00", VA = "0x18A5A8200")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700013B")]
				public static Guid DQRKSZQZSKC
				{
					[Cpp2IlInjected.Token(Token = "0x60001C2")]
					[Cpp2IlInjected.Address(RVA = "0xA5B2500", Offset = "0xA5B0F00", VA = "0x18A5B2500")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700013C")]
				public static Guid FJEBODZWVLH
				{
					[Cpp2IlInjected.Token(Token = "0x60001C3")]
					[Cpp2IlInjected.Address(RVA = "0xA5A8780", Offset = "0xA5A7180", VA = "0x18A5A8780")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700013D")]
				public static Guid KCWHVFQOGAW
				{
					[Cpp2IlInjected.Token(Token = "0x60001C4")]
					[Cpp2IlInjected.Address(RVA = "0xA5B4100", Offset = "0xA5B2B00", VA = "0x18A5B4100")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700013E")]
				public static Guid GNSCBCMQPAO
				{
					[Cpp2IlInjected.Token(Token = "0x60001C5")]
					[Cpp2IlInjected.Address(RVA = "0xA5ACC00", Offset = "0xA5AB600", VA = "0x18A5ACC00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700013F")]
				public static Guid KCZLPYRZPEG
				{
					[Cpp2IlInjected.Token(Token = "0x60001C6")]
					[Cpp2IlInjected.Address(RVA = "0xA5B0280", Offset = "0xA5AEC80", VA = "0x18A5B0280")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000140")]
				public static Guid APTAJLTDHZS
				{
					[Cpp2IlInjected.Token(Token = "0x60001C7")]
					[Cpp2IlInjected.Address(RVA = "0xA5AAC80", Offset = "0xA5A9680", VA = "0x18A5AAC80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000141")]
				public static Guid ARIQUCNNTNC
				{
					[Cpp2IlInjected.Token(Token = "0x60001C8")]
					[Cpp2IlInjected.Address(RVA = "0xA5B3C00", Offset = "0xA5B2600", VA = "0x18A5B3C00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000142")]
				public static Guid NGDMEPIOWLG
				{
					[Cpp2IlInjected.Token(Token = "0x60001C9")]
					[Cpp2IlInjected.Address(RVA = "0xA5A8A00", Offset = "0xA5A7400", VA = "0x18A5A8A00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000143")]
				public static Guid EDLBSOLNZCU
				{
					[Cpp2IlInjected.Token(Token = "0x60001CA")]
					[Cpp2IlInjected.Address(RVA = "0xA5B0780", Offset = "0xA5AF180", VA = "0x18A5B0780")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000144")]
				public static Guid PZLQVONUVFV
				{
					[Cpp2IlInjected.Token(Token = "0x60001CB")]
					[Cpp2IlInjected.Address(RVA = "0xA5AAD80", Offset = "0xA5A9780", VA = "0x18A5AAD80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000145")]
				public static Guid UGHSIUVADZE
				{
					[Cpp2IlInjected.Token(Token = "0x60001CC")]
					[Cpp2IlInjected.Address(RVA = "0xA5A7280", Offset = "0xA5A5C80", VA = "0x18A5A7280")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000146")]
				public static Guid CJFWHCMMUXN
				{
					[Cpp2IlInjected.Token(Token = "0x60001CD")]
					[Cpp2IlInjected.Address(RVA = "0xA5AD000", Offset = "0xA5ABA00", VA = "0x18A5AD000")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000147")]
				public static Guid ZGSCTXNAMYF
				{
					[Cpp2IlInjected.Token(Token = "0x60001CE")]
					[Cpp2IlInjected.Address(RVA = "0xA5A8100", Offset = "0xA5A6B00", VA = "0x18A5A8100")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000148")]
				public static Guid NKDVSCYXEQL
				{
					[Cpp2IlInjected.Token(Token = "0x60001CF")]
					[Cpp2IlInjected.Address(RVA = "0xA5A8400", Offset = "0xA5A6E00", VA = "0x18A5A8400")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000149")]
				public static Guid VYHVMZBGFJI
				{
					[Cpp2IlInjected.Token(Token = "0x60001D0")]
					[Cpp2IlInjected.Address(RVA = "0xA5AC280", Offset = "0xA5AAC80", VA = "0x18A5AC280")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700014A")]
				public static Guid TGGMSVUDJAZ
				{
					[Cpp2IlInjected.Token(Token = "0x60001D1")]
					[Cpp2IlInjected.Address(RVA = "0xA5B2080", Offset = "0xA5B0A80", VA = "0x18A5B2080")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700014B")]
				public static Guid CYPPKXSZWOS
				{
					[Cpp2IlInjected.Token(Token = "0x60001D2")]
					[Cpp2IlInjected.Address(RVA = "0xA5AC180", Offset = "0xA5AAB80", VA = "0x18A5AC180")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700014C")]
				public static Guid BPZZOBRFRMN
				{
					[Cpp2IlInjected.Token(Token = "0x60001D3")]
					[Cpp2IlInjected.Address(RVA = "0xA5B4880", Offset = "0xA5B3280", VA = "0x18A5B4880")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700014D")]
				public static Guid EFGACOGMXZG
				{
					[Cpp2IlInjected.Token(Token = "0x60001D4")]
					[Cpp2IlInjected.Address(RVA = "0xA5A4F00", Offset = "0xA5A3900", VA = "0x18A5A4F00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700014E")]
				public static Guid ACRMMCDQDIR
				{
					[Cpp2IlInjected.Token(Token = "0x60001D5")]
					[Cpp2IlInjected.Address(RVA = "0xA5B0C80", Offset = "0xA5AF680", VA = "0x18A5B0C80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700014F")]
				public static Guid YWXNDOFYXBK
				{
					[Cpp2IlInjected.Token(Token = "0x60001D6")]
					[Cpp2IlInjected.Address(RVA = "0xA5AA000", Offset = "0xA5A8A00", VA = "0x18A5AA000")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000150")]
				public static Guid MTZPJVRSIPJ
				{
					[Cpp2IlInjected.Token(Token = "0x60001D7")]
					[Cpp2IlInjected.Address(RVA = "0xA5B1280", Offset = "0xA5AFC80", VA = "0x18A5B1280")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000151")]
				public static Guid SEQJMOFHMLM
				{
					[Cpp2IlInjected.Token(Token = "0x60001D8")]
					[Cpp2IlInjected.Address(RVA = "0xA5ADF00", Offset = "0xA5AC900", VA = "0x18A5ADF00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000152")]
				public static Guid SPNNMYRZGDQ
				{
					[Cpp2IlInjected.Token(Token = "0x60001D9")]
					[Cpp2IlInjected.Address(RVA = "0xA5ABE00", Offset = "0xA5AA800", VA = "0x18A5ABE00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000153")]
				public static Guid JIIKYZDNCBG
				{
					[Cpp2IlInjected.Token(Token = "0x60001DA")]
					[Cpp2IlInjected.Address(RVA = "0xA5A5D80", Offset = "0xA5A4780", VA = "0x18A5A5D80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000154")]
				public static Guid KQKPHJYSSWL
				{
					[Cpp2IlInjected.Token(Token = "0x60001DB")]
					[Cpp2IlInjected.Address(RVA = "0xA5A8C00", Offset = "0xA5A7600", VA = "0x18A5A8C00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000155")]
				public static Guid RQMHYLYJNWB
				{
					[Cpp2IlInjected.Token(Token = "0x60001DC")]
					[Cpp2IlInjected.Address(RVA = "0xA5A6A00", Offset = "0xA5A5400", VA = "0x18A5A6A00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000156")]
				public static Guid OBVXFRKFPHB
				{
					[Cpp2IlInjected.Token(Token = "0x60001DD")]
					[Cpp2IlInjected.Address(RVA = "0xA5AEF00", Offset = "0xA5AD900", VA = "0x18A5AEF00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000157")]
				public static Guid ZQUNEWVYOXG
				{
					[Cpp2IlInjected.Token(Token = "0x60001DE")]
					[Cpp2IlInjected.Address(RVA = "0xA5AEA80", Offset = "0xA5AD480", VA = "0x18A5AEA80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000158")]
				public static Guid UHHOTXGCTNQ
				{
					[Cpp2IlInjected.Token(Token = "0x60001DF")]
					[Cpp2IlInjected.Address(RVA = "0xA5B3A00", Offset = "0xA5B2400", VA = "0x18A5B3A00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000159")]
				public static Guid AHGUXORKCWF
				{
					[Cpp2IlInjected.Token(Token = "0x60001E0")]
					[Cpp2IlInjected.Address(RVA = "0xA5A8B00", Offset = "0xA5A7500", VA = "0x18A5A8B00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700015A")]
				public static Guid FXQGCQEZYPE
				{
					[Cpp2IlInjected.Token(Token = "0x60001E1")]
					[Cpp2IlInjected.Address(RVA = "0xA5AB580", Offset = "0xA5A9F80", VA = "0x18A5AB580")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700015B")]
				public static Guid PGVSSSPZVEL
				{
					[Cpp2IlInjected.Token(Token = "0x60001E2")]
					[Cpp2IlInjected.Address(RVA = "0xA5B3080", Offset = "0xA5B1A80", VA = "0x18A5B3080")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700015C")]
				public static Guid PDHGOCQMPFI
				{
					[Cpp2IlInjected.Token(Token = "0x60001E3")]
					[Cpp2IlInjected.Address(RVA = "0xA5AC380", Offset = "0xA5AAD80", VA = "0x18A5AC380")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700015D")]
				public static Guid WLNORXNHKZG
				{
					[Cpp2IlInjected.Token(Token = "0x60001E4")]
					[Cpp2IlInjected.Address(RVA = "0xA5B3700", Offset = "0xA5B2100", VA = "0x18A5B3700")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700015E")]
				public static Guid JXODMWPUJSW
				{
					[Cpp2IlInjected.Token(Token = "0x60001E5")]
					[Cpp2IlInjected.Address(RVA = "0xA5A4600", Offset = "0xA5A3000", VA = "0x18A5A4600")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700015F")]
				public static Guid ZELPUKCCXZF
				{
					[Cpp2IlInjected.Token(Token = "0x60001E6")]
					[Cpp2IlInjected.Address(RVA = "0xA5B3680", Offset = "0xA5B2080", VA = "0x18A5B3680")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000160")]
				public static Guid BRPNIJWSXZH
				{
					[Cpp2IlInjected.Token(Token = "0x60001E7")]
					[Cpp2IlInjected.Address(RVA = "0xA5A5700", Offset = "0xA5A4100", VA = "0x18A5A5700")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000161")]
				public static Guid YYBUYMFBNQC
				{
					[Cpp2IlInjected.Token(Token = "0x60001E8")]
					[Cpp2IlInjected.Address(RVA = "0xA5A6280", Offset = "0xA5A4C80", VA = "0x18A5A6280")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000162")]
				public static Guid GRUGSGSVNOA
				{
					[Cpp2IlInjected.Token(Token = "0x60001E9")]
					[Cpp2IlInjected.Address(RVA = "0xA5AD900", Offset = "0xA5AC300", VA = "0x18A5AD900")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000163")]
				public static Guid GAGEUQEPBRJ
				{
					[Cpp2IlInjected.Token(Token = "0x60001EA")]
					[Cpp2IlInjected.Address(RVA = "0xA5AE200", Offset = "0xA5ACC00", VA = "0x18A5AE200")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000164")]
				public static Guid OMOEMJKNNQL
				{
					[Cpp2IlInjected.Token(Token = "0x60001EB")]
					[Cpp2IlInjected.Address(RVA = "0xA5AF680", Offset = "0xA5AE080", VA = "0x18A5AF680")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000165")]
				public static Guid CHLCLFKAJBR
				{
					[Cpp2IlInjected.Token(Token = "0x60001EC")]
					[Cpp2IlInjected.Address(RVA = "0xA5B0E00", Offset = "0xA5AF800", VA = "0x18A5B0E00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000166")]
				public static Guid IWUMEADJNJU
				{
					[Cpp2IlInjected.Token(Token = "0x60001ED")]
					[Cpp2IlInjected.Address(RVA = "0xA5AD780", Offset = "0xA5AC180", VA = "0x18A5AD780")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000167")]
				public static Guid SGHASIZUIFA
				{
					[Cpp2IlInjected.Token(Token = "0x60001EE")]
					[Cpp2IlInjected.Address(RVA = "0xA5B2D80", Offset = "0xA5B1780", VA = "0x18A5B2D80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000168")]
				public static Guid AEUATQWXSBT
				{
					[Cpp2IlInjected.Token(Token = "0x60001EF")]
					[Cpp2IlInjected.Address(RVA = "0xA5A8D00", Offset = "0xA5A7700", VA = "0x18A5A8D00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000169")]
				public static Guid CTREBZCBEXX
				{
					[Cpp2IlInjected.Token(Token = "0x60001F0")]
					[Cpp2IlInjected.Address(RVA = "0xA5A6580", Offset = "0xA5A4F80", VA = "0x18A5A6580")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700016A")]
				public static Guid VFDNNEPJCOO
				{
					[Cpp2IlInjected.Token(Token = "0x60001F1")]
					[Cpp2IlInjected.Address(RVA = "0xA5AD100", Offset = "0xA5ABB00", VA = "0x18A5AD100")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700016B")]
				public static Guid FXVSWSWTLLV
				{
					[Cpp2IlInjected.Token(Token = "0x60001F2")]
					[Cpp2IlInjected.Address(RVA = "0xA5B4580", Offset = "0xA5B2F80", VA = "0x18A5B4580")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700016C")]
				public static Guid FAGWUVEAGYT
				{
					[Cpp2IlInjected.Token(Token = "0x60001F3")]
					[Cpp2IlInjected.Address(RVA = "0xA5B2B00", Offset = "0xA5B1500", VA = "0x18A5B2B00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700016D")]
				public static Guid YZMUQUFCRYQ
				{
					[Cpp2IlInjected.Token(Token = "0x60001F4")]
					[Cpp2IlInjected.Address(RVA = "0xA5B2E80", Offset = "0xA5B1880", VA = "0x18A5B2E80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700016E")]
				public static Guid HKWSOYHFCLX
				{
					[Cpp2IlInjected.Token(Token = "0x60001F5")]
					[Cpp2IlInjected.Address(RVA = "0xA5AEB80", Offset = "0xA5AD580", VA = "0x18A5AEB80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700016F")]
				public static Guid URIHDVORKTT
				{
					[Cpp2IlInjected.Token(Token = "0x60001F6")]
					[Cpp2IlInjected.Address(RVA = "0xA5ADE00", Offset = "0xA5AC800", VA = "0x18A5ADE00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000170")]
				public static Guid OXALMVHIPDF
				{
					[Cpp2IlInjected.Token(Token = "0x60001F7")]
					[Cpp2IlInjected.Address(RVA = "0xA5B4000", Offset = "0xA5B2A00", VA = "0x18A5B4000")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000171")]
				public static Guid LDWONOVGGNF
				{
					[Cpp2IlInjected.Token(Token = "0x60001F8")]
					[Cpp2IlInjected.Address(RVA = "0xA5AF700", Offset = "0xA5AE100", VA = "0x18A5AF700")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000172")]
				public static Guid KFYPQQKHWPL
				{
					[Cpp2IlInjected.Token(Token = "0x60001F9")]
					[Cpp2IlInjected.Address(RVA = "0xA5AB080", Offset = "0xA5A9A80", VA = "0x18A5AB080")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000173")]
				public static Guid LRMSHLKZWZW
				{
					[Cpp2IlInjected.Token(Token = "0x60001FA")]
					[Cpp2IlInjected.Address(RVA = "0xA5B0080", Offset = "0xA5AEA80", VA = "0x18A5B0080")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000174")]
				public static Guid UJMWZKEHKVY
				{
					[Cpp2IlInjected.Token(Token = "0x60001FB")]
					[Cpp2IlInjected.Address(RVA = "0xA5AE280", Offset = "0xA5ACC80", VA = "0x18A5AE280")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000175")]
				public static Guid CKQNAKHRJXJ
				{
					[Cpp2IlInjected.Token(Token = "0x60001FC")]
					[Cpp2IlInjected.Address(RVA = "0xA5AA780", Offset = "0xA5A9180", VA = "0x18A5AA780")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000176")]
				public static Guid SZWKBWGZWIY
				{
					[Cpp2IlInjected.Token(Token = "0x60001FD")]
					[Cpp2IlInjected.Address(RVA = "0xA5AD500", Offset = "0xA5ABF00", VA = "0x18A5AD500")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000177")]
				public static Guid LJNFOOQPZUA
				{
					[Cpp2IlInjected.Token(Token = "0x60001FE")]
					[Cpp2IlInjected.Address(RVA = "0xA5A8080", Offset = "0xA5A6A80", VA = "0x18A5A8080")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000178")]
				public static Guid JISJMUCGHUJ
				{
					[Cpp2IlInjected.Token(Token = "0x60001FF")]
					[Cpp2IlInjected.Address(RVA = "0xA5A8280", Offset = "0xA5A6C80", VA = "0x18A5A8280")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000179")]
				public static Guid FGUNGVBRVGW
				{
					[Cpp2IlInjected.Token(Token = "0x6000200")]
					[Cpp2IlInjected.Address(RVA = "0xA5AC800", Offset = "0xA5AB200", VA = "0x18A5AC800")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700017A")]
				public static Guid LZXYBDESVLY
				{
					[Cpp2IlInjected.Token(Token = "0x6000201")]
					[Cpp2IlInjected.Address(RVA = "0xA5AE300", Offset = "0xA5ACD00", VA = "0x18A5AE300")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700017B")]
				public static Guid UORLBNUUPRE
				{
					[Cpp2IlInjected.Token(Token = "0x6000202")]
					[Cpp2IlInjected.Address(RVA = "0xA5B1C80", Offset = "0xA5B0680", VA = "0x18A5B1C80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700017C")]
				public static Guid CNBJBNWRJEP
				{
					[Cpp2IlInjected.Token(Token = "0x6000203")]
					[Cpp2IlInjected.Address(RVA = "0xA5AF180", Offset = "0xA5ADB80", VA = "0x18A5AF180")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700017D")]
				public static Guid ZJLYUDWSEZQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000204")]
					[Cpp2IlInjected.Address(RVA = "0xA5A7E80", Offset = "0xA5A6880", VA = "0x18A5A7E80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700017E")]
				public static Guid FMFGEJGKVDG
				{
					[Cpp2IlInjected.Token(Token = "0x6000205")]
					[Cpp2IlInjected.Address(RVA = "0xA5AD180", Offset = "0xA5ABB80", VA = "0x18A5AD180")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700017F")]
				public static Guid IPYGCKOBNGF
				{
					[Cpp2IlInjected.Token(Token = "0x6000206")]
					[Cpp2IlInjected.Address(RVA = "0xA5A4D00", Offset = "0xA5A3700", VA = "0x18A5A4D00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000180")]
				public static Guid GACRDGUUDSQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000207")]
					[Cpp2IlInjected.Address(RVA = "0xA5AFD00", Offset = "0xA5AE700", VA = "0x18A5AFD00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000181")]
				public static Guid WZKHKLNQVOF
				{
					[Cpp2IlInjected.Token(Token = "0x6000208")]
					[Cpp2IlInjected.Address(RVA = "0xA5B3600", Offset = "0xA5B2000", VA = "0x18A5B3600")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000182")]
				public static Guid RJFZQFKYAEH
				{
					[Cpp2IlInjected.Token(Token = "0x6000209")]
					[Cpp2IlInjected.Address(RVA = "0xA5A7900", Offset = "0xA5A6300", VA = "0x18A5A7900")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000183")]
				public static Guid UQCPZWDXFIV
				{
					[Cpp2IlInjected.Token(Token = "0x600020A")]
					[Cpp2IlInjected.Address(RVA = "0xA5AA980", Offset = "0xA5A9380", VA = "0x18A5AA980")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000184")]
				public static Guid QHUUXAULXXE
				{
					[Cpp2IlInjected.Token(Token = "0x600020B")]
					[Cpp2IlInjected.Address(RVA = "0xA5ACB80", Offset = "0xA5AB580", VA = "0x18A5ACB80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000185")]
				public static Guid AYTFSQRVTNW
				{
					[Cpp2IlInjected.Token(Token = "0x600020C")]
					[Cpp2IlInjected.Address(RVA = "0xA5AE880", Offset = "0xA5AD280", VA = "0x18A5AE880")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000186")]
				public static Guid ZTCVHEYEMGG
				{
					[Cpp2IlInjected.Token(Token = "0x600020D")]
					[Cpp2IlInjected.Address(RVA = "0xA5AB000", Offset = "0xA5A9A00", VA = "0x18A5AB000")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000187")]
				public static Guid XBXBCOIWKOI
				{
					[Cpp2IlInjected.Token(Token = "0x600020E")]
					[Cpp2IlInjected.Address(RVA = "0xA5A4A00", Offset = "0xA5A3400", VA = "0x18A5A4A00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000188")]
				public static Guid BIVRJNGUXPY
				{
					[Cpp2IlInjected.Token(Token = "0x600020F")]
					[Cpp2IlInjected.Address(RVA = "0xA5AD700", Offset = "0xA5AC100", VA = "0x18A5AD700")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000189")]
				public static Guid AGXEQZPISVI
				{
					[Cpp2IlInjected.Token(Token = "0x6000210")]
					[Cpp2IlInjected.Address(RVA = "0xA5A5A00", Offset = "0xA5A4400", VA = "0x18A5A5A00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018A")]
				public static Guid SWATGSZXALM
				{
					[Cpp2IlInjected.Token(Token = "0x6000211")]
					[Cpp2IlInjected.Address(RVA = "0xA5A6100", Offset = "0xA5A4B00", VA = "0x18A5A6100")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018B")]
				public static Guid NRMIXRFLFNQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000212")]
					[Cpp2IlInjected.Address(RVA = "0xA5B2C80", Offset = "0xA5B1680", VA = "0x18A5B2C80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018C")]
				public static Guid JAIAWEKUQRB
				{
					[Cpp2IlInjected.Token(Token = "0x6000213")]
					[Cpp2IlInjected.Address(RVA = "0xA5AB680", Offset = "0xA5AA080", VA = "0x18A5AB680")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018D")]
				public static Guid GIOIDPIPXJB
				{
					[Cpp2IlInjected.Token(Token = "0x6000214")]
					[Cpp2IlInjected.Address(RVA = "0xA5ACE00", Offset = "0xA5AB800", VA = "0x18A5ACE00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018E")]
				public static Guid FEFJTVHLYVC
				{
					[Cpp2IlInjected.Token(Token = "0x6000215")]
					[Cpp2IlInjected.Address(RVA = "0xA5A8F80", Offset = "0xA5A7980", VA = "0x18A5A8F80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700018F")]
				public static Guid OUBNOYMPKEM
				{
					[Cpp2IlInjected.Token(Token = "0x6000216")]
					[Cpp2IlInjected.Address(RVA = "0xA5AE180", Offset = "0xA5ACB80", VA = "0x18A5AE180")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000190")]
				public static Guid SRSMDCENZSA
				{
					[Cpp2IlInjected.Token(Token = "0x6000217")]
					[Cpp2IlInjected.Address(RVA = "0xA5A7500", Offset = "0xA5A5F00", VA = "0x18A5A7500")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000191")]
				public static Guid TMTIFHWCWWF
				{
					[Cpp2IlInjected.Token(Token = "0x6000218")]
					[Cpp2IlInjected.Address(RVA = "0xA5AD400", Offset = "0xA5ABE00", VA = "0x18A5AD400")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000192")]
				public static Guid TLHNGHMVOSW
				{
					[Cpp2IlInjected.Token(Token = "0x6000219")]
					[Cpp2IlInjected.Address(RVA = "0xA5B3480", Offset = "0xA5B1E80", VA = "0x18A5B3480")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000193")]
				public static Guid RRRPRMRCRRL
				{
					[Cpp2IlInjected.Token(Token = "0x600021A")]
					[Cpp2IlInjected.Address(RVA = "0xA5A4800", Offset = "0xA5A3200", VA = "0x18A5A4800")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000194")]
				public static Guid IGBQTQDZVXX
				{
					[Cpp2IlInjected.Token(Token = "0x600021B")]
					[Cpp2IlInjected.Address(RVA = "0xA5AD880", Offset = "0xA5AC280", VA = "0x18A5AD880")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000195")]
				public static Guid ZSXQAMWBBTX
				{
					[Cpp2IlInjected.Token(Token = "0x600021C")]
					[Cpp2IlInjected.Address(RVA = "0xA5B4280", Offset = "0xA5B2C80", VA = "0x18A5B4280")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000196")]
				public static Guid ITTTQPXLNNZ
				{
					[Cpp2IlInjected.Token(Token = "0x600021D")]
					[Cpp2IlInjected.Address(RVA = "0xA5AA700", Offset = "0xA5A9100", VA = "0x18A5AA700")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000197")]
				public static Guid CCNOUDJDHBL
				{
					[Cpp2IlInjected.Token(Token = "0x600021E")]
					[Cpp2IlInjected.Address(RVA = "0xA5AEF80", Offset = "0xA5AD980", VA = "0x18A5AEF80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000198")]
				public static Guid YATGLLRLIFA
				{
					[Cpp2IlInjected.Token(Token = "0x600021F")]
					[Cpp2IlInjected.Address(RVA = "0xA5A7B00", Offset = "0xA5A6500", VA = "0x18A5A7B00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000199")]
				public static Guid HDBZRAEOIIK
				{
					[Cpp2IlInjected.Token(Token = "0x6000220")]
					[Cpp2IlInjected.Address(RVA = "0xA5B2F00", Offset = "0xA5B1900", VA = "0x18A5B2F00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700019A")]
				public static Guid MAMEJXJFIXS
				{
					[Cpp2IlInjected.Token(Token = "0x6000221")]
					[Cpp2IlInjected.Address(RVA = "0xA5B3C80", Offset = "0xA5B2680", VA = "0x18A5B3C80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700019B")]
				public static Guid VMXQPUHJUEB
				{
					[Cpp2IlInjected.Token(Token = "0x6000222")]
					[Cpp2IlInjected.Address(RVA = "0xA5ACF00", Offset = "0xA5AB900", VA = "0x18A5ACF00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700019C")]
				public static Guid IGHFJLKOWUO
				{
					[Cpp2IlInjected.Token(Token = "0x6000223")]
					[Cpp2IlInjected.Address(RVA = "0xA5AFC80", Offset = "0xA5AE680", VA = "0x18A5AFC80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700019D")]
				public static Guid XNDXBUGXGNT
				{
					[Cpp2IlInjected.Token(Token = "0x6000224")]
					[Cpp2IlInjected.Address(RVA = "0xA5ABB00", Offset = "0xA5AA500", VA = "0x18A5ABB00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700019E")]
				public static Guid AGBPBNSJTTW
				{
					[Cpp2IlInjected.Token(Token = "0x6000225")]
					[Cpp2IlInjected.Address(RVA = "0xA5B2700", Offset = "0xA5B1100", VA = "0x18A5B2700")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700019F")]
				public static Guid IJWRELNXLHF
				{
					[Cpp2IlInjected.Token(Token = "0x6000226")]
					[Cpp2IlInjected.Address(RVA = "0xA5A6C00", Offset = "0xA5A5600", VA = "0x18A5A6C00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A0")]
				public static Guid IYYNUPGYEHK
				{
					[Cpp2IlInjected.Token(Token = "0x6000227")]
					[Cpp2IlInjected.Address(RVA = "0xA5B3980", Offset = "0xA5B2380", VA = "0x18A5B3980")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A1")]
				public static Guid MZLXZNENNUP
				{
					[Cpp2IlInjected.Token(Token = "0x6000228")]
					[Cpp2IlInjected.Address(RVA = "0xA5ACD80", Offset = "0xA5AB780", VA = "0x18A5ACD80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A2")]
				public static Guid EPNPJWKODLK
				{
					[Cpp2IlInjected.Token(Token = "0x6000229")]
					[Cpp2IlInjected.Address(RVA = "0xA5B0880", Offset = "0xA5AF280", VA = "0x18A5B0880")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A3")]
				public static Guid HPPXFDOUOLW
				{
					[Cpp2IlInjected.Token(Token = "0x600022A")]
					[Cpp2IlInjected.Address(RVA = "0xA5AB880", Offset = "0xA5AA280", VA = "0x18A5AB880")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A4")]
				public static Guid YNYLSCXOEST
				{
					[Cpp2IlInjected.Token(Token = "0x600022B")]
					[Cpp2IlInjected.Address(RVA = "0xA5ACB00", Offset = "0xA5AB500", VA = "0x18A5ACB00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A5")]
				public static Guid CNQCBWVQHFB
				{
					[Cpp2IlInjected.Token(Token = "0x600022C")]
					[Cpp2IlInjected.Address(RVA = "0xA5B1480", Offset = "0xA5AFE80", VA = "0x18A5B1480")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A6")]
				public static Guid HBVVGACVJFC
				{
					[Cpp2IlInjected.Token(Token = "0x600022D")]
					[Cpp2IlInjected.Address(RVA = "0xA5ACD00", Offset = "0xA5AB700", VA = "0x18A5ACD00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A7")]
				public static Guid QDZELUZWNKQ
				{
					[Cpp2IlInjected.Token(Token = "0x600022E")]
					[Cpp2IlInjected.Address(RVA = "0xA5A5800", Offset = "0xA5A4200", VA = "0x18A5A5800")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A8")]
				public static Guid AKKXMOUDWPG
				{
					[Cpp2IlInjected.Token(Token = "0x600022F")]
					[Cpp2IlInjected.Address(RVA = "0xA5A7C00", Offset = "0xA5A6600", VA = "0x18A5A7C00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001A9")]
				public static Guid WEGZLOCNILF
				{
					[Cpp2IlInjected.Token(Token = "0x6000230")]
					[Cpp2IlInjected.Address(RVA = "0xA5A9E80", Offset = "0xA5A8880", VA = "0x18A5A9E80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001AA")]
				public static Guid WEWUDIKFKTG
				{
					[Cpp2IlInjected.Token(Token = "0x6000231")]
					[Cpp2IlInjected.Address(RVA = "0xA5A9F80", Offset = "0xA5A8980", VA = "0x18A5A9F80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001AB")]
				public static Guid AUJBNEZNRJQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000232")]
					[Cpp2IlInjected.Address(RVA = "0xA5AD680", Offset = "0xA5AC080", VA = "0x18A5AD680")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001AC")]
				public static Guid DNLTYJWAMFZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000233")]
					[Cpp2IlInjected.Address(RVA = "0xA5AE500", Offset = "0xA5ACF00", VA = "0x18A5AE500")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001AD")]
				public static Guid MFTTPPNAMDV
				{
					[Cpp2IlInjected.Token(Token = "0x6000234")]
					[Cpp2IlInjected.Address(RVA = "0xA5B4380", Offset = "0xA5B2D80", VA = "0x18A5B4380")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001AE")]
				public static Guid IBZUVISMISQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000235")]
					[Cpp2IlInjected.Address(RVA = "0xA5B3E00", Offset = "0xA5B2800", VA = "0x18A5B3E00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001AF")]
				public static Guid DZUHUKNBVIR
				{
					[Cpp2IlInjected.Token(Token = "0x6000236")]
					[Cpp2IlInjected.Address(RVA = "0xA5A4F80", Offset = "0xA5A3980", VA = "0x18A5A4F80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B0")]
				public static Guid XPEZDVXFZTZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000237")]
					[Cpp2IlInjected.Address(RVA = "0xA5AA300", Offset = "0xA5A8D00", VA = "0x18A5AA300")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B1")]
				public static Guid BMTKLFNMUAW
				{
					[Cpp2IlInjected.Token(Token = "0x6000238")]
					[Cpp2IlInjected.Address(RVA = "0xA5A9200", Offset = "0xA5A7C00", VA = "0x18A5A9200")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B2")]
				public static Guid XXWCCAMNELH
				{
					[Cpp2IlInjected.Token(Token = "0x6000239")]
					[Cpp2IlInjected.Address(RVA = "0xA5AE400", Offset = "0xA5ACE00", VA = "0x18A5AE400")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B3")]
				public static Guid KWXCGMMDLRT
				{
					[Cpp2IlInjected.Token(Token = "0x600023A")]
					[Cpp2IlInjected.Address(RVA = "0xA5AC780", Offset = "0xA5AB180", VA = "0x18A5AC780")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B4")]
				public static Guid XOMKRUGVIRP
				{
					[Cpp2IlInjected.Token(Token = "0x600023B")]
					[Cpp2IlInjected.Address(RVA = "0xA5B3580", Offset = "0xA5B1F80", VA = "0x18A5B3580")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B5")]
				public static Guid QIQDBYBAZOJ
				{
					[Cpp2IlInjected.Token(Token = "0x600023C")]
					[Cpp2IlInjected.Address(RVA = "0xA5A9100", Offset = "0xA5A7B00", VA = "0x18A5A9100")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B6")]
				public static Guid LRWWUIOZIXW
				{
					[Cpp2IlInjected.Token(Token = "0x600023D")]
					[Cpp2IlInjected.Address(RVA = "0xA5B3100", Offset = "0xA5B1B00", VA = "0x18A5B3100")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B7")]
				public static Guid PEORWPSGRER
				{
					[Cpp2IlInjected.Token(Token = "0x600023E")]
					[Cpp2IlInjected.Address(RVA = "0xA5AC400", Offset = "0xA5AAE00", VA = "0x18A5AC400")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B8")]
				public static Guid SOSTNSAUOWQ
				{
					[Cpp2IlInjected.Token(Token = "0x600023F")]
					[Cpp2IlInjected.Address(RVA = "0xA5A9500", Offset = "0xA5A7F00", VA = "0x18A5A9500")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001B9")]
				public static Guid DHHSBSQGRQN
				{
					[Cpp2IlInjected.Token(Token = "0x6000240")]
					[Cpp2IlInjected.Address(RVA = "0xA5A9E00", Offset = "0xA5A8800", VA = "0x18A5A9E00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001BA")]
				public static Guid FFGYSFZBJWM
				{
					[Cpp2IlInjected.Token(Token = "0x6000241")]
					[Cpp2IlInjected.Address(RVA = "0xA5AA280", Offset = "0xA5A8C80", VA = "0x18A5AA280")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001BB")]
				public static Guid VDHKIJEGYRS
				{
					[Cpp2IlInjected.Token(Token = "0x6000242")]
					[Cpp2IlInjected.Address(RVA = "0xA5A5C00", Offset = "0xA5A4600", VA = "0x18A5A5C00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001BC")]
				public static Guid VONIDCOCRHO
				{
					[Cpp2IlInjected.Token(Token = "0x6000243")]
					[Cpp2IlInjected.Address(RVA = "0xA5B1200", Offset = "0xA5AFC00", VA = "0x18A5B1200")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001BD")]
				public static Guid WYPFJLHMZEW
				{
					[Cpp2IlInjected.Token(Token = "0x6000244")]
					[Cpp2IlInjected.Address(RVA = "0xA5A6800", Offset = "0xA5A5200", VA = "0x18A5A6800")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001BE")]
				public static Guid TXMOMWWTJOV
				{
					[Cpp2IlInjected.Token(Token = "0x6000245")]
					[Cpp2IlInjected.Address(RVA = "0xA5ACC80", Offset = "0xA5AB680", VA = "0x18A5ACC80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001BF")]
				public static Guid DIEZAIGAGYV
				{
					[Cpp2IlInjected.Token(Token = "0x6000246")]
					[Cpp2IlInjected.Address(RVA = "0xA5AD800", Offset = "0xA5AC200", VA = "0x18A5AD800")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C0")]
				public static Guid JRCRNDUUEWA
				{
					[Cpp2IlInjected.Token(Token = "0x6000247")]
					[Cpp2IlInjected.Address(RVA = "0xA5AC200", Offset = "0xA5AAC00", VA = "0x18A5AC200")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C1")]
				public static Guid KCYWSIVWVYJ
				{
					[Cpp2IlInjected.Token(Token = "0x6000248")]
					[Cpp2IlInjected.Address(RVA = "0xA5A6B00", Offset = "0xA5A5500", VA = "0x18A5A6B00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C2")]
				public static Guid KISEBPUYVJQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000249")]
					[Cpp2IlInjected.Address(RVA = "0xA5ACF80", Offset = "0xA5AB980", VA = "0x18A5ACF80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C3")]
				public static Guid GRWBZWYQBVB
				{
					[Cpp2IlInjected.Token(Token = "0x600024A")]
					[Cpp2IlInjected.Address(RVA = "0xA5ADB80", Offset = "0xA5AC580", VA = "0x18A5ADB80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C4")]
				public static Guid OSBSZFOSMIN
				{
					[Cpp2IlInjected.Token(Token = "0x600024B")]
					[Cpp2IlInjected.Address(RVA = "0xA5AA600", Offset = "0xA5A9000", VA = "0x18A5AA600")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C5")]
				public static Guid EJCMHJOSIKC
				{
					[Cpp2IlInjected.Token(Token = "0x600024C")]
					[Cpp2IlInjected.Address(RVA = "0xA5AFA00", Offset = "0xA5AE400", VA = "0x18A5AFA00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C6")]
				public static Guid UHOYCZXHRXO
				{
					[Cpp2IlInjected.Token(Token = "0x600024D")]
					[Cpp2IlInjected.Address(RVA = "0xA5AFE00", Offset = "0xA5AE800", VA = "0x18A5AFE00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C7")]
				public static Guid KFWOMSJHNPP
				{
					[Cpp2IlInjected.Token(Token = "0x600024E")]
					[Cpp2IlInjected.Address(RVA = "0xA5B2F80", Offset = "0xA5B1980", VA = "0x18A5B2F80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C8")]
				public static Guid JOSNTLHPGXS
				{
					[Cpp2IlInjected.Token(Token = "0x600024F")]
					[Cpp2IlInjected.Address(RVA = "0xA5B0380", Offset = "0xA5AED80", VA = "0x18A5B0380")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001C9")]
				public static Guid ZURASPQZMVL
				{
					[Cpp2IlInjected.Token(Token = "0x6000250")]
					[Cpp2IlInjected.Address(RVA = "0xA5AB900", Offset = "0xA5AA300", VA = "0x18A5AB900")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001CA")]
				public static Guid RKRPDYVRGDC
				{
					[Cpp2IlInjected.Token(Token = "0x6000251")]
					[Cpp2IlInjected.Address(RVA = "0xA5B4A80", Offset = "0xA5B3480", VA = "0x18A5B4A80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001CB")]
				public static Guid EIHVMFIZWHN
				{
					[Cpp2IlInjected.Token(Token = "0x6000252")]
					[Cpp2IlInjected.Address(RVA = "0xA5AFF00", Offset = "0xA5AE900", VA = "0x18A5AFF00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001CC")]
				public static Guid MUNCBOOQZRW
				{
					[Cpp2IlInjected.Token(Token = "0x6000253")]
					[Cpp2IlInjected.Address(RVA = "0xA5B3900", Offset = "0xA5B2300", VA = "0x18A5B3900")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001CD")]
				public static Guid VMQYEECGCHS
				{
					[Cpp2IlInjected.Token(Token = "0x6000254")]
					[Cpp2IlInjected.Address(RVA = "0xA5B0900", Offset = "0xA5AF300", VA = "0x18A5B0900")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001CE")]
				public static Guid QKHXLZZUDLY
				{
					[Cpp2IlInjected.Token(Token = "0x6000255")]
					[Cpp2IlInjected.Address(RVA = "0xA5A5680", Offset = "0xA5A4080", VA = "0x18A5A5680")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001CF")]
				public static Guid LWGJYMIEQQM
				{
					[Cpp2IlInjected.Token(Token = "0x6000256")]
					[Cpp2IlInjected.Address(RVA = "0xA5AF880", Offset = "0xA5AE280", VA = "0x18A5AF880")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D0")]
				public static Guid MHDPLSYOVRD
				{
					[Cpp2IlInjected.Token(Token = "0x6000257")]
					[Cpp2IlInjected.Address(RVA = "0xA5A4780", Offset = "0xA5A3180", VA = "0x18A5A4780")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D1")]
				public static Guid MDSNNBRMFIJ
				{
					[Cpp2IlInjected.Token(Token = "0x6000258")]
					[Cpp2IlInjected.Address(RVA = "0xA5AEA00", Offset = "0xA5AD400", VA = "0x18A5AEA00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D2")]
				public static Guid HWMTGJTSKSS
				{
					[Cpp2IlInjected.Token(Token = "0x6000259")]
					[Cpp2IlInjected.Address(RVA = "0xA5B2200", Offset = "0xA5B0C00", VA = "0x18A5B2200")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D3")]
				public static Guid PGLXRNPYELM
				{
					[Cpp2IlInjected.Token(Token = "0x600025A")]
					[Cpp2IlInjected.Address(RVA = "0xA5A6400", Offset = "0xA5A4E00", VA = "0x18A5A6400")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D4")]
				public static Guid BERYVJBFWAB
				{
					[Cpp2IlInjected.Token(Token = "0x600025B")]
					[Cpp2IlInjected.Address(RVA = "0xA5AE000", Offset = "0xA5ACA00", VA = "0x18A5AE000")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D5")]
				public static Guid FLPMCQBJOWI
				{
					[Cpp2IlInjected.Token(Token = "0x600025C")]
					[Cpp2IlInjected.Address(RVA = "0xA5A5D00", Offset = "0xA5A4700", VA = "0x18A5A5D00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D6")]
				public static Guid LSPYKHHSTPM
				{
					[Cpp2IlInjected.Token(Token = "0x600025D")]
					[Cpp2IlInjected.Address(RVA = "0xA5A9480", Offset = "0xA5A7E80", VA = "0x18A5A9480")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D7")]
				public static Guid MZJATAYHUVS
				{
					[Cpp2IlInjected.Token(Token = "0x600025E")]
					[Cpp2IlInjected.Address(RVA = "0xA5AEC00", Offset = "0xA5AD600", VA = "0x18A5AEC00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D8")]
				public static Guid RNDEWTOYGSA
				{
					[Cpp2IlInjected.Token(Token = "0x600025F")]
					[Cpp2IlInjected.Address(RVA = "0xA5ABC80", Offset = "0xA5AA680", VA = "0x18A5ABC80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001D9")]
				public static Guid KGLUSPXAFOU
				{
					[Cpp2IlInjected.Token(Token = "0x6000260")]
					[Cpp2IlInjected.Address(RVA = "0xA5B1180", Offset = "0xA5AFB80", VA = "0x18A5B1180")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001DA")]
				public static Guid LLXZANPZYDK
				{
					[Cpp2IlInjected.Token(Token = "0x6000261")]
					[Cpp2IlInjected.Address(RVA = "0xA5B1600", Offset = "0xA5B0000", VA = "0x18A5B1600")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001DB")]
				public static Guid BGCYJPUSRCT
				{
					[Cpp2IlInjected.Token(Token = "0x6000262")]
					[Cpp2IlInjected.Address(RVA = "0xA5A9580", Offset = "0xA5A7F80", VA = "0x18A5A9580")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001DC")]
				public static Guid RFXWVKFUUUC
				{
					[Cpp2IlInjected.Token(Token = "0x6000263")]
					[Cpp2IlInjected.Address(RVA = "0xA5A7300", Offset = "0xA5A5D00", VA = "0x18A5A7300")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001DD")]
				public static Guid BUDSOXXSYEF
				{
					[Cpp2IlInjected.Token(Token = "0x6000264")]
					[Cpp2IlInjected.Address(RVA = "0xA5A6F80", Offset = "0xA5A5980", VA = "0x18A5A6F80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001DE")]
				public static Guid ZESDHOMZLOD
				{
					[Cpp2IlInjected.Token(Token = "0x6000265")]
					[Cpp2IlInjected.Address(RVA = "0xA5B4080", Offset = "0xA5B2A80", VA = "0x18A5B4080")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001DF")]
				public static Guid DDRUYLKTUGT
				{
					[Cpp2IlInjected.Token(Token = "0x6000266")]
					[Cpp2IlInjected.Address(RVA = "0xA5A5180", Offset = "0xA5A3B80", VA = "0x18A5A5180")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E0")]
				public static Guid JFESWQCRLPL
				{
					[Cpp2IlInjected.Token(Token = "0x6000267")]
					[Cpp2IlInjected.Address(RVA = "0xA5A7F80", Offset = "0xA5A6980", VA = "0x18A5A7F80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E1")]
				public static Guid MNYROFULLQO
				{
					[Cpp2IlInjected.Token(Token = "0x6000268")]
					[Cpp2IlInjected.Address(RVA = "0xA5B4180", Offset = "0xA5B2B80", VA = "0x18A5B4180")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E2")]
				public static Guid LEHICRZNEJX
				{
					[Cpp2IlInjected.Token(Token = "0x6000269")]
					[Cpp2IlInjected.Address(RVA = "0xA5AFA80", Offset = "0xA5AE480", VA = "0x18A5AFA80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E3")]
				public static Guid GLIHSDWNQVA
				{
					[Cpp2IlInjected.Token(Token = "0x600026A")]
					[Cpp2IlInjected.Address(RVA = "0xA5AA680", Offset = "0xA5A9080", VA = "0x18A5AA680")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E4")]
				public static Guid TWHGGGXWFGT
				{
					[Cpp2IlInjected.Token(Token = "0x600026B")]
					[Cpp2IlInjected.Address(RVA = "0xA5A6680", Offset = "0xA5A5080", VA = "0x18A5A6680")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E5")]
				public static Guid MOCVOEDEWVT
				{
					[Cpp2IlInjected.Token(Token = "0x600026C")]
					[Cpp2IlInjected.Address(RVA = "0xA5AC500", Offset = "0xA5AAF00", VA = "0x18A5AC500")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E6")]
				public static Guid CVXPHZXEXTJ
				{
					[Cpp2IlInjected.Token(Token = "0x600026D")]
					[Cpp2IlInjected.Address(RVA = "0xA5A6500", Offset = "0xA5A4F00", VA = "0x18A5A6500")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E7")]
				public static Guid UTJVAQCYUZC
				{
					[Cpp2IlInjected.Token(Token = "0x600026E")]
					[Cpp2IlInjected.Address(RVA = "0xA5A6180", Offset = "0xA5A4B80", VA = "0x18A5A6180")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E8")]
				public static Guid SMHGOXJMXJX
				{
					[Cpp2IlInjected.Token(Token = "0x600026F")]
					[Cpp2IlInjected.Address(RVA = "0xA5B1A00", Offset = "0xA5B0400", VA = "0x18A5B1A00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001E9")]
				public static Guid OAWUYOTDCCQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000270")]
					[Cpp2IlInjected.Address(RVA = "0xA5A6D00", Offset = "0xA5A5700", VA = "0x18A5A6D00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001EA")]
				public static Guid ARZAQYLTONN
				{
					[Cpp2IlInjected.Token(Token = "0x6000271")]
					[Cpp2IlInjected.Address(RVA = "0xA5A4D80", Offset = "0xA5A3780", VA = "0x18A5A4D80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001EB")]
				public static Guid EGENXRTXEWL
				{
					[Cpp2IlInjected.Token(Token = "0x6000272")]
					[Cpp2IlInjected.Address(RVA = "0xA5B1B00", Offset = "0xA5B0500", VA = "0x18A5B1B00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001EC")]
				public static Guid DLJBKVPQIFN
				{
					[Cpp2IlInjected.Token(Token = "0x6000273")]
					[Cpp2IlInjected.Address(RVA = "0xA5B3200", Offset = "0xA5B1C00", VA = "0x18A5B3200")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001ED")]
				public static Guid JRSJRMEIUGO
				{
					[Cpp2IlInjected.Token(Token = "0x6000274")]
					[Cpp2IlInjected.Address(RVA = "0xA5AE100", Offset = "0xA5ACB00", VA = "0x18A5AE100")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001EE")]
				public static Guid LPELOGBYMSB
				{
					[Cpp2IlInjected.Token(Token = "0x6000275")]
					[Cpp2IlInjected.Address(RVA = "0xA5ADD80", Offset = "0xA5AC780", VA = "0x18A5ADD80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001EF")]
				public static Guid CWPCNMIUBJA
				{
					[Cpp2IlInjected.Token(Token = "0x6000276")]
					[Cpp2IlInjected.Address(RVA = "0xA5A9880", Offset = "0xA5A8280", VA = "0x18A5A9880")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F0")]
				public static Guid ENLCMTSUKAZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000277")]
					[Cpp2IlInjected.Address(RVA = "0xA5A4C00", Offset = "0xA5A3600", VA = "0x18A5A4C00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F1")]
				public static Guid USDPGVOTOUX
				{
					[Cpp2IlInjected.Token(Token = "0x6000278")]
					[Cpp2IlInjected.Address(RVA = "0xA5ABA80", Offset = "0xA5AA480", VA = "0x18A5ABA80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F2")]
				public static Guid ROIAAXRVZPN
				{
					[Cpp2IlInjected.Token(Token = "0x6000279")]
					[Cpp2IlInjected.Address(RVA = "0xA5A9D80", Offset = "0xA5A8780", VA = "0x18A5A9D80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F3")]
				public static Guid QZGMWSNUTDN
				{
					[Cpp2IlInjected.Token(Token = "0x600027A")]
					[Cpp2IlInjected.Address(RVA = "0xA5A6780", Offset = "0xA5A5180", VA = "0x18A5A6780")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F4")]
				public static Guid LTUZGKFOQCN
				{
					[Cpp2IlInjected.Token(Token = "0x600027B")]
					[Cpp2IlInjected.Address(RVA = "0xA5A9600", Offset = "0xA5A8000", VA = "0x18A5A9600")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F5")]
				public static Guid HTAMJOCRVLZ
				{
					[Cpp2IlInjected.Token(Token = "0x600027C")]
					[Cpp2IlInjected.Address(RVA = "0xA5A5F00", Offset = "0xA5A4900", VA = "0x18A5A5F00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F6")]
				public static Guid PSHJYMECTAK
				{
					[Cpp2IlInjected.Token(Token = "0x600027D")]
					[Cpp2IlInjected.Address(RVA = "0xA5B2C00", Offset = "0xA5B1600", VA = "0x18A5B2C00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F7")]
				public static Guid CYKLIWBGAWB
				{
					[Cpp2IlInjected.Token(Token = "0x600027E")]
					[Cpp2IlInjected.Address(RVA = "0xA5B1880", Offset = "0xA5B0280", VA = "0x18A5B1880")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F8")]
				public static Guid KLKGCRFCSTS
				{
					[Cpp2IlInjected.Token(Token = "0x600027F")]
					[Cpp2IlInjected.Address(RVA = "0xA5B4480", Offset = "0xA5B2E80", VA = "0x18A5B4480")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001F9")]
				public static Guid YBRKTUNSONQ
				{
					[Cpp2IlInjected.Token(Token = "0x6000280")]
					[Cpp2IlInjected.Address(RVA = "0xA5B0300", Offset = "0xA5AED00", VA = "0x18A5B0300")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001FA")]
				public static Guid FUYUKYOPCHF
				{
					[Cpp2IlInjected.Token(Token = "0x6000281")]
					[Cpp2IlInjected.Address(RVA = "0xA5AD600", Offset = "0xA5AC000", VA = "0x18A5AD600")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001FB")]
				public static Guid KRSJFJGVIDA
				{
					[Cpp2IlInjected.Token(Token = "0x6000282")]
					[Cpp2IlInjected.Address(RVA = "0xA5A9980", Offset = "0xA5A8380", VA = "0x18A5A9980")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001FC")]
				public static Guid XABGITARLKW
				{
					[Cpp2IlInjected.Token(Token = "0x6000283")]
					[Cpp2IlInjected.Address(RVA = "0xA5B4B50", Offset = "0xA5B3550", VA = "0x18A5B4B50")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001FD")]
				public static Guid RFKWVLATVJP
				{
					[Cpp2IlInjected.Token(Token = "0x6000284")]
					[Cpp2IlInjected.Address(RVA = "0xA5AAD00", Offset = "0xA5A9700", VA = "0x18A5AAD00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001FE")]
				public static Guid IWCSOLANBIF
				{
					[Cpp2IlInjected.Token(Token = "0x6000285")]
					[Cpp2IlInjected.Address(RVA = "0xA5A6E00", Offset = "0xA5A5800", VA = "0x18A5A6E00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x170001FF")]
				public static Guid WMYGASHDASS
				{
					[Cpp2IlInjected.Token(Token = "0x6000286")]
					[Cpp2IlInjected.Address(RVA = "0xA5A6380", Offset = "0xA5A4D80", VA = "0x18A5A6380")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000200")]
				public static Guid CCEUYFCHKYH
				{
					[Cpp2IlInjected.Token(Token = "0x6000287")]
					[Cpp2IlInjected.Address(RVA = "0xA5A6C80", Offset = "0xA5A5680", VA = "0x18A5A6C80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000201")]
				public static Guid BENLINWNINZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000288")]
					[Cpp2IlInjected.Address(RVA = "0xA5A5600", Offset = "0xA5A4000", VA = "0x18A5A5600")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000202")]
				public static Guid KYQDAKHHDLX
				{
					[Cpp2IlInjected.Token(Token = "0x6000289")]
					[Cpp2IlInjected.Address(RVA = "0xA5B2400", Offset = "0xA5B0E00", VA = "0x18A5B2400")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000203")]
				public static Guid MWGFYZCQGMU
				{
					[Cpp2IlInjected.Token(Token = "0x600028A")]
					[Cpp2IlInjected.Address(RVA = "0xA5ABB80", Offset = "0xA5AA580", VA = "0x18A5ABB80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000204")]
				public static Guid QFDGLHSBBHI
				{
					[Cpp2IlInjected.Token(Token = "0x600028B")]
					[Cpp2IlInjected.Address(RVA = "0xA5B2A00", Offset = "0xA5B1400", VA = "0x18A5B2A00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000205")]
				public static Guid NDEOVQUJKFL
				{
					[Cpp2IlInjected.Token(Token = "0x600028C")]
					[Cpp2IlInjected.Address(RVA = "0xA5AC900", Offset = "0xA5AB300", VA = "0x18A5AC900")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000206")]
				public static Guid ZUYXIMBPOHB
				{
					[Cpp2IlInjected.Token(Token = "0x600028D")]
					[Cpp2IlInjected.Address(RVA = "0xA5A5080", Offset = "0xA5A3A80", VA = "0x18A5A5080")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000207")]
				public static Guid OUZXLBVIBCM
				{
					[Cpp2IlInjected.Token(Token = "0x600028E")]
					[Cpp2IlInjected.Address(RVA = "0xA5AC600", Offset = "0xA5AB000", VA = "0x18A5AC600")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000208")]
				public static Guid QVDLTVXOEFS
				{
					[Cpp2IlInjected.Token(Token = "0x600028F")]
					[Cpp2IlInjected.Address(RVA = "0xA5B2280", Offset = "0xA5B0C80", VA = "0x18A5B2280")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000209")]
				public static Guid QVTGLQFGGNT
				{
					[Cpp2IlInjected.Token(Token = "0x6000290")]
					[Cpp2IlInjected.Address(RVA = "0xA5B2300", Offset = "0xA5B0D00", VA = "0x18A5B2300")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700020A")]
				public static Guid FJSKMVWDYEW
				{
					[Cpp2IlInjected.Token(Token = "0x6000291")]
					[Cpp2IlInjected.Address(RVA = "0xA5B0D80", Offset = "0xA5AF780", VA = "0x18A5B0D80")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700020B")]
				public static Guid ZAGROFUAPCH
				{
					[Cpp2IlInjected.Token(Token = "0x6000292")]
					[Cpp2IlInjected.Address(RVA = "0xA5A4B00", Offset = "0xA5A3500", VA = "0x18A5A4B00")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700020C")]
				public static Guid BPZBWTEUUKV
				{
					[Cpp2IlInjected.Token(Token = "0x6000293")]
					[Cpp2IlInjected.Address(RVA = "0xA5B0800", Offset = "0xA5AF200", VA = "0x18A5B0800")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700020D")]
				public static Guid OEEGKDTNTXD
				{
					[Cpp2IlInjected.Token(Token = "0x6000294")]
					[Cpp2IlInjected.Address(RVA = "0xA5AE380", Offset = "0xA5ACD80", VA = "0x18A5AE380")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700020E")]
				public static Guid NJPOIBLVHUW
				{
					[Cpp2IlInjected.Token(Token = "0x6000295")]
					[Cpp2IlInjected.Address(RVA = "0xA5A4680", Offset = "0xA5A3080", VA = "0x18A5A4680")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x1700020F")]
				public static Guid DTFPOEGLZQZ
				{
					[Cpp2IlInjected.Token(Token = "0x6000296")]
					[Cpp2IlInjected.Address(RVA = "0xA5B3780", Offset = "0xA5B2180", VA = "0x18A5B3780")]
					get
					{
						return default(Guid);
					}
				}

				[Cpp2IlInjected.Token(Token = "0x17000210")]
				public static Guid HCQOGOIHSDO
				{
					[Cpp2IlInjected.Token(Token = "0x6000297")]
					[Cpp2IlInjected.Address(RVA = "0xA5B1F00", Offset = "0xA5B0900", VA = "0x18A5B1F00")]
					get
					{
						return default(Guid);
					}
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0xA5A3D80", Offset = "0xA5A2780", VA = "0x18A5A3D80")]
			public static void Run(PersistedRoomData data)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000087")]
			[Cpp2IlInjected.Address(RVA = "0xA594240", Offset = "0xA592C40", VA = "0x18A594240")]
			private static IReadOnlyDictionary<LegacyStableSpawnableToolType, Guid> DGSNMMWVIWA()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000043")]
		public static class NWVIJLEKDJK
		{
			[Cpp2IlInjected.Token(Token = "0x6000298")]
			[Cpp2IlInjected.Address(RVA = "0xA593E00", Offset = "0xA592800", VA = "0x18A593E00")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000044")]
		public static class TYUEEKCWLVN
		{
			[Cpp2IlInjected.Token(Token = "0x6000299")]
			[Cpp2IlInjected.Address(RVA = "0xA5B72B0", Offset = "0xA5B5CB0", VA = "0x18A5B72B0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000045")]
		public static class AZGCFVRBSCN
		{
			[Cpp2IlInjected.Token(Token = "0x600029A")]
			[Cpp2IlInjected.Address(RVA = "0xA5908F0", Offset = "0xA58F2F0", VA = "0x18A5908F0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000046")]
		public static class DDRDXXZIDNE
		{
			[Cpp2IlInjected.Token(Token = "0x4000246")]
			private static readonly Dictionary<Guid, float> ZRWMGEOVNFQ;

			[Cpp2IlInjected.Token(Token = "0x4000247")]
			private static readonly Dictionary<Guid, float> IMPXLNNNISP;

			[Cpp2IlInjected.Token(Token = "0x4000248")]
			private static readonly Dictionary<Guid, bool> PVMUCWCIDLO;

			[Cpp2IlInjected.Token(Token = "0x600029B")]
			[Cpp2IlInjected.Address(RVA = "0xA590B20", Offset = "0xA58F520", VA = "0x18A590B20")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000047")]
		public static class DDWKVETFMYN
		{
			[Cpp2IlInjected.Token(Token = "0x4000249")]
			private static readonly Dictionary<Guid, float> YUMBBCFBDCD;

			[Cpp2IlInjected.Token(Token = "0x400024A")]
			private static readonly Dictionary<Guid, float> JWIMDWGLJSW;

			[Cpp2IlInjected.Token(Token = "0x600029D")]
			[Cpp2IlInjected.Address(RVA = "0xA5B77F0", Offset = "0xA5B61F0", VA = "0x18A5B77F0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000048")]
		public static class UYADLPXCXWL
		{
			[Cpp2IlInjected.Token(Token = "0x600029F")]
			[Cpp2IlInjected.Address(RVA = "0xA5BFFD0", Offset = "0xA5BE9D0", VA = "0x18A5BFFD0")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000049")]
		public static class KDCTNBSAOPL
		{
			[Cpp2IlInjected.Token(Token = "0x400024B")]
			private static readonly Dictionary<Guid, int> GLCHPELMOHX;

			[Cpp2IlInjected.Token(Token = "0x400024C")]
			private static readonly Dictionary<Guid, bool> QCWNINOYNTX;

			[Cpp2IlInjected.Token(Token = "0x400024D")]
			private static readonly Dictionary<Guid, bool> DKHDXAWHLTA;

			[Cpp2IlInjected.Token(Token = "0x400024E")]
			private static readonly Dictionary<Guid, int> SNFWHMRASEK;

			[Cpp2IlInjected.Token(Token = "0x400024F")]
			private static readonly Dictionary<Guid, bool> BXLPQWXPESZ;

			[Cpp2IlInjected.Token(Token = "0x60002A0")]
			[Cpp2IlInjected.Address(RVA = "0xA5BA750", Offset = "0xA5B9150", VA = "0x18A5BA750")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200004A")]
		public static class KCSFSOEFVST
		{
			[Cpp2IlInjected.Token(Token = "0x60002A2")]
			[Cpp2IlInjected.Address(RVA = "0xA5BA590", Offset = "0xA5B8F90", VA = "0x18A5BA590")]
			public static void Run(PersistedRoomData data)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private static Versioner<EDIRCJTODTF, PersistedRoomData, PersistedRoomVersion> IZQDRXDGXEK;

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private static readonly Dictionary<Guid, int> XQQDMZQJLZT;

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private static readonly Guid UBSGRHQIFNV;

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private static readonly Guid JWWEOSZYXIN;

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private static readonly float WHMCORLXNSN;

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0xA58E930", Offset = "0xA58D330", VA = "0x18A58E930")]
		public static PersistedRoomData BSQEAIOGQJM(long a = 0L, [Optional] Timestamp b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xA58EA50", Offset = "0xA58D450", VA = "0x18A58EA50")]
		public static Result<ParseResult<PersistedRoomData>, XZBQMYIZLTP> ISNISPLULJW(EDIRCJTODTF a, byte[] b)
		{
			return default(Result<ParseResult<PersistedRoomData>, XZBQMYIZLTP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0xA58EB80", Offset = "0xA58D580", VA = "0x18A58EB80")]
		public static Result<ParseResult<PersistedRoomData>, XZBQMYIZLTP> ISNISPLULJW(EDIRCJTODTF a, ReadOnlySequence<byte> b)
		{
			return default(Result<ParseResult<PersistedRoomData>, XZBQMYIZLTP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xA58E5F0", Offset = "0xA58CFF0", VA = "0x18A58E5F0")]
		public static Result<None, XZBQMYIZLTP> ACMCPWSDJUZ(EDIRCJTODTF a, PersistedRoomData b)
		{
			return default(Result<None, XZBQMYIZLTP>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0xA58EE60", Offset = "0xA58D860", VA = "0x18A58EE60")]
		public static Guid OKRBSLFMEDY(OSFDDQIVFJF a)
		{
			return default(Guid);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public static class SHIFPGVQUBY
	{
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		public interface EDIRCJTODTF : DZQZMCFTDKX<MFIDGFMFPEG, PlayerSaveVersion>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x200004D")]
		public sealed class TOSGPLXPKRG : EDIRCJTODTF, DZQZMCFTDKX<MFIDGFMFPEG, PlayerSaveVersion>
		{
			[Cpp2IlInjected.Token(Token = "0x4000251")]
			public static TOSGPLXPKRG UIOXUQVVXGJ;

			[Cpp2IlInjected.Token(Token = "0x60002BE")]
			[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160", Slot = "4")]
			public PlayerSaveVersion TZHKUUOLFOF()
			{
				return default(PlayerSaveVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x60002BF")]
			[Cpp2IlInjected.Address(RVA = "0xD7C920", Offset = "0xD7B320", VA = "0x180D7C920", Slot = "5")]
			public PlayerSaveVersion QKDXREEQPMH()
			{
				return default(PlayerSaveVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C0")]
			[Cpp2IlInjected.Address(RVA = "0x1B11150", Offset = "0x1B0FB50", VA = "0x181B11150", Slot = "6")]
			public PlayerSaveVersion Increment(PlayerSaveVersion version)
			{
				return default(PlayerSaveVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C1")]
			[Cpp2IlInjected.Address(RVA = "0x2F46980", Offset = "0x2F45380", VA = "0x182F46980", Slot = "7")]
			public bool DNBDBASICLG(PlayerSaveVersion a, PlayerSaveVersion b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002C2")]
			[Cpp2IlInjected.Address(RVA = "0xA5BFDC0", Offset = "0xA5BE7C0", VA = "0x18A5BFDC0", Slot = "8")]
			public string ToString(PlayerSaveVersion version)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002C3")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public TOSGPLXPKRG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000250")]
		private static Versioner<EDIRCJTODTF, MFIDGFMFPEG, PlayerSaveVersion> IZQDRXDGXEK;

		[Cpp2IlInjected.Token(Token = "0x60002A3")]
		[Cpp2IlInjected.Address(RVA = "0xA5BEDB0", Offset = "0xA5BD7B0", VA = "0x18A5BEDB0")]
		public static MFIDGFMFPEG? QWDBWNOWVDG([Optional] COCJLBZVDNW? a, [Optional] AZZXMELULNW? b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002A4")]
		[Cpp2IlInjected.Address(RVA = "0xA5BE350", Offset = "0xA5BCD50", VA = "0x18A5BE350")]
		public static Result<ParseResult<MFIDGFMFPEG>, XZBQMYIZLTP> ISNISPLULJW(EDIRCJTODTF a, byte[]? bytes)
		{
			return default(Result<ParseResult<MFIDGFMFPEG>, XZBQMYIZLTP>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A5")]
		[Cpp2IlInjected.Address(RVA = "0xA5BE480", Offset = "0xA5BCE80", VA = "0x18A5BE480")]
		public static Result<ParseResult<MFIDGFMFPEG>, XZBQMYIZLTP> ISNISPLULJW(EDIRCJTODTF deps, ReadOnlySequence<byte> a)
		{
			return default(Result<ParseResult<MFIDGFMFPEG>, XZBQMYIZLTP>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A6")]
		[Cpp2IlInjected.Address(RVA = "0xA5BE010", Offset = "0xA5BCA10", VA = "0x18A5BE010")]
		public static Result<None, XZBQMYIZLTP> ACMCPWSDJUZ(EDIRCJTODTF a, MFIDGFMFPEG b)
		{
			return default(Result<None, XZBQMYIZLTP>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002A7")]
		[Cpp2IlInjected.Address(RVA = "0xA5BEEA0", Offset = "0xA5BD8A0", VA = "0x18A5BEEA0")]
		public static void UZQGPSAHVJF(MFIDGFMFPEG a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A8")]
		[Cpp2IlInjected.Address(RVA = "0xA5BF1A0", Offset = "0xA5BDBA0", VA = "0x18A5BF1A0")]
		public static void UZVNMYUFEUO(MFIDGFMFPEG a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002A9")]
		[Cpp2IlInjected.Address(RVA = "0xA5BF3E0", Offset = "0xA5BDDE0", VA = "0x18A5BF3E0")]
		public static void VAAUKFOCOFX(MFIDGFMFPEG a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AA")]
		[Cpp2IlInjected.Address(RVA = "0xA5BF880", Offset = "0xA5BE280", VA = "0x18A5BF880")]
		public static void VAGBHMHZXRG(MFIDGFMFPEG a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AB")]
		[Cpp2IlInjected.Address(RVA = "0xA5BF9B0", Offset = "0xA5BE3B0", VA = "0x18A5BF9B0")]
		public static void VALIETBXHCP(MFIDGFMFPEG a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002AC")]
		[Cpp2IlInjected.Address(RVA = "0xA5BE900", Offset = "0xA5BD300", VA = "0x18A5BE900")]
		private static AZZXMELULNW KLLHBUOXCJY()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AD")]
		[Cpp2IlInjected.Address(RVA = "0xA5BE9E0", Offset = "0xA5BD3E0", VA = "0x18A5BE9E0")]
		private static AZZXMELULNW KLQNZBIULVH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002AF")]
		[Cpp2IlInjected.Address(RVA = "0xA5BFAB0", Offset = "0xA5BE4B0", VA = "0x18A5BFAB0")]
		[CompilerGenerated]
		internal static bool YGEGTZWIVRH(ByteString a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B0")]
		[Cpp2IlInjected.Address(RVA = "0xA5BFA40", Offset = "0xA5BE440", VA = "0x18A5BFA40")]
		[CompilerGenerated]
		internal static MFITZWJKJNB XMSODMTQCQH(bool a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B1")]
		[Cpp2IlInjected.Address(RVA = "0xA5BE220", Offset = "0xA5BCC20", VA = "0x18A5BE220")]
		[CompilerGenerated]
		internal static float BHSMSTAWGQX(ByteString a)
		{
			return default(float);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B2")]
		[Cpp2IlInjected.Address(RVA = "0xA5BECA0", Offset = "0xA5BD6A0", VA = "0x18A5BECA0")]
		[CompilerGenerated]
		internal static MFITZWJKJNB OUKUUIQKHJN(float a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B3")]
		[Cpp2IlInjected.Address(RVA = "0xA5BE320", Offset = "0xA5BCD20", VA = "0x18A5BE320")]
		[CompilerGenerated]
		internal static int HJPIAZCRHNI(ByteString a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B4")]
		[Cpp2IlInjected.Address(RVA = "0xA5BEC30", Offset = "0xA5BD630", VA = "0x18A5BEC30")]
		[CompilerGenerated]
		internal static MFITZWJKJNB NNSVBGWBFMW(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B5")]
		[Cpp2IlInjected.Address(RVA = "0xA5BE250", Offset = "0xA5BCC50", VA = "0x18A5BE250")]
		[CompilerGenerated]
		internal static CircuitsQuat EFCHSHATOOT(ByteString a)
		{
			return default(CircuitsQuat);
		}

		[Cpp2IlInjected.Token(Token = "0x60002B6")]
		[Cpp2IlInjected.Address(RVA = "0xA5BEB40", Offset = "0xA5BD540", VA = "0x18A5BEB40")]
		[CompilerGenerated]
		internal static MFITZWJKJNB MABWSIIGROV(CircuitsQuat a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B7")]
		[Cpp2IlInjected.Address(RVA = "0xA5BFA20", Offset = "0xA5BE420", VA = "0x18A5BFA20")]
		[CompilerGenerated]
		internal static string WPFRLFLGZIY(ByteString a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B8")]
		[Cpp2IlInjected.Address(RVA = "0xA5BEBC0", Offset = "0xA5BD5C0", VA = "0x18A5BEBC0")]
		[CompilerGenerated]
		internal static MFITZWJKJNB NIMDHMWAZWG(string a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002B9")]
		[Cpp2IlInjected.Address(RVA = "0xA5BE140", Offset = "0xA5BCB40", VA = "0x18A5BE140")]
		[CompilerGenerated]
		internal static CircuitsVec3 ASVQYVZJGNC(ByteString a)
		{
			return default(CircuitsVec3);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BA")]
		[Cpp2IlInjected.Address(RVA = "0xA5BEAC0", Offset = "0xA5BD4C0", VA = "0x18A5BEAC0")]
		[CompilerGenerated]
		internal static MFITZWJKJNB LUBSGNDLVEG(CircuitsVec3 a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BB")]
		[Cpp2IlInjected.Address(RVA = "0xA5BFAE0", Offset = "0xA5BE4E0", VA = "0x18A5BFAE0")]
		[CompilerGenerated]
		internal static int ZMDYOBAYNLZ(ByteString a)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60002BC")]
		[Cpp2IlInjected.Address(RVA = "0xA5BED10", Offset = "0xA5BD710", VA = "0x18A5BED10")]
		[CompilerGenerated]
		internal static MFITZWJKJNB QGTFOIENLHP(int a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002BD")]
		[Cpp2IlInjected.Address(RVA = "0x3F1A390", Offset = "0x3F18D90", VA = "0x183F1A390")]
		[CompilerGenerated]
		internal static void WZLXTYLGGDX<a>(RepeatedField<LJCIVZDHHJW> a, Func<ByteString, a> deserialize, Func<a, MFITZWJKJNB> serialize) where a : notnull
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public static class DVOPQKSNDTG
	{
		[Cpp2IlInjected.Token(Token = "0x60002C5")]
		[Cpp2IlInjected.Address(RVA = "0xA5B8D60", Offset = "0xA5B7760", VA = "0x18A5B8D60")]
		public static RUZITZAWBII IFFCZVAVANI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002C6")]
		[Cpp2IlInjected.Address(RVA = "0xA5B9100", Offset = "0xA5B7B00", VA = "0x18A5B9100")]
		public static Result<ParseResult<RUZITZAWBII>, XZBQMYIZLTP> ISNISPLULJW(YRAYVNZABVG.EDIRCJTODTF a, byte[] b)
		{
			return default(Result<ParseResult<RUZITZAWBII>, XZBQMYIZLTP>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C7")]
		[Cpp2IlInjected.Address(RVA = "0xA5B8DB0", Offset = "0xA5B77B0", VA = "0x18A5B8DB0")]
		public static Result<ParseResult<RUZITZAWBII>, XZBQMYIZLTP> ISNISPLULJW(YRAYVNZABVG.EDIRCJTODTF a, ReadOnlySequence<byte> b)
		{
			return default(Result<ParseResult<RUZITZAWBII>, XZBQMYIZLTP>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002C8")]
		[Cpp2IlInjected.Address(RVA = "0xA5B8C90", Offset = "0xA5B7690", VA = "0x18A5B8C90")]
		public static Result<None, XZBQMYIZLTP> ACMCPWSDJUZ(YRAYVNZABVG.EDIRCJTODTF a, RUZITZAWBII b)
		{
			return default(Result<None, XZBQMYIZLTP>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	public static class QSBDGLNYUAL
	{
		[Cpp2IlInjected.Token(Token = "0x60002C9")]
		[Cpp2IlInjected.Address(RVA = "0xA5BDF90", Offset = "0xA5BC990", VA = "0x18A5BDF90")]
		public static SpawnableTemplateData YHNQAAVHUMR([Optional] CircuitTemplateRootData a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002CA")]
		[Cpp2IlInjected.Address(RVA = "0xA5BD610", Offset = "0xA5BC010", VA = "0x18A5BD610")]
		public static Result<ParseResult<SpawnableTemplateData>, XZBQMYIZLTP> ISNISPLULJW(YRAYVNZABVG.EDIRCJTODTF a, GFTAESJOVKC.EDIRCJTODTF b, byte[] c)
		{
			return default(Result<ParseResult<SpawnableTemplateData>, XZBQMYIZLTP>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CB")]
		[Cpp2IlInjected.Address(RVA = "0xA5BD710", Offset = "0xA5BC110", VA = "0x18A5BD710")]
		public static Result<ParseResult<SpawnableTemplateData>, XZBQMYIZLTP> ISNISPLULJW(YRAYVNZABVG.EDIRCJTODTF a, GFTAESJOVKC.EDIRCJTODTF b, ReadOnlySequence<byte> c)
		{
			return default(Result<ParseResult<SpawnableTemplateData>, XZBQMYIZLTP>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CC")]
		[Cpp2IlInjected.Address(RVA = "0xA5BD3A0", Offset = "0xA5BBDA0", VA = "0x18A5BD3A0")]
		public static Result<None, XZBQMYIZLTP> ACMCPWSDJUZ(YRAYVNZABVG.EDIRCJTODTF a, GFTAESJOVKC.EDIRCJTODTF b, SpawnableTemplateData c)
		{
			return default(Result<None, XZBQMYIZLTP>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CD")]
		[Cpp2IlInjected.Address(RVA = "0xA5BDBD0", Offset = "0xA5BC5D0", VA = "0x18A5BDBD0")]
		private static Result<None, XZBQMYIZLTP> XFIUVYYDMVL(YRAYVNZABVG.EDIRCJTODTF a, SpawnableTemplateData b)
		{
			return default(Result<None, XZBQMYIZLTP>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002CE")]
		[Cpp2IlInjected.Address(RVA = "0xA5BDA30", Offset = "0xA5BC430", VA = "0x18A5BDA30")]
		private static Result<None, XZBQMYIZLTP> RFMOPWHMIVF(GFTAESJOVKC.EDIRCJTODTF a, SpawnableTemplateData b)
		{
			return default(Result<None, XZBQMYIZLTP>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000050")]
	public static class GFTAESJOVKC
	{
		[Cpp2IlInjected.Token(Token = "0x2000051")]
		public interface EDIRCJTODTF : DZQZMCFTDKX<SuperRoomData, SuperRoomVersion>
		{
		}

		[Cpp2IlInjected.Token(Token = "0x2000052")]
		public sealed class TOSGPLXPKRG : EDIRCJTODTF, DZQZMCFTDKX<SuperRoomData, SuperRoomVersion>
		{
			[Cpp2IlInjected.Token(Token = "0x4000253")]
			public static TOSGPLXPKRG UIOXUQVVXGJ;

			[Cpp2IlInjected.Token(Token = "0x60002DB")]
			[Cpp2IlInjected.Address(RVA = "0xD11160", Offset = "0xD0FB60", VA = "0x180D11160", Slot = "4")]
			public SuperRoomVersion TZHKUUOLFOF()
			{
				return default(SuperRoomVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x60002DC")]
			[Cpp2IlInjected.Address(RVA = "0xD80A40", Offset = "0xD7F440", VA = "0x180D80A40", Slot = "5")]
			public SuperRoomVersion QKDXREEQPMH()
			{
				return default(SuperRoomVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x60002DD")]
			[Cpp2IlInjected.Address(RVA = "0x1B11150", Offset = "0x1B0FB50", VA = "0x181B11150", Slot = "6")]
			public SuperRoomVersion Increment(SuperRoomVersion version)
			{
				return default(SuperRoomVersion);
			}

			[Cpp2IlInjected.Token(Token = "0x60002DE")]
			[Cpp2IlInjected.Address(RVA = "0x2F46980", Offset = "0x2F45380", VA = "0x182F46980", Slot = "7")]
			public bool DNBDBASICLG(SuperRoomVersion a, SuperRoomVersion b)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60002DF")]
			[Cpp2IlInjected.Address(RVA = "0xA5BFD70", Offset = "0xA5BE770", VA = "0x18A5BFD70", Slot = "8")]
			public string ToString(SuperRoomVersion version)
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60002E0")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public TOSGPLXPKRG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x4000252")]
		private static Versioner<EDIRCJTODTF, SuperRoomData, SuperRoomVersion> IZQDRXDGXEK;

		[Cpp2IlInjected.Token(Token = "0x60002CF")]
		[Cpp2IlInjected.Address(RVA = "0xA5BA290", Offset = "0xA5B8C90", VA = "0x18A5BA290")]
		public static SuperRoomData XFMAFYGWJBO([Optional] CBYLFGRUCMC a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D0")]
		[Cpp2IlInjected.Address(RVA = "0xA5B96F0", Offset = "0xA5B80F0", VA = "0x18A5B96F0")]
		public static Result<ParseResult<SuperRoomData>, XZBQMYIZLTP> ISNISPLULJW(EDIRCJTODTF a, byte[] b)
		{
			return default(Result<ParseResult<SuperRoomData>, XZBQMYIZLTP>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D1")]
		[Cpp2IlInjected.Address(RVA = "0xA5B9820", Offset = "0xA5B8220", VA = "0x18A5B9820")]
		public static Result<ParseResult<SuperRoomData>, XZBQMYIZLTP> ISNISPLULJW(EDIRCJTODTF a, ReadOnlySequence<byte> b)
		{
			return default(Result<ParseResult<SuperRoomData>, XZBQMYIZLTP>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D2")]
		[Cpp2IlInjected.Address(RVA = "0xA5B92A0", Offset = "0xA5B7CA0", VA = "0x18A5B92A0")]
		public static Result<None, XZBQMYIZLTP> ACMCPWSDJUZ(EDIRCJTODTF a, SuperRoomData b)
		{
			return default(Result<None, XZBQMYIZLTP>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002D3")]
		[Cpp2IlInjected.Address(RVA = "0xA5B9CB0", Offset = "0xA5B86B0", VA = "0x18A5B9CB0")]
		private static void UZQGPSAHVJF(SuperRoomData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D4")]
		[Cpp2IlInjected.Address(RVA = "0xA5B9E70", Offset = "0xA5B8870", VA = "0x18A5B9E70")]
		private static void UZVNMYUFEUO(SuperRoomData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D5")]
		[Cpp2IlInjected.Address(RVA = "0xA5B9F70", Offset = "0xA5B8970", VA = "0x18A5B9F70")]
		private static void VAAUKFOCOFX(SuperRoomData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D6")]
		[Cpp2IlInjected.Address(RVA = "0xA5BA000", Offset = "0xA5B8A00", VA = "0x18A5BA000")]
		private static void VAGBHMHZXRG(SuperRoomData a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002D7")]
		[Cpp2IlInjected.Address(RVA = "0xA5B93D0", Offset = "0xA5B7DD0", VA = "0x18A5B93D0")]
		public static DataTableData FZTJCUPSEQX(params int[] levelValues)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002D8")]
		[Cpp2IlInjected.Address(RVA = "0xA5BA080", Offset = "0xA5B8A80", VA = "0x18A5BA080")]
		public static ProgressionManagerData VJVZRISGZUY(params int[] levelValues)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002DA")]
		[Cpp2IlInjected.Address(RVA = "0xA5B9AF0", Offset = "0xA5B84F0", VA = "0x18A5B9AF0")]
		[CompilerGenerated]
		internal static void LQBSFTHTDPE(RepeatedField<QRNDYKJGGLE> a, CloudDataLedgerType b)
		{
		}
	}
}
namespace RecRoom.Versioning.Framework
{
	[Cpp2IlInjected.Token(Token = "0x2000054")]
	public sealed class JDXLEZCHMMS : SZGCLBZVMVH
	{
		[Cpp2IlInjected.Token(Token = "0x60002E5")]
		[Cpp2IlInjected.Address(RVA = "0xA5BA560", Offset = "0xA5B8F60", VA = "0x18A5BA560", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60002E6")]
		[Cpp2IlInjected.Address(RVA = "0x2BDF940", Offset = "0x2BDE340", VA = "0x182BDF940")]
		public JDXLEZCHMMS()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public interface DZQZMCFTDKX<a, b>
	{
		[Cpp2IlInjected.Token(Token = "0x60002E7")]
		[Cpp2IlInjected.Address(Slot = "0")]
		b TZHKUUOLFOF();

		[Cpp2IlInjected.Token(Token = "0x60002E8")]
		[Cpp2IlInjected.Address(Slot = "1")]
		b QKDXREEQPMH();

		[Cpp2IlInjected.Token(Token = "0x60002E9")]
		[Cpp2IlInjected.Address(Slot = "2")]
		b Increment(b version);

		[Cpp2IlInjected.Token(Token = "0x60002EA")]
		[Cpp2IlInjected.Address(Slot = "3")]
		bool DNBDBASICLG(b a, b b);

		[Cpp2IlInjected.Token(Token = "0x60002EB")]
		[Cpp2IlInjected.Address(Slot = "4")]
		string ToString(b version);
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public sealed class EVHVMFUKZQK : SZGCLBZVMVH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000256")]
		private string DFHRGYDAQSF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000257")]
		private string TRQXXCMHWTL;

		[Cpp2IlInjected.Token(Token = "0x60002EC")]
		[Cpp2IlInjected.Address(RVA = "0xA5B9250", Offset = "0xA5B7C50", VA = "0x18A5B9250")]
		public EVHVMFUKZQK(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002ED")]
		[Cpp2IlInjected.Address(RVA = "0xA5B91F0", Offset = "0xA5B7BF0", VA = "0x18A5B91F0", Slot = "7")]
		public override string Display()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public readonly struct ParseResult<T>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000258")]
		public readonly T Value;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000259")]
		public readonly bool IsNew;

		[Cpp2IlInjected.Token(Token = "0x60002EE")]
		[Cpp2IlInjected.Address(RVA = "0x73DC4B0", Offset = "0x73DAEB0", VA = "0x1873DC4B0")]
		internal ParseResult([In] T value, bool isNew)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public static class DXTUOPDBHFK
	{
		[Cpp2IlInjected.Token(Token = "0x60002EF")]
		[Cpp2IlInjected.Address(RVA = "0x39111E0", Offset = "0x390FBE0", VA = "0x1839111E0")]
		public static ParseResult<T> New<T>([In] T value, bool isNew)
		{
			return default(ParseResult<T>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public sealed class WSMHBZUYOYN : SZGCLBZVMVH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400025A")]
		private string DFHRGYDAQSF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400025B")]
		private string TRQXXCMHWTL;

		[Cpp2IlInjected.Token(Token = "0x60002F0")]
		[Cpp2IlInjected.Address(RVA = "0xA5B9250", Offset = "0xA5B7C50", VA = "0x18A5B9250")]
		public WSMHBZUYOYN(string a, string b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F1")]
		[Cpp2IlInjected.Address(RVA = "0xA5C0370", Offset = "0xA5BED70", VA = "0x18A5C0370", Slot = "7")]
		public override string Display()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public static class Util
	{
		[Cpp2IlInjected.Token(Token = "0x60002F2")]
		[Cpp2IlInjected.Address(RVA = "0xA5C0190", Offset = "0xA5BEB90", VA = "0x18A5C0190")]
		public static Guid? BNVPCZVONJT(FKWMEATAMCU a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public readonly struct Versioner<TDeps, TData, TVersion> where TDeps : DZQZMCFTDKX<TData, TVersion>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025C")]
		private readonly IReadOnlyDictionary<TVersion, VersioningPhaseDelegate<TDeps, TData>> _versioningPhases;

		[Cpp2IlInjected.Token(Token = "0x60002F3")]
		[Cpp2IlInjected.Address(RVA = "0xEF9580", Offset = "0xEF7F80", VA = "0x180EF9580")]
		internal Versioner(IReadOnlyDictionary<TVersion, VersioningPhaseDelegate<TDeps, TData>> versioningPhases)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F4")]
		[Cpp2IlInjected.Address(RVA = "0x851ADE0", Offset = "0x85197E0", VA = "0x18851ADE0")]
		public Result<TVersion, XZBQMYIZLTP> ACMCPWSDJUZ(TDeps a, TData b, TVersion c)
		{
			return default(Result<TVersion, XZBQMYIZLTP>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F5")]
		[Cpp2IlInjected.Address(RVA = "0x851CDE0", Offset = "0x851B7E0", VA = "0x18851CDE0")]
		public static VersionerFactory<TDeps, TData, TVersion> JPMHDBJTTOT()
		{
			return default(VersionerFactory<TDeps, TData, TVersion>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public readonly struct VersionerFactory<TDeps, TData, TVersion>
	{
		[Cpp2IlInjected.Token(Token = "0x200005D")]
		[CompilerGenerated]
		private sealed class KMORFLEWRJL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400025E")]
			public VersioningPhaseVoidDelegate<TDeps, TData> LEUZJOTIZUZ;

			[Cpp2IlInjected.Token(Token = "0x60002FA")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public KMORFLEWRJL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FB")]
			[Cpp2IlInjected.Address(RVA = "0x67E34D0", Offset = "0x67E1ED0", VA = "0x1867E34D0")]
			internal Result<None, XZBQMYIZLTP> YFJCJJLKGZD(TDeps a, TData b)
			{
				return default(Result<None, XZBQMYIZLTP>);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200005E")]
		[CompilerGenerated]
		private sealed class JJCJYPIOSDN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400025F")]
			public VersioningPhaseVoidDelegate<TData> LEUZJOTIZUZ;

			[Cpp2IlInjected.Token(Token = "0x60002FC")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public JJCJYPIOSDN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60002FD")]
			[Cpp2IlInjected.Address(RVA = "0x66D7630", Offset = "0x66D6030", VA = "0x1866D7630")]
			internal Result<None, XZBQMYIZLTP> YFJCJJLKGZD(TDeps a, TData b)
			{
				return default(Result<None, XZBQMYIZLTP>);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400025D")]
		internal readonly Dictionary<TVersion, VersioningPhaseDelegate<TDeps, TData>> _versioningPhases;

		[Cpp2IlInjected.Token(Token = "0x60002F6")]
		[Cpp2IlInjected.Address(RVA = "0xEF9580", Offset = "0xEF7F80", VA = "0x180EF9580")]
		internal VersionerFactory(Dictionary<TVersion, VersioningPhaseDelegate<TDeps, TData>> versioningPhases)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60002F7")]
		[Cpp2IlInjected.Address(RVA = "0x851A6F0", Offset = "0x85190F0", VA = "0x18851A6F0")]
		public VersionerFactory<TDeps, TData, TVersion> Add(TVersion version, VersioningPhaseDelegate<TDeps, TData> phase)
		{
			return default(VersionerFactory<TDeps, TData, TVersion>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F8")]
		[Cpp2IlInjected.Address(RVA = "0x851A830", Offset = "0x8519230", VA = "0x18851A830")]
		public VersionerFactory<TDeps, TData, TVersion> Add(TVersion version, VersioningPhaseVoidDelegate<TDeps, TData> phase)
		{
			return default(VersionerFactory<TDeps, TData, TVersion>);
		}

		[Cpp2IlInjected.Token(Token = "0x60002F9")]
		[Cpp2IlInjected.Address(RVA = "0x851A9B0", Offset = "0x85193B0", VA = "0x18851A9B0")]
		public VersionerFactory<TDeps, TData, TVersion> Add(TVersion version, VersioningPhaseVoidDelegate<TData> phase)
		{
			return default(VersionerFactory<TDeps, TData, TVersion>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public static class HISQQZHOGQV
	{
		[Cpp2IlInjected.Token(Token = "0x60002FE")]
		[Cpp2IlInjected.Address(RVA = "0x339F520", Offset = "0x339DF20", VA = "0x18339F520")]
		public static Versioner<TDeps, TData, TVersion> End<TDeps, TData, TVersion>(this VersionerFactory<TDeps, TData, TVersion> self) where TDeps : DZQZMCFTDKX<TData, TVersion>
		{
			return default(Versioner<TDeps, TData, TVersion>);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public sealed class VFWTJPVETDU : SZGCLBZVMVH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000260")]
		public readonly Exception LSDKOPEJIRJ;

		[Cpp2IlInjected.Token(Token = "0x60002FF")]
		[Cpp2IlInjected.Address(RVA = "0x1B647E0", Offset = "0x1B631E0", VA = "0x181B647E0")]
		public VFWTJPVETDU(Exception a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000300")]
		[Cpp2IlInjected.Address(RVA = "0xA5C0340", Offset = "0xA5BED40", VA = "0x18A5C0340", Slot = "7")]
		public override string Display()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000301")]
		[Cpp2IlInjected.Address(RVA = "0xA5C0240", Offset = "0xA5BEC40", VA = "0x18A5C0240", Slot = "8")]
		public override string Debug()
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public abstract class SZGCLBZVMVH : XZBQMYIZLTP
	{
		[Cpp2IlInjected.Token(Token = "0x6000302")]
		[Cpp2IlInjected.Address(RVA = "0x2BDF940", Offset = "0x2BDE340", VA = "0x182BDF940")]
		protected SZGCLBZVMVH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public delegate Result<None, XZBQMYIZLTP> VersioningPhaseDelegate<TDeps, TData>(TDeps deps, TData data);
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public delegate void VersioningPhaseVoidDelegate<TData>(TData data);
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public delegate void VersioningPhaseVoidDelegate<TDeps, TData>(TDeps deps, TData data);
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
