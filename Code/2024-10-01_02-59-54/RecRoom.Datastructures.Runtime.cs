using System;
using System.Buffers;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Cpp2IlInjected;
using JetBrains.Annotations;
using Microsoft.CodeAnalysis;
using RecRoom.Attributes;
using UnityEngine;

[assembly: AssemblyVersion("0.0.0.0")]
namespace Microsoft.CodeAnalysis
{
	[Cpp2IlInjected.Token(Token = "0x2000002")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class EmbeddedAttribute : Attribute
	{
		[Cpp2IlInjected.Token(Token = "0x6000001")]
		[Cpp2IlInjected.Address(RVA = "0x8D4B40", Offset = "0x8D3F40", VA = "0x1808D4B40")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6DB1820", Offset = "0x6DB0C20", VA = "0x186DB1820")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8D5A40", Offset = "0x8D4E40", VA = "0x1808D5A40")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x8D5A80", Offset = "0x8D4E80", VA = "0x1808D5A80")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class EFHCBFCAMLK : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x19BDE10", Offset = "0x19BD210", VA = "0x1819BDE10")]
	public EFHCBFCAMLK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HashableScriptableObject : ScriptableObject, LHGLLBFNCJL, CJKACODNIDP, ISerializationCallbackReceiver
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000003")]
	[SerializeField]
	private byte[] stableHash;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000004")]
	[SerializeField]
	private byte[] seed;

	[Cpp2IlInjected.Token(Token = "0x17000001")]
	public byte[] StableHash
	{
		[Cpp2IlInjected.Token(Token = "0x6000006")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F40", Offset = "0x8A9340", VA = "0x1808A9F40", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8AA330", Offset = "0x8A9730", VA = "0x1808AA330", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8AA350", Offset = "0x8A9750", VA = "0x1808AA350", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9E76C0", Offset = "0x9E6AC0", VA = "0x1809E76C0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash EIIBADICFOJ);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0xA79810", Offset = "0xA78C10", VA = "0x180A79810")]
	protected HashableScriptableObject()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000007")]
public class SavedExtents : MonoBehaviour
{
	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000005")]
	private float maxLocalSpaceRadius;

