using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.SceneManagement;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class DFELHACHFIL
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2985440", Offset = "0x2984640", VA = "0x182985440")]
	public static T LKKJOIOIELO<T>([Optional] string BHFPKCCDEEC) where T : ScriptableObject
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2985350", Offset = "0x2984550", VA = "0x182985350")]
	public static string INHEMEIFNMJ<T>([Optional] string BHFPKCCDEEC) where T : ScriptableObject
	{
		return null;
	}
}
namespace RecRoom.Configs
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public class SingletonScriptableObject<T> : ScriptableObject where T : ScriptableObject
	{
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		private static T _instance;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		protected virtual bool allowCleanup
		{
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x86D520", Offset = "0x86C720", VA = "0x18086D520", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static T Instance
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x497A500", Offset = "0x4979700", VA = "0x18497A500")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x497A2D0", Offset = "0x49794D0", VA = "0x18497A2D0", Slot = "5")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x497A430", Offset = "0x4979630", VA = "0x18497A430")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x44C1750", Offset = "0x44C0950", VA = "0x1844C1750", Slot = "6")]
		protected virtual void BPGAAPNDOCB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x497A370", Offset = "0x4979570", VA = "0x18497A370")]
		private void JGCGAGBGJMB(Scene AFMLKNOAEHD, LoadSceneMode DNCAOAEPAKK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8BE920", Offset = "0x8BDB20", VA = "0x1808BE920")]
		public SingletonScriptableObject()
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
