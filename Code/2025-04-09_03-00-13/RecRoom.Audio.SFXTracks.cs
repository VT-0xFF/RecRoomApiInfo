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
		public enum EDCCHFMFEHN
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
		private EDCCHFMFEHN clipType;

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
			[Cpp2IlInjected.Address(RVA = "0x9A91C0", Offset = "0x9A85C0", VA = "0x1809A91C0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public EDCCHFMFEHN ClipType
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0xB3D410", Offset = "0xB3C810", VA = "0x180B3D410")]
			get
			{
				return default(EDCCHFMFEHN);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000003")]
		public Guid Guid
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x11AA140", Offset = "0x11A9540", VA = "0x1811AA140")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000004")]
		public AudioClip Clip
		{
			[Cpp2IlInjected.Token(Token = "0x6000005")]
			[Cpp2IlInjected.Address(RVA = "0x9AA490", Offset = "0x9A9890", VA = "0x1809AA490")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x7701ED0", Offset = "0x77012D0", VA = "0x187701ED0")]
		public static SFXTrack GNHEPACBJCH(AudioClip PIKEFNILHJI, string OEOLCNJCACI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x7701FC0", Offset = "0x77013C0", VA = "0x187701FC0")]
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
