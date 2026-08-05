using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Google.Protobuf;
using Google.Protobuf.Collections;
using RecRoom.DataLayer;
using RecRoom.Protobuf;
using Unity.Mathematics;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class TMRYTQGXOHE
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	private struct MonoScriptData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public byte[] FilePathsData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public byte[] TypesData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public int TotalTypes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public int TotalFiles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public bool IsEditorOnly;
	}

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
	public TMRYTQGXOHE()
	{
	}
}
namespace RecRoom.ObjectModel
{
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class RHMBIQIYBBO : NJTCHSNGATG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		private NSXTVRYRMOK.PhysicsMode RVKWWCHTLFU;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private static readonly ByteString QASLLCFAYNW;

		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private static readonly ByteString LIOYPWDAXGH;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override NSXTVRYRMOK.PhysicsMode WAXPUCHLXCV
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xCD36A0", Offset = "0xCD20A0", VA = "0x180CD36A0", Slot = "13")]
			get
			{
				return default(NSXTVRYRMOK.PhysicsMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x9881BF0", Offset = "0x98805F0", VA = "0x189881BF0")]
		public bool IYZGRPTQLHS(FDPQDCZIFNA a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x98818D0", Offset = "0x98802D0", VA = "0x1898818D0")]
		private static bool HWZOFWAPJUL(FDPQDCZIFNA a, [Out] NSXTVRYRMOK.PhysicsMode b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public RHMBIQIYBBO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class JFYABYQAQWL : WXCLJFLLUBV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		protected FDPQDCZIFNA DVMGTNZVITG;

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public virtual FDPQDCZIFNA JYJRJZUXYDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xCD36D0", Offset = "0xCD20D0", VA = "0x180CD36D0", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool WSKLVYELOXL
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x9880590", Offset = "0x987EF90", VA = "0x189880590", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool YQZIMQLLXPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x9880560", Offset = "0x987EF60", VA = "0x189880560", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool GQCIXCIWJFA
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x9880500", Offset = "0x987EF00", VA = "0x189880500", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool FEOCBRGXHTK
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x9880530", Offset = "0x987EF30", VA = "0x189880530", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool KUKPDDDNBNT
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x98805C0", Offset = "0x987EFC0", VA = "0x1898805C0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public JFYABYQAQWL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public class NLZFYBNDHMQ : YEGTLVEODZA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private readonly SerializedDataWrapper DVMGTNZVITG;

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x9881160", Offset = "0x987FB60", VA = "0x189881160")]
		public NLZFYBNDHMQ(SerializedDataWrapper a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x9881040", Offset = "0x987FA40", VA = "0x189881040", Slot = "4")]
		public bool YIWKHOLBVXN(NSXTVRYRMOK a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x9880EE0", Offset = "0x987F8E0", VA = "0x189880EE0", Slot = "5")]
		public bool UGWVCHOKIKO(NSXTVRYRMOK a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x9880D30", Offset = "0x987F730", VA = "0x189880D30", Slot = "6")]
		public bool PIKPWLXUUUL(ZHCAINHBIGG a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x9880B90", Offset = "0x987F590", VA = "0x189880B90")]
		private IReadOnlyList<FDPQDCZIFNA> CZBBRWHJKRA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x9880C00", Offset = "0x987F600", VA = "0x189880C00")]
		private bool LVPXFPGBOYK(int a, [Out][NotNullWhen(true)] FDPQDCZIFNA containerData)
		{
			return default(bool);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class KOFKIGVGURL : NJTCHSNGATG, CTLLZSJOIVD, NSXTVRYRMOK, WXCLJFLLUBV
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		private RepeatedField<QFIBYSNQWWF> HVCGPDXHTQK;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public override FDPQDCZIFNA JYJRJZUXYDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x98805F0", Offset = "0x987EFF0", VA = "0x1898805F0", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override NSXTVRYRMOK.PhysicsMode WAXPUCHLXCV
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x9880650", Offset = "0x987F050", VA = "0x189880650", Slot = "13")]
			get
			{
				return default(NSXTVRYRMOK.PhysicsMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int MYLJASPCLPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x9880680", Offset = "0x987F080", VA = "0x189880680", Slot = "14")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x98806C0", Offset = "0x987F0C0", VA = "0x1898806C0", Slot = "15")]
		public void PNVUVRUKKHH(QGTVAOQWSXY a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public KOFKIGVGURL()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class NJTCHSNGATG : JFYABYQAQWL, NSXTVRYRMOK, WXCLJFLLUBV
	{
		[Cpp2IlInjected.Token(Token = "0x1700000B")]
		public abstract NSXTVRYRMOK.PhysicsMode WAXPUCHLXCV
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(Slot = "13")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700000C")]
		public bool OIBRTMINBEF
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x9880AF0", Offset = "0x987F4F0", VA = "0x189880AF0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool VLHOYBTCOZY
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x9880B30", Offset = "0x987F530", VA = "0x189880B30", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool JJOADJERTFC
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x9880B60", Offset = "0x987F560", VA = "0x189880B60", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		protected NJTCHSNGATG()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class PAQARQBWQES : QGTVAOQWSXY, ZQPAARDMLME
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private QFIBYSNQWWF DVMGTNZVITG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		private RepeatedField<HNJSMWUDRMB> VVJZAGDFQNB;

		[Cpp2IlInjected.Token(Token = "0x1700000F")]
		public QFIBYSNQWWF JYJRJZUXYDG
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x98811D0", Offset = "0x987FBD0", VA = "0x1898811D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool HXCOTOULEVL
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x98817E0", Offset = "0x98801E0", VA = "0x1898817E0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public PrimitiveShapeType ZKCHRVVXIRP
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x2836230", Offset = "0x2834C30", VA = "0x182836230", Slot = "5")]
			get
			{
				return default(PrimitiveShapeType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public ZQPAARDMLME KWJHMOIBSWR
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x9881780", Offset = "0x9880180", VA = "0x189881780", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float3 IWJEEIVKPOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x9881230", Offset = "0x987FC30", VA = "0x189881230", Slot = "7")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public quaternion TYYYGKBREIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x9881700", Offset = "0x9880100", VA = "0x189881700", Slot = "8")]
			get
			{
				return default(quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float3 ZGYOETDZTFY
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x9881370", Offset = "0x987FD70", VA = "0x189881370", Slot = "9")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public RenderableMaterial DMNWOMXIVEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x32B8830", Offset = "0x32B7230", VA = "0x1832B8830", Slot = "10")]
			get
			{
				return default(RenderableMaterial);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public RenderableColor SEPYTNPFUCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x12C8A30", Offset = "0x12C7430", VA = "0x1812C8A30", Slot = "11")]
			get
			{
				return default(RenderableColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float ODHAPYRQBCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x98817C0", Offset = "0x98801C0", VA = "0x1898817C0", Slot = "12")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public float3 ZVPEPEOEMXO
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x9881300", Offset = "0x987FD00", VA = "0x189881300", Slot = "13")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float QKOZPLDHNVO
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x9881760", Offset = "0x9880160", VA = "0x189881760", Slot = "14")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ShapeConfigFlags ADXQLHXVAYV
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x859F650", Offset = "0x859E050", VA = "0x18859F650", Slot = "15")]
			get
			{
				return default(ShapeConfigFlags);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int UKTPAZGOJCL
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x9881800", Offset = "0x9880200", VA = "0x189881800", Slot = "20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public bool DOLIPISVUYT
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x98814E0", Offset = "0x987FEE0", VA = "0x1898814E0", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool LNMHYIDAHAY
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x98818A0", Offset = "0x98802A0", VA = "0x1898818A0", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float JMWLPTNOLUF
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x98812A0", Offset = "0x987FCA0", VA = "0x1898812A0", Slot = "19")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool IPPOTLWSTJO
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x98811B0", Offset = "0x987FBB0", VA = "0x1898811B0", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int VMRQLFAKLND
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x9881840", Offset = "0x9880240", VA = "0x189881840", Slot = "21")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x9881510", Offset = "0x987FF10", VA = "0x189881510", Slot = "22")]
		public void JHVVLYKJRKG(FLWDFDMXJCO a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public PAQARQBWQES()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class LCIMXNFSVLY : FLWDFDMXJCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		private (HNJSMWUDRMB curr, HNJSMWUDRMB next, ShapeConfigFlags flags) DVMGTNZVITG;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public (HNJSMWUDRMB curr, HNJSMWUDRMB next, ShapeConfigFlags flags) JYJRJZUXYDG
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x72B5A90", Offset = "0x72B4490", VA = "0x1872B5A90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public float3 OYWTYXOICNS
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x98807F0", Offset = "0x987F1F0", VA = "0x1898807F0", Slot = "4")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float3 AQJHARNXCDR
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x9880AC0", Offset = "0x987F4C0", VA = "0x189880AC0", Slot = "5")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9880860", Offset = "0x987F260", VA = "0x189880860", Slot = "6")]
		public quaternion XVHCUHLEFFP(float3 a)
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public LCIMXNFSVLY()
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
