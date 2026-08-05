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
	[Cpp2IlInjected.Address(RVA = "0x6293030", Offset = "0x6291E30", VA = "0x186293030")]
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
			[Cpp2IlInjected.Address(RVA = "0x62929E0", Offset = "0x62917E0", VA = "0x1862929E0")]
			get
			{
				return default(AnchorParams);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x62929B0", Offset = "0x62917B0", VA = "0x1862929B0")]
		public AnchorParams(Vector2 JPOCOBCOBLE, Vector3 CFPEBEHADEE, Vector3 IPCMMEKMMNL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x6292840", Offset = "0x6291640", VA = "0x186292840")]
		public AnchorParams(CNKCGJMJHAC FJCMPMOMPKI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6292750", Offset = "0x6291550", VA = "0x186292750", Slot = "4")]
		public bool Equals(AnchorParams ONICAEEHHFG)
		{
			return default(bool);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public interface CNKCGJMJHAC
{
	[Cpp2IlInjected.Token(Token = "0x17000002")]
	bool JJMKLJGOKDP
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	bool EBFMMBJFALD
	{
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	bool LJGIJCPDGOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(Slot = "2")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	bool ENMJOFHCPOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(Slot = "3")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	bool OIICLEMKFDB
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	bool OEJHMOANACJ
	{
		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(Slot = "5")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	bool CGFOCEGIJLN
	{
		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(Slot = "6")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	bool LPOMDPNBEDB
	{
		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(Slot = "7")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	float CHFPLMPEGNN
	{
		[Cpp2IlInjected.Token(Token = "0x600000E")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	float JNMBMLHKKBE
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	float LLFOPDHHMFB
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(Slot = "10")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	float GILIBOCDNGN
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(Slot = "11")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	float HHNEIHANIOO
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(Slot = "12")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	float AHDPLDAKNMK
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(Slot = "13")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	float IODIOFGOKBI
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(Slot = "14")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	float JDGKOPLODFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(Slot = "15")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	float FABFBDNCECK
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(Slot = "16")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	float LMHAOEIOINB
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(Slot = "17")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	float EHHLJNCNLOG
	{
		[Cpp2IlInjected.Token(Token = "0x6000018")]
		[Cpp2IlInjected.Address(Slot = "18")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	float HEBKPJMPAIO
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(Slot = "19")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	float JBMHOJBDLAE
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(Slot = "20")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	float ENGGNELMPJK
	{
		[Cpp2IlInjected.Token(Token = "0x600001B")]
		[Cpp2IlInjected.Address(Slot = "21")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	float GIJJHKAKEAL
	{
		[Cpp2IlInjected.Token(Token = "0x600001C")]
		[Cpp2IlInjected.Address(Slot = "22")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	float DOBIIAGELFB
	{
		[Cpp2IlInjected.Token(Token = "0x600001D")]
		[Cpp2IlInjected.Address(Slot = "23")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(Slot = "24")]
	Vector3 IKMCKJKKBID(Vector3 IPCMMEKMMNL);

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(Slot = "25")]
	Vector3 IIFDHCGEAIE(Vector3 HBECNOIGOHH);

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(Slot = "26")]
	Vector3 JAALILGOGDB();

	[Cpp2IlInjected.Token(Token = "0x6000021")]
	[Cpp2IlInjected.Address(Slot = "27")]
	Vector3 KGMGCHDBFAC();
}
namespace RecRoom.Avatars
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public class AnchorParamsRestrictions : CNKCGJMJHAC
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
			[Cpp2IlInjected.Address(RVA = "0x62926C0", Offset = "0x62914C0", VA = "0x1862926C0", Slot = "5")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001B")]
		public bool GetAllowTranslationY
		{
			[Cpp2IlInjected.Token(Token = "0x6000023")]
			[Cpp2IlInjected.Address(RVA = "0x62926F0", Offset = "0x62914F0", VA = "0x1862926F0", Slot = "6")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001C")]
		public bool GetAllowTranslationZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000024")]
			[Cpp2IlInjected.Address(RVA = "0x6292720", Offset = "0x6291520", VA = "0x186292720", Slot = "7")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001D")]
		public bool GetAllowRotationX
		{
			[Cpp2IlInjected.Token(Token = "0x6000025")]
			[Cpp2IlInjected.Address(RVA = "0x6292630", Offset = "0x6291430", VA = "0x186292630", Slot = "9")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001E")]
		public bool GetAllowRotationY
		{
			[Cpp2IlInjected.Token(Token = "0x6000026")]
			[Cpp2IlInjected.Address(RVA = "0x6292660", Offset = "0x6291460", VA = "0x186292660", Slot = "10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700001F")]
		public bool GetAllowRotationZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000027")]
			[Cpp2IlInjected.Address(RVA = "0x6292690", Offset = "0x6291490", VA = "0x186292690", Slot = "11")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public bool GetAllowTranslations
		{
			[Cpp2IlInjected.Token(Token = "0x6000028")]
			[Cpp2IlInjected.Address(RVA = "0x792380", Offset = "0x791180", VA = "0x180792380", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		public bool GetAllowRotations
		{
			[Cpp2IlInjected.Token(Token = "0x6000029")]
			[Cpp2IlInjected.Address(RVA = "0x792390", Offset = "0x791190", VA = "0x180792390", Slot = "8")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0x87B100", Offset = "0x879F00", VA = "0x18087B100", Slot = "12")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxXOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600002B")]
			[Cpp2IlInjected.Address(RVA = "0x8A7360", Offset = "0x8A6160", VA = "0x1808A7360", Slot = "13")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600002C")]
			[Cpp2IlInjected.Address(RVA = "0x8A1EF0", Offset = "0x8A0CF0", VA = "0x1808A1EF0", Slot = "14")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxYOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600002D")]
			[Cpp2IlInjected.Address(RVA = "0x9022E0", Offset = "0x9010E0", VA = "0x1809022E0", Slot = "15")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600002E")]
			[Cpp2IlInjected.Address(RVA = "0x891DF0", Offset = "0x890BF0", VA = "0x180891DF0", Slot = "16")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxZOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600002F")]
			[Cpp2IlInjected.Address(RVA = "0x901F90", Offset = "0x900D90", VA = "0x180901F90", Slot = "17")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x6000030")]
			[Cpp2IlInjected.Address(RVA = "0x746120", Offset = "0x744F20", VA = "0x180746120", Slot = "20")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomY
		{
			[Cpp2IlInjected.Token(Token = "0x6000031")]
			[Cpp2IlInjected.Address(RVA = "0x71BF00", Offset = "0x71AD00", VA = "0x18071BF00", Slot = "21")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x6000032")]
			[Cpp2IlInjected.Address(RVA = "0x7B5780", Offset = "0x7B4580", VA = "0x1807B5780", Slot = "18")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomX
		{
			[Cpp2IlInjected.Token(Token = "0x6000033")]
			[Cpp2IlInjected.Address(RVA = "0x7B5770", Offset = "0x7B4570", VA = "0x1807B5770", Slot = "19")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetRightRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000034")]
			[Cpp2IlInjected.Address(RVA = "0x7B5850", Offset = "0x7B4650", VA = "0x1807B5850", Slot = "22")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetLeftRotationFreedomZ
		{
			[Cpp2IlInjected.Token(Token = "0x6000035")]
			[Cpp2IlInjected.Address(RVA = "0x7B57E0", Offset = "0x7B45E0", VA = "0x1807B57E0", Slot = "23")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public float GetMaxUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000036")]
			[Cpp2IlInjected.Address(RVA = "0x9E37A0", Offset = "0x9E25A0", VA = "0x1809E37A0", Slot = "24")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		public float GetMinUCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000037")]
			[Cpp2IlInjected.Address(RVA = "0x9E37B0", Offset = "0x9E25B0", VA = "0x1809E37B0", Slot = "25")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMaxVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000038")]
			[Cpp2IlInjected.Address(RVA = "0x2361DE0", Offset = "0x2360BE0", VA = "0x182361DE0", Slot = "26")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		private float RecRoom.Avatars.IAnchorParamsRestrictions.GetMinVCoordinate
		{
			[Cpp2IlInjected.Token(Token = "0x6000039")]
			[Cpp2IlInjected.Address(RVA = "0x197EDF0", Offset = "0x197DBF0", VA = "0x18197EDF0", Slot = "27")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x62925A0", Offset = "0x62913A0", VA = "0x1862925A0")]
		public AnchorParamsRestrictions()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003B")]
		[Cpp2IlInjected.Address(RVA = "0x62921F0", Offset = "0x6290FF0", VA = "0x1862921F0")]
		public AnchorParams HNJIHOOGKNC(AnchorParams KAGAJAHEAOD)
		{
			return default(AnchorParams);
		}

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x6292560", Offset = "0x6291360", VA = "0x186292560", Slot = "30")]
		public Vector3 JAALILGOGDB()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x6292580", Offset = "0x6291380", VA = "0x186292580", Slot = "31")]
		public Vector3 KGMGCHDBFAC()
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x62924D0", Offset = "0x62912D0", VA = "0x1862924D0", Slot = "28")]
		public Vector3 IKMCKJKKBID(Vector3 IPCMMEKMMNL)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x6292430", Offset = "0x6291230", VA = "0x186292430", Slot = "29")]
		public Vector3 IIFDHCGEAIE(Vector3 HBECNOIGOHH)
		{
			return default(Vector3);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class FBPJBNPHGKL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private List<Transform> KELCIMFDLDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private Matrix4x4[] POEIFAIDIGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private Dictionary<string, Transform> EDPKCAEBPOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private Dictionary<Transform, Transform> GELAIMCJDNN;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public Transform[] EMDOAOIKNFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x6293DB0", Offset = "0x6292BB0", VA = "0x186293DB0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public Matrix4x4[] CKOMKKBHIPE
	{
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x6293FE0", Offset = "0x6292DE0", VA = "0x186293FE0")]
	public void NNKIIJHMJFC(SkinnedMeshRenderer KDGFFBEDMIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x6293F70", Offset = "0x6292D70", VA = "0x186293F70")]
	public void LNKBNCAECIO(Transform HILKBGFNOLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x6294190", Offset = "0x6292F90", VA = "0x186294190")]
	private Transform POPMAAKFCOH(Transform NBAMDHNBCHC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x6293B30", Offset = "0x6292930", VA = "0x186293B30")]
	public void CEKDJCICCJE(FBPJBNPHGKL PHHJLJNBKDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000046")]
	[Cpp2IlInjected.Address(RVA = "0x6293E00", Offset = "0x6292C00", VA = "0x186293E00")]
	private void GMDPKIIHKHG(Transform DCJJENKGKJB, List<Transform> MKIMOHADGDP, Dictionary<string, Transform> OHIFCCDGLCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000047")]
	[Cpp2IlInjected.Address(RVA = "0x6294270", Offset = "0x6293070", VA = "0x186294270")]
	public FBPJBNPHGKL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class MJLGFAGPIGN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public bool OONFOOPHPHF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x11")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public bool BANILCLKIGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x12")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public bool CAILIGICCMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x13")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public bool FBKJIGKJMFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public bool AALKNANFEJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x15")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public bool LKPOJJCMADK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x16")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public bool FALLILKKMIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public IList<JMLHDMMIJCA> FKDDJDJNGMG;

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public MJLGFAGPIGN()
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	public abstract class AvatarConfiguration : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x79C840", Offset = "0x79B640", VA = "0x18079C840")]
		protected AvatarConfiguration()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000009")]
	public class AvatarCustomizationSettings
	{
		[Cpp2IlInjected.Token(Token = "0x200000A")]
		public enum JFCBDIEEMMC
		{
			[Cpp2IlInjected.Token(Token = "0x400003E")]
			Legacy_Hide,
			[Cpp2IlInjected.Token(Token = "0x400003F")]
			On,
			[Cpp2IlInjected.Token(Token = "0x4000040")]
			Off
		}

		[Cpp2IlInjected.Token(Token = "0x4000029")]
		private const int SERIALIZATION_VERSION = 6;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400002A")]
		[SerializeField]
		public int ver;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400002B")]
		[SerializeField]
		private string eyeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400002C")]
		[SerializeField]
		private Vector2 eyePos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400002D")]
		[SerializeField]
		private float eyeScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400002E")]
		[SerializeField]
		private string mouthId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400002F")]
		[SerializeField]
		private Vector2 mouthPos;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000030")]
		[SerializeField]
		private float mouthScl;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000031")]
		[SerializeField]
		private string hairPrimaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		[SerializeField]
		private string hairSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		[SerializeField]
		private string hairPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		[SerializeField]
		private string beardColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		[SerializeField]
		private string beardSecondaryColorId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
		[Cpp2IlInjected.Token(Token = "0x4000036")]
		[SerializeField]
		private string beardPatternId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
		[Cpp2IlInjected.Token(Token = "0x4000037")]
		[SerializeField]
		private string faceShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		[SerializeField]
		private string bodyShapeId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		[SerializeField]
		private bool useHatAnchorParams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8C")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		[SerializeField]
		private JFCBDIEEMMC useHelmetHair;

		[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		[SerializeField]
		private bool hideEars;

		[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		[SerializeField]
		private AnchorParams hatAnchorParams;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public string EyeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600004A")]
			[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600004B")]
			[Cpp2IlInjected.Address(RVA = "0x701A00", Offset = "0x700800", VA = "0x180701A00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public Vector2 EyePositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600004C")]
			[Cpp2IlInjected.Address(RVA = "0xBD4090", Offset = "0xBD2E90", VA = "0x180BD4090")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x600004D")]
			[Cpp2IlInjected.Address(RVA = "0x887EA0", Offset = "0x886CA0", VA = "0x180887EA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public float EyeScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x600004E")]
			[Cpp2IlInjected.Address(RVA = "0x9022E0", Offset = "0x9010E0", VA = "0x1809022E0")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x600004F")]
			[Cpp2IlInjected.Address(RVA = "0x9027E0", Offset = "0x9015E0", VA = "0x1809027E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		public string MouthGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000050")]
			[Cpp2IlInjected.Address(RVA = "0x718560", Offset = "0x717360", VA = "0x180718560")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000051")]
			[Cpp2IlInjected.Address(RVA = "0x7650F0", Offset = "0x763EF0", VA = "0x1807650F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public Vector2 MouthPositionOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000052")]
			[Cpp2IlInjected.Address(RVA = "0x902350", Offset = "0x901150", VA = "0x180902350")]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000053")]
			[Cpp2IlInjected.Address(RVA = "0x902860", Offset = "0x901660", VA = "0x180902860")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public float MouthScaleOffset
		{
			[Cpp2IlInjected.Token(Token = "0x6000054")]
			[Cpp2IlInjected.Address(RVA = "0x7B5770", Offset = "0x7B4570", VA = "0x1807B5770")]
			get
			{
				return default(float);
			}
			[Cpp2IlInjected.Token(Token = "0x6000055")]
			[Cpp2IlInjected.Address(RVA = "0xBD7140", Offset = "0xBD5F40", VA = "0x180BD7140")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public string HairPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000056")]
			[Cpp2IlInjected.Address(RVA = "0x6FD9C0", Offset = "0x6FC7C0", VA = "0x1806FD9C0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000057")]
			[Cpp2IlInjected.Address(RVA = "0x6FEF10", Offset = "0x6FDD10", VA = "0x1806FEF10")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public string HairSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000058")]
			[Cpp2IlInjected.Address(RVA = "0x77F2A0", Offset = "0x77E0A0", VA = "0x18077F2A0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000059")]
			[Cpp2IlInjected.Address(RVA = "0x87D7E0", Offset = "0x87C5E0", VA = "0x18087D7E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public string HairPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600005A")]
			[Cpp2IlInjected.Address(RVA = "0x7CFA40", Offset = "0x7CE840", VA = "0x1807CFA40")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005B")]
			[Cpp2IlInjected.Address(RVA = "0x7D7500", Offset = "0x7D6300", VA = "0x1807D7500")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public string BeardPrimaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600005C")]
			[Cpp2IlInjected.Address(RVA = "0x7B1C50", Offset = "0x7B0A50", VA = "0x1807B1C50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005D")]
			[Cpp2IlInjected.Address(RVA = "0x71C290", Offset = "0x71B090", VA = "0x18071C290")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public string BeardSecondaryColorGuid
		{
			[Cpp2IlInjected.Token(Token = "0x600005E")]
			[Cpp2IlInjected.Address(RVA = "0x7B1C60", Offset = "0x7B0A60", VA = "0x1807B1C60")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x600005F")]
			[Cpp2IlInjected.Address(RVA = "0x7D74F0", Offset = "0x7D62F0", VA = "0x1807D74F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public string BeardPatternTextureGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000060")]
			[Cpp2IlInjected.Address(RVA = "0x706B50", Offset = "0x705950", VA = "0x180706B50")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000061")]
			[Cpp2IlInjected.Address(RVA = "0x7FE740", Offset = "0x7FD540", VA = "0x1807FE740")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public string FaceShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000062")]
			[Cpp2IlInjected.Address(RVA = "0x73BC80", Offset = "0x73AA80", VA = "0x18073BC80")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000063")]
			[Cpp2IlInjected.Address(RVA = "0x80DCB0", Offset = "0x80CAB0", VA = "0x18080DCB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public string BodyShapeGuid
		{
			[Cpp2IlInjected.Token(Token = "0x6000064")]
			[Cpp2IlInjected.Address(RVA = "0x7C2BD0", Offset = "0x7C19D0", VA = "0x1807C2BD0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000065")]
			[Cpp2IlInjected.Address(RVA = "0x80DCA0", Offset = "0x80CAA0", VA = "0x18080DCA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public bool UseHatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x6000066")]
			[Cpp2IlInjected.Address(RVA = "0xAED750", Offset = "0xAEC550", VA = "0x180AED750")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x6000067")]
			[Cpp2IlInjected.Address(RVA = "0xAEDA60", Offset = "0xAEC860", VA = "0x180AEDA60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public JFCBDIEEMMC UseHelmetHair
		{
			[Cpp2IlInjected.Token(Token = "0x6000068")]
			[Cpp2IlInjected.Address(RVA = "0x6292F80", Offset = "0x6291D80", VA = "0x186292F80")]
			get
			{
				return default(JFCBDIEEMMC);
			}
			[Cpp2IlInjected.Token(Token = "0x6000069")]
			[Cpp2IlInjected.Address(RVA = "0x7875D0", Offset = "0x7863D0", VA = "0x1807875D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public bool HideEars
		{
			[Cpp2IlInjected.Token(Token = "0x600006A")]
			[Cpp2IlInjected.Address(RVA = "0xB6C7D0", Offset = "0xB6B5D0", VA = "0x180B6C7D0")]
			get
			{
				return default(bool);
			}
			[Cpp2IlInjected.Token(Token = "0x600006B")]
			[Cpp2IlInjected.Address(RVA = "0xB6C810", Offset = "0xB6B610", VA = "0x180B6C810")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public AnchorParams HatAnchorParams
		{
			[Cpp2IlInjected.Token(Token = "0x600006C")]
			[Cpp2IlInjected.Address(RVA = "0x6292F60", Offset = "0x6291D60", VA = "0x186292F60")]
			get
			{
				return default(AnchorParams);
			}
			[Cpp2IlInjected.Token(Token = "0x600006D")]
			[Cpp2IlInjected.Address(RVA = "0x6292FB0", Offset = "0x6291DB0", VA = "0x186292FB0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x8AB9D0", Offset = "0x8AA7D0", VA = "0x1808AB9D0")]
		public string APDPBGNCGIO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x6292A50", Offset = "0x6291850", VA = "0x186292A50")]
		public static AvatarCustomizationSettings DHABJCANOEO(string GEEBMNKHCKE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000070")]
		[Cpp2IlInjected.Address(RVA = "0x6292DA0", Offset = "0x6291BA0", VA = "0x186292DA0")]
		public AvatarCustomizationSettings()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	public struct BodySkinnedMeshLODs
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public SkinnedMeshRenderer[] LODs;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	public struct SkeletonLODUpdateRate
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public EHKPJAMPICF lod;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public float updateRate;
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	public struct AvatarHairPatternOverride
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public string PatternGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public Texture2D Texture;
	}
}
[Cpp2IlInjected.Token(Token = "0x200000E")]
public struct FEIPMGDFMHM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000046")]
	public Transform HGLINFAJHCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000047")]
	public GameObject NHFFJLAFNEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000048")]
	public SkinnedMeshRenderer[] HJENIAMGFIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000049")]
	public SkinnedMeshRenderer[] KLKKAJOBGEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400004A")]
	public GameObject BHKLFAFMGPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400004B")]
	public SkinnedMeshRenderer[] BJPLCMMBFFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x400004C")]
	public SkinnedMeshRenderer[] HCCLMAIJIBE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400004D")]
	public FBPJBNPHGKL FDJLEFNMBMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x400004E")]
	public Material FBFNHPFPHHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400004F")]
	public Material APNFCCOLDDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	public Shader IGGEDHKEOFG;
}
[Cpp2IlInjected.Token(Token = "0x200000F")]
public struct DCIKEMKCEIA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	public Transform NJIEBFCBLFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000052")]
	public Transform NNNLLBMNBLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000053")]
	public Transform HIJCHGHFHLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public Transform BOLDAIDIGCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public Transform AALPPCBFBEF;
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public struct INGMCBNHJIN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public SkinnedMeshRenderer[] GNIPEILNFFA;
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public struct OKIOMPFBGHC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public MDFDPJNMINN PNPMDNOPILB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public int PHJKKBOCJIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public int NHHJOAMKNCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public int POFBNHDOOOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public int CKOMOGFGKFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public int LBMFAIBLPEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public int BIHNDFMFPNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public int BAIEDPDCBGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public float LDPGGBJKBHM;
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public struct BLLNPAODNGB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public MDFDPJNMINN PNPMDNOPILB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	public Vector2 ACDPDOMJJOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	public float GHCKIAPEJGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	public Vector2 AJGBBJFAPCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	public float MKHLDLNDGKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	public Vector2 NJAIGGOAEFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public float ECLMEFGOCBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	public float LNDHBANCPFB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	public Vector2 JIPNIINIADK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public Vector2 AJGMCCABGMD;
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class JMLHDMMIJCA
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	public string LMPHGOGJNDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	public OutfitType NMGGEBIIFDC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	public PDHCOINOPJK KGMMCHBDNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	public bool FCAKNMNNHEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	public Color? DKJCBKMPIPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	public Vector3? ONDHPBAELLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	public float? BMHOJJKFKKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	public Guid? BNPGFEJKIAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x64")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public Color? IBKLJDCJIPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	public bool NACIKHAMDFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x79")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	public bool MCJKIGMOLJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	public AnchorParamsRestrictions NFLFKPFFBOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	public Vector2? HMCENPOGKGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	public Transform MGKEHBBFLBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	public FitMeshHemisphere KKJFFKPDPNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	public Vector2 NGLHDDDGFDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private List<AvatarHairPatternOverride> FEEILOONOBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	private Dictionary<string, Texture2D> EHNKFCAAIBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private List<AvatarHairPatternOverride> HEDIOIBALCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x400007D")]
	private Dictionary<string, Texture2D> AHLGDMALDBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD0")]
	[Cpp2IlInjected.Token(Token = "0x400007E")]
	public AssetReference LDPFBGAABGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xD8")]
	[Cpp2IlInjected.Token(Token = "0x400007F")]
	public AssetReference IOACFDJGCFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE0")]
	[Cpp2IlInjected.Token(Token = "0x4000080")]
	public AssetReference[] DDMILMPBIAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE8")]
	[Cpp2IlInjected.Token(Token = "0x4000081")]
	public bool CJCLJHAEJGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xE9")]
	[Cpp2IlInjected.Token(Token = "0x4000082")]
	public bool NKABOLLNPLH;

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public List<AvatarHairPatternOverride> MHNBAGDJFED
	{
		[Cpp2IlInjected.Token(Token = "0x6000071")]
		[Cpp2IlInjected.Address(RVA = "0x702430", Offset = "0x701230", VA = "0x180702430")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000072")]
		[Cpp2IlInjected.Address(RVA = "0x6297CD0", Offset = "0x6296AD0", VA = "0x186297CD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public List<AvatarHairPatternOverride> BONGCBLHFGO
	{
		[Cpp2IlInjected.Token(Token = "0x6000073")]
		[Cpp2IlInjected.Address(RVA = "0x718380", Offset = "0x717180", VA = "0x180718380")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000074")]
		[Cpp2IlInjected.Address(RVA = "0x6297AA0", Offset = "0x62968A0", VA = "0x186297AA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public string BEKHJLEIGLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000075")]
		[Cpp2IlInjected.Address(RVA = "0x6297F00", Offset = "0x6296D00", VA = "0x186297F00")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0x6297FB0", Offset = "0x6296DB0", VA = "0x186297FB0")]
	public JMLHDMMIJCA()
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
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		[SerializeField]
		private Material material;

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public Material Material
		{
			[Cpp2IlInjected.Token(Token = "0x600007D")]
			[Cpp2IlInjected.Address(RVA = "0x6FA130", Offset = "0x6F8F30", VA = "0x1806FA130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0x6292FD0", Offset = "0x6291DD0", VA = "0x186292FD0")]
		public static void OMNBLDOCOHD(AvatarItemMaterial HNOMFFGECKN, Material LOCCEEIOOPO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600007F")]
		[Cpp2IlInjected.Address(RVA = "0x6293030", Offset = "0x6291E30", VA = "0x186293030")]
		public AvatarItemMaterial()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class CNMNOMDBEIC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	public readonly Mesh KBAEGJMEIBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	public readonly Material[] NHGEBJMKKBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	public readonly bool EEGOLGFGLBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x21")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private bool LLCFOOONIGL;

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	private CNMNOMDBEIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6293570", Offset = "0x6292370", VA = "0x186293570")]
	public CNMNOMDBEIC(Mesh DPOJLBHHPEO, Material[] NJDDFBABDAL, bool BCDPEHOMADF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6293680", Offset = "0x6292480", VA = "0x186293680")]
	public CNMNOMDBEIC(SkinnedMeshRenderer HBLJAEGOIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6293200", Offset = "0x6292000", VA = "0x186293200")]
	public static CNMNOMDBEIC CNOJAINLAFH(Renderer KDGFFBEDMIA)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public enum KJIGIBBNMEG
{
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	None,
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	Highfive,
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	Fistbump,
	[Cpp2IlInjected.Token(Token = "0x4000091")]
	Handshake,
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	Point,
	[Cpp2IlInjected.Token(Token = "0x4000093")]
	ThumbsUp,
	[Cpp2IlInjected.Token(Token = "0x4000094")]
	ThumbsDown,
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	ClosedFist,
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	OpenHand
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public enum BKABAJECDOM
{
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	DoNotHideHair,
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	UseHelmetHair,
	[Cpp2IlInjected.Token(Token = "0x400009A")]
	AlwaysHideHair,
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	HideHairToggleable
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public enum PDHCOINOPJK
{
	[Cpp2IlInjected.Token(Token = "0x400009D")]
	None = -1,
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	Head,
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	Torso,
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	LeftHand,
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	RightHand,
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	Mouth,
	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	Legs,
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	LeftFoot,
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	RightFoot,
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	FullBody,
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	Nose
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
[Flags]
public enum EEPHNLCGPCM
{
	[Cpp2IlInjected.Token(Token = "0x40000A9")]
	None = 0,
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	Head = 1,
	[Cpp2IlInjected.Token(Token = "0x40000AB")]
	Torso = 2,
	[Cpp2IlInjected.Token(Token = "0x40000AC")]
	LeftHand = 4,
	[Cpp2IlInjected.Token(Token = "0x40000AD")]
	RightHand = 8,
	[Cpp2IlInjected.Token(Token = "0x40000AE")]
	Mouth = 0x10,
	[Cpp2IlInjected.Token(Token = "0x40000AF")]
	Legs = 0x20,
	[Cpp2IlInjected.Token(Token = "0x40000B0")]
	RightFoot = 0x80,
	[Cpp2IlInjected.Token(Token = "0x40000B1")]
	LeftFoot = 0x40,
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	FullBody = 0x100,
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	Nose = 0x200
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public enum HCNLGPGGDPM
{
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	SkinColor,
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	PrimaryHairColor,
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	SecondaryHairColor,
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	PrimaryBeardColor,
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	SecondaryBeardColor,
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	UGCShirtColor,
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	TeamColor,
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	TeamEmissiveColor
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public enum FDJKIDAFAHH
{
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	HairPattern,
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	BeardPattern
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public enum EJCNAEHOEKD
{
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	TeamItem,
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	SkinColor,
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	HairColor,
	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	BeardColor,
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	UGCShirtColor
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public enum CKIOKLPNMDN
{
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	HairTexture,
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	BeardTexture,
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	UGCShirtTexture
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public enum CCCPFFNJFPC
{
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	None,
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	CollapseSubMeshes,
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	CollapseToUniqueMaterials,
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	MergeAll
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public static class LLKAHPIAMMB
{
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	public static readonly int HDKGCLJIAMC;

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6298A30", Offset = "0x6297830", VA = "0x186298A30")]
	public static HGKNDDEFBNP IAFHLOCANBJ()
	{
		return default(HGKNDDEFBNP);
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x6298810", Offset = "0x6297610", VA = "0x186298810")]
	public static LCAAGMFOMIJ HCLPCADAPLM(Transform PDOKGEDOHHO, Transform DOAOLEOEKOD, AvatarConfiguration ENPMFOIOMEN, Animator BGNIGHOGFNM, VRIK GFJEMJCADGJ, SkeletonLODUpdateRate[] FEFKNDGAOAG, GameObject[] CINCGEBJMEP, Transform AOKIEKFMADP, GameObject FJCEKHFJEGD, BodySkinnedMeshLODs IHNDCKKOLGE, BodySkinnedMeshLODs KJPDCPMFPAC, GameObject HJHPKCEIGLH, BodySkinnedMeshLODs CJOLMANBIBE, BodySkinnedMeshLODs LNLLANAMOBP, FBPJBNPHGKL ONJBEMCKHHO, Material OIMMMLHLFLB, Material PDNFCPPFECB, Shader JCJMDDGDAGE, Transform EHMGOHFECDC, Transform ILJJGFAONJJ, Transform LPJHPGNONDA, Transform JAFOAJADMII, Transform JMKKMGLCNGG)
	{
		return default(LCAAGMFOMIJ);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x6298680", Offset = "0x6297480", VA = "0x186298680")]
	public static CMDOJGPIIDC FACDGFCKCLL(string DJGOKAEAABA, bool BCHBPCAKKOD, bool JLDFDFKCHJH, bool ILJNKDGMOBI, RigidbodyEx CJCCBPEPEKA, RigidbodyEx EFIGBEBFKEC, RigidbodyEx NMKFLGFFEEC, RigidbodyEx FNMACOIDEPG, Transform DLGLHEDDNLJ, Transform FEHHGCIIEOO, Transform HJOOJOPEKJJ, float ODBJJEHFLIN, float OGLJBMNGEEC, PlayerAvatarFullBodyColliders ENOIMBOOHIG)
	{
		return default(CMDOJGPIIDC);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x6298AF0", Offset = "0x62978F0", VA = "0x186298AF0")]
	public static FEIPMGDFMHM KDNIPDMMFNJ(Transform DOAOLEOEKOD, GameObject FJCEKHFJEGD, SkinnedMeshRenderer[] MIAKKJFJPBM, SkinnedMeshRenderer[] ODCOGBAFDGH, GameObject HJHPKCEIGLH, SkinnedMeshRenderer[] ONPFLDFFCMF, SkinnedMeshRenderer[] HCDABCLHCGI, FBPJBNPHGKL ONJBEMCKHHO, Material OIMMMLHLFLB, Material PDNFCPPFECB, Shader JCJMDDGDAGE)
	{
		return default(FEIPMGDFMHM);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x62985F0", Offset = "0x62973F0", VA = "0x1862985F0")]
	public static DCIKEMKCEIA BPANHCIOACA(Transform EHMGOHFECDC, Transform LPJHPGNONDA, Transform ILJJGFAONJJ, Transform JAFOAJADMII, Transform JMKKMGLCNGG)
	{
		return default(DCIKEMKCEIA);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x73FB40", Offset = "0x73E940", VA = "0x18073FB40")]
	public static INGMCBNHJIN NCJNDLPFKGB(SkinnedMeshRenderer[] DBMFLCPCGBI)
	{
		return default(INGMCBNHJIN);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x6298790", Offset = "0x6297590", VA = "0x186298790")]
	public static OKIOMPFBGHC FJIFFKNCOJN(MDFDPJNMINN PDFEBMOOIGN, int DADFOMIICFF, int HPDGCBLNILF, int ANGANBPJGLG, int PLPJBKCLEGB, int GLGCILPJFLJ, int OMAIANAFHPE, int JDNKLBBJALL, float INDIDLHBNJB)
	{
		return default(OKIOMPFBGHC);
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x6298A60", Offset = "0x6297860", VA = "0x186298A60")]
	public static BLLNPAODNGB JOPBPANDBLI(MDFDPJNMINN PDFEBMOOIGN, Vector2 LECMBKMGMKC, float FCPHKJBKAKD, Vector2 ACOIABJEBCH, float DIBKNMAODAJ, Vector2 MEHINGIABHI, float ANBGLCJFOFE)
	{
		return default(BLLNPAODNGB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public interface JBDCMIAKDNA
{
	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	Transform OBACKBELLEI
	{
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	Vector3 PEGIFBFBMMF
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class ABFNKEDKEAE : JBDCMIAKDNA
{
	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public Transform OBACKBELLEI
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x6F7E40", Offset = "0x6F6C40", VA = "0x1806F7E40", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000090")]
		[Cpp2IlInjected.Address(RVA = "0x6F7F10", Offset = "0x6F6D10", VA = "0x1806F7F10")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public Vector3 PEGIFBFBMMF
	{
		[Cpp2IlInjected.Token(Token = "0x6000091")]
		[Cpp2IlInjected.Address(RVA = "0xAC2EA0", Offset = "0xAC1CA0", VA = "0x180AC2EA0", Slot = "5")]
		[CompilerGenerated]
		get
		{
			return default(Vector3);
		}
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0xAC2ED0", Offset = "0xAC1CD0", VA = "0x180AC2ED0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public float? MCHOMALJGPN
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x95C0A0", Offset = "0x95AEA0", VA = "0x18095C0A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x95C100", Offset = "0x95AF00", VA = "0x18095C100")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public ABFNKEDKEAE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
public class JCNBDKPLFEC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000D5")]
	protected readonly ABFNKEDKEAE MGMENFMNMKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	protected readonly ABFNKEDKEAE PJOKMBDEGBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	protected readonly ABFNKEDKEAE JALBEFBENGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000D8")]
	protected readonly ABFNKEDKEAE BPBJAHBMGAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	protected readonly ABFNKEDKEAE PBIFIFLPHGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	protected readonly ABFNKEDKEAE MGCOFEMKACI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	protected readonly ABFNKEDKEAE BGELOKJDPIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	protected readonly ABFNKEDKEAE AGFGINEMEBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	protected readonly ABFNKEDKEAE FENDNMMDEDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	protected readonly ABFNKEDKEAE KMNPLIJBPBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	protected readonly ABFNKEDKEAE IEIPIOOJDOG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	protected readonly ABFNKEDKEAE KIALMLMEHNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	protected readonly ABFNKEDKEAE IHDCCDDICHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x40000E2")]
	protected ABFNKEDKEAE DJACFEBDPDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	protected readonly ABFNKEDKEAE LFLHBGAAOHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	protected readonly ABFNKEDKEAE JEHHOHEFFFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	protected readonly ABFNKEDKEAE OPPDGGBAINO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	protected ABFNKEDKEAE DMPNECCKEFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	protected readonly ABFNKEDKEAE AGEEDEOKOPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	protected readonly ABFNKEDKEAE PGDICNPOCND;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	protected readonly ABFNKEDKEAE JIBJBANJMDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	protected ReadOnlyCollection<ABFNKEDKEAE> AMDEFONCLGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	public Transform AOKIEKFMADP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC8")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private (ABFNKEDKEAE Start, ABFNKEDKEAE End)[] BPGJLHFOEOH;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public JBDCMIAKDNA IOOIOKFIKFJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6F7E40", Offset = "0x6F6C40", VA = "0x1806F7E40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public JBDCMIAKDNA IOEGLGCECJI
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public JBDCMIAKDNA KKHGNBNJNAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000098")]
		[Cpp2IlInjected.Address(RVA = "0x6FA130", Offset = "0x6F8F30", VA = "0x1806FA130")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public JBDCMIAKDNA GMCLLODCMIL
	{
		[Cpp2IlInjected.Token(Token = "0x6000099")]
		[Cpp2IlInjected.Address(RVA = "0x6FA2D0", Offset = "0x6F90D0", VA = "0x1806FA2D0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public JBDCMIAKDNA IHNINEJDOJK
	{
		[Cpp2IlInjected.Token(Token = "0x600009A")]
		[Cpp2IlInjected.Address(RVA = "0x718560", Offset = "0x717360", VA = "0x180718560")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public JBDCMIAKDNA IHFLDDIECNL
	{
		[Cpp2IlInjected.Token(Token = "0x600009B")]
		[Cpp2IlInjected.Address(RVA = "0x6F6E70", Offset = "0x6F5C70", VA = "0x1806F6E70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public JBDCMIAKDNA LCMELDEINBN
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x6FA150", Offset = "0x6F8F50", VA = "0x1806FA150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public ABFNKEDKEAE EMELNGBBBLG
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x6FA150", Offset = "0x6F8F50", VA = "0x1806FA150")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public JBDCMIAKDNA APEKFPDAGIP
	{
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x6FD9C0", Offset = "0x6FC7C0", VA = "0x1806FD9C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public ABFNKEDKEAE NBAMCPICMOE
	{
		[Cpp2IlInjected.Token(Token = "0x600009F")]
		[Cpp2IlInjected.Address(RVA = "0x6FD9C0", Offset = "0x6FC7C0", VA = "0x1806FD9C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public JBDCMIAKDNA CJHOGENJNGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x77F2A0", Offset = "0x77E0A0", VA = "0x18077F2A0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public JBDCMIAKDNA DJPOLOEGJJG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A1")]
		[Cpp2IlInjected.Address(RVA = "0x7CFA40", Offset = "0x7CE840", VA = "0x1807CFA40")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public JBDCMIAKDNA CJHONBPEDDF
	{
		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x7B1C50", Offset = "0x7B0A50", VA = "0x1807B1C50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public ABFNKEDKEAE CBHJEOBEGHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x7B1C50", Offset = "0x7B0A50", VA = "0x1807B1C50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public ABFNKEDKEAE BAKPAAHPPDO
	{
		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x7B1C60", Offset = "0x7B0A60", VA = "0x1807B1C60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public JBDCMIAKDNA EAHFFOMPLAE
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x7B1C60", Offset = "0x7B0A60", VA = "0x1807B1C60")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public JBDCMIAKDNA EPKBGDKOMCP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x706B50", Offset = "0x705950", VA = "0x180706B50")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public JBDCMIAKDNA HAOOIKDBKHL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x73BC80", Offset = "0x73AA80", VA = "0x18073BC80")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public JBDCMIAKDNA HCEHLAKMEHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x7C2BD0", Offset = "0x7C19D0", VA = "0x1807C2BD0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public JBDCMIAKDNA GDKHDLPBGKL
	{
		[Cpp2IlInjected.Token(Token = "0x60000A9")]
		[Cpp2IlInjected.Address(RVA = "0x771990", Offset = "0x770790", VA = "0x180771990")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public JBDCMIAKDNA ENCFIINAKGH
	{
		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x771980", Offset = "0x770780", VA = "0x180771980")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public JBDCMIAKDNA DNDANNFNKNC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x70D1B0", Offset = "0x70BFB0", VA = "0x18070D1B0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public JBDCMIAKDNA BILKCPAKCDC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x7B1C70", Offset = "0x7B0A70", VA = "0x1807B1C70")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public JBDCMIAKDNA LOEOKPIOEJA
	{
		[Cpp2IlInjected.Token(Token = "0x60000AD")]
		[Cpp2IlInjected.Address(RVA = "0x702370", Offset = "0x701170", VA = "0x180702370")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public JBDCMIAKDNA FPMKMGLFADC
	{
		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x702430", Offset = "0x701230", VA = "0x180702430")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public IReadOnlyList<JBDCMIAKDNA> JABAAPKJCIB
	{
		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x7022F0", Offset = "0x7010F0", VA = "0x1807022F0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x6296680", Offset = "0x6295480", VA = "0x186296680")]
	public void GMNCFAEBCJF(VRIK ONKFLKPGIAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x20E6AD0", Offset = "0x20E58D0", VA = "0x1820E6AD0")]
	private void JKOFCEKGLOD(Transform HOKEJKCPCMA, ABFNKEDKEAE INOJNNAPINL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x6297250", Offset = "0x6296050", VA = "0x186297250")]
	public void MLHFGCNOPOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x20E4650", Offset = "0x20E3450", VA = "0x1820E4650")]
	public float EKNOEPNELFD(in (ABFNKEDKEAE Start, ABFNKEDKEAE End) GPDNEMDEFDI)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x6297070", Offset = "0x6295E70", VA = "0x186297070")]
	public void IFFIHHKDILN(in HGKNDDEFBNP NNMLCFCBKLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x6296530", Offset = "0x6295330", VA = "0x186296530")]
	private Vector3 AILDLLJJOBF(in (ABFNKEDKEAE Start, ABFNKEDKEAE End) GPDNEMDEFDI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x6297700", Offset = "0x6296500", VA = "0x186297700")]
	public JCNBDKPLFEC()
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class AvatarSystemConfiguration : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public GameObject AvatarPrefab;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public string AvatarIdentifierPrefix;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x62930F0", Offset = "0x6291EF0", VA = "0x1862930F0")]
		public string BLFFCNHBHLA(string ABGJHOKILCG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6293140", Offset = "0x6291F40", VA = "0x186293140")]
		public AvatarSystemConfiguration()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public struct CMDOJGPIIDC
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	public string NNGCDNCECEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	public bool GDLFOEKIHPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public bool DAANLAKOILA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public float HIIHANJAMCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public float FLOJABJBOGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public bool HEGFDJFOIML;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public RigidbodyEx EANDHKHAGCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public RigidbodyEx EIAGGHIBLEL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public RigidbodyEx BPGKKGPMKIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public RigidbodyEx BLADFCGPKPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public Transform HPDABMLKILK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FA")]
	public Transform PMKAIFAOPFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	public Transform HDAHLNANGLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	public PlayerAvatarFullBodyColliders AKKPMNOLBGA;
}
[Cpp2IlInjected.Token(Token = "0x2000026")]
public struct LCAAGMFOMIJ
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	public Transform KNHPOAAIDAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public Transform LCBLADKLIOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public AvatarConfiguration MFFKCBOGFNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public Animator KMKOECFEMLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public VRIK NNCBKHJNKCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public SkeletonLODUpdateRate[] LMNFKDEMBDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public GameObject[] GCMKBKBOKCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public Transform FEAMFAPCGBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public GameObject NHFFJLAFNEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public BodySkinnedMeshLODs DHMKGBCNDMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public BodySkinnedMeshLODs NBKGHPPKAOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public GameObject BHKLFAFMGPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public BodySkinnedMeshLODs GPAHHMOAJPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x68")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public BodySkinnedMeshLODs AOPBBFFGGKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public FBPJBNPHGKL FDJLEFNMBMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x78")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public Material FBFNHPFPHHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x80")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public Material APNFCCOLDDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x88")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public Shader IGGEDHKEOFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x90")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public Transform NJIEBFCBLFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public Transform HIJCHGHFHLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	public Transform NNNLLBMNBLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA8")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	public Transform BOLDAIDIGCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	public Transform AALPPCBFBEF;
}
[Cpp2IlInjected.Token(Token = "0x2000027")]
public struct HGKNDDEFBNP
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	public float GAOACEMGAFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	public bool DCCLKLOLNIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	public EHKPJAMPICF IBNGIGPIAOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	public Vector3 PJMMCGFNDLJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	public Vector3 NLCIDGIOIFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	public Vector3? PIDKCDJODGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	public Vector3? LAFACHONBBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	public bool IDMPGKKPPIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x45")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	public bool AJHIKDGNKOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x46")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	public bool HILAPHMDNPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x47")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	public bool JIBEGFPNDLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400011F")]
	public bool KEFPOELIAPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4C")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	public Vector3? KBDILDGHCCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x5C")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	public bool JFCJOHECMNM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x60")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	public Vector3? DHCMMNAKNGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x70")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	public bool OIINJHMOKEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x74")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	public Vector3? FHKACHPIFHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x84")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	public Vector3? HGKKCMHEHLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x94")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	public bool IGAJBIBHJMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x95")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	public bool GDFABPFLCCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x96")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public bool APFFAIMIDEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x97")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public bool DNAGOCHFKJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x98")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public bool MICBJFKBMFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x99")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public bool IIAOOGEHBJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9A")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public bool LEDLIOGDMAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9B")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public bool GDGNEMNKFOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9C")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public bool NKEKAKIMDBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x9D")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public bool DNGOAPGCAEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0xA0")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public Vector3? LDFJKDNNAOM;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB0")]
	[Cpp2IlInjected.Token(Token = "0x4000131")]
	public KJIGIBBNMEG MNLIEGDJOOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB4")]
	[Cpp2IlInjected.Token(Token = "0x4000132")]
	public KJIGIBBNMEG BNEICCIOKKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0xB8")]
	[Cpp2IlInjected.Token(Token = "0x4000133")]
	public float GIBPBJENHPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0xBC")]
	[Cpp2IlInjected.Token(Token = "0x4000134")]
	public float IEPGPMAJDPE;
}
[Cpp2IlInjected.Token(Token = "0x2000028")]
public interface HDLDGIJNMJJ
{
	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void ANPMDGCDMGA();

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	global::HBCJHPKGFFI<Texture2D> ECCPCFCFECB(EDNGKBLCIND KCJODFKAPCG, [Optional] EPCIPEABDCI FGGPHJMDLJN);
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
public class GFFHNPPKHPI : HDLDGIJNMJJ, IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000135")]
	private BPKJPGENALE OOPDENAFBGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000136")]
	private IRecRoomQualityConfigProvider PIHFPICHOLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000137")]
	private bool HOBJIPKIODG;

	[Cpp2IlInjected.Token(Token = "0x4000138")]
	private const uint IHGOGENOPKN = 16u;

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x6296390", Offset = "0x6295190", VA = "0x186296390")]
	[NPBDMCLHPNM(AIJEIIPHIJH.None)]
	private static void GNNMKHGNMNO(HKDBAIGILEN DHPFLPHCDGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	[Preserve]
	public GFFHNPPKHPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x6ED320", Offset = "0x6EC120", VA = "0x1806ED320", Slot = "6")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x6296480", Offset = "0x6295280", VA = "0x186296480")]
	private void HPJOFBKKDJM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x6295D10", Offset = "0x6294B10", VA = "0x186295D10", Slot = "4")]
	public void ANPMDGCDMGA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x6295F80", Offset = "0x6294D80", VA = "0x186295F80", Slot = "5")]
	public global::HBCJHPKGFFI<Texture2D> ECCPCFCFECB(EDNGKBLCIND KCJODFKAPCG, [Optional] EPCIPEABDCI FGGPHJMDLJN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x6295D70", Offset = "0x6294B70", VA = "0x186295D70")]
	private uint DFADHNEHKOO(EDNGKBLCIND KCJODFKAPCG, EPCIPEABDCI FGGPHJMDLJN)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public enum PACKADBPBBM
{
	[Cpp2IlInjected.Token(Token = "0x400013C")]
	NeverObscured,
	[Cpp2IlInjected.Token(Token = "0x400013D")]
	AlwaysObscured,
	[Cpp2IlInjected.Token(Token = "0x400013E")]
	PrivateObscured
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class EPCIPEABDCI
{
	[Cpp2IlInjected.Token(Token = "0x4000141")]
	public static readonly EPCIPEABDCI LKPPHHDONBO;

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public int HDAKKEHMEOF
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x6DA060", Offset = "0x6D8E60", VA = "0x1806DA060")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x768440", Offset = "0x767240", VA = "0x180768440")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public PACKADBPBBM OADAPELIACI
	{
		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x768420", Offset = "0x767220", VA = "0x180768420")]
		[CompilerGenerated]
		get
		{
			return default(PACKADBPBBM);
		}
		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x768430", Offset = "0x767230", VA = "0x180768430")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public EPCIPEABDCI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x6293AF0", Offset = "0x62928F0", VA = "0x186293AF0")]
	public EPCIPEABDCI(PACKADBPBBM FOMLKLNHMAJ, int KHPIBEBCDDI)
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
		[Cpp2IlInjected.Token(Token = "0x4000142")]
		private readonly Vector2 UV_CENTER_COORDINATE;

		[Cpp2IlInjected.Token(Token = "0x4000143")]
		public static readonly Vector3 DEFAULT_HEMISPHERE_FITMESH_PIVOT_POSITION;

		[Cpp2IlInjected.Token(Token = "0x4000144")]
		public static readonly Quaternion DEFAULT_HEMISPHERE_FITMESH_PIVOT_ROTATION;

		[Cpp2IlInjected.Token(Token = "0x4000145")]
		public static readonly Vector3 DEFAULT_HEMISPHERE_FITMESH_PIVOT_SCALE;

		[Cpp2IlInjected.Token(Token = "0x4000146")]
		public static readonly FitMeshHemisphere Default;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000147")]
		[SerializeField]
		public Vector3 hemispherePosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x4000148")]
		[SerializeField]
		public Quaternion hemisphereRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000149")]
		[SerializeField]
		public Vector3 hemisphereScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		[SerializeField]
		public float radius;

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public bool IsRadiusValid
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x6295D00", Offset = "0x6294B00", VA = "0x186295D00")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x6295C40", Offset = "0x6294A40", VA = "0x186295C40")]
		public FitMeshHemisphere()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x62957C0", Offset = "0x62945C0", VA = "0x1862957C0")]
		public void IMJCNNIDJOD(FitMeshHemisphere AFABNKFLJGP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x6295440", Offset = "0x6294240", VA = "0x186295440")]
		public Vector3 BGMFPGNCPNL(Vector2 HNKLBLGEGJE, bool HDELOELPIIN = true)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x6295A50", Offset = "0x6294850", VA = "0x186295A50")]
		public Vector3 PJJCGKOJKLI(Vector2 HNKLBLGEGJE)
		{
			return default(Vector3);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x6295810", Offset = "0x6294610", VA = "0x186295810")]
		public Quaternion ONLMIIMONML(Vector2 HNKLBLGEGJE)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x6295940", Offset = "0x6294740", VA = "0x186295940")]
		public Quaternion ONLMIIMONML(Vector2 HNKLBLGEGJE, Vector3 DBABEEJGKOI)
		{
			return default(Quaternion);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x6295780", Offset = "0x6294580", VA = "0x186295780")]
		private Vector2 IAGHOJFIOJL(Vector2 OMALAOHGLNK)
		{
			return default(Vector2);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public struct CDKDONKALNI
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400014B")]
	public readonly GameObject HOINENKKNNN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x400014C")]
	public readonly AvatarItemMaterial LGJPBJEPHBK;

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x9333E0", Offset = "0x9321E0", VA = "0x1809333E0")]
	public CDKDONKALNI(GameObject HOINENKKNNN, AvatarItemMaterial LGJPBJEPHBK)
	{
	}
}
namespace RecRoom.Avatars
{
	[Cpp2IlInjected.Token(Token = "0x200002F")]
	public enum OutfitType
	{
		[Cpp2IlInjected.Token(Token = "0x400014E")]
		None = -1,
		[Cpp2IlInjected.Token(Token = "0x400014F")]
		Hat = 0,
		[Cpp2IlInjected.Token(Token = "0x4000150")]
		Hair = 2,
		[Cpp2IlInjected.Token(Token = "0x4000151")]
		Ear = 3,
		[Cpp2IlInjected.Token(Token = "0x4000152")]
		Eye = 10,
		[Cpp2IlInjected.Token(Token = "0x4000153")]
		Beard = 20,
		[Cpp2IlInjected.Token(Token = "0x4000154")]
		Shoulder = 100,
		[Cpp2IlInjected.Token(Token = "0x4000155")]
		Shirt = 101,
		[Cpp2IlInjected.Token(Token = "0x4000156")]
		Waist = 102,
		[Cpp2IlInjected.Token(Token = "0x4000157")]
		Neck = 103,
		[Cpp2IlInjected.Token(Token = "0x4000158")]
		TeamJersey = 104,
		[Cpp2IlInjected.Token(Token = "0x4000159")]
		CustomShirt = 105,
		[Cpp2IlInjected.Token(Token = "0x400015A")]
		Wrist = 200,
		[Cpp2IlInjected.Token(Token = "0x400015B")]
		TeamWrist = 203,
		[Cpp2IlInjected.Token(Token = "0x400015C")]
		Legs = 300,
		[Cpp2IlInjected.Token(Token = "0x400015D")]
		Feet = 301
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public static class FPPKMDPLMAN
{
	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x6294440", Offset = "0x6293240", VA = "0x186294440")]
	public static bool ACLBCGGBCNC(this OutfitType OPANFECCMDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x62944A0", Offset = "0x62932A0", VA = "0x1862944A0")]
	public static bool PCLGOCGOBAD(this OutfitType OPANFECCMDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x6294490", Offset = "0x6293290", VA = "0x186294490")]
	public static bool PBHDCDJNMPC(this OutfitType OPANFECCMDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x6294480", Offset = "0x6293280", VA = "0x186294480")]
	public static bool ODMDIBCLNJD(this OutfitType OPANFECCMDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x6294470", Offset = "0x6293270", VA = "0x186294470")]
	public static bool MCPHOBKFDJD(this OutfitType OPANFECCMDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x6294460", Offset = "0x6293260", VA = "0x186294460")]
	public static bool HFJBBOFOHAA(this OutfitType OPANFECCMDH)
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
		[Cpp2IlInjected.Token(Token = "0x400015E")]
		private FBPJBNPHGKL FHDMJLJGELN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400015F")]
		private Collider[] PDNMMFIEGPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000160")]
		[SerializeField]
		private GameObject RootGameObject;

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		private Collider[] GJCHIIHKFKN
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x6299CD0", Offset = "0x6298AD0", VA = "0x186299CD0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x6299C50", Offset = "0x6298A50", VA = "0x186299C50")]
		private void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x6299E90", Offset = "0x6298C90", VA = "0x186299E90")]
		public void UpdateBones(FBPJBNPHGKL ONJBEMCKHHO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x6299D40", Offset = "0x6298B40", VA = "0x186299D40")]
		public void SetCollidersEnabled(bool INLFOKCKKHD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x6299EC0", Offset = "0x6298CC0", VA = "0x186299EC0")]
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
		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x60000E1")]
			[Cpp2IlInjected.Address(RVA = "0x7F1200", Offset = "0x7F0000", VA = "0x1807F1200", Slot = "4")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6293190", Offset = "0x6291F90", VA = "0x186293190")]
		public BrowsFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000033")]
	public sealed class EyesFaceFeature : SymmetricalFaceFeature
	{
		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x60000E3")]
			[Cpp2IlInjected.Address(RVA = "0x70F8D0", Offset = "0x70E6D0", VA = "0x18070F8D0", Slot = "4")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6293190", Offset = "0x6291F90", VA = "0x186293190")]
		public EyesFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public abstract class FaceFeature : FaceFeatureBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000161")]
		public Vector2 DefaultAnchor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x4000162")]
		public Vector2 MaxJitterAnchor;

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public Vector2 JitteredAnchor
		{
			[Cpp2IlInjected.Token(Token = "0x60000E5")]
			[Cpp2IlInjected.Address(RVA = "0x62947E0", Offset = "0x62935E0", VA = "0x1862947E0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E6")]
			[Cpp2IlInjected.Address(RVA = "0xA89E00", Offset = "0xA88C00", VA = "0x180A89E00")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public Vector2 JitteredOffset
		{
			[Cpp2IlInjected.Token(Token = "0x60000E7")]
			[Cpp2IlInjected.Address(RVA = "0x9B51E0", Offset = "0x9B3FE0", VA = "0x1809B51E0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000E8")]
			[Cpp2IlInjected.Address(RVA = "0x9B5310", Offset = "0x9B4110", VA = "0x1809B5310")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x62946B0", Offset = "0x62934B0", VA = "0x1862946B0", Slot = "5")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x6294760", Offset = "0x6293560", VA = "0x186294760")]
		protected FaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public abstract class FaceFeatureBase : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x4000165")]
		private const bool HIGH_QUALTIY_COMPRESS = true;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000166")]
		[SerializeField]
		[Tooltip("This guid is auto generated at the time of the asset creation and should never change if you do not want to break an existing player's feature selection")]
		private string GuidString;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000167")]
		[SerializeField]
		private Sprite[] Sprites;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000168")]
		[SerializeField]
		private Sprite menuButtonSprite;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000169")]
		public Vector2 DefaultScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x400016A")]
		public Vector2 MaxJitterScale;

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public string Guid
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000072")]
		public IEnumerable<Sprite> SrcSprites
		{
			[Cpp2IlInjected.Token(Token = "0x60000EC")]
			[Cpp2IlInjected.Address(RVA = "0x6FA130", Offset = "0x6F8F30", VA = "0x1806FA130")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000073")]
		public Sprite MenuButtonSprite
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x6FA2D0", Offset = "0x6F90D0", VA = "0x1806FA2D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000074")]
		public int TextureCount
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x6294690", Offset = "0x6293490", VA = "0x186294690")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000075")]
		public abstract FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(Slot = "4")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public Vector2 JitteredScale
		{
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x46B2DD0", Offset = "0x46B1BD0", VA = "0x1846B2DD0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F1")]
			[Cpp2IlInjected.Address(RVA = "0xB55BA0", Offset = "0xB549A0", VA = "0x180B55BA0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x62944C0", Offset = "0x62932C0", VA = "0x1862944C0")]
		protected static Vector2 JitteredVector2(Vector2 initial, Vector2 maxJitter)
		{
			return default(Vector2);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x6294530", Offset = "0x6293330", VA = "0x186294530", Slot = "5")]
		public virtual void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x62945B0", Offset = "0x62933B0", VA = "0x1862945B0")]
		protected FaceFeatureBase()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public sealed class MDFDPJNMINN : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	private class FJIELJEINNE : IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000173")]
		public readonly Texture2DArray LAJMJHPAMIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000174")]
		public readonly Dictionary<string, int> DJKPFOHAHNH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000175")]
		private readonly JGIJICGALKO ODBPNAIDADF;

		[Cpp2IlInjected.Token(Token = "0x1700007C")]
		public bool FAEEDKODDDK
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x1C770E0", Offset = "0x1C75EE0", VA = "0x181C770E0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x6294370", Offset = "0x6293170", VA = "0x186294370")]
		public FJIELJEINNE(Texture2DArray AMACLPPHCGI, Dictionary<string, int> JDGPEDPPEHI, MDFDPJNMINN NFNHFOGGPDG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x139B850", Offset = "0x139A650", VA = "0x18139B850")]
		public void IOKPBEIOPCP(MDFDPJNMINN INDCJAMMAIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x139BED0", Offset = "0x139ACD0", VA = "0x18139BED0")]
		public void OGAIKCNJBIB(MDFDPJNMINN INDCJAMMAIN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x184A9B0", Offset = "0x18497B0", VA = "0x18184A9B0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	private struct EFFBDAEHNAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000176")]
		private readonly string DBNEHKGPADA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000177")]
		private readonly string OEGJCKCAPDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000178")]
		private readonly string HIGNKBCGLFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000179")]
		private readonly string EKAHPOMLPAB;

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x5CE3C10", Offset = "0x5CE2A10", VA = "0x185CE3C10")]
		public EFFBDAEHNAF(string CLJDEBCAHIP, string KBJODBBMAPG, string IJFIPCLPLNH, string EIPIPFPINJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x6293950", Offset = "0x6292750", VA = "0x186293950")]
		public bool MIHMMJHONAF(EFFBDAEHNAF ONICAEEHHFG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x62937A0", Offset = "0x62925A0", VA = "0x1862937A0", Slot = "0")]
		public override bool Equals(object BLIKPCIFNNO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x6293880", Offset = "0x6292680", VA = "0x186293880", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x6293950", Offset = "0x6292750", VA = "0x186293950")]
		public static bool LHMNPGMNIAC(EFFBDAEHNAF DLPBMGJADDE, EFFBDAEHNAF IKFDOKNMJKG)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x62939E0", Offset = "0x62927E0", VA = "0x1862939E0")]
		public static bool NGBHPPLJJAJ(EFFBDAEHNAF DLPBMGJADDE, EFFBDAEHNAF IKFDOKNMJKG)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x400016C")]
	private readonly Dictionary<string, int> JDGPEDPPEHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000172")]
	private readonly EFFBDAEHNAF FFHNNDENNPL;

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public Texture2DArray APDENJODIPO
	{
		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x6FA140", Offset = "0x6F8F40", VA = "0x1806FA140")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x701A00", Offset = "0x700800", VA = "0x180701A00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public SymmetricalFaceFeature MGNMADLGHBG
	{
		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6FA130", Offset = "0x6F8F30", VA = "0x1806FA130")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x71C2B0", Offset = "0x71B0B0", VA = "0x18071C2B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public SymmetricalFaceFeature KNENPIJAFFI
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6FA2D0", Offset = "0x6F90D0", VA = "0x1806FA2D0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x765100", Offset = "0x763F00", VA = "0x180765100")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public SymmetricalFaceFeature BFIMGEIOBDD
	{
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x718560", Offset = "0x717360", VA = "0x180718560")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x7650F0", Offset = "0x763EF0", VA = "0x1807650F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public FaceFeature HHKKAAOILPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x6F6E70", Offset = "0x6F5C70", VA = "0x1806F6E70")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x6F7830", Offset = "0x6F6630", VA = "0x1806F7830")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x6298E50", Offset = "0x6297C50", VA = "0x186298E50")]
	private static void EFKOAANNIDJ(Sprite MHJCPNOJIKI, Sprite NKFNEHPEDCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x6298F50", Offset = "0x6297D50", VA = "0x186298F50")]
	private static void HPOLMHHDOHG(Sprite LGMEBJLMMGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000101")]
	[Cpp2IlInjected.Address(RVA = "0x6298FC0", Offset = "0x6297DC0", VA = "0x186298FC0")]
	public MDFDPJNMINN(SymmetricalFaceFeature NKGFCKMOLEN, FaceFeature PAHODABJNMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000102")]
	[Cpp2IlInjected.Address(RVA = "0x6298FF0", Offset = "0x6297DF0", VA = "0x186298FF0")]
	public MDFDPJNMINN(SymmetricalFaceFeature MFCDGFGCBED, SymmetricalFaceFeature NKGFCKMOLEN, SymmetricalFaceFeature CMGEAHALCPN, FaceFeature PAHODABJNMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000103")]
	[Cpp2IlInjected.Address(RVA = "0x6298C30", Offset = "0x6297A30", VA = "0x186298C30")]
	public bool AOEHBPPNAEE(Sprite LGMEBJLMMGC, out int CPOAAGLEIPE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000104")]
	[Cpp2IlInjected.Address(RVA = "0x6298E40", Offset = "0x6297C40", VA = "0x186298E40", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.Avatars.Face
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public enum FaceFeatureType
	{
		[Cpp2IlInjected.Token(Token = "0x400017D")]
		Eye = 0,
		[Cpp2IlInjected.Token(Token = "0x400017E")]
		Mouth = 1,
		[Cpp2IlInjected.Token(Token = "0x400017F")]
		Nose = 2,
		[Cpp2IlInjected.Token(Token = "0x4000180")]
		Brows = 3,
		[Cpp2IlInjected.Token(Token = "0x4000181")]
		EyeGleams = 4,
		[Cpp2IlInjected.Token(Token = "0x4000182")]
		Other = 10
	}
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	public sealed class FaceStyleSet : ScriptableObject
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000183")]
		public SymmetricalFaceFeature[] EyeBrows;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000184")]
		public SymmetricalFaceFeature[] Eyes;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000185")]
		public SymmetricalFaceFeature[] EyeGleams;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000186")]
		public FaceFeature[] Mouths;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000187")]
		private Dictionary<string, SymmetricalFaceFeature> eyeBrowFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000188")]
		private Dictionary<string, SymmetricalFaceFeature> eyeFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x4000189")]
		private Dictionary<string, SymmetricalFaceFeature> eyeGleamFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400018A")]
		private Dictionary<string, FaceFeature> mouthFeatureDictionary;

		[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
		[Cpp2IlInjected.Token(Token = "0x400018B")]
		private Dictionary<string, int> featureToIndexMap;

		[Cpp2IlInjected.Token(Token = "0x1700007D")]
		private bool dictionariesInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000113")]
			[Cpp2IlInjected.Address(RVA = "0x6295410", Offset = "0x6294210", VA = "0x186295410")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x6295060", Offset = "0x6293E60", VA = "0x186295060")]
		public MDFDPJNMINN PEIACLNJANM(int NKGFCKMOLEN, int PAHODABJNMJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x6294DE0", Offset = "0x6293BE0", VA = "0x186294DE0")]
		public MDFDPJNMINN PEIACLNJANM(int GLLMJHNKCGM, int NKGFCKMOLEN, int EGLDPOEADKM, int PAHODABJNMJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x6294AD0", Offset = "0x62938D0", VA = "0x186294AD0")]
		public FaceFeatureBase IFEJNABLEAA(FaceFeatureType HFOJGPGEBBL, string LAJNKLHJFND)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x6295300", Offset = "0x6294100", VA = "0x186295300")]
		public int POFGOIKMEKI(string LAJNKLHJFND)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x6294800", Offset = "0x6293600", VA = "0x186294800")]
		private void EBACKDGCKOG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x2285330", Offset = "0x2284130", VA = "0x182285330")]
		private void CDNJHABPPDB<T>(Dictionary<string, T> PHBGHHDKNIF, T[] FIELPEIALJH) where T : FaceFeatureBase
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x62949E0", Offset = "0x62937E0", VA = "0x1862949E0")]
		public string FHDDJOPENEE(FaceFeatureType HFOJGPGEBBL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x6294C60", Offset = "0x6293A60", VA = "0x186294C60")]
		public string OFBDJOKFKAL(FaceFeatureType HFOJGPGEBBL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x6295390", Offset = "0x6294190", VA = "0x186295390")]
		public FaceStyleSet()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public sealed class MouthFaceFeature : FaceFeature
	{
		[Cpp2IlInjected.Token(Token = "0x1700007E")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x600011D")]
			[Cpp2IlInjected.Address(RVA = "0x7FC980", Offset = "0x7FB780", VA = "0x1807FC980", Slot = "4")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x6299C40", Offset = "0x6298A40", VA = "0x186299C40")]
		public MouthFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	public sealed class NoseFaceFeature : FaceFeature
	{
		[Cpp2IlInjected.Token(Token = "0x1700007F")]
		public override FaceFeatureType FaceFeatureType
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x7F1210", Offset = "0x7F0010", VA = "0x1807F1210", Slot = "4")]
			get
			{
				return default(FaceFeatureType);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x6299C40", Offset = "0x6298A40", VA = "0x186299C40")]
		public NoseFaceFeature()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public abstract class SymmetricalFaceFeature : FaceFeatureBase
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
		[Cpp2IlInjected.Token(Token = "0x400018C")]
		public Vector2 MaxJitterAnchors;

		[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
		[Cpp2IlInjected.Token(Token = "0x400018D")]
		public bool JitterSymetrically;

		[Cpp2IlInjected.FieldOffset(Offset = "0x54")]
		[Cpp2IlInjected.Token(Token = "0x400018E")]
		public Vector2 DefaultAnchorLeft;

		[Cpp2IlInjected.FieldOffset(Offset = "0x6C")]
		[Cpp2IlInjected.Token(Token = "0x4000191")]
		public Vector2 DefaultAnchorRight;

		[Cpp2IlInjected.Token(Token = "0x17000080")]
		public Vector2 JitteredAnchorLeft
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x629A120", Offset = "0x6298F20", VA = "0x18629A120")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000122")]
			[Cpp2IlInjected.Address(RVA = "0xC0C000", Offset = "0xC0AE00", VA = "0x180C0C000")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000081")]
		public Vector2 JitteredOffsetLeft
		{
			[Cpp2IlInjected.Token(Token = "0x6000123")]
			[Cpp2IlInjected.Address(RVA = "0x1959010", Offset = "0x1957E10", VA = "0x181959010")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000124")]
			[Cpp2IlInjected.Address(RVA = "0xC0BFE0", Offset = "0xC0ADE0", VA = "0x180C0BFE0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000082")]
		public Vector2 JitteredAnchorRight
		{
			[Cpp2IlInjected.Token(Token = "0x6000125")]
			[Cpp2IlInjected.Address(RVA = "0x1958FF0", Offset = "0x1957DF0", VA = "0x181958FF0")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000126")]
			[Cpp2IlInjected.Address(RVA = "0x9B5300", Offset = "0x9B4100", VA = "0x1809B5300")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000083")]
		public Vector2 JitteredOffsetRight
		{
			[Cpp2IlInjected.Token(Token = "0x6000127")]
			[Cpp2IlInjected.Address(RVA = "0x1958F70", Offset = "0x1957D70", VA = "0x181958F70")]
			[CompilerGenerated]
			get
			{
				return default(Vector2);
			}
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x629A140", Offset = "0x6298F40", VA = "0x18629A140")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000129")]
		[Cpp2IlInjected.Address(RVA = "0x629A010", Offset = "0x6298E10", VA = "0x18629A010", Slot = "5")]
		public override void NewJitter()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x6293190", Offset = "0x6291F90", VA = "0x186293190")]
		protected SymmetricalFaceFeature()
		{
		}
	}
}
[StructLayout((LayoutKind)3, CharSet = CharSet.Auto)]
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class KNPJDABNJNB
{
	[Cpp2IlInjected.Token(Token = "0x4000194")]
	private static byte[] KJPEJCPNACN;

	[Cpp2IlInjected.Token(Token = "0x4000195")]
	private static int ENGDLONOMNK;

	[Cpp2IlInjected.Token(Token = "0x4000196")]
	private static int IBOHBKOLMLK;

	[Cpp2IlInjected.Token(Token = "0x4000197")]
	private static BigInteger BMOFNNOLMPE;

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
	public KNPJDABNJNB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6297FC0", Offset = "0x6296DC0", VA = "0x186297FC0")]
	private static string NKHPLDDEAIA(byte[] MIECAKFJHNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x62980D0", Offset = "0x6296ED0", VA = "0x1862980D0")]
	public static string OEIELDLCBEJ(byte[] NJGGJPEFKKD, bool NCDJBNMKDFA)
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

		[Cpp2IlInjected.Token(Token = "0x4000198")]
		internal static $ArrayType$151 $$field-0;

		[Cpp2IlInjected.Token(Token = "0x600012F")]
		[Cpp2IlInjected.Address(RVA = "0x6ECCD0", Offset = "0x6EBAD0", VA = "0x1806ECCD0")]
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
