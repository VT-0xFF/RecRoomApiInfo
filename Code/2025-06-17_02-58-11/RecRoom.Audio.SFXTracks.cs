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
		public enum OGFELPPKIHL
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
		private OGFELPPKIHL clipType;

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
			[Cpp2IlInjected.Address(RVA = "0xA0A9D0", Offset = "0xA093D0", VA = "0x180A0A9D0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public OGFELPPKIHL ClipType
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xA58550", Offset = "0xA56F50", VA = "0x180A58550")]
			get
			{
				return default(OGFELPPKIHL);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x13E1810", Offset = "0x13E0210", VA = "0x1813E1810")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public AudioClip Clip
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0xA10FC0", Offset = "0xA0F9C0", VA = "0x180A10FC0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7B71FF0", Offset = "0x7B709F0", VA = "0x187B71FF0")]
		public static SFXTrack JEBOFNEMEAN(AudioClip PMDIKJALACN, string AHDGJCPPJHB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7B720E0", Offset = "0x7B70AE0", VA = "0x187B720E0")]
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
