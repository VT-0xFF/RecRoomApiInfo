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
		public float YIOTHBIBEPO
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x837A0B0", Offset = "0x8378EB0", VA = "0x18837A0B0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public float QHGUGYTBPFH
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x2DC5AE0", Offset = "0x2DC48E0", VA = "0x182DC5AE0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public float MQUSCPJGNDM
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x837A0C0", Offset = "0x8378EC0", VA = "0x18837A0C0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public float XKLHGRFVBSF
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x837A0E0", Offset = "0x8378EE0", VA = "0x18837A0E0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000005")]
		public float GHEPBORKPMS
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x837A0D0", Offset = "0x8378ED0", VA = "0x18837A0D0")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000006")]
		public int BERJCPCPBER
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xC1BCE0", Offset = "0xC1AAE0", VA = "0x180C1BCE0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000007")]
		public int ZTNUASYMDEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000007")]
			[Cpp2IlInjected.Address(RVA = "0xA9ED10", Offset = "0xA9DB10", VA = "0x180A9ED10")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		public int QORMDVGZXKT
		{
			[Cpp2IlInjected.Token(Token = "0x6000008")]
			[Cpp2IlInjected.Address(RVA = "0x1664390", Offset = "0x1663190", VA = "0x181664390")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		public int CYRFAIQVDPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000009")]
			[Cpp2IlInjected.Address(RVA = "0xAAF580", Offset = "0xAAE380", VA = "0x180AAF580")]
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
	public static class CQYZIPYSJSK
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x746E360", Offset = "0x746D160", VA = "0x18746E360")]
		public static bool Has(this ChipVisibilitySettings superset, ChipVisibilitySettings subset)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x837A0A0", Offset = "0x8378EA0", VA = "0x18837A0A0")]
		public static ChipVisibilitySettings FCQOBSETTRZ(this ChipVisibilitySettings a, ChipVisibilitySettings b)
		{
			return default(ChipVisibilitySettings);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x837A090", Offset = "0x8378E90", VA = "0x18837A090")]
		public static ChipVisibilitySettings CQLXEWWMTBD(this ChipVisibilitySettings a, ChipVisibilitySettings b)
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
		[Cpp2IlInjected.Address(RVA = "0x837A0F0", Offset = "0x8378EF0", VA = "0x18837A0F0")]
		public static CullingCameraInfo UZLXEASRHJY(Camera a)
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
