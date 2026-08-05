using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using Mono.Math;
using RecRoom;
using RecRoom.Avatars;
using RecRoom.Avatars.Face;
using RootMotion.FinalIK;
using UnityEngine;
using UnityEngine.AddressableAssets;
using UnityEngine.Rendering.Universal;
using UnityEngine.Scripting;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public class AvatarSelectionElement : ScriptableObject
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	public string Guid;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x681A420", Offset = "0x6818E20", VA = "0x18681A420")]
	public AvatarSelectionElement()
	{
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public struct AnchorParams : IEquatable<AnchorParams>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public Vector2 NormalizedPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public Vector3 HemisphereOffsets;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public Vector3 HemisphereRotations;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public static AnchorParams Default
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x6819E30", Offset = "0x6818830", VA = "0x186819E30")]
			get
			{
				return default(AnchorParams);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6819C90", Offset = "0x6818690", VA = "0x186819C90")]
		public AnchorParams(Vector2 MNHJLFPFPGB, Vector3 NNMPPKGNAHD, Vector3 IIECLDLBFFM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6819CC0", Offset = "0x68186C0", VA = "0x186819CC0")]
		public AnchorParams(NHJIOEFLIDM ODAEHEIJPOI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6819BA0", Offset = "0x68185A0", VA = "0x186819BA0", Slot = "4")]
		public bool Equals(AnchorParams EHBPAFKHADK)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface NHJIOEFLIDM
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool CCKJIGGGIKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool FNGECEFEHOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool AOGJMGPLGHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool DOINHMEABGA
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool PNKNEKGJCPI
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool CMODHNEIIGF
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool EHJPLLLNNPK
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool ILFIKJAGIMC
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	float PLGCDDFAOMI
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	float OGAGJJIFLIJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	float GDCDFNBEMJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	float KLPCPGJOCII
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	float JFBNCFGKBCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	float ABMIKMJPMCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	float CJBFLBDHEAN
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	float KPJDHGAPOBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	float PIJJFNGKGAI
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	float IMOGFHFDJGB
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	float BMBAHFMEADE
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	float EJLCPALHKBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	float IEBECALKLJK
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	float LDEPJOBGKMK
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	float FJPMELIBMOE
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	float IDHHBJKKIKN
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "24")]
	Vector3 GIGMBCIACOA(Vector3 IIECLDLBFFM);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 BACKDKOBDCN(Vector3 MAMEHMMPIAD);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Vector3 KKPLDGPBFHD();

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "27")]
	Vector3 MKGDPNBKHMP();
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class AnchorParamsRestrictions : NHJIOEFLIDM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public bool AllowTranslation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public bool AllowRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public float DefaultOffsetX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		public float MinXOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		public float MaxXOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		public float DefaultOffsetY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		public float MinYOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		public float MaxYOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		public float DefaultOffsetZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		public float MinZOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		public float MaxZOffset;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		public float DefaultRotationX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		public float RightRotationFreedomX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public float LeftRotationFreedomX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		public float DefaultRotationY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		public float RightRotationFreedomY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public float LeftRotationFreedomY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public float DefaultRotationZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public float RightRotationFreedomZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public float LeftRotationFreedomZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public float MaxUCoordinate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public float MinUCoordinate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public float MaxVCoordinate;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public float MinVCoordinate;

		[Cpp2IlInjected.Token(Token = "0x1700001A")]
		public bool GetAllowTranslationX
		{
			[Cpp2IlInjected.Token(Token = "0x6000022")]
			[Cpp2IlInjected.Address(RVA = "0x6819B10", Offset = "0x6818510", VA = "0x186819B10", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool GetAllowTranslationY
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x6819B40", Offset = "0x6818540", VA = "0x186819B40", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool GetAllowTranslationZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6819B70", Offset = "0x6818570", VA = "0x186819B70", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public bool GetAllowRotationX
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6819A80", Offset = "0x6818480", VA = "0x186819A80", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool GetAllowRotationY
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6819AB0", Offset = "0x68184B0", VA = "0x186819AB0", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool GetAllowRotationZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6819AE0", Offset = "0x68184E0", VA = "0x186819AE0", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool GetAllowTranslations
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x7E6A20", Offset = "0x7E5420", VA = "0x1807E6A20", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool GetAllowRotations
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x85E260", Offset = "0x85CC60", VA = "0x18085E260", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xAEC0F0", Offset = "0xAEAAF0", VA = "0x180AEC0F0", Slot = "12")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x856FB0", Offset = "0x8559B0", VA = "0x180856FB0", Slot = "13")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x7E44F0", Offset = "0x7E2EF0", VA = "0x1807E44F0", Slot = "14")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0xBDD1B0", Offset = "0xBDBBB0", VA = "0x180BDD1B0", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x7E5900", Offset = "0x7E4300", VA = "0x1807E5900", Slot = "16")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0xBDCE60", Offset = "0xBDB860", VA = "0x180BDCE60", Slot = "17")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x8C3880", Offset = "0x8C2280", VA = "0x1808C3880", Slot = "20")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x899960", Offset = "0x898360", VA = "0x180899960", Slot = "21")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x9D1A30", Offset = "0x9D0430", VA = "0x1809D1A30", Slot = "18")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x9D1A20", Offset = "0x9D0420", VA = "0x1809D1A20", Slot = "19")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x9D1AE0", Offset = "0x9D04E0", VA = "0x1809D1AE0", Slot = "22")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x9D1A70", Offset = "0x9D0470", VA = "0x1809D1A70", Slot = "23")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public float GetMaxUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0xD536F0", Offset = "0xD520F0", VA = "0x180D536F0", Slot = "24")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public float GetMinUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0xD53700", Offset = "0xD52100", VA = "0x180D53700", Slot = "25")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0xDEECC0", Offset = "0xDED6C0", VA = "0x180DEECC0", Slot = "26")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x140E2E0", Offset = "0x140CCE0", VA = "0x18140E2E0", Slot = "27")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x68199F0", Offset = "0x68183F0", VA = "0x1868199F0")]
		public AnchorParamsRestrictions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x6819770", Offset = "0x6818170", VA = "0x186819770")]
		public AnchorParams HAHDNHNGNDB(AnchorParams HFDODCAGMBO)
		{
			return default(AnchorParams);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x68199B0", Offset = "0x68183B0", VA = "0x1868199B0", Slot = "30")]
		public Vector3 KKPLDGPBFHD()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x68199D0", Offset = "0x68183D0", VA = "0x1868199D0", Slot = "31")]
		public Vector3 MKGDPNBKHMP()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x68196E0", Offset = "0x68180E0", VA = "0x1868196E0", Slot = "28")]
		public Vector3 GIGMBCIACOA(Vector3 IIECLDLBFFM)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6819640", Offset = "0x6818040", VA = "0x186819640", Slot = "29")]
		public Vector3 BACKDKOBDCN(Vector3 MAMEHMMPIAD)
		{
			return default(Vector3);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class LFEGOINFIMD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private List<Transform> JHKPCAMFDNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private Matrix4x4[] GMNDDKONEOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private Dictionary<string, Transform> AHGFLDNHIPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private Dictionary<Transform, Transform> JEKLOPPJCEE;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public Transform[] OECFKENNKLH
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x681FF20", Offset = "0x681E920", VA = "0x18681FF20")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Matrix4x4[] JOLFAPNIKDC
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x681FF70", Offset = "0x681E970", VA = "0x18681FF70")]
	public void MFGPLKLPAEM(SkinnedMeshRenderer HPJIHIPEFOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6820200", Offset = "0x681EC00", VA = "0x186820200")]
	public void OHHPKAHGBDI(Transform BEEJFBOPEOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6820120", Offset = "0x681EB20", VA = "0x186820120")]
	private Transform NFHAGCEOPBH(Transform NDEGAJJFOBM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x681FCA0", Offset = "0x681E6A0", VA = "0x18681FCA0")]
	public void FNOJINHDGII(LFEGOINFIMD JCKJPNKLMNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x681FB30", Offset = "0x681E530", VA = "0x18681FB30")]
	private void DBGBIHOKCIN(Transform MNGLAEJHIMG, List<Transform> MMHGGBDPJHE, Dictionary<string, Transform> ICHOHHLDJBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6820270", Offset = "0x681EC70", VA = "0x186820270")]
	public LFEGOINFIMD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class EFHPNAHLPNI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public bool CEAGLPPLGKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public bool LADEPLJNIJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public bool KFCGPLIOGHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public bool FALFEDONPDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public bool GMHGHPAMABM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public bool PPLKDHLBBMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x16")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public bool HKBFJJJDGHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public IList<CBDACJNDNMD> APEAPGDHEBO;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public EFHPNAHLPNI()
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class AvatarConfiguration : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x961520", Offset = "0x95FF20", VA = "0x180961520")]
		protected AvatarConfiguration()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class AvatarCustomizationSettings
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public enum FJHHDGPCDML
		{
			[Cpp2IlInjected.Token(Token = "0x4000042")]
			Legacy_Hide,
			[Cpp2IlInjected.Token(Token = "0x4000043")]
			On,
			[Cpp2IlInjected.Token(Token = "0x4000044")]
			Off
		}

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private const int SERIALIZATION_VERSION = 7;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[SerializeField]
		public int ver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[SerializeField]
		private string eyeBrowsId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[SerializeField]
		private Vector2 eyeBrowsPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[SerializeField]
		private float eyeBrowsScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[SerializeField]
		private string eyeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[SerializeField]
		private Vector2 eyePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		[SerializeField]
		private float eyeScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[SerializeField]
		private string mouthId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[SerializeField]
		private Vector2 mouthPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[SerializeField]
		private float mouthScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[SerializeField]
		private string hairPrimaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[SerializeField]
		private string hairSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[SerializeField]
		private string hairPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[SerializeField]
		private string beardColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[SerializeField]
		private string beardSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		private string beardPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private string faceShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[SerializeField]
		private string bodyShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private bool useHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA4")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		[SerializeField]
		private FJHHDGPCDML useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		[SerializeField]
		private bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0xAC")]
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		[SerializeField]
		private AnchorParams hatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		[SerializeField]
		private string baseAvatarType;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public string EyeBrowsGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x7D2590", Offset = "0x7D0F90", VA = "0x1807D2590")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public Vector2 EyeBrowsPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0x13A22C0", Offset = "0x13A0CC0", VA = "0x1813A22C0")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x84CCE0", Offset = "0x84B6E0", VA = "0x18084CCE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public float EyeBrowsScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0xBDD1B0", Offset = "0xBDBBB0", VA = "0x180BDD1B0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0xBDD6B0", Offset = "0xBDC0B0", VA = "0x180BDD6B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public string EyeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x738BA0", Offset = "0x7375A0", VA = "0x180738BA0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x7D4370", Offset = "0x7D2D70", VA = "0x1807D4370")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public Vector2 EyePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0xBDD220", Offset = "0xBDBC20", VA = "0x180BDD220")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x84CD20", Offset = "0x84B720", VA = "0x18084CD20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public float EyeScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x9D1A20", Offset = "0x9D0420", VA = "0x1809D1A20")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0x16EC580", Offset = "0x16EAF80", VA = "0x1816EC580")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public string MouthGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x73B590", Offset = "0x739F90", VA = "0x18073B590")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x7D7090", Offset = "0x7D5A90", VA = "0x1807D7090")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public Vector2 MouthPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x5E54210", Offset = "0x5E52C10", VA = "0x185E54210")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0xABC770", Offset = "0xABB170", VA = "0x180ABC770")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public float MouthScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x9D1A70", Offset = "0x9D0470", VA = "0x1809D1A70")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x9DF3C0", Offset = "0x9DDDC0", VA = "0x1809DF3C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public string HairPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x7D7060", Offset = "0x7D5A60", VA = "0x1807D7060")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x7D7050", Offset = "0x7D5A50", VA = "0x1807D7050")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public string HairSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x7D7940", Offset = "0x7D6340", VA = "0x1807D7940")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x7D7A20", Offset = "0x7D6420", VA = "0x1807D7A20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public string HairPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x7D7B40", Offset = "0x7D6540", VA = "0x1807D7B40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x7D7A10", Offset = "0x7D6410", VA = "0x1807D7A10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public string BeardPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x7D67B0", Offset = "0x7D51B0", VA = "0x1807D67B0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x7D7B50", Offset = "0x7D6550", VA = "0x1807D7B50")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public string BeardSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x7D5680", Offset = "0x7D4080", VA = "0x1807D5680")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x7DAC10", Offset = "0x7D9610", VA = "0x1807DAC10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public string BeardPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0x7D7A30", Offset = "0x7D6430", VA = "0x1807D7A30")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0x7D6720", Offset = "0x7D5120", VA = "0x1807D6720")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public string FaceShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x7D5630", Offset = "0x7D4030", VA = "0x1807D5630")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x7DABF0", Offset = "0x7D95F0", VA = "0x1807DABF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public string BodyShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0x7D6740", Offset = "0x7D5140", VA = "0x1807D6740")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0x7D7B70", Offset = "0x7D6570", VA = "0x1807D7B70")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public bool UseHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0xDFDD00", Offset = "0xDFC700", VA = "0x180DFDD00")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x1566C60", Offset = "0x1565660", VA = "0x181566C60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public FJHHDGPCDML UseHelmetHair
		{
			[Cpp2IlInjected.Token(Token = "0x600006E")]
			[Cpp2IlInjected.Address(RVA = "0x681A2D0", Offset = "0x6818CD0", VA = "0x18681A2D0")]
			get
			{
				return default(FJHHDGPCDML);
			}
			[Cpp2IlInjected.Token(Token = "0x600006F")]
			[Cpp2IlInjected.Address(RVA = "0x13029B0", Offset = "0x13013B0", VA = "0x1813029B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public bool HideEars
		{
			[Cpp2IlInjected.Token(Token = "0x6000070")]
			[Cpp2IlInjected.Address(RVA = "0xA02970", Offset = "0xA01370", VA = "0x180A02970")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000071")]
			[Cpp2IlInjected.Address(RVA = "0x9ECC30", Offset = "0x9EB630", VA = "0x1809ECC30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public AnchorParams HatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x6000072")]
			[Cpp2IlInjected.Address(RVA = "0x681A2B0", Offset = "0x6818CB0", VA = "0x18681A2B0")]
			get
			{
				return default(AnchorParams);
			}
			[Cpp2IlInjected.Token(Token = "0x6000073")]
			[Cpp2IlInjected.Address(RVA = "0x681A3A0", Offset = "0x6818DA0", VA = "0x18681A3A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public string BaseAvatarType
		{
			[Cpp2IlInjected.Token(Token = "0x6000074")]
			[Cpp2IlInjected.Address(RVA = "0x7D6FF0", Offset = "0x7D59F0", VA = "0x1807D6FF0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000075")]
			[Cpp2IlInjected.Address(RVA = "0x7D7880", Offset = "0x7D6280", VA = "0x1807D7880")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public bool UsesFullBodyAvatar
		{
			[Cpp2IlInjected.Token(Token = "0x6000076")]
			[Cpp2IlInjected.Address(RVA = "0x681A300", Offset = "0x6818D00", VA = "0x18681A300")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0xB1C750", Offset = "0xB1B150", VA = "0x180B1C750")]
		public string HGLHKADDNFF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x6819EA0", Offset = "0x68188A0", VA = "0x186819EA0")]
		public static AvatarCustomizationSettings AIBDMMJCKEC(string KOEBIOOCLIC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000079")]
		[Cpp2IlInjected.Address(RVA = "0x681A040", Offset = "0x6818A40", VA = "0x18681A040")]
		public AvatarCustomizationSettings()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct BodySkinnedMeshLODs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public SkinnedMeshRenderer[] LODs;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct SkeletonLODUpdateRate
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public IJJPEDCHMLC lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public float updateRate;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct AvatarHairPatternOverride
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public string PatternGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public Texture2D Texture;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct LHNAKNKCLEM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public Transform KKIJPHIOIPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public GameObject FGOLCCJFAPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public SkinnedMeshRenderer[] PHAKNCEKEPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public SkinnedMeshRenderer[] FFFKANANLKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public GameObject GNKGGIPCPGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public SkinnedMeshRenderer[] CKKCJNGLDDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public SkinnedMeshRenderer[] JFDFKIOLKPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public LFEGOINFIMD GKILDKHCFIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public Material JBLPFMCPLCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public Material NMFLOJFPPGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public Shader JMJPJHKICNI;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct BCJGOCMBHLL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public Transform LELFBFNAEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public Transform OFDHGAOONBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public Transform LLEPILADFFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public Transform LHKLMHGEIOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public Transform FPMPFEEFILC;
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct OCOAGFMPJLJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public SkinnedMeshRenderer[] AJEBPBACGLM;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct HJJJIHCNPMF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public DBLANHINENO LPFILNNADIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public int KBBFMEFEHHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public int GIPHDNGAPMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public Color OEFLAHNGMDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public Color IPOMOGEFBGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public int GNCAICICHNG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public int KOPNIEGHMKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public Color AOHPLENCIJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public Color CHFCGPLHLMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public int JFIKNOJMFOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public float BMPPCMDKCGA;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct BAEMDAGIOOF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public DBLANHINENO LPFILNNADIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public Vector2 AGFJAFOEANI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public float JBBMIDLOMEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public Vector2 HPMFGAHDFKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public float JDKGNEFFHBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public Vector2 GDBLNOADHKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public float HPHFAPONBDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public float GCBMAGAFMFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Vector2 BJHOEKJPODF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public Vector2 HBPDGCDBPOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public bool IPLAEPEPOAM;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class CBDACJNDNMD
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public string KPDCCEJPHFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public OutfitType DNMPAOHKCEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public FIKFKMFJKMH AABPIMFMJOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public bool NMCJIIIGLFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public Color? ACIPLBCDJHB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public Vector3? BDBOBJALBMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public float? LEIOLOPABKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public Guid? PBEEFBKGAOE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public Color? MKMNMLFNLEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	public bool CLCAEMIIALH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public bool FMEKIBFGHGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	public AnchorParamsRestrictions GOJOJGKMBFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	public Vector2? DLNGAOPDFPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public Transform KAKKJIACDAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public FitMeshHemisphere GOMCKPCKHIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public Vector2 MIFKDAELECI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	private List<AvatarHairPatternOverride> ODLNLCHEONK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	private Dictionary<string, Texture2D> GLJGNKGBPEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x4000083")]
	private List<AvatarHairPatternOverride> OMBNDIJFAMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x4000084")]
	private Dictionary<string, Texture2D> DHJPPEDICCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x4000085")]
	public AssetReference NNAHOGFOHAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x4000086")]
	public AssetReference JGACMAFAHIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000087")]
	public AssetReference[] DPJGEAEDGGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000088")]
	public bool KHLJBBNEDOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE9")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public bool BPBJDCNGBHM;

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public List<AvatarHairPatternOverride> DHKKLDGPGDO
	{
		[Cpp2IlInjected.Token(Token = "0x600007A")]
		[Cpp2IlInjected.Address(RVA = "0x7D6730", Offset = "0x7D5130", VA = "0x1807D6730")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600007B")]
		[Cpp2IlInjected.Address(RVA = "0x681A8D0", Offset = "0x68192D0", VA = "0x18681A8D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public List<AvatarHairPatternOverride> KDKEMKBLDMP
	{
		[Cpp2IlInjected.Token(Token = "0x600007C")]
		[Cpp2IlInjected.Address(RVA = "0x895EB0", Offset = "0x8948B0", VA = "0x180895EB0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x681A5F0", Offset = "0x6818FF0", VA = "0x18681A5F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public string COOHGDNPNML
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x681A820", Offset = "0x6819220", VA = "0x18681A820")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x681AB00", Offset = "0x6819500", VA = "0x18681AB00")]
	public CBDACJNDNMD()
	{
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public class AvatarItemMaterial : AvatarSelectionElement
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		[SerializeField]
		private Material material;

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		public Material Material
		{
			[Cpp2IlInjected.Token(Token = "0x6000086")]
			[Cpp2IlInjected.Address(RVA = "0x7AF6F0", Offset = "0x7AE0F0", VA = "0x1807AF6F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000087")]
		[Cpp2IlInjected.Address(RVA = "0x681A3C0", Offset = "0x6818DC0", VA = "0x18681A3C0")]
		public static void CHDPLBAKFFK(AvatarItemMaterial NODINBNHDOC, Material NCNMCMAJCOL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000088")]
		[Cpp2IlInjected.Address(RVA = "0x681A420", Offset = "0x6818E20", VA = "0x18681A420")]
		public AvatarItemMaterial()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class OPIGOKHFALI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	public readonly Mesh FEPGBBFNBEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public readonly Material[] JGICOBDIDAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	public readonly bool NLCLIKNMPAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	private bool EHOFNNCGKFI;

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	private OPIGOKHFALI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6820D20", Offset = "0x681F720", VA = "0x186820D20")]
	public OPIGOKHFALI(Mesh OLBANABBMBP, Material[] DHBOPPNCLLF, bool JFJJECHJKGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6820E30", Offset = "0x681F830", VA = "0x186820E30")]
	public OPIGOKHFALI(SkinnedMeshRenderer BODHJODBCBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x68209B0", Offset = "0x681F3B0", VA = "0x1868209B0")]
	public static OPIGOKHFALI HHBLELFFFEM(Renderer HPJIHIPEFOA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum NJEJINANHJD
{
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	None,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	Highfive,
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	Fistbump,
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	Handshake,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	Point,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	ThumbsUp,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	ThumbsDown,
	[Cpp2IlInjected.Token(Token = "0x400009C")]
	ClosedFist,
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	OpenHand
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public enum PAFFAINBCGO
{
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	DoNotHideHair,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	UseHelmetHair,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	AlwaysHideHair,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	HideHairToggleable
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum FIKFKMFJKMH
{
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	None = -1,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	Head,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	Torso,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	LeftHand,
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	RightHand,
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	Mouth,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	Legs,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	LeftFoot,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	RightFoot,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	FullBody,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	Nose
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[Flags]
public enum BLBIFOHDMHN
{
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	Head = 1,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	Torso = 2,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	LeftHand = 4,
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	RightHand = 8,
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	Mouth = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	Legs = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	RightFoot = 0x80,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	LeftFoot = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	FullBody = 0x100,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	Nose = 0x200
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum CJIKHOKEAPO
{
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	SkinColor,
	[Cpp2IlInjected.Token(Token = "0x40000BD")]
	PrimaryHairColor,
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	SecondaryHairColor,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	PrimaryBeardColor,
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	SecondaryBeardColor,
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	UGCShirtColor,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	TeamColor,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	TeamEmissiveColor
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public enum PGEOGAFMAHO
{
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	HairPattern,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	BeardPattern
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum CNKJBAAPBPD
{
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	TeamItem,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	SkinColor,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	HairColor,
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	BeardColor,
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	UGCShirtColor
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum IHHBMCCDOJI
{
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	HairTexture,
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	BeardTexture,
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	UGCShirtTexture
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum IOIBCOKBIOJ
{
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	CollapseSubMeshes,
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	CollapseToUniqueMaterials,
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	MergeAll
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class GHCLFNMFEIF
{
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	public static readonly int PIHPAFIGFKI;

	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	public static readonly string GJBCICONLNF;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	public static readonly string KIFDHKCBBDG;

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x681DF80", Offset = "0x681C980", VA = "0x18681DF80")]
	public static IAHBKCHGCJO GJNHBCGCLIJ()
	{
		return default(IAHBKCHGCJO);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x681DD60", Offset = "0x681C760", VA = "0x18681DD60")]
	public static LNBIDDNLDDI CLLGFFANNOG(Transform EOBMBNKEPGB, Transform PGAJNKMKBEL, AvatarConfiguration JNFNLFBKKOF, Animator LGDCGJFNMAP, VRIK KLGJGBCJCBK, SkeletonLODUpdateRate[] EBNAEHPPDDD, GameObject[] CGFKCIACGKI, Transform HLKBAKIMIMN, GameObject MDEKNHKMOEG, BodySkinnedMeshLODs COJPHCKAKGD, BodySkinnedMeshLODs LFJAMFPGENB, GameObject FLCFNMNBOIG, BodySkinnedMeshLODs IFLPOJMPMAC, BodySkinnedMeshLODs KFFGAOEJKCI, LFEGOINFIMD EGKLMLMABPO, Material MCEONNCKCKE, Material GPHKBCPINKH, Shader FKIMIOPGPFG, Transform EFPCNMCJFNN, Transform NJDPICPLACJ, Transform LAGMJIJDGJL, Transform NGCNJAGEFDK, Transform OLHIFMFDMME)
	{
		return default(LNBIDDNLDDI);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x681E0B0", Offset = "0x681CAB0", VA = "0x18681E0B0")]
	public static OIFCFNEJMKO IGJKHFACNLO(string NPDMDBMNHAO, bool CAGJKIFNHAD, bool HOOEHILJGLB, bool PDEPHJHHFGB, RigidbodyEx PDHIMIEJLPJ, RigidbodyEx KEOGDNDFMFF, RigidbodyEx JPBEENBOBMI, RigidbodyEx PFOLFPKLADH, Transform BLGPIKKCLOO, Transform AIPPCFJBIPA, Transform NAOLODCMHHO, float PMNFCPECDAN, float BKGFGMPJIFK, PlayerAvatarFullBodyColliders PHFDCMBOGOH)
	{
		return default(OIFCFNEJMKO);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x681DFB0", Offset = "0x681C9B0", VA = "0x18681DFB0")]
	public static LHNAKNKCLEM IFIBHJFJKJD(Transform PGAJNKMKBEL, GameObject MDEKNHKMOEG, SkinnedMeshRenderer[] BJCLHIHCLCG, SkinnedMeshRenderer[] COIDNACCJOD, GameObject FLCFNMNBOIG, SkinnedMeshRenderer[] CEEKMHMINOH, SkinnedMeshRenderer[] PGOPMAHLCME, LFEGOINFIMD EGKLMLMABPO, Material MCEONNCKCKE, Material GPHKBCPINKH, Shader FKIMIOPGPFG)
	{
		return default(LHNAKNKCLEM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x681E280", Offset = "0x681CC80", VA = "0x18681E280")]
	public static BCJGOCMBHLL PAEAEGNKIHJ(Transform EFPCNMCJFNN, Transform LAGMJIJDGJL, Transform NJDPICPLACJ, Transform NGCNJAGEFDK, Transform OLHIFMFDMME)
	{
		return default(BCJGOCMBHLL);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x8BD3E0", Offset = "0x8BBDE0", VA = "0x1808BD3E0")]
	public static OCOAGFMPJLJ EKOONMAHIMO(SkinnedMeshRenderer[] MJLECEHLGCM)
	{
		return default(OCOAGFMPJLJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x681DCB0", Offset = "0x681C6B0", VA = "0x18681DCB0")]
	public static HJJJIHCNPMF BDAOLKCIGKP(DBLANHINENO BNFDPNKMKPG, int HEFEIOKMOAC, int JCMOGFAELNI, Color HEDKKNELJOH, Color IHPIACMKCOE, int IFGIOECBKKC, int DFOPHBGJCEN, Color CKJJCLAELDM, Color EHIMECFJKPF, int NLOCPIIKKFB, float GFENEPNGIJE)
	{
		return default(HJJJIHCNPMF);
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x681E1C0", Offset = "0x681CBC0", VA = "0x18681E1C0")]
	public static BAEMDAGIOOF MNCBPEPEOML(DBLANHINENO BNFDPNKMKPG, Vector2 HCAAKCBFDIN, float NIEGAKLGCPC, Vector2 CEFLAACEIMI, float KPLAENMHBKG, Vector2 NADHGKMMOOK, float LIBAFPKLFJC, float NHCEFGNMKAD, Vector2 LDNNKHNDCBI, Vector2 CFBFGOODCHA)
	{
		return default(BAEMDAGIOOF);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface KNELFIEFKHD
{
	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	Transform CCKPELKPNKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	Vector3 NPFGDEFCDFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class GDIPMFKHCFJ : KNELFIEFKHD
{
	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public Transform CCKPELKPNKA
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x75C3F0", Offset = "0x75ADF0", VA = "0x18075C3F0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x7D2880", Offset = "0x7D1280", VA = "0x1807D2880")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public Vector3 NPFGDEFCDFH
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0xEB9320", Offset = "0xEB7D20", VA = "0x180EB9320", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0xEB9350", Offset = "0xEB7D50", VA = "0x180EB9350")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public float? CDAODADENJJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0xC782B0", Offset = "0xC76CB0", VA = "0x180C782B0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0xC782F0", Offset = "0xC76CF0", VA = "0x180C782F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public GDIPMFKHCFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class HILBEMBFBGF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	protected readonly GDIPMFKHCFJ APMEBEEKCDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	protected readonly GDIPMFKHCFJ MOPCJFKGFEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	protected readonly GDIPMFKHCFJ OOKJMFKIGEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	protected readonly GDIPMFKHCFJ LAIOMFBPOFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	protected readonly GDIPMFKHCFJ MBDGGKGNPNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	protected readonly GDIPMFKHCFJ LAJKHOPPLJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	protected readonly GDIPMFKHCFJ BGBAJLMIDHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	protected readonly GDIPMFKHCFJ PCLEIJECICE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	protected readonly GDIPMFKHCFJ KGJBFPADFMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	protected readonly GDIPMFKHCFJ OGOBGFBMDJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	protected readonly GDIPMFKHCFJ CJBGEBECGML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	protected readonly GDIPMFKHCFJ PKOLKBMHKIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	protected readonly GDIPMFKHCFJ BMBMCPJGGJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	protected GDIPMFKHCFJ ALKJDCDEIKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	protected readonly GDIPMFKHCFJ DACDLPHJFOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	protected readonly GDIPMFKHCFJ OAFNABFPBJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	protected readonly GDIPMFKHCFJ CMOOFPPOCHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	protected GDIPMFKHCFJ NNKGGIMMFNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	protected readonly GDIPMFKHCFJ PBGPINJCFJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	protected readonly GDIPMFKHCFJ HNGNFNOMOGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	protected readonly GDIPMFKHCFJ JNCNLGHENGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	protected ReadOnlyCollection<GDIPMFKHCFJ> BLALACBJECI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public Transform HLKBAKIMIMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private (GDIPMFKHCFJ Start, GDIPMFKHCFJ End)[] KJAFOELCNKJ;

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public KNELFIEFKHD BEAOHKEGFGB
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x75C3F0", Offset = "0x75ADF0", VA = "0x18075C3F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public KNELFIEFKHD CJBIJAPLNED
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public KNELFIEFKHD BEBEAGNEKGM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7AF6F0", Offset = "0x7AE0F0", VA = "0x1807AF6F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public KNELFIEFKHD EJOAIHNPAAC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x737430", Offset = "0x735E30", VA = "0x180737430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public KNELFIEFKHD GEDEMPIEFDL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x738BA0", Offset = "0x7375A0", VA = "0x180738BA0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public KNELFIEFKHD NHNLDPAHMCG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7374F0", Offset = "0x735EF0", VA = "0x1807374F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public KNELFIEFKHD GACAIBIDJGD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x73EEB0", Offset = "0x73D8B0", VA = "0x18073EEB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public GDIPMFKHCFJ LCECOKINECO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x73EEB0", Offset = "0x73D8B0", VA = "0x18073EEB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public KNELFIEFKHD NJOCGLJMNBO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x73B590", Offset = "0x739F90", VA = "0x18073B590")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public GDIPMFKHCFJ OLKAPABIGDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x73B590", Offset = "0x739F90", VA = "0x18073B590")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public KNELFIEFKHD LIKPGJOLJHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x7516F0", Offset = "0x7500F0", VA = "0x1807516F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public KNELFIEFKHD CBFJBJHJIOH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x741FC0", Offset = "0x7409C0", VA = "0x180741FC0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public KNELFIEFKHD MACEJLCCGHP
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7D7060", Offset = "0x7D5A60", VA = "0x1807D7060")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public GDIPMFKHCFJ DJINJCMKFED
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7D7060", Offset = "0x7D5A60", VA = "0x1807D7060")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public GDIPMFKHCFJ CANEIAEPKEK
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x7D7940", Offset = "0x7D6340", VA = "0x1807D7940")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public KNELFIEFKHD HNDDKJLDLBI
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x7D7940", Offset = "0x7D6340", VA = "0x1807D7940")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public KNELFIEFKHD LHCIDEMCBDH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7D7B40", Offset = "0x7D6540", VA = "0x1807D7B40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public KNELFIEFKHD MAIJFAEPACO
	{
		[Cpp2IlInjected.Token(Token = "0x60000B0")]
		[Cpp2IlInjected.Address(RVA = "0x7D67B0", Offset = "0x7D51B0", VA = "0x1807D67B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public KNELFIEFKHD PFLGKMNKFHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000B1")]
		[Cpp2IlInjected.Address(RVA = "0x7D5680", Offset = "0x7D4080", VA = "0x1807D5680")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public KNELFIEFKHD FMKBBJKNDPF
	{
		[Cpp2IlInjected.Token(Token = "0x60000B2")]
		[Cpp2IlInjected.Address(RVA = "0x7D7A30", Offset = "0x7D6430", VA = "0x1807D7A30")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public KNELFIEFKHD FFEGKKIAOPJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x7D5630", Offset = "0x7D4030", VA = "0x1807D5630")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public KNELFIEFKHD FELLIBCBDJB
	{
		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x7D6740", Offset = "0x7D5140", VA = "0x1807D6740")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public KNELFIEFKHD BJNHAMDOPHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x7D70B0", Offset = "0x7D5AB0", VA = "0x1807D70B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006B")]
	public KNELFIEFKHD OJFKCPJJIJC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x7D6780", Offset = "0x7D5180", VA = "0x1807D6780")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006C")]
	public KNELFIEFKHD ICNHAFMBEHC
	{
		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x7D6730", Offset = "0x7D5130", VA = "0x1807D6730")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006D")]
	public IReadOnlyList<KNELFIEFKHD> GKCIINACGIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x7DAB80", Offset = "0x7D9580", VA = "0x1807DAB80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x681E9B0", Offset = "0x681D3B0", VA = "0x18681E9B0")]
	public void IDMJGMBJIFH(VRIK KGMBABKANKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x2FADA40", Offset = "0x2FAC440", VA = "0x182FADA40")]
	private void EGPIBDHGEMH(Transform BMKGEKNDEIG, GDIPMFKHCFJ BJCKADBMKDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x681E3B0", Offset = "0x681CDB0", VA = "0x18681E3B0")]
	public void BJKLOPNOEFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x2FAE450", Offset = "0x2FACE50", VA = "0x182FAE450")]
	public float GFNBBENEOBH(in (GDIPMFKHCFJ Start, GDIPMFKHCFJ End) COGNJLDAEEI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x681F3A0", Offset = "0x681DDA0", VA = "0x18681F3A0")]
	public void LMFDHDNPBDH(in IAHBKCHGCJO GFHEAAHHEHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x681E860", Offset = "0x681D260", VA = "0x18681E860")]
	private Vector3 BPNHOJCNIEB(in (GDIPMFKHCFJ Start, GDIPMFKHCFJ End) COGNJLDAEEI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x681F580", Offset = "0x681DF80", VA = "0x18681F580")]
	public HILBEMBFBGF()
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class AvatarSystemConfiguration : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public GameObject AvatarPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public string AvatarIdentifierPrefix;

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x681A4E0", Offset = "0x6818EE0", VA = "0x18681A4E0")]
		public string JMNNMGKGBOG(string CHENNDJLOAM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x681A530", Offset = "0x6818F30", VA = "0x18681A530")]
		public AvatarSystemConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct OIFCFNEJMKO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public string ALEHGHHMEDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public bool PIPALBOOBPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public bool KDPJNKOIJHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public float AJBGCPFDLGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public float BFMNGKEGNDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public bool BGENPPOJHGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public RigidbodyEx BEMDPOHINAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public RigidbodyEx JPBHKMPKCPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public RigidbodyEx HKDAAFDLIIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public RigidbodyEx CGLLFHGPMPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public Transform IPDMFHPLINI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public Transform OPKAKNBENMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public Transform PNBBAPNOGOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public PlayerAvatarFullBodyColliders FOEIKOKOLOF;
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct LNBIDDNLDDI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public Transform DDJEKGPKKPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public Transform GDCPABPFCPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public AvatarConfiguration KNCGGMLJBAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public Animator JBDBHLHGLDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public VRIK CNBNFFAFOBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public SkeletonLODUpdateRate[] KPIEGNKKALC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public GameObject[] DFKIJHKCHMN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public Transform KJMGBNMAGBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public GameObject FGOLCCJFAPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public BodySkinnedMeshLODs NCPFCEANBDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public BodySkinnedMeshLODs CHMLJLJACBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public GameObject GNKGGIPCPGA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public BodySkinnedMeshLODs JJCJCENJKHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public BodySkinnedMeshLODs FIAINOJMDDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public LFEGOINFIMD GKILDKHCFIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public Material JBLPFMCPLCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public Material NMFLOJFPPGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public Shader JMJPJHKICNI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public Transform LELFBFNAEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public Transform LLEPILADFFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public Transform OFDHGAOONBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public Transform LHKLMHGEIOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public Transform FPMPFEEFILC;
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct IAHBKCHGCJO
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public float MGMHPNENJLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public bool AGGOILCCLGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public IJJPEDCHMLC HBEABNCAGHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public Vector3 GEIBDKGKEKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public Vector3 AHAJNKMLMBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public Vector3? POHKFFFKMMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public Vector3? HGBMELDGJAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public bool FFOGCHKIFFH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public bool GKMLHJGLJNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public bool OPGHJFJNMMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x47")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public bool HKGMFPCKJNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public bool IPKHEHAMKJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public Vector3? BPFOLAECOAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public bool OGBAEKDENKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public Vector3? FMBFCBDCLLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public bool KGHEPENDEJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public Vector3? HLCHDMFFLAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public Vector3? DJAEGKOIHGM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public bool IEAIIEGHMKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x95")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public bool EOCCNJGNLHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x96")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public bool BFBFEONHAAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x97")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public bool LLPBBLLHJMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public bool POEBNKPMHLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public bool EHMPNEELLGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9A")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	public bool BJPBNHGGLGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9B")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	public bool OFCDKBJANIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	public bool HMLIBGAMCMC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9D")]
	[Cpp2IlInjected.Token(Token = "0x4000138")]
	public bool EGNFPPIGADE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000139")]
	public Vector3? DAIJLGLNFMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400013A")]
	public NJEJINANHJD EPGCPKMIMFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x400013B")]
	public NJEJINANHJD NIJBDOCEKME;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	public float PLBABGCMKLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	public float DNCAEEPABDJ;
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface ACJFHKHEOHG
{
	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void IEBPEPBABNG();

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::CMDAMFNAEHI<Texture2D> HANFJHLOLOM(COFEDDJALBA GHODCJLCILL, [Optional] KEKELDMNAIM PJBJFAJEGCC);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class CGIDBNACNFH : ACJFHKHEOHG, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	private DPOLOKPHELM NACOJJPOJCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400013F")]
	private IRecRoomQualityConfigProvider ODICEOKMPIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000140")]
	private bool KDPMOJEOINK;

	[Cpp2IlInjected.Token(Token = "0x4000141")]
	private const uint BNHMCFKJBHO = 16u;

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x681B190", Offset = "0x6819B90", VA = "0x18681B190")]
	[MBJLKJLIAAH(JDACKNHLALI.None)]
	private static void LJLDJLMDFPP(DPALDOJEBJE GCADPHBJBBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	[Preserve]
	public CGIDBNACNFH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x75FB60", Offset = "0x75E560", VA = "0x18075FB60", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x681B280", Offset = "0x6819C80", VA = "0x18681B280")]
	private void MKFPCGKBOCL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x681B130", Offset = "0x6819B30", VA = "0x18681B130", Slot = "4")]
	public void IEBPEPBABNG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x681AD20", Offset = "0x6819720", VA = "0x18681AD20", Slot = "5")]
	public global::CMDAMFNAEHI<Texture2D> HANFJHLOLOM(COFEDDJALBA GHODCJLCILL, [Optional] KEKELDMNAIM PJBJFAJEGCC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x681AB10", Offset = "0x6819510", VA = "0x18681AB10")]
	private uint GPHJBADPFEK(COFEDDJALBA GHODCJLCILL, KEKELDMNAIM PJBJFAJEGCC)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public enum NMOPOMLANGF
{
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	NeverObscured,
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	AlwaysObscured,
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	PrivateObscured
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class KEKELDMNAIM
{
	[Cpp2IlInjected.Token(Token = "0x400014A")]
	public static readonly KEKELDMNAIM NHIBPFHOELB;

	[Cpp2IlInjected.Token(Token = "0x1700006E")]
	public int DIMNKGKBACC
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x755A00", Offset = "0x754400", VA = "0x180755A00")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x80B370", Offset = "0x809D70", VA = "0x18080B370")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	public NMOPOMLANGF HNBJECOHLAO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x80B660", Offset = "0x80A060", VA = "0x18080B660")]
		[CompilerGenerated]
		get
		{
			return default(NMOPOMLANGF);
		}
		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x80B1F0", Offset = "0x809BF0", VA = "0x18080B1F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public KEKELDMNAIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x681FA20", Offset = "0x681E420", VA = "0x18681FA20")]
	public KEKELDMNAIM(NMOPOMLANGF DPFIFMCONAA, int JIBOJLOIOML)
	{
	}
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public class FitMeshHemisphere
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		private readonly Vector2 UV_CENTER_COORDINATE;

		[Cpp2IlInjected.Token(Token = "0x400014C")]
		public static readonly Vector3 DEFAULT_HEMISPHERE_FITMESH_PIVOT_POSITION;

		[Cpp2IlInjected.Token(Token = "0x400014D")]
		public static readonly Quaternion DEFAULT_HEMISPHERE_FITMESH_PIVOT_ROTATION;

		[Cpp2IlInjected.Token(Token = "0x400014E")]
		public static readonly Vector3 DEFAULT_HEMISPHERE_FITMESH_PIVOT_SCALE;

		[Cpp2IlInjected.Token(Token = "0x400014F")]
		public static readonly FitMeshHemisphere Default;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		[SerializeField]
		public Vector3 hemispherePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		[SerializeField]
		public Quaternion hemisphereRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		[SerializeField]
		public Vector3 hemisphereScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		[SerializeField]
		public float radius;

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public bool IsRadiusValid
		{
			[Cpp2IlInjected.Token(Token = "0x60000D5")]
			[Cpp2IlInjected.Address(RVA = "0x681DCA0", Offset = "0x681C6A0", VA = "0x18681DCA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x681DBE0", Offset = "0x681C5E0", VA = "0x18681DBE0")]
		public FitMeshHemisphere()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x681D3E0", Offset = "0x681BDE0", VA = "0x18681D3E0")]
		public void BGNCPHJNFKB(FitMeshHemisphere IHNOFMHJMDE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x681D4D0", Offset = "0x681BED0", VA = "0x18681D4D0")]
		public Vector3 INOBNNNPMFL(Vector2 OPGPNMDIODJ, bool IPMLGFKCHNK = true)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x681D430", Offset = "0x681BE30", VA = "0x18681D430")]
		public Vector3 ELLCAAENHEH(Vector2 OPGPNMDIODJ)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x681D810", Offset = "0x681C210", VA = "0x18681D810")]
		public Quaternion LKACNGPFEGK(Vector2 OPGPNMDIODJ)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x681D940", Offset = "0x681C340", VA = "0x18681D940")]
		public Quaternion LKACNGPFEGK(Vector2 OPGPNMDIODJ, Vector3 BGGEBPOGDHK)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x681D490", Offset = "0x681BE90", VA = "0x18681D490")]
		private Vector2 FKGFIPMMHIE(Vector2 DOODJGIMOGE)
		{
			return default(Vector2);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct HHOEJHDLBGA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000154")]
	public readonly GameObject JLKLHDLGJJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000155")]
	public readonly AvatarItemMaterial HIFHHNLGJEN;

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0xC33810", Offset = "0xC32210", VA = "0x180C33810")]
	public HHOEJHDLBGA(GameObject JLKLHDLGJJD, AvatarItemMaterial HIFHHNLGJEN)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public enum OutfitType
	{
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		None = -1,
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		Hat = 0,
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		Hair = 2,
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		Ear = 3,
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		Eye = 10,
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		Beard = 20,
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		Shoulder = 100,
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		Shirt = 101,
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		Waist = 102,
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		Neck = 103,
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		TeamJersey = 104,
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		CustomShirt = 105,
		[Cpp2IlInjected.Token(Token = "0x4000163")]
		Wrist = 200,
		[Cpp2IlInjected.Token(Token = "0x4000164")]
		TeamWrist = 203,
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		Legs = 300,
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		Feet = 301
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class KDEMFFFBAPG
{
	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x681F960", Offset = "0x681E360", VA = "0x18681F960")]
	public static bool EBGCIKLFHAE(this OutfitType CFAJELGLJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x681F930", Offset = "0x681E330", VA = "0x18681F930")]
	public static bool BCPGEMFKEEL(this OutfitType CFAJELGLJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x681F980", Offset = "0x681E380", VA = "0x18681F980")]
	public static bool MHLGFIKDDDA(this OutfitType CFAJELGLJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x681F950", Offset = "0x681E350", VA = "0x18681F950")]
	public static bool CCGNKNGLHIB(this OutfitType CFAJELGLJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x681F990", Offset = "0x681E390", VA = "0x18681F990")]
	public static bool OMCHPMFCGPP(this OutfitType CFAJELGLJPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x681F920", Offset = "0x681E320", VA = "0x18681F920")]
	public static bool BBMPMIOPECF(this OutfitType CFAJELGLJPC)
	{
		return default(bool);
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class PlayerAvatarFullBodyColliders : MonoBehaviour
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		private LFEGOINFIMD MOELIAKKHHH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		private Collider[] HEANDDMJBJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		[SerializeField]
		private GameObject RootGameObject;

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		private Collider[] AHFGJGMCGOA
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x6820FD0", Offset = "0x681F9D0", VA = "0x186820FD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6820F50", Offset = "0x681F950", VA = "0x186820F50")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x6821190", Offset = "0x681FB90", VA = "0x186821190")]
		public void UpdateBones(LFEGOINFIMD EGKLMLMABPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x6821040", Offset = "0x681FA40", VA = "0x186821040")]
		public void SetCollidersEnabled(bool CABHIPNEIGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x68211C0", Offset = "0x681FBC0", VA = "0x1868211C0")]
		public PlayerAvatarFullBodyColliders()
		{
		}
	}
}
namespace RecRoom.Avatars.Face
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public sealed class BrowsFaceFeature : SymmetricalFaceFeature
	{
		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x60000EA")]
			[Cpp2IlInjected.Address(RVA = "0xA24EF0", Offset = "0xA238F0", VA = "0x180A24EF0", Slot = "4")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x681A580", Offset = "0x6818F80", VA = "0x18681A580")]
		public BrowsFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public sealed class EyesFaceFeature : SymmetricalFaceFeature
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public Vector2 MaxGleamJitterScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400016B")]
		public Vector2 MaxGleamJitterOffsetAnchors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
		[Cpp2IlInjected.Token(Token = "0x400016C")]
		public bool JitterGleamSymmetrically;

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x7373B0", Offset = "0x735DB0", VA = "0x1807373B0", Slot = "4")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public Vector2 JitteredEyeGleamOffsetLeft
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x681C5C0", Offset = "0x681AFC0", VA = "0x18681C5C0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x681C600", Offset = "0x681B000", VA = "0x18681C600")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public Vector2 JitteredEyeGleamOffsetRight
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x27D2110", Offset = "0x27D0B10", VA = "0x1827D2110")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x27D14A0", Offset = "0x27CFEA0", VA = "0x1827D14A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public Vector2 JitteredEyeGleamScaleLeft
		{
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0x3B005F0", Offset = "0x3AFEFF0", VA = "0x183B005F0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F2")]
			[Cpp2IlInjected.Address(RVA = "0xEFD8B0", Offset = "0xEFC2B0", VA = "0x180EFD8B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000077")]
		public Vector2 JitteredEyeGleamScaleRight
		{
			[Cpp2IlInjected.Token(Token = "0x60000F3")]
			[Cpp2IlInjected.Address(RVA = "0x681C5E0", Offset = "0x681AFE0", VA = "0x18681C5E0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0xEFD8C0", Offset = "0xEFC2C0", VA = "0x180EFD8C0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x681C240", Offset = "0x681AC40", VA = "0x18681C240", Slot = "5")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x681C4E0", Offset = "0x681AEE0", VA = "0x18681C4E0")]
		public EyesFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public abstract class FaceFeature : FaceFeatureBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000171")]
		public Vector2 DefaultAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000172")]
		public Vector2 MaxJitterAnchor;

		[Cpp2IlInjected.Token(Token = "0x17000078")]
		public Vector2 JitteredAnchor
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x681CBA0", Offset = "0x681B5A0", VA = "0x18681CBA0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0xE802E0", Offset = "0xE7ECE0", VA = "0x180E802E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000079")]
		public Vector2 JitteredOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0xD08250", Offset = "0xD06C50", VA = "0x180D08250")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000FA")]
			[Cpp2IlInjected.Address(RVA = "0xA02F60", Offset = "0xA01960", VA = "0x180A02F60")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x681CA70", Offset = "0x681B470", VA = "0x18681CA70", Slot = "5")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x681CB20", Offset = "0x681B520", VA = "0x18681CB20")]
		protected FaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public abstract class FaceFeatureBase : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private const bool HIGH_QUALTIY_COMPRESS = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		[SerializeField]
		[Tooltip("This guid is auto generated at the time of the asset creation and should never change if you do not want to break an existing player's feature selection")]
		private string GuidString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		[SerializeField]
		private Sprite[] Sprites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		[SerializeField]
		private Sprite menuButtonSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		public Vector2 DefaultScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400017A")]
		public Vector2 MaxJitterScale;

		[Cpp2IlInjected.Token(Token = "0x1700007A")]
		public string Guid
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007B")]
		public IEnumerable<Sprite> SrcSprites
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x7AF6F0", Offset = "0x7AE0F0", VA = "0x1807AF6F0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x737430", Offset = "0x735E30", VA = "0x180737430")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		public int TextureCount
		{
			[Cpp2IlInjected.Token(Token = "0x6000100")]
			[Cpp2IlInjected.Address(RVA = "0x681CA50", Offset = "0x681B450", VA = "0x18681CA50")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public abstract FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x6000101")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public Vector2 JitteredScale
		{
			[Cpp2IlInjected.Token(Token = "0x6000102")]
			[Cpp2IlInjected.Address(RVA = "0x1CED6C0", Offset = "0x1CEC0C0", VA = "0x181CED6C0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000103")]
			[Cpp2IlInjected.Address(RVA = "0xC01CC0", Offset = "0xC006C0", VA = "0x180C01CC0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x681C880", Offset = "0x681B280", VA = "0x18681C880")]
		protected static Vector2 JitteredVector2(Vector2 initial, Vector2 maxJitter)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x681C8F0", Offset = "0x681B2F0", VA = "0x18681C8F0", Slot = "5")]
		public virtual void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x681C970", Offset = "0x681B370", VA = "0x18681C970")]
		protected FaceFeatureBase()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class DBLANHINENO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private class KLJAPDGNKNE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		public readonly Texture2DArray CBBLBGNJLLO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public readonly Dictionary<string, int> KHMOLNCDFPD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		private readonly MLJMKOJHCLB BNPGJHDNHPB;

		[Cpp2IlInjected.Token(Token = "0x17000084")]
		public bool IPADHFBLHAE
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x1E14B50", Offset = "0x1E13550", VA = "0x181E14B50")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x681FA60", Offset = "0x681E460", VA = "0x18681FA60")]
		public KLJAPDGNKNE(Texture2DArray OIJPELPOMAC, Dictionary<string, int> GGLEPEFBPOB, DBLANHINENO OGJLCCMLOJJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x25D2230", Offset = "0x25D0C30", VA = "0x1825D2230")]
		public void AHKEAJNNINN(DBLANHINENO HMAOAMDKNDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x25D2F10", Offset = "0x25D1910", VA = "0x1825D2F10")]
		public void KMOIELEIJNC(DBLANHINENO HMAOAMDKNDD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x24C3E80", Offset = "0x24C2880", VA = "0x1824C3E80", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private struct FJKBFMJNDIK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		private readonly string APDIAHIGMML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		private readonly string MDCNHIIPOCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private readonly string OHACDJNEMOE;

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x875B60", Offset = "0x874560", VA = "0x180875B60")]
		public FJKBFMJNDIK(string LJMNDDJECJL, string DCBPNFAHKJI, string MLLEHPGLGCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x681C800", Offset = "0x681B200", VA = "0x18681C800")]
		public bool KHPOGCBLNFJ(FJKBFMJNDIK EHBPAFKHADK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x681C6A0", Offset = "0x681B0A0", VA = "0x18681C6A0", Slot = "0")]
		public override bool Equals(object OMHIFHKMIMJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x1077500", Offset = "0x1075F00", VA = "0x181077500", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x681C610", Offset = "0x681B010", VA = "0x18681C610")]
		public static bool ENMIHMCKBEN(FJKBFMJNDIK BBDDOKEDLCI, FJKBFMJNDIK NAHMKAGEEEK)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600011F")]
		[Cpp2IlInjected.Address(RVA = "0x681C770", Offset = "0x681B170", VA = "0x18681C770")]
		public static bool IDBOJBLCJLG(FJKBFMJNDIK BBDDOKEDLCI, FJKBFMJNDIK NAHMKAGEEEK)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400017C")]
	private readonly Dictionary<string, int> GGLEPEFBPOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000181")]
	private readonly FJKBFMJNDIK DLOMHELLMNH;

	[Cpp2IlInjected.Token(Token = "0x17000080")]
	public Texture2DArray GIKDACHAICK
	{
		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x76B750", Offset = "0x76A150", VA = "0x18076B750")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x7D2590", Offset = "0x7D0F90", VA = "0x1807D2590")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000081")]
	public SymmetricalFaceFeature JLAMFFCMKOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x7AF6F0", Offset = "0x7AE0F0", VA = "0x1807AF6F0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x831AC0", Offset = "0x8304C0", VA = "0x180831AC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000082")]
	public EyesFaceFeature HJIFANDCDEL
	{
		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x737430", Offset = "0x735E30", VA = "0x180737430")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x7DAB60", Offset = "0x7D9560", VA = "0x1807DAB60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000083")]
	public FaceFeature ACFMIHEEKCK
	{
		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x738BA0", Offset = "0x7375A0", VA = "0x180738BA0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x7D4370", Offset = "0x7D2D70", VA = "0x1807D4370")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(RVA = "0x681B5C0", Offset = "0x6819FC0", VA = "0x18681B5C0")]
	private static void NPGIFLMFGDO(Sprite PJAEGFBCLJH, Sprite NOODLBBEHHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x681B540", Offset = "0x6819F40", VA = "0x18681B540")]
	private static void BMEMAENGELC(Sprite GNFCMLMPPEL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000111")]
	[Cpp2IlInjected.Address(RVA = "0x681B6C0", Offset = "0x681A0C0", VA = "0x18681B6C0")]
	public DBLANHINENO(EyesFaceFeature EKBCMBHPALF, FaceFeature FECIJJAGLBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000112")]
	[Cpp2IlInjected.Address(RVA = "0x681B6E0", Offset = "0x681A0E0", VA = "0x18681B6E0")]
	public DBLANHINENO(SymmetricalFaceFeature EFHFJJNKDOM, EyesFaceFeature EKBCMBHPALF, FaceFeature FECIJJAGLBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x681B330", Offset = "0x6819D30", VA = "0x18681B330")]
	public bool AKEDPBAPNLN(Sprite GNFCMLMPPEL, out int ALJOMNDNEBM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x681B5B0", Offset = "0x6819FB0", VA = "0x18681B5B0", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.Avatars.Face
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public enum FaceFeatureType
	{
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		Eye = 0,
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		Mouth = 1,
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		Nose = 2,
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		Brows = 3,
		[Cpp2IlInjected.Token(Token = "0x400018F")]
		Other = 10
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public sealed class FaceStyleSet : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000190")]
		public SymmetricalFaceFeature[] EyeBrows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public EyesFaceFeature[] Eyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000192")]
		public FaceFeature[] Mouths;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000193")]
		private Dictionary<string, SymmetricalFaceFeature> eyeBrowFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000194")]
		private Dictionary<string, EyesFaceFeature> eyeFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000195")]
		private Dictionary<string, FaceFeature> mouthFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000196")]
		private Dictionary<string, int> featureToIndexMap;

		[Cpp2IlInjected.Token(Token = "0x17000085")]
		private bool dictionariesInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x681D3C0", Offset = "0x681BDC0", VA = "0x18681D3C0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x681D140", Offset = "0x681BB40", VA = "0x18681D140")]
		public DBLANHINENO OMPNFBKIFGA(int AHHFLLPHMHC, int EKBCMBHPALF, int FECIJJAGLBM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(RVA = "0x681CC50", Offset = "0x681B650", VA = "0x18681CC50")]
		public FaceFeatureBase GDPJMANGMPP(FaceFeatureType LMGBKJICKBK, string GDCMPFDFIDH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000126")]
		[Cpp2IlInjected.Address(RVA = "0x681CBC0", Offset = "0x681B5C0", VA = "0x18681CBC0")]
		public int DJGLIFMAAAO(string GDCMPFDFIDH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000127")]
		[Cpp2IlInjected.Address(RVA = "0x681CEC0", Offset = "0x681B8C0", VA = "0x18681CEC0")]
		private void NMCCLBGCOBC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000128")]
		[Cpp2IlInjected.Address(RVA = "0x3753830", Offset = "0x3752230", VA = "0x183753830")]
		private void PHKHNJONLKF<T>(Dictionary<string, T> AHKMGODEDKL, T[] OGJIMGJCDFJ) where T : FaceFeatureBase
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x681D070", Offset = "0x681BA70", VA = "0x18681D070")]
		public string OBONENICMIL(FaceFeatureType LMGBKJICKBK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x681CDA0", Offset = "0x681B7A0", VA = "0x18681CDA0")]
		public string MGJMMOLDHNG(FaceFeatureType LMGBKJICKBK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x681D340", Offset = "0x681BD40", VA = "0x18681D340")]
		public FaceStyleSet()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public sealed class MouthFaceFeature : FaceFeature
	{
		[Cpp2IlInjected.Token(Token = "0x17000086")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x600012C")]
			[Cpp2IlInjected.Address(RVA = "0x7373E0", Offset = "0x735DE0", VA = "0x1807373E0", Slot = "4")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x6820370", Offset = "0x681ED70", VA = "0x186820370")]
		public MouthFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public sealed class NoseFaceFeature : FaceFeature
	{
		[Cpp2IlInjected.Token(Token = "0x17000087")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x600012E")]
			[Cpp2IlInjected.Address(RVA = "0x80AC00", Offset = "0x809600", VA = "0x18080AC00", Slot = "4")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6820370", Offset = "0x681ED70", VA = "0x186820370")]
		public NoseFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public abstract class SymmetricalFaceFeature : FaceFeatureBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000197")]
		public Vector2 MaxJitterAnchors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000198")]
		public bool JitterSymetrically;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x4000199")]
		public Vector2 DefaultAnchorLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x400019C")]
		public Vector2 DefaultAnchorRight;

		[Cpp2IlInjected.Token(Token = "0x17000088")]
		public Vector2 JitteredAnchorLeft
		{
			[Cpp2IlInjected.Token(Token = "0x6000130")]
			[Cpp2IlInjected.Address(RVA = "0x1CEA840", Offset = "0x1CE9240", VA = "0x181CEA840")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x10F17B0", Offset = "0x10F01B0", VA = "0x1810F17B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000089")]
		public Vector2 JitteredOffsetLeft
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x1CEE4B0", Offset = "0x1CECEB0", VA = "0x181CEE4B0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x10F1790", Offset = "0x10F0190", VA = "0x1810F1790")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008A")]
		public Vector2 JitteredAnchorRight
		{
			[Cpp2IlInjected.Token(Token = "0x6000134")]
			[Cpp2IlInjected.Address(RVA = "0x2054E20", Offset = "0x2053820", VA = "0x182054E20")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0xD08360", Offset = "0xD06D60", VA = "0x180D08360")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700008B")]
		public Vector2 JitteredOffsetRight
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x2054DB0", Offset = "0x20537B0", VA = "0x182054DB0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x6821420", Offset = "0x681FE20", VA = "0x186821420")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x6821310", Offset = "0x681FD10", VA = "0x186821310", Slot = "5")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x681A580", Offset = "0x6818F80", VA = "0x18681A580")]
		protected SymmetricalFaceFeature()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class NNIFMOPFNIE
{
	[Cpp2IlInjected.Token(Token = "0x400019F")]
	private static byte[] FNNHBCFPBIC;

	[Cpp2IlInjected.Token(Token = "0x40001A0")]
	private static int IPKGAJADJFC;

	[Cpp2IlInjected.Token(Token = "0x40001A1")]
	private static int DIJMLDGECMG;

	[Cpp2IlInjected.Token(Token = "0x40001A2")]
	private static BigInteger DGOGINAIMEE;

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
	public NNIFMOPFNIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x6820380", Offset = "0x681ED80", VA = "0x186820380")]
	private static string DAIOEIOFDHG(byte[] LPDJCHOFJLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x6820490", Offset = "0x681EE90", VA = "0x186820490")]
	public static string LIOEFPBPBEO(byte[] AHIMNOMEIMA, bool ADOOPHPHCDD)
	{
		return null;
	}
}
namespace PrivateImplementationDetailsQOELAJF
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	internal class ArrayCopy148
	{
		[StructLayout((LayoutKind)2, Pack = 1, Size = 151)]
		[Cpp2IlInjected.Token(Token = "0x2000041")]
		private struct $ArrayType$151
		{
		}

		[Cpp2IlInjected.Token(Token = "0x40001A3")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x7577B0", Offset = "0x7561B0", VA = "0x1807577B0")]
		public ArrayCopy148()
		{
		}
	}
}
namespace PrivateImplementationDetailsKQPLETG
{
	[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	public class __BB_OBFUSCATOR_VERSION_3_8_2
	{
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
