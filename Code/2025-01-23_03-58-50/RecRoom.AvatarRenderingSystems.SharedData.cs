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
public interface PDGDLGHNGDC
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	float LCEJDMPNKPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	float BEEDLPMLHBL
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	float BGGCDLNGEPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	float IAPNHCIBJJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float HDPOLCPIBGD
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	float JEHAPGLACFM
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float KBJILHMFMJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float KIKPHCJOAMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float AACGPGEJPAH
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	float KNDBNMKIEJG
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	float DEGENHAADKI
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	float IIKPNJPHFIG
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	float OANEOAKHGJK
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	float NLLAALJONGF
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	float MGAKPIICEKG
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	float EJHGKNEGOHH
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Vector3 NKPBGBFDFFJ(Vector3 ICEMFMMEPBF);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Vector3 JPPFKFNHDLI(Vector3 MOLCJGIOMMN);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Vector3 CLLNEGKGCGH();
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class AnchorParamsRestrictions : PDGDLGHNGDC
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
			[Cpp2IlInjected.Address(RVA = "0x95C5D0", Offset = "0x95ADD0", VA = "0x18095C5D0", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool GetAllowRotations
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xF57710", Offset = "0xF55F10", VA = "0x180F57710", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xB07540", Offset = "0xB05D40", VA = "0x180B07540", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x96C580", Offset = "0x96AD80", VA = "0x18096C580", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0xC155E0", Offset = "0xC13DE0", VA = "0x180C155E0", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xB08640", Offset = "0xB06E40", VA = "0x180B08640", Slot = "7")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x924CC0", Offset = "0x9234C0", VA = "0x180924CC0", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0x8E6460", Offset = "0x8E4C60", VA = "0x1808E6460", Slot = "9")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 DefaultOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x6DEA780", Offset = "0x6DE8F80", VA = "0x186DEA780")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 MinOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x6DEB350", Offset = "0x6DE9B50", VA = "0x186DEB350")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector3 MaxOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x6DEB330", Offset = "0x6DE9B30", VA = "0x186DEB330")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0xC6A220", Offset = "0xC68A20", VA = "0x180C6A220", Slot = "12")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0xC15580", Offset = "0xC13D80", VA = "0x180C15580", Slot = "13")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0x924CB0", Offset = "0x9234B0", VA = "0x180924CB0", Slot = "10")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x924CA0", Offset = "0x9234A0", VA = "0x180924CA0", Slot = "11")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xAE87F0", Offset = "0xAE6FF0", VA = "0x180AE87F0", Slot = "14")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0xC733C0", Offset = "0xC71BC0", VA = "0x180C733C0", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Vector3 DefaultRotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6DEB1A0", Offset = "0x6DE99A0", VA = "0x186DEB1A0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Vector3 RightRotationFreedom
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6DEB370", Offset = "0x6DE9B70", VA = "0x186DEB370")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector3 LeftRotationFreedom
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6DEB310", Offset = "0x6DE9B10", VA = "0x186DEB310")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public float GetMaxUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0xC73400", Offset = "0xC71C00", VA = "0x180C73400", Slot = "16")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public float GetMinUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xC73430", Offset = "0xC71C30", VA = "0x180C73430", Slot = "17")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xC73420", Offset = "0xC71C20", VA = "0x180C73420", Slot = "18")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8D1760", Offset = "0x8CFF60", VA = "0x1808D1760", Slot = "19")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector2 URange
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x6DEB390", Offset = "0x6DE9B90", VA = "0x186DEB390")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x6DEB3D0", Offset = "0x6DE9BD0", VA = "0x186DEB3D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector2 VRange
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x6DEB3B0", Offset = "0x6DE9BB0", VA = "0x186DEB3B0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x6DEB3F0", Offset = "0x6DE9BF0", VA = "0x186DEB3F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x6DEB280", Offset = "0x6DE9A80", VA = "0x186DEB280")]
		public AnchorParamsRestrictions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x6DEA490", Offset = "0x6DE8C90", VA = "0x186DEA490")]
		public IOKFCBDBELC CBKDMGICNDL(IOKFCBDBELC DEEECPMFKNE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x6DEB1A0", Offset = "0x6DE99A0", VA = "0x186DEB1A0", Slot = "25")]
		public Vector3 PDPBEDINANB()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x6DEA780", Offset = "0x6DE8F80", VA = "0x186DEA780", Slot = "22")]
		public Vector3 CLLNEGKGCGH()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x6DEB130", Offset = "0x6DE9930", VA = "0x186DEB130", Slot = "20")]
		public Vector3 NKPBGBFDFFJ(Vector3 ICEMFMMEPBF)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x6DEB0B0", Offset = "0x6DE98B0", VA = "0x186DEB0B0", Slot = "21")]
		public Vector3 JPPFKFNHDLI(Vector3 MOLCJGIOMMN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x6DEA7A0", Offset = "0x6DE8FA0", VA = "0x186DEA7A0", Slot = "0")]
		public override bool Equals(object INCBEIDOHDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x6DEA8B0", Offset = "0x6DE90B0", VA = "0x186DEA8B0")]
		protected bool GBNBMLOJEOB(AnchorParamsRestrictions LIHCAHPMPHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x6DEADB0", Offset = "0x6DE95B0", VA = "0x186DEADB0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x6DEA420", Offset = "0x6DE8C20", VA = "0x186DEA420")]
		[CompilerGenerated]
		internal static bool AELBLNDGECI(float DAOGAHJCGEC, float NBDADAEEFHF)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class PKDHHLEOOHL
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x11A0630", Offset = "0x119EE30", VA = "0x1811A0630")]
	public static bool BCFCNIFKIAJ(this AEIOBEGHMKA OBBFLJMOIGC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x6DECB80", Offset = "0x6DEB380", VA = "0x186DECB80")]
	public static bool GEGNIONDNJP(this AEIOBEGHMKA OBBFLJMOIGC)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class PGDILPHLBFK
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public static bool FIPNJHDCHOD;
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000006")]
	public enum HelmetHairMode
	{
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		[InspectorName("Show Hair")]
		DoNotHideHair,
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		[InspectorName("Use Helmet Hair")]
		UseHelmetHair,
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		[InspectorName("Hide Hair (Always)")]
		AlwaysHideHair,
		[Cpp2IlInjected.Token(Token = "0x4000027")]
		[InspectorName("Hide Hair (Optional)")]
		HideHairToggleable
	}
	[Cpp2IlInjected.Token(Token = "0x2000007")]
	public enum HelmetHairStyle
	{
		[Cpp2IlInjected.Token(Token = "0x4000029")]
		Normal = 0,
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		Curly = 1,
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		Self = -1
	}
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public enum HairPatternStyle
	{
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		Default,
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		NoPattern,
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		Curly,
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		Braid
	}
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public enum AvatarItemBodyType
	{
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		BeanBody,
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		FullBody,
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		ModernBeanBody
	}
}
[Cpp2IlInjected.Token(Token = "0x200000A")]
public static class BBLKGHDFCGP
{
	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x6DEB490", Offset = "0x6DE9C90", VA = "0x186DEB490")]
	public static bool DLHIIALMPHI(this HelmetHairMode JIJHHNIOAFF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x6DEB410", Offset = "0x6DE9C10", VA = "0x186DEB410")]
	public static HBPDIAMDKLD DEBDMEDLGIC(this AvatarItemBodyType PABCJGJOBAA)
	{
		return default(HBPDIAMDKLD);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x6DEB560", Offset = "0x6DE9D60", VA = "0x186DEB560")]
	public static AvatarItemBodyType PPNBDHDOMGO(this HBPDIAMDKLD PABCJGJOBAA)
	{
		return default(AvatarItemBodyType);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x6DEB4A0", Offset = "0x6DE9CA0", VA = "0x186DEB4A0")]
	public static string EJPHOMDABOH(this AvatarItemBodyType PABCJGJOBAA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class EAIGMANLNFK
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public enum FKOIGNJMDDB
	{
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		Head,
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		TorsoAll,
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		TorsoHigh,
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		TorsoLow,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		SleevesShort,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		SleevesLong,
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		DEPRECATED_Palm,
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		DEPRECATED_HandsAll,
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		PantsLong,
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		Shorts,
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		FootMid,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		ShoeLow,
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		PantsShort,
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		PalmL,
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		PalmR,
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		HandL,
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		HandR,
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		Ears,
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		FootHigh
	}

	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[Flags]
	public enum LFNICJCICHD
	{
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		Head = 1,
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		TorsoAll = 2,
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		TorsoHigh = 4,
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		TorsoLow = 8,
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		SleevesShort = 0x10,
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		SleevesLong = 0x20,
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		DEPRECATED_Palm = 0x40,
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		DEPRECATED_HandsAll = 0x80,
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		PantsLong = 0x100,
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		Shorts = 0x200,
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		FootMid = 0x400,
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		ShoeLow = 0x800,
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		PantsShort = 0x1000,
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		PalmL = 0x2000,
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		PalmR = 0x4000,
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		HandL = 0x8000,
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		HandR = 0x10000,
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		Ears = 0x20000,
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		FootHigh = 0x40000
	}

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly LFNICJCICHD CDCJAIDFANG;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly LFNICJCICHD MAPOBFCNFFO;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly LFNICJCICHD KADOJBMEKEH;

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x6DEB820", Offset = "0x6DEA020", VA = "0x186DEB820")]
	public static LFNICJCICHD MHFMPHNADGG(LFNICJCICHD IAGEKKOFAEH, LFNICJCICHD BMPNMJEJJMG)
	{
		return default(LFNICJCICHD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6DEB8A0", Offset = "0x6DEA0A0", VA = "0x186DEB8A0")]
	public static LFNICJCICHD PHONHDFIJGP(LFNICJCICHD AEKCJNNENPE, LFNICJCICHD EBPAONPNCGD)
	{
		return default(LFNICJCICHD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6DEB790", Offset = "0x6DE9F90", VA = "0x186DEB790")]
	public static LFNICJCICHD IMEMHIHLKEM(FKOIGNJMDDB CKOHNIKLNIC, LFNICJCICHD KPIOCPGNCIC)
	{
		return default(LFNICJCICHD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6DEB810", Offset = "0x6DEA010", VA = "0x186DEB810")]
	public static LFNICJCICHD LBOJCIHIAKE(FKOIGNJMDDB CKOHNIKLNIC, LFNICJCICHD KPIOCPGNCIC)
	{
		return default(LFNICJCICHD);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6DEB7A0", Offset = "0x6DE9FA0", VA = "0x186DEB7A0")]
	public static bool KKOKHFKDJEE(this LFNICJCICHD POAGPEBCNEL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6DEB830", Offset = "0x6DEA030", VA = "0x186DEB830")]
	public static bool NKPEJHFMPKI(this LFNICJCICHD POAGPEBCNEL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public class JLDEDNBPGBN
{
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	public enum LPLGBBLCAGO : short
	{
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		None = -1,
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		Happy = 0,
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		Love = 1,
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		Laugh = 2,
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		TongueOut = 3,
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		Wink = 4,
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		Smirk = 5,
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		SmileSweat = 10,
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		Grimacing = 11,
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		Shocked = 12,
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		Thinking = 13,
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		Sleeping = 14,
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		Sad = 20,
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		Angry = 21,
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		Nauseated = 22,
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		Flat = 23,
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		Smile = 100
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public class FitMeshHemisphere
	{
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		public static readonly Vector2 UV_CENTER_COORDINATE;

		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public static readonly Vector3 DEFAULT_HEMISPHERE_FITMESH_PIVOT_POSITION;

		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public static readonly Quaternion DEFAULT_HEMISPHERE_FITMESH_PIVOT_ROTATION;

		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public static readonly Vector3 DEFAULT_HEMISPHERE_FITMESH_PIVOT_SCALE;

		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public const float DEFAULT_HEMISPHERE_RADIUS = 0.13f;

		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public static readonly FitMeshHemisphere Default;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public Vector3 hemispherePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		public Quaternion hemisphereRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public Vector3 hemisphereScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		public float radius;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool IsRadiusValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x6DEC420", Offset = "0x6DEAC20", VA = "0x186DEC420")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x6DEB980", Offset = "0x6DEA180", VA = "0x186DEB980")]
		public void GAFECMDEOJE(FitMeshHemisphere DFPFLNMHNBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x6DEBD50", Offset = "0x6DEA550", VA = "0x186DEBD50")]
		public Vector3 KKNEMILEACD(Vector2 DKEBCCIFDJJ, bool BNEBKGJGBGE = true)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x6DEB920", Offset = "0x6DEA120", VA = "0x186DEB920")]
		public Vector3 FEHOJENGGNH(Vector2 DKEBCCIFDJJ)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x6DEBB90", Offset = "0x6DEA390", VA = "0x186DEBB90")]
		public Quaternion IGCMHGNDFNA(Vector2 DKEBCCIFDJJ)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x6DEBA20", Offset = "0x6DEA220", VA = "0x186DEBA20")]
		public Quaternion IGCMHGNDFNA(Vector2 DKEBCCIFDJJ, Vector3 CJJFEDJOEMF)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x6DEB9D0", Offset = "0x6DEA1D0", VA = "0x186DEB9D0")]
		public Vector2 HOBGMDKECJP(Vector2 JGDGMJBALFA)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x6DEC370", Offset = "0x6DEAB70", VA = "0x186DEC370")]
		public FitMeshHemisphere()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public enum OutfitType
	{
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		None = -1,
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		Hat = 0,
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		Hair = 2,
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		Ear = 3,
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		Eye = 10,
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		Beard = 20,
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		Shoulder = 100,
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		Shirt = 101,
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		Waist = 102,
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		Neck = 103,
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		TeamJersey = 104,
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		CustomShirt = 105,
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		Wrist = 200,
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		TeamWrist = 203,
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		Legs = 300,
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		Feet = 301
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public static class CFBEOPIEIED
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x6DEB6D0", Offset = "0x6DE9ED0", VA = "0x186DEB6D0")]
	public static bool FMJOFBMAMNE(this OutfitType DOAOHLJCGOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x6DEB730", Offset = "0x6DE9F30", VA = "0x186DEB730")]
	public static bool IPJFHFHEOJO(this OutfitType DOAOHLJCGOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x6DEB6B0", Offset = "0x6DE9EB0", VA = "0x186DEB6B0")]
	public static bool ADBKCKBKLNF(this OutfitType DOAOHLJCGOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x6DEB720", Offset = "0x6DE9F20", VA = "0x186DEB720")]
	public static bool INGCKKNOKPA(this OutfitType DOAOHLJCGOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x6DEB750", Offset = "0x6DE9F50", VA = "0x186DEB750")]
	public static bool KNDDHHABGME(this OutfitType DOAOHLJCGOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x6DEB700", Offset = "0x6DE9F00", VA = "0x186DEB700")]
	public static bool GENHCFFOMNJ(this OutfitType DOAOHLJCGOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6DEB6F0", Offset = "0x6DE9EF0", VA = "0x186DEB6F0")]
	public static bool GAJIMBLEKEH(this OutfitType DOAOHLJCGOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6DEB6C0", Offset = "0x6DE9EC0", VA = "0x186DEB6C0")]
	public static bool BEBALCCNPMM(this OutfitType DOAOHLJCGOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6DEB760", Offset = "0x6DE9F60", VA = "0x186DEB760")]
	public static bool MKILKEDNDPP(this OutfitType DOAOHLJCGOI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6DEB780", Offset = "0x6DE9F80", VA = "0x186DEB780")]
	public static bool PCDNOPGCFBN(this OutfitType DOAOHLJCGOI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class OIONHLLJNIJ : IEqualityComparer<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	public static readonly OIONHLLJNIJ ODDIIHPHFEL;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6DECA70", Offset = "0x6DEB270", VA = "0x186DECA70", Slot = "4")]
	public bool Equals(OutfitType BPNIFJOBIHJ, OutfitType OFHJCAHBFDB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6DECAD0", Offset = "0x6DEB2D0", VA = "0x186DECAD0", Slot = "5")]
	public int GetHashCode(OutfitType OCLAPBNMMGE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
	public OIONHLLJNIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public enum AINGIJEMIFC
{
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	SkinColor,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	PrimaryHairColor,
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	SecondaryHairColor,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	PrimaryBeardColor,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	SecondaryBeardColor,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	UGCShirtColor,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	TeamColor,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	TeamEmissiveColor
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum EIDJHFBIHJL
{
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	HairPattern,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	BeardPattern
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum AGEOOIMHKJF
{
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	TeamItem,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	SkinColor,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	HairColor,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	BeardColor,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	UGCShirtColor
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum DMGIDOOBPMF
{
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	HairTexture,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	BeardTexture,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	UGCShirtTexture
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public enum BDBJJGAKCLO
{
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	CollapseSubMeshes,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	CollapseToUniqueMaterials,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	MergeAll
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum CGELODKCHMB
{
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	Base,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	Wide,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	Flat,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	Downturned,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	Hooked,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	Long,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	Upturned,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	None
}
namespace RecRoom.Avatars.Data.Shared
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001A")]
	public class AdditionalFeetData : AdditionalOutfitTypeData<AdditionalFeetData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		public float heelAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		public float heightOffset;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x6DE9930", Offset = "0x6DE8130", VA = "0x186DE9930", Slot = "7")]
		public override bool Equals(AdditionalFeetData LIHCAHPMPHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x6DE9960", Offset = "0x6DE8160", VA = "0x186DE9960", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x6DE99E0", Offset = "0x6DE81E0", VA = "0x186DE99E0")]
		public AdditionalFeetData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class AdditionalHatData : AdditionalOutfitTypeData<AdditionalHatData>
	{
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		public static readonly Vector2 DEFAULT_HAT_UV_OVERRIDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		public HelmetHairMode helmetHairMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public bool legacyHidesHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		[ReadOnlyField]
		public bool UseHatUVOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		[ReadOnlyField]
		public Vector2 HatUVOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		[ReadOnlyField]
		public bool AllowFitMeshOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		[ReadOnlyField]
		public Vector3 FitMeshPivotPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		[ReadOnlyField]
		public Quaternion FitMeshPivotRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		[ReadOnlyField]
		public AnchorParamsRestrictions AnchorParamsRestrictions;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector2 UVOverride
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x6DE9F20", Offset = "0x6DE8720", VA = "0x186DE9F20")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x6DE9A20", Offset = "0x6DE8220", VA = "0x186DE9A20", Slot = "7")]
		public override bool Equals(AdditionalHatData LIHCAHPMPHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x6DE9C10", Offset = "0x6DE8410", VA = "0x186DE9C10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x6DE9D70", Offset = "0x6DE8570", VA = "0x186DE9D70")]
		public AdditionalHatData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public abstract class AdditionalOutfitTypeData : IEquatable<AdditionalOutfitTypeData>
	{
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		protected const float EPSILON = 0.001f;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x6DEA030", Offset = "0x6DE8830", VA = "0x186DEA030")]
		public static bool HCMKMPIDOGN(OutfitType OCLAPBNMMGE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x6DEA060", Offset = "0x6DE8860", VA = "0x186DEA060")]
		public static AdditionalOutfitTypeData JHEOKMMJDLF(OutfitType OCLAPBNMMGE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x6DE9FA0", Offset = "0x6DE87A0", VA = "0x186DE9FA0", Slot = "0")]
		public override bool Equals(object INCBEIDOHDO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract bool Equals(AdditionalOutfitTypeData LIHCAHPMPHD);

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x8C5530", Offset = "0x8C3D30", VA = "0x1808C5530")]
		protected AdditionalOutfitTypeData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public abstract class AdditionalOutfitTypeData<T> : AdditionalOutfitTypeData, IEquatable<T> where T : AdditionalOutfitTypeData<T>
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x47B0AF0", Offset = "0x47AF2F0", VA = "0x1847B0AF0", Slot = "5")]
		public override bool Equals(AdditionalOutfitTypeData LIHCAHPMPHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract bool Equals(T LIHCAHPMPHD);

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8E06A0", Offset = "0x8DEEA0", VA = "0x1808E06A0")]
		protected AdditionalOutfitTypeData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public class BeardData : AdditionalOutfitTypeData<BeardData>, OEEKMHACBEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public HairPatternStyle beardHairPatternStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public bool usesHairColor;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool UsesHairColor
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0xCEFF80", Offset = "0xCEE780", VA = "0x180CEFF80", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public HairPatternStyle PatternStyle
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x8B51A0", Offset = "0x8B39A0", VA = "0x1808B51A0", Slot = "9")]
			get
			{
				return default(HairPatternStyle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x6DEB5E0", Offset = "0x6DE9DE0", VA = "0x186DEB5E0", Slot = "7")]
		public override bool Equals(BeardData LIHCAHPMPHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6DEB600", Offset = "0x6DE9E00", VA = "0x186DEB600", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x6DEB670", Offset = "0x6DE9E70", VA = "0x186DEB670")]
		public BeardData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class HairData : AdditionalOutfitTypeData<HairData>, OEEKMHACBEH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public float radius;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public Vector3 hemispherePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public Quaternion hemisphereRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public Vector3 hemisphereScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public HairPatternStyle hairPatternStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public bool usesHairColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public HelmetHairStyle helmetHairStyle;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool UsesHairColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x933530", Offset = "0x931D30", VA = "0x180933530", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public HairPatternStyle PatternStyle
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x8D4640", Offset = "0x8D2E40", VA = "0x1808D4640", Slot = "9")]
			get
			{
				return default(HairPatternStyle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public HelmetHairStyle HelmetHairStyle
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x95B900", Offset = "0x95A100", VA = "0x18095B900")]
			get
			{
				return default(HelmetHairStyle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public FitMeshHemisphere Hemisphere
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x6DEC7E0", Offset = "0x6DEAFE0", VA = "0x186DEC7E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6DEC430", Offset = "0x6DEAC30", VA = "0x186DEC430", Slot = "7")]
		public override bool Equals(HairData LIHCAHPMPHD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x6DEC620", Offset = "0x6DEAE20", VA = "0x186DEC620", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x6DEC720", Offset = "0x6DEAF20", VA = "0x186DEC720")]
		public HairData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public interface OEEKMHACBEH
{
	[Cpp2IlInjected.Token(Token = "0x17000033")]
	bool LBEIGEBCIJK
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	HairPatternStyle FJDJHNEJEEG
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class KPHCDAICMEI
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6DEC870", Offset = "0x6DEB070", VA = "0x186DEC870")]
	public static AEIOBEGHMKA INFOJGDKLDG(this OutfitType DOAOHLJCGOI, AvatarItemSidednessEquipType KJNNDCAMBAO = AvatarItemSidednessEquipType.Left)
	{
		return default(AEIOBEGHMKA);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6DEC970", Offset = "0x6DEB170", VA = "0x186DEC970")]
	public static AEIOBEGHMKA MFPADFHHLNJ(this AEIOBEGHMKA ALHMBEPBCGJ)
	{
		return default(AEIOBEGHMKA);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x6DEC8F0", Offset = "0x6DEB0F0", VA = "0x186DEC8F0")]
	public static bool KJCMDBCPGLC(this OutfitType DOAOHLJCGOI, AEIOBEGHMKA ALHMBEPBCGJ)
	{
		return default(bool);
	}
}
namespace RecRoom.Avatars.Data.Shared
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public enum AvatarItemSidednessEquipType
	{
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		Left,
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		Both,
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		Right
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public static class NIDAJHNJBML
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6DECA00", Offset = "0x6DEB200", VA = "0x186DECA00")]
	public static bool BBGEAMNBMJB(this AvatarItemSidednessEquipType KJNNDCAMBAO, AEIOBEGHMKA ALHMBEPBCGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6DEC9D0", Offset = "0x6DEB1D0", VA = "0x186DEC9D0")]
	public static bool AOCBILOCOID(this AvatarItemSidednessEquipType NIDNENKOCJN, AEIOBEGHMKA ALHMBEPBCGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6DECA30", Offset = "0x6DEB230", VA = "0x186DECA30")]
	public static bool DLJPEHIBCFD(this AvatarItemSidednessEquipType CMHMGBMPGJJ, AvatarItemSidednessEquipType KICIBNLJPCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6DECA50", Offset = "0x6DEB250", VA = "0x186DECA50")]
	public static AvatarItemSidednessEquipType LGGAENOPIGM(this AvatarItemSidednessEquipType CMHMGBMPGJJ)
	{
		return default(AvatarItemSidednessEquipType);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
internal enum ANDGMAINEOP
{
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	None = -1,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	Hat = 0,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	Hair = 1,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	Ear = 2,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	Eye = 3,
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	Beard = 4,
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	Shoulder = 5,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	Shirt = 6,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	Waist = 7,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	Neck = 8,
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	Wrist = 10
}
namespace RecRoom.Avatars.Data.Shared
{
	[Cpp2IlInjected.Token(Token = "0x2000025")]
	[Flags]
	public enum OutfitSlotFlags
	{
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		Hat = 1,
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		Hair = 2,
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		Ear = 4,
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		Eye = 8,
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		Beard = 0x10,
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		Shoulder = 0x20,
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		Shirt = 0x40,
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		Waist = 0x80,
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		Neck = 0x100,
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		Wrist = 0x400,
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		All = int.MaxValue
	}
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public static class AHKKEMLCAMM
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6DE9460", Offset = "0x6DE7C60", VA = "0x186DE9460")]
	private static ANDGMAINEOP KDOIJDPELBJ(this OutfitType DOAOHLJCGOI)
	{
		return default(ANDGMAINEOP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6DE97C0", Offset = "0x6DE7FC0", VA = "0x186DE97C0")]
	public static OutfitSlotFlags KPCBAOPLLLD(this OutfitType DOAOHLJCGOI)
	{
		return default(OutfitSlotFlags);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6DE9450", Offset = "0x6DE7C50", VA = "0x186DE9450")]
	public static bool DFFBOOOOLDP(this OutfitSlotFlags PKICGOEPCJH, OutfitSlotFlags CKOBMLFGIFJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6DE95D0", Offset = "0x6DE7DD0", VA = "0x186DE95D0")]
	public static bool KNKADJODEKI(this OutfitType DOAOHLJCGOI, OutfitSlotFlags FCMFMCPDBAG)
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
