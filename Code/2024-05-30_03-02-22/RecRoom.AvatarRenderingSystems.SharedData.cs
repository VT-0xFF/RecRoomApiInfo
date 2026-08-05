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

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface CNLAGBBMCIC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	float BFPIFACFMHM
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	float NBFHKHELEED
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	float JBBHPHOLDAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	float NJLJAPFAAAG
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float BPMBHCOFEJB
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	float OCKMENDMCAK
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float OLMILKIEPKF
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float JAIIJPFNPKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float KHOCOKJEHKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	float LDEGIDDMEAE
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	float HOENGOHCFCJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	float ILLPOKPFIGF
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	float MEHBHEGMIJP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	float IKMFDPKJPMG
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	float AAJBNEIGFMA
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	float BJLJLNMDICN
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Vector3 LODDOGGNOKI(Vector3 ONEKHKKFNIA);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Vector3 DDPJLGPJPOE(Vector3 HOAIIPGBOAD);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Vector3 JNGBFMBPCDE();
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class AnchorParamsRestrictions : CNLAGBBMCIC
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

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public static readonly Vector2 DEFAULT_UV_RANGE;

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public static readonly Vector3 DEFAULT_MIN;

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public static readonly Vector3 DEFAULT_MAX;

		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public static readonly Vector3 DEFAULT_FREEDOM;

		[Cpp2IlInjected.Token(Token = "0x17000011")]
		public bool GetAllowTranslations
		{
			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8CC9A0", Offset = "0x8CBBA0", VA = "0x1808CC9A0", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool GetAllowRotations
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xABF9C0", Offset = "0xABEBC0", VA = "0x180ABF9C0", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x834740", Offset = "0x833940", VA = "0x180834740", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x834700", Offset = "0x833900", VA = "0x180834700", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x834730", Offset = "0x833930", VA = "0x180834730", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x834710", Offset = "0x833910", VA = "0x180834710", Slot = "7")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8346F0", Offset = "0x8338F0", VA = "0x1808346F0", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x7F8E00", Offset = "0x7F8000", VA = "0x1807F8E00", Slot = "9")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 DefaultOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x62B7810", Offset = "0x62B6A10", VA = "0x1862B7810")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x834690", Offset = "0x833890", VA = "0x180834690", Slot = "12")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x834EC0", Offset = "0x8340C0", VA = "0x180834EC0", Slot = "13")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x8346B0", Offset = "0x8338B0", VA = "0x1808346B0", Slot = "10")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x8346C0", Offset = "0x8338C0", VA = "0x1808346C0", Slot = "11")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x834DC0", Offset = "0x833FC0", VA = "0x180834DC0", Slot = "14")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x834DB0", Offset = "0x833FB0", VA = "0x180834DB0", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Vector3 DefaultRotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x62B7830", Offset = "0x62B6A30", VA = "0x1862B7830")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float GetMaxUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x834E40", Offset = "0x834040", VA = "0x180834E40", Slot = "16")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float GetMinUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x834E90", Offset = "0x834090", VA = "0x180834E90", Slot = "17")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x834E70", Offset = "0x834070", VA = "0x180834E70", Slot = "18")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x7E3B80", Offset = "0x7E2D80", VA = "0x1807E3B80", Slot = "19")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector2 URange
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x62B7F80", Offset = "0x62B7180", VA = "0x1862B7F80")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x62B7FC0", Offset = "0x62B71C0", VA = "0x1862B7FC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector2 VRange
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x62B7FA0", Offset = "0x62B71A0", VA = "0x1862B7FA0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x62B7FE0", Offset = "0x62B71E0", VA = "0x1862B7FE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x62B7EF0", Offset = "0x62B70F0", VA = "0x1862B7EF0")]
		public AnchorParamsRestrictions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x62B7520", Offset = "0x62B6720", VA = "0x1862B7520")]
		public MINLICNIIAF JKAJADMHENO(MINLICNIIAF DENOPGPOKGI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x62B7830", Offset = "0x62B6A30", VA = "0x1862B7830", Slot = "25")]
		public Vector3 KCNOLNPCDHK()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x62B7810", Offset = "0x62B6A10", VA = "0x1862B7810", Slot = "22")]
		public Vector3 JNGBFMBPCDE()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x62B7D50", Offset = "0x62B6F50", VA = "0x1862B7D50", Slot = "20")]
		public Vector3 LODDOGGNOKI(Vector3 ONEKHKKFNIA)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x62B7390", Offset = "0x62B6590", VA = "0x1862B7390", Slot = "21")]
		public Vector3 DDPJLGPJPOE(Vector3 HOAIIPGBOAD)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x62B7410", Offset = "0x62B6610", VA = "0x1862B7410", Slot = "0")]
		public override bool Equals(object CDJAKLIPEBF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x62B7850", Offset = "0x62B6A50", VA = "0x1862B7850")]
		protected bool LEKGILNOIAO(AnchorParamsRestrictions JPLJHFMPDFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x62B7DC0", Offset = "0x62B6FC0", VA = "0x1862B7DC0")]
		[CompilerGenerated]
		internal static bool MIOLDAFAHKJ(float BPOHBPAMNLC, float NOIIDJMAOFK)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public class MGFFLAIFAPE
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private Transform[] ALNINJBLHCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private readonly Dictionary<string, Transform> OLMNICLKIOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private readonly Dictionary<Transform, Transform> BCBENJALEBF;

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public Transform[] LMMFHNECLJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x7CB530", Offset = "0x7CA730", VA = "0x1807CB530")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x62BE1C0", Offset = "0x62BD3C0", VA = "0x1862BE1C0")]
	public void HDDKOKJIANG(Transform LKOCKNKFFID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x62BE0E0", Offset = "0x62BD2E0", VA = "0x1862BE0E0")]
	public Transform FMPOCGBIKMM(Transform KMLFDHMPLBI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x62BE2A0", Offset = "0x62BD4A0", VA = "0x1862BE2A0")]
	public void JMEGDHMDAOL(SkinnedMeshRenderer CDECJOIBEBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003A")]
	[Cpp2IlInjected.Address(RVA = "0x62BDF30", Offset = "0x62BD130", VA = "0x1862BDF30")]
	private static void BGJDHIAFJON(Transform LNOFAKNEFAA, List<Transform> IHCDPEFBLHH, Dictionary<string, Transform> BNAAMFOCAGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x62BE4E0", Offset = "0x62BD6E0", VA = "0x1862BE4E0")]
	public MGFFLAIFAPE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class FEIOKEPKPAA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public bool BPNBMDJGIDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public bool GODGFMNLCKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public PLPCONDGDMD? JLKEIBNCIEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public GKPJGAOJHHB.JGJMGEIKMEE BIOEDIOLJEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public Texture2D EPAPLIOMEBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public Texture2D DABLJKEPGNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public IList<MHNAHBJPPJF> GBIFOAKIHJJ;

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public FEIOKEPKPAA()
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public abstract class AvatarConfiguration : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[Header("Face Features")]
		[Tooltip("How far apart you can position your eyebrows.")]
		public Vector2 EyebrowsHorizontalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[Tooltip("How far up and down you can position your eyebrows.")]
		public Vector2 EyebrowsVerticalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[Tooltip("How small/large you can scale your eyebrows.")]
		public Vector2 EyebrowsScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[Tooltip("How far apart can position your eyes.")]
		public Vector2 EyesHorizontalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		[Tooltip("How far up and down you can position your eyes.")]
		public Vector2 EyesVerticalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[Tooltip("How small/large you can scale your eyes.")]
		public Vector2 EyeScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[Tooltip("How far left and right you can position your mouth.")]
		public Vector2 MouthHorizontalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[Tooltip("How far up and down you can position your mouth.")]
		public Vector2 MouthVerticalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[Tooltip("How small/large you can scale your mouth.")]
		public Vector2 MouthScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[Tooltip("How far left and right you can position your nose.")]
		public Vector2 NoseHorizontalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[Tooltip("How far up and down you can position your nose.")]
		public Vector2 NoseVerticalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[Tooltip("How small/large you can scale your nose.")]
		public Vector2 NoseScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[Tooltip("A constant multiplier on all eye jitter.")]
		public Vector2 GlobalEyeJitterMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[Tooltip("A constant multiplier on all eye gleam jitter.")]
		public Vector2 GlobalEyeGleamJitterMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[Tooltip("A constant multiplier on all eyebrow jitter.")]
		public Vector2 GlobalEyebrowJitterMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[Tooltip("A constant multiplier on all mouth jitter.")]
		public Vector2 GlobalMouthJitterMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[Tooltip("Used to scale a face bone into UV space by scaling to the bone's (x,y) position")]
		public Vector2 ScaleFaceBonesToUVs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[Tooltip("Used to translate all face bone into UV space by adding the offset to the post-scaled bone (x,y) position")]
		public Vector2 TranslateFaceBonesToUVsOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[Tooltip("Used to translate the eye brow bones into UV space by adding to the post-scaled bone (x,y) position")]
		public Vector2 TranslateEyeBrowBonesToUVsOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[Tooltip("Used to translate the eye bones into UV space by adding to the post-scaled bone (x,y) position")]
		public Vector2 TranslateEyeBonesToUVsOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[Tooltip("Used to translate the mouth bones into UV space by adding to the post-scaled bone (x,y) position")]
		public Vector2 TranslateMouthBoneToUVsOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		[Tooltip("Minimum distance used to decrowd eyes to brows in vertical UV space")]
		public float MinDistFromEyesToBrowsInUVVerticalSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		[Tooltip("Minimum distance used to decrowd nose to eyes in vertical UV space")]
		public float MinDistFromNoseToEyesInUVVerticalSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[Tooltip("Minimum distance used to decrowd mouth to nose in vertical UV space")]
		public float MinDistFromMouthToNoseInUVVerticalSpace;

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x62B8000", Offset = "0x62B7200", VA = "0x1862B8000")]
		protected AvatarConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public static class HMANNAPOIIA
{
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	public static readonly NEHJKNGNCPD AHFJCELEGCJ;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public static MINLICNIIAF DFMBFEOCKCK
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x62BD760", Offset = "0x62BC960", VA = "0x1862BD760")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000008")]
public struct FGHFJOIPDFD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000045")]
	public Transform KHENNEPFNAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public AssetReference DHEAHHENOIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public GameObject ACGBGNKJJFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public GameObject EEGJOLHCFCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public SkinnedMeshRenderer NBGHHDIEKNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public Material GGMCBGNKCHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public Material DKEOMKINBLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public Material IAJIFJBJGHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public Shader CBPBEFCPNGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public Shader LBIHGOJEHGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public Animator NBLBHFNBMJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public Renderer[] DFOKOFHHLMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public AvatarConfiguration AKLDGNGLCCF;
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public struct PFAODCKNIFO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public SkinnedMeshRenderer[] PKLAHIIEDFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public SkinnedMeshRenderer[] CPHDPMMCEHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public SkinnedMeshRenderer[] DOEKNPADADP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public SkinnedMeshRenderer[] LNOIDNMLLLA;
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public struct BodySkinnedMeshLODs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public SkinnedMeshRenderer[] LODs;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public struct POABKCDCHCA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public Transform AFNEBKCEOCD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public Transform GMKJIGDOLPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public Transform NABBPPFMFHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public Transform DGGPEKJDKKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public Transform LKEKGNPBEJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public Transform CMHFPMABDPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public Transform NEEMMMDNAPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public AvatarConfiguration AKLDGNGLCCF;
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public struct ILIABBNEMKB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public SkinnedMeshRenderer[] IDABJCMMKNE;
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public struct BECMCNIPBEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public CBIMLGEJDAN JHBBNOONEPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public int AOICGLNEIMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public int GHAMIHEIPLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public Color CNAOFMCHEEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public Color PABIPGCEEDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public int MLKPCPBIIMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public int CEEMEFPGINF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public Color IOBDAHLLMDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public Color MFOIEEKNLLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public int JPLMNDNBGAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public float JIFKIKPHGAE;
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct KAIBKFCKHGP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public CBIMLGEJDAN JHBBNOONEPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public Vector2 KLBHNLLBFEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public float IHBEAMODMLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Vector2 FKLEHAIAGLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public float HLEGLFODIAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public Vector2 MCNFGOPFOJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public float JOLHMOCPCIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public Vector2 GKPFDAPGKBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public float ELGIIIHLMPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public bool PINGCCOALFP;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class MHNAHBJPPJF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public string KLNBLIAPPFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public OutfitType PDOJCCCFFBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public HPNPAHEDPFN HNEMLGPLOOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public GKPJGAOJHHB.JGJMGEIKMEE MHFKIJJDIJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public bool CACKECJAIKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public bool MIBCINLPPEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public bool FALGJLIDNAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public Color? GBKOJDBPEOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public Guid? KILFGOBNADJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public Color? PBACOGOGACK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public bool HJPGKJNNAGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x65")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public bool AJIPAGCMGBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public Transform OCADHJKMLDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public Vector2? JNFEMHEIAPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public FitMeshHemisphere FAHFNCHLOHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public AssetReference PCNFFNBBCEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public AssetReference EGDKDCPEDEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public AssetReference[] HFAADFFBDDM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public bool PJLGJNLFMFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA1")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public bool LGKJEJDDILE;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public string IIIJKFDKJHI
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x62BE5B0", Offset = "0x62BD7B0", VA = "0x1862BE5B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x62BE5B0", Offset = "0x62BD7B0", VA = "0x1862BE5B0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x62BE660", Offset = "0x62BD860", VA = "0x1862BE660")]
	public MHNAHBJPPJF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class BHLNBGHIAOC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public SkinnedMeshRenderer PFHMJALPHBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private Material[] ABOOLNMEMFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private byte[] CNGKBEFCIKH;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public Mesh DEKKIFFBCKL
	{
		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x62B9860", Offset = "0x62B8A60", VA = "0x1862B9860")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public Material[] JHIFMFMMGAC
	{
		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002C")]
	public byte[] CPKKAKGMINE
	{
		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7CB4C0", Offset = "0x7CA6C0", VA = "0x1807CB4C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x62B9A00", Offset = "0x62B8C00", VA = "0x1862B9A00")]
	public BHLNBGHIAOC(SkinnedMeshRenderer LDJHLGLAKLG, [Optional] Material[] EOHHHJHHFON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x62B9880", Offset = "0x62B8A80", VA = "0x1862B9880")]
	public static BHLNBGHIAOC MHLMNDMCJMM(Renderer MNDOIBEKKNI)
	{
		return null;
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct PositionAndRotation
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		public Vector3 Position;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		public Quaternion Rotation;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public static PositionAndRotation Default
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0xB121A0", Offset = "0xB113A0", VA = "0x180B121A0")]
			get
			{
				return default(PositionAndRotation);
			}
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class NICAAGNDLMD
{
	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x62BE910", Offset = "0x62BDB10", VA = "0x1862BE910")]
	public static PositionAndRotation MJOHPKBMMHD(this PositionAndRotation BBBJJLMMFBB)
	{
		return default(PositionAndRotation);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x62BE670", Offset = "0x62BD870", VA = "0x1862BE670")]
	public static float DEMLBFBKEHA(float GIHFGGLMPDC, Vector2 MFPNDALPJCO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x62BE710", Offset = "0x62BD910", VA = "0x1862BE710")]
	public static float DEMLBFBKEHA(float GIHFGGLMPDC, float EEMOHNLEPMA, float PDGAAEFHKDC, float GINACGGICNB)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x62BE840", Offset = "0x62BDA40", VA = "0x1862BE840")]
	public static float HGEEENBHIAL(float HLCKBKFCMPI, Vector2 MFPNDALPJCO)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x62BE790", Offset = "0x62BD990", VA = "0x1862BE790")]
	public static float HGEEENBHIAL(float HLCKBKFCMPI, float EEMOHNLEPMA, float PDGAAEFHKDC, float GINACGGICNB)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class GELCLKMAONE
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public static readonly int KJFDCBCFFIN;

	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public static readonly string EBCAGNBHIBE;
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum JFGGPMGAKAN
{
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	DoNotHideHair,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	UseHelmetHair,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	AlwaysHideHair,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	HideHairToggleable
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum BFFDOJMCJEG
{
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	Normal = 0,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	Curly = 1,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	Self = -1
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum PILCNIJAOHN
{
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	NoPattern,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	Curly,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	Braid
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum HPNPAHEDPFN
{
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	None = -1,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	Head,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	Torso,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	LeftHand,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	RightHand,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	Mouth,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	Legs,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	LeftFoot,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	RightFoot,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	FullBody,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	Nose,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	Face
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public enum PLGNOHLNEIL
{
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	SkinColor,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	PrimaryHairColor,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	SecondaryHairColor,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	PrimaryBeardColor,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	SecondaryBeardColor,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	UGCShirtColor,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	TeamColor,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	TeamEmissiveColor
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum KPHNAIJOACJ
{
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	HairPattern,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	BeardPattern
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum HBKIBICCOCC
{
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	TeamItem,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	SkinColor,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	HairColor,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	BeardColor,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	UGCShirtColor
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum BDOCIDDJPJJ
{
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	HairTexture,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	BeardTexture,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	UGCShirtTexture
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public enum EJDHPAFPNLO
{
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	CollapseSubMeshes,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	CollapseToUniqueMaterials,
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	MergeAll
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum HCHPGDCFMBM
{
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	Base,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	Wide,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	Flat,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	Downturned,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	Hooked,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	Long,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	Upturned,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	None
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum IOOMDAFGOFE
{
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	BeanBody,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	FullBody
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public static class JMNBBPCDJFN
{
	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x62BDE10", Offset = "0x62BD010", VA = "0x1862BDE10")]
	public static bool BNDLEDLEJEM(this JFGGPMGAKAN LDLDNCIADAD)
	{
		return default(bool);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class AvatarSkinAssetItem : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x2000021")]
		public enum NANJNMDFLHG
		{
			[Cpp2IlInjected.Token(Token = "0x40000DB")]
			ScreenFirstPersonSkinMesh,
			[Cpp2IlInjected.Token(Token = "0x40000DC")]
			ThirdPersonSkinMesh,
			[Cpp2IlInjected.Token(Token = "0x40000DD")]
			VRFirstPersonSkinMesh,
			[Cpp2IlInjected.Token(Token = "0x40000DE")]
			NoseSkinMesh,
			[Cpp2IlInjected.Token(Token = "0x40000DF")]
			FaceSkinMesh
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		[SerializeField]
		private BodySkinnedMeshLODs screenFirstPersonBodySkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		[SerializeField]
		private BodySkinnedMeshLODs vrFirstPersonBodySkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		[SerializeField]
		private BodySkinnedMeshLODs thirdPersonBodySkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		[SerializeField]
		private NoseMeshConfiguration[] noseMeshConfigurations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		[SerializeField]
		private BodySkinnedMeshLODs facialSpritesSkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private Dictionary<PLPCONDGDMD, BodySkinnedMeshLODs> JFAFMGFGNBA;

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public BodySkinnedMeshLODs AGKHGMDNEGP
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public BodySkinnedMeshLODs JECOOHFFHHK
		{
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x7CB4C0", Offset = "0x7CA6C0", VA = "0x1807CB4C0")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public BodySkinnedMeshLODs MGKKFNELJMJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x7CB520", Offset = "0x7CA720", VA = "0x1807CB520")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public BodySkinnedMeshLODs IANJAGNOBCP
		{
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x7CEA40", Offset = "0x7CDC40", VA = "0x1807CEA40")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x62B8550", Offset = "0x62B7750", VA = "0x1862B8550")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x62B82B0", Offset = "0x62B74B0", VA = "0x1862B82B0")]
		public SkinnedMeshRenderer[] GetBodySkinnedMeshLODsByType(NANJNMDFLHG BEKFGIIFIDO, [Optional] PLPCONDGDMD? GNDKNGFJCHF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000056")]
		[Cpp2IlInjected.Address(RVA = "0x62B8650", Offset = "0x62B7850", VA = "0x1862B8650")]
		public AvatarSkinAssetItem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class GKPJGAOJHHB
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public enum IILKNEODKJB
	{
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		Head,
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		TorsoAll,
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		TorsoHigh,
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		TorsoLow,
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		SleevesShort,
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		SleevesLong,
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		DEPRECATED_Palm,
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		DEPRECATED_HandsAll,
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		PantsLong,
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		Shorts,
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		FootMid,
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		ShoeLow,
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		PantsShort,
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		PalmL,
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		PalmR,
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		HandL,
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		HandR,
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		Ears,
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		FootHigh
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[Flags]
	public enum JGJMGEIKMEE
	{
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		Head = 1,
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		TorsoAll = 2,
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		TorsoHigh = 4,
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		TorsoLow = 8,
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		SleevesShort = 0x10,
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		SleevesLong = 0x20,
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		DEPRECATED_Palm = 0x40,
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		DEPRECATED_HandsAll = 0x80,
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		PantsLong = 0x100,
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		Shorts = 0x200,
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		FootMid = 0x400,
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		ShoeLow = 0x800,
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		PantsShort = 0x1000,
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		PalmL = 0x2000,
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		PalmR = 0x4000,
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		HandL = 0x8000,
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		HandR = 0x10000,
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		Ears = 0x20000,
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		FootHigh = 0x40000
	}

	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	public static JGJMGEIKMEE GLICFGCLDOI;

	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	public static JGJMGEIKMEE BLDALBFDENI;

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x1C9A470", Offset = "0x1C99670", VA = "0x181C9A470")]
	public static JGJMGEIKMEE KMNFAHMCKIJ(JGJMGEIKMEE DEBHHMICHOE, JGJMGEIKMEE HJBDGJCDNMC)
	{
		return default(JGJMGEIKMEE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x1C9A460", Offset = "0x1C99660", VA = "0x181C9A460")]
	public static JGJMGEIKMEE KIJFNFMLAIM(JGJMGEIKMEE EOMECLPKHFE, JGJMGEIKMEE GEADAHLENLH)
	{
		return default(JGJMGEIKMEE);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x62BD700", Offset = "0x62BC900", VA = "0x1862BD700")]
	public static JGJMGEIKMEE PBDCDJEDENB(IILKNEODKJB DJIGOOIFCHP, JGJMGEIKMEE KDOEDIMJFGI)
	{
		return default(JGJMGEIKMEE);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x62BD6F0", Offset = "0x62BC8F0", VA = "0x1862BD6F0")]
	public static JGJMGEIKMEE MKAFOJPNHNI(IILKNEODKJB DJIGOOIFCHP, JGJMGEIKMEE KDOEDIMJFGI)
	{
		return default(JGJMGEIKMEE);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x62BD610", Offset = "0x62BC810", VA = "0x1862BD610")]
	public static bool BKAONBOKGEG(this JGJMGEIKMEE OGDCKADDBND)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x62BD680", Offset = "0x62BC880", VA = "0x1862BD680")]
	public static bool FKNNCBMAEOD(this JGJMGEIKMEE OGDCKADDBND)
	{
		return default(bool);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class AvatarSkinnedMeshBoneOrderRemapsData : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000026")]
		public struct BoneOrderRemapEntry
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010C")]
			public string boneOrderChecksum;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400010D")]
			public byte[] boneOrderRemap;
		}

		[Cpp2IlInjected.Token(Token = "0x2000027")]
		[CompilerGenerated]
		private sealed class DOFALJGFCOK
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400010E")]
			public AvatarSkinnedMeshBonesController bonesController;

			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
			public DOFALJGFCOK()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x62BAD30", Offset = "0x62B9F30", VA = "0x1862BAD30")]
			internal bool HDNPBPONNFI(BoneOrderRemapEntry item)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		[SerializeField]
		private List<BoneOrderRemapEntry> BoneOrderRemapData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		private Dictionary<string, byte[]> _boneOrderRemaps;

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x62B9150", Offset = "0x62B8350", VA = "0x1862B9150")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x62B9150", Offset = "0x62B8350", VA = "0x1862B9150")]
		private void KMCMMEMNBEP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x62B9160", Offset = "0x62B8360", VA = "0x1862B9160")]
		private void LNLOLDGKLJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x62B86E0", Offset = "0x62B78E0", VA = "0x1862B86E0")]
		public byte[] FCKLJKNIMKD(string PJAJDIAOMIF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x62B8750", Offset = "0x62B7950", VA = "0x1862B8750")]
		public bool KDHPHGFEGDL(SkinnedMeshBoneOrderData EPJNIMHDMEJ, AvatarSkinnedMeshBonesController AEJEIEGCOMD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x62B92B0", Offset = "0x62B84B0", VA = "0x1862B92B0")]
		public AvatarSkinnedMeshBoneOrderRemapsData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public static class GHLJNHPNFOF
{
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public struct ABACPBOHAFI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public Transform[] LMMFHNECLJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public Matrix4x4[] KPAEINDJCPJ;
	}

	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public static readonly string AOLJCNABJCG;

	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private static AvatarSkinnedMeshBoneOrderRemapsData KFPBPNFGEIP;

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x62BD5A0", Offset = "0x62BC7A0", VA = "0x1862BD5A0")]
	static GHLJNHPNFOF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x62BD420", Offset = "0x62BC620", VA = "0x1862BD420")]
	public static AvatarSkinnedMeshBoneOrderRemapsData EKIEIHGIPIB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x62BCD60", Offset = "0x62BBF60", VA = "0x1862BCD60")]
	public static byte[] BCLKNDPIECD(SkinnedMeshRenderer CDECJOIBEBJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x62BD020", Offset = "0x62BC220", VA = "0x1862BD020")]
	public static ABACPBOHAFI? CFBPKMKJDPG(SkinnedMeshRenderer CDECJOIBEBJ)
	{
		return null;
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[RequireComponent(typeof(SkinnedMeshRenderer))]
	[DisallowMultipleComponent]
	public class AvatarSkinnedMeshBonesController : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		[ReadOnlyField]
		[SerializeField]
		private string boneOrderChecksum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		[SerializeField]
		[EOOIALGHMHP(LIEGAMPPNDC.Self, false, false, false)]
		public SkinnedMeshRenderer SkinnedMeshRenderer;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public string JEKJEAIABKE
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x62B9380", Offset = "0x62B8580", VA = "0x1862B9380")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x62B9850", Offset = "0x62B8A50", VA = "0x1862B9850")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x62B97B0", Offset = "0x62B89B0", VA = "0x1862B97B0")]
		private void LNLOLDGKLJC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x62B93B0", Offset = "0x62B85B0", VA = "0x1862B93B0")]
		[ContextMenu("Calculate Bone Order Checksum")]
		public bool CalculateBoneOrderChecksum()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DE0", Offset = "0x7C8FE0", VA = "0x1807C9DE0")]
		public AvatarSkinnedMeshBonesController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public enum HCLAIJIHHNA
{
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	NeverObscured,
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	AlwaysObscured,
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	PrivateObscured
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class CLPKOMANLAG
{
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public static readonly CLPKOMANLAG DNJMIDOFPAJ;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public int BCPKLCGCNBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x7C8110", Offset = "0x7C7310", VA = "0x1807C8110")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x7CE040", Offset = "0x7CD240", VA = "0x1807CE040")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public HCLAIJIHHNA EJLCBCMJLFI
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x83B480", Offset = "0x83A680", VA = "0x18083B480")]
		[CompilerGenerated]
		get
		{
			return default(HCLAIJIHHNA);
		}
		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0xB10790", Offset = "0xB0F990", VA = "0x180B10790")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public CLPKOMANLAG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x2450C80", Offset = "0x244FE80", VA = "0x182450C80")]
	public CLPKOMANLAG(HCLAIJIHHNA CKIGLEMFOLA, int POLANHIBICG)
	{
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public class FitMeshHemisphere
	{
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public static readonly Vector2 UV_CENTER_COORDINATE;

		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public static readonly Vector3 DEFAULT_HEMISPHERE_FITMESH_PIVOT_POSITION;

		[Cpp2IlInjected.Token(Token = "0x4000122")]
		public static readonly Quaternion DEFAULT_HEMISPHERE_FITMESH_PIVOT_ROTATION;

		[Cpp2IlInjected.Token(Token = "0x4000123")]
		public static readonly Vector3 DEFAULT_HEMISPHERE_FITMESH_PIVOT_SCALE;

		[Cpp2IlInjected.Token(Token = "0x4000124")]
		public const float DEFAULT_HEMISPHERE_RADIUS = 0.13f;

		[Cpp2IlInjected.Token(Token = "0x4000125")]
		public static readonly FitMeshHemisphere Default;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000126")]
		public Vector3 hemispherePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public Quaternion hemisphereRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public Vector3 hemisphereScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		public float radius;

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public bool IsRadiusValid
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x62BCCD0", Offset = "0x62BBED0", VA = "0x1862BCCD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x62BC340", Offset = "0x62BB540", VA = "0x1862BC340")]
		public void FNDOEOJILMI(FitMeshHemisphere HEMPLAICAMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x62BC390", Offset = "0x62BB590", VA = "0x1862BC390")]
		public Vector3 IJCHBEKEHNB(Vector2 JEMICNDHDHE, bool JOBHCHFFHJL = true)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x62BCA90", Offset = "0x62BBC90", VA = "0x1862BCA90")]
		public Vector3 NAEFIIFHFBO(Vector2 JEMICNDHDHE)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x62BC750", Offset = "0x62BB950", VA = "0x1862BC750")]
		public Quaternion LEAGONHOBKG(Vector2 JEMICNDHDHE)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x62BC910", Offset = "0x62BBB10", VA = "0x1862BC910")]
		public Quaternion LEAGONHOBKG(Vector2 JEMICNDHDHE, Vector3 JIFNODEPMAA)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x6000083")]
		[Cpp2IlInjected.Address(RVA = "0x62BC2E0", Offset = "0x62BB4E0", VA = "0x1862BC2E0")]
		public Vector2 BIFIGNHJBGM(Vector2 JOPLEJGKCDI)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000084")]
		[Cpp2IlInjected.Address(RVA = "0x62BCC20", Offset = "0x62BBE20", VA = "0x1862BCC20")]
		public FitMeshHemisphere()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public struct NoseMeshConfiguration
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public NoseFaceOption NoseOption;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public BodySkinnedMeshLODs Meshes;
	}
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public enum OutfitType
	{
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		None = -1,
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		Hat = 0,
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		Hair = 2,
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		Ear = 3,
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		Eye = 10,
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		Beard = 20,
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		Shoulder = 100,
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		Shirt = 101,
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		Waist = 102,
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		Neck = 103,
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		TeamJersey = 104,
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		CustomShirt = 105,
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		Wrist = 200,
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		TeamWrist = 203,
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		Legs = 300,
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		Feet = 301
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public static class IPONOAAEPDF
{
	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x62BDD90", Offset = "0x62BCF90", VA = "0x1862BDD90")]
	public static bool FOJHBFPLNND(this OutfitType OEEACNJPIPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x62BDDD0", Offset = "0x62BCFD0", VA = "0x1862BDDD0")]
	public static bool ICGEJDGHBIH(this OutfitType OEEACNJPIPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x62BDDF0", Offset = "0x62BCFF0", VA = "0x1862BDDF0")]
	public static bool IKPAHONBNFM(this OutfitType OEEACNJPIPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x62BDE00", Offset = "0x62BD000", VA = "0x1862BDE00")]
	public static bool LGHODLGDAIO(this OutfitType OEEACNJPIPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x62BDD80", Offset = "0x62BCF80", VA = "0x1862BDD80")]
	public static bool FLAEKIPCMJE(this OutfitType OEEACNJPIPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x62BDD40", Offset = "0x62BCF40", VA = "0x1862BDD40")]
	public static bool AIAAIGJJHFN(this OutfitType OEEACNJPIPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x62BDDB0", Offset = "0x62BCFB0", VA = "0x1862BDDB0")]
	public static bool FPDEMHMBDJD(this OutfitType OEEACNJPIPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x62BDDC0", Offset = "0x62BCFC0", VA = "0x1862BDDC0")]
	public static bool GBGPDHOLKIN(this OutfitType OEEACNJPIPN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x62BDD60", Offset = "0x62BCF60", VA = "0x1862BDD60")]
	public static bool CMAMKMPFOPN(this OutfitType OEEACNJPIPN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public class KJNOHHOMFCP : IEqualityComparer<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public static readonly KJNOHHOMFCP LNFBMICMFIL;

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x62BDE20", Offset = "0x62BD020", VA = "0x1862BDE20", Slot = "4")]
	public bool Equals(OutfitType BCIHOFEOMEC, OutfitType GNEOFODOKDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x62BDE80", Offset = "0x62BD080", VA = "0x1862BDE80", Slot = "5")]
	public int GetHashCode(OutfitType HHJOOHJDNNM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
	public KJNOHHOMFCP()
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public class SkinnedMeshBoneOrderData : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		[SerializeField]
		private List<string> validBoneOrder;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public IReadOnlyList<string> CurrentValidBoneOrder
		{
			[Cpp2IlInjected.Token(Token = "0x6000093")]
			[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x62BEA80", Offset = "0x62BDC80", VA = "0x1862BEA80")]
		public void APNJNIOMNGA(SkinnedMeshRenderer CDECJOIBEBJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x62BEC30", Offset = "0x62BDE30", VA = "0x1862BEC30")]
		public SkinnedMeshBoneOrderData()
		{
		}
	}
}
namespace RecRoom.Avatars.Data.Shared
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class AdditionalHatData : AdditionalOutfitTypeData<AdditionalHatData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		public static readonly Vector2 DEFAULT_HAT_UV_OVERRIDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		public JFGGPMGAKAN helmetHairMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public bool legacyHidesHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		[ReadOnlyField]
		public bool UseHatUVOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		[ReadOnlyField]
		public Vector2 HatUVOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		[ReadOnlyField]
		public bool AllowFitMeshOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		[ReadOnlyField]
		public Vector3 FitMeshPivotPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		[ReadOnlyField]
		public Quaternion FitMeshPivotRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		[ReadOnlyField]
		public AnchorParamsRestrictions AnchorParamsRestrictions;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public Vector2 UVOverride
		{
			[Cpp2IlInjected.Token(Token = "0x6000099")]
			[Cpp2IlInjected.Address(RVA = "0x62B6EA0", Offset = "0x62B60A0", VA = "0x1862B6EA0")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x62B69A0", Offset = "0x62B5BA0", VA = "0x1862B69A0", Slot = "8")]
		public override bool Equals(AdditionalHatData JPLJHFMPDFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x62B6B90", Offset = "0x62B5D90", VA = "0x1862B6B90", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x62B6CF0", Offset = "0x62B5EF0", VA = "0x1862B6CF0")]
		public AdditionalHatData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public abstract class AdditionalOutfitTypeData : IEquatable<AdditionalOutfitTypeData>
	{
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		protected const float EPSILON = 0.001f;

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x62B72E0", Offset = "0x62B64E0", VA = "0x1862B72E0")]
		public static bool ENKJALJMEPC(OutfitType HHJOOHJDNNM)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x62B6F20", Offset = "0x62B6120", VA = "0x1862B6F20")]
		public static AdditionalOutfitTypeData ADOMMGOMPJC(OutfitType HHJOOHJDNNM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x62B7300", Offset = "0x62B6500", VA = "0x1862B7300", Slot = "0")]
		public override bool Equals(object CDJAKLIPEBF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract bool Equals(AdditionalOutfitTypeData JPLJHFMPDFD);

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x62B7260", Offset = "0x62B6460", VA = "0x1862B7260", Slot = "6")]
		public virtual AdditionalOutfitTypeData CIALDCDEGDF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		protected AdditionalOutfitTypeData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public abstract class AdditionalOutfitTypeData<T> : AdditionalOutfitTypeData, IEquatable<T> where T : AdditionalOutfitTypeData<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x3FB9D60", Offset = "0x3FB8F60", VA = "0x183FB9D60", Slot = "5")]
		public override bool Equals(AdditionalOutfitTypeData JPLJHFMPDFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract bool Equals(T JPLJHFMPDFD);

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x7F2B00", Offset = "0x7F1D00", VA = "0x1807F2B00")]
		protected AdditionalOutfitTypeData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public class BeardData : AdditionalOutfitTypeData<BeardData>, EFLCEOJGFKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public PILCNIJAOHN beardHairPatternStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public bool usesHairColor;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public bool UsesHairColor
		{
			[Cpp2IlInjected.Token(Token = "0x60000A7")]
			[Cpp2IlInjected.Address(RVA = "0x865BA0", Offset = "0x864DA0", VA = "0x180865BA0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public PILCNIJAOHN PatternStyle
		{
			[Cpp2IlInjected.Token(Token = "0x60000A8")]
			[Cpp2IlInjected.Address(RVA = "0x7C8110", Offset = "0x7C7310", VA = "0x1807C8110", Slot = "10")]
			get
			{
				return default(PILCNIJAOHN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x62B9AC0", Offset = "0x62B8CC0", VA = "0x1862B9AC0", Slot = "8")]
		public override bool Equals(BeardData JPLJHFMPDFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x62B9AE0", Offset = "0x62B8CE0", VA = "0x1862B9AE0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x62B9B50", Offset = "0x62B8D50", VA = "0x1862B9B50")]
		public BeardData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public class HairData : AdditionalOutfitTypeData<HairData>, EFLCEOJGFKB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public float radius;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public Vector3 hemispherePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public Quaternion hemisphereRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		public Vector3 hemisphereScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		public PILCNIJAOHN hairPatternStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		public bool usesHairColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		public BFFDOJMCJEG helmetHairStyle;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public bool UsesHairColor
		{
			[Cpp2IlInjected.Token(Token = "0x60000AC")]
			[Cpp2IlInjected.Address(RVA = "0x913800", Offset = "0x912A00", VA = "0x180913800", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public PILCNIJAOHN PatternStyle
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x7E69D0", Offset = "0x7E5BD0", VA = "0x1807E69D0", Slot = "10")]
			get
			{
				return default(PILCNIJAOHN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public FitMeshHemisphere Hemisphere
		{
			[Cpp2IlInjected.Token(Token = "0x60000AE")]
			[Cpp2IlInjected.Address(RVA = "0x62BDCB0", Offset = "0x62BCEB0", VA = "0x1862BDCB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x62BD900", Offset = "0x62BCB00", VA = "0x1862BD900", Slot = "8")]
		public override bool Equals(HairData JPLJHFMPDFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x62BDAF0", Offset = "0x62BCCF0", VA = "0x1862BDAF0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x62BDBF0", Offset = "0x62BCDF0", VA = "0x1862BDBF0")]
		public HairData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public interface EFLCEOJGFKB
{
	[Cpp2IlInjected.Token(Token = "0x1700003D")]
	bool ILLMPLPNDLB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	PILCNIJAOHN BIFLFFCHNJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
namespace RecRoom.Avatars.Data.Shared
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public class SerializedAvatarItemData
	{
		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0x7CB530", Offset = "0x7CA730", VA = "0x1807CB530")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B5")]
			[Cpp2IlInjected.Address(RVA = "0x7CB4D0", Offset = "0x7CA6D0", VA = "0x1807CB4D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public OutfitType OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x7D01E0", Offset = "0x7CF3E0", VA = "0x1807D01E0")]
			[CompilerGenerated]
			get
			{
				return default(OutfitType);
			}
			[Cpp2IlInjected.Token(Token = "0x60000B7")]
			[Cpp2IlInjected.Address(RVA = "0x7CFAB0", Offset = "0x7CECB0", VA = "0x1807CFAB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public OutfitType[] SecondaryOutfitTypes
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x7CB4C0", Offset = "0x7CA6C0", VA = "0x1807CB4C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000B9")]
			[Cpp2IlInjected.Address(RVA = "0x7CAF90", Offset = "0x7CA190", VA = "0x1807CAF90")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public bool HidesHands
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x9B6690", Offset = "0x9B5890", VA = "0x1809B6690")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0xA8C3F0", Offset = "0xA8B5F0", VA = "0x180A8C3F0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public bool HidesLeftEar
		{
			[Cpp2IlInjected.Token(Token = "0x60000BC")]
			[Cpp2IlInjected.Address(RVA = "0xD19090", Offset = "0xD18290", VA = "0x180D19090")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BD")]
			[Cpp2IlInjected.Address(RVA = "0xD18870", Offset = "0xD17A70", VA = "0x180D18870")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public bool HidesRightEar
		{
			[Cpp2IlInjected.Token(Token = "0x60000BE")]
			[Cpp2IlInjected.Address(RVA = "0x1DC80F0", Offset = "0x1DC72F0", VA = "0x181DC80F0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000BF")]
			[Cpp2IlInjected.Address(RVA = "0x1DC8100", Offset = "0x1DC7300", VA = "0x181DC8100")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public bool UsesTeamColor
		{
			[Cpp2IlInjected.Token(Token = "0x60000C0")]
			[Cpp2IlInjected.Address(RVA = "0x1316350", Offset = "0x1315550", VA = "0x181316350")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C1")]
			[Cpp2IlInjected.Address(RVA = "0x62BEA70", Offset = "0x62BDC70", VA = "0x1862BEA70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public Vector3? CustomImposterRotationOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60000C2")]
			[Cpp2IlInjected.Address(RVA = "0x2204490", Offset = "0x2203690", VA = "0x182204490")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x22043C0", Offset = "0x22035C0", VA = "0x1822043C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public float? CustomImposterScale
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x1A530B0", Offset = "0x1A522B0", VA = "0x181A530B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000C5")]
			[Cpp2IlInjected.Address(RVA = "0x1A530E0", Offset = "0x1A522E0", VA = "0x181A530E0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public bool HasLeftAndRightMeshes
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0xD131C0", Offset = "0xD123C0", VA = "0x180D131C0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0xD187A0", Offset = "0xD179A0", VA = "0x180D187A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public IOOMDAFGOFE ItemBodyType
		{
			[Cpp2IlInjected.Token(Token = "0x60000C8")]
			[Cpp2IlInjected.Address(RVA = "0x865120", Offset = "0x864320", VA = "0x180865120")]
			[CompilerGenerated]
			get
			{
				return default(IOOMDAFGOFE);
			}
			[Cpp2IlInjected.Token(Token = "0x60000C9")]
			[Cpp2IlInjected.Address(RVA = "0xA5E750", Offset = "0xA5D950", VA = "0x180A5E750")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public GKPJGAOJHHB.JGJMGEIKMEE ApplySkinMask
		{
			[Cpp2IlInjected.Token(Token = "0x60000CA")]
			[Cpp2IlInjected.Address(RVA = "0x953290", Offset = "0x952490", VA = "0x180953290")]
			[CompilerGenerated]
			get
			{
				return default(GKPJGAOJHHB.JGJMGEIKMEE);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x94B640", Offset = "0x94A840", VA = "0x18094B640")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public AdditionalOutfitTypeData OutfitTypeData
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x7CBF80", Offset = "0x7CB180", VA = "0x1807CBF80")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x7CBF70", Offset = "0x7CB170", VA = "0x1807CBF70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public Guid ProxyAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x60000CE")]
			[Cpp2IlInjected.Address(RVA = "0xB7FD60", Offset = "0xB7EF60", VA = "0x180B7FD60")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x60000CF")]
			[Cpp2IlInjected.Address(RVA = "0x1286500", Offset = "0x1285700", VA = "0x181286500")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public Guid AvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x60000D0")]
			[Cpp2IlInjected.Address(RVA = "0xF90690", Offset = "0xF8F890", VA = "0x180F90690")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D1")]
			[Cpp2IlInjected.Address(RVA = "0x3E071C0", Offset = "0x3E063C0", VA = "0x183E071C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x7D45D0", Offset = "0x7D37D0", VA = "0x1807D45D0")]
		public SerializedAvatarItemData()
		{
		}
	}
}
namespace RecRoom.Avatars.Face
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public sealed class BrowsFaceFeature : SymmetricalFaceFeature
	{
		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x832EE0", Offset = "0x8320E0", VA = "0x180832EE0", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x62B9B90", Offset = "0x62B8D90", VA = "0x1862B9B90")]
		public BrowsFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public sealed class EyesFaceFeature : SymmetricalFaceFeature
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		public Vector2 MaxGleamJitterScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		public Vector2 MaxGleamJitterOffsetAnchors;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		public bool JitterGleamSymmetrically;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public Vector2 GleamJitterMultiplier;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x7C9E00", Offset = "0x7C9000", VA = "0x1807C9E00", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public Vector2 JitteredEyeGleamOffsetLeft
		{
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x62BB170", Offset = "0x62BA370", VA = "0x1862BB170")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x62BB1D0", Offset = "0x62BA3D0", VA = "0x1862BB1D0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public Vector2 JitteredEyeGleamOffsetRight
		{
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x62BB190", Offset = "0x62BA390", VA = "0x1862BB190")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0x62BB1E0", Offset = "0x62BA3E0", VA = "0x1862BB1E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public Vector2 JitteredEyeGleamScaleLeft
		{
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0xB00C30", Offset = "0xAFFE30", VA = "0x180B00C30")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0x18EC220", Offset = "0x18EB420", VA = "0x1818EC220")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public Vector2 JitteredEyeGleamScaleRight
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x62BB1B0", Offset = "0x62BA3B0", VA = "0x1862BB1B0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x62BB1F0", Offset = "0x62BA3F0", VA = "0x1862BB1F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x62BAD60", Offset = "0x62B9F60", VA = "0x1862BAD60", Slot = "7")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x62BB060", Offset = "0x62BA260", VA = "0x1862BB060")]
		public EyesFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public abstract class FaceFeature : FaceFeatureBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public Vector2 DefaultAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public Vector2 MaxJitterAnchor;

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public Vector2 JitteredAnchor
		{
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x62BC2C0", Offset = "0x62BB4C0", VA = "0x1862BC2C0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0xFD65E0", Offset = "0xFD57E0", VA = "0x180FD65E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public Vector2 JitteredOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0xBCCD70", Offset = "0xBCBF70", VA = "0x180BCCD70")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0xFD57C0", Offset = "0xFD49C0", VA = "0x180FD57C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x62BC080", Offset = "0x62BB280", VA = "0x1862BC080", Slot = "7")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x62BC1C0", Offset = "0x62BB3C0", VA = "0x1862BC1C0")]
		protected FaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	public abstract class FaceFeatureBase : SelectableFaceOption
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000042")]
		[CompilerGenerated]
		private struct <LoadSpriteAssetsAsync>d__26 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400017D")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x400017E")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400017F")]
			public FaceFeatureBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x4000180")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x62BF020", Offset = "0x62BE220", VA = "0x1862BF020", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x62BFD80", Offset = "0x62BEF80", VA = "0x1862BFD80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400016F")]
		private static readonly string[] FACE_FEATURE_ASSET_PATHS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		private readonly List<AECHCDNEFCI<Sprite>> _spriteResourceHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		private readonly List<Sprite> _loadedSprites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		private Task _activelyLoadingTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		private int _referenceCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		[SerializeField]
		private List<AssetReference> SpriteReferences;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		[SerializeField]
		private Sprite[] DefaultSprites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		public Vector2 DefaultScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		public Vector2 MaxJitterScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public Vector2 JitterMultiplier;

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public string DefaultSpriteName
		{
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0x7CE890", Offset = "0x7CDA90", VA = "0x1807CE890")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x7CE960", Offset = "0x7CDB60", VA = "0x1807CE960")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public IEnumerable<Sprite> SrcLoadedSprites
		{
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x62BBFD0", Offset = "0x62BB1D0", VA = "0x1862BBFD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public int TextureCount
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0x62BC040", Offset = "0x62BB240", VA = "0x1862BC040")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public bool IsLoaded
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x62BBF80", Offset = "0x62BB180", VA = "0x1862BBF80")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public Vector2 JitteredScale
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x516BE30", Offset = "0x516B030", VA = "0x18516BE30")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x516BF90", Offset = "0x516B190", VA = "0x18516BF90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x62BBA60", Offset = "0x62BAC60", VA = "0x1862BBA60")]
		protected static Vector2 JitteredVector2(Vector2 initial, Vector2 maxJitter)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0x62BBBA0", Offset = "0x62BADA0", VA = "0x1862BBBA0", Slot = "7")]
		public virtual void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0x62BBAD0", Offset = "0x62BACD0", VA = "0x1862BBAD0")]
		[AsyncStateMachine(typeof(<LoadSpriteAssetsAsync>d__26))]
		public Task LoadSpriteAssetsAsync()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x62BBC80", Offset = "0x62BAE80", VA = "0x1862BBC80")]
		public void ReleaseSpriteResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x62BB850", Offset = "0x62BAA50", VA = "0x1862BB850")]
		private void DisposeAllSpriteResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x62BBD80", Offset = "0x62BAF80", VA = "0x1862BBD80")]
		protected FaceFeatureBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000043")]
	public enum FaceFeatureType
	{
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		Eye,
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		Mouth,
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		Nose,
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		Brows
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public sealed class CBIMLGEJDAN : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	[CompilerGenerated]
	private struct FCAEMACIBJN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public AsyncTaskMethodBuilder<CBIMLGEJDAN> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public SymmetricalFaceFeature eyeBrow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		public EyesFaceFeature eye;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public FaceFeature mouth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		private BPDAEKAOABP.EJKMCACJODA <__>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x62BB200", Offset = "0x62BA400", VA = "0x1862BB200", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x62BB7E0", Offset = "0x62BA9E0", VA = "0x1862BB7E0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000186")]
	private readonly Dictionary<string, int> JBCGDELAKBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400018B")]
	private bool KMJJMNMDBHB;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public Texture2DArray NJNPEOODOKE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x7CB510", Offset = "0x7CA710", VA = "0x1807CB510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x7CAF80", Offset = "0x7CA180", VA = "0x1807CAF80")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public SymmetricalFaceFeature IGMHGKNIPAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x7CB4C0", Offset = "0x7CA6C0", VA = "0x1807CB4C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7CAF90", Offset = "0x7CA190", VA = "0x1807CAF90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public EyesFaceFeature FJJBIKIGCOP
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x7CB520", Offset = "0x7CA720", VA = "0x1807CB520")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x7CB4F0", Offset = "0x7CA6F0", VA = "0x1807CB4F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public FaceFeature NCOMOGNPBEO
	{
		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x7CB4E0", Offset = "0x7CA6E0", VA = "0x1807CB4E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x7CB500", Offset = "0x7CA700", VA = "0x1807CB500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x62B9E80", Offset = "0x62B9080", VA = "0x1862B9E80")]
	private static void FJCJAADJKED(Sprite ODKDIDDOPLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x62BA650", Offset = "0x62B9850", VA = "0x1862BA650")]
	public static CBIMLGEJDAN KHKENJCGAKB(SymmetricalFaceFeature HDPEMHOHBPG, EyesFaceFeature CDPBAAOHLIE, FaceFeature AMMKHHABEOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x62B9BA0", Offset = "0x62B8DA0", VA = "0x1862B9BA0")]
	[AsyncStateMachine(typeof(FCAEMACIBJN))]
	public static Task<CBIMLGEJDAN> BOAAAPDKMOB(SymmetricalFaceFeature HDPEMHOHBPG, EyesFaceFeature CDPBAAOHLIE, FaceFeature AMMKHHABEOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x62BA8D0", Offset = "0x62B9AD0", VA = "0x1862BA8D0")]
	private CBIMLGEJDAN(SymmetricalFaceFeature HDPEMHOHBPG, EyesFaceFeature CDPBAAOHLIE, FaceFeature AMMKHHABEOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000105")]
	[Cpp2IlInjected.Address(RVA = "0x62B9EF0", Offset = "0x62B90F0", VA = "0x1862B9EF0")]
	private void GKPKEMCHEGJ(List<Sprite> DDGAECAEJEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000106")]
	[Cpp2IlInjected.Address(RVA = "0x62BA6E0", Offset = "0x62B98E0", VA = "0x1862BA6E0")]
	public bool ONOJNFFAFDG(string EGDKADKJOOK, [Out] int PMNHOLIPOMJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000107")]
	[Cpp2IlInjected.Address(RVA = "0x62B9E50", Offset = "0x62B9050", VA = "0x1862B9E50", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000108")]
	[Cpp2IlInjected.Address(RVA = "0x62B9D60", Offset = "0x62B8F60", VA = "0x1862B9D60")]
	public bool DOILPLLJOOE()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000109")]
	[Cpp2IlInjected.Address(RVA = "0x62B9CE0", Offset = "0x62B8EE0", VA = "0x1862B9CE0")]
	public void CGLGBIFJLCF()
	{
	}
}
namespace RecRoom.Avatars.Face
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public sealed class MouthFaceFeature : FaceFeature
	{
		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x831ED0", Offset = "0x8310D0", VA = "0x180831ED0", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x62BC1C0", Offset = "0x62BB3C0", VA = "0x1862BC1C0")]
		public MouthFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public sealed class NoseFaceOption : SelectableFaceOption
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public HCHPGDCFMBM SelectedNoseType;

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x6000111")]
			[Cpp2IlInjected.Address(RVA = "0x847C60", Offset = "0x846E60", VA = "0x180847C60", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x834750", Offset = "0x833950", VA = "0x180834750")]
		public NoseFaceOption()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	public abstract class SelectableFaceOption : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		[Tooltip("This guid is auto generated at the time of the asset creation and should never change if you do not want to break an existing player's feature selection")]
		[SerializeField]
		[Obsolete("Use FaceFeatureId instead!")]
		protected string GuidString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		[SerializeField]
		private SerializedFaceFeatureId faceFeatureId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		[SerializeField]
		private Sprite menuButtonSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		[SerializeField]
		private bool isNoneOption;

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public PLPCONDGDMD FaceFeatureId
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x923140", Offset = "0x922340", VA = "0x180923140")]
			get
			{
				return default(PLPCONDGDMD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		public bool IsNoneOption
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x90C730", Offset = "0x90B930", VA = "0x18090C730")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x7CB4E0", Offset = "0x7CA6E0", VA = "0x1807CB4E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public abstract FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x923690", Offset = "0x922890", VA = "0x180923690", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x7C9DF0", Offset = "0x7C8FF0", VA = "0x1807C9DF0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x834750", Offset = "0x833950", VA = "0x180834750")]
		protected SelectableFaceOption()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public abstract class SymmetricalFaceFeature : FaceFeatureBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400019A")]
		public Vector2 MaxJitterAnchors;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400019B")]
		public bool JitterSymetrically;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public Vector2 DefaultAnchorLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x400019F")]
		public Vector2 DefaultAnchorRight;

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public Vector2 JitteredAnchorLeft
		{
			[Cpp2IlInjected.Token(Token = "0x600011A")]
			[Cpp2IlInjected.Address(RVA = "0x62BEFA0", Offset = "0x62BE1A0", VA = "0x1862BEFA0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600011B")]
			[Cpp2IlInjected.Address(RVA = "0xDBEC40", Offset = "0xDBDE40", VA = "0x180DBEC40")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public Vector2 JitteredOffsetLeft
		{
			[Cpp2IlInjected.Token(Token = "0x600011C")]
			[Cpp2IlInjected.Address(RVA = "0x62BEFE0", Offset = "0x62BE1E0", VA = "0x1862BEFE0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x58B3670", Offset = "0x58B2870", VA = "0x1858B3670")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public Vector2 JitteredAnchorRight
		{
			[Cpp2IlInjected.Token(Token = "0x600011E")]
			[Cpp2IlInjected.Address(RVA = "0x62BEFC0", Offset = "0x62BE1C0", VA = "0x1862BEFC0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x58B6940", Offset = "0x58B5B40", VA = "0x1858B6940")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public Vector2 JitteredOffsetRight
		{
			[Cpp2IlInjected.Token(Token = "0x6000120")]
			[Cpp2IlInjected.Address(RVA = "0x62BF000", Offset = "0x62BE200", VA = "0x1862BF000")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x58B6930", Offset = "0x58B5B30", VA = "0x1858B6930")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x62BECC0", Offset = "0x62BDEC0", VA = "0x1862BECC0", Slot = "7")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x62BEED0", Offset = "0x62BE0D0", VA = "0x1862BEED0")]
		protected SymmetricalFaceFeature()
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
