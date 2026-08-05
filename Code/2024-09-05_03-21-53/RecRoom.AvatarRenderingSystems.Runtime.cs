using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using RecRoom.AssetIds;
using RecRoom.Avatars;
using RecRoom.Avatars.Data.Shared;
using RecRoom.Core.Studio;
using RecRoom.DataLayer.Attributes;
using RecRoom.Logging.Attributes;
using Unity.Collections;
using Unity.Collections.LowLevel.Unsafe;
using Unity.Jobs;
using Unity.Mathematics;
using Unity.Profiling;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Rendering.Universal;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
namespace _LogRegistration.RecRoom_AvatarRenderingSystems_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[RecRoom.Logging.Attributes.Preserve]
	public class LogRegistrationIndex : JOPFPPBONLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x6A407F0", Offset = "0x6A3F1F0", VA = "0x186A407F0", Slot = "4")]
		public override void HEDMFNKAECO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x8AE600", Offset = "0x8AD000", VA = "0x1808AE600")]
		public LogRegistrationIndex()
		{
		}
	}
}
namespace _AssemblyRegistry.RecRoom_AvatarRenderingSystems_Runtime
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[RecRoom.DataLayer.Attributes.Preserve]
	public class _AssemblyIndex : MGJKNLCKGOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6A444D0", Offset = "0x6A42ED0", VA = "0x186A444D0", Slot = "8")]
		public override void KLIFGJHDPHO(DIMDGJNLMOK registry)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x6283490", Offset = "0x6281E90", VA = "0x186283490")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class RecNetCDNAssetReference : AssetReference
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private RecNetCDNKey key;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override object RuntimeKey
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x8869B0", Offset = "0x8853B0", VA = "0x1808869B0", Slot = "6")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public override string AssetGUID
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x6A43C00", Offset = "0x6A42600", VA = "0x186A43C00", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6A43B30", Offset = "0x6A42530", VA = "0x186A43B30", Slot = "17")]
		public override bool RuntimeKeyIsValid()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x6A43BC0", Offset = "0x6A425C0", VA = "0x186A43BC0")]
		public RecNetCDNAssetReference(RecNetCDNKey JODEIIFHAPK)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class RecNetCDNKey
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public string bundleUrl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public string itemPath;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public List<RecNetCDNKey> Dependencies;

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public string UniqueItemIdentifier
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8869A0", Offset = "0x8853A0", VA = "0x1808869A0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000A")]
			[Cpp2IlInjected.Address(RVA = "0x885AF0", Offset = "0x8844F0", VA = "0x180885AF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public string CacheHash
		{
			[Cpp2IlInjected.Token(Token = "0x600000B")]
			[Cpp2IlInjected.Address(RVA = "0x886D60", Offset = "0x885760", VA = "0x180886D60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x886770", Offset = "0x885170", VA = "0x180886770")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6A43C40", Offset = "0x6A42640", VA = "0x186A43C40")]
		public static RecNetCDNKey DJMPFODALIJ(string BOOGHLIGMPC, string KCOHHIMHOBN = "")
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(RVA = "0x6232A80", Offset = "0x6231480", VA = "0x186232A80")]
		public void FAHPNHFNKFA(string CAGEIBNHFCK, string KCGNLENMMHH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6A43D40", Offset = "0x6A42740", VA = "0x186A43D40")]
		public RecNetCDNKey()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
[PLAFBFJHEAK]
public class HDGPBEOLHKF : DJMPODNLHCI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	protected readonly List<Mesh> ADKGGIKDLDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	protected readonly List<byte[]> KJPMAOMACNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	protected readonly List<Matrix4x4> LCFAFCAJBJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	protected readonly List<bool> COFLOCJGDFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	protected readonly List<int> BEJIJJFJEMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400000C")]
	protected readonly List<bool> DAIFFHNKDOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	protected readonly List<int> ONBMIIBMODB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	protected Allocator OLJFMFPICBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	protected PGMCADPPNDC DMKONIJECNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	protected byte CDBLEHPHGDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	protected IList<int> IEHCAAINMEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000012")]
	protected IList<int> MJPMEBANJND;

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x6A33840", Offset = "0x6A32240", VA = "0x186A33840", Slot = "4")]
	public void NLJICFCGPJA(Mesh ANBKEJJPIHH, Matrix4x4 ECNJMMKOLMG, byte[] JDPIOINPAKB, bool DPKFNEJEEGG = false, MJONKEEGKHL.OANEACHHLDN BIHCBJJLGOE = (MJONKEEGKHL.OANEACHHLDN)0, int NAFKDFAKHJG = -1, bool ACOJGBCIENJ = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6A335B0", Offset = "0x6A31FB0", VA = "0x186A335B0", Slot = "5")]
	public void FCIFLCCDLAK(Allocator MDICAPEDFAK, PGMCADPPNDC DPFAONFNIDP, byte GAPNAFGCLPM, [Optional] IList<int> BFIBIGDOGCK, [Optional] IList<int> OGDBGLFFKEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x6A335F0", Offset = "0x6A31FF0", VA = "0x186A335F0")]
	private static void MPLCMJLKBBN(Mesh ANBKEJJPIHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x6A33A50", Offset = "0x6A32450", VA = "0x186A33A50")]
	public HDGPBEOLHKF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
[PLAFBFJHEAK]
public struct OHHBCPEBCCI : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[ReadOnly]
	public HDCHJDKDDIF NGHIPIJCNKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[ReadOnly]
	public int CGHMLJBBANM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public GMOHBHABCJM COOFFOCDAHJ;

	[Cpp2IlInjected.Token(Token = "0x6000014")]
	[Cpp2IlInjected.Address(RVA = "0x6A41380", Offset = "0x6A3FD80", VA = "0x186A41380", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
[NativeContainer]
[PLAFBFJHEAK]
public struct GMOHBHABCJM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public struct NHIGOHHHAGH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		public Vector3 CKJBKCNFIIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		public Vector3 BELBOBCMBGH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		public Vector4 PMGHDGKDGKL;
	}

	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct AIAKECDPFKP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		public float JPEHNNINMHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		public float ONCAONPNJLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		public float KHAPOHMJHCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		public float LGCOHJFLJPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		public byte CJPEHOGBDKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		public byte FONMDBJKCJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		public byte IGKMKBDMOGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		public byte EPIICJJAEAJ;
	}

	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct GDOLABEAHIA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		public half JPEHNNINMHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		public half ONCAONPNJLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		public half KHAPOHMJHCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		public half LGCOHJFLJPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		public byte CJPEHOGBDKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		public byte FONMDBJKCJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		public byte IGKMKBDMOGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		public byte EPIICJJAEAJ;
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct JCMALMFLEDC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public half4 BLBBBKOLGJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public half2 MNOOLFMDIML;
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct NLGHMKLFFHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public half4 BLBBBKOLGJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public half2 MNOOLFMDIML;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public half2 HCHBNILLJLO;
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public struct PPGMDLHBMED
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public half4 BLBBBKOLGJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public half2 MNOOLFMDIML;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public half2 HCHBNILLJLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public half2 FFKFNFFNCGP;
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public struct KOAAGEAAONH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public half4 BLBBBKOLGJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public half2 MNOOLFMDIML;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public half2 HCHBNILLJLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public half2 FFKFNFFNCGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public half2 JOJAOKKGJPP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public struct LBBELELNEDH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public float JPEHNNINMHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public float ONCAONPNJLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public float KHAPOHMJHCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public float LGCOHJFLJPC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public int CJPEHOGBDKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int FONMDBJKCJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public int IGKMKBDMOGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public int EPIICJJAEAJ;
	}

	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct NPONKGIMEGM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		public Color BLBBBKOLGJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		public Vector2 MNOOLFMDIML;
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct NNMCOBOFLHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		public Color BLBBBKOLGJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		public Vector2 MNOOLFMDIML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		public Vector2 HCHBNILLJLO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public struct DBKLGKAKIFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public Color BLBBBKOLGJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public Vector2 MNOOLFMDIML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public Vector2 HCHBNILLJLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public Vector2 FFKFNFFNCGP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct GNKDOMDJMGG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		public Color BLBBBKOLGJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		public Vector2 MNOOLFMDIML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		public Vector2 HCHBNILLJLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public Vector2 FFKFNFFNCGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		public Vector2 JOJAOKKGJPP;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private bool DACKONKHFNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public NativeArray<NHIGOHHHAGH> MHFCHCPKJDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public NativeArray<JCMALMFLEDC> BNAMGAAFPNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public NativeArray<NLGHMKLFFHB> GILAAAKOPIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public NativeArray<PPGMDLHBMED> CDLCMBHHOHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public NativeArray<KOAAGEAAONH> MPBECFMOHNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public NativeArray<GDOLABEAHIA> CMJLOCBKGEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public NativeArray<AIAKECDPFKP> NEJFIIGDGDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public NativeArray<NPONKGIMEGM> JLOJEFMEHGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public NativeArray<NNMCOBOFLHC> KGFMMIAIKDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public NativeArray<DBKLGKAKIFI> PICJKAOOMEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public NativeArray<GNKDOMDJMGG> KEFMHDHJPNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public NativeArray<LBBELELNEDH> DBJDCKKDNHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public NativeArray<int> MMHBJNCDKMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public NativeArray<int> EBJMLEBBLPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	private NativeArray<int> IFPLHKKHHHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	private NativeArray<int> HOLIPDBKLLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public NativeArray<int> GJNPGCANCMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public NativeArray<int> NNIPMCDKJHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public NativeArray<int> BMEHPJDOMEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public NativeArray<BoneWeight> GMCKGCKGAIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private NativeArray<int> APDNBDIKMDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private bool GNBINBECLDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x159")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private bool PMAKKAFMGHO;

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public int FJEDHBOPAJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x6A312D0", Offset = "0x6A2FCD0", VA = "0x186A312D0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6A30A80", Offset = "0x6A2F480", VA = "0x186A30A80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public int OBPLCPKGCOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6A2F050", Offset = "0x6A2DA50", VA = "0x186A2F050")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(RVA = "0x6A312E0", Offset = "0x6A2FCE0", VA = "0x186A312E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public int JIKAIIDAABB
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x6A31380", Offset = "0x6A2FD80", VA = "0x186A31380")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x6A2FB30", Offset = "0x6A2E530", VA = "0x186A2FB30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public int JNHLIFJKJMF
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(RVA = "0x6A2FAC0", Offset = "0x6A2E4C0", VA = "0x186A2FAC0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6A31390", Offset = "0x6A2FD90", VA = "0x186A31390")]
	public GMOHBHABCJM(int JMJOPMPPDPD, int JDFFOCMONDJ, int ACAKDLEEMFC, int JFOMGAJDGLP, Allocator MDICAPEDFAK, int LJJEGPBBKLF, OFPGGHGKMMH INMIHNAKFFK, bool GNBINBECLDL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6A312F0", Offset = "0x6A2FCF0", VA = "0x186A312F0")]
	public void MKNHCBJBOJC(int EBDDHAPIAHH, Vector3 OEHMKJHGMIJ, Vector3 NGLGLPDMMBG, Vector4 LJDCGGEFKLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6A30A90", Offset = "0x6A2F490", VA = "0x186A30A90")]
	public void GLNMENKEEMB(int EBDDHAPIAHH, BoneWeight OAMFOFKGHEB, NativeSlice<byte> JDPIOINPAKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6A2F460", Offset = "0x6A2DE60", VA = "0x186A2F460")]
	public Color CMMBACGHFNM(int EBDDHAPIAHH)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6A2F060", Offset = "0x6A2DA60", VA = "0x186A2F060")]
	public void ADMEGKLOBJO(int EBDDHAPIAHH, Color FOBCKJHLPBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(RVA = "0x6A30EC0", Offset = "0x6A2F8C0", VA = "0x186A30EC0")]
	public void KDALMGELNMK(byte HFBJMLDHHNJ, int EBDDHAPIAHH, Vector2 NNPPPDIINHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000022")]
	[Cpp2IlInjected.Address(RVA = "0x6A2F040", Offset = "0x6A2DA40", VA = "0x186A2F040")]
	public void AAFGJCEPPIK(int EBDDHAPIAHH, int JHHINGACJOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000023")]
	[Cpp2IlInjected.Address(RVA = "0x6A31270", Offset = "0x6A2FC70", VA = "0x186A31270")]
	public bool KOCMJBCNPHP(int HFBJMLDHHNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000024")]
	[Cpp2IlInjected.Address(RVA = "0x6A2F9F0", Offset = "0x6A2E3F0", VA = "0x186A2F9F0")]
	public void EMDBKAICHMA(int ENLEPGJIFEF, int ELDAPMPELBH, int OMBKDMFPMFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000025")]
	[Cpp2IlInjected.Address(RVA = "0x6A2F790", Offset = "0x6A2E190", VA = "0x186A2F790", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000026")]
	[Cpp2IlInjected.Address(RVA = "0x6A2FB40", Offset = "0x6A2E540", VA = "0x186A2FB40")]
	public Mesh GEICFGBFCFK([Optional] string LPPEDCPPANP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
[NativeContainer]
[PLAFBFJHEAK]
[DefaultMember("Item")]
public struct HDCHJDKDDIF : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public Mesh.MeshDataArray OLDEGJBOLPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public NativeArray<int> JKGHHHBIFCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public NativeArray<int> PIOJDNBOFHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public NativeArray<BoneWeight> GMCKGCKGAIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	private NativeArray<Matrix4x4> ALOJODODJNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private NativeArray<int> ELJHIHHLKDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private NativeArray<byte> OGJJMKNBNDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private NativeArray<int> DGLOCEHLPKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private NativeArray<int> MBFCIBNNALC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public NativeArray<sbyte> KJNPPOLAEKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public NativeArray<byte> PHEECDEMMNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public NativeArray<bool> ACOJGBCIENJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public NativeArray<int> NAFKDFAKHJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	private bool GNBINBECLDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private NativeArray<int> JIEPDJLDJBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private bool PMAKKAFMGHO;

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public int JIJKOHILKBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x6A321B0", Offset = "0x6A30BB0", VA = "0x186A321B0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public int CACMJOAFFJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x6A321D0", Offset = "0x6A30BD0", VA = "0x186A321D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public int OPHNDAKFLHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x6A32200", Offset = "0x6A30C00", VA = "0x186A32200")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public int CMANGOKIJOI
	{
		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x6A322D0", Offset = "0x6A30CD0", VA = "0x186A322D0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x6A31DC0", Offset = "0x6A307C0", VA = "0x186A31DC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public int FJEDHBOPAJL
	{
		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6A322E0", Offset = "0x6A30CE0", VA = "0x186A322E0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6A321E0", Offset = "0x6A30BE0", VA = "0x186A321E0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public int ANLDBEKLOOP
	{
		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6A321C0", Offset = "0x6A30BC0", VA = "0x186A321C0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x6A321F0", Offset = "0x6A30BF0", VA = "0x186A321F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public PGMCADPPNDC AOCGOHAKNKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6A32300", Offset = "0x6A30D00", VA = "0x186A32300")]
		get
		{
			return default(PGMCADPPNDC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6A322F0", Offset = "0x6A30CF0", VA = "0x186A322F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public byte KKCJNPDDBKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6A31DD0", Offset = "0x6A307D0", VA = "0x186A31DD0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6A32030", Offset = "0x6A30A30", VA = "0x186A32030")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public FBMPFMIDBEK MJCLDFCFNGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6A31DE0", Offset = "0x6A307E0", VA = "0x186A31DE0")]
		get
		{
			return default(FBMPFMIDBEK);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x6A323E0", Offset = "0x6A30DE0", VA = "0x186A323E0")]
	public HDCHJDKDDIF(IList<Mesh> IEDHCLBPBDH, IList<Matrix4x4> GIJCGJKCCKC, IList<bool> ACOJGBCIENJ, byte GAPNAFGCLPM, IList<byte[]> ELNEKBOPLAH, IList<int> NNHKCKHKHAB, IList<bool> OOFLMBDANFK, IList<int> NAFKDFAKHJG, IList<int> BFIBIGDOGCK, IList<int> FMJGIENFDGA, Allocator MDICAPEDFAK, PGMCADPPNDC DPFAONFNIDP, bool GNBINBECLDL = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x6A32310", Offset = "0x6A30D10", VA = "0x186A32310")]
	public GMOHBHABCJM NNCEMHLAHBO(Allocator MDICAPEDFAK, OFPGGHGKMMH INMIHNAKFFK)
	{
		return default(GMOHBHABCJM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x6A32040", Offset = "0x6A30A40", VA = "0x186A32040", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
[PLAFBFJHEAK]
public class NJBFICNOICD : HDGPBEOLHKF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public bool ODFPOPIGOMG;

	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private static readonly ProfilerMarker OIBNNNJOJAC;

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x6A40930", Offset = "0x6A3F330", VA = "0x186A40930")]
	public HDCHJDKDDIF NPHHKCLMNCO()
	{
		return default(HDCHJDKDDIF);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6A40C30", Offset = "0x6A3F630", VA = "0x186A40C30")]
	public NJBFICNOICD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct FBMPFMIDBEK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public Mesh.MeshData FPIKJMBMLNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public NativeSlice<BoneWeight> GMCKGCKGAIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public NativeSlice<byte> CFIGGPGOAEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public int BILAKJPPFBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public Matrix4x4 DAKKCFIAEBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public int BKLPIMAKDHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public NativeSlice<byte> JDPIOINPAKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public bool OGGCDAHIGDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public int MNCLONDAIJA;
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class JFBKCLMGPNG : HPBDMLCGCCD
{
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	private abstract class NIKFMLCLKHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public readonly PLGDACFFJCI MBNDKGJMNPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		protected bool JOCPGJJDJNC;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public virtual bool JLGBMEHCGAG
		{
			[Cpp2IlInjected.Token(Token = "0x60000AB")]
			[Cpp2IlInjected.Address(RVA = "0x8CD1A0", Offset = "0x8CBBA0", VA = "0x1808CD1A0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public virtual bool NFGEAHPCPAG
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x8CD1A0", Offset = "0x8CBBA0", VA = "0x1808CD1A0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public virtual MJONKEEGKHL.OANEACHHLDN BKLPIMAKDHD
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x883220", Offset = "0x881C20", VA = "0x180883220", Slot = "6")]
			get
			{
				return default(MJONKEEGKHL.OANEACHHLDN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public bool ONODLPDLDHO
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0xACC530", Offset = "0xACAF30", VA = "0x180ACC530")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public bool IPLJJDIJECB
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x16DD370", Offset = "0x16DBD70", VA = "0x1816DD370")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public bool BNPKMBPNGGF
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x6A40920", Offset = "0x6A3F320", VA = "0x186A40920")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool CDMELMKMBFK
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x6A40900", Offset = "0x6A3F300", VA = "0x186A40900")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x88DF90", Offset = "0x88C990", VA = "0x18088DF90")]
		protected NIKFMLCLKHH(PLGDACFFJCI KMJNCNCHJIH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract MFAPHLCBHHA JFDMEAJNOJI(int[] GHJEALBECEL, List<GEOMECACKBK> FPGDPIIOJOP, List<GEOMECACKBK> IFLDPPNCJDM);

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract NKKEOENIOIA BEEHLPFHCPC(uint NDKONLLHKBF, AvatarSkinnedMeshBoneOrderRemapsData IIAPJLDPMCL);
	}

	[Cpp2IlInjected.Token(Token = "0x200001B")]
	private class NPMDMIJCIMB : NIKFMLCLKHH
	{
		[Cpp2IlInjected.Token(Token = "0x200001C")]
		[CompilerGenerated]
		private sealed class HKDOPENDJIC
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x40000E1")]
			public FGDPIAEELFA<GameObject> skinAvatarItemPrefabHandle;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x40000E2")]
			public NPMDMIJCIMB <>4__this;

			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
			public HKDOPENDJIC()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0x6A33C80", Offset = "0x6A32680", VA = "0x186A33C80")]
			internal void CPEMLPHKFGF(GameObject result)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private readonly AvatarSkinAssetItem.EDGDIAGPNPM EIAGBGFLAFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private readonly AssetReference GPOHDENIGJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private readonly MJONKEEGKHL.OANEACHHLDN IIABLGBLDPI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private readonly IIEBDBDHLOD? OFAEDKLCINP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private readonly Material[] OMHIGABGHBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private SkinnedMeshRenderer[] AMIPOFGPNLN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private AvatarSkinAssetItem FMBENJCFBBN;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public override MJONKEEGKHL.OANEACHHLDN BKLPIMAKDHD
		{
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x8893F0", Offset = "0x887DF0", VA = "0x1808893F0", Slot = "6")]
			get
			{
				return default(MJONKEEGKHL.OANEACHHLDN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x6A41270", Offset = "0x6A3FC70", VA = "0x186A41270")]
		public NPMDMIJCIMB(AvatarSkinAssetItem.EDGDIAGPNPM LDCEEJMHPAF, AssetReference DMONBKPGDHO, Material ELGDCACJLBD, PLGDACFFJCI IIACJIKFNAK, MJONKEEGKHL.OANEACHHLDN NOHDHBENFGP = (MJONKEEGKHL.OANEACHHLDN)0, [Optional] IIEBDBDHLOD? DJHBAOMNFAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x6A41160", Offset = "0x6A3FB60", VA = "0x186A41160")]
		public NPMDMIJCIMB(AvatarSkinAssetItem.EDGDIAGPNPM LDCEEJMHPAF, AssetReference DMONBKPGDHO, Material ELGDCACJLBD, MJONKEEGKHL.OANEACHHLDN NOHDHBENFGP = (MJONKEEGKHL.OANEACHHLDN)0, [Optional] IIEBDBDHLOD? DJHBAOMNFAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6A40F20", Offset = "0x6A3F920", VA = "0x186A40F20", Slot = "7")]
		public override MFAPHLCBHHA JFDMEAJNOJI(int[] GHJEALBECEL, List<GEOMECACKBK> FPGDPIIOJOP, List<GEOMECACKBK> IFLDPPNCJDM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6A40C40", Offset = "0x6A3F640", VA = "0x186A40C40", Slot = "8")]
		public override NKKEOENIOIA BEEHLPFHCPC(uint NDKONLLHKBF, AvatarSkinnedMeshBoneOrderRemapsData IIAPJLDPMCL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6A410F0", Offset = "0x6A3FAF0", VA = "0x186A410F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200001D")]
	private class PPNIDEILDBE : NIKFMLCLKHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public readonly KOBEBIMIGBA JEIGFDAIKHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private FGDPIAEELFA<AGMFAOFOCLJ> NJKBMHPODAD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public AGMFAOFOCLJ NPJNDFDILOG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		private FGDPIAEELFA<Material[]> AEMOAGLOMMF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public Material[] BIBNEJKEFCA;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public override bool JLGBMEHCGAG
		{
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x89F3F0", Offset = "0x89DDF0", VA = "0x18089F3F0", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public override bool NFGEAHPCPAG
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x6A43A20", Offset = "0x6A42420", VA = "0x186A43A20", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6A43AD0", Offset = "0x6A424D0", VA = "0x186A43AD0")]
		public PPNIDEILDBE(PLGDACFFJCI KMJNCNCHJIH, KOBEBIMIGBA LLMLMNHEPIB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x6A432C0", Offset = "0x6A41CC0", VA = "0x186A432C0", Slot = "7")]
		public override MFAPHLCBHHA JFDMEAJNOJI(int[] GHJEALBECEL, List<GEOMECACKBK> FPGDPIIOJOP, List<GEOMECACKBK> IFLDPPNCJDM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x6A42E30", Offset = "0x6A41830", VA = "0x186A42E30", Slot = "8")]
		public override NKKEOENIOIA BEEHLPFHCPC(uint NDKONLLHKBF, AvatarSkinnedMeshBoneOrderRemapsData IIAPJLDPMCL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x6A43750", Offset = "0x6A42150", VA = "0x186A43750")]
		public NKKEOENIOIA KKMOMGOGGOE(GameObject LGEGPOAODCJ, uint NDKONLLHKBF, bool NMMFDLFHBCC, bool BEDABFHHCGG, AvatarSkinnedMeshBoneOrderRemapsData IIAPJLDPMCL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x6A42F60", Offset = "0x6A41960", VA = "0x186A42F60")]
		public static bool HECEICKHLMK(Renderer[] DLEAECLDKFG, string BPPALBDDDHG, [Out] Renderer GBILLOENLGC, [Out] Renderer KBDDCAKPPPA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x6A43A80", Offset = "0x6A42480", VA = "0x186A43A80", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6A43960", Offset = "0x6A42360", VA = "0x186A43960")]
		private (FGDPIAEELFA<AGMFAOFOCLJ>, FGDPIAEELFA<Material[]>) MIEGFFNCBII()
		{
			return default((FGDPIAEELFA<AGMFAOFOCLJ>, FGDPIAEELFA<Material[]>));
		}

		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x444A300", Offset = "0x4448D00", VA = "0x18444A300")]
		[CompilerGenerated]
		private void EJEFEOMBLFM(AGMFAOFOCLJ DFEFBOIIPKP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x886990", Offset = "0x885390", VA = "0x180886990")]
		[CompilerGenerated]
		private void GLLOBBMNCBO(Material[] DFEFBOIIPKP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000020")]
	[CompilerGenerated]
	private sealed class BMOKFEMOAJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public ONHIKCEPCOC avatarBuildParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public JFBKCLMGPNG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public EOKLDMPJAPL buildMeshPromise;

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public BMOKFEMOAJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x6A2C880", Offset = "0x6A2B280", VA = "0x186A2C880")]
		internal bool EKDLFAPCKKL(KOBEBIMIGBA item)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x6A2C8D0", Offset = "0x6A2B2D0", VA = "0x186A2C8D0")]
		internal void LPDNEDDFADA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x6A2C7D0", Offset = "0x6A2B1D0", VA = "0x186A2C7D0")]
		internal void ALAFHBIEAHP(string err)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x6A2C7F0", Offset = "0x6A2B1F0", VA = "0x186A2C7F0")]
		internal void ALAGAPKCMPB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6A2C8F0", Offset = "0x6A2B2F0", VA = "0x186A2C8F0")]
		internal void NLAMIJNKHLK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x8869A0", Offset = "0x8853A0", VA = "0x1808869A0")]
		internal MFAPHLCBHHA GHIDGOHPMOP()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[CompilerGenerated]
	private sealed class AHNHNINNFIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public int lowestPossibleLOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public BMOKFEMOAJE CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public AHNHNINNFIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6A2C5E0", Offset = "0x6A2AFE0", VA = "0x186A2C5E0")]
		internal GJIAPEJPGBN EBINDEOELHC(int lod)
		{
			return default(GJIAPEJPGBN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000022")]
	[CompilerGenerated]
	private sealed class BJAHHPHLLIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		public List<EOKLDMPJAPL> innerPromises;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public BJAHHPHLLIJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6A2C6A0", Offset = "0x6A2B0A0", VA = "0x186A2C6A0")]
		internal void DLMIODBLMPP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	[CompilerGenerated]
	private sealed class DDNGPFJDJLK : IEnumerator<IHLHBLBKNMF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private IHLHBLBKNMF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public JFBKCLMGPNG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public List<NIKFMLCLKHH> parts;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public List<EOKLDMPJAPL> innerPromises;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public bool isFirstPerson;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public Func<int, GJIAPEJPGBN> getLayer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public AGPOMHAFLJO materialPropertyBlock;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public Material materialInstance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		private int <lodIndex>5__2;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private IHLHBLBKNMF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x88DF90", Offset = "0x88C990", VA = "0x18088DF90")]
		[DebuggerHidden]
		public DDNGPFJDJLK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x6A2EB60", Offset = "0x6A2D560", VA = "0x186A2EB60", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x6A2ED60", Offset = "0x6A2D760", VA = "0x186A2ED60", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[CompilerGenerated]
	private sealed class FENBKDAOJKN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		public int[] LODs;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		public JFBKCLMGPNG <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public FENBKDAOJKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x6A2EFF0", Offset = "0x6A2D9F0", VA = "0x186A2EFF0")]
		internal MFAPHLCBHHA DCEKNFKOPCC(NIKFMLCLKHH p)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[CompilerGenerated]
	private sealed class HOJEDCHLNHC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public HAEJEBPAKIA cancelable;

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public HOJEDCHLNHC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x8D37C0", Offset = "0x8D21C0", VA = "0x1808D37C0")]
		internal void LHJACJPCABA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xBB63D0", Offset = "0xBB4DD0", VA = "0x180BB63D0")]
		internal void LHGCAEHHDOP(string err)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private sealed class IEFJAKIDKEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public long jobComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		public Stopwatch stopwatch;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		public SkinnedMeshRenderer lodRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public long meshComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public string meshName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public long meshCopyComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public JFBKCLMGPNG <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public int lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public List<Material> newUniqueMaterials;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public int frameStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public long lodBuildStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public long startCombineBuilder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public long jobScheduled;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public Action onFinally;

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public IEFJAKIDKEB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private sealed class EIHONBFGEOL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public GMOHBHABCJM defaultMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		public HDCHJDKDDIF defaultAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		public IEFJAKIDKEB CS$<>8__locals1;

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public EIHONBFGEOL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x6A2EDB0", Offset = "0x6A2D7B0", VA = "0x186A2EDB0")]
		internal void FGMBHONNAHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0xBBD7F0", Offset = "0xBBC1F0", VA = "0x180BBD7F0")]
		internal void FFFMLLFBGGP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private sealed class IHOLIEHCJAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public bool waitingForComplete;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public JobHandle lodBuildJobHandle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public IBLOPKGEONA legacyMeshJobContainer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public BECLDIKOBPD legacyAvatarMeshJobGroup;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C8")]
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public IEFJAKIDKEB CS$<>8__locals2;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public IHOLIEHCJAC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6A34070", Offset = "0x6A32A70", VA = "0x186A34070")]
		internal void EICILLJMPDD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0xBB8320", Offset = "0xBB6D20", VA = "0x180BB8320")]
		internal void LJIOKPAPOLM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	[CompilerGenerated]
	private sealed class KOMOKBCGDGP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public KeyValuePair<string, KOBEBIMIGBA> entry;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public HAEJEBPAKIA cancelablePromise;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public KOBEBIMIGBA avatarItem;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public JFBKCLMGPNG <>4__this;

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public KOMOKBCGDGP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6A40340", Offset = "0x6A3ED40", VA = "0x186A40340")]
		internal MFAPHLCBHHA EEKGFJPBNCI(CLBJJJHJFPD item)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6A40300", Offset = "0x6A3ED00", VA = "0x186A40300")]
		internal void BDKJMIGBFGA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private sealed class LGCAEPGMFHP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public FGDPIAEELFA<Texture2D> resourceHandle;

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public LGCAEPGMFHP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6A407A0", Offset = "0x6A3F1A0", VA = "0x186A407A0")]
		internal void CJNJCFNGKMC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private sealed class NENOMICPDHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public string overrideItemIdentifier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public PLGDACFFJCI overrideBodyPart;

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x883870", Offset = "0x882270", VA = "0x180883870")]
		public NENOMICPDHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x6A40880", Offset = "0x6A3F280", VA = "0x186A40880")]
		internal bool ADIGHLNDPLH(KeyValuePair<string, KOBEBIMIGBA> entry)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private AvatarConfiguration MIGCHDGGKOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private Transform PCJICKAKEHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private AssetReference GPOHDENIGJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	private GameObject EBENMDKIPJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	private GameObject HEEECEJHDOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	private SkinnedMeshRenderer IGPFMBENMKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	private AvatarSkinnedMeshBoneOrderRemapsData BPOGPALFEHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Transform[] KEKMBGAOIFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private Matrix4x4[] MHLOMIILCDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private Material HIKLBNBHHOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private Material FBPJMENBGEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private Material KBJILNNLOEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private Shader FCGGCELPMCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private Shader PHIDOPJIFBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private Animator OGNHCHCJNCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	private Renderer[] MKBJINBJNFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private MJONKEEGKHL.OANEACHHLDN JPBMINNBAGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private AvatarBodyPartShapesManager EEGGPMGALLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	private IReadOnlyDictionary<string, Transform> IIGKPEJLILL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private AvatarFaceShapeData.PHKKDCDPDBG MGMEKKAOAPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private AvatarBodyShapeData.MMLPPPGOCGI OANEHAIMAHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private bool ECJMCHJINGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB1")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private bool MELHDDDFPBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private Color PFDABNLFOOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	private Color CCMMBPJMHFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD4")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private Color JNHIDBHCLNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE4")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	private Color? NNHHHEDENII;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	private Color? DPABPBLEGJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10C")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private Color? JPIFIADAMNB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private Color? FNBOIBHLNBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private Texture2D EDEMBNPBMJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private Texture2D HHFOCMCNALJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	[CanBeNull]
	private KOBEBIMIGBA PFDCHAHNGCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	private Texture EEBDJBNMJHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private Color JAJAEDENLHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public Dictionary<Renderer, AGPOMHAFLJO> BPEHFGLLDFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private Dictionary<Renderer, AGPOMHAFLJO> NFKHLFFFLHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private Dictionary<string, List<OCAFHAFHPLD>> OKNPBBCMIKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private Dictionary<string, List<OCAFHAFHPLD>> EHLILBEFINH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	private readonly List<GEOMECACKBK> PNOKOCHGECA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	private readonly List<GEOMECACKBK> OHJNBEPFBIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	private readonly List<GEOMECACKBK> ICIPPMHKDBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A0")]
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	private readonly List<GEOMECACKBK> OGHCEOJDEAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	private Dictionary<OCAFHAFHPLD, Material> EJIBDBEOBOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B0")]
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	private Dictionary<OCAFHAFHPLD, Material> BNFIGKHLKFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	private SkinnedMeshRenderer[] LLEPKBIEHHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C0")]
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	private SkinnedMeshRenderer[] HNALGCPFGMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	private SkinnedMeshRenderer[] FBLLHALANPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private SkinnedMeshRenderer[] LEMPIEAMBHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1D8")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private readonly Dictionary<string, FGDPIAEELFA<Texture2D>> EGAHCMBEJLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private readonly Dictionary<string, FGDPIAEELFA<Texture2D>> HJHJELJIFHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1E8")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private AdditionalHatData GEPCFOAOGHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private IDDKLPOMBMA GEKDMBADPMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1F8")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private FitMeshHemisphere AEKDNPEEEGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x200")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private PositionAndRotation DFDKHNFJJAF;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x220")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	private Material PCGJECECGDG;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x228")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	private Material BILJHFEILAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x230")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private Dictionary<string, KOBEBIMIGBA> CMDDAIJDKBF;

	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private static readonly int OGLDBLJGJCD;

	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	private static readonly int OOPKFEAAKNL;

	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static readonly int IBADKOMJCLO;

	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private static readonly int KCPEEHPECCH;

	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private static readonly int PGFJCCHMONP;

	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static readonly int IMKIJBIEGEF;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly int ADGGMOAOJOI;

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static readonly int BCIGPHGOCPD;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static readonly int OFMBAEADEFI;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly int NJELMHNABMP;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static readonly int PLBPEGLAACH;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly int EMKKEKKMPEG;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly int IICLIMPPOPO;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly int LCDEIKHHNFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x238")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly PLAJPLAPENK GFFHEKGAGKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x240")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly PLAJPLAPENK PNKODAEANEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x248")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private bool OCMIHMEFLBN;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static Lazy<JAHIFEMIDHK> OBMCLMEHLHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x250")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private Lazy<KCPFPEPLBLO> EKHGKMLNBNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x258")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private Lazy<CDPLPEKILNE> BFJDBDGMGBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x260")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private IEIBCMGLIKN CCMEGFONHNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x268")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private List<Action> FOFBKIIKAOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x270")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private HPOMCNJDPHM DALFPHOKLDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x278")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private SkinnedMeshRenderer[] LPEAHHEKKGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x280")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	private int HFIKBJCLCOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x284")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	private bool IMGAOHAFEOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x288")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private int DCIMPGLMPON;

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public bool MGMPIOCFFAM
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6A3A7B0", Offset = "0x6A391B0", VA = "0x186A3A7B0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6A36830", Offset = "0x6A35230", VA = "0x186A36830")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	private Material EHCNGOELMFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6A3C020", Offset = "0x6A3AA20", VA = "0x186A3C020")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	private Material BKEJLOEJFMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6A3D790", Offset = "0x6A3C190", VA = "0x186A3D790")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	private bool HMKFBIADCHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x89F3F0", Offset = "0x89DDF0", VA = "0x18089F3F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public LJIAAKKJMFC NHNAOOBDMDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x900EE0", Offset = "0x8FF8E0", VA = "0x180900EE0", Slot = "21")]
		get
		{
			return default(LJIAAKKJMFC);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	private static JAHIFEMIDHK LGHCFIEDAOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x6A37690", Offset = "0x6A36090", VA = "0x186A37690")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	private KCPFPEPLBLO KIPCBIPBGEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x6A3BFD0", Offset = "0x6A3A9D0", VA = "0x186A3BFD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	private CDPLPEKILNE KBOJNNHGINF
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x6A3F1B0", Offset = "0x6A3DBB0", VA = "0x186A3F1B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	private IEIBCMGLIKN LBKKGCCEGKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x6A395A0", Offset = "0x6A37FA0", VA = "0x186A395A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public PLAJPLAPENK BBMGEFMACMI
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0xD2C810", Offset = "0xD2B210", VA = "0x180D2C810", Slot = "12")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public PLAJPLAPENK EFIAOOHOMJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x1425AF0", Offset = "0x14244F0", VA = "0x181425AF0", Slot = "13")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public SkinnedMeshRenderer[] CAJILDNABAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000058")]
		[Cpp2IlInjected.Address(RVA = "0xC9C2A0", Offset = "0xC9ACA0", VA = "0x180C9C2A0", Slot = "16")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public Renderer[] IKGLKGIDLFL
	{
		[Cpp2IlInjected.Token(Token = "0x6000059")]
		[Cpp2IlInjected.Address(RVA = "0x88C900", Offset = "0x88B300", VA = "0x18088C900", Slot = "17")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public bool IKPBMAAIDEO
	{
		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x6A35F80", Offset = "0x6A34980", VA = "0x186A35F80", Slot = "20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public PositionAndRotation HFFJBGMJFGO
	{
		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6A3A850", Offset = "0x6A39250", VA = "0x186A3A850", Slot = "27")]
		get
		{
			return default(PositionAndRotation);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public MJONKEEGKHL.OANEACHHLDN CMDGMPHGFFG
	{
		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x88C850", Offset = "0x88B250", VA = "0x18088C850", Slot = "18")]
		get
		{
			return default(MJONKEEGKHL.OANEACHHLDN);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public int EIEFKHPIBGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x2332130", Offset = "0x2330B30", VA = "0x182332130")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6A36DA0", Offset = "0x6A357A0", VA = "0x186A36DA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	private bool AKMKOEGDGOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6A3A9D0", Offset = "0x6A393D0", VA = "0x186A3A9D0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	private static bool BNAMMMFOIPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6A3F200", Offset = "0x6A3DC00", VA = "0x186A3F200")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6A3FB50", Offset = "0x6A3E550", VA = "0x186A3FB50")]
	public JFBKCLMGPNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x6A3EEF0", Offset = "0x6A3D8F0", VA = "0x186A3EEF0", Slot = "28")]
	public void PCEEADECCDH(PJKBFLPLDHF ABLGKNEMKAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x6A385B0", Offset = "0x6A36FB0", VA = "0x186A385B0", Slot = "29")]
	public void FKNMENBLGLN(LNACEOHGPFJ LBFMPKEGEHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x6A36DA0", Offset = "0x6A357A0", VA = "0x186A36DA0", Slot = "4")]
	public void DKHFJCGHCAL(int NDKONLLHKBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x6A38680", Offset = "0x6A37080", VA = "0x186A38680", Slot = "9")]
	public void FNJHABLABPK(AFOGLPHBMEM GKGEOCLKLLI, Texture2D GOIIACIDIEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x6A3B140", Offset = "0x6A39B40", VA = "0x186A3B140", Slot = "10")]
	public void LOKFFKDLEJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6A38930", Offset = "0x6A37330", VA = "0x186A38930", Slot = "11")]
	public bool FPANLDFAJFM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x6A36E60", Offset = "0x6A35860", VA = "0x186A36E60", Slot = "8")]
	public void EBAPGCCMLHF(FDPILNELIGF AMFEJHMJAGG, Color? BLBBBKOLGJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x6A373F0", Offset = "0x6A35DF0", VA = "0x186A373F0")]
	private void EGHACNEDALJ(Action HEOLPMPANBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6A3F3A0", Offset = "0x6A3DDA0", VA = "0x186A3F3A0", Slot = "5")]
	public void PKNOEOBFNIB(KOBEBIMIGBA EMKKKMCJHFB, Texture BGOJEMPBMKF, Color IMENNKEIAPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6A36830", Offset = "0x6A35230", VA = "0x186A36830", Slot = "6")]
	public void CDMIBBHGFFO(bool GALCOOCAELE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x180A6F0", Offset = "0x18090F0", VA = "0x18180A6F0", Slot = "7")]
	public void BJOMFGAHONG(HPOMCNJDPHM APDNBDIKMDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6A3C1B0", Offset = "0x6A3ABB0", VA = "0x186A3C1B0", Slot = "14")]
	public EOKLDMPJAPL NEELIDKEKHO(ONHIKCEPCOC ELGEAMPJBDE, bool HAKBBJDPICO, int[] DNBBPHEKMMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6A37C00", Offset = "0x6A36600", VA = "0x186A37C00", Slot = "15")]
	public void FFLFLLEPLFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6A3B300", Offset = "0x6A39D00", VA = "0x186A3B300", Slot = "26")]
	public void MDBJIEDMHDE([Optional] IDDKLPOMBMA POOAGJMBAEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6A3B1C0", Offset = "0x6A39BC0", VA = "0x186A3B1C0")]
	private bool MCKLHINEEBN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x6A399E0", Offset = "0x6A383E0", VA = "0x186A399E0", Slot = "19")]
	public bool HPKPAIFJCCA(MJONKEEGKHL.OANEACHHLDN EKFKGDKIJND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x6A3AC40", Offset = "0x6A39640", VA = "0x186A3AC40")]
	private bool LIBPOIPOOIG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x6A3E920", Offset = "0x6A3D320", VA = "0x186A3E920")]
	private EOKLDMPJAPL PBJGOIELADH(bool HAKBBJDPICO, List<NIKFMLCLKHH> CEGOPPNFBBP, int[] DNBBPHEKMMF, Func<int, GJIAPEJPGBN> PKOIENHPEMH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x6A3DFB0", Offset = "0x6A3C9B0", VA = "0x186A3DFB0")]
	[IteratorStateMachine(typeof(DDNGPFJDJLK))]
	private IEnumerator<IHLHBLBKNMF> OECIKICFNKC(bool HAKBBJDPICO, List<NIKFMLCLKHH> CEGOPPNFBBP, int[] DNBBPHEKMMF, Func<int, GJIAPEJPGBN> PKOIENHPEMH, AGPOMHAFLJO CHMGEFBPMID, Material JGPGIBHCNNK, List<EOKLDMPJAPL> FHOKHMKOGJL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x6A39150", Offset = "0x6A37B50", VA = "0x186A39150")]
	private EOKLDMPJAPL GLNBJAKCLJO(List<NIKFMLCLKHH> CEGOPPNFBBP, int[] DNBBPHEKMMF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6A342B0", Offset = "0x6A32CB0", VA = "0x186A342B0")]
	private DABMKCAGAIA AAEOBIEDIKC(List<NIKFMLCLKHH> CEGOPPNFBBP, int NDKONLLHKBF, bool HAKBBJDPICO, GJIAPEJPGBN MMOIPMHDPJP, bool IJIDNJCLEGJ, AGPOMHAFLJO CHMGEFBPMID, Material JGPGIBHCNNK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6A35EC0", Offset = "0x6A348C0", VA = "0x186A35EC0", Slot = "22")]
	public void AGJDJKIJPGD(AvatarFaceShape LGKLNEFNOIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A200", Offset = "0x6A38C00", VA = "0x186A3A200", Slot = "23")]
	public void ILMGJEALLBN(AvatarBodyShape ACMEJGGELNF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6A37E00", Offset = "0x6A36800", VA = "0x186A37E00", Slot = "25")]
	public void FGINPLKDKFC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x6A36250", Offset = "0x6A34C50", VA = "0x186A36250", Slot = "24")]
	public void BGIBDLMCKGG(bool DCGICCKDDJB, bool EPOBJIBGPEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x6A39AD0", Offset = "0x6A384D0", VA = "0x186A39AD0")]
	private void IGDDKJKFABL(SkinnedMeshRenderer KLHMKBEJLJH, int NDKONLLHKBF, Mesh ANBKEJJPIHH, List<Material> CDPPEHBJKIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6A39640", Offset = "0x6A38040", VA = "0x186A39640")]
	private static Material HEGGNBBKENP(Dictionary<OCAFHAFHPLD, Material> AEPJANOKINP, Material LINJPHMININ, GOBJOHNJDAK BNCHIKHAIDG, FOMLDJLGFFP GGKKPKHIDLK, PLGDACFFJCI IIACJIKFNAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6A397A0", Offset = "0x6A381A0", VA = "0x186A397A0")]
	private static GOBJOHNJDAK HKCMLOPCFLH(NIKFMLCLKHH NGKJJJEBOOD, int HLLCDPPFFFC)
	{
		return default(GOBJOHNJDAK);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6A3F410", Offset = "0x6A3DE10", VA = "0x186A3F410")]
	private void PNKCAFODHCM(int ALFOCGJIHEG, Material MLMFHAHBCEC, NIKFMLCLKHH NGKJJJEBOOD, [Out] Texture2D OJOAHDGNLHC, [Out] Vector4 LHEMDNPKOCL, [Out] Texture2D IBMJHICFEFO, [Out] Texture2D BJPLKJKEBCJ, [Out] Texture2D CKEHJMCKFCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x6A3E210", Offset = "0x6A3CC10", VA = "0x186A3E210")]
	private void OKCILIAMFGG(int ALFOCGJIHEG, Material MLMFHAHBCEC, NIKFMLCLKHH NGKJJJEBOOD, [Out] Color KFFAOFGKEMD, [Out] Color ECOHHPEEIMN, [Out] Color HGAGKPJHAPK, [Out] Color ODKFAJMKCIN, [Out] Color OMFDOHGLOHK, [Out] Color MIPEGFIHKLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x6A365D0", Offset = "0x6A34FD0", VA = "0x186A365D0")]
	private bool BLPIDPEBECP(Material MLMFHAHBCEC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x6A37480", Offset = "0x6A35E80", VA = "0x186A37480")]
	private static Material EJLJOJPDPCC(int ALFOCGJIHEG, PPNIDEILDBE NGKJJJEBOOD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x6A36840", Offset = "0x6A35240", VA = "0x186A36840")]
	private static FOMLDJLGFFP CJFLJLBLPEK(NIKFMLCLKHH NGKJJJEBOOD, int HLLCDPPFFFC)
	{
		return default(FOMLDJLGFFP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x6A3BCF0", Offset = "0x6A3A6F0", VA = "0x186A3BCF0")]
	private static void MHLHHFCKLGN(Dictionary<string, List<OCAFHAFHPLD>> HJDLPIEKGOC, NIKFMLCLKHH ILAPGIMIKGO, Material LINJPHMININ, GOBJOHNJDAK AMFEJHMJAGG, FOMLDJLGFFP GKGEOCLKLLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x6A3AD90", Offset = "0x6A39790", VA = "0x186A3AD90")]
	private static SkinnedMeshRenderer LKPGFPHAHLG(Transform DCMLDPACFGH, Transform LACEFFKACBJ, SkinnedMeshRenderer[] DLEAECLDKFG, int NDKONLLHKBF, GJIAPEJPGBN MMOIPMHDPJP, bool HAKBBJDPICO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x6A374D0", Offset = "0x6A35ED0", VA = "0x186A374D0")]
	private void EMJGOIDEDAF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6A37470", Offset = "0x6A35E70", VA = "0x186A37470")]
	private void EJDPPCPDCLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6A39440", Offset = "0x6A37E40", VA = "0x186A39440")]
	private static void GODBANFKJOK(Dictionary<OCAFHAFHPLD, Material> AEPJANOKINP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6A360F0", Offset = "0x6A34AF0", VA = "0x186A360F0")]
	private static void AKHENFAHNKF(Dictionary<Renderer, AGPOMHAFLJO> NEPEODCHLNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6A398C0", Offset = "0x6A382C0", VA = "0x186A398C0")]
	private void HOJDPCPIIDE(SkinnedMeshRenderer[] DLEAECLDKFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A160", Offset = "0x6A38B60", VA = "0x186A3A160")]
	private void IJJOCOLBNHB(SkinnedMeshRenderer FJMAGDJJPBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6A383D0", Offset = "0x6A36DD0", VA = "0x186A383D0")]
	private void FKIIDCHJJGE(List<GEOMECACKBK> IOEAFCCDPCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6A3AFC0", Offset = "0x6A399C0", VA = "0x186A3AFC0")]
	private void LOHDICMCAHB(Dictionary<string, FGDPIAEELFA<Texture2D>> HJDLPIEKGOC, bool NFLJEFENIHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6A38630", Offset = "0x6A37030", VA = "0x186A38630")]
	private void FLKIPINHJIE(Dictionary<string, List<OCAFHAFHPLD>> HJDLPIEKGOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A2C0", Offset = "0x6A38CC0", VA = "0x186A3A2C0")]
	private void IPIPFPNKIMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6A37260", Offset = "0x6A35C60", VA = "0x186A37260")]
	private void ECHOGOJNMKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6A39C10", Offset = "0x6A38610", VA = "0x186A39C10")]
	private void IIPOPKCNJKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6A39A00", Offset = "0x6A38400", VA = "0x186A39A00")]
	private void IEPAMFPIIGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6A3AD00", Offset = "0x6A39700", VA = "0x186A3AD00")]
	private void LJPJEEBCLEA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6A3E0C0", Offset = "0x6A3CAC0", VA = "0x186A3E0C0")]
	private void OGJCKOJIKAN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6A36CD0", Offset = "0x6A356D0", VA = "0x186A36CD0")]
	private void DIKAANDCNJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6A38890", Offset = "0x6A37290", VA = "0x186A38890")]
	private void FOFPOCKPADF(bool PKIICCJGDKA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6A3D880", Offset = "0x6A3C280", VA = "0x186A3D880")]
	private void NLGKGLDILPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6A36DC0", Offset = "0x6A357C0", VA = "0x186A36DC0")]
	private void DOHHHPIILMI(bool PKIICCJGDKA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6A36290", Offset = "0x6A34C90", VA = "0x186A36290")]
	private void BICFMFBOBIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x6A37F00", Offset = "0x6A36900", VA = "0x186A37F00")]
	private void FHHGJFKADOB(Material JGPGIBHCNNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6A3BAF0", Offset = "0x6A3A4F0", VA = "0x186A3BAF0")]
	private void MDGBKFKFGOF(Material JGPGIBHCNNK, Color NCMHIMIBNPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6A369E0", Offset = "0x6A353E0", VA = "0x186A369E0")]
	private void DFOAJHLGKCP(Material JGPGIBHCNNK, Color EIKCJPFKFEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6A3E6F0", Offset = "0x6A3D0F0", VA = "0x186A3E6F0")]
	private void ONJJHPIELFN(Material JGPGIBHCNNK, Color KFFAOFGKEMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6A36B50", Offset = "0x6A35550", VA = "0x186A36B50")]
	private void DGMMJKCNCFL(Material JGPGIBHCNNK, Texture2D GOIIACIDIEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A880", Offset = "0x6A39280", VA = "0x186A3A880")]
	private void KAAKFAACKHC(Material JGPGIBHCNNK, Texture KHBFEKMEIFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x6A3AA80", Offset = "0x6A39480", VA = "0x186A3AA80")]
	private void LBPGFEDNMND(Action<AGPOMHAFLJO> JEMNBANFADI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x6A3DE00", Offset = "0x6A3C800", VA = "0x186A3DE00")]
	private void OBCNABDGDFA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x6A378A0", Offset = "0x6A362A0", VA = "0x186A378A0")]
	private void FCNGJGOIDAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x6A38B30", Offset = "0x6A37530", VA = "0x186A38B30")]
	private EOKLDMPJAPL GDABELICMGI()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x6A3DA30", Offset = "0x6A3C430", VA = "0x186A3DA30")]
	private void OBBEPFNNBEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A420", Offset = "0x6A38E20", VA = "0x186A3A420")]
	public void JDHCKCPGCPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6A37790", Offset = "0x6A36190", VA = "0x186A37790")]
	[CompilerGenerated]
	private void FCGDJGLEAIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6A36260", Offset = "0x6A34C60", VA = "0x186A36260")]
	[CompilerGenerated]
	private void BGNICJFNGDG(AGPOMHAFLJO BKKGGAMMLDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6A3A7C0", Offset = "0x6A391C0", VA = "0x186A3A7C0")]
	[CompilerGenerated]
	private void JLPEMBDAFMP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x6A3D9E0", Offset = "0x6A3C3E0", VA = "0x186A3D9E0")]
	[CompilerGenerated]
	private void NNFEJDMEIDF(AGPOMHAFLJO BKKGGAMMLDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6A38AA0", Offset = "0x6A374A0", VA = "0x186A38AA0")]
	[CompilerGenerated]
	private void FPCNFLGJOAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6A36930", Offset = "0x6A35330", VA = "0x186A36930")]
	[CompilerGenerated]
	private void DANBJJJEEGD(AGPOMHAFLJO BKKGGAMMLDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6A37700", Offset = "0x6A36100", VA = "0x186A37700")]
	[CompilerGenerated]
	private void EPJFHKLGPLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6A3E860", Offset = "0x6A3D260", VA = "0x186A3E860")]
	[CompilerGenerated]
	private void OOBGONDDFPM(AGPOMHAFLJO BKKGGAMMLDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6A3D950", Offset = "0x6A3C350", VA = "0x186A3D950")]
	[CompilerGenerated]
	private void NNCHCMPOCFB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x6A3AA50", Offset = "0x6A39450", VA = "0x186A3AA50")]
	[CompilerGenerated]
	private void KKPLBMMAOMI(AGPOMHAFLJO BKKGGAMMLDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x6A3BC60", Offset = "0x6A3A660", VA = "0x186A3BC60")]
	[CompilerGenerated]
	private void MEIPPEHPOCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x6A3DF80", Offset = "0x6A3C980", VA = "0x186A3DF80")]
	[CompilerGenerated]
	private void ODDAJHKDBAI(AGPOMHAFLJO BKKGGAMMLDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x6A3E890", Offset = "0x6A3D290", VA = "0x186A3E890")]
	[CompilerGenerated]
	private void PANHDBDHAJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6A39410", Offset = "0x6A37E10", VA = "0x186A39410")]
	[CompilerGenerated]
	private void GMFBLKEDDMP(AGPOMHAFLJO BKKGGAMMLDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6A37820", Offset = "0x6A36220", VA = "0x186A37820")]
	[CompilerGenerated]
	private void FCGEJLBCPIF(KeyValuePair<string, FGDPIAEELFA<Texture2D>> HOODFIDELNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6A35E30", Offset = "0x6A34830", VA = "0x186A35E30")]
	[CompilerGenerated]
	private void ADMFGDKFGOG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6A39120", Offset = "0x6A37B20", VA = "0x186A39120")]
	[CompilerGenerated]
	private void GGOLOJONENH(AGPOMHAFLJO BKKGGAMMLDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6A36950", Offset = "0x6A35350", VA = "0x186A36950")]
	[CompilerGenerated]
	private void DAPMAKPHCHJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6A3DA00", Offset = "0x6A3C400", VA = "0x186A3DA00")]
	[CompilerGenerated]
	private void NNMEIFPHPKI(AGPOMHAFLJO BKKGGAMMLDG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class COIKIBKNBPI : JPLPDGPDHJC
{
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private static readonly int BBHCIDPBPHG;

	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private static readonly int CIBLGIAOBMO;

	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private static readonly int PADMJOAMIMC;

	[Cpp2IlInjected.Token(Token = "0x400012F")]
	private static readonly int LAFPHDMOIIO;

	[Cpp2IlInjected.Token(Token = "0x4000130")]
	private static readonly int CFHFCHEIMFD;

	[Cpp2IlInjected.Token(Token = "0x4000131")]
	private static readonly int IEJJHLEDGMB;

	[Cpp2IlInjected.Token(Token = "0x4000132")]
	private static readonly int NOIGBJECJEH;

	[Cpp2IlInjected.Token(Token = "0x4000133")]
	private static readonly int KJMLPEJCHDD;

	[Cpp2IlInjected.Token(Token = "0x4000134")]
	private static readonly int MAEBDIBHHPI;

	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private static readonly int BIMIMKPMPAE;

	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private static readonly int BENONHCEMMC;

	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private static readonly int KFKHOMLFHBL;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private static readonly int GKMKKHGKLJH;

	[Cpp2IlInjected.Token(Token = "0x4000139")]
	private static readonly int HBHFOONFEAD;

	[Cpp2IlInjected.Token(Token = "0x400013A")]
	private static readonly int DFBHKJPGCKD;

	[Cpp2IlInjected.Token(Token = "0x400013B")]
	private static readonly int PAKJPMEPFPP;

	[Cpp2IlInjected.Token(Token = "0x400013C")]
	private static readonly int BCKEADIABNJ;

	[Cpp2IlInjected.Token(Token = "0x400013D")]
	private static readonly int DICHODNJPHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private Transform CNMMMEECNHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private Transform DHGPELBCDOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private Transform MBEAAENIMLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private Transform AMKKKLINNBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000142")]
	private Transform OFFJNAEMDOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private Transform CPKPLNGKAKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private Transform CDKCJKAMDAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private GHOCBHEIOKH CINDPPNIBCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private MaterialPropertyBlock DJBAPHBBBJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private SkinnedMeshRenderer[] KEPACFLJOIA;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	private MaterialPropertyBlock AFHDNOBIHHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x6A2CAB0", Offset = "0x6A2B4B0", VA = "0x186A2CAB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public bool PAJCHKNMDKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x6A2DD90", Offset = "0x6A2C790", VA = "0x186A2DD90", Slot = "4")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6A2E730", Offset = "0x6A2D130", VA = "0x186A2E730", Slot = "7")]
	public void PCEEADECCDH(GHOCBHEIOKH OIIKBEIOGLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6A2CB30", Offset = "0x6A2B530", VA = "0x186A2CB30", Slot = "8")]
	public void EFADAOKKNFL(BONECKELFCI IJDAEIDBODM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6A2DF10", Offset = "0x6A2C910", VA = "0x186A2DF10", Slot = "5")]
	public void LGMDEKOAEEG(COGHAJMGFJB NHHJOLJFFJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x6A2C980", Offset = "0x6A2B380", VA = "0x186A2C980")]
	private Vector2 ABJACBMECJA(Vector2 GENENELAJEK)
	{
		return default(Vector2);
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x6A2CC40", Offset = "0x6A2B640", VA = "0x186A2CC40", Slot = "6")]
	public void GJEIFCJKFAK(DPGDAOADILK IJDAEIDBODM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x6A2E3F0", Offset = "0x6A2CDF0", VA = "0x186A2E3F0")]
	private void LNGNLHLCPMD(DPGDAOADILK OMMNCFBGHHN, FEADBNHGDIN BMIPGCAAEGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x6A2CB60", Offset = "0x6A2B560", VA = "0x186A2CB60")]
	private void GACAOJNPMLP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x6A2EB00", Offset = "0x6A2D500", VA = "0x186A2EB00")]
	public COIKIBKNBPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x6A2CA20", Offset = "0x6A2B420", VA = "0x186A2CA20")]
	[CompilerGenerated]
	internal static (float, float) DHKNNOIALOF(float KJNIBPIBKPN)
	{
		return default((float, float));
	}

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x6A2C9E0", Offset = "0x6A2B3E0", VA = "0x186A2C9E0")]
	[CompilerGenerated]
	internal static Vector4 BEJNDBHNEEB(Vector2 BJDHDJCINFH, Vector2 ADJNFMJNIAA)
	{
		return default(Vector4);
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class AvatarItemMaterial : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		[SerializeField]
		[Obsolete("Use CombinationId instead!")]
		private string Guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		[SerializeField]
		private SerializedCombinationId combinationId;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		private MKALFOKDGKE? cachedMaterialCombinationId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		[SerializeField]
		private Material material;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		[SerializeField]
		private Material[] additionalMaterials;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public NLPKIMNBAMP CombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x600010D")]
			[Cpp2IlInjected.Address(RVA = "0x6A486D0", Offset = "0x6A470D0", VA = "0x186A486D0")]
			get
			{
				return default(NLPKIMNBAMP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public MKALFOKDGKE MaterialCombinationId
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x6A48700", Offset = "0x6A47100", VA = "0x186A48700")]
			get
			{
				return default(MKALFOKDGKE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public Material Material
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x885FC0", Offset = "0x8849C0", VA = "0x180885FC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public Material[] AdditionalMaterials
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x885FD0", Offset = "0x8849D0", VA = "0x180885FD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6A48520", Offset = "0x6A46F20", VA = "0x186A48520")]
		public Material[] GIGNKFGACEN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x6A48360", Offset = "0x6A46D60", VA = "0x186A48360")]
		public static void CNGJKAJMEBE(AvatarItemMaterial AKJKBNNEOKN, Material MLMFHAHBCEC, int ALFOCGJIHEG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x6A48610", Offset = "0x6A47010", VA = "0x186A48610")]
		public AvatarItemMaterial()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
[PLAFBFJHEAK]
public struct GPDFDAJONKF : IJob
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014D")]
	[ReadOnly]
	public BECLDIKOBPD NGHIPIJCNKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x400014E")]
	[ReadOnly]
	public int CGHMLJBBANM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x190")]
	[Cpp2IlInjected.Token(Token = "0x400014F")]
	public IBLOPKGEONA COOFFOCDAHJ;

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x6A4B590", Offset = "0x6A49F90", VA = "0x186A4B590", Slot = "4")]
	public void Execute()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
[NativeContainer]
[PLAFBFJHEAK]
public struct IBLOPKGEONA : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000150")]
	public NativeArray<Vector3> DBNAEKNAGJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000151")]
	public NativeArray<Vector3> LABFLHMCLEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000152")]
	public NativeArray<Vector4> IIHDJPGJDHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000153")]
	public NativeArray<Vector2> JCMOOBJCHNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	public NativeArray<Vector2> FFKFNFFNCGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	public NativeArray<Vector2> JOJAOKKGJPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	public NativeArray<Vector2> HDJDEPGLELJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000157")]
	public NativeArray<Color> ONPANKAMIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000158")]
	public NativeArray<int> MMHBJNCDKMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000159")]
	public NativeArray<int> EBJMLEBBLPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400015A")]
	private NativeArray<int> IFPLHKKHHHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private NativeArray<int> HOLIPDBKLLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400015C")]
	public NativeArray<int> GJNPGCANCMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400015D")]
	public NativeArray<int> NNIPMCDKJHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x400015E")]
	public NativeArray<int> BMEHPJDOMEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x400015F")]
	public NativeArray<BoneWeight> DJLBCLFHIBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	private NativeArray<int> APDNBDIKMDG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	private bool PMAKKAFMGHO;

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	public int FJEDHBOPAJL
	{
		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x6A4D250", Offset = "0x6A4BC50", VA = "0x186A4D250")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x6A4D020", Offset = "0x6A4BA20", VA = "0x186A4D020")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int OBPLCPKGCOI
	{
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x6A4C940", Offset = "0x6A4B340", VA = "0x186A4C940")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x6A4D260", Offset = "0x6A4BC60", VA = "0x186A4D260")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public int JIKAIIDAABB
	{
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x6A4D370", Offset = "0x6A4BD70", VA = "0x186A4D370")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x6A4CCC0", Offset = "0x6A4B6C0", VA = "0x186A4CCC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x6A4D380", Offset = "0x6A4BD80", VA = "0x186A4D380")]
	public IBLOPKGEONA(int JMJOPMPPDPD, int JDFFOCMONDJ, int ACAKDLEEMFC, int JFOMGAJDGLP, Allocator MDICAPEDFAK, int LJJEGPBBKLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x6A4D270", Offset = "0x6A4BC70", VA = "0x186A4D270")]
	public void MKNHCBJBOJC(int EBDDHAPIAHH, Vector3 OEHMKJHGMIJ, Vector3 NGLGLPDMMBG, Vector4 LJDCGGEFKLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x6A4D030", Offset = "0x6A4BA30", VA = "0x186A4D030")]
	public void GLNMENKEEMB(int EBDDHAPIAHH, BoneWeight OAMFOFKGHEB, NativeSlice<byte> JDPIOINPAKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6A4CA20", Offset = "0x6A4B420", VA = "0x186A4CA20")]
	public Color CMMBACGHFNM(int EBDDHAPIAHH)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6A4C950", Offset = "0x6A4B350", VA = "0x186A4C950")]
	public void ADMEGKLOBJO(int EBDDHAPIAHH, Color FOBCKJHLPBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x6A4D1D0", Offset = "0x6A4BBD0", VA = "0x186A4D1D0")]
	public void KDALMGELNMK(byte HFBJMLDHHNJ, int EBDDHAPIAHH, Vector2 NNPPPDIINHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x6A4C930", Offset = "0x6A4B330", VA = "0x186A4C930")]
	public void AAFGJCEPPIK(int EBDDHAPIAHH, int JHHINGACJOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x6A4D220", Offset = "0x6A4BC20", VA = "0x186A4D220")]
	public bool KOCMJBCNPHP(int HFBJMLDHHNJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x6A4CBF0", Offset = "0x6A4B5F0", VA = "0x186A4CBF0")]
	public void EMDBKAICHMA(int ENLEPGJIFEF, int ELDAPMPELBH, int OMBKDMFPMFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x6A4C970", Offset = "0x6A4B370", VA = "0x186A4C970")]
	public int[] BLIGCFDMBNA(int ENLEPGJIFEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x6A4D2E0", Offset = "0x6A4BCE0", VA = "0x186A4D2E0")]
	private NativeSlice<int> MPDNHKPJCIC(int ENLEPGJIFEF)
	{
		return default(NativeSlice<int>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x6A4CA40", Offset = "0x6A4B440", VA = "0x186A4CA40", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6A4CCD0", Offset = "0x6A4B6D0", VA = "0x186A4CCD0")]
	public Mesh GEICFGBFCFK([Optional] string LPPEDCPPANP)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
[DefaultMember("Item")]
[PLAFBFJHEAK]
[NativeContainer]
public struct BECLDIKOBPD : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	public NativeArray<Vector3> DBNAEKNAGJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000163")]
	public NativeArray<Vector3> LABFLHMCLEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000164")]
	public NativeArray<Vector4> IIHDJPGJDHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	public NativeArray<Vector2> JCMOOBJCHNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000166")]
	public NativeArray<Vector2> FFKFNFFNCGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000167")]
	public NativeArray<Vector2> JOJAOKKGJPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000168")]
	public NativeArray<Vector2> HDJDEPGLELJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000169")]
	public NativeArray<Color> ONPANKAMIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400016A")]
	public NativeArray<int> OKJGNDNAAOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400016B")]
	public NativeArray<int> OJLOCBGHFAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	public NativeArray<int> PKJBLPBFCND;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400016D")]
	public NativeArray<int> DMGFAGDFMJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400016E")]
	public NativeArray<bool> ACOJGBCIENJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400016F")]
	public NativeArray<int> NAFKDFAKHJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000170")]
	public NativeArray<int> PIOJDNBOFHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x4000171")]
	public NativeArray<BoneWeight> GMCKGCKGAIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private NativeArray<Matrix4x4> ALOJODODJNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x4000173")]
	private NativeArray<int> ELJHIHHLKDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x4000174")]
	private NativeArray<byte> OGJJMKNBNDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x4000175")]
	private NativeArray<int> DGLOCEHLPKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x4000176")]
	private NativeArray<int> MBFCIBNNALC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x4000177")]
	public NativeArray<sbyte> KJNPPOLAEKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x4000178")]
	public NativeArray<byte> PHEECDEMMNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x4000179")]
	private NativeArray<int> JIEPDJLDJBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x400017A")]
	private bool PMAKKAFMGHO;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public int JIJKOHILKBL
	{
		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x20DE2D0", Offset = "0x20DCCD0", VA = "0x1820DE2D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public int CACMJOAFFJP
	{
		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x11AA9A0", Offset = "0x11A93A0", VA = "0x1811AA9A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public int OPHNDAKFLHH
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x6A48FA0", Offset = "0x6A479A0", VA = "0x186A48FA0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	public int CMANGOKIJOI
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x6A48FD0", Offset = "0x6A479D0", VA = "0x186A48FD0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(RVA = "0x6A487C0", Offset = "0x6A471C0", VA = "0x186A487C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public int FJEDHBOPAJL
	{
		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6A48FE0", Offset = "0x6A479E0", VA = "0x186A48FE0")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000130")]
		[Cpp2IlInjected.Address(RVA = "0x6A48F80", Offset = "0x6A47980", VA = "0x186A48F80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public int ANLDBEKLOOP
	{
		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x6A48F70", Offset = "0x6A47970", VA = "0x186A48F70")]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x6A48F90", Offset = "0x6A47990", VA = "0x186A48F90")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public PGMCADPPNDC AOCGOHAKNKD
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x6A49000", Offset = "0x6A47A00", VA = "0x186A49000")]
		get
		{
			return default(PGMCADPPNDC);
		}
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x6A48FF0", Offset = "0x6A479F0", VA = "0x186A48FF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public byte KKCJNPDDBKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x6A487D0", Offset = "0x6A471D0", VA = "0x186A487D0")]
		get
		{
			return default(byte);
		}
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x6A48D00", Offset = "0x6A47700", VA = "0x186A48D00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public BPGHDAHHJLD MJCLDFCFNGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x6A487E0", Offset = "0x6A471E0", VA = "0x186A487E0")]
		get
		{
			return default(BPGHDAHHJLD);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x6A490E0", Offset = "0x6A47AE0", VA = "0x186A490E0")]
	public BECLDIKOBPD(IList<Mesh> IEDHCLBPBDH, IList<Matrix4x4> GIJCGJKCCKC, IList<bool> ACOJGBCIENJ, byte GAPNAFGCLPM, IList<byte[]> ELNEKBOPLAH, IList<int> NNHKCKHKHAB, IList<bool> OOFLMBDANFK, IList<int> NAFKDFAKHJG, IList<int> BFIBIGDOGCK, IList<int> FMJGIENFDGA, Allocator MDICAPEDFAK, PGMCADPPNDC DPFAONFNIDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x6A49010", Offset = "0x6A47A10", VA = "0x186A49010")]
	public IBLOPKGEONA NNCEMHLAHBO(Allocator MDICAPEDFAK)
	{
		return default(IBLOPKGEONA);
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x6A48D10", Offset = "0x6A47710", VA = "0x186A48D10", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
[PLAFBFJHEAK]
public class OOPDMMENJDA : HDGPBEOLHKF
{
	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x6A4E500", Offset = "0x6A4CF00", VA = "0x186A4E500")]
	public BECLDIKOBPD NPHHKCLMNCO()
	{
		return default(BECLDIKOBPD);
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x6A40C30", Offset = "0x6A3F630", VA = "0x186A40C30")]
	public OOPDMMENJDA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public struct BPGHDAHHJLD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400017D")]
	public NativeSlice<Vector3> DBNAEKNAGJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017E")]
	public NativeSlice<Vector3> LABFLHMCLEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400017F")]
	public NativeSlice<Vector4> IIHDJPGJDHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000180")]
	public NativeSlice<Vector2> JCMOOBJCHNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	public NativeSlice<Vector2> FFKFNFFNCGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000182")]
	public NativeSlice<Vector2> JOJAOKKGJPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public NativeSlice<Vector2> HDJDEPGLELJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000184")]
	public NativeSlice<Color> ONPANKAMIJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000185")]
	public NativeSlice<int> FFDHJPBFFGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	public NativeSlice<int> DMGFAGDFMJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000187")]
	public NativeSlice<BoneWeight> GMCKGCKGAIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000188")]
	public NativeSlice<byte> CFIGGPGOAEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000189")]
	public int BILAKJPPFBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
	[Cpp2IlInjected.Token(Token = "0x400018A")]
	public Matrix4x4 DAKKCFIAEBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x104")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	public int BKLPIMAKDHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x400018C")]
	public NativeSlice<byte> JDPIOINPAKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x400018D")]
	public bool OGGCDAHIGDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11C")]
	[Cpp2IlInjected.Token(Token = "0x400018E")]
	public int MNCLONDAIJA;
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
internal readonly struct OCAFHAFHPLD : IEquatable<OCAFHAFHPLD>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400018F")]
	internal readonly Material CKDAEMELGPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000190")]
	internal readonly GOBJOHNJDAK PDBIHNDGANF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000191")]
	internal readonly FOMLDJLGFFP KKKDFHKLJMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000192")]
	internal readonly PLGDACFFJCI DLDNODOBJNL;

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0xB9A070", Offset = "0xB98A70", VA = "0x180B9A070")]
	public OCAFHAFHPLD(Material MLMFHAHBCEC, GOBJOHNJDAK BNCHIKHAIDG, FOMLDJLGFFP GGKKPKHIDLK, PLGDACFFJCI IIACJIKFNAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x6A4DF10", Offset = "0x6A4C910", VA = "0x186A4DF10", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0xB99D20", Offset = "0xB98720", VA = "0x180B99D20", Slot = "4")]
	public bool Equals(OCAFHAFHPLD AIPFCMFLDKG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x6A4DD80", Offset = "0x6A4C780", VA = "0x186A4DD80", Slot = "0")]
	public override bool Equals(object GIGIFGONEAO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000144")]
	[Cpp2IlInjected.Address(RVA = "0x6A4DE70", Offset = "0x6A4C870", VA = "0x186A4DE70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class AGPOMHAFLJO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000193")]
	private MaterialPropertyBlock FAGJCNMAGCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	public Color? PJDMLODKBBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000195")]
	public Color? IANBPFIBPCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000196")]
	public Color? BGNEFFHODFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
	[Cpp2IlInjected.Token(Token = "0x4000197")]
	public Color? LGOKDEAAIEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000198")]
	public Color GOIIFGOMDIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000199")]
	public Color CKLCLJFAOON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400019A")]
	public Color KJEHBDAEENH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400019B")]
	public Texture2D JHJBPNINOAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400019C")]
	public Texture2D BEEOPJKENEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400019D")]
	private Dictionary<OCAFHAFHPLD, int> ELCLOMHBFPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400019E")]
	private GOBJOHNJDAK[] IILDIPHKFKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private FOMLDJLGFFP[] NIOJOOPKMMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	public Vector4[] CEKEEPKAFME;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	public Vector4[] PALNDNMILKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	public Vector4[] FPKMDEKLEHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x40001A3")]
	public Vector4[] IGBACJFEIKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x40001A4")]
	public Vector4[] LEIMCPPPGKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x40001A5")]
	public Vector4[] JMAPPDOFHAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF0")]
	[Cpp2IlInjected.Token(Token = "0x40001A6")]
	private List<Texture2D> PMIBBCEOJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xF8")]
	[Cpp2IlInjected.Token(Token = "0x40001A7")]
	private Vector4[] HFBHCMAIINA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x100")]
	[Cpp2IlInjected.Token(Token = "0x40001A8")]
	private List<Texture2D> CDJHBJEEPGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x108")]
	[Cpp2IlInjected.Token(Token = "0x40001A9")]
	private float[] BKEAIDGLLOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x110")]
	[Cpp2IlInjected.Token(Token = "0x40001AA")]
	private Vector4[] JGDIKNHBKNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x118")]
	[Cpp2IlInjected.Token(Token = "0x40001AB")]
	private float[] CFDNOEDCIBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x120")]
	[Cpp2IlInjected.Token(Token = "0x40001AC")]
	public float[] OHGBMLPJKNA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x128")]
	[Cpp2IlInjected.Token(Token = "0x40001AD")]
	private List<Texture2D> IFPEHMAEHMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x130")]
	[Cpp2IlInjected.Token(Token = "0x40001AE")]
	private float[] CNJHLFPGJKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x138")]
	[Cpp2IlInjected.Token(Token = "0x40001AF")]
	private List<Texture2D> JPFECOJPABC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x140")]
	[Cpp2IlInjected.Token(Token = "0x40001B0")]
	private Vector4[] MGEFEFJDLDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x148")]
	[Cpp2IlInjected.Token(Token = "0x40001B1")]
	private float[] HFOEMMOOFJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x150")]
	[Cpp2IlInjected.Token(Token = "0x40001B2")]
	private Vector4[] KCCCMAJEEOD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x158")]
	[Cpp2IlInjected.Token(Token = "0x40001B3")]
	public float[] DJODMENACBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x160")]
	[Cpp2IlInjected.Token(Token = "0x40001B4")]
	public Texture2DArray JPCDDMLAGPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x168")]
	[Cpp2IlInjected.Token(Token = "0x40001B5")]
	public Texture2DArray CFNKAEIMBBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x170")]
	[Cpp2IlInjected.Token(Token = "0x40001B6")]
	public Texture2DArray KGJDDLGJHCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x178")]
	[Cpp2IlInjected.Token(Token = "0x40001B7")]
	public Texture2DArray BFOHGJLDIPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x180")]
	[Cpp2IlInjected.Token(Token = "0x40001B8")]
	private bool ODMBAPIBKEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x184")]
	[Cpp2IlInjected.Token(Token = "0x40001B9")]
	private int GCIBPOBADMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x188")]
	[Cpp2IlInjected.Token(Token = "0x40001BA")]
	private Vector2? KFIBGMOJAFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x194")]
	[Cpp2IlInjected.Token(Token = "0x40001BB")]
	private TextureFormat NLBBFPCMEOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x198")]
	[Cpp2IlInjected.Token(Token = "0x40001BC")]
	private Vector2? MIIOKALNNFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A4")]
	[Cpp2IlInjected.Token(Token = "0x40001BD")]
	private TextureFormat CJKOEFNLDHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1A8")]
	[Cpp2IlInjected.Token(Token = "0x40001BE")]
	private Vector2? MCJGCGHPANH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B4")]
	[Cpp2IlInjected.Token(Token = "0x40001BF")]
	private TextureFormat EKAKGFNDMDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1B8")]
	[Cpp2IlInjected.Token(Token = "0x40001C0")]
	private Vector2? OEKOEIKANPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C4")]
	[Cpp2IlInjected.Token(Token = "0x40001C1")]
	private TextureFormat EOPHAAEJOIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C8")]
	[Cpp2IlInjected.Token(Token = "0x40001C2")]
	private bool PJOLCHEBHAJ;

	[Cpp2IlInjected.Token(Token = "0x40001C3")]
	private static int HLHIKEMHIKD;

	[Cpp2IlInjected.Token(Token = "0x40001C4")]
	private static int PEPMDHBGFNA;

	[Cpp2IlInjected.Token(Token = "0x40001C5")]
	private static int CFLEKBGEKIN;

	[Cpp2IlInjected.Token(Token = "0x40001C6")]
	private static int JMIJGIHGKMO;

	[Cpp2IlInjected.Token(Token = "0x40001C7")]
	private static int ODINGMDAFLO;

	[Cpp2IlInjected.Token(Token = "0x40001C8")]
	private static int HGGNGNIJPGI;

	[Cpp2IlInjected.Token(Token = "0x40001C9")]
	private static int BOGKMOKDICM;

	[Cpp2IlInjected.Token(Token = "0x40001CA")]
	private static int JGHDBGFLJDC;

	[Cpp2IlInjected.Token(Token = "0x40001CB")]
	private static int JNLNBGOIFEB;

	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private static int ANPJBBPPOHF;

	[Cpp2IlInjected.Token(Token = "0x40001CD")]
	private static int PGIIGGHKHON;

	[Cpp2IlInjected.Token(Token = "0x40001CE")]
	private static int PDKKMIFGGFK;

	[Cpp2IlInjected.Token(Token = "0x40001CF")]
	private static int LBHALCGKFAF;

	[Cpp2IlInjected.Token(Token = "0x40001D0")]
	private static int NFELDCCPGKD;

	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private static int LDPPPGIDODB;

	[Cpp2IlInjected.Token(Token = "0x40001D2")]
	private static int MGAPIBLEAKP;

	[Cpp2IlInjected.Token(Token = "0x40001D3")]
	private static int JLEGCMLAHHO;

	[Cpp2IlInjected.Token(Token = "0x40001D4")]
	private static int EKAKHMBNCAC;

	[Cpp2IlInjected.Token(Token = "0x40001D5")]
	private static int PPNJCIFNFHJ;

	[Cpp2IlInjected.Token(Token = "0x40001D6")]
	private static int IHMPBKCAOFL;

	[Cpp2IlInjected.Token(Token = "0x6000145")]
	[Cpp2IlInjected.Address(RVA = "0x6A475A0", Offset = "0x6A45FA0", VA = "0x186A475A0")]
	private AGPOMHAFLJO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000146")]
	[Cpp2IlInjected.Address(RVA = "0x6A47A90", Offset = "0x6A46490", VA = "0x186A47A90")]
	public AGPOMHAFLJO(Color DBBPKOMDCHL, Color LBJJAOPJKDD, Color FNCIKOFDNML, Color? GFLHKONNICC, Color? KCICDOADIMK, Color? JGGEHHJDMBJ, Texture2D LOFLKBHDFIJ, Texture2D HGFILOBBHHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x6A46ED0", Offset = "0x6A458D0", VA = "0x186A46ED0")]
	internal int NIIBCPBFLOI(Material PPHBNABBBKC, GOBJOHNJDAK BNCHIKHAIDG, FOMLDJLGFFP GGKKPKHIDLK, PLGDACFFJCI IIACJIKFNAK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x6A46FC0", Offset = "0x6A459C0", VA = "0x186A46FC0")]
	private int NIIBCPBFLOI(OCAFHAFHPLD JODEIIFHAPK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x6A45F70", Offset = "0x6A44970", VA = "0x186A45F70")]
	internal int DGLBFEFGPPG(Material PPHBNABBBKC, Color KFFAOFGKEMD, Color ECOHHPEEIMN, Color HGAGKPJHAPK, Color ODKFAJMKCIN, Color OMFDOHGLOHK, Texture2D ILEMMKONCCF, Vector4 ILOKOKDCFHH, Texture2D JGLELAPIIFJ, Vector4 DMHBGDEMEFF, float OIHMBAKHHOD, float JGMEPIIIKLD, Texture2D AHODDKPFBFD, Vector4 GNJFKJEPNBF, float EOOGDKHOHEP, Texture2D FNKNHCBHDBB, Color MIPEGFIHKLL, Vector4 NODOBEKBMFD, GOBJOHNJDAK BNCHIKHAIDG, FOMLDJLGFFP GGKKPKHIDLK, PLGDACFFJCI IIACJIKFNAK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x6A44F90", Offset = "0x6A43990", VA = "0x186A44F90")]
	private void ALPGIBPAOFD(List<Texture2D> PMIBBCEOJIO, [Out] Texture2DArray GFANJNAFOIL, [Out] Texture2DArray DLGEINOJHKG, [Out] Texture2DArray OMCALOFPKAI, [Out] Texture2DArray BAALKDJACOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x6A46B80", Offset = "0x6A45580", VA = "0x186A46B80")]
	public void HBOHBDJMAIM(Shader LDGPJINEOFI, Renderer AAPNFNNCHNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x6A45250", Offset = "0x6A43C50", VA = "0x186A45250")]
	private void CDCLGMDAIHH(Shader LDGPJINEOFI, Renderer AAPNFNNCHNO, int FKKGFJNBJOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x6A46CD0", Offset = "0x6A456D0", VA = "0x186A46CD0")]
	private Color JDNFEHDJDDH(Color GFJGAPGIJMD, GOBJOHNJDAK AMFEJHMJAGG)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x6A47050", Offset = "0x6A45A50", VA = "0x186A47050")]
	private Color NKBHIMINFFI(Color GIKPJAGCEBB, GOBJOHNJDAK AMFEJHMJAGG)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(RVA = "0x6A45150", Offset = "0x6A43B50", VA = "0x186A45150")]
	private bool BCBDAALJGGC(Texture2D OLOFGKKHOFA, FOMLDJLGFFP GKGEOCLKLLI, [Out] Texture2D AEBJJIAGEKB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(RVA = "0x6A471A0", Offset = "0x6A45BA0", VA = "0x186A471A0")]
	private void PPCHBNBGBKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000151")]
	[Cpp2IlInjected.Address(RVA = "0x6A46B40", Offset = "0x6A45540", VA = "0x186A46B40", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public static class OFHLAPEFCCI
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	[CompilerGenerated]
	private sealed class LEBPIKPANDP : IEnumerator<IHLHBLBKNMF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private IHLHBLBKNMF <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D9")]
		public JobHandle handle;

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		private IHLHBLBKNMF System.Collections.Generic.IEnumerator<RecRoom.Core.ISchedule>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x886780", Offset = "0x885180", VA = "0x180886780", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x88DF90", Offset = "0x88C990", VA = "0x18088DF90")]
		[DebuggerHidden]
		public LEBPIKPANDP(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0xBB8390", Offset = "0xBB6D90", VA = "0x180BB8390", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x6A4DD30", Offset = "0x6A4C730", VA = "0x186A4DD30", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000153")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230")]
	public static void PMNIPIOONFH(string KFBALBFDDFF, int NDKONLLHKBF, long IKBOKFBMGJF, long PDAIDILGBPF, long PMILLAJKCJI, long APGLKFEGFOP, long HALFBEACFDD, long JDKEGKHGNGP, long NDOBAOOADJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000154")]
	[Cpp2IlInjected.Address(RVA = "0x6A4E340", Offset = "0x6A4CD40", VA = "0x186A4E340")]
	public static DABMKCAGAIA GDMFMFEKHOC(JobHandle LLFNOODONNB, bool NEJBJLGJLBP, bool HMKFBIADCHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x6A4E490", Offset = "0x6A4CE90", VA = "0x186A4E490")]
	[IteratorStateMachine(typeof(LEBPIKPANDP))]
	private static IEnumerator<IHLHBLBKNMF> NKGDMFHFEKB(JobHandle OMKGKCDECFC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class AMKGJCLDCFE : CDPLPEKILNE, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001DA")]
	private HNGNMNOAGJK JKMEKPJIILO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40001DB")]
	private KOFFCHIBFCN LCIIPIBHHGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40001DC")]
	private IRecRoomQualityConfigProvider POHHPCDJCEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40001DD")]
	private bool PMAKKAFMGHO;

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x6A480B0", Offset = "0x6A46AB0", VA = "0x186A480B0")]
	[POCMGODEOKB.GGOFPJDKHFE.NHEEFPAGIJC]
	internal static void HPJGKMOFOOB(APIKLLPBEEI PLCAFBBHOLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x5D61710", Offset = "0x5D60110", VA = "0x185D61710")]
	[UnityEngine.Scripting.Preserve]
	public AMKGJCLDCFE([CNNDHKODGDP(null)] KOFFCHIBFCN LDFLDEGAHPL, [CNNDHKODGDP(null)] HNGNMNOAGJK APPCFGJDPFG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x6A48020", Offset = "0x6A46A20", VA = "0x186A48020")]
	private void CGAJCLCAOGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(RVA = "0x6A481B0", Offset = "0x6A46BB0", VA = "0x186A481B0", Slot = "4")]
	public void LOKFFKDLEJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000161")]
	[Cpp2IlInjected.Address(RVA = "0x6A47B50", Offset = "0x6A46550", VA = "0x186A47B50", Slot = "5")]
	public FGDPIAEELFA<Texture2D> BBNPABPLIBN(CLBJJJHJFPD MOIMLHGDDBP, [Optional] HPOMCNJDPHM APDNBDIKMDG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x6A48230", Offset = "0x6A46C30", VA = "0x186A48230")]
	private uint PPLAJDGLIKE(CLBJJJHJFPD MOIMLHGDDBP, HPOMCNJDPHM APDNBDIKMDG)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public interface DJMPODNLHCI
{
	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void NLJICFCGPJA(Mesh ANBKEJJPIHH, Matrix4x4 ECNJMMKOLMG, byte[] JDPIOINPAKB, bool DPKFNEJEEGG = false, MJONKEEGKHL.OANEACHHLDN BIHCBJJLGOE = (MJONKEEGKHL.OANEACHHLDN)0, int NAFKDFAKHJG = -1, bool ACOJGBCIENJ = false);

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "1")]
	void FCIFLCCDLAK(Allocator MDICAPEDFAK, PGMCADPPNDC DPFAONFNIDP, byte GAPNAFGCLPM, [Optional] IList<int> BFIBIGDOGCK, [Optional] IList<int> OGDBGLFFKEI);
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public readonly struct AGMFAOFOCLJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40001E0")]
	public readonly GameObject LGEGPOAODCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40001E1")]
	private readonly AvatarItemMaterial BNJGBGDBLCA;

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0xC4E920", Offset = "0xC4D320", VA = "0x180C4E920")]
	public AGMFAOFOCLJ(GameObject LGEGPOAODCJ, AvatarItemMaterial BNJGBGDBLCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x6A44D80", Offset = "0x6A43780", VA = "0x186A44D80")]
	public void OPLGCHAPMLH(Material MLMFHAHBCEC, int ALFOCGJIHEG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class AFPDFBBAJPK : NMIGKGCBFJE<Task<(GameObject, AvatarItemMaterial)>, AGMFAOFOCLJ>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private struct JKOOMHNCKCJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001E6")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001E7")]
		public AsyncTaskMethodBuilder<(GameObject, AvatarItemMaterial)> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001E8")]
		public Task<GameObject> goTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001E9")]
		public Task<AvatarItemMaterial> materialTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EA")]
		private GameObject <go>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001EB")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001EC")]
		private TaskAwaiter<GameObject> <>u__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001ED")]
		private TaskAwaiter<AvatarItemMaterial> <>u__3;

		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x6A4D7C0", Offset = "0x6A4C1C0", VA = "0x186A4D7C0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x6A4DCC0", Offset = "0x6A4C6C0", VA = "0x186A4DCC0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40001E2")]
	private FGDPIAEELFA<GameObject> BCMENOJCLCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001E3")]
	private FGDPIAEELFA<AvatarItemMaterial> ANBMBCHKFGJ;

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x6A44CF0", Offset = "0x6A436F0", VA = "0x186A44CF0")]
	private AFPDFBBAJPK(Task<(GameObject, AvatarItemMaterial)> CCAACFNOONL, FGDPIAEELFA<GameObject> CBLJOMKGEFI, FGDPIAEELFA<AvatarItemMaterial> PFNNHKCMCBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x6A446A0", Offset = "0x6A430A0", VA = "0x186A446A0")]
	public static AFPDFBBAJPK IFAFEFDLIPC(AssetReference FDIEMAHDNDG, [Optional] AssetReference FDACOIMABNH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x6A44C50", Offset = "0x6A43650", VA = "0x186A44C50", Slot = "11")]
	protected override AGMFAOFOCLJ OGMAHNLOGAJ(Task<(GameObject, AvatarItemMaterial)> HELKEHCFKFA)
	{
		return default(AGMFAOFOCLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x6A44AA0", Offset = "0x6A434A0", VA = "0x186A44AA0", Slot = "12")]
	protected override void KFMGNINKLBH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6A44B20", Offset = "0x6A43520", VA = "0x186A44B20")]
	[AsyncStateMachine(typeof(JKOOMHNCKCJ))]
	private static Task<(GameObject, AvatarItemMaterial)> MFPGPPGFCKI(Task<GameObject> LOGOHGJHOOM, Task<AvatarItemMaterial> EAIMJBNDEPL)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class HBMEAIKIKLH
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	private class PEJALDGOKHP : NMIGKGCBFJE<Task<MaterialMapAsset>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001EF")]
		private FGDPIAEELFA<MaterialMapAsset> OMKGKCDECFC;

		[Cpp2IlInjected.Token(Token = "0x6000176")]
		[Cpp2IlInjected.Address(RVA = "0x6A4EA70", Offset = "0x6A4D470", VA = "0x186A4EA70")]
		public PEJALDGOKHP(FGDPIAEELFA<MaterialMapAsset> OMKGKCDECFC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000177")]
		[Cpp2IlInjected.Address(RVA = "0x6A4E650", Offset = "0x6A4D050", VA = "0x186A4E650", Slot = "11")]
		protected override Material[] OGMAHNLOGAJ(Task<MaterialMapAsset> CCAACFNOONL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000178")]
		[Cpp2IlInjected.Address(RVA = "0x6A4E5F0", Offset = "0x6A4CFF0", VA = "0x186A4E5F0", Slot = "12")]
		protected override void KFMGNINKLBH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	private class OFEGABPMIAL : NMIGKGCBFJE<Task<Material[]>, Material[]>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001F4")]
		private List<FGDPIAEELFA<Material>> AJBLMIKCHLB;

		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x6A4E2D0", Offset = "0x6A4CCD0", VA = "0x186A4E2D0")]
		public OFEGABPMIAL(Task<Material[]> CCAACFNOONL, List<FGDPIAEELFA<Material>> AJBLMIKCHLB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017F")]
		[Cpp2IlInjected.Address(RVA = "0x6A4E280", Offset = "0x6A4CC80", VA = "0x186A4E280", Slot = "11")]
		protected override Material[] OGMAHNLOGAJ(Task<Material[]> HELKEHCFKFA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000180")]
		[Cpp2IlInjected.Address(RVA = "0x6A4E140", Offset = "0x6A4CB40", VA = "0x186A4E140", Slot = "12")]
		protected override void KFMGNINKLBH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40001EE")]
	private static readonly ANDGIEDMMDP AGICKJCJECJ;

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x6A4C4A0", Offset = "0x6A4AEA0", VA = "0x186A4C4A0")]
	public static FGDPIAEELFA<Material[]> OPKKCNLBEIK(AssetReference[] BODBMIGKBHG)
	{
		return null;
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class SkinnedMeshBonesInspector : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001F7")]
		[EHNJJNMEJEA(BILCJMODHFE.Self, false, false, false)]
		[SerializeField]
		private SkinnedMeshRenderer skinnedMeshRenderer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001F8")]
		[SerializeField]
		private int BoneWeightsDisplayStart;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40001F9")]
		[SerializeField]
		private int BoneWeightsDisplayAmount;

		[Cpp2IlInjected.Token(Token = "0x6000184")]
		[Cpp2IlInjected.Address(RVA = "0x6A4EB50", Offset = "0x6A4D550", VA = "0x186A4EB50")]
		public SkinnedMeshBonesInspector()
		{
		}
	}
}
namespace RecRoom.Avatars.Face
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public sealed class FaceStyleSet : ScriptableObject
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[CompilerGenerated]
		private struct CNPDLBFMFKD : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000207")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000208")]
			public AsyncTaskMethodBuilder<JDECACOCKCL> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x4000209")]
			public FaceStyleSet <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x400020A")]
			public int eyeBrows;

			[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
			[Cpp2IlInjected.Token(Token = "0x400020B")]
			public int eye;

			[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
			[Cpp2IlInjected.Token(Token = "0x400020C")]
			public int mouth;

			[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
			[Cpp2IlInjected.Token(Token = "0x400020D")]
			private TaskAwaiter<JDECACOCKCL> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000190")]
			[Cpp2IlInjected.Address(RVA = "0x6A4A900", Offset = "0x6A49300", VA = "0x186A4A900", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x6A4AC40", Offset = "0x6A49640", VA = "0x186A4AC40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001FA")]
		public SymmetricalFaceFeature[] EyeBrows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001FB")]
		public EyesFaceFeature[] Eyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001FC")]
		public NoseFaceOption[] Noses;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001FD")]
		public FaceFeature[] Mouths;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001FE")]
		[Header("Default Values")]
		public SymmetricalFaceFeature DefaultEyeBrowsFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001FF")]
		public EyesFaceFeature DefaultEyesFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000200")]
		public FaceFeature DefaultMouthFeature;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000201")]
		private Dictionary<IIEBDBDHLOD, SymmetricalFaceFeature> eyeBrowFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000202")]
		private Dictionary<IIEBDBDHLOD, EyesFaceFeature> eyeFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000203")]
		private Dictionary<IIEBDBDHLOD, NoseFaceOption> noseOptionsDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000204")]
		private Dictionary<IIEBDBDHLOD, FaceFeature> mouthFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000205")]
		private readonly Dictionary<IIEBDBDHLOD, int> featureToIndexMap;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000206")]
		private JDECACOCKCL _defaultFaceStyle;

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		private bool dictionariesInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000185")]
			[Cpp2IlInjected.Address(RVA = "0x6A4B560", Offset = "0x6A49F60", VA = "0x186A4B560")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000186")]
		[Cpp2IlInjected.Address(RVA = "0x6A4AF60", Offset = "0x6A49960", VA = "0x186A4AF60")]
		public JDECACOCKCL FAMNFAIGKOA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000187")]
		[Cpp2IlInjected.Address(RVA = "0x6A4ACB0", Offset = "0x6A496B0", VA = "0x186A4ACB0")]
		[AsyncStateMachine(typeof(CNPDLBFMFKD))]
		public Task<JDECACOCKCL> AHEKMHJDANP(int GJCACLKGMOK, int CKMDNFBMIPI, int DCLLGEIGGEJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x6A4B310", Offset = "0x6A49D10", VA = "0x186A4B310")]
		public NoseFaceOption MJKHJIMLOKE(int IHOHFJJDOBG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0x6A4ADE0", Offset = "0x6A497E0", VA = "0x186A4ADE0")]
		public SelectableFaceOption EPFODDLNHHE(FaceFeatureType CCDECPBNDJK, IIEBDBDHLOD BIFJALBNKHB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x6A4AFB0", Offset = "0x6A499B0", VA = "0x186A4AFB0")]
		public int GMCOOJLEKLM(IIEBDBDHLOD BIFJALBNKHB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x6A4B030", Offset = "0x6A49A30", VA = "0x186A4B030")]
		private void GOAKPLPDBAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x2C7BEB0", Offset = "0x2C7A8B0", VA = "0x182C7BEB0")]
		private void PHKMDHFJCPH<T>(IDictionary<IIEBDBDHLOD, T> EDBFMFKGPOA, IReadOnlyList<T> JBKELKENMJH) where T : SelectableFaceOption
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x6A4B260", Offset = "0x6A49C60", VA = "0x186A4B260")]
		public IIEBDBDHLOD IEFLMOPMEAC(FaceFeatureType CCDECPBNDJK)
		{
			return default(IIEBDBDHLOD);
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x6A4B3B0", Offset = "0x6A49DB0", VA = "0x186A4B3B0")]
		public IIEBDBDHLOD POEJLIILJKE(FaceFeatureType CCDECPBNDJK)
		{
			return default(IIEBDBDHLOD);
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x6A4B4D0", Offset = "0x6A49ED0", VA = "0x186A4B4D0")]
		public FaceStyleSet()
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
