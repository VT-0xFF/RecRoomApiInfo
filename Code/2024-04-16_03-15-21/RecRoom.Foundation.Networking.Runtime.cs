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
			[Cpp2IlInjected.Address(RVA = "0x906BA0", Offset = "0x905DA0", VA = "0x180906BA0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int ActorNumber
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x6139D80", Offset = "0x6138F80", VA = "0x186139D80")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool DestroyOnLeave
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x6139DA0", Offset = "0x6138FA0", VA = "0x186139DA0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x6139DD0", Offset = "0x6138FD0", VA = "0x186139DD0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x6139BD0", Offset = "0x6138DD0", VA = "0x186139BD0")]
		private static int GIPIDAKIHNM(int DOGHMENCEAA, int LLLAABMNCFK, bool ADNIBKBBCFB)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x6139C60", Offset = "0x6138E60", VA = "0x186139C60")]
		public static ViewId HKBPDPEAAFF(int DOGHMENCEAA, int LLLAABMNCFK, bool ADNIBKBBCFB)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xD898F0", Offset = "0xD88AF0", VA = "0x180D898F0")]
		public static ViewId HKBPDPEAAFF(int JMONNIGBPFP)
		{
			return default(ViewId);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6139B80", Offset = "0x6138D80", VA = "0x186139B80")]
		public static bool FPIEKNKMEBM(ViewId EAIBKNOIIGG, ViewId PKGAILNKPEP)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x6139CF0", Offset = "0x6138EF0", VA = "0x186139CF0")]
		public static bool LEBDJINPIPG(ViewId EAIBKNOIIGG, ViewId PKGAILNKPEP)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x6139B30", Offset = "0x6138D30", VA = "0x186139B30")]
		public static bool FPIEKNKMEBM(int EAIBKNOIIGG, ViewId PKGAILNKPEP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x61399D0", Offset = "0x6138BD0", VA = "0x1861399D0", Slot = "4")]
		public bool Equals(ViewId MEJMHKPOODP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x6139A60", Offset = "0x6138C60", VA = "0x186139A60", Slot = "0")]
		public override bool Equals(object GLMGCMELGFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x6139C10", Offset = "0x6138E10", VA = "0x186139C10", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class MDJBKJBFMCJ
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static int MGHEHKKJABE;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static int KJJOPFIOJDD;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static int FDPKEJLFOAE;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x6139980", Offset = "0x6138B80", VA = "0x186139980")]
	public static void JJPNAIFDIKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x61398A0", Offset = "0x6138AA0", VA = "0x1861398A0")]
	public static void IAKODPENMOF(int[] KPNBCHHMNEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x6139610", Offset = "0x6138810", VA = "0x186139610")]
	public static int HIGEDBLNHHP(int GEGGOMMMKCK, Func<int, bool> IOIKJLGPCJA, bool ADNIBKBBCFB = true)
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
