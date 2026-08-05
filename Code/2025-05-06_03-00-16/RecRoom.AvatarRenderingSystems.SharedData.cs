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
public interface FFGGGJLBFJP
{
	[Cpp2IlInjected.Token(Token = "0x17000001")]
	float DAOPBGONLLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	float AEGPPIAAKFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	float PAMEKHCMDCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	float DGAMNCPOOME
	{
		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	float NEADLHMIFPA
	{
		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	float IKHLIBODIAO
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	float KGEMHNIHJDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	float MCIONKOFBCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	float DDFMKDGIOKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	float BDBIBCEEBMG
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	float DMIEDEGAFLG
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	float GNIILDJAEII
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	float NFINMFNBDNN
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	float JKPHBHFOFLM
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	float EEHGPOFKNNF
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	float CIHLIBEEGBH
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(Slot = "16")]
	Vector3 LAINIHOPAEH(Vector3 EGGHFEMCBAC);

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(Slot = "17")]
	Vector3 FBJBAEAAFJG(Vector3 OPGCBMDFJBH);

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(Slot = "18")]
	Vector3 JKGDGMIDMMC();
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class AnchorParamsRestrictions : FFGGGJLBFJP
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
			[Cpp2IlInjected.Address(RVA = "0xC47930", Offset = "0xC46130", VA = "0x180C47930", Slot = "23")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000012")]
		public bool GetAllowRotations
		{
			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0xC46E20", Offset = "0xC45620", VA = "0x180C46E20", Slot = "24")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000013")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0xEB6410", Offset = "0xEB4C10", VA = "0x180EB6410", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000014")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0xD03120", Offset = "0xD01920", VA = "0x180D03120", Slot = "5")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000015")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x1048690", Offset = "0x1046E90", VA = "0x181048690", Slot = "6")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000016")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0xF14BE0", Offset = "0xF133E0", VA = "0x180F14BE0", Slot = "7")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000017")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0xBCD620", Offset = "0xBCBE20", VA = "0x180BCD620", Slot = "8")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000018")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xA0E660", Offset = "0xA0CE60", VA = "0x180A0E660", Slot = "9")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000019")]
		public Vector3 DefaultOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001C")]
			[Cpp2IlInjected.Address(RVA = "0x79ABD80", Offset = "0x79AA580", VA = "0x1879ABD80")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public Vector3 MinOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001D")]
			[Cpp2IlInjected.Address(RVA = "0x79AC020", Offset = "0x79AA820", VA = "0x1879AC020")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public Vector3 MaxOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0x79AC000", Offset = "0x79AA800", VA = "0x1879AC000")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x600001F")]
			[Cpp2IlInjected.Address(RVA = "0x108A790", Offset = "0x1088F90", VA = "0x18108A790", Slot = "12")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x6000020")]
			[Cpp2IlInjected.Address(RVA = "0x1048640", Offset = "0x1046E40", VA = "0x181048640", Slot = "13")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x6000021")]
			[Cpp2IlInjected.Address(RVA = "0xBD7A50", Offset = "0xBD6250", VA = "0x180BD7A50", Slot = "10")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0xBD7EF0", Offset = "0xBD66F0", VA = "0x180BD7EF0", Slot = "11")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0xE99CD0", Offset = "0xE984D0", VA = "0x180E99CD0", Slot = "14")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x1093C70", Offset = "0x1092470", VA = "0x181093C70", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public Vector3 DefaultRotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x79ABE80", Offset = "0x79AA680", VA = "0x1879ABE80")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public Vector3 RightRotationFreedom
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x79AC040", Offset = "0x79AA840", VA = "0x1879AC040")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public Vector3 LeftRotationFreedom
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x79ABFE0", Offset = "0x79AA7E0", VA = "0x1879ABFE0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public float GetMaxUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x1093CB0", Offset = "0x10924B0", VA = "0x181093CB0", Slot = "16")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		public float GetMinUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0xC47940", Offset = "0xC46140", VA = "0x180C47940", Slot = "17")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xC466D0", Offset = "0xC44ED0", VA = "0x180C466D0", Slot = "18")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x9F98F0", Offset = "0x9F80F0", VA = "0x1809F98F0", Slot = "19")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Vector2 URange
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x79AC060", Offset = "0x79AA860", VA = "0x1879AC060")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x79AC0A0", Offset = "0x79AA8A0", VA = "0x1879AC0A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public Vector2 VRange
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x79AC080", Offset = "0x79AA880", VA = "0x1879AC080")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x79AC0C0", Offset = "0x79AA8C0", VA = "0x1879AC0C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000030")]
		[Cpp2IlInjected.Address(RVA = "0x79ABF50", Offset = "0x79AA750", VA = "0x1879ABF50")]
		public AnchorParamsRestrictions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000031")]
		[Cpp2IlInjected.Address(RVA = "0x79ABAA0", Offset = "0x79AA2A0", VA = "0x1879ABAA0")]
		public PNINFJFLLCD IGDGPFDCPFP(PNINFJFLLCD GDHHJDMGDFG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x79ABE80", Offset = "0x79AA680", VA = "0x1879ABE80", Slot = "25")]
		public Vector3 NEGLDLDJEHP()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x79ABD80", Offset = "0x79AA580", VA = "0x1879ABD80", Slot = "22")]
		public Vector3 JKGDGMIDMMC()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x79ABDA0", Offset = "0x79AA5A0", VA = "0x1879ABDA0", Slot = "20")]
		public Vector3 LAINIHOPAEH(Vector3 EGGHFEMCBAC)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x79AB220", Offset = "0x79A9A20", VA = "0x1879AB220", Slot = "21")]
		public Vector3 FBJBAEAAFJG(Vector3 OPGCBMDFJBH)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x79AB110", Offset = "0x79A9910", VA = "0x1879AB110", Slot = "0")]
		public override bool Equals(object PNHCNFOFAFI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x79AB2A0", Offset = "0x79A9AA0", VA = "0x1879AB2A0")]
		protected bool GNBACMEALJB(AnchorParamsRestrictions PGPJMFPAKOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x79AB7A0", Offset = "0x79A9FA0", VA = "0x1879AB7A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x79ABE10", Offset = "0x79AA610", VA = "0x1879ABE10")]
		[CompilerGenerated]
		internal static bool LIMDCIJABHB(float BINANFFLHIK, float NOAPPAEGHOH)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class NCOJDNBOKAL
{
	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x15BF470", Offset = "0x15BDC70", VA = "0x1815BF470")]
	public static bool LKGLOKADGOL(this PNLIIGCPIIK AHBBECMMPOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003C")]
	[Cpp2IlInjected.Address(RVA = "0x79AE5C0", Offset = "0x79ACDC0", VA = "0x1879AE5C0")]
	public static bool OAAACGLKELF(this PNLIIGCPIIK AHBBECMMPOG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003D")]
	[Cpp2IlInjected.Address(RVA = "0x79AE5A0", Offset = "0x79ACDA0", VA = "0x1879AE5A0")]
	public static bool GONCJAAMGDB(this PNLIIGCPIIK AHBBECMMPOG)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public static class INMDGPGHAAC
{
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public static bool HGMMKDFGFEH;
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
public static class JPKMFHHMNLO
{
	[Cpp2IlInjected.Token(Token = "0x600003E")]
	[Cpp2IlInjected.Address(RVA = "0x79AE2F0", Offset = "0x79ACAF0", VA = "0x1879AE2F0")]
	public static bool HPGNDGNILIG(this HelmetHairMode DELDHBMPINE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x79AE3C0", Offset = "0x79ACBC0", VA = "0x1879AE3C0")]
	public static DODMAGIBHBA NODBOAKPDNJ(this AvatarItemBodyType HECCPBIHNCK)
	{
		return default(DODMAGIBHBA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x79AE440", Offset = "0x79ACC40", VA = "0x1879AE440")]
	public static AvatarItemBodyType PIJPFBACIMK(this DODMAGIBHBA HECCPBIHNCK)
	{
		return default(AvatarItemBodyType);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x79AE300", Offset = "0x79ACB00", VA = "0x1879AE300")]
	public static string KPDGNDHGAHH(this AvatarItemBodyType HECCPBIHNCK)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000B")]
public static class BPAGDKHHELP
{
	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x79AC5C0", Offset = "0x79AADC0", VA = "0x1879AC5C0")]
	public static void JLCAABDGPFP(Transform NKADNMPJAAH, Transform OLAMJNCEDIH, Transform LLKLGKFHFIG, Transform AFPMGODJBDH, float NLAHBHCHGAE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000C")]
public static class HHPKDLEJEOP
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public enum HEPJGONNNBJ
	{
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		Head,
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		TorsoAll,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		TorsoHigh,
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		TorsoLow,
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		DEPRECATED_SleevesShort,
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		DEPRECATED_SleevesLong,
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		DEPRECATED_Palm,
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		DEPRECATED_HandsAll,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		DEPRECATED_PantsLong,
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		Shorts,
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		DEPRECATED_FootMid,
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		DEPRECATED_ShoeLow,
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		DEPRECATED_PantsShort,
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		PalmL,
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		PalmR,
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		HandL,
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		HandR,
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		DEPRECATED_Ears,
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		DEPRECATED_FootHigh,
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		Neck,
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		EarLeft,
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		EarRight,
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		SleevesShortLeft,
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		SleevesShortRight,
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		SleevesLongLeft,
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		SleevesLongRight,
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		PantsLongLeft,
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		PantsLongRight,
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		FootMidLeft,
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		FootMidRight,
		[Cpp2IlInjected.Token(Token = "0x400005A")]
		FootLowLeft,
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		FootLowRight,
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		PantsShortLeft,
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		PantsShortRight,
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		UpperThighLeft,
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		UpperThighRight,
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		FootHighLeft,
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		FootHighRight,
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		FootAnkleLeft,
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		FootAnkleRight,
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		TorsoCrop,
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		FingersOnlyLeft,
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		FingersOnlyRight,
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		ArmpitLeft,
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		ArmpitRight,
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		TorsoTop,
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		Modesty,
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		ShortShorts,
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		SleevesSuperShortLeft,
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		SleevesSuperShortRight,
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		SleevesMidLeft,
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		SleevesMidRight,
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		PantsKneeHighLeft,
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		PantsKneeHighRight,
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		LowerThighLeft,
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		LowerThighRight,
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		HandsThumbOnlyLeft,
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		HandsThumbOnlyRight
	}

	[Cpp2IlInjected.Token(Token = "0x200000E")]
	[Flags]
	public enum OOIFDIEICOH : long
	{
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		Head = 1L,
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		TorsoAll = 2L,
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		TorsoHigh = 4L,
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		TorsoLow = 8L,
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		SleevesShort = 0x10L,
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		SleevesLong = 0x20L,
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		DEPRECATED_Palm = 0x40L,
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		DEPRECATED_HandsAll = 0x80L,
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		PantsLong = 0x100L,
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		Shorts = 0x200L,
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		FootMid = 0x400L,
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		ShoeLow = 0x800L,
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		PantsShort = 0x1000L,
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		PalmL = 0x2000L,
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		PalmR = 0x4000L,
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		HandL = 0x8000L,
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		HandR = 0x10000L,
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		Ears = 0x20000L,
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		FootHigh = 0x40000L,
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		Neck = 0x80000L,
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		EarLeft = 0x100000L,
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		EarRight = 0x200000L,
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		SleevesShortLeft = 0x400000L,
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		SleevesShortRight = 0x800000L,
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		SleevesLongLeft = 0x1000000L,
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		SleevesLongRight = 0x2000000L,
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		PantsLongLeft = 0x4000000L,
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		PantsLongRight = 0x8000000L,
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		FootMidLeft = 0x10000000L,
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		FootMidRight = 0x20000000L,
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		FootLowLeft = 0x40000000L,
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		FootLowRight = 0x80000000L,
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		PantsShortLeft = 0x100000000L,
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		PantsShortRight = 0x200000000L,
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		UpperThighLeft = 0x400000000L,
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		UpperThighRight = 0x800000000L,
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		FootHighLeft = 0x1000000000L,
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		FootHighRight = 0x2000000000L,
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		FootAnkleLeft = 0x4000000000L,
		[Cpp2IlInjected.Token(Token = "0x400009E")]
		FootAnkleRight = 0x8000000000L,
		[Cpp2IlInjected.Token(Token = "0x400009F")]
		TorsoCrop = 0x10000000000L,
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		FingersOnlyLeft = 0x20000000000L,
		[Cpp2IlInjected.Token(Token = "0x40000A1")]
		FingersOnlyRight = 0x40000000000L,
		[Cpp2IlInjected.Token(Token = "0x40000A2")]
		ArmpitLeft = 0x80000000000L,
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		ArmpitRight = 0x100000000000L,
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		TorsoTop = 0x200000000000L,
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		Modesty = 0x400000000000L,
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		ShortShorts = 0x800000000000L,
		[Cpp2IlInjected.Token(Token = "0x40000A7")]
		SleevesSuperShortLeft = 0x1000000000000L,
		[Cpp2IlInjected.Token(Token = "0x40000A8")]
		SleevesSuperShortRight = 0x2000000000000L,
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		SleevesMidLeft = 0x4000000000000L,
		[Cpp2IlInjected.Token(Token = "0x40000AA")]
		SleevesMidRight = 0x8000000000000L,
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		PantsKneeHighLeft = 0x10000000000000L,
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		PantsKneeHighRight = 0x20000000000000L,
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		LowerThighLeft = 0x40000000000000L,
		[Cpp2IlInjected.Token(Token = "0x40000AE")]
		LowerThighRight = 0x80000000000000L,
		[Cpp2IlInjected.Token(Token = "0x40000AF")]
		HandsThumbOnlyLeft = 0x100000000000000L,
		[Cpp2IlInjected.Token(Token = "0x40000B0")]
		HandsThumbOnlyRight = 0x200000000000000L
	}

	[Cpp2IlInjected.Token(Token = "0x4000035")]
	public static readonly IReadOnlyList<HEPJGONNNBJ> DBCKPLMGMAI;

	[Cpp2IlInjected.Token(Token = "0x4000036")]
	public static readonly IReadOnlyList<HEPJGONNNBJ> MHLLFHJGNHA;

	[Cpp2IlInjected.Token(Token = "0x4000037")]
	public static readonly IReadOnlyList<HEPJGONNNBJ> PICOEGHEKKD;

	[Cpp2IlInjected.Token(Token = "0x4000038")]
	public static readonly OOIFDIEICOH GKDCBACLILF;

	[Cpp2IlInjected.Token(Token = "0x4000039")]
	public static readonly OOIFDIEICOH DGLHIKGALIA;

	[Cpp2IlInjected.Token(Token = "0x400003A")]
	public static readonly OOIFDIEICOH MGKCLIFIOFH;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x79ADCF0", Offset = "0x79AC4F0", VA = "0x1879ADCF0")]
	public static OOIFDIEICOH CEBNNLCFKCE(OOIFDIEICOH AIAIKIGCKEJ, OOIFDIEICOH MFMNBLPOLAI)
	{
		return default(OOIFDIEICOH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x79ADD30", Offset = "0x79AC530", VA = "0x1879ADD30")]
	public static OOIFDIEICOH PLMOGNAAJKB(OOIFDIEICOH BGODGPEOPJA, OOIFDIEICOH HNEJJOFBCBL)
	{
		return default(OOIFDIEICOH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x79ADD00", Offset = "0x79AC500", VA = "0x1879ADD00")]
	public static OOIFDIEICOH IFNIHJLFPGE(HEPJGONNNBJ AOPBDHJABPP, OOIFDIEICOH CIOEJKJCJLH)
	{
		return default(OOIFDIEICOH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x79ADD10", Offset = "0x79AC510", VA = "0x1879ADD10")]
	public static OOIFDIEICOH KKJGKAFJILF(HEPJGONNNBJ AOPBDHJABPP, OOIFDIEICOH CIOEJKJCJLH)
	{
		return default(OOIFDIEICOH);
	}
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public class GEKMFAEANGI
{
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public enum GKJOEAALMGF : short
	{
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		None = -1,
		[Cpp2IlInjected.Token(Token = "0x40000B3")]
		Happy = 0,
		[Cpp2IlInjected.Token(Token = "0x40000B4")]
		Love = 1,
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		Laugh = 2,
		[Cpp2IlInjected.Token(Token = "0x40000B6")]
		TongueOut = 3,
		[Cpp2IlInjected.Token(Token = "0x40000B7")]
		Wink = 4,
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		Smirk = 5,
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		SmileSweat = 10,
		[Cpp2IlInjected.Token(Token = "0x40000BA")]
		Grimacing = 11,
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		Shocked = 12,
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		Thinking = 13,
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		Sleeping = 14,
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		Sad = 20,
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		Angry = 21,
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		Nauseated = 22,
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		Flat = 23,
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		Smile = 100
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public class FitMeshHemisphere
	{
		[Cpp2IlInjected.Token(Token = "0x40000C3")]
		public static readonly Vector2 UV_CENTER_COORDINATE;

		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public static readonly Vector3 DEFAULT_HEMISPHERE_FITMESH_PIVOT_POSITION;

		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public static readonly Quaternion DEFAULT_HEMISPHERE_FITMESH_PIVOT_ROTATION;

		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		public static readonly Vector3 DEFAULT_HEMISPHERE_FITMESH_PIVOT_SCALE;

		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		public const float DEFAULT_HEMISPHERE_RADIUS = 0.13f;

		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		public static readonly FitMeshHemisphere Default;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		public Vector3 hemispherePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public Quaternion hemisphereRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public Vector3 hemisphereScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public float radius;

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public bool IsRadiusValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000048")]
			[Cpp2IlInjected.Address(RVA = "0x79ADBE0", Offset = "0x79AC3E0", VA = "0x1879ADBE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x79AD1D0", Offset = "0x79AB9D0", VA = "0x1879AD1D0")]
		public void LPJIGELOOCI(FitMeshHemisphere DNPDILIPBPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x79AD220", Offset = "0x79ABA20", VA = "0x1879AD220")]
		public Vector3 MEJHMLDCJOC(Vector2 BMIOGPDPFFN, bool BGBGFPPIFEG = true)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x79AD120", Offset = "0x79AB920", VA = "0x1879AD120")]
		public Vector3 EBGKEDGAFPM(Vector2 BMIOGPDPFFN)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x79AD870", Offset = "0x79AC070", VA = "0x1879AD870")]
		public Quaternion PCIEAKMABPK(Vector2 BMIOGPDPFFN)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x79AD700", Offset = "0x79ABF00", VA = "0x1879AD700")]
		public Quaternion PCIEAKMABPK(Vector2 BMIOGPDPFFN, Vector3 CGOEAOLPNPN)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x79AD180", Offset = "0x79AB980", VA = "0x1879AD180")]
		public Vector2 EEGMDOGBBDP(Vector2 PODDLGCCEPC)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x79ADB40", Offset = "0x79AC340", VA = "0x1879ADB40")]
		public FitMeshHemisphere()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public enum OutfitType
	{
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		None = -1,
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		Hat = 0,
		[Cpp2IlInjected.Token(Token = "0x40000D0")]
		Hair = 2,
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		Ear = 3,
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		Eye = 10,
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		Beard = 20,
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		Shoulder = 100,
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		Shirt = 101,
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		Waist = 102,
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		Neck = 103,
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		TeamJersey = 104,
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		CustomShirt = 105,
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		Wrist = 200,
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		TeamWrist = 203,
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		Legs = 300,
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		Feet = 301
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class KGPMIOKHIBC
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x79AE560", Offset = "0x79ACD60", VA = "0x1879AE560")]
	public static bool ODMGGCFODLH(this OutfitType IDPHALEDPIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x79AE500", Offset = "0x79ACD00", VA = "0x1879AE500")]
	public static bool GBHLPLIMJMH(this OutfitType IDPHALEDPIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x79AE550", Offset = "0x79ACD50", VA = "0x1879AE550")]
	public static bool KLDPPCMGKMF(this OutfitType IDPHALEDPIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x79AE590", Offset = "0x79ACD90", VA = "0x1879AE590")]
	public static bool OPCCEIPLANJ(this OutfitType IDPHALEDPIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x79AE520", Offset = "0x79ACD20", VA = "0x1879AE520")]
	public static bool JNFCODFEPBA(this OutfitType IDPHALEDPIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x79AE4E0", Offset = "0x79ACCE0", VA = "0x1879AE4E0")]
	public static bool DLFDFOFEJLO(this OutfitType IDPHALEDPIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x79AE530", Offset = "0x79ACD30", VA = "0x1879AE530")]
	public static bool JPHONLELKML(this OutfitType IDPHALEDPIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x79AE540", Offset = "0x79ACD40", VA = "0x1879AE540")]
	public static bool KEINHILCGKL(this OutfitType IDPHALEDPIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x79AE4C0", Offset = "0x79ACCC0", VA = "0x1879AE4C0")]
	public static bool DBEFONEICBN(this OutfitType IDPHALEDPIM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x79AE580", Offset = "0x79ACD80", VA = "0x1879AE580")]
	public static bool OMIGIFIMGJD(this OutfitType IDPHALEDPIM)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class HCBEDDEKPFJ : IEqualityComparer<OutfitType>
{
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	public static readonly HCBEDDEKPFJ DJLOIKDDKCN;

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x79ADBF0", Offset = "0x79AC3F0", VA = "0x1879ADBF0", Slot = "4")]
	public bool Equals(OutfitType IGCNGONAHEN, OutfitType HJKMHJPBPGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x79ADC50", Offset = "0x79AC450", VA = "0x1879ADC50", Slot = "5")]
	public int GetHashCode(OutfitType PIJHKCJDAHO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
	public HCBEDDEKPFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public enum ODFNGAHMFGO
{
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	SkinColor,
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	PrimaryHairColor,
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	SecondaryHairColor,
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	PrimaryBeardColor,
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	SecondaryBeardColor,
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	UGCShirtColor,
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	TeamColor,
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	TeamEmissiveColor
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public enum HJAGPJFAJIO
{
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	HairPattern,
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	BeardPattern
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum NMINLHPKGCA
{
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	TeamItem,
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	SkinColor,
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	HairColor,
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	BeardColor,
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	UGCShirtColor
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public enum CIPOGJIBMCP
{
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	HairTexture,
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	BeardTexture,
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	UGCShirtTexture
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum DHGIOBOEMOO
{
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	CollapseSubMeshes,
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	CollapseToUniqueMaterials,
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	MergeAll
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public enum DPOJOKMIJDG
{
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	Base,
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	Wide,
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	Flat,
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	Downturned,
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	Hooked,
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	Long,
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	Upturned,
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	None
}
namespace RecRoom.Avatars.Data.Shared
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001B")]
	public class AdditionalFeetData : AdditionalOutfitTypeData<AdditionalFeetData>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		public float heelAngle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public float heightOffset;

		[Cpp2IlInjected.Token(Token = "0x600005F")]
		[Cpp2IlInjected.Address(RVA = "0x79AA640", Offset = "0x79A8E40", VA = "0x1879AA640", Slot = "7")]
		public override bool Equals(AdditionalFeetData PGPJMFPAKOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000060")]
		[Cpp2IlInjected.Address(RVA = "0x79AA670", Offset = "0x79A8E70", VA = "0x1879AA670", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000061")]
		[Cpp2IlInjected.Address(RVA = "0x79AA6F0", Offset = "0x79A8EF0", VA = "0x1879AA6F0")]
		public AdditionalFeetData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001C")]
	public class AdditionalHatData : AdditionalOutfitTypeData<AdditionalHatData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public static readonly Vector2 DEFAULT_HAT_UV_OVERRIDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public HelmetHairMode helmetHairMode;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		public bool legacyHidesHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		[ReadOnlyField]
		public bool UseHatUVOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400010B")]
		[ReadOnlyField]
		public Vector2 HatUVOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		[ReadOnlyField]
		public bool AllowFitMeshOverride;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		[ReadOnlyField]
		public Vector3 FitMeshPivotPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		[ReadOnlyField]
		public Quaternion FitMeshPivotRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		[ReadOnlyField]
		public AnchorParamsRestrictions AnchorParamsRestrictions;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Vector2 UVOverride
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x79AAC20", Offset = "0x79A9420", VA = "0x1879AAC20")]
			get
			{
				return default(Vector2);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x79AA730", Offset = "0x79A8F30", VA = "0x1879AA730", Slot = "7")]
		public override bool Equals(AdditionalHatData PGPJMFPAKOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0x79AA920", Offset = "0x79A9120", VA = "0x1879AA920", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x79AAA80", Offset = "0x79A9280", VA = "0x1879AAA80")]
		public AdditionalHatData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001D")]
	public abstract class AdditionalOutfitTypeData : IEquatable<AdditionalOutfitTypeData>
	{
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		protected const float EPSILON = 0.001f;

		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0x79AB0E0", Offset = "0x79A98E0", VA = "0x1879AB0E0")]
		public static bool PFEMKGFDAKN(OutfitType PIJHKCJDAHO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000068")]
		[Cpp2IlInjected.Address(RVA = "0x79AAD30", Offset = "0x79A9530", VA = "0x1879AAD30")]
		public static AdditionalOutfitTypeData NKIHIDGHACP(OutfitType PIJHKCJDAHO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000069")]
		[Cpp2IlInjected.Address(RVA = "0x79AACA0", Offset = "0x79A94A0", VA = "0x1879AACA0", Slot = "0")]
		public override bool Equals(object PNHCNFOFAFI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006A")]
		[Cpp2IlInjected.Address(Slot = "5")]
		public abstract bool Equals(AdditionalOutfitTypeData PGPJMFPAKOO);

		[Cpp2IlInjected.Token(Token = "0x600006B")]
		[Cpp2IlInjected.Address(RVA = "0x9E6790", Offset = "0x9E4F90", VA = "0x1809E6790")]
		protected AdditionalOutfitTypeData()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200001E")]
	public abstract class AdditionalOutfitTypeData<T> : AdditionalOutfitTypeData, IEquatable<T> where T : AdditionalOutfitTypeData<T>
	{
		[Cpp2IlInjected.Token(Token = "0x600006C")]
		[Cpp2IlInjected.Address(RVA = "0x4DA9A30", Offset = "0x4DA8230", VA = "0x184DA9A30", Slot = "5")]
		public override bool Equals(AdditionalOutfitTypeData PGPJMFPAKOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		public abstract bool Equals(T PGPJMFPAKOO);

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0xA08FF0", Offset = "0xA077F0", VA = "0x180A08FF0")]
		protected AdditionalOutfitTypeData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200001F")]
	public class BeardData : AdditionalOutfitTypeData<BeardData>, NGOPMDOPPDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public HairPatternStyle beardHairPatternStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public bool usesHairColor;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public bool UsesHairColor
		{
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x110C0D0", Offset = "0x110A8D0", VA = "0x18110C0D0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public HairPatternStyle PatternStyle
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0x9DD1A0", Offset = "0x9DB9A0", VA = "0x1809DD1A0", Slot = "9")]
			get
			{
				return default(HairPatternStyle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x79ACF10", Offset = "0x79AB710", VA = "0x1879ACF10", Slot = "7")]
		public override bool Equals(BeardData PGPJMFPAKOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x79ACF30", Offset = "0x79AB730", VA = "0x1879ACF30", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x79ACFA0", Offset = "0x79AB7A0", VA = "0x1879ACFA0")]
		public BeardData()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public class HairData : AdditionalOutfitTypeData<HairData>, NGOPMDOPPDL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public float radius;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public Vector3 hemispherePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		public Quaternion hemisphereRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		public Vector3 hemisphereScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		public HairPatternStyle hairPatternStyle;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		public bool usesHairColor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public HelmetHairStyle helmetHairStyle;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public bool UsesHairColor
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0xBFD9F0", Offset = "0xBFC1F0", VA = "0x180BFD9F0", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		public HairPatternStyle PatternStyle
		{
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x9FCF90", Offset = "0x9FB790", VA = "0x1809FCF90", Slot = "9")]
			get
			{
				return default(HairPatternStyle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		public HelmetHairStyle HelmetHairStyle
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0xCF7390", Offset = "0xCF5B90", VA = "0x180CF7390")]
			get
			{
				return default(HelmetHairStyle);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		public FitMeshHemisphere Hemisphere
		{
			[Cpp2IlInjected.Token(Token = "0x6000077")]
			[Cpp2IlInjected.Address(RVA = "0x79AE260", Offset = "0x79ACA60", VA = "0x1879AE260")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x79ADEB0", Offset = "0x79AC6B0", VA = "0x1879ADEB0", Slot = "7")]
		public override bool Equals(HairData PGPJMFPAKOO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x79AE0A0", Offset = "0x79AC8A0", VA = "0x1879AE0A0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x79AE1A0", Offset = "0x79AC9A0", VA = "0x1879AE1A0")]
		public HairData()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface NGOPMDOPPDL
{
	[Cpp2IlInjected.Token(Token = "0x17000033")]
	bool FOLMIKJKAGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	HairPatternStyle LFCGLJKFHOK
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public static class DHECENHDGME
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x79AD0A0", Offset = "0x79AB8A0", VA = "0x1879AD0A0")]
	public static PNLIIGCPIIK IEGODPAKJCC(this OutfitType IDPHALEDPIM, AvatarItemSidednessEquipType BECDJOEDMGF = AvatarItemSidednessEquipType.Left)
	{
		return default(PNLIIGCPIIK);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x79ACFE0", Offset = "0x79AB7E0", VA = "0x1879ACFE0")]
	public static PNLIIGCPIIK FCMCJPJKHHC(this PNLIIGCPIIK MDILONMHHMF)
	{
		return default(PNLIIGCPIIK);
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x79AD030", Offset = "0x79AB830", VA = "0x1879AD030")]
	public static bool FGIPOPCDCOH(this OutfitType IDPHALEDPIM, PNLIIGCPIIK MDILONMHHMF)
	{
		return default(bool);
	}
}
namespace RecRoom.Avatars.Data.Shared
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public enum AvatarItemSidednessEquipType
	{
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		Left,
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		Both,
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		Right
	}
}
[Cpp2IlInjected.Token(Token = "0x2000024")]
public static class OEEOBKCPIEK
{
	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x79AE5D0", Offset = "0x79ACDD0", VA = "0x1879AE5D0")]
	public static bool DEDKDAKFIGN(this AvatarItemSidednessEquipType BECDJOEDMGF, PNLIIGCPIIK MDILONMHHMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x79AE620", Offset = "0x79ACE20", VA = "0x1879AE620")]
	public static bool ONALEADDCNN(this AvatarItemSidednessEquipType FMLINEFKDLA, PNLIIGCPIIK MDILONMHHMF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x79AE600", Offset = "0x79ACE00", VA = "0x1879AE600")]
	public static bool FBGNKLIOFCK(this AvatarItemSidednessEquipType BCCBFIFOEOH, AvatarItemSidednessEquipType MBMCDAABGDC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x79AE650", Offset = "0x79ACE50", VA = "0x1879AE650")]
	public static AvatarItemSidednessEquipType PKJMPHNNAOL(this AvatarItemSidednessEquipType BCCBFIFOEOH)
	{
		return default(AvatarItemSidednessEquipType);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
internal enum MEPHOILMMBH
{
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	None = -1,
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	Hat = 0,
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	Hair = 1,
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	Ear = 2,
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	Eye = 3,
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	Beard = 4,
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	Shoulder = 5,
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	Shirt = 6,
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	Waist = 7,
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	Neck = 8,
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	Wrist = 10
}
namespace RecRoom.Avatars.Data.Shared
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[Flags]
	public enum OutfitSlotFlags
	{
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x400012C")]
		Hat = 1,
		[Cpp2IlInjected.Token(Token = "0x400012D")]
		Hair = 2,
		[Cpp2IlInjected.Token(Token = "0x400012E")]
		Ear = 4,
		[Cpp2IlInjected.Token(Token = "0x400012F")]
		Eye = 8,
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		Beard = 0x10,
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		Shoulder = 0x20,
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		Shirt = 0x40,
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		Waist = 0x80,
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		Neck = 0x100,
		[Cpp2IlInjected.Token(Token = "0x4000135")]
		Wrist = 0x400,
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		All = int.MaxValue
	}
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public static class BIGMLJNCFGO
{
	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x79AC0F0", Offset = "0x79AA8F0", VA = "0x1879AC0F0")]
	private static MEPHOILMMBH CFHCMNOFCAI(this OutfitType IDPHALEDPIM)
	{
		return default(MEPHOILMMBH);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x79AC450", Offset = "0x79AAC50", VA = "0x1879AC450")]
	public static OutfitSlotFlags OFECHICMBKA(this OutfitType IDPHALEDPIM)
	{
		return default(OutfitSlotFlags);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x79AC0E0", Offset = "0x79AA8E0", VA = "0x1879AC0E0")]
	public static bool BMAGNOLOGEN(this OutfitSlotFlags JCILDDEFCHM, OutfitSlotFlags KNDOANFJJMD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x79AC260", Offset = "0x79AAA60", VA = "0x1879AC260")]
	public static bool GDBPMKDDCDG(this OutfitType IDPHALEDPIM, OutfitSlotFlags ANOBACMEMCM)
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
