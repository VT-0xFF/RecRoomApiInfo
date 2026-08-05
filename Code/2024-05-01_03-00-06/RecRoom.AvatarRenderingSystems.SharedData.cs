using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Cpp2IlInjected;
using RecRoom.AssetIds;
using RecRoom.Attributes;
using RecRoom.Avatars;
using RecRoom.Avatars.Face;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Serialization;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface BHFIAEPJAFH
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	float PCJAFGMOBFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	float DPJEIILBLIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	float NAMHADOMGIK
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	float AEHJNNPGNPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float AGHPCNJBJGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	float HDMGMKNAJEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float LIOGCLBHCAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float DKINEDAOAKN
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float ODKFGBDHBPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	float OGFNKEIAOOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	float GBGCCEGNLNF
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	float NEGOHACHNED
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	float CANGBNNLIHC
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	float CCAFPHKBBHN
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	float FCJEJEJDDFO
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	float PFMMFDILPOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Vector3 JNAKGDNKMDE(Vector3 JCKPLDNDGDC);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Vector3 FNBEMMEFKNL(Vector3 ICOHOPJGHPH);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Vector3 MANGACJDBMM();
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class AnchorParamsRestrictions : BHFIAEPJAFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public bool AllowTranslation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public bool AllowRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public float DefaultOffsetX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public float MinXOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public float MaxXOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public float DefaultOffsetY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public float MinYOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public float MaxYOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public float DefaultOffsetZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public float MinZOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public float MaxZOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public float DefaultRotationX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public float RightRotationFreedomX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public float LeftRotationFreedomX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public float DefaultRotationY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public float RightRotationFreedomY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public float LeftRotationFreedomY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public float DefaultRotationZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public float RightRotationFreedomZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public float LeftRotationFreedomZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public float MaxUCoordinate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public float MinUCoordinate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public float MaxVCoordinate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public float MinVCoordinate;

		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public const float DEFAULT_MIN_OFFSET = -0.1f;

		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public const float DEFAULT_MAX_OFFSET = 0.1f;

		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public const float DEFAULT_ROTATION_FREEDOM = 180f;

		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public const float DEFAULT_MIN_UV_COORDINATE = 0f;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public const float DEFAULT_MAX_UV_COORDINATE = 1f;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool GetAllowTranslations
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x801870", Offset = "0x800670", VA = "0x180801870", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool GetAllowRotations
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xA0E340", Offset = "0xA0D140", VA = "0x180A0E340", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x938680", Offset = "0x937480", VA = "0x180938680", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x9EF930", Offset = "0x9EE730", VA = "0x1809EF930", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8F3690", Offset = "0x8F2490", VA = "0x1808F3690", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x975DA0", Offset = "0x974BA0", VA = "0x180975DA0", Slot = "7")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x888B00", Offset = "0x887900", VA = "0x180888B00", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7DFAB0", Offset = "0x7DE8B0", VA = "0x1807DFAB0", Slot = "9")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0xA27B90", Offset = "0xA26990", VA = "0x180A27B90", Slot = "12")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x1127190", Offset = "0x1125F90", VA = "0x181127190", Slot = "13")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x92F240", Offset = "0x92E040", VA = "0x18092F240", Slot = "10")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xC662B0", Offset = "0xC650B0", VA = "0x180C662B0", Slot = "11")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x1B4D2C0", Offset = "0x1B4C0C0", VA = "0x181B4D2C0", Slot = "14")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xD054A0", Offset = "0xD042A0", VA = "0x180D054A0", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public float GetMaxUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xD054B0", Offset = "0xD042B0", VA = "0x180D054B0", Slot = "16")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public float GetMinUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xA6AEE0", Offset = "0xA69CE0", VA = "0x180A6AEE0", Slot = "17")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8BA4A0", Offset = "0x8B92A0", VA = "0x1808BA4A0", Slot = "18")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x7CA940", Offset = "0x7C9740", VA = "0x1807CA940", Slot = "19")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x60D8360", Offset = "0x60D7160", VA = "0x1860D8360")]
		public AnchorParamsRestrictions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x60D83F0", Offset = "0x60D71F0", VA = "0x1860D83F0")]
		public AnchorParamsRestrictions(NLIGFIJJNLM CGPMFEMKNAJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x60D7FD0", Offset = "0x60D6DD0", VA = "0x1860D7FD0")]
		public PMDHNMGMOEM JFCHJILMNAO(PMDHNMGMOEM BACPFIKIJKM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x60D8340", Offset = "0x60D7140", VA = "0x1860D8340", Slot = "25")]
		public Vector3 MINMHNCJFPP()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600002A")]
		[Cpp2IlInjected.Address(RVA = "0x60D8320", Offset = "0x60D7120", VA = "0x1860D8320", Slot = "22")]
		public Vector3 MANGACJDBMM()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x60D82B0", Offset = "0x60D70B0", VA = "0x1860D82B0", Slot = "20")]
		public Vector3 JNAKGDNKMDE(Vector3 JCKPLDNDGDC)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x60D7D90", Offset = "0x60D6B90", VA = "0x1860D7D90", Slot = "21")]
		public Vector3 FNBEMMEFKNL(Vector3 ICOHOPJGHPH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x60D7AF0", Offset = "0x60D68F0", VA = "0x1860D7AF0", Slot = "0")]
		public override bool Equals(object EIFMADKIHON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x60D7E10", Offset = "0x60D6C10", VA = "0x1860D7E10")]
		protected bool GPOBLKCLAFD(AnchorParamsRestrictions GGINNHLAMLI)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class BMDLMLPEJPH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private Transform[] DJHDOOBJGIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private readonly Dictionary<string, Transform> KEBMOCBPDAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private readonly Dictionary<Transform, Transform> IEEMFPLBELK;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public Transform[] JKNKOIDHIIN
	{
		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x7B1BD0", Offset = "0x7B09D0", VA = "0x1807B1BD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x60DA670", Offset = "0x60D9470", VA = "0x1860DA670")]
	public void PJEHBOOEFJP(Transform NPDECMDOJCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x60DA350", Offset = "0x60D9150", VA = "0x1860DA350")]
	public Transform NCDHKCFKPKA(Transform IEGLDEKGADF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000032")]
	[Cpp2IlInjected.Address(RVA = "0x60DA430", Offset = "0x60D9230", VA = "0x1860DA430")]
	public void NKGCMJBDNJI(SkinnedMeshRenderer IMBJJEHONAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000033")]
	[Cpp2IlInjected.Address(RVA = "0x60DA1A0", Offset = "0x60D8FA0", VA = "0x1860DA1A0")]
	private static void BBIBFPFNPBL(Transform GDOPFEEANMP, List<Transform> PBBEDHFJELM, Dictionary<string, Transform> BLGKJEDICCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000034")]
	[Cpp2IlInjected.Address(RVA = "0x60DA750", Offset = "0x60D9550", VA = "0x1860DA750")]
	public BMDLMLPEJPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class MEJCJKHPGID
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public bool MAFJDKCNMKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public bool DIKGDFIANBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public BEPKGBHJAIF? PNDHNHNDEPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public CPCJFDHFPLD.LCMFNGJPNFA LKFFCOHJLJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public Texture2D GIIKAGCLFAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public Texture2D ILLHCNGMFCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public IList<JAEIDGMCOAF> JDFIIEGGCJG;

	[Cpp2IlInjected.Token(Token = "0x6000035")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public MEJCJKHPGID()
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public abstract class AvatarConfiguration : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		[Header("Face Features")]
		[Tooltip("How far apart you can position your eyebrows.")]
		public Vector2 EyebrowsHorizontalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		[Tooltip("How far up and down you can position your eyebrows.")]
		public Vector2 EyebrowsVerticalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[Tooltip("How small/large you can scale your eyebrows.")]
		public Vector2 EyebrowsScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[Tooltip("How far apart can position your eyes.")]
		public Vector2 EyesHorizontalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[Tooltip("How far up and down you can position your eyes.")]
		public Vector2 EyesVerticalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[Tooltip("How small/large you can scale your eyes.")]
		public Vector2 EyeScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[Tooltip("How far left and right you can position your mouth.")]
		public Vector2 MouthHorizontalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[Tooltip("How far up and down you can position your mouth.")]
		public Vector2 MouthVerticalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		[Tooltip("How small/large you can scale your mouth.")]
		public Vector2 MouthScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[Tooltip("How far left and right you can position your nose.")]
		public Vector2 NoseHorizontalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[Tooltip("How far up and down you can position your nose.")]
		public Vector2 NoseVerticalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[Tooltip("How small/large you can scale your nose.")]
		public Vector2 NoseScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[Tooltip("A constant multiplier on all eye jitter.")]
		public Vector2 GlobalEyeJitterMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[Tooltip("A constant multiplier on all eye gleam jitter.")]
		public Vector2 GlobalEyeGleamJitterMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[Tooltip("A constant multiplier on all eyebrow jitter.")]
		public Vector2 GlobalEyebrowJitterMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[Tooltip("A constant multiplier on all mouth jitter.")]
		public Vector2 GlobalMouthJitterMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[Tooltip("Used to scale a face bone into UV space by scaling to the bone's (x,y) position")]
		public Vector2 ScaleFaceBonesToUVs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[Tooltip("Used to translate all face bone into UV space by adding the offset to the post-scaled bone (x,y) position")]
		public Vector2 TranslateFaceBonesToUVsOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[Tooltip("Used to translate the eye brow bones into UV space by adding to the post-scaled bone (x,y) position")]
		public Vector2 TranslateEyeBrowBonesToUVsOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[Tooltip("Used to translate the eye bones into UV space by adding to the post-scaled bone (x,y) position")]
		public Vector2 TranslateEyeBonesToUVsOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[Tooltip("Used to translate the mouth bones into UV space by adding to the post-scaled bone (x,y) position")]
		public Vector2 TranslateMouthBoneToUVsOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[Tooltip("Minimum distance used to decrowd eyes to brows in vertical UV space")]
		public float MinDistFromEyesToBrowsInUVVerticalSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[Tooltip("Minimum distance used to decrowd nose to eyes in vertical UV space")]
		public float MinDistFromNoseToEyesInUVVerticalSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[Tooltip("Minimum distance used to decrowd mouth to nose in vertical UV space")]
		public float MinDistFromMouthToNoseInUVVerticalSpace;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x60D84C0", Offset = "0x60D72C0", VA = "0x1860D84C0")]
		protected AvatarConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class BHMJCENDEMA
{
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	public static readonly JKACHIPLIBE MABHOGPHEJG;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public static PMDHNMGMOEM OGPJGFLNKOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x60D9F30", Offset = "0x60D8D30", VA = "0x1860D9F30")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct OMOLKENECLO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	public Transform JLDMPGDFIAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	public AssetReference NJGOHEFLKFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	public GameObject JFPEGOGCMJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public GameObject KFCLBHAHGJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public SkinnedMeshRenderer KNMMENGMCKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public Material HHDNLMPLAOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public Material FOIJGPINPIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public Material EDGHPGLAGKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public Shader OIDNEANNPKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public Shader DPDFJDMILGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public Animator FCILAIGCPDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public Renderer[] FDDPINPBJFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public AvatarConfiguration IHOJKINCMIJ;
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct DIAKCGKHGHK
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public SkinnedMeshRenderer[] EAFIFCGMCLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public SkinnedMeshRenderer[] IAGOBEJFGLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public SkinnedMeshRenderer[] JMGKJIPIGFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public SkinnedMeshRenderer[] PCLHDINOGNB;
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct BodySkinnedMeshLODs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public SkinnedMeshRenderer[] LODs;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct AvatarHairPatternOverride : ISerializationCallbackReceiver, IEquatable<AvatarHairPatternOverride>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		[Obsolete("Use HairPatternId instead!")]
		[FormerlySerializedAs("PatternGuid")]
		[SerializeField]
		private string patternGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public Texture2D Texture;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		[SerializeField]
		private SerializedHairPatternId hairPatternId;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public KMLPMOPGMKE HairPatternId
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x60D88A0", Offset = "0x60D76A0", VA = "0x1860D88A0")]
			get
			{
				return default(KMLPMOPGMKE);
			}
			[Cpp2IlInjected.Token(Token = "0x600003A")]
			[Cpp2IlInjected.Address(RVA = "0x60D88D0", Offset = "0x60D76D0", VA = "0x1860D88D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x60D8850", Offset = "0x60D7650", VA = "0x1860D8850")]
		public AvatarHairPatternOverride(KMLPMOPGMKE NEOFKHDFANM, Texture2D AOHFCHDJECC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x60D8810", Offset = "0x60D7610", VA = "0x1860D8810", Slot = "6")]
		public bool Equals(AvatarHairPatternOverride GGINNHLAMLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x60D8760", Offset = "0x60D7560", VA = "0x1860D8760", Slot = "0")]
		public override bool Equals(object EIFMADKIHON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x60D8840", Offset = "0x60D7640", VA = "0x1860D8840", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct NGIIEKPEOGO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public Transform HAJIENNHKNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public Transform KJHEBIFFJCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public Transform CKBHPMLBHHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public Transform OKACCFFLNPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public Transform KNIHICIDBPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public Transform LBONBNDCNMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public Transform NFBKMMAHAJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public AvatarConfiguration IHOJKINCMIJ;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct HBELCEIBMJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public SkinnedMeshRenderer[] LKMBNMBPIGD;
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct FGBLPFKFEMG
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public EECMHFMEFGK JLMKFGHGBEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public int NNJPDNDPCMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public int EDFMFHPJKAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public Color FAFMKIOEDFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public Color IJDHJKGJPEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public int DAFOFNINCEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public int IFOHDHAICDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public Color LIPADHKICBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public Color NJEBJMLLMFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public int HDLPPBKDBMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public float NDAIOPJEIJO;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct IFEPJBGCLOH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public EECMHFMEFGK JLMKFGHGBEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public Vector2 FGJOCHDNMKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public float OLIBDKOFLEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public Vector2 LKCCLOPCCNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public float BLPJCHHCGOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public Vector2 KCNGLODKBOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public float KPJGJFGLDIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public Vector2 EPNBOOOEJLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public float MIKKLGCNGCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public bool ILIIIMAGMDM;
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class JAEIDGMCOAF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public string HFBLFDGJOMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public OutfitType GNGFNLFHCKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public ECLNJFJJGAI HJOEMCAAFDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public CPCJFDHFPLD.LCMFNGJPNFA MOLJLKCPAOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public bool MBENLDPCMMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public bool KPJLAGPKMFO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public bool LAOHCLMLKJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public Color? HOKNMDEONDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public Guid? AKAIAFDBOJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public Color? ACDOHAPCABE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public bool DOOMMHECDCE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x65")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public bool HNBHLIEANHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public Transform JNKBENJDMPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public FitMeshHemisphere MFPHDHKLMAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public Vector2 HGHKFNLNIKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public AssetReference BPFNIGPKKNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public AssetReference NOGEDCGJNLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public AssetReference[] FLJOFNJJJMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public bool FHKNGFMANFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public bool BJLHCMAFKEE;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public string PFOIGBGDDFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x60DE110", Offset = "0x60DCF10", VA = "0x1860DE110")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x60DE110", Offset = "0x60DCF10", VA = "0x1860DE110", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x60DE1C0", Offset = "0x60DCFC0", VA = "0x1860DE1C0")]
	public JAEIDGMCOAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public class BPMIEPCDJJC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public SkinnedMeshRenderer BGFAMHDJCOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private Material[] FBMAHOBDLML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private byte[] BMEFEIEBCMM;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public Mesh LMCKPFBBINE
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x60DA820", Offset = "0x60D9620", VA = "0x1860DA820")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public Material[] KNAGIFBKGHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public byte[] KABKFCEGNAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x7B22D0", Offset = "0x7B10D0", VA = "0x1807B22D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x60DA9C0", Offset = "0x60D97C0", VA = "0x1860DA9C0")]
	public BPMIEPCDJJC(SkinnedMeshRenderer IMNCCBFJNNE, [Optional] Material[] LKNPHFCDGFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x60DA840", Offset = "0x60D9640", VA = "0x1860DA840")]
	public static BPMIEPCDJJC IHFLEPMJPEN(Renderer INJBJDLKFFP)
	{
		return null;
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct PositionAndRotation
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		public Vector3 Position;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public Quaternion Rotation;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public static PositionAndRotation Default
		{
			[Cpp2IlInjected.Token(Token = "0x6000049")]
			[Cpp2IlInjected.Address(RVA = "0xA40280", Offset = "0xA3F080", VA = "0x180A40280")]
			get
			{
				return default(PositionAndRotation);
			}
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class IFGCOLKKCPG
{
	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x60DD840", Offset = "0x60DC640", VA = "0x1860DD840")]
	public static PositionAndRotation NFEGKKEJINP(this PositionAndRotation LEBJODLGKNP)
	{
		return default(PositionAndRotation);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x60DD9A0", Offset = "0x60DC7A0", VA = "0x1860DD9A0")]
	public static float NLCNNKHDOOL(float HKJAKBPEJHH, Vector2 ICJEGJPHJAL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x60DDA40", Offset = "0x60DC840", VA = "0x1860DDA40")]
	public static float NLCNNKHDOOL(float HKJAKBPEJHH, float CGPMFEMKNAJ, float HPDLBBBABGA, float BKMAHFHDFAF)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x60DD6C0", Offset = "0x60DC4C0", VA = "0x1860DD6C0")]
	public static float CEGOHMEMKJB(float DIBNBLEEFNN, Vector2 ICJEGJPHJAL)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x60DD790", Offset = "0x60DC590", VA = "0x1860DD790")]
	public static float CEGOHMEMKJB(float DIBNBLEEFNN, float CGPMFEMKNAJ, float HPDLBBBABGA, float BKMAHFHDFAF)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class OIIAPEGKEGK
{
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public static readonly int DOIMPJBIKEP;

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public static readonly string BKBOMOCPIMO;
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum BBAEMEDDAKP
{
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	DoNotHideHair,
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	UseHelmetHair,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	AlwaysHideHair,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	HideHairToggleable
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum ECLNJFJJGAI
{
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	None = -1,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	Head,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	Torso,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	LeftHand,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	RightHand,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	Mouth,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	Legs,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	LeftFoot,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	RightFoot,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	FullBody,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	Nose,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	Face
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum MDNKCLMDPPG
{
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	SkinColor,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	PrimaryHairColor,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	SecondaryHairColor,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	PrimaryBeardColor,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	SecondaryBeardColor,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	UGCShirtColor,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	TeamColor,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	TeamEmissiveColor
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public enum OOEFNIKLCCO
{
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	HairPattern,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	BeardPattern
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum IACLPKIDDKN
{
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	TeamItem,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	SkinColor,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	HairColor,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	BeardColor,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	UGCShirtColor
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum JLGDBEPAMEA
{
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	HairTexture,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	BeardTexture,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	UGCShirtTexture
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum AAODJCMCBJN
{
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	CollapseSubMeshes,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	CollapseToUniqueMaterials,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	MergeAll
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public enum DCIGFAKEFGM
{
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	Base,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	Wide,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	Flat,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	Downturned,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	Hooked,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	Long,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	Upturned,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	None
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class AvatarSkinAssetItem : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200001E")]
		public enum DCKKKMJJBGA
		{
			[Cpp2IlInjected.Token(Token = "0x40000CE")]
			ScreenFirstPersonSkinMesh,
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			ThirdPersonSkinMesh,
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			VRFirstPersonSkinMesh,
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			NoseSkinMesh,
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			FaceSkinMesh
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		[SerializeField]
		private BodySkinnedMeshLODs screenFirstPersonBodySkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		[SerializeField]
		private BodySkinnedMeshLODs vrFirstPersonBodySkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		[SerializeField]
		private BodySkinnedMeshLODs thirdPersonBodySkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		[SerializeField]
		private NoseMeshConfiguration[] noseMeshConfigurations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		[SerializeField]
		private BodySkinnedMeshLODs facialSpritesSkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private Dictionary<BEPKGBHJAIF, BodySkinnedMeshLODs> BHDNDIBJOMG;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public BodySkinnedMeshLODs FDCPDDJKABH
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public BodySkinnedMeshLODs FLNPLINBMEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x7B22D0", Offset = "0x7B10D0", VA = "0x1807B22D0")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public BodySkinnedMeshLODs DHGCBAMOEIN
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x7B22C0", Offset = "0x7B10C0", VA = "0x1807B22C0")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public BodySkinnedMeshLODs NIEDAEFPOCC
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x7B1EF0", Offset = "0x7B0CF0", VA = "0x1807B1EF0")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x60D8CA0", Offset = "0x60D7AA0", VA = "0x1860D8CA0")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x60D8A10", Offset = "0x60D7810", VA = "0x1860D8A10")]
		public SkinnedMeshRenderer[] GetBodySkinnedMeshLODsByType(DCKKKMJJBGA IPAKHIBBENL, [Optional] BEPKGBHJAIF? IFJBMIAAOOG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x60D8DA0", Offset = "0x60D7BA0", VA = "0x1860D8DA0")]
		public AvatarSkinAssetItem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class CPCJFDHFPLD
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public enum BNDOPEKLCNC
	{
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		Head,
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		TorsoAll,
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		TorsoHigh,
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		TorsoLow,
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		SleevesShort,
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		SleevesLong,
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		DEPRECATED_Palm,
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		DEPRECATED_HandsAll,
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		PantsLong,
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		Shorts,
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		FootMid,
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		ShoeLow,
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		PantsShort,
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		PalmL,
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		PalmR,
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		HandL,
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		HandR,
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		Ears,
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		FootHigh
	}

	[Cpp2IlInjected.Token(Token = "0x2000021")]
	[Flags]
	public enum LCMFNGJPNFA
	{
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		Head = 1,
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		TorsoAll = 2,
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		TorsoHigh = 4,
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		TorsoLow = 8,
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		SleevesShort = 0x10,
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		SleevesLong = 0x20,
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		DEPRECATED_Palm = 0x40,
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		DEPRECATED_HandsAll = 0x80,
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		PantsLong = 0x100,
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		Shorts = 0x200,
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		FootMid = 0x400,
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		ShoeLow = 0x800,
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		PantsShort = 0x1000,
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		PalmL = 0x2000,
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		PalmR = 0x4000,
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		HandL = 0x8000,
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		HandR = 0x10000,
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		Ears = 0x20000,
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		FootHigh = 0x40000
	}

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public static LCMFNGJPNFA CIIKPPHFNAF;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public static LCMFNGJPNFA NCJMOHCBKDI;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1BD0080", Offset = "0x1BCEE80", VA = "0x181BD0080")]
	public static LCMFNGJPNFA JBGDIMICGII(LCMFNGJPNFA EGDNOPMBLBM, LCMFNGJPNFA IENJBLEAPCF)
	{
		return default(LCMFNGJPNFA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1BD0070", Offset = "0x1BCEE70", VA = "0x181BD0070")]
	public static LCMFNGJPNFA ICGLNBPEAGJ(LCMFNGJPNFA ONHCIJJBIHO, LCMFNGJPNFA KLDLPHFNLPG)
	{
		return default(LCMFNGJPNFA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x60DAB10", Offset = "0x60D9910", VA = "0x1860DAB10")]
	public static LCMFNGJPNFA COHOABGEABD(BNDOPEKLCNC EAFEDOEANPO, LCMFNGJPNFA CBOALJBGIFD)
	{
		return default(LCMFNGJPNFA);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x60DAC00", Offset = "0x60D9A00", VA = "0x1860DAC00")]
	public static LCMFNGJPNFA NFMFECGGCLJ(BNDOPEKLCNC EAFEDOEANPO, LCMFNGJPNFA CBOALJBGIFD)
	{
		return default(LCMFNGJPNFA);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x60DAB90", Offset = "0x60D9990", VA = "0x1860DAB90")]
	public static bool JDLGMBMAGOB(this LCMFNGJPNFA JGEOEOBDEBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x60DAB20", Offset = "0x60D9920", VA = "0x1860DAB20")]
	public static bool IJHAJLNNJNA(this LCMFNGJPNFA JGEOEOBDEBM)
	{
		return default(bool);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public class AvatarSkinnedMeshBoneOrderRemapsData : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000023")]
		public struct BoneOrderRemapEntry
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000FF")]
			public string boneOrderChecksum;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000100")]
			public byte[] boneOrderRemap;
		}

		[Cpp2IlInjected.Token(Token = "0x2000024")]
		[CompilerGenerated]
		private sealed class EGOMIBGOJFF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000101")]
			public AvatarSkinnedMeshBonesController bonesController;

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
			public EGOMIBGOJFF()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x60DBD50", Offset = "0x60DAB50", VA = "0x1860DBD50")]
			internal bool HAABFKMCFEK(BoneOrderRemapEntry item)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		[SerializeField]
		private List<BoneOrderRemapEntry> BoneOrderRemapData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private Dictionary<string, byte[]> _boneOrderRemaps;

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x60D9970", Offset = "0x60D8770", VA = "0x1860D9970")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x60D9970", Offset = "0x60D8770", VA = "0x1860D9970")]
		private void GPNNCLIKHLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x60D9820", Offset = "0x60D8620", VA = "0x1860D9820")]
		private void EMKMCINDNGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x60D9980", Offset = "0x60D8780", VA = "0x1860D9980")]
		public byte[] PIHPODCOAJC(string NCEKGNCDIKN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x60D8E30", Offset = "0x60D7C30", VA = "0x1860D8E30")]
		public bool BFPACKDLJEM(SkinnedMeshBoneOrderData DPIOELDFONH, AvatarSkinnedMeshBonesController KKFOPGIDAOM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x60D99F0", Offset = "0x60D87F0", VA = "0x1860D99F0")]
		public AvatarSkinnedMeshBoneOrderRemapsData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class MLFBCADAIGG
{
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public struct NFJMCFMIFAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public Transform[] JKNKOIDHIIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public Matrix4x4[] JPOIJKEHBFC;
	}

	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public static readonly string AHMPGNHGGAD;

	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private static AvatarSkinnedMeshBoneOrderRemapsData HOPKEGDOIHB;

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x60DE9E0", Offset = "0x60DD7E0", VA = "0x1860DE9E0")]
	static MLFBCADAIGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x60DE870", Offset = "0x60DD670", VA = "0x1860DE870")]
	public static AvatarSkinnedMeshBoneOrderRemapsData NLHBLNJFLNB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x60DE5C0", Offset = "0x60DD3C0", VA = "0x1860DE5C0")]
	public static byte[] MFPBCEAKDLM(SkinnedMeshRenderer IMBJJEHONAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x60DE1D0", Offset = "0x60DCFD0", VA = "0x1860DE1D0")]
	public static NFJMCFMIFAN? LHMIGLMIHNK(SkinnedMeshRenderer IMBJJEHONAC)
	{
		return null;
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[RequireComponent(typeof(SkinnedMeshRenderer))]
	[DisallowMultipleComponent]
	public class AvatarSkinnedMeshBonesController : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		[SerializeField]
		[ReadOnlyField]
		private string boneOrderChecksum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		[FHFEFOGEDAO(KLKJAELFHOF.Self, false, false, false)]
		[SerializeField]
		public SkinnedMeshRenderer SkinnedMeshRenderer;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public string FMPKPGBHJPB
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x60D9AC0", Offset = "0x60D88C0", VA = "0x1860D9AC0")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x60D9F20", Offset = "0x60D8D20", VA = "0x1860D9F20")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x60D9E80", Offset = "0x60D8C80", VA = "0x1860D9E80")]
		private void EMKMCINDNGE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x60D9AF0", Offset = "0x60D88F0", VA = "0x1860D9AF0")]
		[ContextMenu("Calculate Bone Order Checksum")]
		public bool CalculateBoneOrderChecksum()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7B0790", Offset = "0x7AF590", VA = "0x1807B0790")]
		public AvatarSkinnedMeshBonesController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public enum HPMPONPGIOO
{
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	NeverObscured,
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	AlwaysObscured,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	PrivateObscured
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class CBPHCAMMFPP
{
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public static readonly CBPHCAMMFPP NGIMMBPCNIG;

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public int NGIMLGCHECG
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7AE110", Offset = "0x7ACF10", VA = "0x1807AE110")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7B4FE0", Offset = "0x7B3DE0", VA = "0x1807B4FE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public HPMPONPGIOO LFHBKONGLHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xA4E340", Offset = "0xA4D140", VA = "0x180A4E340")]
		[CompilerGenerated]
		get
		{
			return default(HPMPONPGIOO);
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xA4E3C0", Offset = "0xA4D1C0", VA = "0x180A4E3C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public CBPHCAMMFPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x23A54F0", Offset = "0x23A42F0", VA = "0x1823A54F0")]
	public CBPHCAMMFPP(HPMPONPGIOO JLLJLOICEHP, int CCJJLCHMBMI)
	{
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002C")]
	public class FitMeshHemisphere
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private readonly Vector2 UV_CENTER_COORDINATE;

		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public static readonly Vector3 DEFAULT_HEMISPHERE_FITMESH_PIVOT_POSITION;

		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public static readonly Quaternion DEFAULT_HEMISPHERE_FITMESH_PIVOT_ROTATION;

		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public static readonly Vector3 DEFAULT_HEMISPHERE_FITMESH_PIVOT_SCALE;

		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public static readonly FitMeshHemisphere Default;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		[SerializeField]
		public Vector3 hemispherePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		[SerializeField]
		public Quaternion hemisphereRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		[SerializeField]
		public Vector3 hemisphereScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		[SerializeField]
		public float radius;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public bool IsRadiusValid
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x60DD6B0", Offset = "0x60DC4B0", VA = "0x1860DD6B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x60DD600", Offset = "0x60DC400", VA = "0x1860DD600")]
		public FitMeshHemisphere()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x60DCD00", Offset = "0x60DBB00", VA = "0x1860DCD00")]
		public void EHLDJHDBHML(FitMeshHemisphere CJJGLGLJJJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x60DCDB0", Offset = "0x60DBBB0", VA = "0x1860DCDB0")]
		public Vector3 GJLIAMNNEFG(Vector2 CCKECCPNKPN, bool MNIOINJBOPB = true)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x60DCD50", Offset = "0x60DBB50", VA = "0x1860DCD50")]
		public Vector3 FDOLEEECHOE(Vector2 CCKECCPNKPN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x60DD2A0", Offset = "0x60DC0A0", VA = "0x1860DD2A0")]
		public Quaternion GJMGDBDHIOE(Vector2 CCKECCPNKPN)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x60DD120", Offset = "0x60DBF20", VA = "0x1860DD120")]
		public Quaternion GJMGDBDHIOE(Vector2 CCKECCPNKPN, Vector3 FNANLJHCFLP)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x60DCCA0", Offset = "0x60DBAA0", VA = "0x1860DCCA0")]
		private Vector2 COHNNNDBBFE(Vector2 FLOBDDNGNEB)
		{
			return default(Vector2);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public struct NoseMeshConfiguration
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public NoseFaceOption NoseOption;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public BodySkinnedMeshLODs Meshes;
	}
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public enum OutfitType
	{
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		None = -1,
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		Hat = 0,
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		Hair = 2,
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		Ear = 3,
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		Eye = 10,
		[Cpp2IlInjected.Token(Token = "0x4000124")]
		Beard = 20,
		[Cpp2IlInjected.Token(Token = "0x4000125")]
		Shoulder = 100,
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		Shirt = 101,
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		Waist = 102,
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		Neck = 103,
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		TeamJersey = 104,
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		CustomShirt = 105,
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		Wrist = 200,
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		TeamWrist = 203,
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		Legs = 300,
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		Feet = 301
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public static class BKOBNGBMMDF
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x60DA150", Offset = "0x60D8F50", VA = "0x1860DA150")]
	public static bool LFAPJPCOKPA(this OutfitType NNEPGIFCEMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x60DA180", Offset = "0x60D8F80", VA = "0x1860DA180")]
	public static bool PJNGGOEHKNE(this OutfitType NNEPGIFCEMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x60DA110", Offset = "0x60D8F10", VA = "0x1860DA110")]
	public static bool FHIDMFACGHO(this OutfitType NNEPGIFCEMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x60DA0E0", Offset = "0x60D8EE0", VA = "0x1860DA0E0")]
	public static bool CCMGEELFJHL(this OutfitType NNEPGIFCEMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x60DA0D0", Offset = "0x60D8ED0", VA = "0x1860DA0D0")]
	public static bool AJPGNIGHBGA(this OutfitType NNEPGIFCEMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x60DA120", Offset = "0x60D8F20", VA = "0x1860DA120")]
	public static bool IELAADMMGCC(this OutfitType NNEPGIFCEMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x60DA140", Offset = "0x60D8F40", VA = "0x1860DA140")]
	public static bool KKMDACMIBMG(this OutfitType NNEPGIFCEMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x60DA170", Offset = "0x60D8F70", VA = "0x1860DA170")]
	public static bool PGOLCOMMLFL(this OutfitType NNEPGIFCEMG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x60DA0F0", Offset = "0x60D8EF0", VA = "0x1860DA0F0")]
	public static bool CILGOFNMKCF(this OutfitType NNEPGIFCEMG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class NACNIOBAFFC : IEqualityComparer<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public static readonly NACNIOBAFFC LLCJIHIKEMG;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x60DEA40", Offset = "0x60DD840", VA = "0x1860DEA40", Slot = "4")]
	public bool Equals(OutfitType LJKMPGIDKFE, OutfitType JGPJNFLCOLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x60DEAA0", Offset = "0x60DD8A0", VA = "0x1860DEAA0", Slot = "5")]
	public int GetHashCode(OutfitType DDEINLAGLLL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public NACNIOBAFFC()
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class SkinnedMeshBoneOrderData : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		[SerializeField]
		private List<string> validBoneOrder;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public IReadOnlyList<string> CurrentValidBoneOrder
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x60DEBC0", Offset = "0x60DD9C0", VA = "0x1860DEBC0")]
		public void PNLMBFENJEP(SkinnedMeshRenderer IMBJJEHONAC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x60DED60", Offset = "0x60DDB60", VA = "0x1860DED60")]
		public SkinnedMeshBoneOrderData()
		{
		}
	}
}
namespace RecRoom.Avatars.Face
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public sealed class BrowsFaceFeature : SymmetricalFaceFeature
	{
		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x914B90", Offset = "0x913990", VA = "0x180914B90", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x60DAA80", Offset = "0x60D9880", VA = "0x1860DAA80")]
		public BrowsFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public sealed class EyesFaceFeature : SymmetricalFaceFeature
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		public Vector2 MaxGleamJitterScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		public Vector2 MaxGleamJitterOffsetAnchors;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		public bool JitterGleamSymmetrically;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		public Vector2 GleamJitterMultiplier;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x600009B")]
			[Cpp2IlInjected.Address(RVA = "0x7B07B0", Offset = "0x7AF5B0", VA = "0x1807B07B0", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public Vector2 JitteredEyeGleamOffsetLeft
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x60DC190", Offset = "0x60DAF90", VA = "0x1860DC190")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600009D")]
			[Cpp2IlInjected.Address(RVA = "0x60DC1F0", Offset = "0x60DAFF0", VA = "0x1860DC1F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public Vector2 JitteredEyeGleamOffsetRight
		{
			[Cpp2IlInjected.Token(Token = "0x600009E")]
			[Cpp2IlInjected.Address(RVA = "0x60DC1B0", Offset = "0x60DAFB0", VA = "0x1860DC1B0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600009F")]
			[Cpp2IlInjected.Address(RVA = "0x60DC200", Offset = "0x60DB000", VA = "0x1860DC200")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public Vector2 JitteredEyeGleamScaleLeft
		{
			[Cpp2IlInjected.Token(Token = "0x60000A0")]
			[Cpp2IlInjected.Address(RVA = "0xAD5270", Offset = "0xAD4070", VA = "0x180AD5270")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x1800BE0", Offset = "0x17FF9E0", VA = "0x181800BE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public Vector2 JitteredEyeGleamScaleRight
		{
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x60DC1D0", Offset = "0x60DAFD0", VA = "0x1860DC1D0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A3")]
			[Cpp2IlInjected.Address(RVA = "0x60DC210", Offset = "0x60DB010", VA = "0x1860DC210")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x60DBD80", Offset = "0x60DAB80", VA = "0x1860DBD80", Slot = "7")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x60DC080", Offset = "0x60DAE80", VA = "0x1860DC080")]
		public EyesFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public abstract class FaceFeature : FaceFeatureBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		public Vector2 DefaultAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		public Vector2 MaxJitterAnchor;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public Vector2 JitteredAnchor
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x60DCC80", Offset = "0x60DBA80", VA = "0x1860DCC80")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x56E4140", Offset = "0x56E2F40", VA = "0x1856E4140")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public Vector2 JitteredOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0xB22EA0", Offset = "0xB21CA0", VA = "0x180B22EA0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0xF3B940", Offset = "0xF3A740", VA = "0x180F3B940")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x60DCA50", Offset = "0x60DB850", VA = "0x1860DCA50", Slot = "7")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x60DCB90", Offset = "0x60DB990", VA = "0x1860DCB90")]
		protected FaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public abstract class FaceFeatureBase : SelectableFaceOption
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000038")]
		[CompilerGenerated]
		private struct <LoadSpriteAssetsAsync>d__26 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400014D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400014E")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400014F")]
			public FaceFeatureBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000150")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0x60DF140", Offset = "0x60DDF40", VA = "0x1860DF140", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x60DFE90", Offset = "0x60DEC90", VA = "0x1860DFE90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400013F")]
		private static readonly string[] FACE_FEATURE_ASSET_PATHS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		private readonly List<BCJOGHANCKE<Sprite>> _spriteResourceHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		private readonly List<Sprite> _loadedSprites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private Task _activelyLoadingTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		private int _referenceCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		[SerializeField]
		private List<AssetReference> SpriteReferences;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		[SerializeField]
		private Sprite[] DefaultSprites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		public Vector2 DefaultScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		public Vector2 MaxJitterScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		public Vector2 JitterMultiplier;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public string DefaultSpriteName
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x7B7040", Offset = "0x7B5E40", VA = "0x1807B7040")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x7B7070", Offset = "0x7B5E70", VA = "0x1807B7070")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public IEnumerable<Sprite> SrcLoadedSprites
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x60DC9A0", Offset = "0x60DB7A0", VA = "0x1860DC9A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public int TextureCount
		{
			[Cpp2IlInjected.Token(Token = "0x60000AF")]
			[Cpp2IlInjected.Address(RVA = "0x60DCA10", Offset = "0x60DB810", VA = "0x1860DCA10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public bool IsLoaded
		{
			[Cpp2IlInjected.Token(Token = "0x60000B0")]
			[Cpp2IlInjected.Address(RVA = "0x60DC950", Offset = "0x60DB750", VA = "0x1860DC950")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public Vector2 JitteredScale
		{
			[Cpp2IlInjected.Token(Token = "0x60000B1")]
			[Cpp2IlInjected.Address(RVA = "0x4EDFC80", Offset = "0x4EDEA80", VA = "0x184EDFC80")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x4EDFE80", Offset = "0x4EDEC80", VA = "0x184EDFE80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x60DC430", Offset = "0x60DB230", VA = "0x1860DC430")]
		protected static Vector2 JitteredVector2(Vector2 initial, Vector2 maxJitter)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x60DC570", Offset = "0x60DB370", VA = "0x1860DC570", Slot = "7")]
		public virtual void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x60DC4A0", Offset = "0x60DB2A0", VA = "0x1860DC4A0")]
		[AsyncStateMachine(typeof(<LoadSpriteAssetsAsync>d__26))]
		public Task LoadSpriteAssetsAsync()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x60DC650", Offset = "0x60DB450", VA = "0x1860DC650")]
		public void ReleaseSpriteResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x60DC220", Offset = "0x60DB020", VA = "0x1860DC220")]
		private void DisposeAllSpriteResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x60DC750", Offset = "0x60DB550", VA = "0x1860DC750")]
		protected FaceFeatureBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public enum FaceFeatureType
	{
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		Eye,
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		Mouth,
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		Nose,
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		Brows
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public sealed class EECMHFMEFGK : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct ILAEOAJPABH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		public AsyncTaskMethodBuilder<EECMHFMEFGK> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		public SymmetricalFaceFeature eyeBrow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		public EyesFaceFeature eye;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		public FaceFeature mouth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		private OFLIHLAMOOO.KFIHEFLKECH <__>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x60DDAC0", Offset = "0x60DC8C0", VA = "0x1860DDAC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x60DE0A0", Offset = "0x60DCEA0", VA = "0x1860DE0A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000156")]
	private readonly Dictionary<string, int> EEMCAGPFNEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400015B")]
	private bool OAHNNNMGFPO;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public Texture2DArray OJIHBMBGNCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x7B1930", Offset = "0x7B0730", VA = "0x1807B1930")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public SymmetricalFaceFeature LLHPHIHLJGG
	{
		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x7B22D0", Offset = "0x7B10D0", VA = "0x1807B22D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x7B1940", Offset = "0x7B0740", VA = "0x1807B1940")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public EyesFaceFeature GLEDJFGIICH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x7B22C0", Offset = "0x7B10C0", VA = "0x1807B22C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7B1ED0", Offset = "0x7B0CD0", VA = "0x1807B1ED0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public FaceFeature IMBCNFIEDFH
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x7B8500", Offset = "0x7B7300", VA = "0x1807B8500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x7B84F0", Offset = "0x7B72F0", VA = "0x1807B84F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x60DB730", Offset = "0x60DA530", VA = "0x1860DB730")]
	private static void LFPMNFPNFBC(Sprite IPIIMJLKAED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x60DB8E0", Offset = "0x60DA6E0", VA = "0x1860DB8E0")]
	public static EECMHFMEFGK PEPKNGBNOAK(SymmetricalFaceFeature NEIKCLPMFPO, EyesFaceFeature JNINOPNBNHG, FaceFeature NDAKEPNOJIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x60DB7A0", Offset = "0x60DA5A0", VA = "0x1860DB7A0")]
	[AsyncStateMachine(typeof(ILAEOAJPABH))]
	public static Task<EECMHFMEFGK> OGLHBJGEJBM(SymmetricalFaceFeature NEIKCLPMFPO, EyesFaceFeature JNINOPNBNHG, FaceFeature NDAKEPNOJIJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x60DB970", Offset = "0x60DA770", VA = "0x1860DB970")]
	private EECMHFMEFGK(SymmetricalFaceFeature NEIKCLPMFPO, EyesFaceFeature JNINOPNBNHG, FaceFeature NDAKEPNOJIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x60DAC60", Offset = "0x60D9A60", VA = "0x1860DAC60")]
	private void CNGLCBEJLEE(List<Sprite> PJADIGCIEMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x60DB540", Offset = "0x60DA340", VA = "0x1860DB540")]
	public bool LDELHAAEKNH(string GOBMMDDHOAP, [Out] int AELAKOMEEDP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x60DB3A0", Offset = "0x60DA1A0", VA = "0x1860DB3A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x60DB3D0", Offset = "0x60DA1D0", VA = "0x1860DB3D0")]
	public bool GOBGLGCFBCN()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x60DB4C0", Offset = "0x60DA2C0", VA = "0x1860DB4C0")]
	public void HIIONNOFFCC()
	{
	}
}
namespace RecRoom.Avatars.Face
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public sealed class MouthFaceFeature : FaceFeature
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x874150", Offset = "0x872F50", VA = "0x180874150", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x60DCB90", Offset = "0x60DB990", VA = "0x1860DCB90")]
		public MouthFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public sealed class NoseFaceOption : SelectableFaceOption
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public DCIGFAKEFGM SelectedNoseType;

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x900CB0", Offset = "0x8FFAB0", VA = "0x180900CB0", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x89A860", Offset = "0x899660", VA = "0x18089A860")]
		public NoseFaceOption()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public abstract class SelectableFaceOption : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		[Obsolete("Use FaceFeatureId instead!")]
		[SerializeField]
		[Tooltip("This guid is auto generated at the time of the asset creation and should never change if you do not want to break an existing player's feature selection")]
		protected string GuidString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		[SerializeField]
		private SerializedFaceFeatureId faceFeatureId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		[SerializeField]
		private Sprite menuButtonSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		[SerializeField]
		private bool isNoneOption;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public BEPKGBHJAIF FaceFeatureId
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x882770", Offset = "0x881570", VA = "0x180882770")]
			get
			{
				return default(BEPKGBHJAIF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public bool IsNoneOption
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0x86DBD0", Offset = "0x86C9D0", VA = "0x18086DBD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x7B8500", Offset = "0x7B7300", VA = "0x1807B8500")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public abstract FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x882CB0", Offset = "0x881AB0", VA = "0x180882CB0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x89A860", Offset = "0x899660", VA = "0x18089A860")]
		protected SelectableFaceOption()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public abstract class SymmetricalFaceFeature : FaceFeatureBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public Vector2 MaxJitterAnchors;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public bool JitterSymetrically;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public Vector2 DefaultAnchorLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public Vector2 DefaultAnchorRight;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public Vector2 JitteredAnchorLeft
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x60DF0C0", Offset = "0x60DDEC0", VA = "0x1860DF0C0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0xCE46E0", Offset = "0xCE34E0", VA = "0x180CE46E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public Vector2 JitteredOffsetLeft
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x60DF100", Offset = "0x60DDF00", VA = "0x1860DF100")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x56DFF80", Offset = "0x56DED80", VA = "0x1856DFF80")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public Vector2 JitteredAnchorRight
		{
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x60DF0E0", Offset = "0x60DDEE0", VA = "0x1860DF0E0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x56E3250", Offset = "0x56E2050", VA = "0x1856E3250")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public Vector2 JitteredOffsetRight
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x60DF120", Offset = "0x60DDF20", VA = "0x1860DF120")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x56E3240", Offset = "0x56E2040", VA = "0x1856E3240")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x60DEDF0", Offset = "0x60DDBF0", VA = "0x1860DEDF0", Slot = "7")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x60DEFF0", Offset = "0x60DDDF0", VA = "0x1860DEFF0")]
		protected SymmetricalFaceFeature()
		{
		}
	}
}
namespace RecRoom.Avatars.Data.Shared
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	public class AdditionalHatData : AdditionalOutfitTypeData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		[ReadOnlyField]
		[SerializeField]
		public bool UseHatUVOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		[SerializeField]
		[ReadOnlyField]
		public Vector2 HatUVOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		[ReadOnlyField]
		[SerializeField]
		public Vector2 DefaultUVOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		[SerializeField]
		[ReadOnlyField]
		public bool AllowFitMeshOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		[SerializeField]
		[ReadOnlyField]
		public Vector3 FitMeshPivotPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		[SerializeField]
		[ReadOnlyField]
		public Quaternion FitMeshPivotRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		[ReadOnlyField]
		[SerializeField]
		public AnchorParamsRestrictions AnchorParamsRestrictions;

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x60D7310", Offset = "0x60D6110", VA = "0x1860D7310", Slot = "0")]
		public override bool Equals(object EIFMADKIHON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x60D7420", Offset = "0x60D6220", VA = "0x1860D7420")]
		protected bool GPOBLKCLAFD(AdditionalHatData GGINNHLAMLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x60D7610", Offset = "0x60D6410", VA = "0x1860D7610", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x60D79F0", Offset = "0x60D67F0", VA = "0x1860D79F0")]
		public AdditionalHatData()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x60D77B0", Offset = "0x60D65B0", VA = "0x1860D77B0")]
		public AdditionalHatData(GLLKJBFDAIA CGPMFEMKNAJ)
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class AdditionalOutfitTypeData
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public AdditionalOutfitTypeData()
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
