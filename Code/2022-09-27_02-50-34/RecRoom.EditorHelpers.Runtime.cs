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
		[Cpp2IlInjected.Address(RVA = "0x5FADF0", Offset = "0x5F9FF0", VA = "0x1805FADF0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4755DE0", Offset = "0x4754FE0", VA = "0x184755DE0")]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x6000003")]
			[Cpp2IlInjected.Address(RVA = "0x4755E00", Offset = "0x4755000", VA = "0x184755E00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x72F660", Offset = "0x72E860", VA = "0x18072F660")]
		private static T JCNCGBLDEAE(ref T BNAPHKKLNMI, ref string EKKALEGBLBO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0x5F6110", Offset = "0x5F5310", VA = "0x1805F6110")]
		private static string PDLEALGNDAM(T BNAPHKKLNMI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0xF36150", Offset = "0xF35350", VA = "0x180F36150")]
		protected EditorPrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class HHBAILLJLGM
{
	[Cpp2IlInjected.Token(Token = "0x6000007")]
	[Cpp2IlInjected.Address(RVA = "0x5F7350", Offset = "0x5F6550", VA = "0x1805F7350")]
	public static void JEFDPGFJOIP()
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
