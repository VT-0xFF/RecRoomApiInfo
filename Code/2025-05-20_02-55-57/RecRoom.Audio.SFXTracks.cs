using System;
using System.Reflection;
using Cpp2IlInjected;
using RecRoom.Attributes;
using RecRoom.DataStructures;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public class SFXTrack : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x2000003")]
		public enum OLDKBKPGIMD
		{
			[Cpp2IlInjected.Token(Token = "0x4000006")]
			SFX,
			[Cpp2IlInjected.Token(Token = "0x4000007")]
			Music,
			[Cpp2IlInjected.Token(Token = "0x4000008")]
			Ambience
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private string friendlyName;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private OLDKBKPGIMD clipType;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000003")]
		[SerializeField]
		private SerializedGuid guid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		[SerializeField]
		[ReadOnlyField]
		private AudioClip clip;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public string FriendlyName
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public OLDKBKPGIMD ClipType
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xBFD840", Offset = "0xBFCA40", VA = "0x180BFD840")]
			get
			{
				return default(OLDKBKPGIMD);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x12B37F0", Offset = "0x12B29F0", VA = "0x1812B37F0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public AudioClip Clip
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x9F2480", Offset = "0x9F1680", VA = "0x1809F2480")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7AC51C0", Offset = "0x7AC43C0", VA = "0x187AC51C0")]
		public static SFXTrack EAIFKKLDBGP(AudioClip PONOJCFJEFA, string AOEGJGILOAO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7AC52B0", Offset = "0x7AC44B0", VA = "0x187AC52B0")]
		public SFXTrack()
		{
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
