using System;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.Foundation.Networking.DataTypes
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public struct ViewId : IEquatable<ViewId>
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public const int MAX_VIEW_IDS = 100000;

		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public const int MAX_PLAYER_IDS = 10000;

		[Cpp2IlInjected.Token(Token = "0x4000003")]
		public const int MAX_VIEW_SUB_IDS = 50000;

		[Cpp2IlInjected.Token(Token = "0x4000004")]
		public const int DONT_DESTROY_ON_LEAVE_FLAG = 50000;

		[Cpp2IlInjected.Token(Token = "0x4000005")]
		public const int RUNTIME_INSTANTIATE_VIEW_ID_OFFSET = 90000;

		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public const int COMPILE_TIME_MAIN_ROOT_ID_OFFSET = 89000;

		[Cpp2IlInjected.Token(Token = "0x4000007")]
		public static readonly ViewId Invalid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		[SerializeField]
		private int id;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public readonly int RawId
		{
			[Cpp2IlInjected.Token(Token = "0x6000001")]
			[Cpp2IlInjected.Address(RVA = "0x919B20", Offset = "0x918F20", VA = "0x180919B20")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int ActorNumber
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x61C0640", Offset = "0x61BFA40", VA = "0x1861C0640")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool DestroyOnLeave
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x61C0660", Offset = "0x61BFA60", VA = "0x1861C0660")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x61C0690", Offset = "0x61BFA90", VA = "0x1861C0690")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x61C0570", Offset = "0x61BF970", VA = "0x1861C0570")]
		private static int OOKJIEDLCJP(int EDAGPCPLIDJ, int MGEBEBCBFMG, bool JJCDKCEGFJD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x61C04E0", Offset = "0x61BF8E0", VA = "0x1861C04E0")]
		public static ViewId LIODGANGHEE(int EDAGPCPLIDJ, int MGEBEBCBFMG, bool JJCDKCEGFJD)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xD8C3C0", Offset = "0xD8B7C0", VA = "0x180D8C3C0")]
		public static ViewId LIODGANGHEE(int ONAKHLGGKFC)
		{
			return default(ViewId);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x61C0440", Offset = "0x61BF840", VA = "0x1861C0440")]
		public static bool IDILALBKFJC(ViewId OOGPCKEGMIK, ViewId NPEJHBIFPCC)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x61C05B0", Offset = "0x61BF9B0", VA = "0x1861C05B0")]
		public static bool PINPHFMGPOK(ViewId OOGPCKEGMIK, ViewId NPEJHBIFPCC)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x61C0490", Offset = "0x61BF890", VA = "0x1861C0490")]
		public static bool IDILALBKFJC(int OOGPCKEGMIK, ViewId NPEJHBIFPCC)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x61C0290", Offset = "0x61BF690", VA = "0x1861C0290", Slot = "4")]
		public bool Equals(ViewId MGDPHHCBMMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x61C0320", Offset = "0x61BF720", VA = "0x1861C0320", Slot = "0")]
		public override bool Equals(object LIKEKIACGIL)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x61C03F0", Offset = "0x61BF7F0", VA = "0x1861C03F0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class BBPCJGLENKA
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static int EDJBOBDMMEC;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static int HAJBCOJCLNP;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static int JIDNGAHKJDL;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x61C0240", Offset = "0x61BF640", VA = "0x1861C0240")]
	public static void JDGOFMCNBIC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x61BFEC0", Offset = "0x61BF2C0", VA = "0x1861BFEC0")]
	public static void FBOENACFJOF(int[] KMIAIMBPPLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x61BFFA0", Offset = "0x61BF3A0", VA = "0x1861BFFA0")]
	public static int HMAMELKIDGK(int NOKJLGNAGDL, Func<int, bool> CAHMAGIKBNC, bool JJCDKCEGFJD = true)
	{
		return default(int);
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
