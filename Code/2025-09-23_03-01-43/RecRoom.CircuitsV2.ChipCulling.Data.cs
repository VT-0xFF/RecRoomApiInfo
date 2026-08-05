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
			[Cpp2IlInjected.Address(RVA = "0x83EFA50", Offset = "0x83EE050", VA = "0x1883EFA50")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public float ChipBoundsScaleFactor
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x2E13130", Offset = "0x2E11730", VA = "0x182E13130")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public float PortCutoffDistanceSq
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x83EFA60", Offset = "0x83EE060", VA = "0x1883EFA60")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public float PortTextCutoffDistanceSq
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x83EFA70", Offset = "0x83EE070", VA = "0x1883EFA70")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public float TitleTextCutoffDistanceSq
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x83EFA80", Offset = "0x83EE080", VA = "0x1883EFA80")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int MaxNormalResChips
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xBA16B0", Offset = "0xB9FCB0", VA = "0x180BA16B0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int TransformSyncBatches
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xAB04F0", Offset = "0xAAEAF0", VA = "0x180AB04F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int CullingBatches
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0xACF420", Offset = "0xACDA20", VA = "0x180ACF420")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int BufferSize
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xAFC970", Offset = "0xAFAF70", VA = "0x180AFC970")]
			get
			{
				return default(int);
			}
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[Flags]
public enum EAFKCCMJLGN
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
public static class PBGMFJDOOIK
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x7469290", Offset = "0x7467890", VA = "0x187469290")]
	public static bool JFHKHNNDHHF(this EAFKCCMJLGN JAPBIEJCCMN, EAFKCCMJLGN EOIHPGIPMNM)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x83EFD60", Offset = "0x83EE360", VA = "0x1883EFD60")]
	public static EAFKCCMJLGN GPMPBOBEHGA(this EAFKCCMJLGN JAPBIEJCCMN, EAFKCCMJLGN EOIHPGIPMNM)
	{
		return default(EAFKCCMJLGN);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x83EFD50", Offset = "0x83EE350", VA = "0x1883EFD50")]
	public static EAFKCCMJLGN CCOBOLLDOLE(this EAFKCCMJLGN JAPBIEJCCMN, EAFKCCMJLGN EOIHPGIPMNM)
	{
		return default(EAFKCCMJLGN);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct DKJMDNOADCM
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public float ACKHBEABDIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public float OOIDIJNGFGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public float COMDIKENGAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public float MANMGAKHMMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public float DMLLJLLADEH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public float KFCLCHBLPGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public float CCHAINOCNIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public float BJKJBGCAEIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public float KMKEFLHFMCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public float IOPDBKBOAEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public float FBOPDHAMAJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public float HDIOGJGJBGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public float LBAKLGBNACG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public float OKGJLBBIDPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public float CAINEDCFIKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public float BNLKDDOKLCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public float IFEAFNLONNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public float ALGOHPKDLHE;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x83EFA90", Offset = "0x83EE090", VA = "0x1883EFA90")]
	public static DKJMDNOADCM KEKOHAFGIHL(Camera GMAOCMBEHJO)
	{
		return default(DKJMDNOADCM);
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
