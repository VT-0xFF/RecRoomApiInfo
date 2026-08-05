using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.CircuitsV2.ChipCulling.Data
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public struct ChipVisibilityConfig
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private float maxVisibleDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private float chipBoundsScaleFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[SerializeField]
		private float portCutoffDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[SerializeField]
		private float portTextCutoffDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		[SerializeField]
		private float titleTextCutoffDistance;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		[SerializeField]
		private int maxNormalResChips;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		[SerializeField]
		private int transformSyncBatches;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		private int cullingBatches;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		[SerializeField]
		private int bufferSize;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public float JPDCMTKSMTY
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x88E7250", Offset = "0x88E5E50", VA = "0x1888E7250")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public float DOAFIJKQXAX
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x3083020", Offset = "0x3081C20", VA = "0x183083020")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public float DQADWBJBRZG
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x88E7240", Offset = "0x88E5E40", VA = "0x1888E7240")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public float NFXYRYIHNGD
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x88E7230", Offset = "0x88E5E30", VA = "0x1888E7230")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public float FUZPPFRFXIU
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x88E7220", Offset = "0x88E5E20", VA = "0x1888E7220")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int HBNDPLTBQJR
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xB69740", Offset = "0xB68340", VA = "0x180B69740")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int ILNOUVQZUHS
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xB1D780", Offset = "0xB1C380", VA = "0x180B1D780")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int DRTRPTRPTXX
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x16E6ED0", Offset = "0x16E5AD0", VA = "0x1816E6ED0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int ZQATCOJOSOW
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xB256B0", Offset = "0xB242B0", VA = "0x180B256B0")]
			get
			{
				return default(int);
			}
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Flags]
	public enum ChipVisibilitySettings
	{
		[Cpp2IlInjected.Token(Token = "0x400000B")]
		Uninitialized = -2147483648,
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		None = 0,
		[Cpp2IlInjected.Token(Token = "0x400000D")]
		Visible = 1,
		[Cpp2IlInjected.Token(Token = "0x400000E")]
		NormalRes = 2,
		[Cpp2IlInjected.Token(Token = "0x400000F")]
		PortsVisible = 4,
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		PortTextVisible = 8,
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		TitleTextVisible = 0x10,
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		SpriteVisible = 0x20,
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		CollidersEnabled = 0x40,
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		All = 0x7FFFFFFF
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	public static class NYJCECTVCUM
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x7A091A0", Offset = "0x7A07DA0", VA = "0x187A091A0")]
		public static bool Has(this ChipVisibilitySettings superset, ChipVisibilitySettings subset)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x88E7530", Offset = "0x88E6130", VA = "0x1888E7530")]
		public static ChipVisibilitySettings JOTYZSVQKJX(this ChipVisibilitySettings a, ChipVisibilitySettings b)
		{
			return default(ChipVisibilitySettings);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x88E7520", Offset = "0x88E6120", VA = "0x1888E7520")]
		public static ChipVisibilitySettings GATDNHVFLWT(this ChipVisibilitySettings a, ChipVisibilitySettings b)
		{
			return default(ChipVisibilitySettings);
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000005")]
	public struct CullingCameraInfo
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		public float positionX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
		[Cpp2IlInjected.Token(Token = "0x4000016")]
		public float positionY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public float positionZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public float forwardX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public float forwardY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public float forwardZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public float upX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public float upY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public float upZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
		[Cpp2IlInjected.Token(Token = "0x400001E")]
		public float rightX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x400001F")]
		public float rightY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000020")]
		public float rightZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000021")]
		public float farDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public float nearDist;

		[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public float yFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
		[Cpp2IlInjected.Token(Token = "0x4000024")]
		public float heightFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public float xFactor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public float ratio;

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x88E7260", Offset = "0x88E5E60", VA = "0x1888E7260")]
		public static CullingCameraInfo TVOGHKOYEIM(Camera a)
		{
			return default(CullingCameraInfo);
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
