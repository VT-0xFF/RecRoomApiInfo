using System;
using System.Reflection;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace RecRoom.EditorUtils
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	public abstract class EditorPrefabReference
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x67FB30", Offset = "0x67EB30", VA = "0x18067FB30")]
		protected EditorPrefabReference()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	public abstract class EditorPrefabReference<T> : EditorPrefabReference where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		[SerializeField]
		private string prefabAssetGuid;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		[SerializeField]
		private T prefabReference;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public T Prefab
		{
			[Cpp2IlInjected.Token(Token = "0x6000002")]
			[Cpp2IlInjected.Address(RVA = "0x2022780", Offset = "0x2021780", VA = "0x182022780")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x20227A0", Offset = "0x20217A0", VA = "0x1820227A0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x67E000", Offset = "0x67D000", VA = "0x18067E000")]
		private static T EHKNDPLJDHA(ref T AAJJNJDKADI, ref string MHGOIEENBGM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x685170", Offset = "0x684170", VA = "0x180685170")]
		private static string JEALKIEPFIK(T AAJJNJDKADI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x1E33270", Offset = "0x1E32270", VA = "0x181E33270")]
		protected EditorPrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class KLJBNHKNLMH
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x697EB0", Offset = "0x696EB0", VA = "0x180697EB0")]
	public static void JDOBHDEDHJI()
	{
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
