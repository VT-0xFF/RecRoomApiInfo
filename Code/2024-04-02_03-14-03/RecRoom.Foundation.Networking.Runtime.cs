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
			[Cpp2IlInjected.Address(RVA = "0x8F8000", Offset = "0x8F6C00", VA = "0x1808F8000")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public int ActorNumber
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x612CEC0", Offset = "0x612BAC0", VA = "0x18612CEC0")]
			get
			{
				return default(int);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public bool DestroyOnLeave
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x612CEE0", Offset = "0x612BAE0", VA = "0x18612CEE0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public bool IsValid
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x612CF10", Offset = "0x612BB10", VA = "0x18612CF10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x612CDF0", Offset = "0x612B9F0", VA = "0x18612CDF0")]
		private static int JDNBNAFLLGM(int JMLMHFMMNDK, int LHJCMGFNHOC, bool CLKNKJBMNJL)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x612CB10", Offset = "0x612B710", VA = "0x18612CB10")]
		public static ViewId APADDLNAEBN(int JMLMHFMMNDK, int LHJCMGFNHOC, bool CLKNKJBMNJL)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xD8C510", Offset = "0xD8B110", VA = "0x180D8C510")]
		public static ViewId APADDLNAEBN(int AFKHBABOICO)
		{
			return default(ViewId);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x612CD00", Offset = "0x612B900", VA = "0x18612CD00")]
		public static bool FKDJFADGJBA(ViewId GDDMOGHGPAF, ViewId GHPICIIHMOJ)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x612CE30", Offset = "0x612BA30", VA = "0x18612CE30")]
		public static bool MGCOHCIMIFH(ViewId GDDMOGHGPAF, ViewId GHPICIIHMOJ)
		{
			return default(bool);
		}

		[SpecialName]
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x612CD50", Offset = "0x612B950", VA = "0x18612CD50")]
		public static bool FKDJFADGJBA(int GDDMOGHGPAF, ViewId GHPICIIHMOJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x612CBA0", Offset = "0x612B7A0", VA = "0x18612CBA0", Slot = "4")]
		public bool Equals(ViewId NAFFCAIMPLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x612CC30", Offset = "0x612B830", VA = "0x18612CC30", Slot = "0")]
		public override bool Equals(object OGGNGHKHHGI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x612CDA0", Offset = "0x612B9A0", VA = "0x18612CDA0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000003")]
public static class NBCCIIFBIKE
{
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	private static int HFCMGAABLCJ;

	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static int HDAKJJKOIAM;

	[Cpp2IlInjected.Token(Token = "0x400000B")]
	private static int BFAMOFCLOGL;

	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x612C740", Offset = "0x612B340", VA = "0x18612C740")]
	public static void CIGIFMAKIPJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x612C790", Offset = "0x612B390", VA = "0x18612C790")]
	public static void FHLMGBAHIFB(int[] JOLDFAHAKJO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x612C870", Offset = "0x612B470", VA = "0x18612C870")]
	public static int ILHHIGCHEKO(int OEPJHGIBOKI, Func<int, bool> OEOANNFIHID, bool CLKNKJBMNJL = true)
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
