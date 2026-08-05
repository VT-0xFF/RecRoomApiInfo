using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using Cpp2IlInjected;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
[Cpp2IlInjected.Token(Token = "0x2000002")]
public abstract class GameRoot : SingletonMonoBehaviour<GameRoot>
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	private sealed class HKHDFDCGBHN : IEnumerator<object>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000004")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000005")]
		private object <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000006")]
		public GameRoot <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000007")]
		private IDisposable <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		object IEnumerator<object>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600000C")]
			[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0", Slot = "4")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000002")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600000E")]
			[Cpp2IlInjected.Address(RVA = "0x6671A0", Offset = "0x6659A0", VA = "0x1806671A0", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6D1490", Offset = "0x6CFC90", VA = "0x1806D1490")]
		[DebuggerHidden]
		public HKHDFDCGBHN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x1EC36D0", Offset = "0x1EC1ED0", VA = "0x181EC36D0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x1EC34F0", Offset = "0x1EC1CF0", VA = "0x181EC34F0", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x1EC3720", Offset = "0x1EC1F20", VA = "0x181EC3720")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x1EC3690", Offset = "0x1EC1E90", VA = "0x181EC3690", Slot = "8")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000001")]
	[SerializeField]
	private GameObject StartupObject;

	[Cpp2IlInjected.Token(Token = "0x4000002")]
	private static HashSet<GameObject> FDJDJEDNBLL;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static HashSet<UnityEngine.Object> DBECDDBAIML;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x1EC31F0", Offset = "0x1EC19F0", VA = "0x181EC31F0")]
	public static void RegisterDontDestroyOnLoad(GameObject NJPGIIMNPBL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x1EC32B0", Offset = "0x1EC1AB0", VA = "0x181EC32B0")]
	public static void RegisterHideFlagsDontSaveObejct(UnityEngine.Object ODMJCJPGHNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x1EC2E60", Offset = "0x1EC1660", VA = "0x181EC2E60", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x1EC3340", Offset = "0x1EC1B40", VA = "0x181EC3340")]
	[IteratorStateMachine(typeof(HKHDFDCGBHN))]
	private IEnumerator Start()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x655970", Offset = "0x654170", VA = "0x180655970", Slot = "6")]
	protected virtual void KJECAKGOGJA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x1EC3480", Offset = "0x1EC1C80", VA = "0x181EC3480")]
	protected GameRoot()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class IEAPEIKMJGA
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2EB07D0", Offset = "0x2EAEFD0", VA = "0x182EB07D0")]
	public static void AEOGPFDPLDN<T>(this T CHHHDNBJJIO) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x1EC37E0", Offset = "0x1EC1FE0", VA = "0x181EC37E0")]
	public static void AEOGPFDPLDN(this GameObject HBGIADIFHEC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class InjectedSingletonMonoBehaviour<TInt, TImpl> : SingletonMonoBehaviour<TImpl> where TInt : class where TImpl : InjectedSingletonMonoBehaviour<TInt, TImpl>, TInt
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x3F10C80", Offset = "0x3F0F480", VA = "0x183F10C80", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x3F10E30", Offset = "0x3F0F630", VA = "0x183F10E30", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x3F10EE0", Offset = "0x3F0F6E0", VA = "0x183F10EE0")]
	public InjectedSingletonMonoBehaviour()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public class ManagedSingletonObject : MonoBehaviour
{
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	public static Dictionary<string, ManagedSingletonObject> managedObjects;

	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000009")]
	[SerializeField]
	private string guid;

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public GameObject EJEHNDMLPJN
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x16C83C0", Offset = "0x16C6BC0", VA = "0x1816C83C0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x1EC38D0", Offset = "0x1EC20D0", VA = "0x181EC38D0")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x1EC3B50", Offset = "0x1EC2350", VA = "0x181EC3B50")]
	private void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0x6E7F30", Offset = "0x6E6730", VA = "0x1806E7F30")]
	public ManagedSingletonObject()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class SingletonMonoBehaviour<T> : MonoBehaviour where T : SingletonMonoBehaviour<T>
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static T NIDJHACIMJI;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static T KGCADEGMLJC
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0x1E1D520", Offset = "0x1E1BD20", VA = "0x181E1D520")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static bool ELDHHCEEDGI
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x4662A10", Offset = "0x4661210", VA = "0x184662A10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4662490", Offset = "0x4660C90", VA = "0x184662490", Slot = "4")]
	protected virtual void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4662850", Offset = "0x4661050", VA = "0x184662850", Slot = "5")]
	protected virtual void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x3A89490", Offset = "0x3A87C90", VA = "0x183A89490")]
	public SingletonMonoBehaviour()
	{
	}
}
namespace Cpp2IlInjected;

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