	[NonSerialized]
	[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
	[Cpp2IlInjected.Token(Token = "0x4000006")]
	private float maxWorldSpaceRadius;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000007")]
	[ReadOnlyField]
	[SerializeField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[SerializeField]
	[HideInInspector]
	[ReadOnlyField]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6DB2B50", Offset = "0x6DB1F50", VA = "0x186DB2B50")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6DB2B10", Offset = "0x6DB1F10", VA = "0x186DB2B10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6DB2B90", Offset = "0x6DB1F90", VA = "0x186DB2B90")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6DB2D40", Offset = "0x6DB2140", VA = "0x186DB2D40")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6DB2CB0", Offset = "0x6DB20B0", VA = "0x186DB2CB0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xA7A1B0", Offset = "0xA795B0", VA = "0x180A7A1B0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xBBF830", Offset = "0xBBEC30", VA = "0x180BBF830")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6DB2AD0", Offset = "0x6DB1ED0", VA = "0x186DB2AD0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6DB2C20", Offset = "0x6DB2020", VA = "0x186DB2C20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6DB2570", Offset = "0x6DB1970", VA = "0x186DB2570")]
	public void CopyBounds(SavedExtents OCKBFCIKBEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6DB2A20", Offset = "0x6DB1E20", VA = "0x186DB2A20")]
	public void SetLocalSpaceBounds(Bounds FHDDFBMCIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xEB8F40", Offset = "0xEB8340", VA = "0x180EB8F40")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6DB2A10", Offset = "0x6DB1E10", VA = "0x186DB2A10")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6DB2660", Offset = "0x6DB1A60", VA = "0x186DB2660")]
	private void MPMKGMMKBIJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6DB2810", Offset = "0x6DB1C10", VA = "0x186DB2810")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6DB1F30", Offset = "0x6DB1330", VA = "0x186DB1F30")]
	public static void CalculateLocalBoundsFor(GameObject JPONDMDOHLN, [Out] Bounds FHDDFBMCIOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6DB25A0", Offset = "0x6DB19A0", VA = "0x186DB25A0")]
	private static void LMDFPLGJFLN(Bounds PMGMHFIMGOD, Color HPAGGPJLKCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6DB2A40", Offset = "0x6DB1E40", VA = "0x186DB2A40")]
	public SavedExtents()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000009")]
public abstract class SerializedKeyVal<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000D")]
	[SerializeField]
	private TKey _key;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000E")]
	[SerializeField]
	private TVal _val;

	[Cpp2IlInjected.Token(Token = "0x1700000D")]
	public TKey Key
	{
		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8A91A0", Offset = "0x8A85A0", VA = "0x1808A91A0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x8B5800", Offset = "0x8B4C00", VA = "0x1808B5800")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x130FD00", Offset = "0x130F100", VA = "0x18130FD00")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x4D6E510", Offset = "0x4D6D910", VA = "0x184D6E510")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "4")]
	public virtual void LJMFODFCCCE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	protected SerializedKeyVal()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000A")]
public abstract class SerializedDictionary<TKey, TVal, TKeyVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400000F")]
	[EFHCBFCAMLK]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4D6E020", Offset = "0x4D6D420", VA = "0x184D6E020", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4D6C640", Offset = "0x4D6BA40", VA = "0x184D6C640", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4D6E400", Offset = "0x4D6D800", VA = "0x184D6E400")]
	protected SerializedDictionary()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000B")]
public abstract class EditableSerializedDictionary<TKey, TVal, TKeyVal> : IReadOnlyDictionary<TKey, TVal>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable, IReadOnlyCollection<KeyValuePair<TKey, TVal>>, ISerializationCallbackReceiver where TKeyVal : SerializedKeyVal<TKey, TVal>, new()
{
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[CompilerGenerated]
	private sealed class OEBAAGAIIPM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public OEBAAGAIIPM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x4A5C270", Offset = "0x4A5B670", VA = "0x184A5C270")]
		internal int IDBEFEBBMLB(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[EFHCBFCAMLK]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3B7BC80", Offset = "0x3B7B080", VA = "0x183B7BC80", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3B7BCE0", Offset = "0x3B7B0E0", VA = "0x183B7BCE0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3B7BB50", Offset = "0x3B7AF50", VA = "0x183B7BB50", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey GMJINMLEEAC]
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3B7BC10", Offset = "0x3B7B010", VA = "0x183B7BC10", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3B7B9F0", Offset = "0x3B7ADF0", VA = "0x183B7B9F0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3B7B670", Offset = "0x3B7AA70", VA = "0x183B7B670", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3B7A9E0", Offset = "0x3B79DE0", VA = "0x183B7A9E0", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3B7A8A0", Offset = "0x3B79CA0", VA = "0x183B7A8A0", Slot = "14")]
	protected virtual string GCKNIJPLDOM(TKeyVal EDICMHINCMP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3B7A840", Offset = "0x3B79C40", VA = "0x183B7A840", Slot = "4")]
	public bool ContainsKey(TKey GMJINMLEEAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3B7B860", Offset = "0x3B7AC60", VA = "0x183B7B860", Slot = "5")]
	public bool TryGetValue(TKey GMJINMLEEAC, [Out] TVal LIHHDPOHLDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3B7A930", Offset = "0x3B79D30", VA = "0x183B7A930", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3B7A930", Offset = "0x3B79D30", VA = "0x183B7A930", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3B7B8C0", Offset = "0x3B7ACC0", VA = "0x183B7B8C0")]
	protected EditableSerializedDictionary()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000D")]
public abstract class SerializedReferenceKeyVal<TKey, TVal>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	[SerializeField]
	private TKey _key;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	[SerializeReference]
	[SerializeField]
	private TVal _val;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public TKey Key
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F00", Offset = "0x8A9300", VA = "0x1808A9F00")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F20", Offset = "0x8A9320", VA = "0x1808A9F20")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F40", Offset = "0x8A9340", VA = "0x1808A9F40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	protected SerializedReferenceKeyVal()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200000E")]
public abstract class SerializedReferenceDictionary<TKey, TVal> : Dictionary<TKey, TVal>, ISerializationCallbackReceiver
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200000F")]
	private class SerializedReferenceKeyValuePair : SerializedReferenceKeyVal<TKey, TVal>
	{
		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3EEB290", Offset = "0x3EEA690", VA = "0x183EEB290")]
		public SerializedReferenceKeyValuePair()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[SerializeField]
	[EFHCBFCAMLK]
	private List<SerializedReferenceKeyValuePair> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4D6F7F0", Offset = "0x4D6EBF0", VA = "0x184D6F7F0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4D6ED30", Offset = "0x4D6E130", VA = "0x184D6ED30", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4D6E400", Offset = "0x4D6D800", VA = "0x184D6E400")]
	protected SerializedReferenceDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class FOIJKOLBMDB<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private class DHOEFDIFJGD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public float HINPJDOKCPL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public T JKEIFELLNME;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public DHOEFDIFJGD()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class LDIPPJOJOCG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public LDIPPJOJOCG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x45D4820", Offset = "0x45D3C20", VA = "0x1845D4820")]
		internal bool AJOBGOMJGCM(DHOEFDIFJGD sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly float KKIMOAFFPMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly float IJKJDPMIGAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private List<DHOEFDIFJGD> PFDOBMNHIHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private CBIGCBOHNBJ<DHOEFDIFJGD> IILOMOBHPIB;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int ANEJECEADML
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3F395A0", Offset = "0x3F389A0", VA = "0x183F395A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3F39680", Offset = "0x3F38A80", VA = "0x183F39680")]
	public FOIJKOLBMDB(float KKCMGHPDBFC, float KONBNPIFFPI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3F393B0", Offset = "0x3F387B0", VA = "0x183F393B0")]
	public bool JALJGBNCEEH(float LBFLJPCMBIG, T LIHHDPOHLDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3F38A90", Offset = "0x3F37E90", VA = "0x183F38A90")]
	public IEnumerable<T> IEAFLNDGFPD(float LBFLJPCMBIG, [Optional] float? LKFGMFGNHGG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3F389D0", Offset = "0x3F37DD0", VA = "0x183F389D0")]
	public void FLFDAJFNFLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3F38810", Offset = "0x3F37C10", VA = "0x183F38810")]
	private void AILIBKCINAG(float LBFLJPCMBIG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class KKJNFJJEHGD<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct PODNAPNAGIB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public T JKEIFELLNME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public float CCGFCDKJBLC;
	}

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static float GMMMHKKFOIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private List<T> MIECAPPGMKP;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private const int CCIMCOLMLJO = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private PODNAPNAGIB[] AFBDFGIDJPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private int EKHHOCHGHJC;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public float MJKLMHHMCCB
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xCB5350", Offset = "0xCB4750", VA = "0x180CB5350")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xCD3190", Offset = "0xCD2590", VA = "0x180CD3190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x454C010", Offset = "0x454B410", VA = "0x18454C010")]
	public KKJNFJJEHGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x454BED0", Offset = "0x454B2D0", VA = "0x18454BED0")]
	public KKJNFJJEHGD(int MFKKELONDCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x454BD70", Offset = "0x454B170", VA = "0x18454BD70")]
	public void PJLPMKJIOFF(float LBFLJPCMBIG, T LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x454B630", Offset = "0x454AA30", VA = "0x18454B630")]
	public void FLFDAJFNFLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x454ADA0", Offset = "0x454A1A0", VA = "0x18454ADA0")]
	public bool AEBIEFOGPBF(float BLPPBAOPDMF, float JGGMCGLFDNH, [Out] T LIHHDPOHLDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x454BA40", Offset = "0x454AE40", VA = "0x18454BA40")]
	public bool KDIOJCKJJME(float BLPPBAOPDMF, float JGGMCGLFDNH, [Out] T LIHHDPOHLDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x454B300", Offset = "0x454A700", VA = "0x18454B300")]
	public void ELLBPMEGHME(float BLPPBAOPDMF, float JGGMCGLFDNH, List<T> FIJBJOBOOEA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x454B2D0", Offset = "0x454A6D0", VA = "0x18454B2D0")]
	private int CAJOBPHMPCB(int EEPMPJHGJEH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x454BC10", Offset = "0x454B010", VA = "0x18454BC10")]
	private void OHDCHNPKKJP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T DIJIBLDAGCF();

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T FNLFNIHOPAK(T LIHHDPOHLDK, float HIKBGGAGLAA);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T FHHHFDLMDGD(T GIDMNJLJNOH, T OONEKAPAHLL);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T OOFPMMLKEKF(T GIDMNJLJNOH, T OONEKAPAHLL);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class AKLLOFEGEHO : KKJNFJJEHGD<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8BAB70", Offset = "0x8B9F70", VA = "0x1808BAB70", Slot = "4")]
	protected override Vector3 DIJIBLDAGCF()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6DADB60", Offset = "0x6DACF60", VA = "0x186DADB60", Slot = "5")]
	protected override Vector3 FNLFNIHOPAK(Vector3 LIHHDPOHLDK, float HIKBGGAGLAA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6DADB10", Offset = "0x6DACF10", VA = "0x186DADB10", Slot = "6")]
	protected override Vector3 FHHHFDLMDGD(Vector3 GIDMNJLJNOH, Vector3 OONEKAPAHLL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6DADBA0", Offset = "0x6DACFA0", VA = "0x186DADBA0", Slot = "7")]
	protected override Vector3 OOFPMMLKEKF(Vector3 GIDMNJLJNOH, Vector3 OONEKAPAHLL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6DADC20", Offset = "0x6DAD020", VA = "0x186DADC20")]
	public AKLLOFEGEHO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class HKLCAEKIPIP
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2E883C0", Offset = "0x2E877C0", VA = "0x182E883C0")]
	public static PCIAHMECFFE<T1, T2> LIDOGEGODKP<T1, T2>(T1 KIGKLLNEIEL, T2 DOGEMKPCENL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2E88460", Offset = "0x2E87860", VA = "0x182E88460")]
	public static MLPMBBOFILJ<T1, T2, T3> LIDOGEGODKP<T1, T2, T3>(T1 KIGKLLNEIEL, T2 DOGEMKPCENL, T3 JBDDONKFGIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x4881080", Offset = "0x4880480", VA = "0x184881080")]
	internal static int PLDBNFPOGDF(int IOEEAEJHJFC, int HIHLALBOHOL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x6145ED0", Offset = "0x61452D0", VA = "0x186145ED0")]
	internal static int PLDBNFPOGDF(int IOEEAEJHJFC, int HIHLALBOHOL, int EIOCGFDFKLC)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class PCIAHMECFFE<T1, T2> : IComparable<PCIAHMECFFE<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly T1 PKIKIEDKOPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly T2 LMEEEOJOBLO;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4B53090", Offset = "0x4B52490", VA = "0x184B53090")]
	public PCIAHMECFFE(T1 KIGKLLNEIEL, T2 DOGEMKPCENL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4B514B0", Offset = "0x4B508B0", VA = "0x184B514B0", Slot = "4")]
	public int CompareTo(PCIAHMECFFE<T1, T2> OCKBFCIKBEN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x4B51F70", Offset = "0x4B51370", VA = "0x184B51F70", Slot = "0")]
	public override bool Equals(object OCKBFCIKBEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x4B52420", Offset = "0x4B51820", VA = "0x184B52420", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4B529E0", Offset = "0x4B51DE0", VA = "0x184B529E0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class MLPMBBOFILJ<T1, T2, T3> : IComparable<MLPMBBOFILJ<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly T1 PKIKIEDKOPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly T2 LMEEEOJOBLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly T3 GOMEHMDPGHN;

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x48498D0", Offset = "0x4848CD0", VA = "0x1848498D0")]
	public MLPMBBOFILJ(T1 KIGKLLNEIEL, T2 DOGEMKPCENL, T3 JBDDONKFGIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x4849080", Offset = "0x4848480", VA = "0x184849080", Slot = "4")]
	public int CompareTo(MLPMBBOFILJ<T1, T2, T3> OCKBFCIKBEN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x4849300", Offset = "0x4848700", VA = "0x184849300", Slot = "0")]
	public override bool Equals(object OCKBFCIKBEN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x48494D0", Offset = "0x48488D0", VA = "0x1848494D0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x4849710", Offset = "0x4848B10", VA = "0x184849710", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public abstract class ValueCurve<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[SerializeField]
	protected AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	[SerializeField]
	protected T minValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	[SerializeField]
	protected T maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	[SerializeField]
	protected float duration;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public T JKEIFELLNME
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x257C100", Offset = "0x257B500", VA = "0x18257C100")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x257C110", Offset = "0x257B510", VA = "0x18257C110")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public float FBIBKLEJCEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0xA884D0", Offset = "0xA878D0", VA = "0x180A884D0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4FE0520", Offset = "0x4FDF920", VA = "0x184FE0520")]
	public T FDCPCLDPLOB(float HIKBGGAGLAA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4FE0660", Offset = "0x4FDFA60", VA = "0x184FE0660")]
	public T NCCGJGBJFOB(float HIKBGGAGLAA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T GBNMMMGFOPB(T GIDMNJLJNOH, T OONEKAPAHLL, float HIKBGGAGLAA);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6DAF7A0", Offset = "0x6DAEBA0", VA = "0x186DAF7A0", Slot = "4")]
	protected override float GBNMMMGFOPB(float GIDMNJLJNOH, float OONEKAPAHLL, float HIKBGGAGLAA)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6DAF7E0", Offset = "0x6DAEBE0", VA = "0x186DAF7E0")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x1166E00", Offset = "0x1166200", VA = "0x181166E00", Slot = "4")]
	protected override Vector3 GBNMMMGFOPB(Vector3 GIDMNJLJNOH, Vector3 OONEKAPAHLL, float HIKBGGAGLAA)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6DB3B10", Offset = "0x6DB2F10", VA = "0x186DB3B10")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6DAE130", Offset = "0x6DAD530", VA = "0x186DAE130", Slot = "4")]
	protected override Color GBNMMMGFOPB(Color GIDMNJLJNOH, Color OONEKAPAHLL, float HIKBGGAGLAA)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6DAE1F0", Offset = "0x6DAD5F0", VA = "0x186DAE1F0")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class IDNLHDPMOAD : MBIODKLGEBC<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6DAF890", Offset = "0x6DAEC90", VA = "0x186DAF890")]
	public IDNLHDPMOAD(int MLLKNBDHHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6DAF820", Offset = "0x6DAEC20", VA = "0x186DAF820", Slot = "6")]
	protected override uint GDADLEMCCBO(uint EIIBADICFOJ, string LIHHDPOHLDK)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class LPIOHIBICCE : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly IDisposable FKMJLLKHOAH;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	public LPIOHIBICCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct IJIKMCNEGNF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> AELDPCHHNDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private int NJGJCJJGIMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private int FKAGHFCHEMB;

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3B257F0", Offset = "0x3B24BF0", VA = "0x183B257F0")]
	private IJIKMCNEGNF(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> PPAMLNJAIDE, int MNOLDPPGAAC, int DFGKNBACFBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x420BF20", Offset = "0x420B320", VA = "0x18420BF20")]
	public static IJIKMCNEGNF<T> AALKPJMFIHM()
	{
		return default(IJIKMCNEGNF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x420D650", Offset = "0x420CA50", VA = "0x18420D650")]
	public (int, int, Task<T>) LIHEPDKAKLB(int NMAAEIEEHNK, [Optional] CancellationToken EEHACKMODLA, double HEJMBOHMFMN = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x420DDB0", Offset = "0x420D1B0", VA = "0x18420DDB0")]
	public void PEOIDDFNEOA(int NMAAEIEEHNK, int DFGKNBACFBF, [In] T CIFMGKBFCHA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class NCAJJFOPDKB
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6DB1750", Offset = "0x6DB0B50", VA = "0x186DB1750")]
	public static IJIKMCNEGNF<OKFEIOHLOGM> AALKPJMFIHM()
	{
		return default(IJIKMCNEGNF<OKFEIOHLOGM>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6DB17A0", Offset = "0x6DB0BA0", VA = "0x186DB17A0")]
	public static void PEOIDDFNEOA([In] this IJIKMCNEGNF<OKFEIOHLOGM> MBGHIKEGJAA, int NMAAEIEEHNK, int DFGKNBACFBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[DefaultMember("Item")]
public class ELEMDMKBHMI<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly Dictionary<TKey, TVal> JLMMLMCPDBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly Dictionary<TVal, TKey> EMEFLJKMAGE;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public int NJGLPGPPJOG
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x389B8C0", Offset = "0x389ACC0", VA = "0x18389B8C0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public bool OGEBMIKLHAJ
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8F3EB0", Offset = "0x8F32B0", VA = "0x1808F3EB0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public ICollection<TKey> HBJADEMOOKC
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x3B42C00", Offset = "0x3B42000", VA = "0x183B42C00", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public ICollection<TVal> FMMJAAJNCFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x3B42C60", Offset = "0x3B42060", VA = "0x183B42C60", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public TVal CPCAOKGGKKP
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x3B42B90", Offset = "0x3B41F90", VA = "0x183B42B90", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x3B42CC0", Offset = "0x3B420C0", VA = "0x183B42CC0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public TKey CPCAOKGGKKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x3B427E0", Offset = "0x3B41BE0", VA = "0x183B427E0")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3B41FD0", Offset = "0x3B413D0", VA = "0x183B41FD0", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x3B42950", Offset = "0x3B41D50", VA = "0x183B42950", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3B41D00", Offset = "0x3B41100", VA = "0x183B41D00", Slot = "9")]
	public void Add(TKey GMJINMLEEAC, TVal LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3B41DA0", Offset = "0x3B411A0", VA = "0x183B41DA0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> BNDEDHKBDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3B42080", Offset = "0x3B41480", VA = "0x183B42080", Slot = "8")]
	public bool ContainsKey(TKey GMJINMLEEAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3B420E0", Offset = "0x3B414E0", VA = "0x183B420E0", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> BNDEDHKBDGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3B42840", Offset = "0x3B41C40", VA = "0x183B42840", Slot = "10")]
	public bool Remove(TKey GMJINMLEEAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3B42880", Offset = "0x3B41C80", VA = "0x183B42880", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> BNDEDHKBDGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3B429A0", Offset = "0x3B41DA0", VA = "0x183B429A0", Slot = "11")]
	public bool TryGetValue(TKey GMJINMLEEAC, [Out] TVal LIHHDPOHLDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3B426E0", Offset = "0x3B41AE0", VA = "0x183B426E0", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3B42160", Offset = "0x3B41560", VA = "0x183B42160", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] AFBDFGIDJPF, int IFBAABIFFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3B42440", Offset = "0x3B41840", VA = "0x183B42440")]
	public bool FDPJDJCOJAH(TVal GMJINMLEEAC, [Out] TKey LIHHDPOHLDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3B41ED0", Offset = "0x3B412D0", VA = "0x183B41ED0")]
	private void COKLFNOADMN(TKey GMJINMLEEAC, TVal HMBPNLCBEEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3B425E0", Offset = "0x3B419E0", VA = "0x183B425E0")]
	private void GOKIJNHGDPM(TKey GMJINMLEEAC, TVal HMBPNLCBEEJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3B42310", Offset = "0x3B41710", VA = "0x183B42310")]
	private bool DLNDJLCBFFE(TKey GMJINMLEEAC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3B42A00", Offset = "0x3B41E00", VA = "0x183B42A00")]
	public ELEMDMKBHMI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[DefaultMember("Item")]
public class PGPJKEJCAFM<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private PGPJKEJCAFM<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003C")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x3BC90D0", Offset = "0x3BC84D0", VA = "0x183BC90D0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x3BD0160", Offset = "0x3BCF560", VA = "0x183BD0160", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x3BD1570", Offset = "0x3BD0970", VA = "0x183BD1570")]
		public Enumerator(PGPJKEJCAFM<T> FIJBJOBOOEA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x3BCF540", Offset = "0x3BCE940", VA = "0x183BCF540", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x3BCFC20", Offset = "0x3BCF020", VA = "0x183BCFC20", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x3BCDFA0", Offset = "0x3BCD3A0", VA = "0x183BCDFA0")]
		private void LJNHBCAHLNA()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private T[] IGBJMHCINDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private int IHLILPEDKCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private int EKBMPDBILAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private int DMDALLEEEHI;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int NJGLPGPPJOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x4B60AB0", Offset = "0x4B5FEB0", VA = "0x184B60AB0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public T CPCAOKGGKKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x4B60EA0", Offset = "0x4B602A0", VA = "0x184B60EA0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x4B5F6B0", Offset = "0x4B5EAB0", VA = "0x184B5F6B0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x4B61880", Offset = "0x4B60C80", VA = "0x184B61880")]
	public PGPJKEJCAFM(int MLLKNBDHHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x4B61270", Offset = "0x4B60670", VA = "0x184B61270")]
	public void PJLPMKJIOFF(T HIKBGGAGLAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x4B600B0", Offset = "0x4B5F4B0", VA = "0x184B600B0")]
	public void FLFDAJFNFLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x4B609D0", Offset = "0x4B5FDD0", VA = "0x184B609D0")]
	public void HNHGPIOOAKK(int MGEMHICLKEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x4B600D0", Offset = "0x4B5F4D0", VA = "0x184B600D0")]
	public void FNBNPIELHGO(T[] AFBDFGIDJPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x4B60AF0", Offset = "0x4B5FEF0", VA = "0x184B60AF0")]
	public Enumerator MKNNDFMGFGD()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x4B616D0", Offset = "0x4B60AD0", VA = "0x184B616D0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x4B616D0", Offset = "0x4B60AD0", VA = "0x184B616D0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x4B5FA70", Offset = "0x4B5EE70", VA = "0x184B5FA70")]
	private int COCNMHOPMBN(int AEAHMAMPNLO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4B5F900", Offset = "0x4B5ED00", VA = "0x184B5F900")]
	private int BNJCOJCNEDH(int AEAHMAMPNLO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class ABDOPOACKOD<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public delegate Task<TResult> OCJKNEDJDEK(TRequest JHKMPCADNAF, CancellationToken EEHACKMODLA);

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public enum DFHHDMBEIEF
	{
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class MGHPEGLLOOM
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private const float FGCOLPEHAKF = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TimeSpan CFPMABACMAG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int GAGIJHIELJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public DFHHDMBEIEF LICKEDAJBDJ;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public static readonly MGHPEGLLOOM DPPOJDBEGAC;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float CLBHGOOKEBE
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x481C650", Offset = "0x481BA50", VA = "0x18481C650")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public TimeSpan LOGIAHCFGND
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F00", Offset = "0x8A9300", VA = "0x1808A9F00")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x481C7A0", Offset = "0x481BBA0", VA = "0x18481C7A0")]
		public MGHPEGLLOOM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private readonly struct KGAAOPHPKOI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly TRequest JHKMPCADNAF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly CancellationToken EEHACKMODLA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public readonly TaskCompletionSource<TResult> ONBCLJCPOHM;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x452DB40", Offset = "0x452CF40", VA = "0x18452DB40")]
		public KGAAOPHPKOI(TRequest JHKMPCADNAF, TaskCompletionSource<TResult> ONBCLJCPOHM, CancellationToken EEHACKMODLA)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct GNMNIJCHIFE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public ABDOPOACKOD<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x401F310", Offset = "0x401E710", VA = "0x18401F310", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x401FFA0", Offset = "0x401F3A0", VA = "0x18401FFA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private struct AGKNLEPIHKN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public ABDOPOACKOD<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private KGAAOPHPKOI <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x3FB6490", Offset = "0x3FB5890", VA = "0x183FB6490", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x3FB7810", Offset = "0x3FB6C10", VA = "0x183FB7810", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly CancellationTokenSource IKBPOAPEBGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly List<KGAAOPHPKOI> EOAJJDOJKPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly MGHPEGLLOOM MFEBLEJIIDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly OCJKNEDJDEK JHPMHGKLCEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private Task OIDLLGKPMLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private int GNJCNEKLNFA;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x3F84640", Offset = "0x3F83A40", VA = "0x183F84640")]
	public ABDOPOACKOD(OCJKNEDJDEK JHPMHGKLCEJ, [Optional] MGHPEGLLOOM MFEBLEJIIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x3F82AA0", Offset = "0x3F81EA0", VA = "0x183F82AA0")]
	public Task<TResult> BNECHBMMFEK(TRequest JHKMPCADNAF, CancellationToken EEHACKMODLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x3F84160", Offset = "0x3F83560", VA = "0x183F84160")]
	private void MKLBLICALNH(KGAAOPHPKOI CDGBHEFJNCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x3F831B0", Offset = "0x3F825B0", VA = "0x183F831B0")]
	[AsyncStateMachine(typeof(ABDOPOACKOD<, >.GNMNIJCHIFE))]
	private Task BONEOFNKDCF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x3F83DA0", Offset = "0x3F831A0", VA = "0x183F83DA0")]
	private KGAAOPHPKOI FEHMBLFBCNF()
	{
		return default(KGAAOPHPKOI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x3F829B0", Offset = "0x3F81DB0", VA = "0x183F829B0")]
	[AsyncStateMachine(typeof(ABDOPOACKOD<, >.AGKNLEPIHKN))]
	private Task AIKLKDHBOOJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x3F83420", Offset = "0x3F82820", VA = "0x183F83420")]
	private void CKBGFHPLLCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x3F83750", Offset = "0x3F82B50", VA = "0x183F83750", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[DefaultMember("Item")]
public class GEJAEGAEOCH<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly List<T> HGMKHDHJCFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private HashSet<T> ICCMKHGHGBH;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int NJGLPGPPJOG
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x389B8C0", Offset = "0x389ACC0", VA = "0x18389B8C0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool OGEBMIKLHAJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8F3EB0", Offset = "0x8F32B0", VA = "0x1808F3EB0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public T CPCAOKGGKKP
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2CEB6A0", Offset = "0x2CEAAA0", VA = "0x182CEB6A0", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x3FD8610", Offset = "0x3FD7A10", VA = "0x183FD8610", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3F4FBA0", Offset = "0x3F4EFA0", VA = "0x183F4FBA0", Slot = "11")]
	public void Add(T BNDEDHKBDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x3FD7E20", Offset = "0x3FD7220", VA = "0x183FD7E20")]
	public bool MNCFLHJHNAL(T BNDEDHKBDGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3FD81F0", Offset = "0x3FD75F0", VA = "0x183FD81F0", Slot = "15")]
	public bool Remove(T BNDEDHKBDGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x3EF3D90", Offset = "0x3EF3190", VA = "0x183EF3D90", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x3F097D0", Offset = "0x3F08BD0", VA = "0x183F097D0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x3FD78A0", Offset = "0x3FD6CA0", VA = "0x183FD78A0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x3FD7950", Offset = "0x3FD6D50", VA = "0x183FD7950", Slot = "13")]
	public bool Contains(T BNDEDHKBDGD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x3FD79B0", Offset = "0x3FD6DB0", VA = "0x183FD79B0", Slot = "14")]
	public void CopyTo(T[] AFBDFGIDJPF, int IFBAABIFFGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x3FD7A10", Offset = "0x3FD6E10", VA = "0x183FD7A10", Slot = "6")]
	public int IndexOf(T BNDEDHKBDGD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x3FD7A70", Offset = "0x3FD6E70", VA = "0x183FD7A70", Slot = "7")]
	public void Insert(int AEAHMAMPNLO, T BNDEDHKBDGD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x3FD7F30", Offset = "0x3FD7330", VA = "0x183FD7F30", Slot = "8")]
	public void RemoveAt(int AEAHMAMPNLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x3FD8390", Offset = "0x3FD7790", VA = "0x183FD8390")]
	public GEJAEGAEOCH()
	{
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400005B")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x17000029")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000DC")]
			[Cpp2IlInjected.Address(RVA = "0x2423F80", Offset = "0x2423380", VA = "0x182423F80")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x6DB30E0", Offset = "0x6DB24E0", VA = "0x186DB30E0")]
		public SerializedGuid([In] Guid FDANKBMKMCE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x6DB2F50", Offset = "0x6DB2350", VA = "0x186DB2F50")]
		public static SerializedGuid IPCEAAGEPNK()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x6DB2ED0", Offset = "0x6DB22D0", VA = "0x186DB2ED0")]
		public static SerializedGuid FECIJNIMBBE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x6DB2FD0", Offset = "0x6DB23D0", VA = "0x186DB2FD0")]
		public bool KGFOOIOHGJD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6DB30B0", Offset = "0x6DB24B0", VA = "0x186DB30B0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6DB3030", Offset = "0x6DB2430", VA = "0x186DB3030", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x6DB2E00", Offset = "0x6DB2200", VA = "0x186DB2E00", Slot = "7")]
		public bool Equals(SerializedGuid OCKBFCIKBEN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6DB2E40", Offset = "0x6DB2240", VA = "0x186DB2E40", Slot = "0")]
		public override bool Equals(object PBAACPJGKNP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6DB2F40", Offset = "0x6DB2340", VA = "0x186DB2F40", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6DB2DD0", Offset = "0x6DB21D0", VA = "0x186DB2DD0", Slot = "6")]
		public int CompareTo(SerializedGuid OCKBFCIKBEN)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class EMDCBLNHCPH : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly Type DMEJMCDCBHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public readonly string LNNMCLJPEKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public readonly bool MBKCIAPLIBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public readonly bool NEFJJCGMOBN;

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6DAF3E0", Offset = "0x6DAE7E0", VA = "0x186DAF3E0")]
	public EMDCBLNHCPH(Type MJOJDGFFMBB, string KAOKGCGOLKH, bool ADGOJPEMEFF = false, bool DLFIIILGJJP = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class PMKGFNIFFEC<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public readonly struct KMHIBDGLMBH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly long KAKFEHLDJNG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public readonly long PEPGAIICPIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public readonly int KFOFEMEMDEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public readonly int LEHPCOFCDNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public readonly bool NFNEMADMEMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly string FOILPLMNAFF;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x45512E0", Offset = "0x45506E0", VA = "0x1845512E0")]
		public KMHIBDGLMBH(long KAKFEHLDJNG, int KFOFEMEMDEF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x45512B0", Offset = "0x45506B0", VA = "0x1845512B0")]
		public KMHIBDGLMBH(long KAKFEHLDJNG, long PEPGAIICPIK, int KFOFEMEMDEF, int LEHPCOFCDNE, bool NFNEMADMEMM, string FOILPLMNAFF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x4551140", Offset = "0x4550540", VA = "0x184551140")]
		public int KGAEMHFJIJC()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x4551190", Offset = "0x4550590", VA = "0x184551190")]
		public int KNIPCLDHNAK(int JNNABCOLIDP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x45511B0", Offset = "0x45505B0", VA = "0x1845511B0")]
		public double LCGKPBMDLDP()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x4551210", Offset = "0x4550610", VA = "0x184551210")]
		public KMHIBDGLMBH MMLCPADPIHE(long PEPGAIICPIK, int LEHPCOFCDNE)
		{
			return default(KMHIBDGLMBH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class INNANANOCLO : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		[CompilerGenerated]
		private struct HEGLBFAOKPF<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public INNANANOCLO <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public Func<INNANANOCLO, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private INNANANOCLO <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x4081FA0", Offset = "0x40813A0", VA = "0x184081FA0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x4082500", Offset = "0x4081900", VA = "0x184082500", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public readonly TKey NDKJAMPIIHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly PMKGFNIFFEC<TKey> GBIEPJHIGOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public readonly EGGMDNJPOBA DFDLACHAHGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private List<INNANANOCLO> PHCJLDBDBPI;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public string FNHKCFBBJPC
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x3FEB5E0", Offset = "0x3FEA9E0", VA = "0x183FEB5E0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public IEnumerable<INNANANOCLO> NJONKLMDNAB
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x42164E0", Offset = "0x42158E0", VA = "0x1842164E0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public KMHIBDGLMBH GFOBEOKJEOJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x42164C0", Offset = "0x42158C0", VA = "0x1842164C0")]
			[CompilerGenerated]
			get
			{
				return default(KMHIBDGLMBH);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x4216070", Offset = "0x4215470", VA = "0x184216070")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x4216520", Offset = "0x4215920", VA = "0x184216520")]
		internal INNANANOCLO(PMKGFNIFFEC<TKey> GBIEPJHIGOL, TKey GMJINMLEEAC, EGGMDNJPOBA DFDLACHAHGJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x4216300", Offset = "0x4215700", VA = "0x184216300")]
		public INNANANOCLO JAFIBNBLLKN(TKey GMJINMLEEAC, [Optional] EGGMDNJPOBA? DHCDHNNJMDE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x3042D10", Offset = "0x3042110", VA = "0x183042D10")]
		[AsyncStateMachine(typeof(HEGLBFAOKPF<>))]
		public Task<T> PLCGLCEMHKO<T>(TKey GMJINMLEEAC, Func<INNANANOCLO, Task<T>> HGNEAAOPDDM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x42160A0", Offset = "0x42154A0", VA = "0x1842160A0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class HKNKKGCLFOK : IEnumerable<(TKey, List<TKey>, KMHIBDGLMBH)>, IEnumerable, IEnumerator<(TKey, List<TKey>, KMHIBDGLMBH)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private (TKey key, List<TKey> path, KMHIBDGLMBH timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public PMKGFNIFFEC<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private IEnumerator<(TKey key, List<TKey> path, KMHIBDGLMBH timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private (TKey, List<TKey>, KMHIBDGLMBH) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x241D850", Offset = "0x241CC50", VA = "0x18241D850", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, KMHIBDGLMBH));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x40B0020", Offset = "0x40AF420", VA = "0x1840B0020", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x241D940", Offset = "0x241CD40", VA = "0x18241D940")]
		[DebuggerHidden]
		public HKNKKGCLFOK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x3DBD6E0", Offset = "0x3DBCAE0", VA = "0x183DBD6E0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x40AFAF0", Offset = "0x40AEEF0", VA = "0x1840AFAF0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x40AFEA0", Offset = "0x40AF2A0", VA = "0x1840AFEA0")]
		private void PKLCPOPHKJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x40AFFD0", Offset = "0x40AF3D0", VA = "0x1840AFFD0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x40AFEF0", Offset = "0x40AF2F0", VA = "0x1840AFEF0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, KMHIBDGLMBH)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x3B41BB0", Offset = "0x3B40FB0", VA = "0x183B41BB0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private sealed class FHGFFGIGEDH : IEnumerable<(TKey, List<TKey>, KMHIBDGLMBH)>, IEnumerable, IEnumerator<(TKey, List<TKey>, KMHIBDGLMBH)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private (TKey key, List<TKey> path, KMHIBDGLMBH timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private INNANANOCLO timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public INNANANOCLO <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public PMKGFNIFFEC<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private IEnumerator<INNANANOCLO> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private IEnumerator<(TKey key, List<TKey> path, KMHIBDGLMBH timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		private (TKey, List<TKey>, KMHIBDGLMBH) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x241D850", Offset = "0x241CC50", VA = "0x18241D850", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, KMHIBDGLMBH));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x3F1D300", Offset = "0x3F1C700", VA = "0x183F1D300", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x241D940", Offset = "0x241CD40", VA = "0x18241D940")]
		[DebuggerHidden]
		public FHGFFGIGEDH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x3F1D360", Offset = "0x3F1C760", VA = "0x183F1D360", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x3F1C930", Offset = "0x3F1BD30", VA = "0x183F1C930", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x3F1D110", Offset = "0x3F1C510", VA = "0x183F1D110")]
		private void PKLCPOPHKJE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x3F1C8D0", Offset = "0x3F1BCD0", VA = "0x183F1C8D0")]
		private void EMBCDMFMIHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x3F1D2B0", Offset = "0x3F1C6B0", VA = "0x183F1D2B0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x3F1D170", Offset = "0x3F1C570", VA = "0x183F1D170", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, KMHIBDGLMBH)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x3F1D270", Offset = "0x3F1C670", VA = "0x183F1D270", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly Action<TKey, KMHIBDGLMBH, EGGMDNJPOBA> GOJCAOMDOHA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly Action<TKey, KMHIBDGLMBH, EGGMDNJPOBA> ONGCFGEALLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly Action<PMKGFNIFFEC<TKey>, EGGMDNJPOBA> KDMNMCJMGOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly EGGMDNJPOBA DFDLACHAHGJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly INNANANOCLO FADFPMJHPBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private bool LNIMNIKGCDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private int LMCNBNNIIFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly Stopwatch CDAIPIPNKHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly int OEHJOEINPDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private string GNEEDOINBLH;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public INNANANOCLO LLHDLABBPKD
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x8AE500", Offset = "0x8AD900", VA = "0x1808AE500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	[NotNull]
	public string FNHKCFBBJPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x8ADBA0", Offset = "0x8ACFA0", VA = "0x1808ADBA0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x4B76670", Offset = "0x4B75A70", VA = "0x184B76670")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x4B768F0", Offset = "0x4B75CF0", VA = "0x184B768F0")]
	public PMKGFNIFFEC(TKey HKODDPDBFKL, EGGMDNJPOBA DFDLACHAHGJ, [Optional] int? KFOFEMEMDEF, [Optional][CanBeNull] Stopwatch CDAIPIPNKHN, [Optional] Action<TKey, KMHIBDGLMBH, EGGMDNJPOBA> GOJCAOMDOHA, [Optional] Action<TKey, KMHIBDGLMBH, EGGMDNJPOBA> ONGCFGEALLI, [Optional] Action<PMKGFNIFFEC<TKey>, EGGMDNJPOBA> KDMNMCJMGOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x4B76590", Offset = "0x4B75990", VA = "0x184B76590", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x4B76840", Offset = "0x4B75C40", VA = "0x184B76840")]
	[IteratorStateMachine(typeof(PMKGFNIFFEC<>.HKNKKGCLFOK))]
	public IEnumerable<(TKey, List<TKey>, KMHIBDGLMBH)> LJMLNJHGKCH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x4B76750", Offset = "0x4B75B50", VA = "0x184B76750")]
	[IteratorStateMachine(typeof(PMKGFNIFFEC<>.FHGFFGIGEDH))]
	private IEnumerable<(TKey, List<TKey>, KMHIBDGLMBH)> LJMLNJHGKCH(List<TKey> BLDDFJAJFGI, INNANANOCLO ALKAKFCLFJO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x4B766D0", Offset = "0x4B75AD0", VA = "0x184B766D0")]
	private (long, int) ICAAHINOAKH()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public abstract class LLIBGCABNCE<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut LIBKPIMKLJA(PMKGFNIFFEC<TKey> GBIEPJHIGOL);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	protected LLIBGCABNCE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public abstract class NLDGOLJPLAG<TKey> : LLIBGCABNCE<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public delegate string ODPKBLPNJFI(TKey GMJINMLEEAC);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x48D0500", Offset = "0x48CF900", VA = "0x1848D0500")]
	private static string PMLPOOOJMME(TKey GMJINMLEEAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x48D02B0", Offset = "0x48CF6B0", VA = "0x1848D02B0", Slot = "4")]
	public override string LIBKPIMKLJA(PMKGFNIFFEC<TKey> GBIEPJHIGOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x48D03A0", Offset = "0x48CF7A0", VA = "0x1848D03A0")]
	public string LIBKPIMKLJA(PMKGFNIFFEC<TKey> GBIEPJHIGOL, [NotNull] ODPKBLPNJFI DOHJOMJOBJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string GGBLLEGCIMP(PMKGFNIFFEC<TKey> GBIEPJHIGOL, [NotNull] ODPKBLPNJFI DOHJOMJOBJH);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3B77180", Offset = "0x3B76580", VA = "0x183B77180")]
	protected NLDGOLJPLAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class GFJGIBFMOCJ<TKey> : LLIBGCABNCE<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public delegate string DKGHFFIEAFF(TKey GMJINMLEEAC);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly string GDDAACLNCDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly double HAPLDBLIGPI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly bool ADCPEJHPMIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly int HALEMLJGCOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly ISet<string> BNLDBPIPKCO;

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3FE1EA0", Offset = "0x3FE12A0", VA = "0x183FE1EA0")]
	private static string PMLPOOOJMME(TKey GMJINMLEEAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3FE1EE0", Offset = "0x3FE12E0", VA = "0x183FE1EE0")]
	public GFJGIBFMOCJ(string GDDAACLNCDD = "F2", double HAPLDBLIGPI = double.MaxValue, bool ADCPEJHPMIM = false, int HALEMLJGCOF = int.MaxValue, [Optional] ISet<string> BNLDBPIPKCO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x3FE1DB0", Offset = "0x3FE11B0", VA = "0x183FE1DB0", Slot = "4")]
	public override Dictionary<string, string> LIBKPIMKLJA(PMKGFNIFFEC<TKey> GBIEPJHIGOL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3FE1680", Offset = "0x3FE0A80", VA = "0x183FE1680")]
	private bool HOOCOPGGCDB(string HGBNNHFBFKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x3FE1760", Offset = "0x3FE0B60", VA = "0x183FE1760")]
	public Dictionary<string, string> LIBKPIMKLJA(PMKGFNIFFEC<TKey> GBIEPJHIGOL, DKGHFFIEAFF DOHJOMJOBJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x3FE1400", Offset = "0x3FE0800", VA = "0x183FE1400")]
	private string FGKELGJHOCN(StringBuilder BDNKNCMLEFK, List<TKey> LGGDOIPCNCM, DKGHFFIEAFF DOHJOMJOBJH, bool IJEGJOHFNDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x3FE12A0", Offset = "0x3FE06A0", VA = "0x183FE12A0")]
	private static void DPHECMDIODI(StringBuilder NPJGPDFCBCD, string EBNPHPPCMEO, bool HPJOCMFCPHG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class HFIHIJFAOGI<TKey> : NLDGOLJPLAG<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct HPGJOIEGJOC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public ODPKBLPNJFI keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public static HFIHIJFAOGI<TKey> FKMJLLKHOAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly string[] KINJGHMKCAL;

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x40891B0", Offset = "0x40885B0", VA = "0x1840891B0")]
	private HFIHIJFAOGI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x4088100", Offset = "0x4087500", VA = "0x184088100", Slot = "5")]
	protected override string GGBLLEGCIMP(PMKGFNIFFEC<TKey> GBIEPJHIGOL, ODPKBLPNJFI DOHJOMJOBJH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x4088F50", Offset = "0x4088350", VA = "0x184088F50")]
	[CompilerGenerated]
	internal static string HLMLPMOCGKM(string IHNIKDHMNKJ, TKey GMJINMLEEAC, HPGJOIEGJOC P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public sealed class EPOFAIEJKBJ : PMKGFNIFFEC<string>
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class LNNGPNCMGNC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public Action<EPOFAIEJKBJ, EGGMDNJPOBA> callback;

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public LNNGPNCMGNC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x6DB01D0", Offset = "0x6DAF5D0", VA = "0x186DB01D0")]
		internal void MIOKABFGEJO(PMKGFNIFFEC<string> timer, EGGMDNJPOBA log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6DAF510", Offset = "0x6DAE910", VA = "0x186DAF510")]
	public EPOFAIEJKBJ(EGGMDNJPOBA DFDLACHAHGJ, [Optional] string PABJMPEAIGA, [Optional] int? KFOFEMEMDEF, [Optional] Stopwatch CDAIPIPNKHN, [Optional] Action<string, KMHIBDGLMBH, EGGMDNJPOBA> GOJCAOMDOHA, [Optional] Action<string, KMHIBDGLMBH, EGGMDNJPOBA> ONGCFGEALLI, [Optional] Action<EPOFAIEJKBJ, EGGMDNJPOBA> KDMNMCJMGOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6DAF450", Offset = "0x6DAE850", VA = "0x186DAF450")]
	private static Action<PMKGFNIFFEC<string>, EGGMDNJPOBA> LOHDCDBABCJ(Action<EPOFAIEJKBJ, EGGMDNJPOBA> BNNBDLHMCLC)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public abstract class OKPFFOMGMHC
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private class FCJOOLFJEKH : OKPFFOMGMHC
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public static OKPFFOMGMHC FKMJLLKHOAH
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x6DAF660", Offset = "0x6DAEA60", VA = "0x186DAF660")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override float GANICAJBNBD
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0xCB4650", Offset = "0xCB3A50", VA = "0x180CB4650", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x6DAF750", Offset = "0x6DAEB50", VA = "0x186DAF750")]
		public FCJOOLFJEKH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static OKPFFOMGMHC BBJPAJCNKCO;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public static OKPFFOMGMHC DPPOJDBEGAC
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x6DB18A0", Offset = "0x6DB0CA0", VA = "0x186DB18A0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public abstract float GANICAJBNBD
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
	protected OKPFFOMGMHC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface PLAOPNDIDAJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool IMHJEBACLHE
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface FLIAEPPCPCN<T> : PLAOPNDIDAJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	[NotNull]
	Task<T> CJJDGCHAJIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	[NotNull]
	MIJNEIJMPHL<T> CAPCGENPCEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class COCHPLALLHA
{
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x2C572F0", Offset = "0x2C566F0", VA = "0x182C572F0")]
	public static FLIAEPPCPCN<TResource> CMOAALKCNNM<TResource, TId>(this CFHDIMIAJNN<TId, TResource> HMKOCECLFBO, TId IHELCOHOCAM, [Optional] Func<TId, CancellationToken, Task<TResource>>? HMLGBNNCOGJ) where TResource : notnull where TId : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class OBIKNAIHIDP
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private sealed class KMMCMBGEBHB<T> : DIJLOMONMJJ<T?> where T : class
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override Task<T?> CJJDGCHAJIE
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override MIJNEIJMPHL<T?> CAPCGENPCEF
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x8AA330", Offset = "0x8A9730", VA = "0x1808AA330", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x4558960", Offset = "0x4557D60", VA = "0x184558960")]
		public KMMCMBGEBHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "10")]
		protected override void DHDLBJOGNLN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private sealed class BIFFKCDEALK<T> : DIJLOMONMJJ<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly T CHNBFPNODAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly Action<T>? MHJMIOGFFNI;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override Task<T> CJJDGCHAJIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F50", Offset = "0x8A9350", VA = "0x1808A9F50", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override MIJNEIJMPHL<T> CAPCGENPCEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x8A9D20", Offset = "0x8A9120", VA = "0x1808A9D20", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x5278320", Offset = "0x5277720", VA = "0x185278320")]
		public BIFFKCDEALK(T EHFHDBPLLGN, Action<T>? FEMGHJNBLNC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x52782C0", Offset = "0x52776C0", VA = "0x1852782C0", Slot = "10")]
		protected override void DHDLBJOGNLN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private sealed class IBEMHFADLGJ<T> : DIJLOMONMJJ<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override Task<T> CJJDGCHAJIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override MIJNEIJMPHL<T> CAPCGENPCEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x8AA330", Offset = "0x8A9730", VA = "0x1808AA330", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x415CF90", Offset = "0x415C390", VA = "0x18415CF90")]
		public IBEMHFADLGJ(Exception PBLCLNMOIGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "10")]
		protected override void DHDLBJOGNLN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private sealed class EONNDONHKED<T> : DIJLOMONMJJ<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[CompilerGenerated]
		private struct PBKBDMGDEPH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public Task<FLIAEPPCPCN<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			private TaskAwaiter<FLIAEPPCPCN<T>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private TaskAwaiter<T> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x4B4B650", Offset = "0x4B4AA50", VA = "0x184B4B650", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x4B4BB90", Offset = "0x4B4AF90", VA = "0x184B4BB90", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		[CompilerGenerated]
		private struct HKKDFDNPBAA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public Task<FLIAEPPCPCN<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			private TaskAwaiter<FLIAEPPCPCN<T>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x40AF140", Offset = "0x40AE540", VA = "0x1840AF140", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x40AF620", Offset = "0x40AEA20", VA = "0x1840AF620", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private readonly Task<FLIAEPPCPCN<T>> IMCLPNAPMHD;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override Task<T> CJJDGCHAJIE
		{
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x8AA330", Offset = "0x8A9730", VA = "0x1808AA330", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override MIJNEIJMPHL<T> CAPCGENPCEF
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x8AA340", Offset = "0x8A9740", VA = "0x1808AA340", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x3B75200", Offset = "0x3B74600", VA = "0x183B75200")]
		public EONNDONHKED(Task<FLIAEPPCPCN<T>> BIDGKFLMMBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x3B74C90", Offset = "0x3B74090", VA = "0x183B74C90", Slot = "10")]
		protected override void DHDLBJOGNLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x3B74F00", Offset = "0x3B74300", VA = "0x183B74F00")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(EONNDONHKED<>.PBKBDMGDEPH))]
		internal static Task<T> EJEBOAKGBEG(Task<FLIAEPPCPCN<T>> BIDGKFLMMBN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x3B74E10", Offset = "0x3B74210", VA = "0x183B74E10")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(EONNDONHKED<>.HKKDFDNPBAA))]
		internal static Task DODJEADGEGB(Task<FLIAEPPCPCN<T>> BIDGKFLMMBN)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private sealed class EPNIIGMOODC<TIn, TOut> : DIJLOMONMJJ<TOut> where TIn : notnull where TOut : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private struct LEKCJCMJEPO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public AsyncTaskMethodBuilder<TOut> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			public Func<TIn, TOut> transformFunc;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public Task<TIn> innerTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			private Func<TIn, TOut> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private TaskAwaiter<TIn> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x45D5A80", Offset = "0x45D4E80", VA = "0x1845D5A80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x3FD5E40", Offset = "0x3FD5240", VA = "0x183FD5E40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly FLIAEPPCPCN<TIn> GDOMMJDPJLM;

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override Task<TOut> CJJDGCHAJIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x8AA330", Offset = "0x8A9730", VA = "0x1808AA330", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override MIJNEIJMPHL<TOut> CAPCGENPCEF
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x8AA340", Offset = "0x8A9740", VA = "0x1808AA340", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x3B77580", Offset = "0x3B76980", VA = "0x183B77580")]
		public EPNIIGMOODC(FLIAEPPCPCN<TIn> LDEKOGDAABJ, Func<TIn, TOut> OGIBFEOBDJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x3B774E0", Offset = "0x3B768E0", VA = "0x183B774E0", Slot = "10")]
		protected override void DHDLBJOGNLN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x3B77350", Offset = "0x3B76750", VA = "0x183B77350")]
		[AsyncStateMachine(typeof(EPNIIGMOODC<, >.LEKCJCMJEPO))]
		[CompilerGenerated]
		internal static Task<TOut> AEKJIHBOAMG(Task<TIn> OANCLONEIKP, Func<TIn, TOut> OGIBFEOBDJG)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x2FF22D0", Offset = "0x2FF16D0", VA = "0x182FF22D0")]
	public static FLIAEPPCPCN<T> NHLFLGLAPGF<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x2FF2220", Offset = "0x2FF1620", VA = "0x182FF2220")]
	public static FLIAEPPCPCN<T> IEOHEJNGJCL<T>(T CIFMGKBFCHA, [Optional] Action<T>? FEMGHJNBLNC) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x2E503D0", Offset = "0x2E4F7D0", VA = "0x182E503D0")]
	public static FLIAEPPCPCN<T> OACBNMOEDGH<T>(Exception PBLCLNMOIGC) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x2E503D0", Offset = "0x2E4F7D0", VA = "0x182E503D0")]
	public static FLIAEPPCPCN<T> GFBJEHLLGMI<T>(Task<FLIAEPPCPCN<T>> BIDGKFLMMBN) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x2BEDC10", Offset = "0x2BED010", VA = "0x182BEDC10")]
	public static FLIAEPPCPCN<TOut> GCKCOGKHDGG<TOut, TIn>(FLIAEPPCPCN<TIn> PKDPMCLKPHH, Func<TIn, TOut> OGIBFEOBDJG) where TOut : notnull where TIn : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public abstract class DIJLOMONMJJ<T> : FLIAEPPCPCN<T>, PLAOPNDIDAJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private static readonly string JCGNEJEKBPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly ALFOLKGPCLL OKFIDAOIOAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private bool LNIMNIKGCDA;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public bool IMHJEBACLHE
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xE81EA0", Offset = "0xE812A0", VA = "0x180E81EA0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public abstract Task<T> CJJDGCHAJIE
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public abstract MIJNEIJMPHL<T> CAPCGENPCEF
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5C31CA0", Offset = "0x5C310A0", VA = "0x185C31CA0")]
	public DIJLOMONMJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x5C318F0", Offset = "0x5C30CF0", VA = "0x185C318F0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void DHDLBJOGNLN();
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public abstract class PMDMPHJALAF<TTask, T> : DIJLOMONMJJ<T> where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class JCLEFNMHNOB
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004F")]
		private struct <<-ctor>g__AwaitThenTransformTaskResult|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BF")]
			public TTask originalTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C0")]
			public JCLEFNMHNOB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x3888E60", Offset = "0x3888260", VA = "0x183888E60", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x38893D0", Offset = "0x38887D0", VA = "0x1838893D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public PMDMPHJALAF<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public JCLEFNMHNOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x441A1D0", Offset = "0x44195D0", VA = "0x18441A1D0")]
		[AsyncStateMachine(typeof(PMDMPHJALAF<, >.JCLEFNMHNOB.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> MILJOPIPNNJ(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private readonly Task<T> BIDGKFLMMBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	protected readonly CancellationTokenSource INFCCFLIMCN;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public override Task<T> CJJDGCHAJIE
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public override MIJNEIJMPHL<T> CAPCGENPCEF
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x8AA330", Offset = "0x8A9730", VA = "0x1808AA330", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x4B74E60", Offset = "0x4B74260", VA = "0x184B74E60")]
	protected PMDMPHJALAF(TTask BIDGKFLMMBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x4B74E10", Offset = "0x4B74210", VA = "0x184B74E10", Slot = "10")]
	protected override void DHDLBJOGNLN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract T HIHPHPGPLJL(TTask FIHALOMIDNB);

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "12")]
	protected abstract void GOIEHLKKJDP();
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class BGALCMCFOPO<T> : DIJLOMONMJJ<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly CCELPPEDKLE<Task<T>> BMFAJCPPADN;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public override Task<T> CJJDGCHAJIE
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x401A5A0", Offset = "0x40199A0", VA = "0x18401A5A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public override MIJNEIJMPHL<T> CAPCGENPCEF
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x8AA330", Offset = "0x8A9730", VA = "0x1808AA330", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x52762B0", Offset = "0x52756B0", VA = "0x1852762B0")]
	public BGALCMCFOPO(CCELPPEDKLE<Task<T>> AEKCHKDBJNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x5276290", Offset = "0x5275690", VA = "0x185276290", Slot = "10")]
	protected override void DHDLBJOGNLN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class LIEDJENLLBM
{
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public static readonly HashAlgorithmName KBOIICMDGHF;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly ThreadLocal<IncrementalHash> EIEPNBINAFI;

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6DAFF80", Offset = "0x6DAF380", VA = "0x186DAFF80")]
	public static int KPACJFIJBOF(this LHGLLBFNCJL EKFDAGHNIGH, IncrementalHash EIIBADICFOJ, byte[] IOKHMEHKOGF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x6DAF8E0", Offset = "0x6DAECE0", VA = "0x186DAF8E0")]
	public static bool BOLGPKKKHHF([CanBeNull] this LHGLLBFNCJL EKFDAGHNIGH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x6DAF940", Offset = "0x6DAED40", VA = "0x186DAF940")]
	public static bool BOLGPKKKHHF([CanBeNull] this LHGLLBFNCJL EKFDAGHNIGH, [Out] string GJAHCEMFFMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x6DAFC50", Offset = "0x6DAF050", VA = "0x186DAFC50")]
	public static bool BOLGPKKKHHF([CanBeNull] this LHGLLBFNCJL EKFDAGHNIGH, IncrementalHash EIIBADICFOJ, byte[] IOKHMEHKOGF, [Out] string GJAHCEMFFMA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x6DB0000", Offset = "0x6DAF400", VA = "0x186DB0000")]
	private static bool PNHNPHFAEHN(byte[] DIHHEHNLILG, Span<byte> ELKOBHHKJGN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class MKNPIEPKPAN
{
	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x6DB0530", Offset = "0x6DAF930", VA = "0x186DB0530")]
	public static int NIOLFBCMACB(HashAlgorithmName GEEFELIJCCJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6DB02D0", Offset = "0x6DAF6D0", VA = "0x186DB02D0")]
	public static int KPACJFIJBOF(this CJKACODNIDP DGGGAHGKKLJ, byte[] INIICOPEICE, IncrementalHash EIIBADICFOJ, byte[] OKLBHEPBBFO)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public interface CJKACODNIDP
{
	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash EIIBADICFOJ);
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface LHGLLBFNCJL : CJKACODNIDP
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	[CanBeNull]
	byte[] IJKHONNDMBA
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	[CanBeNull]
	byte[] BANDOFNOIBL
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class DLCALINPJPP
{
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static bool HLBJHLIHDHF;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly ArrayPool<byte> GLHJKOACPHP;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly ArrayPool<char> LJDBPFAKAOP;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly Encoding LCKPNCBBIBA;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly ThreadLocal<Encoder> ODHKIEONLKA;

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x2C89D60", Offset = "0x2C89160", VA = "0x182C89D60")]
	public static void MOAEMJMBMBF<T>(this IncrementalHash EHJAPEFGKEP, [CanBeNull] T FCNHHPDOLNN) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x2C89E20", Offset = "0x2C89220", VA = "0x182C89E20")]
	public static void NMBMCFDNHNJ<T>(this IncrementalHash EHJAPEFGKEP, [CanBeNull] T DGGGAHGKKLJ) where T : CJKACODNIDP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x2C89210", Offset = "0x2C88610", VA = "0x182C89210")]
	public static void KNLJNCHDAOB<T>(this IncrementalHash EHJAPEFGKEP, [CanBeNull] IList<T> BOBFOIHNGGD) where T : CJKACODNIDP
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x6DAE230", Offset = "0x6DAD630", VA = "0x186DAE230")]
	private static bool BGNOOGLIBEA([CanBeNull] CJKACODNIDP DGGGAHGKKLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x6DAE6C0", Offset = "0x6DADAC0", VA = "0x186DAE6C0")]
	public static void FGOKMKDNMKI(this IncrementalHash EIIBADICFOJ, string? CLPEKNBALGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x6DAE490", Offset = "0x6DAD890", VA = "0x186DAE490")]
	public static void EGEIONPOFHJ(this IncrementalHash EIIBADICFOJ, long BPGPJEKNOMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x6DAE2C0", Offset = "0x6DAD6C0", VA = "0x186DAE2C0")]
	public static void DMNBLDNJLAL(this IncrementalHash EIIBADICFOJ, int GEAPENHKIKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEC30", Offset = "0x6DAE030", VA = "0x186DAEC30")]
	public static void HICOJAJILOK(this IncrementalHash EIIBADICFOJ, short MGFNOGILDBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEAC0", Offset = "0x6DADEC0", VA = "0x186DAEAC0")]
	public static void GBFJFHOOFKM(this IncrementalHash EIIBADICFOJ, byte OPBGEHJMPAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEE60", Offset = "0x6DAE260", VA = "0x186DAEE60")]
	public static void MGILOJKHDDF(this IncrementalHash EIIBADICFOJ, bool KBMJMNEBNDP, bool FBKBDAANKFE = false, bool NMHJNCKPJHL = false, bool HKPBKDDBPHA = false, bool CAKLKEPBMGM = false, bool FKGDGKMLLJK = false, bool AGMHGDOJACG = false, bool CBLMKKJAMLI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x2C89730", Offset = "0x2C88B30", VA = "0x182C89730")]
	public static void MEABLAADBOM<T>(this IncrementalHash EIIBADICFOJ, T CCLPDLLIEKA) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEE00", Offset = "0x6DAE200", VA = "0x186DAEE00")]
	public static void KAKJFLFKGON(this IncrementalHash EIIBADICFOJ, float MPPPBDOIBKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEFD0", Offset = "0x6DAE3D0", VA = "0x186DAEFD0")]
	public static void PANIBDCLHAJ(this IncrementalHash EIIBADICFOJ, ulong ODBHFLBEENF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x6DAE660", Offset = "0x6DADA60", VA = "0x186DAE660")]
	public static void ENNPDFNKMLP(this IncrementalHash EIIBADICFOJ, uint AJJMPBKLGOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x6DAEBD0", Offset = "0x6DADFD0", VA = "0x186DAEBD0")]
	public static void GCDLFPEEMPH(this IncrementalHash EIIBADICFOJ, ushort JNFAFOAMDIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x6DAF030", Offset = "0x6DAE430", VA = "0x186DAF030")]
	public static void PBKFAKKPHOL(this IncrementalHash EIIBADICFOJ, Vector3 JJDDDPNDFEE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class NAIKMGEMPBA : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x6DB0680", Offset = "0x6DAFA80", VA = "0x186DB0680")]
	public NAIKMGEMPBA(string ADPAIBGIHMB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public abstract class CCDBOKMOKGF<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	internal class BGEKPNFNJPJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public TNode MBGHIKEGJAA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public TNode IIOPLDELPHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public FHANEKEDJGI IMHKEPBHMIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public List<FHANEKEDJGI> MGLPIINJHPA;

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public BGEKPNFNJPJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	internal struct FHANEKEDJGI : IComparable<FHANEKEDJGI>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public int EKKNGGKNJOL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public TClaimant BPBAGHBELIO;

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x10CA180", Offset = "0x10C9580", VA = "0x1810CA180")]
		public FHANEKEDJGI(int EKKNGGKNJOL, TClaimant BPBAGHBELIO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3F1C320", Offset = "0x3F1B720", VA = "0x183F1C320")]
		public bool EOJOBGNDPIN([In] FHANEKEDJGI OCKBFCIKBEN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x3F1C380", Offset = "0x3F1B780", VA = "0x183F1C380")]
		public bool HKAAIBHIFFN([In] FHANEKEDJGI OCKBFCIKBEN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x3F1C310", Offset = "0x3F1B710", VA = "0x183F1C310", Slot = "4")]
		public int CompareTo(FHANEKEDJGI OCKBFCIKBEN)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3F1C390", Offset = "0x3F1B790", VA = "0x183F1C390", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public enum BGAPLLDNAJM
	{
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class JGDKLHEEKEI : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public CCDBOKMOKGF<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x1700004D")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B0")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B2")]
			[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0xA24590", Offset = "0xA23990", VA = "0x180A24590")]
		[DebuggerHidden]
		public JGDKLHEEKEI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x442AA90", Offset = "0x4429E90", VA = "0x18442AA90", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x442AC70", Offset = "0x442A070", VA = "0x18442AC70", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x442AB70", Offset = "0x4429F70", VA = "0x18442AB70", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x3DBED10", Offset = "0x3DBE110", VA = "0x183DBED10", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private static readonly CBIGCBOHNBJ<BGEKPNFNJPJ> GLFMJNNCFOE;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly CBIGCBOHNBJ<List<FHANEKEDJGI>> GKBJELMPIJG;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static int GOAINKDNLEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	internal readonly Dictionary<TClaimant, TNode> MEMHCPKLHBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	internal readonly Dictionary<TNode, BGEKPNFNJPJ> LIECFIBHMLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private BGAPLLDNAJM EEKKEDKPKFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private bool HLAMJAHICLD;

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode INPHMHOLIBC(TNode ABBPLCKDHFH);

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void BIGKKANKEEH(TNode ABBPLCKDHFH, TClaimant PCPBBKNNKNF, TClaimant MEKCJFCJDMG);

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x53056C0", Offset = "0x5304AC0", VA = "0x1853056C0")]
	public CCDBOKMOKGF(BGAPLLDNAJM EEKKEDKPKFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x53044C0", Offset = "0x53038C0", VA = "0x1853044C0")]
	public void FNCHGDPADEE(TNode ABBPLCKDHFH, TNode FFCFOAEFPGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x5304590", Offset = "0x5303990", VA = "0x185304590")]
	public void IEELHDCALAD(TClaimant BPBAGHBELIO, TNode OBEALNIHPDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x53040C0", Offset = "0x53034C0", VA = "0x1853040C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x5303AB0", Offset = "0x5302EB0", VA = "0x185303AB0")]
	private void AEEAPJMHHFN(TClaimant BPBAGHBELIO, TNode IMAPPNACGJO, TNode OBEALNIHPDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x5304450", Offset = "0x5303850", VA = "0x185304450")]
	private int FLAENGDEIDO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x5303B80", Offset = "0x5302F80", VA = "0x185303B80")]
	private void BEFDBOKOHPN(TClaimant BPBAGHBELIO, TNode LPHFMBLHOGO, TNode DBKGKALEDOH, int DNMNPHDMKGF = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x5303FE0", Offset = "0x53033E0", VA = "0x185303FE0")]
	private void CCHDLAGLFLD(FHANEKEDJGI GCIJNIPLGIE, BGEKPNFNJPJ KFGHKJHEFCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x5304900", Offset = "0x5303D00", VA = "0x185304900")]
	private void LLHOOIEDGKM(TClaimant BPBAGHBELIO, TNode LPHFMBLHOGO, TNode DBKGKALEDOH, int DNMNPHDMKGF = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x53050B0", Offset = "0x53044B0", VA = "0x1853050B0")]
	private void MFBGKAJGCFF(FHANEKEDJGI GCIJNIPLGIE, TNode ABBPLCKDHFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x53042E0", Offset = "0x53036E0", VA = "0x1853042E0")]
	private void FKIIPHMLFIB(FHANEKEDJGI GCIJNIPLGIE, BGEKPNFNJPJ KFGHKJHEFCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x53051F0", Offset = "0x53045F0", VA = "0x1853051F0")]
	private void NNKGICDNIBH(BGEKPNFNJPJ KFGHKJHEFCL, bool HGLCNLMNLBC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x5304D20", Offset = "0x5304120", VA = "0x185304D20")]
	private void MDBLIKHEAAN(BGEKPNFNJPJ KFGHKJHEFCL, TNode FFCFOAEFPGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x5303EE0", Offset = "0x53032E0", VA = "0x185303EE0")]
	[IteratorStateMachine(typeof(CCDBOKMOKGF<, >.JGDKLHEEKEI))]
	private IEnumerable<TNode> BEHIDGABPAN(TNode LPHFMBLHOGO, TNode DBKGKALEDOH, bool HKAEOGKPCMI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x5304C00", Offset = "0x5304000", VA = "0x185304C00")]
	private BGEKPNFNJPJ MBFMGCLBMCL(TNode ABBPLCKDHFH, TNode IIOPLDELPHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x5305350", Offset = "0x5304750", VA = "0x185305350")]
	private BGEKPNFNJPJ OMFFACJCDEI(TNode ABBPLCKDHFH, TNode IIOPLDELPHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x5304730", Offset = "0x5303B30", VA = "0x185304730")]
	private void KMIJFHACKPL(BGEKPNFNJPJ KFGHKJHEFCL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class MBIODKLGEBC<T> : IEnumerable<MBIODKLGEBC<T>.BKLCGLMCABC>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public struct BKLCGLMCABC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public T LIHHDPOHLDK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public int AEAHMAMPNLO;
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public class KOFCNIJGDJJ : IEnumerator<BKLCGLMCABC>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private MBIODKLGEBC<T> NBJBCOJNBPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private int AEAHMAMPNLO;

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x3B7C610", Offset = "0x3B7BA10", VA = "0x183B7C610", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public BKLCGLMCABC BLKMEFCLAAD
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x455BB30", Offset = "0x455AF30", VA = "0x18455BB30", Slot = "4")]
			get
			{
				return default(BKLCGLMCABC);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x455BAF0", Offset = "0x455AEF0", VA = "0x18455BAF0")]
		public KOFCNIJGDJJ(MBIODKLGEBC<T> NBJBCOJNBPF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x455BA70", Offset = "0x455AE70", VA = "0x18455BA70", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x3BD2890", Offset = "0x3BD1C90", VA = "0x183BD2890", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0xC64AF0", Offset = "0xC63EF0", VA = "0x180C64AF0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	private struct BOMJOBKOAJD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public bool JHFFMNHBEIO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public T LIHHDPOHLDK;
	}

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private const int PBBFBCNHIPM = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly Dictionary<T, int> GEJODKHPHKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private BOMJOBKOAJD[] PJDJIGKPBED;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private int AJKAHOKNFED;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public int KPCOKDPECHD
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x8EAF70", Offset = "0x8EA370", VA = "0x1808EAF70")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x8EA560", Offset = "0x8E9960", VA = "0x1808EA560")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public int NJGLPGPPJOG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x389B8C0", Offset = "0x389ACC0", VA = "0x18389B8C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x48038A0", Offset = "0x4802CA0", VA = "0x1848038A0")]
	public MBIODKLGEBC(int MLLKNBDHHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x4803460", Offset = "0x4802860", VA = "0x184803460")]
	public MBIODKLGEBC(BKLCGLMCABC[] NGFEDFAKHGF, bool BJFFMMIJJEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x48020B0", Offset = "0x48014B0", VA = "0x1848020B0")]
	public int BAMAEGEKMHE()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x4802450", Offset = "0x4801850", VA = "0x184802450")]
	private int GANBJNKHLKG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x48026C0", Offset = "0x4801AC0", VA = "0x1848026C0", Slot = "6")]
	protected virtual uint GDADLEMCCBO(uint EIIBADICFOJ, T LIHHDPOHLDK)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x4802F10", Offset = "0x4802310", VA = "0x184802F10")]
	public bool NEIOGECFNMJ(T LIHHDPOHLDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x4802830", Offset = "0x4801C30", VA = "0x184802830")]
	public int MIKNCIKMOOO(T LIHHDPOHLDK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x4802740", Offset = "0x4801B40", VA = "0x184802740")]
	public T GMGOKDOKMEE(int AEAHMAMPNLO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x4802E40", Offset = "0x4802240", VA = "0x184802E40")]
	public bool MNCFLHJHNAL(T LIHHDPOHLDK, bool ONFEIALNLEL = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x48028C0", Offset = "0x4801CC0", VA = "0x1848028C0")]
	public bool MNCFLHJHNAL(T LIHHDPOHLDK, int AEAHMAMPNLO, bool ONFEIALNLEL = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x48021D0", Offset = "0x48015D0", VA = "0x1848021D0")]
	private int FKPMCBBPJJG(int IHLILPEDKCL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x4802F70", Offset = "0x4802370", VA = "0x184802F70", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x4802F70", Offset = "0x4802370", VA = "0x184802F70", Slot = "4")]
	private IEnumerator<BKLCGLMCABC> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class CBIGCBOHNBJ<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly Stack<T> GOBLLDAPGMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly List<T> FELMMCLIAJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly int JPJJPKCCKFF;

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x53025E0", Offset = "0x53019E0", VA = "0x1853025E0")]
	public static CBIGCBOHNBJ<T> ACHGECHCDJH(int MLLKNBDHHFM = 0, int JPJJPKCCKFF = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x53027E0", Offset = "0x5301BE0", VA = "0x1853027E0")]
	public static CBIGCBOHNBJ<T> DKMLMAEDGLK(int MLLKNBDHHFM = 0, int JPJJPKCCKFF = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x5302F90", Offset = "0x5302390", VA = "0x185302F90")]
	public CBIGCBOHNBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x5302FE0", Offset = "0x53023E0", VA = "0x185302FE0")]
	public CBIGCBOHNBJ(int MLLKNBDHHFM, int JPJJPKCCKFF = int.MaxValue, bool LFFOOFDIOBI = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x5302AC0", Offset = "0x5301EC0", VA = "0x185302AC0")]
	public T KGLKHOLMLDN()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x5302EA0", Offset = "0x53022A0", VA = "0x185302EA0")]
	public void PHDJEGBOJIB(T LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x53026E0", Offset = "0x5301AE0", VA = "0x1853026E0")]
	private void COBIFBFCFCO(T LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x5302A70", Offset = "0x5301E70", VA = "0x185302A70")]
	private void GPIKOGECGNK(T LIHHDPOHLDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x53028E0", Offset = "0x5301CE0", VA = "0x1853028E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x5302CA0", Offset = "0x53020A0", VA = "0x185302CA0")]
	private void LPAGEAGICAI(IEnumerable<T> BIHDACIMKFK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class HHCGNBDIDKC<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private Dictionary<int, T> KFEJHMHFKIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private T OOPOOILFIIE;

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public virtual T PKLDFHBCJGE
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F10", Offset = "0x8A9310", VA = "0x1808A9F10", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F40", Offset = "0x8A9340", VA = "0x1808A9F40", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x408C890", Offset = "0x408BC90", VA = "0x18408C890")]
	public bool ABPBJIKCHMH(T LIHHDPOHLDK, int EKKNGGKNJOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x3B26340", Offset = "0x3B25740", VA = "0x183B26340")]
	public bool CKCBFAMPDJB(int EKKNGGKNJOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x408CC30", Offset = "0x408C030", VA = "0x18408CC30")]
	public T DHOCABFEPBE(int ILMBJJEMHHJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x408CEB0", Offset = "0x408C2B0", VA = "0x18408CEB0")]
	private bool IODKMNKMHON()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x408CE50", Offset = "0x408C250", VA = "0x18408CE50")]
	public bool FDPJDJCOJAH(int EKKNGGKNJOL, [Out] T LIHHDPOHLDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x3B281A0", Offset = "0x3B275A0", VA = "0x183B281A0")]
	public HHCGNBDIDKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class HJJKIMEOIBC<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	protected struct BKEJJEDIABL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public T JKEIFELLNME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public int NNMKEIMDIEH;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	protected readonly List<BKEJJEDIABL> IGBJMHCINDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private T JHAAIHNHGAB;

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public int NJGLPGPPJOG
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x389B8C0", Offset = "0x389ACC0", VA = "0x18389B8C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x40AD2D0", Offset = "0x40AC6D0", VA = "0x1840AD2D0")]
	public bool FCCKHINNPHJ(T LIHHDPOHLDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x40ADE40", Offset = "0x40AD240", VA = "0x1840ADE40")]
	public void PJLPMKJIOFF(T LIHHDPOHLDK, int EKKNGGKNJOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x40AD910", Offset = "0x40ACD10", VA = "0x1840AD910")]
	public bool MAHJHHAHNPL(T LIHHDPOHLDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x40AD6D0", Offset = "0x40ACAD0", VA = "0x1840AD6D0")]
	public void FLFDAJFNFLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x40AD220", Offset = "0x40AC620", VA = "0x1840AD220")]
	public T DDPLJAIGOIG()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x40ADB20", Offset = "0x40ACF20", VA = "0x1840ADB20")]
	protected void NOBHLHINABO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x40ADFE0", Offset = "0x40AD3E0", VA = "0x1840ADFE0")]
	public HJJKIMEOIBC()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		[SerializeField]
		[GNGJGNLFLFE(GODLKEADDAA.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x6DB1B30", Offset = "0x6DB0F30", VA = "0x186DB1B30")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x6DB1E00", Offset = "0x6DB1200", VA = "0x186DB1E00")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x6DB1D10", Offset = "0x6DB1110", VA = "0x186DB1D10")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x6DB1A80", Offset = "0x6DB0E80", VA = "0x186DB1A80")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x6DB1D50", Offset = "0x6DB1150", VA = "0x186DB1D50")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x6DB1C60", Offset = "0x6DB1060", VA = "0x186DB1C60")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x6DB1A00", Offset = "0x6DB0E00", VA = "0x186DB1A00")]
		public ReferencePoint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public abstract class ResourcePrefabReference<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x4D31990", Offset = "0x4D30D90", VA = "0x184D31990", Slot = "4")]
		public virtual T DGJIMKBKNLH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class NBECCENKELP : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private Dictionary<byte, CEPMPCBNAAM> OJODMKBIODA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private readonly CBIGCBOHNBJ<CEPMPCBNAAM> NJJCJAEHNPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly bool HJCNFKMPHKC;

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public CEPMPCBNAAM IBBOFMGMAAO
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F00", Offset = "0x8A9300", VA = "0x1808A9F00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x8A9F20", Offset = "0x8A9320", VA = "0x1808A9F20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public Vector2 HPOMGOHEANK
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x104DDF0", Offset = "0x104D1F0", VA = "0x18104DDF0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x13688A0", Offset = "0x1367CA0", VA = "0x1813688A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	private Vector2 OENPJAJGMFH
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x9EB870", Offset = "0x9EAC70", VA = "0x1809EB870")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public Vector2 EINNMFBDDOF
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x6DB1670", Offset = "0x6DB0A70", VA = "0x186DB1670")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x8B8190", Offset = "0x8B7590", VA = "0x1808B8190")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public int APCCOHNHLJM
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x8A9D40", Offset = "0x8A9140", VA = "0x1808A9D40")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x8A9D30", Offset = "0x8A9130", VA = "0x1808A9D30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x6DB1690", Offset = "0x6DB0A90", VA = "0x186DB1690")]
	public NBECCENKELP(Bounds HEHALPJENOM, Vector2[] MMIGBIIOCIM, int DIMOHGCMAFI, byte IHLILPEDKCL, float NJKDPHGFJGA = 0f, [Optional] CBIGCBOHNBJ<CEPMPCBNAAM> NJJCJAEHNPO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x6DB11E0", Offset = "0x6DB05E0", VA = "0x186DB11E0")]
	public void KIAOOLEEBPI(Bounds HEHALPJENOM, Vector2[] MMIGBIIOCIM, int DIMOHGCMAFI, byte IHLILPEDKCL, float NJKDPHGFJGA = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x6DB0E00", Offset = "0x6DB0200", VA = "0x186DB0E00")]
	public CEPMPCBNAAM FFPGKINFHDG(byte AEAHMAMPNLO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x6DB1110", Offset = "0x6DB0510", VA = "0x186DB1110")]
	public void KBNJKKBLENN(Vector3 MBJNFCDOKCE, float GFECADPHGOD, float JCBNCEHNHCL, List<byte> PPAIIEGPGDE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x6DB0EC0", Offset = "0x6DB02C0", VA = "0x186DB0EC0")]
	public void GILJKAGBIFI(CEPMPCBNAAM.KMPDNJFKHHL GIIHNDMJAHI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x6DB06E0", Offset = "0x6DAFAE0", VA = "0x186DB06E0")]
	public static int BOBHLJCCAHF(Vector2[] MMIGBIIOCIM, int DIMOHGCMAFI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x6DB0EE0", Offset = "0x6DB02E0", VA = "0x186DB0EE0")]
	private CEPMPCBNAAM IJMLBOMNJJM(byte AEAHMAMPNLO, CEPMPCBNAAM.MJJPHDDOEOG NKCCPEJFEJB, CEPMPCBNAAM IIOPLDELPHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x6DB09E0", Offset = "0x6DAFDE0", VA = "0x186DB09E0")]
	private void DAIELOFKGCN(CEPMPCBNAAM IIOPLDELPHL, Vector2[] MMIGBIIOCIM, int DIKMDKMIOBP, int DJPDGKNCLKG, int IONIJLLJNLD, int EAGOFMGKEIC, float NJKDPHGFJGA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x6DB07C0", Offset = "0x6DAFBC0", VA = "0x186DB07C0")]
	private void CMLECOJBBBP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x6DB0DA0", Offset = "0x6DB01A0", VA = "0x186DB0DA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x6DB0E60", Offset = "0x6DB0260", VA = "0x186DB0E60", Slot = "1")]
	~NBECCENKELP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class CEPMPCBNAAM
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public enum MJJPHDDOEOG
	{
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public enum KMPDNJFKHHL
	{
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public byte BMLMCKPLKGH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public Vector3 OIBFFBMBJGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public Vector3 NDEEOPEAONL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public Vector3 HOCFOOHHDEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public Vector3 EHEPBGIOFNK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public MJJPHDDOEOG FKGIKPBHFIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public CEPMPCBNAAM DIEIKKLOHIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public List<CEPMPCBNAAM> IHLOMFBLLNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public bool LLMIACGHFGP;

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x6DAE110", Offset = "0x6DAD510", VA = "0x186DAE110")]
	public CEPMPCBNAAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x6DADCB0", Offset = "0x6DAD0B0", VA = "0x186DADCB0")]
	public void IPADPHKPOBL(CEPMPCBNAAM BBNLJLBANGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x8ABE30", Offset = "0x8AB230", VA = "0x1808ABE30")]
	public void GILJKAGBIFI(int BAKPDLFLFBN, KMPDNJFKHHL GIIHNDMJAHI, int JJDCPJHHIHE = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x6DADE80", Offset = "0x6DAD280", VA = "0x186DADE80")]
	public void KBNJKKBLENN(List<byte> PPAIIEGPGDE, Vector3 MBJNFCDOKCE, float GFECADPHGOD, float JCBNCEHNHCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x6DAE0E0", Offset = "0x6DAD4E0", VA = "0x186DAE0E0")]
	public bool LCHHPCDOHAP(Vector3 HDGFJIGDDLF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x6DADC80", Offset = "0x6DAD080", VA = "0x186DADC80")]
	public bool GMGMAHFMHGB(Vector3 HDGFJIGDDLF, float GIDKGKFOMDH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x6DADDF0", Offset = "0x6DAD1F0", VA = "0x186DADDF0")]
	public void JLABJFAHLGH()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x200006D")]
		public struct BNHEDKFLCJN<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			private readonly List<Component> HGMKHDHJCFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			private readonly bool JGGEMIKMPIM;

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x3EE9040", Offset = "0x3EE8440", VA = "0x183EE9040")]
			public BNHEDKFLCJN(List<Component> HGMKHDHJCFJ, bool JGGEMIKMPIM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x527ECC0", Offset = "0x527E0C0", VA = "0x18527ECC0")]
			public CNCBFNJBCFI<T> MKNNDFMGFGD()
			{
				return default(CNCBFNJBCFI<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x527ED30", Offset = "0x527E130", VA = "0x18527ED30", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x527ED30", Offset = "0x527E130", VA = "0x18527ED30", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006E")]
		public struct CNCBFNJBCFI<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			private readonly List<Component> HGMKHDHJCFJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			private readonly bool JGGEMIKMPIM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			private int AEAHMAMPNLO;

			[Cpp2IlInjected.Token(Token = "0x17000060")]
			public T BLKMEFCLAAD
			{
				[Cpp2IlInjected.Token(Token = "0x600021A")]
				[Cpp2IlInjected.Address(RVA = "0x5332C50", Offset = "0x5332050", VA = "0x185332C50", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000061")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600021B")]
				[Cpp2IlInjected.Address(RVA = "0x5332BE0", Offset = "0x5331FE0", VA = "0x185332BE0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x5332C20", Offset = "0x5332020", VA = "0x185332C20")]
			public CNCBFNJBCFI(List<Component> HGMKHDHJCFJ, bool JGGEMIKMPIM)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x5332B20", Offset = "0x5331F20", VA = "0x185332B20", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x5332B30", Offset = "0x5331F30", VA = "0x185332B30", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x3B25180", Offset = "0x3B24580", VA = "0x183B25180", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000209")]
			[Cpp2IlInjected.Address(RVA = "0x6DB37F0", Offset = "0x6DB2BF0", VA = "0x186DB37F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x8B7800", Offset = "0x8B6C00", VA = "0x1808B7800")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x6DB3550", Offset = "0x6DB2950", VA = "0x186DB3550")]
		private void JLABJFAHLGH(GameObject APOLHGOCCNB, bool DPEDJCGKFCE = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x6DB36C0", Offset = "0x6DB2AC0", VA = "0x186DB36C0")]
		public static void JLABJFAHLGH(GameObject APOLHGOCCNB, ToolHierarchyCache HMKOCECLFBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x6DB3750", Offset = "0x6DB2B50", VA = "0x186DB3750")]
		public void LOAEKADIODE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x317BD40", Offset = "0x317B140", VA = "0x18317BD40")]
		public void CICDFOHOIOG<T>(Action<T> MDOOJHKFGMP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x317BF80", Offset = "0x317B380", VA = "0x18317BF80")]
		public T MEPNHAGMEBF<T>(bool JGGEMIKMPIM = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x317C020", Offset = "0x317B420", VA = "0x18317C020")]
		public BNHEDKFLCJN<T> NIINIJPAKPP<T>(bool JGGEMIKMPIM = false) where T : class
		{
			return default(BNHEDKFLCJN<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x6DB3110", Offset = "0x6DB2510", VA = "0x186DB3110")]
		public List<Component> BGBNJNHGAOG(Type LGJDMOCCBDP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x6DB3460", Offset = "0x6DB2860", VA = "0x186DB3460", Slot = "4")]
		public bool Equals(ToolHierarchyCache CFANGCOBGCF, ToolHierarchyCache HHLCHNICLGA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x6DB34E0", Offset = "0x6DB28E0", VA = "0x186DB34E0", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache PBAACPJGKNP)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class PCILJPLLFNJ<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private int MLLKNBDHHFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private int DBACGBJNODE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private List<T> CLFAAKBCKGB;

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public int NJGLPGPPJOG
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x401A5A0", Offset = "0x40199A0", VA = "0x18401A5A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public T HFOIJEAEKAE
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x4B53480", Offset = "0x4B52880", VA = "0x184B53480")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public T PHCMCJMJBDA
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x4B532D0", Offset = "0x4B526D0", VA = "0x184B532D0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public T FPCMGHALOMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x4B53170", Offset = "0x4B52570", VA = "0x184B53170")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x4B539C0", Offset = "0x4B52DC0", VA = "0x184B539C0")]
	public PCILJPLLFNJ(int MLLKNBDHHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x4B537E0", Offset = "0x4B52BE0", VA = "0x184B537E0")]
	public void PJLPMKJIOFF(T GOCDIDDFLGC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x4B53350", Offset = "0x4B52750", VA = "0x184B53350")]
	public void FLFDAJFNFLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x4B53560", Offset = "0x4B52960", VA = "0x184B53560")]
	public void IIJELDADNFL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x4B53950", Offset = "0x4B52D50", VA = "0x184B53950")]
	public void PMFIACCPCLL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x4B53660", Offset = "0x4B52A60", VA = "0x184B53660")]
	public void KCGNGBGONEC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x4B530D0", Offset = "0x4B524D0", VA = "0x184B530D0")]
	public List<T> BLLIMHHOKNF()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class AIGDJEJHAJD<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private struct EDPCMJFPFCA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public int NNMKEIMDIEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public T JKEIFELLNME;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private readonly Dictionary<object, EDPCMJFPFCA> KFEJHMHFKIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly EqualityComparer<T> GGIBDMDNHLG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private T OOPOOILFIIE;

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public virtual T PKLDFHBCJGE
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x9A84F0", Offset = "0x9A78F0", VA = "0x1809A84F0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x3FC1800", Offset = "0x3FC0C00", VA = "0x183FC1800", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public bool GJJKPHFHOJC
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x3FC2BB0", Offset = "0x3FC1FB0", VA = "0x183FC2BB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public object NOKANJBGMDP
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x8AE500", Offset = "0x8AD900", VA = "0x1808AE500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x8AE4F0", Offset = "0x8AD8F0", VA = "0x1808AE4F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x3FC1100", Offset = "0x3FC0500", VA = "0x183FC1100")]
	public bool ABPBJIKCHMH(T LIHHDPOHLDK, object FDAIGOGAKMH, int EKKNGGKNJOL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x3FC13A0", Offset = "0x3FC07A0", VA = "0x183FC13A0")]
	public bool CKCBFAMPDJB(object FDAIGOGAKMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x3FC14F0", Offset = "0x3FC08F0", VA = "0x183FC14F0")]
	public bool FDPJDJCOJAH(object FDAIGOGAKMH, [Out] T LIHHDPOHLDK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x3B42C60", Offset = "0x3B42060", VA = "0x183B42C60")]
	public void FLFDAJFNFLK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x3FC2870", Offset = "0x3FC1C70", VA = "0x183FC2870")]
	private bool IODKMNKMHON()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x3FC2C40", Offset = "0x3FC2040", VA = "0x183FC2C40")]
	public AIGDJEJHAJD()
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
