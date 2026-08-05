using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using RecRoom.Attributes;
using RecRoom.Avatars;
using RecRoom.Avatars.Data.Shared;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public interface IOCNHDDOGGE
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	float KLCGPKMPMJE
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	float GGNDMBAODFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	float ANHNJOIFLHK
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	float AIOMJKCNALB
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float GGPHMPKMCBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	float JNFLICHAMJP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float FBJHJLBHDJJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float PGHFMBJBHGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float NAFHOJHELPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	float DPKFHLOAMMB
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	float MPPOLMGIOOD
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	float GHDAJKPIJDF
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	float FFECLCHHCAI
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	float DDANCDKGMFB
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	float BFEEPGFGBJB
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	float ABHJKOHLIPJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Vector3 KMGAOJEDOIF(Vector3 AHNDJINOPFP);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Vector3 PFLMPACBFAN(Vector3 LONBLNBNJPL);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Vector3 HOJFKMCJLJP();
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class AnchorParamsRestrictions : IOCNHDDOGGE
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
			[Cpp2IlInjected.Address(RVA = "0x9617B0", Offset = "0x960BB0", VA = "0x1809617B0", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool GetAllowRotations
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xF5E030", Offset = "0xF5D430", VA = "0x180F5E030", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xB05EB0", Offset = "0xB052B0", VA = "0x180B05EB0", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x97B440", Offset = "0x97A840", VA = "0x18097B440", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xC1C7F0", Offset = "0xC1BBF0", VA = "0x180C1C7F0", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xB16330", Offset = "0xB15730", VA = "0x180B16330", Slot = "7")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x933CC0", Offset = "0x9330C0", VA = "0x180933CC0", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8F6550", Offset = "0x8F5950", VA = "0x1808F6550", Slot = "9")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 DefaultOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6E8FBE0", Offset = "0x6E8EFE0", VA = "0x186E8FBE0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 MinOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6E8FF00", Offset = "0x6E8F300", VA = "0x186E8FF00")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector3 MaxOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x6E8FEE0", Offset = "0x6E8F2E0", VA = "0x186E8FEE0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xC76FF0", Offset = "0xC763F0", VA = "0x180C76FF0", Slot = "12")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xC1C790", Offset = "0xC1BB90", VA = "0x180C1C790", Slot = "13")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x933CB0", Offset = "0x9330B0", VA = "0x180933CB0", Slot = "10")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x933CA0", Offset = "0x9330A0", VA = "0x180933CA0", Slot = "11")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xAE8470", Offset = "0xAE7870", VA = "0x180AE8470", Slot = "14")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xC7FFF0", Offset = "0xC7F3F0", VA = "0x180C7FFF0", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Vector3 DefaultRotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6E8FCE0", Offset = "0x6E8F0E0", VA = "0x186E8FCE0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Vector3 RightRotationFreedom
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6E8FF20", Offset = "0x6E8F320", VA = "0x186E8FF20")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector3 LeftRotationFreedom
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6E8FEC0", Offset = "0x6E8F2C0", VA = "0x186E8FEC0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public float GetMaxUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xC80030", Offset = "0xC7F430", VA = "0x180C80030", Slot = "16")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public float GetMinUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xC80060", Offset = "0xC7F460", VA = "0x180C80060", Slot = "17")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xC80050", Offset = "0xC7F450", VA = "0x180C80050", Slot = "18")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8E1EF0", Offset = "0x8E12F0", VA = "0x1808E1EF0", Slot = "19")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector2 URange
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6E8FF40", Offset = "0x6E8F340", VA = "0x186E8FF40")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6E8FF80", Offset = "0x6E8F380", VA = "0x186E8FF80")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector2 VRange
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6E8FF60", Offset = "0x6E8F360", VA = "0x186E8FF60")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6E8FFA0", Offset = "0x6E8F3A0", VA = "0x186E8FFA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6E8FE30", Offset = "0x6E8F230", VA = "0x186E8FE30")]
		public AnchorParamsRestrictions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6E8F100", Offset = "0x6E8E500", VA = "0x186E8F100")]
		public NBNLNGHNGFL FGMDEPEMAHM(NBNLNGHNGFL NIOAEPGLKBH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6E8FCE0", Offset = "0x6E8F0E0", VA = "0x186E8FCE0", Slot = "25")]
		public Vector3 NFEKHJJPAMA()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6E8FBE0", Offset = "0x6E8EFE0", VA = "0x186E8FBE0", Slot = "22")]
		public Vector3 HOJFKMCJLJP()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6E8FC70", Offset = "0x6E8F070", VA = "0x186E8FC70", Slot = "20")]
		public Vector3 KMGAOJEDOIF(Vector3 AHNDJINOPFP)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6E8FD00", Offset = "0x6E8F100", VA = "0x186E8FD00", Slot = "21")]
		public Vector3 PFLMPACBFAN(Vector3 LONBLNBNJPL)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6E8EFF0", Offset = "0x6E8E3F0", VA = "0x186E8EFF0", Slot = "0")]
		public override bool Equals(object NCHBKHMIMGJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6E8F3E0", Offset = "0x6E8E7E0", VA = "0x186E8F3E0")]
		protected bool FIEJHAMNHHO(AnchorParamsRestrictions BMKPAKCEMFK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6E8F8E0", Offset = "0x6E8ECE0", VA = "0x186E8F8E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6E8FC00", Offset = "0x6E8F000", VA = "0x186E8FC00")]
		[CompilerGenerated]
		internal static bool JCEHAFIPDHI(float DDIIBBHFODJ, float BCCGANGEINF)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class NCCBPLLLLLL
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x11B8E10", Offset = "0x11B8210", VA = "0x1811B8E10")]
	public static bool CAJAOFLEPJO(this HAPHCDJNHOG AEJLBPBOCPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6E916C0", Offset = "0x6E90AC0", VA = "0x186E916C0")]
	public static bool NLENABOLHKM(this HAPHCDJNHOG AEJLBPBOCPI)
	{
		return default(bool);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public enum HelmetHairMode
	{
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		[InspectorName("Show Hair")]
		DoNotHideHair,
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[InspectorName("Use Helmet Hair")]
		UseHelmetHair,
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[InspectorName("Hide Hair (Always)")]
		AlwaysHideHair,
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[InspectorName("Hide Hair (Optional)")]
		HideHairToggleable
	}
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public enum HelmetHairStyle
	{
		[Cpp2IlInjected.Token(Token = "0x4000028")]
		Normal = 0,
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		Curly = 1,
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		Self = -1
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum HairPatternStyle
	{
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		NoPattern,
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		Curly,
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		Braid
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public enum AvatarItemBodyType
	{
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		BeanBody,
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		FullBody,
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		ModernBeanBody
	}
}
[Cpp2IlInjected.Token(Token = "0x2000009")]
public static class LMKDOEOOHCG
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6E91570", Offset = "0x6E90970", VA = "0x186E91570")]
	public static bool FCKCAAMAIDH(this HelmetHairMode PABCKLJDABE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6E914F0", Offset = "0x6E908F0", VA = "0x186E914F0")]
	public static EOPKGKNJKFM EIPJFDEDOGM(this AvatarItemBodyType APNBNFCFAMM)
	{
		return default(EOPKGKNJKFM);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6E91640", Offset = "0x6E90A40", VA = "0x186E91640")]
	public static AvatarItemBodyType OHALFAIDBIE(this EOPKGKNJKFM APNBNFCFAMM)
	{
		return default(AvatarItemBodyType);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6E91580", Offset = "0x6E90980", VA = "0x186E91580")]
	public static string HDLHMIFMMIL(this AvatarItemBodyType APNBNFCFAMM)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class IBBAPAKLKFF
{
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public enum GGLOLBIANLP
	{
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		Head,
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		TorsoAll,
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		TorsoHigh,
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		TorsoLow,
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		SleevesShort,
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		SleevesLong,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		DEPRECATED_Palm,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		DEPRECATED_HandsAll,
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		PantsLong,
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		Shorts,
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		FootMid,
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		ShoeLow,
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		PantsShort,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		PalmL,
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		PalmR,
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		HandL,
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		HandR,
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		Ears,
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		FootHigh
	}

	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[Flags]
	public enum JPAHGGFNNNL
	{
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		Head = 1,
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		TorsoAll = 2,
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		TorsoHigh = 4,
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		TorsoLow = 8,
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		SleevesShort = 0x10,
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		SleevesLong = 0x20,
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		DEPRECATED_Palm = 0x40,
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		DEPRECATED_HandsAll = 0x80,
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		PantsLong = 0x100,
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		Shorts = 0x200,
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		FootMid = 0x400,
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		ShoeLow = 0x800,
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		PantsShort = 0x1000,
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		PalmL = 0x2000,
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		PalmR = 0x4000,
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		HandL = 0x8000,
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		HandR = 0x10000,
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		Ears = 0x20000,
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		FootHigh = 0x40000
	}

	[Cpp2IlInjected.Token(Token = "0x4000034")]
	public static JPAHGGFNNNL MMILJLNOGPO;

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static JPAHGGFNNNL HIBNDHEMKAG;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6E912E0", Offset = "0x6E906E0", VA = "0x186E912E0")]
	public static JPAHGGFNNNL EIJBDOHPDLO(JPAHGGFNNNL ABLPOADIMLM, JPAHGGFNNNL IKNKOKIBPKC)
	{
		return default(JPAHGGFNNNL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6E91370", Offset = "0x6E90770", VA = "0x186E91370")]
	public static JPAHGGFNNNL OPBBBPLAIKK(JPAHGGFNNNL LOBNHACCGJL, JPAHGGFNNNL BHMFJBEMHML)
	{
		return default(JPAHGGFNNNL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6E912F0", Offset = "0x6E906F0", VA = "0x186E912F0")]
	public static JPAHGGFNNNL EONPCPBIMFC(GGLOLBIANLP FABCGGBNLKL, JPAHGGFNNNL LHFFNMLCMGJ)
	{
		return default(JPAHGGFNNNL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6E91380", Offset = "0x6E90780", VA = "0x186E91380")]
	public static JPAHGGFNNNL PDAEDKDPLJI(GGLOLBIANLP FABCGGBNLKL, JPAHGGFNNNL LHFFNMLCMGJ)
	{
		return default(JPAHGGFNNNL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6E91300", Offset = "0x6E90700", VA = "0x186E91300")]
	public static bool OCEIEEOAMLK(this JPAHGGFNNNL EOEFINIJEJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6E91390", Offset = "0x6E90790", VA = "0x186E91390")]
	public static bool PFHDGGMFGKM(this JPAHGGFNNNL EOEFINIJEJD)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class PLNKHDFAHFD
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public enum GFOEIHGPCGD : short
	{
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		None = -1,
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		Happy = 0,
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		Love = 1,
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		Laugh = 2,
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		TongueOut = 3,
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		Wink = 4,
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		Smirk = 5,
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		SmileSweat = 10,
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		Grimacing = 11,
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		Shocked = 12,
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		Thinking = 13,
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		Sleeping = 14,
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		Sad = 20,
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		Angry = 21,
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		Nauseated = 22,
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		Flat = 23,
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		Smile = 100
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public class FitMeshHemisphere
	{
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public static readonly Vector2 UV_CENTER_COORDINATE;

		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public static readonly Vector3 DEFAULT_HEMISPHERE_FITMESH_PIVOT_POSITION;

		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public static readonly Quaternion DEFAULT_HEMISPHERE_FITMESH_PIVOT_ROTATION;

		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public static readonly Vector3 DEFAULT_HEMISPHERE_FITMESH_PIVOT_SCALE;

		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public const float DEFAULT_HEMISPHERE_RADIUS = 0.13f;

		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public static readonly FitMeshHemisphere Default;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public Vector3 hemispherePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public Quaternion hemisphereRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Vector3 hemisphereScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public float radius;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool IsRadiusValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6E90E90", Offset = "0x6E90290", VA = "0x186E90E90")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6E907A0", Offset = "0x6E8FBA0", VA = "0x186E907A0")]
		public void KKMAIPOKHEB(FitMeshHemisphere DNBDJPOAJHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6E907F0", Offset = "0x6E8FBF0", VA = "0x186E907F0")]
		public Vector3 POIHAPMCAIA(Vector2 DMHJHKAIDJJ, bool HHGOMAJFNOB = true)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6E903D0", Offset = "0x6E8F7D0", VA = "0x186E903D0")]
		public Vector3 BDLOLPNCILN(Vector2 DMHJHKAIDJJ)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6E90430", Offset = "0x6E8F830", VA = "0x186E90430")]
		public Quaternion GABIKJGPDGF(Vector2 DMHJHKAIDJJ)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6E905E0", Offset = "0x6E8F9E0", VA = "0x186E905E0")]
		public Quaternion GABIKJGPDGF(Vector2 DMHJHKAIDJJ, Vector3 NCANECNDPAL)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6E90750", Offset = "0x6E8FB50", VA = "0x186E90750")]
		public Vector2 KFGOEHBBKMH(Vector2 CJMJLLMGHAC)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6E90DF0", Offset = "0x6E901F0", VA = "0x186E90DF0")]
		public FitMeshHemisphere()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum OutfitType
	{
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		None = -1,
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		Hat = 0,
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		Hair = 2,
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		Ear = 3,
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		Eye = 10,
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		Beard = 20,
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		Shoulder = 100,
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		Shirt = 101,
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		Waist = 102,
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		Neck = 103,
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		TeamJersey = 104,
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		CustomShirt = 105,
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		Wrist = 200,
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		TeamWrist = 203,
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		Legs = 300,
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		Feet = 301
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public static class EEOFODBKAAJ
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6E90210", Offset = "0x6E8F610", VA = "0x186E90210")]
	public static bool LJDJBOBDODC(this OutfitType HKNHLPOKHIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6E901F0", Offset = "0x6E8F5F0", VA = "0x186E901F0")]
	public static bool JCPHHJMKJEK(this OutfitType HKNHLPOKHIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6E901E0", Offset = "0x6E8F5E0", VA = "0x186E901E0")]
	public static bool FMBBDNIOOKL(this OutfitType HKNHLPOKHIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6E90230", Offset = "0x6E8F630", VA = "0x186E90230")]
	public static bool MBOMNNGHGJA(this OutfitType HKNHLPOKHIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6E90260", Offset = "0x6E8F660", VA = "0x186E90260")]
	public static bool OIOPCHADGKK(this OutfitType HKNHLPOKHIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6E901A0", Offset = "0x6E8F5A0", VA = "0x186E901A0")]
	public static bool CIPCOEFCNED(this OutfitType HKNHLPOKHIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6E90190", Offset = "0x6E8F590", VA = "0x186E90190")]
	public static bool AJLMLINKAKO(this OutfitType HKNHLPOKHIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6E901D0", Offset = "0x6E8F5D0", VA = "0x186E901D0")]
	public static bool DELAEEIFBKD(this OutfitType HKNHLPOKHIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6E90240", Offset = "0x6E8F640", VA = "0x186E90240")]
	public static bool OIFHBOJJAOB(this OutfitType HKNHLPOKHIK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6E901C0", Offset = "0x6E8F5C0", VA = "0x186E901C0")]
	public static bool DBLAMLPLPJB(this OutfitType HKNHLPOKHIK)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class BAJPFIGJKJE : IEqualityComparer<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public static readonly BAJPFIGJKJE ELEBKANKHDF;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6E8FFC0", Offset = "0x6E8F3C0", VA = "0x186E8FFC0", Slot = "4")]
	public bool Equals(OutfitType EECBKGGNMLP, OutfitType COJOLHFAFMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6E90020", Offset = "0x6E8F420", VA = "0x186E90020", Slot = "5")]
	public int GetHashCode(OutfitType IFBDJLKPHIG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
	public BAJPFIGJKJE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public enum OGGFNBOMCOK
{
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	SkinColor,
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	PrimaryHairColor,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	SecondaryHairColor,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	PrimaryBeardColor,
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	SecondaryBeardColor,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	UGCShirtColor,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	TeamColor,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	TeamEmissiveColor
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum GIEOMBNNLBI
{
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	HairPattern,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	BeardPattern
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum NLIABPACMCI
{
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	TeamItem,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	SkinColor,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	HairColor,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	BeardColor,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	UGCShirtColor
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum PIABCGLBJDM
{
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	HairTexture,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	BeardTexture,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	UGCShirtTexture
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum PFKOJMLNIIH
{
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	CollapseSubMeshes,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	CollapseToUniqueMaterials,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	MergeAll
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public enum OMDDHHLOJNA
{
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	Base,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	Wide,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	Flat,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	Downturned,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	Hooked,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	Long,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	Upturned,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	None
}
namespace RecRoom.Avatars.Data.Shared
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000019")]
	public class AdditionalFeetData : AdditionalOutfitTypeData<AdditionalFeetData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		public float heelAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		public float heightOffset;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6E8E4B0", Offset = "0x6E8D8B0", VA = "0x186E8E4B0", Slot = "8")]
		public override bool Equals(AdditionalFeetData BMKPAKCEMFK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6E8E4E0", Offset = "0x6E8D8E0", VA = "0x186E8E4E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6E8E560", Offset = "0x6E8D960", VA = "0x186E8E560")]
		public AdditionalFeetData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class AdditionalHatData : AdditionalOutfitTypeData<AdditionalHatData>
	{
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public static readonly Vector2 DEFAULT_HAT_UV_OVERRIDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public HelmetHairMode helmetHairMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public bool legacyHidesHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		[ReadOnlyField]
		public bool UseHatUVOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		[ReadOnlyField]
		public Vector2 HatUVOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		[ReadOnlyField]
		public bool AllowFitMeshOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		[ReadOnlyField]
		public Vector3 FitMeshPivotPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		[ReadOnlyField]
		public Quaternion FitMeshPivotRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		[ReadOnlyField]
		public AnchorParamsRestrictions AnchorParamsRestrictions;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector2 UVOverride
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x6E8EA90", Offset = "0x6E8DE90", VA = "0x186E8EA90")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6E8E5A0", Offset = "0x6E8D9A0", VA = "0x186E8E5A0", Slot = "8")]
		public override bool Equals(AdditionalHatData BMKPAKCEMFK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6E8E790", Offset = "0x6E8DB90", VA = "0x186E8E790", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6E8E8F0", Offset = "0x6E8DCF0", VA = "0x186E8E8F0")]
		public AdditionalHatData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public abstract class AdditionalOutfitTypeData : IEquatable<AdditionalOutfitTypeData>
	{
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		protected const float EPSILON = 0.001f;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6E8EFC0", Offset = "0x6E8E3C0", VA = "0x186E8EFC0")]
		public static bool LHOIMFHGINB(OutfitType IFBDJLKPHIG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6E8EC10", Offset = "0x6E8E010", VA = "0x186E8EC10")]
		public static AdditionalOutfitTypeData KOPOAAAOIOD(OutfitType IFBDJLKPHIG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6E8EB80", Offset = "0x6E8DF80", VA = "0x186E8EB80", Slot = "0")]
		public override bool Equals(object NCHBKHMIMGJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract bool Equals(AdditionalOutfitTypeData BMKPAKCEMFK);

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x6E8EB10", Offset = "0x6E8DF10", VA = "0x186E8EB10", Slot = "6")]
		public virtual AdditionalOutfitTypeData EIBGMEMLIIJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x8CC920", Offset = "0x8CBD20", VA = "0x1808CC920")]
		protected AdditionalOutfitTypeData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public abstract class AdditionalOutfitTypeData<T> : AdditionalOutfitTypeData, IEquatable<T> where T : AdditionalOutfitTypeData<T>
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x45C86C0", Offset = "0x45C7AC0", VA = "0x1845C86C0", Slot = "5")]
		public override bool Equals(AdditionalOutfitTypeData BMKPAKCEMFK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		public abstract bool Equals(T BMKPAKCEMFK);

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8F0CF0", Offset = "0x8F00F0", VA = "0x1808F0CF0")]
		protected AdditionalOutfitTypeData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public class BeardData : AdditionalOutfitTypeData<BeardData>, DDPDKGDALHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public HairPatternStyle beardHairPatternStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public bool usesHairColor;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool UsesHairColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xCF7B10", Offset = "0xCF6F10", VA = "0x180CF7B10", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public HairPatternStyle PatternStyle
		{
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x8C51A0", Offset = "0x8C45A0", VA = "0x1808C51A0", Slot = "10")]
			get
			{
				return default(HairPatternStyle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6E900C0", Offset = "0x6E8F4C0", VA = "0x186E900C0", Slot = "8")]
		public override bool Equals(BeardData BMKPAKCEMFK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6E900E0", Offset = "0x6E8F4E0", VA = "0x186E900E0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6E90150", Offset = "0x6E8F550", VA = "0x186E90150")]
		public BeardData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class HairData : AdditionalOutfitTypeData<HairData>, DDPDKGDALHO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public float radius;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public Vector3 hemispherePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public Quaternion hemisphereRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public Vector3 hemisphereScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public HairPatternStyle hairPatternStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public bool usesHairColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public HelmetHairStyle helmetHairStyle;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool UsesHairColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x942EF0", Offset = "0x9422F0", VA = "0x180942EF0", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public HairPatternStyle PatternStyle
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x8E4C60", Offset = "0x8E4060", VA = "0x1808E4C60", Slot = "10")]
			get
			{
				return default(HairPatternStyle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public HelmetHairStyle HelmetHairStyle
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x96EF30", Offset = "0x96E330", VA = "0x18096EF30")]
			get
			{
				return default(HelmetHairStyle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public FitMeshHemisphere Hemisphere
		{
			[Cpp2IlInjected.Token(Token = "0x6000078")]
			[Cpp2IlInjected.Address(RVA = "0x6E91250", Offset = "0x6E90650", VA = "0x186E91250")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6E90EA0", Offset = "0x6E902A0", VA = "0x186E90EA0", Slot = "8")]
		public override bool Equals(HairData BMKPAKCEMFK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6E91090", Offset = "0x6E90490", VA = "0x186E91090", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x6E91190", Offset = "0x6E90590", VA = "0x186E91190")]
		public HairData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public interface DDPDKGDALHO
{
	[Cpp2IlInjected.Token(Token = "0x17000033")]
	bool OFOAOKKLIGL
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	HairPatternStyle OELJBBOLCND
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class FGBGDIBDHDF
{
	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6E90350", Offset = "0x6E8F750", VA = "0x186E90350")]
	public static HAPHCDJNHOG NJNPNJEOBGP(this OutfitType HKNHLPOKHIK, AvatarItemSidednessEquipType OHGENCKHMKH = AvatarItemSidednessEquipType.Left)
	{
		return default(HAPHCDJNHOG);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6E902F0", Offset = "0x6E8F6F0", VA = "0x186E902F0")]
	public static HAPHCDJNHOG LMKJCEFHHJE(this HAPHCDJNHOG JBCPDKGINNI)
	{
		return default(HAPHCDJNHOG);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6E90270", Offset = "0x6E8F670", VA = "0x186E90270")]
	public static bool EEGPPFPFPMB(this OutfitType HKNHLPOKHIK, HAPHCDJNHOG JBCPDKGINNI)
	{
		return default(bool);
	}
}
namespace RecRoom.Avatars.Data.Shared
{
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public enum AvatarItemSidednessEquipType
	{
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		Left,
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		Both,
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		Right
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class LHEINIOHPKF
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6E914C0", Offset = "0x6E908C0", VA = "0x186E914C0")]
	public static bool OMDDBLBEMLK(this AvatarItemSidednessEquipType OHGENCKHMKH, HAPHCDJNHOG JBCPDKGINNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6E91490", Offset = "0x6E90890", VA = "0x186E91490")]
	public static bool GGALDJBNAGI(this AvatarItemSidednessEquipType AEDDGDNJFBL, HAPHCDJNHOG JBCPDKGINNI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6E91450", Offset = "0x6E90850", VA = "0x186E91450")]
	public static bool EADAIAOCPPJ(this AvatarItemSidednessEquipType LJJDFHGKCMC, AvatarItemSidednessEquipType JPHBPNJFNPJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6E91470", Offset = "0x6E90870", VA = "0x186E91470")]
	public static AvatarItemSidednessEquipType FMLLBGHCBOJ(this AvatarItemSidednessEquipType LJJDFHGKCMC)
	{
		return default(AvatarItemSidednessEquipType);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
internal enum EOOKACEJIGK
{
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	None = -1,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	Hat = 0,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	Hair = 1,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	Ear = 2,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	Eye = 3,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	Beard = 4,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	Shoulder = 5,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	Shirt = 6,
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	Waist = 7,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	Neck = 8,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	Wrist = 10
}
namespace RecRoom.Avatars.Data.Shared
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	[Flags]
	public enum OutfitSlotFlags
	{
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		Hat = 1,
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		Hair = 2,
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		Ear = 4,
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		Eye = 8,
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		Beard = 0x10,
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		Shoulder = 0x20,
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		Shirt = 0x40,
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		Waist = 0x80,
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		Neck = 0x100,
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		Wrist = 0x400,
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		All = int.MaxValue
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public static class APKMHEIKGAE
{
	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6E8DFD0", Offset = "0x6E8D3D0", VA = "0x186E8DFD0")]
	private static EOOKACEJIGK DIJLNDPECJD(this OutfitType HKNHLPOKHIK)
	{
		return default(EOOKACEJIGK);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6E8E330", Offset = "0x6E8D730", VA = "0x186E8E330")]
	public static OutfitSlotFlags GICNPMABKKL(this OutfitType HKNHLPOKHIK)
	{
		return default(OutfitSlotFlags);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6E8E4A0", Offset = "0x6E8D8A0", VA = "0x186E8E4A0")]
	public static bool PAPHLJMMHKM(this OutfitSlotFlags CGEIKKDBHCO, OutfitSlotFlags BIGIOCEDFEA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x6E8E140", Offset = "0x6E8D540", VA = "0x186E8E140")]
	public static bool FHAJGCOCMNK(this OutfitType HKNHLPOKHIK, OutfitSlotFlags NFGMAAGCHPG)
	{
		return default(bool);
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
