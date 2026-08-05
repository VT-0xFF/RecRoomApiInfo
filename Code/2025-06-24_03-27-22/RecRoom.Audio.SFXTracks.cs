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
		public enum MCKNLCGEMJH
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
		private MCKNLCGEMJH clipType;

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
			[Cpp2IlInjected.Address(RVA = "0xA1FCA0", Offset = "0xA1E8A0", VA = "0x180A1FCA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public MCKNLCGEMJH ClipType
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xA768B0", Offset = "0xA754B0", VA = "0x180A768B0")]
			get
			{
				return default(MCKNLCGEMJH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x14030C0", Offset = "0x1401CC0", VA = "0x1814030C0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public AudioClip Clip
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xA21F10", Offset = "0xA20B10", VA = "0x180A21F10")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7BF0CA0", Offset = "0x7BEF8A0", VA = "0x187BF0CA0")]
		public static SFXTrack GLOMJONEBBE(AudioClip KLFMLBHBEGH, string IGBMPBJHPMH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7BF0D90", Offset = "0x7BEF990", VA = "0x187BF0D90")]
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
