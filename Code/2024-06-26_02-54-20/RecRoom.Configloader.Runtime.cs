using System;
using System.Reflection;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
using UnityEngine;
using UnityEngine.SceneManagement;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public static class OLJLOFEJGHG
{
	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x2CA1D80", Offset = "0x2CA0380", VA = "0x182CA1D80")]
	public static T DMEKLBBHDMI<T>([Optional] string LCLKDNPLMED) where T : ScriptableObject
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x2CA1E70", Offset = "0x2CA0470", VA = "0x182CA1E70")]
	public static string KJPAGMBNELP<T>([Optional] string LCLKDNPLMED) where T : ScriptableObject
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
			[Cpp2IlInjected.Address(RVA = "0x87D530", Offset = "0x87BB30", VA = "0x18087D530", Slot = "4")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		public static T Instance
		{
			[Cpp2IlInjected.Token(Token = "0x6000004")]
			[Cpp2IlInjected.Address(RVA = "0x4990430", Offset = "0x498EA30", VA = "0x184990430")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x49901F0", Offset = "0x498E7F0", VA = "0x1849901F0", Slot = "5")]
		protected virtual void Awake()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x4990360", Offset = "0x498E960", VA = "0x184990360")]
		private void OnDestroy()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x44D4E30", Offset = "0x44D3430", VA = "0x1844D4E30", Slot = "6")]
		protected virtual void LFHJDGAOGNJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x49902A0", Offset = "0x498E8A0", VA = "0x1849902A0")]
		private void NAOGCGMEEKF(Scene HPPMLCIIGCM, LoadSceneMode LAHMDGOAKPJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8CDE30", Offset = "0x8CC430", VA = "0x1808CDE30")]
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
