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
			[Cpp2IlInjected.Address(RVA = "0x6A8C320", Offset = "0x6A8A920", VA = "0x186A8C320")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public float ChipBoundsScaleFactor
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x22B84B0", Offset = "0x22B6AB0", VA = "0x1822B84B0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public float PortCutoffDistanceSq
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x6A8C330", Offset = "0x6A8A930", VA = "0x186A8C330")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public float PortTextCutoffDistanceSq
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x6A8C340", Offset = "0x6A8A940", VA = "0x186A8C340")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public float TitleTextCutoffDistanceSq
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x6A8C350", Offset = "0x6A8A950", VA = "0x186A8C350")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int MaxNormalResChips
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0x9023F0", Offset = "0x9009F0", VA = "0x1809023F0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int TransformSyncBatches
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0x88D660", Offset = "0x88BC60", VA = "0x18088D660")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int CullingBatches
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x8ADCB0", Offset = "0x8AC2B0", VA = "0x1808ADCB0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int BufferSize
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0x8F5280", Offset = "0x8F3880", VA = "0x1808F5280")]
			get
			{
				return default(int);
			}
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
[Flags]
public enum MNKCDAMFOED
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
public static class JIHPKGGFBDD
{
	[Cpp2IlInjected.Token(Token = "0x600000A")]
	[Cpp2IlInjected.Address(RVA = "0x5D63E80", Offset = "0x5D62480", VA = "0x185D63E80")]
	public static bool PADOCPINEPM(this MNKCDAMFOED MPINGDBLLNO, MNKCDAMFOED HCPMBPNFNAB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(RVA = "0x6A13AD0", Offset = "0x6A120D0", VA = "0x186A13AD0")]
	public static MNKCDAMFOED HNFLNJBDOKM(this MNKCDAMFOED MPINGDBLLNO, MNKCDAMFOED HCPMBPNFNAB)
	{
		return default(MNKCDAMFOED);
	}

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x6A13A50", Offset = "0x6A12050", VA = "0x186A13A50")]
	public static MNKCDAMFOED IDNIPDJJPID(this MNKCDAMFOED MPINGDBLLNO, MNKCDAMFOED HCPMBPNFNAB)
	{
		return default(MNKCDAMFOED);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public struct LBNBGBEKNAN
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	public float DGHGGDIAFEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x4")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public float FDBLBANFMMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x8")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public float GPCLGFMMCGC;

	[Cpp2IlInjected.FieldOffset(Offset = "0xC")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	public float DNNIMPDIKDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	public float BEKMDECHBKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	public float BFBLAMJFFLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	public float NDHJGNPANDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x400001C")]
	public float OKMCLGGFCDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400001D")]
	public float CILEIANOGLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x24")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public float LGFLFJAPBMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public float NNCHHHONPBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public float ABBOOMILDHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public float DJKFOGBEAEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x34")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public float MFLCANKFBOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	public float ENADLFJNHAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x3C")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public float DCDAEBIAFKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public float MJDIKOMNNHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public float DKCOFLKBNIP;

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x6A8C360", Offset = "0x6A8A960", VA = "0x186A8C360")]
	public static LBNBGBEKNAN BBCHGKFPPLN(Camera ICLEFGOOMHE)
	{
		return default(LBNBGBEKNAN);
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
