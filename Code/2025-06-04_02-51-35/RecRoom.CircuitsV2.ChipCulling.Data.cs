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
		public float MaxVisibleDistanceSq
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x7EA57F0", Offset = "0x7EA3FF0", VA = "0x187EA57F0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public float ChipBoundsScaleFactor
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x2B18B80", Offset = "0x2B17380", VA = "0x182B18B80")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public float PortCutoffDistanceSq
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x7EA5800", Offset = "0x7EA4000", VA = "0x187EA5800")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public float PortTextCutoffDistanceSq
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x7EA5810", Offset = "0x7EA4010", VA = "0x187EA5810")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public float TitleTextCutoffDistanceSq
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x7EA5820", Offset = "0x7EA4020", VA = "0x187EA5820")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int MaxNormalResChips
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA76460", Offset = "0xA74C60", VA = "0x180A76460")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int TransformSyncBatches
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xA32B80", Offset = "0xA31380", VA = "0x180A32B80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int CullingBatches
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xA513E0", Offset = "0xA4FBE0", VA = "0x180A513E0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int BufferSize
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xA8E7C0", Offset = "0xA8CFC0", VA = "0x180A8E7C0")]
			get
			{
				return default(int);
			}
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[Flags]
public enum PMADCGJBPPD
{
	[Cpp2IlInjected.Token(Token = "0x400000B")]
	Uninitialized = int.MinValue,
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
	All = int.MaxValue
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class OLOOMCCJGAF
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x6FCDE30", Offset = "0x6FCC630", VA = "0x186FCDE30")]
	public static bool BJDFCLKONOA(this PMADCGJBPPD OGJLEGMOFJE, PMADCGJBPPD DJCIBNCECGJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x7EA5AF0", Offset = "0x7EA42F0", VA = "0x187EA5AF0")]
	public static PMADCGJBPPD AIMOKPHOMFM(this PMADCGJBPPD OGJLEGMOFJE, PMADCGJBPPD DJCIBNCECGJ)
	{
		return default(PMADCGJBPPD);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7EA5B00", Offset = "0x7EA4300", VA = "0x187EA5B00")]
	public static PMADCGJBPPD BPPCPFGMMLB(this PMADCGJBPPD OGJLEGMOFJE, PMADCGJBPPD DJCIBNCECGJ)
	{
		return default(PMADCGJBPPD);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct MCJEMFABGGB
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public float GKIPMECCILC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public float PMIAOELMKIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public float HFJBIKAJFKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public float LFJIBCLBBGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public float DCJMJKHPPDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public float ALPDIIBGGPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public float LEOAJOANDLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public float GCPEPMICGMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public float EHEIJMBLMFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public float FGCPPIFOHBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public float FCHCBAFPHJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public float BHMFBEDFKNF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public float PFMPANHCHBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public float BIINCDIEMHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public float KMHCKGFPNGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public float KKDJAOHEMNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public float FHBLHJPFEGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public float AJLBFCAIPFI;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7EA5830", Offset = "0x7EA4030", VA = "0x187EA5830")]
	public static MCJEMFABGGB EAPDPOAKJPH(Camera LAMNAKLBEAK)
	{
		return default(MCJEMFABGGB);
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
