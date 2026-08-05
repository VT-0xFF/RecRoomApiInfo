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
public interface MJPAACGOJDG
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	float OGBODFHFNJD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	float EAMKCJJAKME
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	float GLGDKBGNDGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	float PBEKCEIHLLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float LPPIDIHOAHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	float DEPONCDCAID
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float MIOBAOOHMNL
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float EHHDCDENOON
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float FLOEHPGLCHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	float BBEHGDNIKKP
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	float KHNIEGOILFH
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	float IAGOLONBBBM
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	float DPGLFIHINOP
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	float LBJAIFPDDKP
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	float OFHOIBEHKPJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	float LPOJINFFLHB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Vector3 EEJBKLPCHIA(Vector3 PJBOJGIPEHE);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Vector3 KOJJODFLDOM(Vector3 BDFAADHJMCA);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Vector3 KOBHLGOFOKJ();
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class AnchorParamsRestrictions : MJPAACGOJDG
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
			[Cpp2IlInjected.Address(RVA = "0x897580", Offset = "0x896180", VA = "0x180897580", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool GetAllowRotations
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xB6AC20", Offset = "0xB69820", VA = "0x180B6AC20", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8B3230", Offset = "0x8B1E30", VA = "0x1808B3230", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8B31F0", Offset = "0x8B1DF0", VA = "0x1808B31F0", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8B3220", Offset = "0x8B1E20", VA = "0x1808B3220", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x8B3200", Offset = "0x8B1E00", VA = "0x1808B3200", Slot = "7")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8B31E0", Offset = "0x8B1DE0", VA = "0x1808B31E0", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x873480", Offset = "0x872080", VA = "0x180873480", Slot = "9")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 DefaultOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x67834A0", Offset = "0x67820A0", VA = "0x1867834A0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x8B3180", Offset = "0x8B1D80", VA = "0x1808B3180", Slot = "12")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x8B39B0", Offset = "0x8B25B0", VA = "0x1808B39B0", Slot = "13")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x8B31A0", Offset = "0x8B1DA0", VA = "0x1808B31A0", Slot = "10")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x8B31B0", Offset = "0x8B1DB0", VA = "0x1808B31B0", Slot = "11")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x8B38B0", Offset = "0x8B24B0", VA = "0x1808B38B0", Slot = "14")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x8B38A0", Offset = "0x8B24A0", VA = "0x1808B38A0", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public Vector3 DefaultRotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6783540", Offset = "0x6782140", VA = "0x186783540")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public float GetMaxUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x8B3930", Offset = "0x8B2530", VA = "0x1808B3930", Slot = "16")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float GetMinUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x8B3980", Offset = "0x8B2580", VA = "0x1808B3980", Slot = "17")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x8B3960", Offset = "0x8B2560", VA = "0x1808B3960", Slot = "18")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x85E7D0", Offset = "0x85D3D0", VA = "0x18085E7D0", Slot = "19")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public Vector2 URange
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x6783F10", Offset = "0x6782B10", VA = "0x186783F10")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x6783F50", Offset = "0x6782B50", VA = "0x186783F50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public Vector2 VRange
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x6783F30", Offset = "0x6782B30", VA = "0x186783F30")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x6783F70", Offset = "0x6782B70", VA = "0x186783F70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002C")]
		[Cpp2IlInjected.Address(RVA = "0x6783E80", Offset = "0x6782A80", VA = "0x186783E80")]
		public AnchorParamsRestrictions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x6783AD0", Offset = "0x67826D0", VA = "0x186783AD0")]
		public POPGKCADAAO PHIOOGDEGPM(POPGKCADAAO BAJDEIKPEAL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x6783540", Offset = "0x6782140", VA = "0x186783540", Slot = "25")]
		public Vector3 KOPJKKJJAOB()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600002F")]
		[Cpp2IlInjected.Address(RVA = "0x67834A0", Offset = "0x67820A0", VA = "0x1867834A0", Slot = "22")]
		public Vector3 KOBHLGOFOKJ()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6783320", Offset = "0x6781F20", VA = "0x186783320", Slot = "20")]
		public Vector3 EEJBKLPCHIA(Vector3 PJBOJGIPEHE)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x67834C0", Offset = "0x67820C0", VA = "0x1867834C0", Slot = "21")]
		public Vector3 KOJJODFLDOM(Vector3 BDFAADHJMCA)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6783390", Offset = "0x6781F90", VA = "0x186783390", Slot = "0")]
		public override bool Equals(object HAHECKLGOJC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6783560", Offset = "0x6782160", VA = "0x186783560")]
		protected bool NKPGMPOIHJL(AnchorParamsRestrictions OCNJFCPHJLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6783A60", Offset = "0x6782660", VA = "0x186783A60")]
		[CompilerGenerated]
		internal static bool OLMJBFDHMEC(float NABHBOMGBNH, float EIKHFLMLKJH)
		{
			return default(bool);
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public class AvatarBodyPartBoneData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public bool HasLocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public bool HasLocalRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public bool HasLocalScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public Vector3 LocalPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public Quaternion LocalRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		public Vector3 LocalScale;

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6783F90", Offset = "0x6782B90", VA = "0x186783F90", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public AvatarBodyPartBoneData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct FaceShapeAnimationInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		public AvatarFaceShapeData.GBHONPHPKHH FaceShapeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		public AnimationClip FaceShapeAnimationClip;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public struct BodyShapeAnimationInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		public AvatarBodyShapeData.LDEABGDMDAI BodyShapeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		public AnimationClip BodyShapeAnimationClip;
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public class AvatarBodyPartShapesManager : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x2000008")]
		[CompilerGenerated]
		private sealed class AFEJJHHJIIE
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			public AvatarFaceShapeBoneData faceShapeData;

			[Cpp2IlInjected.Token(Token = "0x6000040")]
			[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
			public AFEJJHHJIIE()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0x67828E0", Offset = "0x67814E0", VA = "0x1867828E0")]
			internal bool LKHBLLCNFAI(KeyValuePair<string, Transform> bone)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000009")]
		[CompilerGenerated]
		private sealed class GLBGDLFFNBM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000041")]
			public AvatarBodyShapeBoneData bodyShapeData;

			[Cpp2IlInjected.Token(Token = "0x6000042")]
			[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
			public GLBGDLFFNBM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000043")]
			[Cpp2IlInjected.Address(RVA = "0x67897F0", Offset = "0x67883F0", VA = "0x1867897F0")]
			internal bool HFMCMMJKJEC(KeyValuePair<string, Transform> bone)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400002C")]
		private const float ANIM_CLIP_EVAL_TIME = 0f;

		[Cpp2IlInjected.Token(Token = "0x400002D")]
		private const string TWEAK_BONE_NAME_EXTENSION = "Tweak";

		[Cpp2IlInjected.Token(Token = "0x400002E")]
		private const string SHAPER_BONE_NAME_EXTENSION = "Shaper";

		[Cpp2IlInjected.Token(Token = "0x400002F")]
		private const string LOCAL_POSITION_X_PROPERTY_NAME = "m_LocalPosition.x";

		[Cpp2IlInjected.Token(Token = "0x4000030")]
		private const string LOCAL_POSITION_Y_PROPERTY_NAME = "m_LocalPosition.y";

		[Cpp2IlInjected.Token(Token = "0x4000031")]
		private const string LOCAL_POSITION_Z_PROPERTY_NAME = "m_LocalPosition.z";

		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private const string LOCAL_EULER_ANGLES_X_PROPERTY_NAME = "localEulerAnglesRaw.x";

		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private const string LOCAL_EULER_ANGLES_Y_PROPERTY_NAME = "localEulerAnglesRaw.y";

		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private const string LOCAL_EULER_ANGLES_Z_PROPERTY_NAME = "localEulerAnglesRaw.z";

		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private const string LOCAL_SCALE_X_PROPERTY_NAME = "m_LocalScale.x";

		[Cpp2IlInjected.Token(Token = "0x4000036")]
		private const string LOCAL_SCALE_Y_PROPERTY_NAME = "m_LocalScale.y";

		[Cpp2IlInjected.Token(Token = "0x4000037")]
		private const string LOCAL_SCALE_Z_PROPERTY_NAME = "m_LocalScale.z";

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[SerializeField]
		private List<FaceShapeAnimationInfo> faceShapeAnimationInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		private List<BodyShapeAnimationInfo> bodyShapeAnimationInfo;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private List<AvatarFaceShapeBoneData> faceShapeBoneData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[SerializeField]
		private List<AvatarBodyShapeBoneData> bodyShapeBoneData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private readonly Dictionary<(string, AvatarFaceShapeData.GBHONPHPKHH), AvatarBodyPartBoneData> boneNameToFaceShapeDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private readonly Dictionary<(string, AvatarBodyShapeData.LDEABGDMDAI), AvatarBodyPartBoneData> boneNameToBodyShapeDataMapping;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private readonly List<string> faceBonesToUpdate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private readonly List<string> bodyBonesToUpdate;

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x67846A0", Offset = "0x67832A0", VA = "0x1867846A0")]
		public void EHHLDMLDHNI(IReadOnlyDictionary<string, Transform> DMKPIOFOPMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x67843B0", Offset = "0x6782FB0", VA = "0x1867843B0")]
		public void AOKNJJBGLIM(IReadOnlyDictionary<string, Transform> DMKPIOFOPMP, AvatarFaceShapeData.GBHONPHPKHH AEGMFFKJOCB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6784120", Offset = "0x6782D20", VA = "0x186784120")]
		public void ANCELALNALO(IReadOnlyDictionary<string, Transform> DMKPIOFOPMP, AvatarBodyShapeData.LDEABGDMDAI IOMBKHDAGIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6784CA0", Offset = "0x67838A0", VA = "0x186784CA0")]
		private Vector3 INBNACIAEKE(Transform MOEKKGKEANC, AvatarBodyPartBoneData PNOAMGJCACA)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6784640", Offset = "0x6783240", VA = "0x186784640")]
		private Quaternion DLIIECBDPGF(Transform MOEKKGKEANC, AvatarBodyPartBoneData PNOAMGJCACA)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6784D10", Offset = "0x6783910", VA = "0x186784D10")]
		private Vector3 LBNKLOBPHNA(Transform MOEKKGKEANC, AvatarBodyPartBoneData PNOAMGJCACA)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x6784D80", Offset = "0x6783980", VA = "0x186784D80")]
		private void OBOMGJGDDIE(Transform MOEKKGKEANC, AvatarBodyPartBoneData PNOAMGJCACA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6784E80", Offset = "0x6783A80", VA = "0x186784E80")]
		public AvatarBodyPartShapesManager()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000A")]
	public class AvatarBodyShapeData
	{
		[Cpp2IlInjected.Token(Token = "0x200000B")]
		public enum LDEABGDMDAI
		{
			[Cpp2IlInjected.Token(Token = "0x4000045")]
			None,
			[Cpp2IlInjected.Token(Token = "0x4000046")]
			Pear,
			[Cpp2IlInjected.Token(Token = "0x4000047")]
			Apple,
			[Cpp2IlInjected.Token(Token = "0x4000048")]
			Triangle,
			[Cpp2IlInjected.Token(Token = "0x4000049")]
			Hourglass,
			[Cpp2IlInjected.Token(Token = "0x400004A")]
			Square
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public LDEABGDMDAI blendShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		[Range(0f, 2f)]
		public float value;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public AvatarBodyShapeData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public class AvatarBodyShape : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		[Obsolete("Use BodyShapeId instead!")]
		[HideInInspector]
		[SerializeField]
		private string guidString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		[SerializeField]
		private SerializedBodyShapeId bodyShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public string FriendlyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		[SerializeField]
		private Sprite menuButtonSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public AvatarBodyShapeData[] map;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public CPONPOCPOHL BodyShapeId
		{
			[Cpp2IlInjected.Token(Token = "0x6000045")]
			[Cpp2IlInjected.Address(RVA = "0x9C47B0", Offset = "0x9C33B0", VA = "0x1809C47B0")]
			get
			{
				return default(CPONPOCPOHL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x6000046")]
			[Cpp2IlInjected.Address(RVA = "0x843220", Offset = "0x841E20", VA = "0x180843220")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6785300", Offset = "0x6783F00", VA = "0x186785300")]
		public AvatarBodyShape()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public class AvatarBodyShapeBoneData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public AvatarBodyShapeData.LDEABGDMDAI BodyShapeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AvatarBodyPartBoneData AvatarBodyPartBoneData;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6785080", Offset = "0x6783C80", VA = "0x186785080", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public AvatarBodyShapeBoneData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class DEPGENALEBH
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	private Transform[] OGBBGLGFPOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	private readonly Dictionary<string, Transform> MCGHIENLIJF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	private readonly Dictionary<Transform, Transform> JEEEHNEDMPB;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public IReadOnlyDictionary<string, Transform> HFFEIGABBLG
	{
		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public Transform[] OPKLDPJLFOH
	{
		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x843370", Offset = "0x841F70", VA = "0x180843370")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x6787730", Offset = "0x6786330", VA = "0x186787730")]
	public void PIFFFEFNFIG(Transform NHCCINMELAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x67872B0", Offset = "0x6785EB0", VA = "0x1867872B0")]
	public Transform FIHCKGEAKMD(Transform APCLODKMIEM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x67874F0", Offset = "0x67860F0", VA = "0x1867874F0")]
	public void NNDCHNAPICC(SkinnedMeshRenderer JEOIALKABFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6787390", Offset = "0x6785F90", VA = "0x186787390")]
	private static void GDNBJKMKCND(Transform BLPDMPJLPPJ, List<Transform> NJLPBEBOIPJ, Dictionary<string, Transform> NKOLKBIPOEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6787810", Offset = "0x6786410", VA = "0x186787810")]
	public DEPGENALEBH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class EFHJEIJOCLJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public bool CLFABFPNFJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public bool LLBMGAADPBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public EPAIPDBBJOB? IFKDPADLOCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public OCPDNKAOFCI.LFAEFIBNIJB EGBOMNIBGKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public Texture2D HDHCNOEMLPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public Texture2D IJDNGDGPOCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public IList<MFEHKIDNCCC> IOMPHHANKMA;

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public EFHJEIJOCLJ()
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public abstract class AvatarConfiguration : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		[Tooltip("How far apart you can position your eyebrows.")]
		[Header("Face Features")]
		public Vector2 EyebrowsHorizontalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		[Tooltip("How far up and down you can position your eyebrows.")]
		public Vector2 EyebrowsVerticalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		[Tooltip("How small/large you can scale your eyebrows.")]
		public Vector2 EyebrowsScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		[Tooltip("How far apart can position your eyes.")]
		public Vector2 EyesHorizontalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		[Tooltip("How far up and down you can position your eyes.")]
		public Vector2 EyesVerticalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		[Tooltip("How small/large you can scale your eyes.")]
		public Vector2 EyeScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		[Tooltip("How far left and right you can position your mouth.")]
		public Vector2 MouthHorizontalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		[Tooltip("How far up and down you can position your mouth.")]
		public Vector2 MouthVerticalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		[Tooltip("How small/large you can scale your mouth.")]
		public Vector2 MouthScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		[Tooltip("How far left and right you can position your nose.")]
		public Vector2 NoseHorizontalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		[Tooltip("How far up and down you can position your nose.")]
		public Vector2 NoseVerticalPositionRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		[Tooltip("How small/large you can scale your nose.")]
		public Vector2 NoseScaleRange;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		[Tooltip("A constant multiplier on all eye jitter.")]
		public Vector2 GlobalEyeJitterMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		[Tooltip("A constant multiplier on all eye gleam jitter.")]
		public Vector2 GlobalEyeGleamJitterMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		[Tooltip("A constant multiplier on all eyebrow jitter.")]
		public Vector2 GlobalEyebrowJitterMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		[Tooltip("A constant multiplier on all mouth jitter.")]
		public Vector2 GlobalMouthJitterMultiplier;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		[Tooltip("Used to scale a face bone into UV space by scaling to the bone's (x,y) position")]
		public Vector2 ScaleFaceBonesToUVs;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		[Tooltip("Used to translate all face bone into UV space by adding the offset to the post-scaled bone (x,y) position")]
		public Vector2 TranslateFaceBonesToUVsOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		[Tooltip("Used to translate the eye brow bones into UV space by adding to the post-scaled bone (x,y) position")]
		public Vector2 TranslateEyeBrowBonesToUVsOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		[Tooltip("Used to translate the eye bones into UV space by adding to the post-scaled bone (x,y) position")]
		public Vector2 TranslateEyeBonesToUVsOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		[Tooltip("Used to translate the mouth bones into UV space by adding to the post-scaled bone (x,y) position")]
		public Vector2 TranslateMouthBoneToUVsOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		[Tooltip("Minimum distance used to decrowd eyes to brows in vertical UV space")]
		public float MinDistFromEyesToBrowsInUVVerticalSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC4")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		[Tooltip("Minimum distance used to decrowd nose to eyes in vertical UV space")]
		public float MinDistFromNoseToEyesInUVVerticalSpace;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		[Tooltip("Minimum distance used to decrowd mouth to nose in vertical UV space")]
		public float MinDistFromMouthToNoseInUVVerticalSpace;

		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0x6785390", Offset = "0x6783F90", VA = "0x186785390")]
		protected AvatarConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class FHCNOLGBLKG
{
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public static readonly MCENINEIDDK EFFIPNCEIAL;

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public static POPGKCADAAO IIILGGHAOFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000055")]
		[Cpp2IlInjected.Address(RVA = "0x6787DC0", Offset = "0x67869C0", VA = "0x186787DC0")]
		get
		{
			return null;
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct MFBFMPCFHEP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public Transform JBDFBJGDCGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public AssetReference NFEHBHEOGID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public GameObject NNBOCBJNEML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public GameObject DNDFNLCKFAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public SkinnedMeshRenderer KGFDENONOFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public AvatarSkinnedMeshBoneOrderRemapsData OLKCMPAIMOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public Material LOFNDJKEGGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public Material KCDFFIJGFKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public Material CFMFJCNABMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public Shader INOBODGCNKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public Shader DGGFCLEMLLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public Animator KKIHBANPNAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public Renderer[] BAOOJKMJFOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	public AvatarConfiguration IBFACOPPGEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	public AvatarBodyPartShapesManager NAKPDCFIGMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public IReadOnlyDictionary<string, Transform> FKHMBLKACMJ;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public struct AIOPABHBAFF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public SkinnedMeshRenderer[] LFNPDDHMJEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public SkinnedMeshRenderer[] PLOKAGEDJMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public SkinnedMeshRenderer[] EJEPCGPEKCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public SkinnedMeshRenderer[] CDEPLPKABDE;
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000014")]
	public struct BodySkinnedMeshLODs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		public SkinnedMeshRenderer[] LODs;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public struct POJPECEJPPN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public Transform KJNHKEIHJLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	public Transform DCOJILOCLNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public Transform KCCAPDGHOKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public Transform IKIMFAMPNCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	public Transform GPOJGDFIBKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public Transform OBFEMNEFOBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public Transform GINENDNHBGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public AvatarConfiguration IBFACOPPGEB;
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public struct OOHMCNLKMGM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	public SkinnedMeshRenderer[] EBDOCBIDALM;
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public struct AJPBPBCKEJN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	public OFIAGAGHOCM FIHEIGNELKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	public int NGMLNEPBNPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	public int DDJKCKDDBNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	public Color HLLJKFIACAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	public Color POAEJDLENOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	public int MLKFILIGKLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public int FDENLECLENE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	public Color COJEBGAPEJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	public Color JBMIGFNKJIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	public int CPCENAMHHIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	public float MDGIMEAJAJE;
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public struct CLAMMCFGNOO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	public OFIAGAGHOCM FIHEIGNELKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	public Vector2 PKNFBGNPJOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	public float DBEGNPKPDIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	public Vector2 IMFIKNJADIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public float LJPNJEHFEND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	public Vector2 BDJDIBFGMPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	public float FEGMJLNKMMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	public Vector2 BCCGBPDCNFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	public float GLLIBBIJDJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	public bool GAJHMJIEILI;
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class AvatarFaceShapeData
	{
		[Cpp2IlInjected.Token(Token = "0x200001A")]
		public enum GBHONPHPKHH
		{
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			None,
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			Heart,
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			Oval,
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			Pointy,
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			Round,
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			Square
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		public GBHONPHPKHH blendShape;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		[Range(0f, 2f)]
		public float value;

		[Cpp2IlInjected.Token(Token = "0x6000057")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public AvatarFaceShapeData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class AvatarFaceShape : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		[HideInInspector]
		[Obsolete("Use FaceShapeId instead!")]
		[SerializeField]
		private string guidString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		[SerializeField]
		private SerializedFaceShapeId faceShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public string FriendlyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		[SerializeField]
		private Sprite menuButtonSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public AvatarFaceShapeData[] map;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public FKGKDBCHMBL FaceShapeId
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x9C47B0", Offset = "0x9C33B0", VA = "0x1809C47B0")]
			get
			{
				return default(FKGKDBCHMBL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x843220", Offset = "0x841E20", VA = "0x180843220")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600005A")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005B")]
		[Cpp2IlInjected.Address(RVA = "0x67858C0", Offset = "0x67844C0", VA = "0x1867858C0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600005C")]
		[Cpp2IlInjected.Address(RVA = "0x6785920", Offset = "0x6784520", VA = "0x186785920")]
		public AvatarFaceShape()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class AvatarFaceShapeBoneData
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public AvatarFaceShapeData.GBHONPHPKHH FaceShapeName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public string BoneName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public AvatarBodyPartBoneData AvatarBodyPartBoneData;

		[Cpp2IlInjected.Token(Token = "0x600005D")]
		[Cpp2IlInjected.Address(RVA = "0x6785640", Offset = "0x6784240", VA = "0x186785640", Slot = "3")]
		public override string ToString()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600005E")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public AvatarFaceShapeBoneData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class MFEHKIDNCCC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	public string JBJAOBKIEOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	public OutfitType APHPOMMLLOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	public BHNAMMMFFGC DNOELALLCLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	public OCPDNKAOFCI.LFAEFIBNIJB JIMPJBNMAML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	public bool ILMMGCMIKNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x25")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	public bool DEIDKNHKKKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x26")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	public bool ACEHGIFCIAD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public Color? GHEOAADIGEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	public Guid? LLLHNLOHOPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	public Color? JBNHMAJHDCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public bool BBEFBDLLDMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x65")]
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	public bool OALPFFOLCAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	public Transform HIMNMLDBGGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	public Vector2? PKIFHCJFLPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	public FitMeshHemisphere EIJNJNJGONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	public AssetReference AKOIADBFHKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	public AssetReference KPJELJGGEMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	public AssetReference[] POAKEGOGJJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	public bool EHJPMDINFNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA1")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public bool EMFOLBFLENJ;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public string DJPEBOGCHOB
	{
		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x678A290", Offset = "0x6788E90", VA = "0x18678A290")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x678A290", Offset = "0x6788E90", VA = "0x18678A290", Slot = "3")]
	public override string ToString()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x678A340", Offset = "0x6788F40", VA = "0x18678A340")]
	public MFEHKIDNCCC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class OLNGIDOLPIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	public SkinnedMeshRenderer IFMPGBKHIIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private Material[] PABGDGLPIBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private byte[] JBPAPCPBCKA;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public Mesh GOEEKNKKNNB
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x678B630", Offset = "0x678A230", VA = "0x18678B630")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000030")]
	public Material[] MGFIANCIIGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public byte[] BDOALLIPCAD
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x844520", Offset = "0x843120", VA = "0x180844520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x678B7E0", Offset = "0x678A3E0", VA = "0x18678B7E0")]
	public OLNGIDOLPIA(SkinnedMeshRenderer OLCDJHGFCID, AvatarSkinnedMeshBoneOrderRemapsData IPLDBICNJGM, [Optional] Material[] FNDGFEHMAOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x678B650", Offset = "0x678A250", VA = "0x18678B650")]
	public static OLNGIDOLPIA PIDDFAEPKKM(Renderer KKNFDPNGCFK, AvatarSkinnedMeshBoneOrderRemapsData IPLDBICNJGM)
	{
		return null;
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public struct PositionAndRotation
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public Vector3 Position;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public Quaternion Rotation;

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public static PositionAndRotation Default
		{
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xBA7F90", Offset = "0xBA6B90", VA = "0x180BA7F90")]
			get
			{
				return default(PositionAndRotation);
			}
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class GBKMDCOCPNL
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x67893F0", Offset = "0x6787FF0", VA = "0x1867893F0")]
	public static PositionAndRotation EEHPMEEFMIE(this PositionAndRotation KMGNJMEBIEL)
	{
		return default(PositionAndRotation);
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x67896D0", Offset = "0x67882D0", VA = "0x1867896D0")]
	public static float PCAADCPFPGI(float NEAJEANMBOG, Vector2 NOGGDFMLLII)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x6789770", Offset = "0x6788370", VA = "0x186789770")]
	public static float PCAADCPFPGI(float NEAJEANMBOG, float KFFFFOIIONO, float OKEJJJPMBDN, float EJBCANAPLDC)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6789550", Offset = "0x6788150", VA = "0x186789550")]
	public static float FGBEAONAGEF(float GLMEMJNJKAN, Vector2 NOGGDFMLLII)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x6789620", Offset = "0x6788220", VA = "0x186789620")]
	public static float FGBEAONAGEF(float GLMEMJNJKAN, float KFFFFOIIONO, float OKEJJJPMBDN, float EJBCANAPLDC)
	{
		return default(float);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class NCKKHJBBCCC
{
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	public static readonly int INDLCNPJLCF;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	public static readonly string GFMNMLPJCHH;
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public enum ILPDGFHFILK
{
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	DoNotHideHair,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	UseHelmetHair,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	AlwaysHideHair,
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	HideHairToggleable
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public enum PFDDGEOIKJA
{
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	Normal = 0,
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	Curly = 1,
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	Self = -1
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public enum FOJKAEIGAHI
{
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	Default,
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	NoPattern,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	Curly,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	Braid
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public enum BHNAMMMFFGC
{
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	None = -1,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	Head,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	Torso,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	LeftHand,
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	RightHand,
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	Mouth,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	Legs,
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	LeftFoot,
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	RightFoot,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	FullBody,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	Nose,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	Face
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public enum CIEBJCCMIDM
{
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	SkinColor,
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	PrimaryHairColor,
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	SecondaryHairColor,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	PrimaryBeardColor,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	SecondaryBeardColor,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	UGCShirtColor,
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	TeamColor,
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	TeamEmissiveColor
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public enum NHJHPLIGHLG
{
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	HairPattern,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	BeardPattern
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public enum PJCPHABLHKP
{
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	TeamItem,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	SkinColor,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	HairColor,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	BeardColor,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	UGCShirtColor
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public enum EAOGGLFPFIF
{
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	HairTexture,
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	BeardTexture,
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	UGCShirtTexture
}
[Cpp2IlInjected.Token(Token = "0x200002A")]
public enum MCCPHDBNPAI
{
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	CollapseSubMeshes,
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	CollapseToUniqueMaterials,
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	MergeAll
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public enum IAPGOOFMBNK
{
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	Base,
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	Wide,
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	Flat,
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	Downturned,
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	Hooked,
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	Long,
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	Upturned,
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	None
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public enum LIPOHEEJPJE
{
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	BeanBody,
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	FullBody
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public static class ELPOLEFCGPH
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x67878E0", Offset = "0x67864E0", VA = "0x1867878E0")]
	public static bool BKIAPLMMFDI(this ILPDGFHFILK GMLNLDALPIF)
	{
		return default(bool);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class AvatarSkinAssetItem : MonoBehaviour
	{
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		public enum FJNNMOANEBC
		{
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			ScreenFirstPersonSkinMesh,
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			ThirdPersonSkinMesh,
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			VRFirstPersonSkinMesh,
			[Cpp2IlInjected.Token(Token = "0x4000123")]
			NoseSkinMesh,
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			FaceSkinMesh
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		[SerializeField]
		private BodySkinnedMeshLODs screenFirstPersonBodySkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		[SerializeField]
		private BodySkinnedMeshLODs vrFirstPersonBodySkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		[SerializeField]
		private BodySkinnedMeshLODs thirdPersonBodySkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		[SerializeField]
		private NoseMeshConfiguration[] noseMeshConfigurations;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		[SerializeField]
		private BodySkinnedMeshLODs facialSpritesSkinnedMeshes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		private Dictionary<EPAIPDBBJOB, BodySkinnedMeshLODs> PNAOJFAENMD;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public BodySkinnedMeshLODs OIDNFKKHKMF
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public BodySkinnedMeshLODs BHBNFPIGDGB
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x844520", Offset = "0x843120", VA = "0x180844520")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public BodySkinnedMeshLODs JDEGPHENAAN
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x843500", Offset = "0x842100", VA = "0x180843500")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public BodySkinnedMeshLODs JHOBCANKNHB
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x843220", Offset = "0x841E20", VA = "0x180843220")]
			get
			{
				return default(BodySkinnedMeshLODs);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6785C10", Offset = "0x6784810", VA = "0x186785C10")]
		public void Initialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6785970", Offset = "0x6784570", VA = "0x186785970")]
		public SkinnedMeshRenderer[] GetBodySkinnedMeshLODsByType(FJNNMOANEBC JPIGKIJLPAF, [Optional] EPAIPDBBJOB? OPCBNACKJJD)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6785D10", Offset = "0x6784910", VA = "0x186785D10")]
		public AvatarSkinAssetItem()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class OCPDNKAOFCI
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public enum DLBGCMJPOAL
	{
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		Head,
		[Cpp2IlInjected.Token(Token = "0x4000129")]
		TorsoAll,
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		TorsoHigh,
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		TorsoLow,
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		SleevesShort,
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		SleevesLong,
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		DEPRECATED_Palm,
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		DEPRECATED_HandsAll,
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		PantsLong,
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		Shorts,
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		FootMid,
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		ShoeLow,
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		PantsShort,
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		PalmL,
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		PalmR,
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		HandL,
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		HandR,
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		Ears,
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		FootHigh
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	[Flags]
	public enum LFAEFIBNIJB
	{
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		Head = 1,
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		TorsoAll = 2,
		[Cpp2IlInjected.Token(Token = "0x400013E")]
		TorsoHigh = 4,
		[Cpp2IlInjected.Token(Token = "0x400013F")]
		TorsoLow = 8,
		[Cpp2IlInjected.Token(Token = "0x4000140")]
		SleevesShort = 0x10,
		[Cpp2IlInjected.Token(Token = "0x4000141")]
		SleevesLong = 0x20,
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		DEPRECATED_Palm = 0x40,
		[Cpp2IlInjected.Token(Token = "0x4000143")]
		DEPRECATED_HandsAll = 0x80,
		[Cpp2IlInjected.Token(Token = "0x4000144")]
		PantsLong = 0x100,
		[Cpp2IlInjected.Token(Token = "0x4000145")]
		Shorts = 0x200,
		[Cpp2IlInjected.Token(Token = "0x4000146")]
		FootMid = 0x400,
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		ShoeLow = 0x800,
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		PantsShort = 0x1000,
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		PalmL = 0x2000,
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		PalmR = 0x4000,
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		HandL = 0x8000,
		[Cpp2IlInjected.Token(Token = "0x400014C")]
		HandR = 0x10000,
		[Cpp2IlInjected.Token(Token = "0x400014D")]
		Ears = 0x20000,
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		FootHigh = 0x40000
	}

	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public static LFAEFIBNIJB ICJCLAKCFLF;

	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public static LFAEFIBNIJB HBKGKNOEPHE;

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x1D796A0", Offset = "0x1D782A0", VA = "0x181D796A0")]
	public static LFAEFIBNIJB NALNELCDJMI(LFAEFIBNIJB BFJJIMAKIGG, LFAEFIBNIJB GIPEKPPFFCI)
	{
		return default(LFAEFIBNIJB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x1D79690", Offset = "0x1D78290", VA = "0x181D79690")]
	public static LFAEFIBNIJB EAIGHLCFFFK(LFAEFIBNIJB CGJHEJLDEFG, LFAEFIBNIJB PBFMJCNNNNK)
	{
		return default(LFAEFIBNIJB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x678A4C0", Offset = "0x67890C0", VA = "0x18678A4C0")]
	public static LFAEFIBNIJB MEBNIGHJAEP(DLBGCMJPOAL GHJMFBNFKHH, LFAEFIBNIJB DCDDLBJBKGP)
	{
		return default(LFAEFIBNIJB);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x678A4B0", Offset = "0x67890B0", VA = "0x18678A4B0")]
	public static LFAEFIBNIJB KIOCOHIMLKK(DLBGCMJPOAL GHJMFBNFKHH, LFAEFIBNIJB DCDDLBJBKGP)
	{
		return default(LFAEFIBNIJB);
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x678A440", Offset = "0x6789040", VA = "0x18678A440")]
	public static bool BJEAEKEMFOO(this LFAEFIBNIJB KMKMAOIGIDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x678A3D0", Offset = "0x6788FD0", VA = "0x18678A3D0")]
	public static bool BBAPBCHFHJN(this LFAEFIBNIJB KMKMAOIGIDH)
	{
		return default(bool);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public class AvatarSkinnedMeshBoneOrderRemapsData : ScriptableObject
	{
		[Serializable]
		[Cpp2IlInjected.Token(Token = "0x2000034")]
		public struct BoneOrderRemapEntry
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000153")]
			public string boneOrderChecksum;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x4000154")]
			public byte[] boneOrderRemap;
		}

		[Cpp2IlInjected.Token(Token = "0x2000035")]
		[CompilerGenerated]
		private sealed class ENAIHPBDMEG
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000155")]
			public AvatarSkinnedMeshBonesController bonesController;

			[Cpp2IlInjected.Token(Token = "0x6000084")]
			[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
			public ENAIHPBDMEG()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000085")]
			[Cpp2IlInjected.Address(RVA = "0x67878F0", Offset = "0x67864F0", VA = "0x1867878F0")]
			internal bool CICCHLDOHOE(BoneOrderRemapEntry item)
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public static readonly string AvatarSkinBaseRootBone;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		[SerializeField]
		private List<BoneOrderRemapEntry> BoneOrderRemapData;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		[SerializeField]
		public AssetReference ValidSkinnedMeshBoneOrderDataReference;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		private Dictionary<string, byte[]> _boneOrderRemaps;

		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x6786870", Offset = "0x6785470", VA = "0x186786870")]
		private void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6786870", Offset = "0x6785470", VA = "0x186786870")]
		private void GCOJNGINBFN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6786880", Offset = "0x6785480", VA = "0x186786880")]
		private void PCMIJKJGMKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000080")]
		[Cpp2IlInjected.Address(RVA = "0x6786800", Offset = "0x6785400", VA = "0x186786800")]
		public byte[] BIFPBEFMBLF(string OILFHJNIIGF)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x6785DA0", Offset = "0x67849A0", VA = "0x186785DA0")]
		public bool ACEIGKIDFPI(SkinnedMeshBoneOrderData GJECIMAOBNA, AvatarSkinnedMeshBonesController EMFMMGJBOBP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x6786A40", Offset = "0x6785640", VA = "0x186786A40")]
		public AvatarSkinnedMeshBoneOrderRemapsData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public static class LBHAPBNOLAI
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public struct KBDPEOLICCD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		public Transform[] OPKLDPJLFOH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		public Matrix4x4[] DPKHGDJAKAA;
	}

	[Cpp2IlInjected.Token(Token = "0x4000158")]
	public static readonly string AHEHDGCBKIP;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x678A100", Offset = "0x6788D00", VA = "0x18678A100")]
	public static byte[] PFCPNLAHGJC(AvatarSkinnedMeshBoneOrderRemapsData IPLDBICNJGM, SkinnedMeshRenderer JEOIALKABFH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6789D10", Offset = "0x6788910", VA = "0x186789D10")]
	public static KBDPEOLICCD? AHIPLHACDBA(AvatarSkinnedMeshBoneOrderRemapsData IPLDBICNJGM, SkinnedMeshRenderer JEOIALKABFH)
	{
		return null;
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[DisallowMultipleComponent]
	[RequireComponent(typeof(SkinnedMeshRenderer))]
	public class AvatarSkinnedMeshBonesController : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		[ReadOnlyField]
		[SerializeField]
		private string boneOrderChecksum;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		[HHMHLCBPJEC(LBBGAALIOCK.Self, false, false, false)]
		[SerializeField]
		public SkinnedMeshRenderer SkinnedMeshRenderer;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public string ADBFKFNHIOP
		{
			[Cpp2IlInjected.Token(Token = "0x600008F")]
			[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x6786B10", Offset = "0x6785710", VA = "0x186786B10")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x6786F40", Offset = "0x6785B40", VA = "0x186786F40")]
		private void OnValidate()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x6786F50", Offset = "0x6785B50", VA = "0x186786F50")]
		private void PCMIJKJGMKN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6786B40", Offset = "0x6785740", VA = "0x186786B40")]
		[ContextMenu("Calculate Bone Order Checksum")]
		public bool CalculateBoneOrderChecksum()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0x846CB0", Offset = "0x8458B0", VA = "0x180846CB0")]
		public AvatarSkinnedMeshBonesController()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public enum DHCDKHLOHFF
{
	[Cpp2IlInjected.Token(Token = "0x4000160")]
	NeverObscured,
	[Cpp2IlInjected.Token(Token = "0x4000161")]
	AlwaysObscured,
	[Cpp2IlInjected.Token(Token = "0x4000162")]
	PrivateObscured
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public class HODPMKGAFIK
{
	[Cpp2IlInjected.Token(Token = "0x4000165")]
	public static readonly HODPMKGAFIK IOGFCHMIMPG;

	[Cpp2IlInjected.Token(Token = "0x17000038")]
	public int MMCAGJBJCPG
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x8431A0", Offset = "0x841DA0", VA = "0x1808431A0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x8444C0", Offset = "0x8430C0", VA = "0x1808444C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	public DHCDKHLOHFF OEHJEGCNMKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x8B9300", Offset = "0x8B7F00", VA = "0x1808B9300")]
		[CompilerGenerated]
		get
		{
			return default(DHCDKHLOHFF);
		}
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0xBAE740", Offset = "0xBAD340", VA = "0x180BAE740")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public HODPMKGAFIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x254D490", Offset = "0x254C090", VA = "0x18254D490")]
	public HODPMKGAFIK(DHCDKHLOHFF CMLBPDKMHGL, int FMGHGLDDHMK)
	{
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public class FitMeshHemisphere
	{
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		public static readonly Vector2 UV_CENTER_COORDINATE;

		[Cpp2IlInjected.Token(Token = "0x4000167")]
		public static readonly Vector3 DEFAULT_HEMISPHERE_FITMESH_PIVOT_POSITION;

		[Cpp2IlInjected.Token(Token = "0x4000168")]
		public static readonly Quaternion DEFAULT_HEMISPHERE_FITMESH_PIVOT_ROTATION;

		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public static readonly Vector3 DEFAULT_HEMISPHERE_FITMESH_PIVOT_SCALE;

		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public const float DEFAULT_HEMISPHERE_RADIUS = 0.13f;

		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public static readonly FitMeshHemisphere Default;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public Vector3 hemispherePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400016D")]
		public Quaternion hemisphereRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400016E")]
		public Vector3 hemisphereScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400016F")]
		public float radius;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public bool IsRadiusValid
		{
			[Cpp2IlInjected.Token(Token = "0x600009C")]
			[Cpp2IlInjected.Address(RVA = "0x67893E0", Offset = "0x6787FE0", VA = "0x1867893E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6788A50", Offset = "0x6787650", VA = "0x186788A50")]
		public void JMNGEPAHKJL(FitMeshHemisphere MGKPMLGMKGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6788AA0", Offset = "0x67876A0", VA = "0x186788AA0")]
		public Vector3 LKADLFAAKCD(Vector2 OMNDJDEHBKM, bool KJDPPKJIANK = true)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x67889F0", Offset = "0x67875F0", VA = "0x1867889F0")]
		public Vector3 JDMJIAEBKNP(Vector2 OMNDJDEHBKM)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x6789040", Offset = "0x6787C40", VA = "0x186789040")]
		public Quaternion PHOBDCJNGPG(Vector2 OMNDJDEHBKM)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x6788EC0", Offset = "0x6787AC0", VA = "0x186788EC0")]
		public Quaternion PHOBDCJNGPG(Vector2 OMNDJDEHBKM, Vector3 KOBDLDPHMGA)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x6788E60", Offset = "0x6787A60", VA = "0x186788E60")]
		public Vector2 OINEJEAGPOH(Vector2 DHIDHBOGGLP)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x6789330", Offset = "0x6787F30", VA = "0x186789330")]
		public FitMeshHemisphere()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public struct NoseMeshConfiguration
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000170")]
		public NoseFaceOption NoseOption;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public BodySkinnedMeshLODs Meshes;
	}
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	public enum OutfitType
	{
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		None = -1,
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		Hat = 0,
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		Hair = 2,
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		Ear = 3,
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		Eye = 10,
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		Beard = 20,
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		Shoulder = 100,
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		Shirt = 101,
		[Cpp2IlInjected.Token(Token = "0x400017B")]
		Waist = 102,
		[Cpp2IlInjected.Token(Token = "0x400017C")]
		Neck = 103,
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		TeamJersey = 104,
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		CustomShirt = 105,
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		Wrist = 200,
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		TeamWrist = 203,
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		Legs = 300,
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		Feet = 301
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class CJHAEGCGFBC
{
	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x6787210", Offset = "0x6785E10", VA = "0x186787210")]
	public static bool CMBCBAIILEM(this OutfitType NKCBPGLAJNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x6787290", Offset = "0x6785E90", VA = "0x186787290")]
	public static bool NDAGBAECOMF(this OutfitType NKCBPGLAJNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x6787250", Offset = "0x6785E50", VA = "0x186787250")]
	public static bool IPCEAFKBAKL(this OutfitType NKCBPGLAJNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6787200", Offset = "0x6785E00", VA = "0x186787200")]
	public static bool CFOBFFEGCLA(this OutfitType NKCBPGLAJNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x67871E0", Offset = "0x6785DE0", VA = "0x1867871E0")]
	public static bool AGNFJEFJLOP(this OutfitType NKCBPGLAJNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6787260", Offset = "0x6785E60", VA = "0x186787260")]
	public static bool KGKOGPACPCF(this OutfitType NKCBPGLAJNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6787280", Offset = "0x6785E80", VA = "0x186787280")]
	public static bool MFDEODMLPBC(this OutfitType NKCBPGLAJNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x67871F0", Offset = "0x6785DF0", VA = "0x1867871F0")]
	public static bool BBEFBKKIOMF(this OutfitType NKCBPGLAJNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6787230", Offset = "0x6785E30", VA = "0x186787230")]
	public static bool EHAHAGEJPEI(this OutfitType NKCBPGLAJNM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public class BLBCFIJJEGC : IEqualityComparer<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x4000183")]
	public static readonly BLBCFIJJEGC GGKBGANLBLD;

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6786FF0", Offset = "0x6785BF0", VA = "0x186786FF0", Slot = "4")]
	public bool Equals(OutfitType OOCKDJMJOJK, OutfitType KFCKFBKACGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6787050", Offset = "0x6785C50", VA = "0x186787050", Slot = "5")]
	public int GetHashCode(OutfitType NCNNODEFPOG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
	public BLBCFIJJEGC()
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class SkinnedMeshBoneOrderData : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		[SerializeField]
		private List<string> validBoneOrder;

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public IReadOnlyList<string> CurrentValidBoneOrder
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x678BF10", Offset = "0x678AB10", VA = "0x18678BF10")]
		public void JJCDJOIPPNB(SkinnedMeshRenderer JEOIALKABFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x678C0C0", Offset = "0x678ACC0", VA = "0x18678C0C0")]
		public SkinnedMeshBoneOrderData()
		{
		}
	}
}
namespace RecRoom.Avatars.Data.Shared
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	public class AdditionalHatData : AdditionalOutfitTypeData<AdditionalHatData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		public static readonly Vector2 DEFAULT_HAT_UV_OVERRIDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		public ILPDGFHFILK helmetHairMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		public bool legacyHidesHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		[ReadOnlyField]
		public bool UseHatUVOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		[ReadOnlyField]
		public Vector2 HatUVOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		[ReadOnlyField]
		public bool AllowFitMeshOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		[ReadOnlyField]
		public Vector3 FitMeshPivotPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		[ReadOnlyField]
		public Quaternion FitMeshPivotRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		[ReadOnlyField]
		public AnchorParamsRestrictions AnchorParamsRestrictions;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public Vector2 UVOverride
		{
			[Cpp2IlInjected.Token(Token = "0x60000B8")]
			[Cpp2IlInjected.Address(RVA = "0x6782E40", Offset = "0x6781A40", VA = "0x186782E40")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x6782940", Offset = "0x6781540", VA = "0x186782940", Slot = "8")]
		public override bool Equals(AdditionalHatData OCNJFCPHJLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x6782B30", Offset = "0x6781730", VA = "0x186782B30", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x6782C90", Offset = "0x6781890", VA = "0x186782C90")]
		public AdditionalHatData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	public abstract class AdditionalOutfitTypeData : IEquatable<AdditionalOutfitTypeData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		protected const float EPSILON = 0.001f;

		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x6783290", Offset = "0x6781E90", VA = "0x186783290")]
		public static bool KDCNNODIOBH(OutfitType NCNNODEFPOG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x6782F50", Offset = "0x6781B50", VA = "0x186782F50")]
		public static AdditionalOutfitTypeData GADNMLFOLLL(OutfitType NCNNODEFPOG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x6782EC0", Offset = "0x6781AC0", VA = "0x186782EC0", Slot = "0")]
		public override bool Equals(object HAHECKLGOJC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract bool Equals(AdditionalOutfitTypeData OCNJFCPHJLD);

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x67832B0", Offset = "0x6781EB0", VA = "0x1867832B0", Slot = "6")]
		public virtual AdditionalOutfitTypeData KLPACBHCBJJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		protected AdditionalOutfitTypeData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000046")]
	public abstract class AdditionalOutfitTypeData<T> : AdditionalOutfitTypeData, IEquatable<T> where T : AdditionalOutfitTypeData<T>
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x40CBC50", Offset = "0x40CA850", VA = "0x1840CBC50", Slot = "5")]
		public override bool Equals(AdditionalOutfitTypeData OCNJFCPHJLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract bool Equals(T OCNJFCPHJLD);

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x86D6A0", Offset = "0x86C2A0", VA = "0x18086D6A0")]
		protected AdditionalOutfitTypeData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	public class BeardData : AdditionalOutfitTypeData<BeardData>, IOHODLEPFAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public FOJKAEIGAHI beardHairPatternStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public bool usesHairColor;

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public bool UsesHairColor
		{
			[Cpp2IlInjected.Token(Token = "0x60000C6")]
			[Cpp2IlInjected.Address(RVA = "0x90BF50", Offset = "0x90AB50", VA = "0x18090BF50", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public FOJKAEIGAHI PatternStyle
		{
			[Cpp2IlInjected.Token(Token = "0x60000C7")]
			[Cpp2IlInjected.Address(RVA = "0x8431A0", Offset = "0x841DA0", VA = "0x1808431A0", Slot = "10")]
			get
			{
				return default(FOJKAEIGAHI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x6787100", Offset = "0x6785D00", VA = "0x186787100", Slot = "8")]
		public override bool Equals(BeardData OCNJFCPHJLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x6787120", Offset = "0x6785D20", VA = "0x186787120", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x6787190", Offset = "0x6785D90", VA = "0x186787190")]
		public BeardData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000048")]
	public class HairData : AdditionalOutfitTypeData<HairData>, IOHODLEPFAG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		public float radius;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		public Vector3 hemispherePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		public Quaternion hemisphereRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		public Vector3 hemisphereScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public FOJKAEIGAHI hairPatternStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public bool usesHairColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public PFDDGEOIKJA helmetHairStyle;

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public bool UsesHairColor
		{
			[Cpp2IlInjected.Token(Token = "0x60000CB")]
			[Cpp2IlInjected.Address(RVA = "0x9AA4B0", Offset = "0x9A90B0", VA = "0x1809AA4B0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public FOJKAEIGAHI PatternStyle
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x8615D0", Offset = "0x8601D0", VA = "0x1808615D0", Slot = "10")]
			get
			{
				return default(FOJKAEIGAHI);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public FitMeshHemisphere Hemisphere
		{
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x6789C80", Offset = "0x6788880", VA = "0x186789C80")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x67898D0", Offset = "0x67884D0", VA = "0x1867898D0", Slot = "8")]
		public override bool Equals(HairData OCNJFCPHJLD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x6789AC0", Offset = "0x67886C0", VA = "0x186789AC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6789BC0", Offset = "0x67887C0", VA = "0x186789BC0")]
		public HairData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public interface IOHODLEPFAG
{
	[Cpp2IlInjected.Token(Token = "0x17000042")]
	bool MNIPBHKJCHE
	{
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	FOJKAEIGAHI EPOELAPKLMH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
namespace RecRoom.Avatars.Data.Shared
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200004A")]
	public class SerializedAvatarItemData
	{
		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public string Name
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x843370", Offset = "0x841F70", VA = "0x180843370")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D4")]
			[Cpp2IlInjected.Address(RVA = "0x8434A0", Offset = "0x8420A0", VA = "0x1808434A0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public OutfitType OutfitType
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x84DDF0", Offset = "0x84C9F0", VA = "0x18084DDF0")]
			[CompilerGenerated]
			get
			{
				return default(OutfitType);
			}
			[Cpp2IlInjected.Token(Token = "0x60000D6")]
			[Cpp2IlInjected.Address(RVA = "0x84DE00", Offset = "0x84CA00", VA = "0x18084DE00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public OutfitType[] SecondaryOutfitTypes
		{
			[Cpp2IlInjected.Token(Token = "0x60000D7")]
			[Cpp2IlInjected.Address(RVA = "0x844520", Offset = "0x843120", VA = "0x180844520")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000D8")]
			[Cpp2IlInjected.Address(RVA = "0x844500", Offset = "0x843100", VA = "0x180844500")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool HidesHands
		{
			[Cpp2IlInjected.Token(Token = "0x60000D9")]
			[Cpp2IlInjected.Address(RVA = "0xA53410", Offset = "0xA52010", VA = "0x180A53410")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DA")]
			[Cpp2IlInjected.Address(RVA = "0xB30190", Offset = "0xB2ED90", VA = "0x180B30190")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public bool HidesLeftEar
		{
			[Cpp2IlInjected.Token(Token = "0x60000DB")]
			[Cpp2IlInjected.Address(RVA = "0xDCFC60", Offset = "0xDCE860", VA = "0x180DCFC60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0xDD07C0", Offset = "0xDCF3C0", VA = "0x180DD07C0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public bool HidesRightEar
		{
			[Cpp2IlInjected.Token(Token = "0x60000DD")]
			[Cpp2IlInjected.Address(RVA = "0x1E97300", Offset = "0x1E95F00", VA = "0x181E97300")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000DE")]
			[Cpp2IlInjected.Address(RVA = "0x1E97310", Offset = "0x1E95F10", VA = "0x181E97310")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public bool UsesTeamColor
		{
			[Cpp2IlInjected.Token(Token = "0x60000DF")]
			[Cpp2IlInjected.Address(RVA = "0x13C7770", Offset = "0x13C6370", VA = "0x1813C7770")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E0")]
			[Cpp2IlInjected.Address(RVA = "0x678BF00", Offset = "0x678AB00", VA = "0x18678BF00")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public Vector3? CustomImposterRotationOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x22F4210", Offset = "0x22F2E10", VA = "0x1822F4210")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E2")]
			[Cpp2IlInjected.Address(RVA = "0x22F4200", Offset = "0x22F2E00", VA = "0x1822F4200")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public float? CustomImposterScale
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x1B09080", Offset = "0x1B07C80", VA = "0x181B09080")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000E4")]
			[Cpp2IlInjected.Address(RVA = "0x1B090B0", Offset = "0x1B07CB0", VA = "0x181B090B0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		public bool HasLeftAndRightMeshes
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0xDB8970", Offset = "0xDB7570", VA = "0x180DB8970")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xDCDBD0", Offset = "0xDCC7D0", VA = "0x180DCDBD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public LIPOHEEJPJE ItemBodyType
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x90B4D0", Offset = "0x90A0D0", VA = "0x18090B4D0")]
			[CompilerGenerated]
			get
			{
				return default(LIPOHEEJPJE);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0xAED320", Offset = "0xAEBF20", VA = "0x180AED320")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public OCPDNKAOFCI.LFAEFIBNIJB ApplySkinMask
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0xAEDB40", Offset = "0xAEC740", VA = "0x180AEDB40")]
			[CompilerGenerated]
			get
			{
				return default(OCPDNKAOFCI.LFAEFIBNIJB);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0x1440E70", Offset = "0x143FA70", VA = "0x181440E70")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public AdditionalOutfitTypeData OutfitTypeData
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x8433B0", Offset = "0x841FB0", VA = "0x1808433B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x843340", Offset = "0x841F40", VA = "0x180843340")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public Guid ProxyAvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0xC22610", Offset = "0xC21210", VA = "0x180C22610")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x1338350", Offset = "0x1336F50", VA = "0x181338350")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public Guid AvatarItemId
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x10388B0", Offset = "0x10374B0", VA = "0x1810388B0")]
			[CompilerGenerated]
			get
			{
				return default(Guid);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x3D12E60", Offset = "0x3D11A60", VA = "0x183D12E60")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x84D640", Offset = "0x84C240", VA = "0x18084D640")]
		public SerializedAvatarItemData()
		{
		}
	}
}
namespace RecRoom.Avatars.Face
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	public sealed class BrowsFaceFeature : SymmetricalFaceFeature
	{
		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0x8BC790", Offset = "0x8BB390", VA = "0x1808BC790", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x67871D0", Offset = "0x6785DD0", VA = "0x1867871D0")]
		public BrowsFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004C")]
	public sealed class EyesFaceFeature : SymmetricalFaceFeature
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
		[Cpp2IlInjected.Token(Token = "0x40001A9")]
		public Vector2 MaxGleamJitterScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
		[Cpp2IlInjected.Token(Token = "0x40001AA")]
		public Vector2 MaxGleamJitterOffsetAnchors;

		[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
		[Cpp2IlInjected.Token(Token = "0x40001AB")]
		public bool JitterGleamSymmetrically;

		[Cpp2IlInjected.FieldOffset(Offset = "0xEC")]
		[Cpp2IlInjected.Token(Token = "0x40001AC")]
		public Vector2 GleamJitterMultiplier;

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x846CD0", Offset = "0x8458D0", VA = "0x180846CD0", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public Vector2 JitteredEyeGleamOffsetLeft
		{
			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x6787D30", Offset = "0x6786930", VA = "0x186787D30")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x6787D90", Offset = "0x6786990", VA = "0x186787D90")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public Vector2 JitteredEyeGleamOffsetRight
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x6787D50", Offset = "0x6786950", VA = "0x186787D50")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x6787DA0", Offset = "0x67869A0", VA = "0x186787DA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public Vector2 JitteredEyeGleamScaleLeft
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0xB62BD0", Offset = "0xB617D0", VA = "0x180B62BD0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0x19A27F0", Offset = "0x19A13F0", VA = "0x1819A27F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public Vector2 JitteredEyeGleamScaleRight
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x6787D70", Offset = "0x6786970", VA = "0x186787D70")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x6787DB0", Offset = "0x67869B0", VA = "0x186787DB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6787920", Offset = "0x6786520", VA = "0x186787920", Slot = "7")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6787C20", Offset = "0x6786820", VA = "0x186787C20")]
		public EyesFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004D")]
	public abstract class FaceFeature : FaceFeatureBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001B1")]
		public Vector2 DefaultAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001B2")]
		public Vector2 MaxJitterAnchor;

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public Vector2 JitteredAnchor
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x67889D0", Offset = "0x67875D0", VA = "0x1867889D0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x107E590", Offset = "0x107D190", VA = "0x18107E590")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005A")]
		public Vector2 JitteredOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(RVA = "0xC6F040", Offset = "0xC6DC40", VA = "0x180C6F040")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x107E5A0", Offset = "0x107D1A0", VA = "0x18107E5A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x6788790", Offset = "0x6787390", VA = "0x186788790", Slot = "7")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x67888D0", Offset = "0x67874D0", VA = "0x1867888D0")]
		protected FaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	public abstract class FaceFeatureBase : SelectableFaceOption
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000050")]
		[CompilerGenerated]
		private struct <LoadSpriteAssetsAsync>d__26 : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40001C3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
			[Cpp2IlInjected.Token(Token = "0x40001C4")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x40001C5")]
			public FaceFeatureBase <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
			[Cpp2IlInjected.Token(Token = "0x40001C6")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x678C4B0", Offset = "0x678B0B0", VA = "0x18678C4B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x678D140", Offset = "0x678BD40", VA = "0x18678D140", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x40001B5")]
		private static readonly string[] FACE_FEATURE_ASSET_PATHS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001B6")]
		private readonly List<OBOGMAPJNLF<Sprite>> _spriteResourceHandles;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x40001B7")]
		private readonly List<Sprite> _loadedSprites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x40001B8")]
		private Task _activelyLoadingTask;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x40001B9")]
		private int _referenceCount;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x40001BA")]
		[SerializeField]
		private List<AssetReference> SpriteReferences;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x40001BB")]
		[SerializeField]
		private Sprite[] DefaultSprites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x40001BD")]
		public Vector2 DefaultScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x40001BE")]
		public Vector2 MaxJitterScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x40001BF")]
		public Vector2 JitterMultiplier;

		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		public string DefaultSpriteName
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x8431C0", Offset = "0x841DC0", VA = "0x1808431C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x843380", Offset = "0x841F80", VA = "0x180843380")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		public IEnumerable<Sprite> SrcLoadedSprites
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x67886E0", Offset = "0x67872E0", VA = "0x1867886E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public int TextureCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x6788750", Offset = "0x6787350", VA = "0x186788750")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public bool IsLoaded
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x6788690", Offset = "0x6787290", VA = "0x186788690")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public Vector2 JitteredScale
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x554C610", Offset = "0x554B210", VA = "0x18554C610")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600010B")]
			[Cpp2IlInjected.Address(RVA = "0x554C810", Offset = "0x554B410", VA = "0x18554C810")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x6788170", Offset = "0x6786D70", VA = "0x186788170")]
		protected static Vector2 JitteredVector2(Vector2 initial, Vector2 maxJitter)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x67882B0", Offset = "0x6786EB0", VA = "0x1867882B0", Slot = "7")]
		public virtual void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x67881E0", Offset = "0x6786DE0", VA = "0x1867881E0")]
		[AsyncStateMachine(typeof(<LoadSpriteAssetsAsync>d__26))]
		public Task LoadSpriteAssetsAsync()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x6788390", Offset = "0x6786F90", VA = "0x186788390")]
		public void ReleaseSpriteResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x6787F60", Offset = "0x6786B60", VA = "0x186787F60")]
		private void DisposeAllSpriteResources()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x6788490", Offset = "0x6787090", VA = "0x186788490")]
		protected FaceFeatureBase()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	public enum FaceFeatureType
	{
		[Cpp2IlInjected.Token(Token = "0x40001C8")]
		Eye,
		[Cpp2IlInjected.Token(Token = "0x40001C9")]
		Mouth,
		[Cpp2IlInjected.Token(Token = "0x40001CA")]
		Nose,
		[Cpp2IlInjected.Token(Token = "0x40001CB")]
		Brows
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public sealed class OFIAGAGHOCM : IDisposable
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private struct PAKMPOEOODH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40001D2")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x40001D3")]
		public AsyncTaskMethodBuilder<OFIAGAGHOCM> <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001D4")]
		public SymmetricalFaceFeature eyeBrow;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x40001D5")]
		public EyesFaceFeature eye;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001D6")]
		public FaceFeature mouth;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001D7")]
		private DEAGKENLJKN.GNJIHBNGMDO <__>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001D8")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x678B8B0", Offset = "0x678A4B0", VA = "0x18678B8B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x678BE90", Offset = "0x678AA90", VA = "0x18678BE90", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40001CC")]
	private readonly Dictionary<string, int> JAHFJLOGKNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40001D1")]
	private bool NBOIKKOECBD;

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public Texture2DArray CGBCDJAAACM
	{
		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x8432F0", Offset = "0x841EF0", VA = "0x1808432F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x843330", Offset = "0x841F30", VA = "0x180843330")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public SymmetricalFaceFeature DDGCNGONBAN
	{
		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x844520", Offset = "0x843120", VA = "0x180844520")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x844500", Offset = "0x843100", VA = "0x180844500")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public EyesFaceFeature CFIPOEONPPF
	{
		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x843500", Offset = "0x842100", VA = "0x180843500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x847810", Offset = "0x846410", VA = "0x180847810")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public FaceFeature BKGCCJPCJPO
	{
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x8431E0", Offset = "0x841DE0", VA = "0x1808431E0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x847820", Offset = "0x846420", VA = "0x180847820")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x678A740", Offset = "0x6789340", VA = "0x18678A740")]
	private static void FDPHDLPLILN(Sprite CDLBKMCBHGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x678B1C0", Offset = "0x6789DC0", VA = "0x18678B1C0")]
	public static OFIAGAGHOCM NGINEKNGING(SymmetricalFaceFeature CJJJGFCGJNM, EyesFaceFeature FKKMNKGGIHC, FaceFeature EMJCPICLAFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x678B080", Offset = "0x6789C80", VA = "0x18678B080")]
	[AsyncStateMachine(typeof(PAKMPOEOODH))]
	public static Task<OFIAGAGHOCM> HPEOAMCIMLD(SymmetricalFaceFeature CJJJGFCGJNM, EyesFaceFeature FKKMNKGGIHC, FaceFeature EMJCPICLAFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x678B250", Offset = "0x6789E50", VA = "0x18678B250")]
	private OFIAGAGHOCM(SymmetricalFaceFeature CJJJGFCGJNM, EyesFaceFeature FKKMNKGGIHC, FaceFeature EMJCPICLAFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x678A8A0", Offset = "0x67894A0", VA = "0x18678A8A0")]
	private void HBEFNLMGOLO(List<Sprite> HOBDDOFCMNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x678A520", Offset = "0x6789120", VA = "0x18678A520")]
	public bool DNFOALPCIFG(string EPGKEKLEDGI, [Out] int OPDMGNJCACB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x678A710", Offset = "0x6789310", VA = "0x18678A710", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x678A7B0", Offset = "0x67893B0", VA = "0x18678A7B0")]
	public bool GKFNCCNFNCH()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x678B000", Offset = "0x6789C00", VA = "0x18678B000")]
	public void HMOGMAOPIFC()
	{
	}
}
namespace RecRoom.Avatars.Face
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	public sealed class MouthFaceFeature : FaceFeature
	{
		[Cpp2IlInjected.Token(Token = "0x17000064")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x8B0E30", Offset = "0x8AFA30", VA = "0x1808B0E30", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x67888D0", Offset = "0x67874D0", VA = "0x1867888D0")]
		public MouthFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public sealed class NoseFaceOption : SelectableFaceOption
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40001DB")]
		public IAPGOOFMBNK SelectedNoseType;

		[Cpp2IlInjected.Token(Token = "0x17000065")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x8B4D90", Offset = "0x8B3990", VA = "0x1808B4D90", Slot = "6")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0x8B3240", Offset = "0x8B1E40", VA = "0x1808B3240")]
		public NoseFaceOption()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public abstract class SelectableFaceOption : ScriptableObject, ISerializationCallbackReceiver
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40001DC")]
		[Tooltip("This guid is auto generated at the time of the asset creation and should never change if you do not want to break an existing player's feature selection")]
		[SerializeField]
		[Obsolete("Use FaceFeatureId instead!")]
		protected string GuidString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40001DD")]
		[SerializeField]
		private SerializedFaceFeatureId faceFeatureId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40001DE")]
		[SerializeField]
		private Sprite menuButtonSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40001DF")]
		[SerializeField]
		private bool isNoneOption;

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		public EPAIPDBBJOB FaceFeatureId
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x9C47B0", Offset = "0x9C33B0", VA = "0x1809C47B0")]
			get
			{
				return default(EPAIPDBBJOB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public bool IsNoneOption
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x9D7F40", Offset = "0x9D6B40", VA = "0x1809D7F40")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x8431E0", Offset = "0x841DE0", VA = "0x1808431E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000069")]
		public abstract FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(Slot = "6")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(RVA = "0x67858C0", Offset = "0x67844C0", VA = "0x1867858C0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x846CC0", Offset = "0x8458C0", VA = "0x180846CC0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x8B3240", Offset = "0x8B1E40", VA = "0x1808B3240")]
		protected SelectableFaceOption()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000058")]
	public abstract class SymmetricalFaceFeature : FaceFeatureBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x40001E0")]
		public Vector2 MaxJitterAnchors;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x40001E1")]
		public bool JitterSymetrically;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x40001E2")]
		public Vector2 DefaultAnchorLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
		[Cpp2IlInjected.Token(Token = "0x40001E5")]
		public Vector2 DefaultAnchorRight;

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public Vector2 JitteredAnchorLeft
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x678C430", Offset = "0x678B030", VA = "0x18678C430")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0xE64430", Offset = "0xE63030", VA = "0x180E64430")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public Vector2 JitteredOffsetLeft
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x678C470", Offset = "0x678B070", VA = "0x18678C470")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600013C")]
			[Cpp2IlInjected.Address(RVA = "0x5D7AF60", Offset = "0x5D79B60", VA = "0x185D7AF60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Vector2 JitteredAnchorRight
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x678C450", Offset = "0x678B050", VA = "0x18678C450")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x5D7E230", Offset = "0x5D7CE30", VA = "0x185D7E230")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public Vector2 JitteredOffsetRight
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x678C490", Offset = "0x678B090", VA = "0x18678C490")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x5D7E220", Offset = "0x5D7CE20", VA = "0x185D7E220")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x678C150", Offset = "0x678AD50", VA = "0x18678C150", Slot = "7")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000142")]
		[Cpp2IlInjected.Address(RVA = "0x678C360", Offset = "0x678AF60", VA = "0x18678C360")]
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
