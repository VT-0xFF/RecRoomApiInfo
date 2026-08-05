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
	private sealed class AFCIEHEPEFO : IEnumerator<object>, IEnumerator, IDisposable
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
			[Cpp2IlInjected.Address(RVA = "0x657030", Offset = "0x655E30", VA = "0x180657030", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x657030", Offset = "0x655E30", VA = "0x180657030", Slot = "7")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x6C8920", Offset = "0x6C7720", VA = "0x1806C8920")]
		[DebuggerHidden]
		public AFCIEHEPEFO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x5E910F0", Offset = "0x5E8FEF0", VA = "0x185E910F0", Slot = "5")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x5E90F10", Offset = "0x5E8FD10", VA = "0x185E90F10", Slot = "6")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x5E91140", Offset = "0x5E8FF40", VA = "0x185E91140")]
		private void <>m__Finally1()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0x5E910B0", Offset = "0x5E8FEB0", VA = "0x185E910B0", Slot = "8")]
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
	private static HashSet<GameObject> ODEFANIKLEM;

	[Cpp2IlInjected.Token(Token = "0x4000003")]
	private static HashSet<UnityEngine.Object> JDMLJABOBCO;

	[Cpp2IlInjected.Token(Token = "0x6000001")]
	[Cpp2IlInjected.Address(RVA = "0x5E91590", Offset = "0x5E90390", VA = "0x185E91590")]
	public static void RegisterDontDestroyOnLoad(GameObject NLMNGLPMKIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000002")]
	[Cpp2IlInjected.Address(RVA = "0x5E91650", Offset = "0x5E90450", VA = "0x185E91650")]
	public static void RegisterHideFlagsDontSaveObejct(UnityEngine.Object CCPIHKCBGHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000003")]
	[Cpp2IlInjected.Address(RVA = "0x5E91200", Offset = "0x5E90000", VA = "0x185E91200", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000004")]
	[Cpp2IlInjected.Address(RVA = "0x5E916E0", Offset = "0x5E904E0", VA = "0x185E916E0")]
	[IteratorStateMachine(typeof(AFCIEHEPEFO))]
	private IEnumerator Start()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x65A830", Offset = "0x659630", VA = "0x18065A830", Slot = "6")]
	protected virtual void FFKBJLPOPPG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000006")]
	[Cpp2IlInjected.Address(RVA = "0x5E91820", Offset = "0x5E90620", VA = "0x185E91820")]
	protected GameRoot()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
public static class PGBOIEJLOID
{
	[Cpp2IlInjected.Token(Token = "0x600000F")]
	[Cpp2IlInjected.Address(RVA = "0x2F72B10", Offset = "0x2F71910", VA = "0x182F72B10")]
	public static void BLJDCLGLJLA<T>(this T AFOPPLDIMJL) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000010")]
	[Cpp2IlInjected.Address(RVA = "0x5E91C20", Offset = "0x5E90A20", VA = "0x185E91C20")]
	public static void BLJDCLGLJLA(this GameObject BFJMKCMPBKG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class InjectedSingletonMonoBehaviour<TInt, TImpl> : SingletonMonoBehaviour<TImpl> where TInt : class where TImpl : InjectedSingletonMonoBehaviour<TInt, TImpl>, TInt
{
	[Cpp2IlInjected.Token(Token = "0x6000011")]
	[Cpp2IlInjected.Address(RVA = "0x2146620", Offset = "0x2145420", VA = "0x182146620", Slot = "4")]
	protected override void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000012")]
	[Cpp2IlInjected.Address(RVA = "0x21467D0", Offset = "0x21455D0", VA = "0x1821467D0", Slot = "5")]
	protected override void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000013")]
	[Cpp2IlInjected.Address(RVA = "0x2146880", Offset = "0x2145680", VA = "0x182146880")]
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
	public GameObject MNODLILBCMH
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xC82B10", Offset = "0xC81910", VA = "0x180C82B10")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000015")]
	[Cpp2IlInjected.Address(RVA = "0x5E91890", Offset = "0x5E90690", VA = "0x185E91890")]
	private void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000016")]
	[Cpp2IlInjected.Address(RVA = "0x5E91B10", Offset = "0x5E90910", VA = "0x185E91B10")]
	private void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000017")]
	[Cpp2IlInjected.Address(RVA = "0xC81A90", Offset = "0xC80890", VA = "0x180C81A90")]
	public ManagedSingletonObject()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class SingletonMonoBehaviour<T> : MonoBehaviour where T : SingletonMonoBehaviour<T>
{
	[Cpp2IlInjected.Token(Token = "0x400000A")]
	private static T HFEGMKMMHDH;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public static T JNHMLOILMCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000019")]
		[Cpp2IlInjected.Address(RVA = "0xC6DDE0", Offset = "0xC6CBE0", VA = "0x180C6DDE0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public static bool FLBGIACDMIP
	{
		[Cpp2IlInjected.Token(Token = "0x600001A")]
		[Cpp2IlInjected.Address(RVA = "0x43599F0", Offset = "0x43587F0", VA = "0x1843599F0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x4359470", Offset = "0x4358270", VA = "0x184359470", Slot = "4")]
	protected virtual void Awake()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x4359830", Offset = "0x4358630", VA = "0x184359830", Slot = "5")]
	protected virtual void OnDestroy()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x1E7E8F0", Offset = "0x1E7D6F0", VA = "0x181E7E8F0")]
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
