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
	[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0C6A0", Offset = "0xD0B0A0", VA = "0x180D0C6A0", Slot = "13")]
			get
			{
				return default(NSXTVRYRMOK.PhysicsMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x99E6990", Offset = "0x99E5390", VA = "0x1899E6990")]
		public bool IYZGRPTQLHS(FDPQDCZIFNA a)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x99E6670", Offset = "0x99E5070", VA = "0x1899E6670")]
		private static bool HWZOFWAPJUL(FDPQDCZIFNA a, [Out] NSXTVRYRMOK.PhysicsMode b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
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
			[Cpp2IlInjected.Address(RVA = "0xD0C6D0", Offset = "0xD0B0D0", VA = "0x180D0C6D0", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool WSKLVYELOXL
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x99E5330", Offset = "0x99E3D30", VA = "0x1899E5330", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool YQZIMQLLXPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x99E5300", Offset = "0x99E3D00", VA = "0x1899E5300", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public bool GQCIXCIWJFA
		{
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x99E52A0", Offset = "0x99E3CA0", VA = "0x1899E52A0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public bool FEOCBRGXHTK
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x99E52D0", Offset = "0x99E3CD0", VA = "0x1899E52D0", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public bool KUKPDDDNBNT
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x99E5360", Offset = "0x99E3D60", VA = "0x1899E5360", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
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
		[Cpp2IlInjected.Address(RVA = "0x99E5F00", Offset = "0x99E4900", VA = "0x1899E5F00")]
		public NLZFYBNDHMQ(SerializedDataWrapper a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x99E5DE0", Offset = "0x99E47E0", VA = "0x1899E5DE0", Slot = "4")]
		public bool YIWKHOLBVXN(NSXTVRYRMOK a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x99E5C80", Offset = "0x99E4680", VA = "0x1899E5C80", Slot = "5")]
		public bool UGWVCHOKIKO(NSXTVRYRMOK a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x99E5AD0", Offset = "0x99E44D0", VA = "0x1899E5AD0", Slot = "6")]
		public bool PIKPWLXUUUL(ZHCAINHBIGG a, int b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x99E5930", Offset = "0x99E4330", VA = "0x1899E5930")]
		private IReadOnlyList<FDPQDCZIFNA> CZBBRWHJKRA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x99E59A0", Offset = "0x99E43A0", VA = "0x1899E59A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x99E5390", Offset = "0x99E3D90", VA = "0x1899E5390", Slot = "9")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public override NSXTVRYRMOK.PhysicsMode WAXPUCHLXCV
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x99E53F0", Offset = "0x99E3DF0", VA = "0x1899E53F0", Slot = "13")]
			get
			{
				return default(NSXTVRYRMOK.PhysicsMode);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000A")]
		public int MYLJASPCLPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x99E5420", Offset = "0x99E3E20", VA = "0x1899E5420", Slot = "14")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x99E5460", Offset = "0x99E3E60", VA = "0x1899E5460", Slot = "15")]
		public void PNVUVRUKKHH(QGTVAOQWSXY a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
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
			[Cpp2IlInjected.Address(RVA = "0x99E5890", Offset = "0x99E4290", VA = "0x1899E5890", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000D")]
		public bool VLHOYBTCOZY
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x99E58D0", Offset = "0x99E42D0", VA = "0x1899E58D0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700000E")]
		public bool JJOADJERTFC
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x99E5900", Offset = "0x99E4300", VA = "0x1899E5900", Slot = "12")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
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
			[Cpp2IlInjected.Address(RVA = "0x99E5F70", Offset = "0x99E4970", VA = "0x1899E5F70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000010")]
		public bool HXCOTOULEVL
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x99E6580", Offset = "0x99E4F80", VA = "0x1899E6580", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public PrimitiveShapeType ZKCHRVVXIRP
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x2859190", Offset = "0x2857B90", VA = "0x182859190", Slot = "5")]
			get
			{
				return default(PrimitiveShapeType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public ZQPAARDMLME KWJHMOIBSWR
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x99E6520", Offset = "0x99E4F20", VA = "0x1899E6520", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		public float3 IWJEEIVKPOP
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x99E5FD0", Offset = "0x99E49D0", VA = "0x1899E5FD0", Slot = "7")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		public quaternion TYYYGKBREIK
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x99E64A0", Offset = "0x99E4EA0", VA = "0x1899E64A0", Slot = "8")]
			get
			{
				return default(quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		public float3 ZGYOETDZTFY
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x99E6110", Offset = "0x99E4B10", VA = "0x1899E6110", Slot = "9")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		public RenderableMaterial DMNWOMXIVEB
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x32CB890", Offset = "0x32CA290", VA = "0x1832CB890", Slot = "10")]
			get
			{
				return default(RenderableMaterial);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		public RenderableColor SEPYTNPFUCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x135EC70", Offset = "0x135D670", VA = "0x18135EC70", Slot = "11")]
			get
			{
				return default(RenderableColor);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		public float ODHAPYRQBCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x99E6560", Offset = "0x99E4F60", VA = "0x1899E6560", Slot = "12")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public float3 ZVPEPEOEMXO
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x99E60A0", Offset = "0x99E4AA0", VA = "0x1899E60A0", Slot = "13")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public float QKOZPLDHNVO
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x99E6500", Offset = "0x99E4F00", VA = "0x1899E6500", Slot = "14")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public ShapeConfigFlags ADXQLHXVAYV
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x8721AE0", Offset = "0x87204E0", VA = "0x188721AE0", Slot = "15")]
			get
			{
				return default(ShapeConfigFlags);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public int UKTPAZGOJCL
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x99E65A0", Offset = "0x99E4FA0", VA = "0x1899E65A0", Slot = "20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public bool DOLIPISVUYT
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x99E6280", Offset = "0x99E4C80", VA = "0x1899E6280", Slot = "17")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool LNMHYIDAHAY
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x99E6640", Offset = "0x99E5040", VA = "0x1899E6640", Slot = "16")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float JMWLPTNOLUF
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x99E6040", Offset = "0x99E4A40", VA = "0x1899E6040", Slot = "19")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool IPPOTLWSTJO
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x99E5F50", Offset = "0x99E4950", VA = "0x1899E5F50", Slot = "18")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public int VMRQLFAKLND
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x99E65E0", Offset = "0x99E4FE0", VA = "0x1899E65E0", Slot = "21")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x99E62B0", Offset = "0x99E4CB0", VA = "0x1899E62B0", Slot = "22")]
		public void JHVVLYKJRKG(FLWDFDMXJCO a, int b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
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
			[Cpp2IlInjected.Address(RVA = "0x73CD720", Offset = "0x73CC120", VA = "0x1873CD720")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public float3 OYWTYXOICNS
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x99E5590", Offset = "0x99E3F90", VA = "0x1899E5590", Slot = "4")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float3 AQJHARNXCDR
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x99E5860", Offset = "0x99E4260", VA = "0x1899E5860", Slot = "5")]
			get
			{
				return default(float3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x99E5600", Offset = "0x99E4000", VA = "0x1899E5600", Slot = "6")]
		public quaternion XVHCUHLEFFP(float3 a)
		{
			return default(quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0xD10590", Offset = "0xD0EF90", VA = "0x180D10590")]
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
