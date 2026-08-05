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
		[Cpp2IlInjected.Address(RVA = "0x7D9A20", Offset = "0x7D8820", VA = "0x1807D9A20")]
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
		[Cpp2IlInjected.Address(RVA = "0x61EA970", Offset = "0x61E9770", VA = "0x1861EA970")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x7D9DC0", Offset = "0x7D8BC0", VA = "0x1807D9DC0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x7D9E00", Offset = "0x7D8C00", VA = "0x1807D9E00")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class LNAKOJEIGPH : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x7BF230", Offset = "0x7BE030", VA = "0x1807BF230")]
	public LNAKOJEIGPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HashableScriptableObject : ScriptableObject, LBOLCDOJHPP, CGOHMGMKPBG, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x7B1930", Offset = "0x7B0730", VA = "0x1807B1930", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x7B22D0", Offset = "0x7B10D0", VA = "0x1807B22D0", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x7B1940", Offset = "0x7B0740", VA = "0x1807B1940", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x872A70", Offset = "0x871870", VA = "0x180872A70", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash CBBELKKKCJN);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x89A860", Offset = "0x899660", VA = "0x18089A860")]
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
	[ReadOnlyField]
	[HideInInspector]
	[SerializeField]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x61EBB70", Offset = "0x61EA970", VA = "0x1861EBB70")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x61EBB30", Offset = "0x61EA930", VA = "0x1861EBB30")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x61EBBB0", Offset = "0x61EA9B0", VA = "0x1861EBBB0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x61EBD60", Offset = "0x61EAB60", VA = "0x1861EBD60")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x61EBCD0", Offset = "0x61EAAD0", VA = "0x1861EBCD0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x938680", Offset = "0x937480", VA = "0x180938680")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x9EF930", Offset = "0x9EE730", VA = "0x1809EF930")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x61EBAF0", Offset = "0x61EA8F0", VA = "0x1861EBAF0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x61EBC40", Offset = "0x61EAA40", VA = "0x1861EBC40")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x61EB620", Offset = "0x61EA420", VA = "0x1861EB620")]
	public void CopyBounds(SavedExtents GGINNHLAMLI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x61EBA40", Offset = "0x61EA840", VA = "0x1861EBA40")]
	public void SetLocalSpaceBounds(Bounds ONPLJOHBCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xA298C0", Offset = "0xA286C0", VA = "0x180A298C0")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x61EB870", Offset = "0x61EA670", VA = "0x1861EB870")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x61EB880", Offset = "0x61EA680", VA = "0x1861EB880")]
	private void PFDEEEDDFDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x61EB650", Offset = "0x61EA450", VA = "0x1861EB650")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x61EAFE0", Offset = "0x61E9DE0", VA = "0x1861EAFE0")]
	public static void CalculateLocalBoundsFor(GameObject EBIGFKEAJMH, [Out] Bounds ONPLJOHBCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x61EAF20", Offset = "0x61E9D20", VA = "0x1861EAF20")]
	private static void CCJIBDCFLCD(Bounds CJOKOOBKDLJ, Color JJPJCHPNNMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x61EBA60", Offset = "0x61EA860", VA = "0x1861EBA60")]
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
		[Cpp2IlInjected.Address(RVA = "0x7AE110", Offset = "0x7ACF10", VA = "0x1807AE110")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x7B4FE0", Offset = "0x7B3DE0", VA = "0x1807B4FE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xE5CDD0", Offset = "0xE5BBD0", VA = "0x180E5CDD0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x43FD880", Offset = "0x43FC680", VA = "0x1843FD880")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "4")]
	public virtual void HDALAPHOEIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
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
	[LNAKOJEIGPH]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x43FD4B0", Offset = "0x43FC2B0", VA = "0x1843FD4B0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x43FC2A0", Offset = "0x43FB0A0", VA = "0x1843FC2A0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x43FD7C0", Offset = "0x43FC5C0", VA = "0x1843FD7C0")]
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
	private sealed class MGPMNJELPOP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public MGPMNJELPOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3F98C00", Offset = "0x3F97A00", VA = "0x183F98C00")]
		internal int MFCKCCGEHLO(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[LNAKOJEIGPH]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x34D2A60", Offset = "0x34D1860", VA = "0x1834D2A60", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x34D2AA0", Offset = "0x34D18A0", VA = "0x1834D2AA0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x34D2980", Offset = "0x34D1780", VA = "0x1834D2980", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey OBPLDLNDJLE]
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x34D2A00", Offset = "0x34D1800", VA = "0x1834D2A00", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x34D2880", Offset = "0x34D1680", VA = "0x1834D2880", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x34D25D0", Offset = "0x34D13D0", VA = "0x1834D25D0", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x34D1B10", Offset = "0x34D0910", VA = "0x1834D1B10", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x34D1A40", Offset = "0x34D0840", VA = "0x1834D1A40", Slot = "14")]
	protected virtual string FOMBFDHKKOO(TKeyVal IFIFPGOBPGI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x34D19A0", Offset = "0x34D07A0", VA = "0x1834D19A0", Slot = "4")]
	public bool ContainsKey(TKey OBPLDLNDJLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x34D2750", Offset = "0x34D1550", VA = "0x1834D2750", Slot = "5")]
	public bool TryGetValue(TKey OBPLDLNDJLE, [Out] TVal DIBNBLEEFNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x34D1A70", Offset = "0x34D0870", VA = "0x1834D1A70", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x34D1A70", Offset = "0x34D0870", VA = "0x1834D1A70", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x34D2790", Offset = "0x34D1590", VA = "0x1834D2790")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class CMENFPGCCKM<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private class CCMDLPEHLLG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public float FAALLNJCFLG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public T ACOGNAIJGCD;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public CCMDLPEHLLG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class FNOBEKMMFBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public FNOBEKMMFBG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x3862F70", Offset = "0x3861D70", VA = "0x183862F70")]
		internal bool IDCGADLNCKO(CCMDLPEHLLG sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly float GNOJHKGOACN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly float MJAKKGPOFBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private List<CCMDLPEHLLG> BDCFOCGMIGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private ELNLLPJPMEE<CCMDLPEHLLG> BBPGPANINPP;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int JODLPLGKDFD
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x4DFBC90", Offset = "0x4DFAA90", VA = "0x184DFBC90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x4DFBD70", Offset = "0x4DFAB70", VA = "0x184DFBD70")]
	public CMENFPGCCKM(float IKCCKLECBML, float FHHJMMFGLKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4DFB500", Offset = "0x4DFA300", VA = "0x184DFB500")]
	public bool DPLGCBCABBG(float DIAHEDLEKEE, T DIBNBLEEFNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x4DFB9B0", Offset = "0x4DFA7B0", VA = "0x184DFB9B0")]
	public IEnumerable<T> IMLEJKDMGNC(float DIAHEDLEKEE, [Optional] float? KKIANLMBAEI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x4DFB670", Offset = "0x4DFA470", VA = "0x184DFB670")]
	public void HOCLBDDCDMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4DFB260", Offset = "0x4DFA060", VA = "0x184DFB260")]
	private void CDKINNNCFMO(float DIAHEDLEKEE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class PNADFKOIGBI<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct KPFODENKPJA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public T ACOGNAIJGCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public float HHKFCJPEKLI;
	}

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private static float IFMKJJBHDNH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private List<T> FHFMCCOHLKO;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private const int DHFLKDNANMD = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private KPFODENKPJA[] OKLABKDOFAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private int LLOPGKJIIAC;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float KIEFDHHEDBB
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x8382E0", Offset = "0x8370E0", VA = "0x1808382E0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x86A760", Offset = "0x869560", VA = "0x18086A760")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x41E2180", Offset = "0x41E0F80", VA = "0x1841E2180")]
	public PNADFKOIGBI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x41E21A0", Offset = "0x41E0FA0", VA = "0x1841E21A0")]
	public PNADFKOIGBI(int CGDBKIJPKOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x41E1E90", Offset = "0x41E0C90", VA = "0x1841E1E90")]
	public void HDCMKJKDALC(float DIAHEDLEKEE, T DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x41E2040", Offset = "0x41E0E40", VA = "0x1841E2040")]
	public void HOCLBDDCDMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x41E16F0", Offset = "0x41E04F0", VA = "0x1841E16F0")]
	public bool CKBGAECBNFI(float EHJFLPFLNII, float LPKNJMIFOJN, [Out] T DIBNBLEEFNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x41E1560", Offset = "0x41E0360", VA = "0x1841E1560")]
	public bool BLEKPCLNKCN(float EHJFLPFLNII, float LPKNJMIFOJN, [Out] T DIBNBLEEFNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x41E1B70", Offset = "0x41E0970", VA = "0x1841E1B70")]
	public void GEAPODDEDGB(float EHJFLPFLNII, float LPKNJMIFOJN, List<T> GGBNILIIFNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x41E1360", Offset = "0x41E0160", VA = "0x1841E1360")]
	private int AMOAMMBOHOH(int CMPLPGDDDOB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x41E1B30", Offset = "0x41E0930", VA = "0x1841E1B30")]
	private void FAFAJLIDHJI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T AMAABJCGBEP();

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T MNBLMDJFLDH(T DIBNBLEEFNN, float HKJAKBPEJHH);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T GDLHLIFLDGK(T MAEINFGKCEL, T FLBFHNBPNFN);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T GCJLLKLAOON(T MAEINFGKCEL, T FLBFHNBPNFN);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class BNGLLEBJELI : PNADFKOIGBI<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x7BFAC0", Offset = "0x7BE8C0", VA = "0x1807BFAC0", Slot = "4")]
	protected override Vector3 AMAABJCGBEP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x61E78F0", Offset = "0x61E66F0", VA = "0x1861E78F0", Slot = "5")]
	protected override Vector3 MNBLMDJFLDH(Vector3 DIBNBLEEFNN, float HKJAKBPEJHH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x61E78A0", Offset = "0x61E66A0", VA = "0x1861E78A0", Slot = "6")]
	protected override Vector3 GDLHLIFLDGK(Vector3 MAEINFGKCEL, Vector3 FLBFHNBPNFN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x61E7820", Offset = "0x61E6620", VA = "0x1861E7820", Slot = "7")]
	protected override Vector3 GCJLLKLAOON(Vector3 MAEINFGKCEL, Vector3 FLBFHNBPNFN)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x61E7930", Offset = "0x61E6730", VA = "0x1861E7930")]
	public BNGLLEBJELI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class PGLKBJJHODJ
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2A50FF0", Offset = "0x2A4FDF0", VA = "0x182A50FF0")]
	public static KGCPBIMDGMA<T1, T2> ANGJMEBBFOG<T1, T2>(T1 JFIIACDAPPP, T2 HJNBMNAIAMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2A51070", Offset = "0x2A4FE70", VA = "0x182A51070")]
	public static CGBBNABMAAA<T1, T2, T3> ANGJMEBBFOG<T1, T2, T3>(T1 JFIIACDAPPP, T2 HJNBMNAIAMO, T3 OICEKOAODEH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x3FE5590", Offset = "0x3FE4390", VA = "0x183FE5590")]
	internal static int LGBELNHDLLG(int KKINKCBGKNJ, int HEHABAMFIEJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x55F5B00", Offset = "0x55F4900", VA = "0x1855F5B00")]
	internal static int LGBELNHDLLG(int KKINKCBGKNJ, int HEHABAMFIEJ, int HFGMGLNBAPI)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class KGCPBIMDGMA<T1, T2> : IComparable<KGCPBIMDGMA<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly T1 KIPFKCLHGLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly T2 PHPOAEMBJAP;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x3CEAD20", Offset = "0x3CE9B20", VA = "0x183CEAD20")]
	public KGCPBIMDGMA(T1 JFIIACDAPPP, T2 HJNBMNAIAMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x3CE93F0", Offset = "0x3CE81F0", VA = "0x183CE93F0", Slot = "4")]
	public int CompareTo(KGCPBIMDGMA<T1, T2> GGINNHLAMLI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x3CE9990", Offset = "0x3CE8790", VA = "0x183CE9990", Slot = "0")]
	public override bool Equals(object GGINNHLAMLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x3CEA190", Offset = "0x3CE8F90", VA = "0x183CEA190", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x3CEA8A0", Offset = "0x3CE96A0", VA = "0x183CEA8A0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class CGBBNABMAAA<T1, T2, T3> : IComparable<CGBBNABMAAA<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly T1 KIPFKCLHGLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly T2 PHPOAEMBJAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly T3 BBEMFCLMHDC;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x4D20270", Offset = "0x4D1F070", VA = "0x184D20270")]
	public CGBBNABMAAA(T1 JFIIACDAPPP, T2 HJNBMNAIAMO, T3 OICEKOAODEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x4D1F990", Offset = "0x4D1E790", VA = "0x184D1F990", Slot = "4")]
	public int CompareTo(CGBBNABMAAA<T1, T2, T3> GGINNHLAMLI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x4D1FBF0", Offset = "0x4D1E9F0", VA = "0x184D1FBF0", Slot = "0")]
	public override bool Equals(object GGINNHLAMLI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x4D1FF10", Offset = "0x4D1ED10", VA = "0x184D1FF10", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4D1FFB0", Offset = "0x4D1EDB0", VA = "0x184D1FFB0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public abstract class ValueCurve<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	[SerializeField]
	protected AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	[SerializeField]
	protected T minValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	[SerializeField]
	protected T maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	[SerializeField]
	protected float duration;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public T ACOGNAIJGCD
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x218C7D0", Offset = "0x218B5D0", VA = "0x18218C7D0")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x218C7C0", Offset = "0x218B5C0", VA = "0x18218C7C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public float GLFPDPGCHDJ
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8B4B70", Offset = "0x8B3970", VA = "0x1808B4B70")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x45EE6D0", Offset = "0x45ED4D0", VA = "0x1845EE6D0")]
	public T DFJALFFDDIG(float HKJAKBPEJHH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x45EEAD0", Offset = "0x45ED8D0", VA = "0x1845EEAD0")]
	public T PEAMDMHFCEN(float HKJAKBPEJHH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T JOPLKCNIHHP(T MAEINFGKCEL, T FLBFHNBPNFN, float HKJAKBPEJHH);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x61E8E60", Offset = "0x61E7C60", VA = "0x1861E8E60", Slot = "4")]
	protected override float JOPLKCNIHHP(float MAEINFGKCEL, float FLBFHNBPNFN, float HKJAKBPEJHH)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x61E8EA0", Offset = "0x61E7CA0", VA = "0x1861E8EA0")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0xCE7BC0", Offset = "0xCE69C0", VA = "0x180CE7BC0", Slot = "4")]
	protected override Vector3 JOPLKCNIHHP(Vector3 MAEINFGKCEL, Vector3 FLBFHNBPNFN, float HKJAKBPEJHH)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x61ECA60", Offset = "0x61EB860", VA = "0x1861ECA60")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x61E8B90", Offset = "0x61E7990", VA = "0x1861E8B90", Slot = "4")]
	protected override Color JOPLKCNIHHP(Color MAEINFGKCEL, Color FLBFHNBPNFN, float HKJAKBPEJHH)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x61E8C50", Offset = "0x61E7A50", VA = "0x1861E8C50")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class CEBBBPHPCNA : EPGBAHIGGGB<string>
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x61E7A60", Offset = "0x61E6860", VA = "0x1861E7A60")]
	public CEBBBPHPCNA(int GIOLCDOMFDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x61E79F0", Offset = "0x61E67F0", VA = "0x1861E79F0", Slot = "6")]
	protected override uint DKMADHCHGKB(uint CBBELKKKCJN, string DIBNBLEEFNN)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class AHMLDOJMHDK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly IDisposable LLCJIHIKEMG;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	public AHMLDOJMHDK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct JJFBDONLLKB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> IJDOCIJBLAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private int HPHDLOOLMHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int ABENHKALEJC;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x3C3F640", Offset = "0x3C3E440", VA = "0x183C3F640")]
	private JJFBDONLLKB(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> AOBDHONEGAI, int IJAJIPNOOBM, int KOFEJGJFCPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x3C3D490", Offset = "0x3C3C290", VA = "0x183C3D490")]
	public static JJFBDONLLKB<T> KHDJPNLCMFA()
	{
		return default(JJFBDONLLKB<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x3C3E900", Offset = "0x3C3D700", VA = "0x183C3E900")]
	public (int, int, Task<T>) KOODLPGEIEJ(int HAEHFCPEDMJ, [Optional] CancellationToken KANPDHELHMD, double GKFGFCFKANC = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x3C3F2A0", Offset = "0x3C3E0A0", VA = "0x183C3F2A0")]
	public void NJJJEAAIBAN(int HAEHFCPEDMJ, int KOFEJGJFCPD, [In] T FJMMLPMLLGC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class BMGFOAJECOM
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x61E7750", Offset = "0x61E6550", VA = "0x1861E7750")]
	public static JJFBDONLLKB<CDPLPCBKJFN> KHDJPNLCMFA()
	{
		return default(JJFBDONLLKB<CDPLPCBKJFN>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x61E77A0", Offset = "0x61E65A0", VA = "0x1861E77A0")]
	public static void NJJJEAAIBAN([In] this JJFBDONLLKB<CDPLPCBKJFN> ILACEKALGJH, int HAEHFCPEDMJ, int KOFEJGJFCPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[DefaultMember("Item")]
public class CLDJADLMKCG<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly Dictionary<TKey, TVal> OENJHBMNJAE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly Dictionary<TVal, TKey> NNCBKBBKCHI;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int BLPIMLOHMJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x3284510", Offset = "0x3283310", VA = "0x183284510", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool LIIHEFGBOIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x7F8240", Offset = "0x7F7040", VA = "0x1807F8240", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public ICollection<TKey> LIOGCBENAED
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x3915120", Offset = "0x3913F20", VA = "0x183915120", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public ICollection<TVal> EDOJOOOMFJN
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x4DFA920", Offset = "0x4DF9720", VA = "0x184DFA920", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public TVal OODNGMCMHAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x4DFA8C0", Offset = "0x4DF96C0", VA = "0x184DFA8C0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x4DFA980", Offset = "0x4DF9780", VA = "0x184DFA980", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public TKey OODNGMCMHAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x4DFA1D0", Offset = "0x4DF8FD0", VA = "0x184DFA1D0")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4DF9D00", Offset = "0x4DF8B00", VA = "0x184DF9D00", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4DFA6A0", Offset = "0x4DF94A0", VA = "0x184DFA6A0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x4DF9CB0", Offset = "0x4DF8AB0", VA = "0x184DF9CB0", Slot = "9")]
	public void Add(TKey OBPLDLNDJLE, TVal DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x4DF9C60", Offset = "0x4DF8A60", VA = "0x184DF9C60", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> LMLNLGNPIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3C1BEB0", Offset = "0x3C1ACB0", VA = "0x183C1BEB0", Slot = "8")]
	public bool ContainsKey(TKey OBPLDLNDJLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x4DF9DB0", Offset = "0x4DF8BB0", VA = "0x184DF9DB0", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> LMLNLGNPIDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x4DFA620", Offset = "0x4DF9420", VA = "0x184DFA620", Slot = "10")]
	public bool Remove(TKey OBPLDLNDJLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x4DFA670", Offset = "0x4DF9470", VA = "0x184DFA670", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> LMLNLGNPIDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x4DFA790", Offset = "0x4DF9590", VA = "0x184DFA790", Slot = "11")]
	public bool TryGetValue(TKey OBPLDLNDJLE, [Out] TVal DIBNBLEEFNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x4DF9FF0", Offset = "0x4DF8DF0", VA = "0x184DF9FF0", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4DF9DE0", Offset = "0x4DF8BE0", VA = "0x184DF9DE0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] OKLABKDOFAF, int GKAEDFLMLFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x4DFA100", Offset = "0x4DF8F00", VA = "0x184DFA100")]
	public bool JJGGEGPCFME(TVal OBPLDLNDJLE, [Out] TKey DIBNBLEEFNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x4DF9F50", Offset = "0x4DF8D50", VA = "0x184DF9F50")]
	private void FNDJCMFLPBC(TKey OBPLDLNDJLE, TVal FLOENDBPFOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x4DFA480", Offset = "0x4DF9280", VA = "0x184DFA480")]
	private void PJOGDKCLKLP(TKey OBPLDLNDJLE, TVal FLOENDBPFOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x4DFA220", Offset = "0x4DF9020", VA = "0x184DFA220")]
	private bool MPPBNJCBNPJ(TKey OBPLDLNDJLE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x4DFA7D0", Offset = "0x4DF95D0", VA = "0x184DFA7D0")]
	public CLDJADLMKCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[DefaultMember("Item")]
public class MIAMHMAIDAN<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private MIAMHMAIDAN<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000039")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003A")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000020")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A9")]
			[Cpp2IlInjected.Address(RVA = "0x351A450", Offset = "0x3519250", VA = "0x18351A450", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x35201D0", Offset = "0x351EFD0", VA = "0x1835201D0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x3521190", Offset = "0x351FF90", VA = "0x183521190")]
		public Enumerator(MIAMHMAIDAN<T> GGBNILIIFNK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x351DF80", Offset = "0x351CD80", VA = "0x18351DF80", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x351EC50", Offset = "0x351DA50", VA = "0x18351EC50", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x351C530", Offset = "0x351B330", VA = "0x18351C530")]
		private void CDBIHOIGFKG()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private T[] AEBHMCHAANA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private int DLJHEFPEFCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private int LBDKFBCFLKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private int MIJEJKOAIDK;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int BLPIMLOHMJK
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x3FA36E0", Offset = "0x3FA24E0", VA = "0x183FA36E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public T OODNGMCMHAM
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x3FA3650", Offset = "0x3FA2450", VA = "0x183FA3650")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x3FA1CF0", Offset = "0x3FA0AF0", VA = "0x183FA1CF0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3FA3A00", Offset = "0x3FA2800", VA = "0x183FA3A00")]
	public MIAMHMAIDAN(int GIOLCDOMFDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3FA2310", Offset = "0x3FA1110", VA = "0x183FA2310")]
	public void HDCMKJKDALC(T HKJAKBPEJHH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3FA24D0", Offset = "0x3FA12D0", VA = "0x183FA24D0")]
	public void HOCLBDDCDMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3FA2520", Offset = "0x3FA1320", VA = "0x183FA2520")]
	public void JIMHAAPJHOH(int NJKDAMEBDBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3FA25C0", Offset = "0x3FA13C0", VA = "0x183FA25C0")]
	public void LMEOKBKFCPL(T[] OKLABKDOFAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3FA1C80", Offset = "0x3FA0A80", VA = "0x183FA1C80")]
	public Enumerator CNEJODDGPIM()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3FA3720", Offset = "0x3FA2520", VA = "0x183FA3720", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x3FA3720", Offset = "0x3FA2520", VA = "0x183FA3720", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3FA3260", Offset = "0x3FA2060", VA = "0x183FA3260")]
	private int MENPAEOCAHI(int AELAKOMEEDP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x3FA24F0", Offset = "0x3FA12F0", VA = "0x183FA24F0")]
	private int JCMLPDKMECF(int AELAKOMEEDP)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class HOBPGBBGIDA<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public delegate Task<TResult> NLHFOFAFHOH(TRequest AIAKOJMKOGA, CancellationToken KANPDHELHMD);

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public enum LFCHLCLEDJE
	{
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class OOMDOKDOKMI
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private const float HOKPOKFAJGM = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TimeSpan LHELOGIHADE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int ANOPOHHLEBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public LFCHLCLEDJE GBIPJMGCCKE;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public static readonly OOMDOKDOKMI NGIMMBPCNIG;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float KLLMEPMKMDM
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x412B5C0", Offset = "0x412A3C0", VA = "0x18412B5C0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public TimeSpan BIPODKLNDFB
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x7B1BD0", Offset = "0x7B09D0", VA = "0x1807B1BD0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x412B6A0", Offset = "0x412A4A0", VA = "0x18412B6A0")]
		public OOMDOKDOKMI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	private readonly struct NDKGCBLAKEJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly TRequest AIAKOJMKOGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly CancellationToken KANPDHELHMD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly TaskCompletionSource<TResult> KBJNIEAGNFI;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x4016370", Offset = "0x4015170", VA = "0x184016370")]
		public NDKGCBLAKEJ(TRequest AIAKOJMKOGA, TaskCompletionSource<TResult> KBJNIEAGNFI, CancellationToken KANPDHELHMD)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct OIPKFFFHHPF : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public HOBPGBBGIDA<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x4110CA0", Offset = "0x410FAA0", VA = "0x184110CA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x4111840", Offset = "0x4110640", VA = "0x184111840", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct IOKMMPEKGBE : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public HOBPGBBGIDA<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private NDKGCBLAKEJ <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x3A99FC0", Offset = "0x3A98DC0", VA = "0x183A99FC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x3A9B100", Offset = "0x3A99F00", VA = "0x183A9B100", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly CancellationTokenSource KEBAGODJIEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly List<NDKGCBLAKEJ> OPHIEBINCDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly OOMDOKDOKMI OAJLJJNOKON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly NLHFOFAFHOH DEKCDEEFBPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Task MKGKFAJGKBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private int GCDHGPLILPL;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x39DA050", Offset = "0x39D8E50", VA = "0x1839DA050")]
	public HOBPGBBGIDA(NLHFOFAFHOH DEKCDEEFBPH, [Optional] OOMDOKDOKMI OAJLJJNOKON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x39D8D00", Offset = "0x39D7B00", VA = "0x1839D8D00")]
	public Task<TResult> HAMIHBMCMJN(TRequest AIAKOJMKOGA, CancellationToken KANPDHELHMD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x39D9CE0", Offset = "0x39D8AE0", VA = "0x1839D9CE0")]
	private void MAFNMGEOHOO(NDKGCBLAKEJ BDILJIKOONK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x39D8FB0", Offset = "0x39D7DB0", VA = "0x1839D8FB0")]
	[AsyncStateMachine(typeof(HOBPGBBGIDA<, >.OIPKFFFHHPF))]
	private Task ILOCNBOPBMC()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x39D9150", Offset = "0x39D7F50", VA = "0x1839D9150")]
	private NDKGCBLAKEJ JPGILLCLGJP()
	{
		return default(NDKGCBLAKEJ);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x39D9AB0", Offset = "0x39D88B0", VA = "0x1839D9AB0")]
	[AsyncStateMachine(typeof(HOBPGBBGIDA<, >.IOKMMPEKGBE))]
	private Task LPDJICLNFON()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x39D87F0", Offset = "0x39D75F0", VA = "0x1839D87F0")]
	private void GINMEMGAEAM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x39D85D0", Offset = "0x39D73D0", VA = "0x1839D85D0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DefaultMember("Item")]
public class PLGMOJLCANB<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly List<T> GIJBOOPKLBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private HashSet<T> CBNIDLFDEJJ;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int BLPIMLOHMJK
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x3284510", Offset = "0x3283310", VA = "0x183284510", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool LIIHEFGBOIM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x7F8240", Offset = "0x7F7040", VA = "0x1807F8240", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public T OODNGMCMHAM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x4053A60", Offset = "0x4052860", VA = "0x184053A60", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x41DB950", Offset = "0x41DA750", VA = "0x1841DB950", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x388D9F0", Offset = "0x388C7F0", VA = "0x18388D9F0", Slot = "11")]
	public void Add(T LMLNLGNPIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x41DB420", Offset = "0x41DA220", VA = "0x1841DB420")]
	public bool NPFFPDIACNA(T LMLNLGNPIDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x41DB7D0", Offset = "0x41DA5D0", VA = "0x1841DB7D0", Slot = "15")]
	public bool Remove(T LMLNLGNPIDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x390CD90", Offset = "0x390BB90", VA = "0x18390CD90", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x38A98B0", Offset = "0x38A86B0", VA = "0x1838A98B0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x41DB1B0", Offset = "0x41D9FB0", VA = "0x1841DB1B0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x41DB210", Offset = "0x41DA010", VA = "0x1841DB210", Slot = "13")]
	public bool Contains(T LMLNLGNPIDN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x41DB250", Offset = "0x41DA050", VA = "0x1841DB250", Slot = "14")]
	public void CopyTo(T[] OKLABKDOFAF, int GKAEDFLMLFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x3D58BC0", Offset = "0x3D579C0", VA = "0x183D58BC0", Slot = "6")]
	public int IndexOf(T LMLNLGNPIDN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x41DB280", Offset = "0x41DA080", VA = "0x1841DB280", Slot = "7")]
	public void Insert(int AELAKOMEEDP, T LMLNLGNPIDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x41DB580", Offset = "0x41DA380", VA = "0x1841DB580", Slot = "8")]
	public void RemoveAt(int AELAKOMEEDP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x41DB860", Offset = "0x41DA660", VA = "0x1841DB860")]
	public PLGMOJLCANB()
	{
	}
}
namespace RecRoom.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	public sealed class SerializedGuid : ISerializationCallbackReceiver, IComparable<SerializedGuid>, IEquatable<SerializedGuid>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000059")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000D3")]
			[Cpp2IlInjected.Address(RVA = "0x1FF3D80", Offset = "0x1FF2B80", VA = "0x181FF3D80")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x61EC100", Offset = "0x61EAF00", VA = "0x1861EC100")]
		public SerializedGuid([In] Guid IIGMMHCLOGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x61EBFD0", Offset = "0x61EADD0", VA = "0x1861EBFD0")]
		public static SerializedGuid OHCAEKBGMDI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x61EBE20", Offset = "0x61EAC20", VA = "0x1861EBE20")]
		public static SerializedGuid DFEJDDDLAHB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x61EBF70", Offset = "0x61EAD70", VA = "0x1861EBF70")]
		public bool JODNNLIOIFI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x61EC0D0", Offset = "0x61EAED0", VA = "0x1861EC0D0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x61EC050", Offset = "0x61EAE50", VA = "0x1861EC050", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x61EBE90", Offset = "0x61EAC90", VA = "0x1861EBE90", Slot = "7")]
		public bool Equals(SerializedGuid GGINNHLAMLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x61EBED0", Offset = "0x61EACD0", VA = "0x1861EBED0", Slot = "0")]
		public override bool Equals(object EIFMADKIHON)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x61EBF60", Offset = "0x61EAD60", VA = "0x1861EBF60", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x61EBDF0", Offset = "0x61EABF0", VA = "0x1861EBDF0", Slot = "6")]
		public int CompareTo(SerializedGuid GGINNHLAMLI)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class DMNHNHJBFKN : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly Type NLPHKMKEOFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly string NEAPAOHOEIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly bool KOBPADAIFLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly bool MIJKALNNMON;

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x61E8C90", Offset = "0x61E7A90", VA = "0x1861E8C90")]
	public DMNHNHJBFKN(Type MCEPKEDHNJP, string BELDMJMOCHF, bool OMJCLEHKFEE = false, bool LHIHCEGJNPF = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class DIMFGGHDEDI<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public readonly struct NDEAOADOMII
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public readonly long PIPKNGPBOAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public readonly long ALBHJALIGME;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public readonly int NKHLLCGGEGA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly int KFJGPPOAKNE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public readonly bool HFGEJHKIJCJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly string PADCBDGGFND;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x4014110", Offset = "0x4012F10", VA = "0x184014110")]
		public NDEAOADOMII(long PIPKNGPBOAP, int NKHLLCGGEGA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x40140E0", Offset = "0x4012EE0", VA = "0x1840140E0")]
		public NDEAOADOMII(long PIPKNGPBOAP, long ALBHJALIGME, int NKHLLCGGEGA, int KFJGPPOAKNE, bool HFGEJHKIJCJ, string PADCBDGGFND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x4013FF0", Offset = "0x4012DF0", VA = "0x184013FF0")]
		public int NCMFLABLLIK()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x4013FD0", Offset = "0x4012DD0", VA = "0x184013FD0")]
		public int FMCFBIHJGON(int FKELPOKPABH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x4013F70", Offset = "0x4012D70", VA = "0x184013F70")]
		public double ELDALNODFLO()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x4014040", Offset = "0x4012E40", VA = "0x184014040")]
		public NDEAOADOMII NDFHCKOJLFP(long ALBHJALIGME, int KFJGPPOAKNE)
		{
			return default(NDEAOADOMII);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class NJDBOGMFDFJ : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private struct PGFBDAJEECN<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public NJDBOGMFDFJ <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public Func<NJDBOGMFDFJ, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			private NJDBOGMFDFJ <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x41CCEB0", Offset = "0x41CBCB0", VA = "0x1841CCEB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x34C5980", Offset = "0x34C4780", VA = "0x1834C5980", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public readonly TKey AAPIPDGMADH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly DIMFGGHDEDI<TKey> DPOENBOPPGM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly JNOMMELLEMA LEDKGOEDJCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private List<NJDBOGMFDFJ> HGKNPAOBHAA;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public string PNODFNNLGOI
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x402B580", Offset = "0x402A380", VA = "0x18402B580")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public IEnumerable<NJDBOGMFDFJ> PJOPMMGNAII
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x402B350", Offset = "0x402A150", VA = "0x18402B350")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public NDEAOADOMII LLOEOCALHOP
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x402B560", Offset = "0x402A360", VA = "0x18402B560")]
			[CompilerGenerated]
			get
			{
				return default(NDEAOADOMII);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x402B700", Offset = "0x402A500", VA = "0x18402B700")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x402B730", Offset = "0x402A530", VA = "0x18402B730")]
		internal NJDBOGMFDFJ(DIMFGGHDEDI<TKey> DPOENBOPPGM, TKey OBPLDLNDJLE, JNOMMELLEMA LEDKGOEDJCM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x402B5B0", Offset = "0x402A3B0", VA = "0x18402B5B0")]
		public NJDBOGMFDFJ OCKBDGFPFHM(TKey OBPLDLNDJLE, [Optional] JNOMMELLEMA? MMNILFJLPNE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x27E5D30", Offset = "0x27E4B30", VA = "0x1827E5D30")]
		[AsyncStateMachine(typeof(PGFBDAJEECN<>))]
		public Task<T> BAHCJFCNOMH<T>(TKey OBPLDLNDJLE, Func<NJDBOGMFDFJ, Task<T>> HAEHEOGNGAP)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x402B380", Offset = "0x402A180", VA = "0x18402B380", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class NEKANHNBNEI : IEnumerable<(TKey, List<TKey>, NDEAOADOMII)>, IEnumerable, IEnumerator<(TKey, List<TKey>, NDEAOADOMII)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private (TKey key, List<TKey> path, NDEAOADOMII timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public DIMFGGHDEDI<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private IEnumerator<(TKey key, List<TKey> path, NDEAOADOMII timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		private (TKey, List<TKey>, NDEAOADOMII) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x200D7E0", Offset = "0x200C5E0", VA = "0x18200D7E0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, NDEAOADOMII));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x4019910", Offset = "0x4018710", VA = "0x184019910", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x200D8D0", Offset = "0x200C6D0", VA = "0x18200D8D0")]
		[DebuggerHidden]
		public NEKANHNBNEI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x37DEC10", Offset = "0x37DDA10", VA = "0x1837DEC10", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x4019480", Offset = "0x4018280", VA = "0x184019480", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x4019430", Offset = "0x4018230", VA = "0x184019430")]
		private void DJJHEMEPHNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x40198C0", Offset = "0x40186C0", VA = "0x1840198C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x4019800", Offset = "0x4018600", VA = "0x184019800", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, NDEAOADOMII)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x37E6D40", Offset = "0x37E5B40", VA = "0x1837E6D40", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class BMKHIADILKA : IEnumerable<(TKey, List<TKey>, NDEAOADOMII)>, IEnumerable, IEnumerator<(TKey, List<TKey>, NDEAOADOMII)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private (TKey key, List<TKey> path, NDEAOADOMII timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private NJDBOGMFDFJ timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public NJDBOGMFDFJ <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public DIMFGGHDEDI<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private IEnumerator<NJDBOGMFDFJ> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private IEnumerator<(TKey key, List<TKey> path, NDEAOADOMII timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private (TKey, List<TKey>, NDEAOADOMII) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x200D7E0", Offset = "0x200C5E0", VA = "0x18200D7E0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, NDEAOADOMII));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x4884390", Offset = "0x4883190", VA = "0x184884390", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x200D8D0", Offset = "0x200C6D0", VA = "0x18200D8D0")]
		[DebuggerHidden]
		public BMKHIADILKA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x48843F0", Offset = "0x48831F0", VA = "0x1848843F0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x4883B00", Offset = "0x4882900", VA = "0x184883B00", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x4883A40", Offset = "0x4882840", VA = "0x184883A40")]
		private void DJJHEMEPHNE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x4883AA0", Offset = "0x48828A0", VA = "0x184883AA0")]
		private void MHENGEIGMCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x4884340", Offset = "0x4883140", VA = "0x184884340", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x4884260", Offset = "0x4883060", VA = "0x184884260", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, NDEAOADOMII)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x440FD30", Offset = "0x440EB30", VA = "0x18440FD30", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly Action<TKey, NDEAOADOMII, JNOMMELLEMA> EGDDNIFHLJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly Action<TKey, NDEAOADOMII, JNOMMELLEMA> EOFEFHANPIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly Action<DIMFGGHDEDI<TKey>, JNOMMELLEMA> GFFEGAFPCJL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly JNOMMELLEMA LEDKGOEDJCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly NJDBOGMFDFJ JJANIEHKGPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private bool KJIMDOIMIPD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int JNKAHNIAOHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly Stopwatch OLOMJKLKIGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly int JEOBDBDPNGL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private string ADBFJAIDINF;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public NJDBOGMFDFJ EMDPJHNNAOB
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x7B8500", Offset = "0x7B7300", VA = "0x1807B8500")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	[NotNull]
	public string PNODFNNLGOI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x7B5870", Offset = "0x7B4670", VA = "0x1807B5870")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x5151EE0", Offset = "0x5150CE0", VA = "0x185151EE0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x5151FC0", Offset = "0x5150DC0", VA = "0x185151FC0")]
	public DIMFGGHDEDI(TKey CNFKPGKACGB, JNOMMELLEMA LEDKGOEDJCM, [Optional] int? NKHLLCGGEGA, [Optional][CanBeNull] Stopwatch OLOMJKLKIGP, [Optional] Action<TKey, NDEAOADOMII, JNOMMELLEMA> EGDDNIFHLJG, [Optional] Action<TKey, NDEAOADOMII, JNOMMELLEMA> EOFEFHANPIJ, [Optional] Action<DIMFGGHDEDI<TKey>, JNOMMELLEMA> GFFEGAFPCJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x5151CF0", Offset = "0x5150AF0", VA = "0x185151CF0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x5151E50", Offset = "0x5150C50", VA = "0x185151E50")]
	[IteratorStateMachine(typeof(DIMFGGHDEDI<>.NEKANHNBNEI))]
	public IEnumerable<(TKey, List<TKey>, NDEAOADOMII)> FJLAPDJGLPL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x5151D80", Offset = "0x5150B80", VA = "0x185151D80")]
	[IteratorStateMachine(typeof(DIMFGGHDEDI<>.BMKHIADILKA))]
	private IEnumerable<(TKey, List<TKey>, NDEAOADOMII)> FJLAPDJGLPL(List<TKey> CCKBKBLBNND, NJDBOGMFDFJ FMDBMLMNLON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x5151F40", Offset = "0x5150D40", VA = "0x185151F40")]
	private (long, int) NOJNKFEIIOD()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public abstract class DLHMJKEIOEB<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut CKLIEALABHO(DIMFGGHDEDI<TKey> DPOENBOPPGM);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	protected DLHMJKEIOEB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public abstract class IJBGELANHPD<TKey> : DLHMJKEIOEB<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public delegate string OBLIDHMDOJP(TKey OBPLDLNDJLE);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x3A85100", Offset = "0x3A83F00", VA = "0x183A85100")]
	private static string FOEILNCGFPL(TKey OBPLDLNDJLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x3A84F10", Offset = "0x3A83D10", VA = "0x183A84F10", Slot = "4")]
	public override string CKLIEALABHO(DIMFGGHDEDI<TKey> DPOENBOPPGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x3A84FC0", Offset = "0x3A83DC0", VA = "0x183A84FC0")]
	public string CKLIEALABHO(DIMFGGHDEDI<TKey> DPOENBOPPGM, [NotNull] OBLIDHMDOJP EIJPIENICGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string MCBCPPHBNKJ(DIMFGGHDEDI<TKey> DPOENBOPPGM, [NotNull] OBLIDHMDOJP EIJPIENICGA);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x3A85140", Offset = "0x3A83F40", VA = "0x183A85140")]
	protected IJBGELANHPD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class EGDKEBGNIGK<TKey> : DLHMJKEIOEB<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public delegate string MMEFDCFEGKL(TKey OBPLDLNDJLE);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly string HLHAIKGGCLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly double AMEBFABDKEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly bool CHBJEBIAMGO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly int IKGBMOHNDKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly ISet<string> HMNCBHBJCBI;

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x3483920", Offset = "0x3482720", VA = "0x183483920")]
	private static string FOEILNCGFPL(TKey OBPLDLNDJLE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x3483AC0", Offset = "0x34828C0", VA = "0x183483AC0")]
	public EGDKEBGNIGK(string HLHAIKGGCLO = "F2", double AMEBFABDKEP = double.MaxValue, bool CHBJEBIAMGO = false, int IKGBMOHNDKM = int.MaxValue, [Optional] ISet<string> HMNCBHBJCBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x3483590", Offset = "0x3482390", VA = "0x183483590", Slot = "4")]
	public override Dictionary<string, string> CKLIEALABHO(DIMFGGHDEDI<TKey> DPOENBOPPGM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3483850", Offset = "0x3482650", VA = "0x183483850")]
	private bool FCGEKNBDDPH(string JMONBMGIAFO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3482FE0", Offset = "0x3481DE0", VA = "0x183482FE0")]
	public Dictionary<string, string> CKLIEALABHO(DIMFGGHDEDI<TKey> DPOENBOPPGM, MMEFDCFEGKL EIJPIENICGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x3483640", Offset = "0x3482440", VA = "0x183483640")]
	private string EDMJGOKGEDI(StringBuilder ONEKGHCHKKM, List<TKey> KDFPOPHBNJK, MMEFDCFEGKL EIJPIENICGA, bool COGEEEDPAPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3483960", Offset = "0x3482760", VA = "0x183483960")]
	private static void PDNJCNBGAEF(StringBuilder OLKKMONOPAH, string HKEKJBKJIAI, bool DPCDCCKGKHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class FBOHMNLDADF<TKey> : IJBGELANHPD<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct AGMCGHMANEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public OBLIDHMDOJP keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public static FBOHMNLDADF<TKey> LLCJIHIKEMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly string[] EKEGJPGHKHL;

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x38284F0", Offset = "0x38272F0", VA = "0x1838284F0")]
	private FBOHMNLDADF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3827570", Offset = "0x3826370", VA = "0x183827570", Slot = "5")]
	protected override string MCBCPPHBNKJ(DIMFGGHDEDI<TKey> DPOENBOPPGM, OBLIDHMDOJP EIJPIENICGA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3827480", Offset = "0x3826280", VA = "0x183827480")]
	[CompilerGenerated]
	internal static string IKFOPGMGNJO(string CFEBFKDMFJC, TKey OBPLDLNDJLE, AGMCGHMANEK P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class CMNIHEGKOAH : DIMFGGHDEDI<string>
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class JKCJJOGLCCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public Action<CMNIHEGKOAH, JNOMMELLEMA> callback;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public JKCJJOGLCCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x61E98A0", Offset = "0x61E86A0", VA = "0x1861E98A0")]
		internal void NFHNBDIBFNC(DIMFGGHDEDI<string> timer, JNOMMELLEMA log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x61E8800", Offset = "0x61E7600", VA = "0x1861E8800")]
	public CMNIHEGKOAH(JNOMMELLEMA LEDKGOEDJCM, [Optional] string BCHMDJCIKDG, [Optional] int? NKHLLCGGEGA, [Optional] Stopwatch OLOMJKLKIGP, [Optional] Action<string, NDEAOADOMII, JNOMMELLEMA> EGDDNIFHLJG, [Optional] Action<string, NDEAOADOMII, JNOMMELLEMA> EOFEFHANPIJ, [Optional] Action<CMNIHEGKOAH, JNOMMELLEMA> GFFEGAFPCJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x61E8740", Offset = "0x61E7540", VA = "0x1861E8740")]
	private static Action<DIMFGGHDEDI<string>, JNOMMELLEMA> BKGHGIFKJMP(Action<CMNIHEGKOAH, JNOMMELLEMA> KPIAINDMMOB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public abstract class ENALGCAABDO
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	private class APIJHCCJJHO : ENALGCAABDO
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public static ENALGCAABDO LLCJIHIKEMG
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x61E7610", Offset = "0x61E6410", VA = "0x1861E7610")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override float DGJPNOBJGGG
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x83EFB0", Offset = "0x83DDB0", VA = "0x18083EFB0", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x61E7700", Offset = "0x61E6500", VA = "0x1861E7700")]
		public APIJHCCJJHO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static ENALGCAABDO OLNMLEPMDOK;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static ENALGCAABDO NGIMMBPCNIG
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x61E8D00", Offset = "0x61E7B00", VA = "0x1861E8D00")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public abstract float DGJPNOBJGGG
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
	protected ENALGCAABDO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface LNKPACKCPAH : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	bool BOHPGLCBGLD
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface BCJOGHANCKE<T> : LNKPACKCPAH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	[NotNull]
	Task<T> ENAMDLEEABK
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	[NotNull]
	NPCIDDLFILB<T> JEOFKHDOBBM
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class DINGDDJNDFM
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	private sealed class PADMINGHEGC<T> : ICKOEGBDKCH<T?> where T : class
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override Task<T?> ENAMDLEEABK
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override NPCIDDLFILB<T?> JEOFKHDOBBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x7B22D0", Offset = "0x7B10D0", VA = "0x1807B22D0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x41B9240", Offset = "0x41B8040", VA = "0x1841B9240")]
		public PADMINGHEGC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "10")]
		protected override void PBMNEGEAJIM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private sealed class NNOCMFJBNHK<T> : ICKOEGBDKCH<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override Task<T> ENAMDLEEABK
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override NPCIDDLFILB<T> JEOFKHDOBBM
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x7B22D0", Offset = "0x7B10D0", VA = "0x1807B22D0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x404C3C0", Offset = "0x404B1C0", VA = "0x18404C3C0")]
		public NNOCMFJBNHK(Exception CCDENENMPHG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "10")]
		protected override void PBMNEGEAJIM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	private sealed class JBCBFEHGFOG<T> : ICKOEGBDKCH<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		[CompilerGenerated]
		private struct GMLLAKNIKFG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public Task<BCJOGHANCKE<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			private TaskAwaiter<BCJOGHANCKE<T>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			private TaskAwaiter<T> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x39601E0", Offset = "0x395EFE0", VA = "0x1839601E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x3960690", Offset = "0x395F490", VA = "0x183960690", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		[CompilerGenerated]
		private struct JGBOHOIAHNH : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public Task<BCJOGHANCKE<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			private TaskAwaiter<BCJOGHANCKE<T>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x3C20E50", Offset = "0x3C1FC50", VA = "0x183C20E50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x3C210E0", Offset = "0x3C1FEE0", VA = "0x183C210E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly Task<BCJOGHANCKE<T>> NOMCGJJBLOJ;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override Task<T> ENAMDLEEABK
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x7B22D0", Offset = "0x7B10D0", VA = "0x1807B22D0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override NPCIDDLFILB<T> JEOFKHDOBBM
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x7B22C0", Offset = "0x7B10C0", VA = "0x1807B22C0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x3C16BA0", Offset = "0x3C159A0", VA = "0x183C16BA0")]
		public JBCBFEHGFOG(Task<BCJOGHANCKE<T>> JKCFEOGKFBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x3C16B20", Offset = "0x3C15920", VA = "0x183C16B20", Slot = "10")]
		protected override void PBMNEGEAJIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x3C169D0", Offset = "0x3C157D0", VA = "0x183C169D0")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(JBCBFEHGFOG<>.GMLLAKNIKFG))]
		internal static Task<T> MEHHIBKFNDP(Task<BCJOGHANCKE<T>> JKCFEOGKFBB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x3C168F0", Offset = "0x3C156F0", VA = "0x183C168F0")]
		[AsyncStateMachine(typeof(JBCBFEHGFOG<>.JGBOHOIAHNH))]
		[CompilerGenerated]
		internal static Task FJHMAFAJBIK(Task<BCJOGHANCKE<T>> JKCFEOGKFBB)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x274F850", Offset = "0x274E650", VA = "0x18274F850")]
	public static BCJOGHANCKE<T> CNCELEPFOGN<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x269D350", Offset = "0x269C150", VA = "0x18269D350")]
	public static BCJOGHANCKE<T> DIDGHHJHICA<T>(Exception CCDENENMPHG) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x269D350", Offset = "0x269C150", VA = "0x18269D350")]
	public static BCJOGHANCKE<T> CFFKKICMGPP<T>(Task<BCJOGHANCKE<T>> JKCFEOGKFBB) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public abstract class ICKOEGBDKCH<T> : BCJOGHANCKE<T>, LNKPACKCPAH, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static readonly string OEJLGHNECDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly OFLIHLAMOOO OGJBPMCDCDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private bool KJIMDOIMIPD;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool BOHPGLCBGLD
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0xA0E340", Offset = "0xA0D140", VA = "0x180A0E340", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public abstract Task<T> ENAMDLEEABK
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public abstract NPCIDDLFILB<T> JEOFKHDOBBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x3A6E680", Offset = "0x3A6D480", VA = "0x183A6E680")]
	public ICKOEGBDKCH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x3A6E420", Offset = "0x3A6D220", VA = "0x183A6E420", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void PBMNEGEAJIM();
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public abstract class GEJKKAEHLKJ<TTask, T> : ICKOEGBDKCH<T> where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class HGAJGDCENAI
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		private struct <<-ctor>g__AwaitThenTransformTaskResult|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public TTask originalTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			public HGAJGDCENAI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x3274B40", Offset = "0x3273940", VA = "0x183274B40", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x3274E00", Offset = "0x3273C00", VA = "0x183274E00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public GEJKKAEHLKJ<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public HGAJGDCENAI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x39BB750", Offset = "0x39BA550", VA = "0x1839BB750")]
		[AsyncStateMachine(typeof(GEJKKAEHLKJ<, >.HGAJGDCENAI.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> HLIELDIEIEO(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private readonly Task<T> JKCFEOGKFBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	protected readonly CancellationTokenSource PGKPKKCBGGG;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public override Task<T> ENAMDLEEABK
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public override NPCIDDLFILB<T> JEOFKHDOBBM
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x7B22D0", Offset = "0x7B10D0", VA = "0x1807B22D0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x38FFC10", Offset = "0x38FEA10", VA = "0x1838FFC10")]
	protected GEJKKAEHLKJ(TTask JKCFEOGKFBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x38FFA00", Offset = "0x38FE800", VA = "0x1838FFA00", Slot = "10")]
	protected override void PBMNEGEAJIM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract T KBJJEKEEDMM(TTask AJLHJOIDHFC);

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "12")]
	protected abstract void NIPEBFMDMLH();
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class NBMEHHEFNPE<T> : ICKOEGBDKCH<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly HFMDJFNGONB<Task<T>> DIPPOCGIMAL;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public override Task<T> ENAMDLEEABK
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x3DCA3F0", Offset = "0x3DC91F0", VA = "0x183DCA3F0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public override NPCIDDLFILB<T> JEOFKHDOBBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x7B22D0", Offset = "0x7B10D0", VA = "0x1807B22D0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x3FF3650", Offset = "0x3FF2450", VA = "0x183FF3650")]
	public NBMEHHEFNPE(HFMDJFNGONB<Task<T>> LOMAEAMACNE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x3FF3630", Offset = "0x3FF2430", VA = "0x183FF3630", Slot = "10")]
	protected override void PBMNEGEAJIM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class IFLPLGEGCHC
{
	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x61E93E0", Offset = "0x61E81E0", VA = "0x1861E93E0")]
	[NotNull]
	public static byte[] FLMENICGAHJ(this LBOLCDOJHPP OINIGHMKHJF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x61E9370", Offset = "0x61E8170", VA = "0x1861E9370")]
	[NotNull]
	public static byte[] FLMENICGAHJ(this LBOLCDOJHPP OINIGHMKHJF, HashAlgorithmName CAMMNAKGKDE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x61E95F0", Offset = "0x61E83F0", VA = "0x1861E95F0")]
	public static bool IDNGMNHFAAK([CanBeNull] this LBOLCDOJHPP OINIGHMKHJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x61E9450", Offset = "0x61E8250", VA = "0x1861E9450")]
	public static bool IDNGMNHFAAK([CanBeNull] this LBOLCDOJHPP OINIGHMKHJF, [Out] string EPIMHJFIPDE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x61E9780", Offset = "0x61E8580", VA = "0x1861E9780")]
	private static bool KJAAAEJFODD([NotNull] LBOLCDOJHPP OINIGHMKHJF, [Out][CanBeNull] byte[] EDFAHDHHALE, [Out][CanBeNull] byte[] GCECICPJNNO)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class CMPCPPMIEJH
{
	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x61E8950", Offset = "0x61E7750", VA = "0x1861E8950")]
	[NotNull]
	public static byte[] FLMENICGAHJ(this CGOHMGMKPBG JFJILEICGMH, HashAlgorithmName CAMMNAKGKDE, byte[] PAABDFDPKMF)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface CGOHMGMKPBG
{
	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash CBBELKKKCJN);
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public interface LBOLCDOJHPP : CGOHMGMKPBG
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	[CanBeNull]
	byte[] KAJMNKMHLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	[CanBeNull]
	byte[] IKGPPJFPGDL
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class CGHONBBKGEF
{
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private static readonly ArrayPool<byte> BFGHJGHFGMN;

	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private static bool FGIPKGPECLA;

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x2714280", Offset = "0x2713080", VA = "0x182714280")]
	public static void CNOFCCODMPD<T>(this IncrementalHash LKHBMEAECCE, [CanBeNull] T FFDKILKJFCC) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x2714340", Offset = "0x2713140", VA = "0x182714340")]
	public static void IEBBAEKJLBB<T>(this IncrementalHash LKHBMEAECCE, [CanBeNull] T JFJILEICGMH) where T : CGOHMGMKPBG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x2713D60", Offset = "0x2712B60", VA = "0x182713D60")]
	public static void ALCNBAFBBBB<T>(this IncrementalHash LKHBMEAECCE, [CanBeNull] IList<T> MFANBODKMBG) where T : CGOHMGMKPBG
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x61E83E0", Offset = "0x61E71E0", VA = "0x1861E83E0")]
	private static bool NDBGPABGEEF([CanBeNull] CGOHMGMKPBG JFJILEICGMH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x61E7E50", Offset = "0x61E6C50", VA = "0x1861E7E50")]
	public static void EKHLIMOIIGB(this IncrementalHash CBBELKKKCJN, [CanBeNull] string CMAFIAACOLA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x61E8470", Offset = "0x61E7270", VA = "0x1861E8470")]
	public static void NPFLKCMJJDK(this IncrementalHash CBBELKKKCJN, long ECDOKBJJIPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x61E7C20", Offset = "0x61E6A20", VA = "0x1861E7C20")]
	public static void CHDAHDCDHBN(this IncrementalHash CBBELKKKCJN, int CHIJPDGLHEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x61E8210", Offset = "0x61E7010", VA = "0x1861E8210")]
	public static void LBJCLGPMOBP(this IncrementalHash CBBELKKKCJN, short MECHMIHFEAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x61E7B10", Offset = "0x61E6910", VA = "0x1861E7B10")]
	public static void AIJDFAPKJPC(this IncrementalHash CBBELKKKCJN, byte EGJMJDMJBON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x61E7F10", Offset = "0x61E6D10", VA = "0x1861E7F10")]
	public static void GLFMMGKMKAH(this IncrementalHash CBBELKKKCJN, bool ONPEGBNLFMA, bool GFCKDFNIDJA = false, bool FODIMKCMAII = false, bool GOKLCOAPDNF = false, bool LAGDICGCGKH = false, bool OIAPJEIMJDN = false, bool GMOPENBPHJO = false, bool NINFABBKDND = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x27143D0", Offset = "0x27131D0", VA = "0x1827143D0")]
	public static void JIBGLPENGEO<T>(this IncrementalHash CBBELKKKCJN, T GOCCBDNGINL) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x61E7AB0", Offset = "0x61E68B0", VA = "0x1861E7AB0")]
	public static void ADOMJKECLKE(this IncrementalHash CBBELKKKCJN, float IKEFDCCMCBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x61E8080", Offset = "0x61E6E80", VA = "0x1861E8080")]
	public static void JFFJAHFEOEK(this IncrementalHash CBBELKKKCJN, ulong APLDOMFCMLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x61E7EB0", Offset = "0x61E6CB0", VA = "0x1861E7EB0")]
	public static void GHLNNFPDEDH(this IncrementalHash CBBELKKKCJN, uint CLMKBLKAEOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x61E7DF0", Offset = "0x61E6BF0", VA = "0x1861E7DF0")]
	public static void DGJCIBDAPCB(this IncrementalHash CBBELKKKCJN, ushort FALPPPFNLPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x61E80E0", Offset = "0x61E6EE0", VA = "0x1861E80E0")]
	public static void KIPGFDFMOGB(this IncrementalHash CBBELKKKCJN, Vector3 EHAPDCBCKPJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class CCGJMOLDPGI : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x61E7990", Offset = "0x61E6790", VA = "0x1861E7990")]
	public CCGJMOLDPGI(string HPJAAILCALJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public abstract class FLPOAGGPGOP<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	internal class KIBBJKHEIIJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public TNode ILACEKALGJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public TNode OGCHMLDLLMJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public BFHBHNBFBPN IMGBGPELIHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public List<BFHBHNBFBPN> EELCBLHLCHN;

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public KIBBJKHEIIJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal struct BFHBHNBFBPN : IComparable<BFHBHNBFBPN>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public int BLHNHPBIGKL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public TClaimant DKGOBPAGDGF;

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xC2B5C0", Offset = "0xC2A3C0", VA = "0x180C2B5C0")]
		public BFHBHNBFBPN(int BLHNHPBIGKL, TClaimant DKGOBPAGDGF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x4852090", Offset = "0x4850E90", VA = "0x184852090")]
		public bool KKGBOANHGBM([In] BFHBHNBFBPN GGINNHLAMLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x48520F0", Offset = "0x4850EF0", VA = "0x1848520F0")]
		public bool PONDNFMBGHC([In] BFHBHNBFBPN GGINNHLAMLI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x4852080", Offset = "0x4850E80", VA = "0x184852080", Slot = "4")]
		public int CompareTo(BFHBHNBFBPN GGINNHLAMLI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x4852100", Offset = "0x4850F00", VA = "0x184852100", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public enum JPHNAHLMOEP
	{
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class KIBALHHPOIN : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C6")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C7")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C8")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C9")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public FLPOAGGPGOP<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000191")]
			[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000193")]
			[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x802B10", Offset = "0x801910", VA = "0x180802B10")]
		[DebuggerHidden]
		public KIBALHHPOIN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x3D0B330", Offset = "0x3D0A130", VA = "0x183D0B330", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x3D0B4F0", Offset = "0x3D0A2F0", VA = "0x183D0B4F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x3D0B410", Offset = "0x3D0A210", VA = "0x183D0B410", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x37E00E0", Offset = "0x37DEEE0", VA = "0x1837E00E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private static readonly ELNLLPJPMEE<KIBBJKHEIIJ> GPDAKNOAMMH;

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static readonly ELNLLPJPMEE<List<BFHBHNBFBPN>> DNJPFNGDDDI;

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static int ALACMBGAEIE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	internal readonly Dictionary<TClaimant, TNode> EFEDNFGNKFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	internal readonly Dictionary<TNode, KIBBJKHEIIJ> GIIEOAIILAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private JPHNAHLMOEP JLLJLOICEHP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private bool COIBHEFKPKD;

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode MPDJOKILJNF(TNode FMEAKEGGFNK);

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void EMJCMBFAOGD(TNode FMEAKEGGFNK, TClaimant BHCMCJOGLAC, TClaimant EEPJNNLCICK);

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x3858BB0", Offset = "0x38579B0", VA = "0x183858BB0")]
	public FLPOAGGPGOP(JPHNAHLMOEP JLLJLOICEHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x3858640", Offset = "0x3857440", VA = "0x183858640")]
	public void LMCAJNCNNAN(TNode FMEAKEGGFNK, TNode OIJEBDLJMMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x3858400", Offset = "0x3857200", VA = "0x183858400")]
	public void JHGMHHAMLMI(TClaimant DKGOBPAGDGF, TNode DNNLHAAIIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x3857B10", Offset = "0x3856910", VA = "0x183857B10", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x3857CB0", Offset = "0x3856AB0", VA = "0x183857CB0")]
	private void FAILFANPKOK(TClaimant DKGOBPAGDGF, TNode FJAFHMHEIPN, TNode DNNLHAAIIDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x3858390", Offset = "0x3857190", VA = "0x183858390")]
	private int HIICNPGLNOC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x3858070", Offset = "0x3856E70", VA = "0x183858070")]
	private void GAOMDEDOGEF(TClaimant DKGOBPAGDGF, TNode POLACCHFGKI, TNode DONPBLGNHAN, int INOEONNEAEG = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x38586D0", Offset = "0x38574D0", VA = "0x1838586D0")]
	private void MEIHAJAPPEA(BFHBHNBFBPN BLAPNMAJHCB, KIBBJKHEIIJ OKABCGPFCBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x3858750", Offset = "0x3857550", VA = "0x183858750")]
	private void PHNKPIBINLJ(TClaimant DKGOBPAGDGF, TNode POLACCHFGKI, TNode DONPBLGNHAN, int INOEONNEAEG = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x3857920", Offset = "0x3856720", VA = "0x183857920")]
	private void CNCIOGPIDMK(BFHBHNBFBPN BLAPNMAJHCB, TNode FMEAKEGGFNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x3857A30", Offset = "0x3856830", VA = "0x183857A30")]
	private void DMDFJJHOCPO(BFHBHNBFBPN BLAPNMAJHCB, KIBBJKHEIIJ OKABCGPFCBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x3858520", Offset = "0x3857320", VA = "0x183858520")]
	private void LAJLFOPGKEJ(KIBBJKHEIIJ OKABCGPFCBI, bool LIFKHLILMIA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x3857D50", Offset = "0x3856B50", VA = "0x183857D50")]
	private void FPKKEJOPAMG(KIBBJKHEIIJ OKABCGPFCBI, TNode OIJEBDLJMMH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x38574C0", Offset = "0x38562C0", VA = "0x1838574C0")]
	[IteratorStateMachine(typeof(FLPOAGGPGOP<, >.KIBALHHPOIN))]
	private IEnumerable<TNode> AJNBFMCAFHK(TNode POLACCHFGKI, TNode DONPBLGNHAN, bool MPBIIHIBIAK = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x38576E0", Offset = "0x38564E0", VA = "0x1838576E0")]
	private KIBBJKHEIIJ CCGMKJNAAHD(TNode FMEAKEGGFNK, TNode OGCHMLDLLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x3857590", Offset = "0x3856390", VA = "0x183857590")]
	private KIBBJKHEIIJ CALFJEEJKDN(TNode FMEAKEGGFNK, TNode OGCHMLDLLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x38577C0", Offset = "0x38565C0", VA = "0x1838577C0")]
	private void CMPEKHLBJOK(KIBBJKHEIIJ OKABCGPFCBI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class EPGBAHIGGGB<T> : IEnumerable<EPGBAHIGGGB<T>.EMKMGCAKOAO>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct EMKMGCAKOAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public T DIBNBLEEFNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public int AELAKOMEEDP;
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public class CBIOCPAJGJD : IEnumerator<EMKMGCAKOAO>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private EPGBAHIGGGB<T> PKHKCIJFODK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private int AELAKOMEEDP;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x34D3410", Offset = "0x34D2210", VA = "0x1834D3410", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public EMKMGCAKOAO HKCIIOLPAGP
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x4C3F5B0", Offset = "0x4C3E3B0", VA = "0x184C3F5B0", Slot = "4")]
			get
			{
				return default(EMKMGCAKOAO);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x4C3F4C0", Offset = "0x4C3E2C0", VA = "0x184C3F4C0")]
		public CBIOCPAJGJD(EPGBAHIGGGB<T> PKHKCIJFODK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x4C3F440", Offset = "0x4C3E240", VA = "0x184C3F440", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x3526A60", Offset = "0x3525860", VA = "0x183526A60", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x86C2C0", Offset = "0x86B0C0", VA = "0x18086C2C0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private struct JPJGENNLKJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public bool EMDMBDAKNLD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public T DIBNBLEEFNN;
	}

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private const int EMEPDPNJOFK = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private readonly Dictionary<T, int> MKGPINOICLC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private JPJGENNLKJE[] BJLPFGOAPOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private int ECLFENJOMFP;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public int FFBAAHNCNGE
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x7EF360", Offset = "0x7EE160", VA = "0x1807EF360")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x7EEE30", Offset = "0x7EDC30", VA = "0x1807EEE30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public int BLPIMLOHMJK
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x3284510", Offset = "0x3283310", VA = "0x183284510")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x34CC7D0", Offset = "0x34CB5D0", VA = "0x1834CC7D0")]
	public EPGBAHIGGGB(int GIOLCDOMFDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x34CCC50", Offset = "0x34CBA50", VA = "0x1834CCC50")]
	public EPGBAHIGGGB(EMKMGCAKOAO[] KDMFGCDEBON, bool FFOCIMMBCFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x34CBB90", Offset = "0x34CA990", VA = "0x1834CBB90")]
	public int FBCKIEDPFFD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x34CBFD0", Offset = "0x34CADD0", VA = "0x1834CBFD0")]
	private int LBACFEDAELI()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x34CBB40", Offset = "0x34CA940", VA = "0x1834CBB40", Slot = "6")]
	protected virtual uint DKMADHCHGKB(uint CBBELKKKCJN, T DIBNBLEEFNN)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x34CBD70", Offset = "0x34CAB70", VA = "0x1834CBD70")]
	public bool JOEEKNMILFN(T DIBNBLEEFNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x34CC1A0", Offset = "0x34CAFA0", VA = "0x1834CC1A0")]
	public int LLCANGLOPHL(T DIBNBLEEFNN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x34CBD00", Offset = "0x34CAB00", VA = "0x1834CBD00")]
	public T HCBNBLGHOHO(int AELAKOMEEDP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x34CC6C0", Offset = "0x34CB4C0", VA = "0x1834CC6C0")]
	public bool NPFFPDIACNA(T DIBNBLEEFNN, bool JMKIOJNDFKP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x34CC4C0", Offset = "0x34CB2C0", VA = "0x1834CC4C0")]
	public bool NPFFPDIACNA(T DIBNBLEEFNN, int AELAKOMEEDP, bool JMKIOJNDFKP = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x34CBC60", Offset = "0x34CAA60", VA = "0x1834CBC60")]
	private int HBKJDLMFGME(int DLJHEFPEFCO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x34CC750", Offset = "0x34CB550", VA = "0x1834CC750", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x34CC750", Offset = "0x34CB550", VA = "0x1834CC750", Slot = "4")]
	private IEnumerator<EMKMGCAKOAO> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class ELNLLPJPMEE<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly Stack<T> GGLMMKNEPJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private readonly List<T> CNLOLHKLDFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly int EADBCFJGEAE;

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x3498180", Offset = "0x3496F80", VA = "0x183498180")]
	public static ELNLLPJPMEE<T> PIOEKEBDHHF(int GIOLCDOMFDF = 0, int EADBCFJGEAE = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x34980A0", Offset = "0x3496EA0", VA = "0x1834980A0")]
	public static ELNLLPJPMEE<T> PGBIJNJMPJO(int GIOLCDOMFDF = 0, int EADBCFJGEAE = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x3498260", Offset = "0x3497060", VA = "0x183498260")]
	public ELNLLPJPMEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x3498290", Offset = "0x3497090", VA = "0x183498290")]
	public ELNLLPJPMEE(int GIOLCDOMFDF, int EADBCFJGEAE = int.MaxValue, bool AHJDEAGOFKC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x3497A60", Offset = "0x3496860", VA = "0x183497A60")]
	public T APGDKGKLOIJ()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x3497FD0", Offset = "0x3496DD0", VA = "0x183497FD0")]
	public void IHAHIMEKHEN(T DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x3497F00", Offset = "0x3496D00", VA = "0x183497F00")]
	private void GNNFHEDFOBH(T DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x3497BC0", Offset = "0x34969C0", VA = "0x183497BC0")]
	private void BNPEPOKKDAO(T DIBNBLEEFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x3497BE0", Offset = "0x34969E0", VA = "0x183497BE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x3497D10", Offset = "0x3496B10", VA = "0x183497D10")]
	private void FEAFDNNPMEE(IEnumerable<T> NIEBKKPIOLC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class AMILJGCHIJA<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private Dictionary<int, T> BHHBJAICHNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private T KIPCDLNDDKA;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public virtual T MFJIIINLKFG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x7AE390", Offset = "0x7AD190", VA = "0x1807AE390", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x7B1930", Offset = "0x7B0730", VA = "0x1807B1930", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x391D480", Offset = "0x391C280", VA = "0x18391D480")]
	public bool HJOOJPBLNDO(T DIBNBLEEFNN, int BLHNHPBIGKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x391D560", Offset = "0x391C360", VA = "0x18391D560")]
	public bool HPJCIBMLEPI(int BLHNHPBIGKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x391D600", Offset = "0x391C400", VA = "0x18391D600")]
	public T LCPMPKHKOPB(int ENFMNHPAFPO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x391D9A0", Offset = "0x391C7A0", VA = "0x18391D9A0")]
	private bool PNMJGIBPLIB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x391D5C0", Offset = "0x391C3C0", VA = "0x18391D5C0")]
	public bool JJGGEGPCFME(int BLHNHPBIGKL, [Out] T DIBNBLEEFNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x391DB40", Offset = "0x391C940", VA = "0x18391DB40")]
	public AMILJGCHIJA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class PJMMLCPFNIC<T>
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	protected struct GPKLNEOHHND
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public T ACOGNAIJGCD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public int HCKLHOGNAFI;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	protected readonly List<GPKLNEOHHND> AEBHMCHAANA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private T OEFGHGPPDBK;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public int BLPIMLOHMJK
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x3284510", Offset = "0x3283310", VA = "0x183284510")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x41CFAC0", Offset = "0x41CE8C0", VA = "0x1841CFAC0")]
	public bool FLKCGLEENDL(T DIBNBLEEFNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x41CFC30", Offset = "0x41CEA30", VA = "0x1841CFC30")]
	public void HDCMKJKDALC(T DIBNBLEEFNN, int BLHNHPBIGKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x41CF990", Offset = "0x41CE790", VA = "0x1841CF990")]
	public bool BOIJHFOIOPE(T DIBNBLEEFNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x41CFCD0", Offset = "0x41CEAD0", VA = "0x1841CFCD0")]
	public void HOCLBDDCDMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x41CFD30", Offset = "0x41CEB30", VA = "0x1841CFD30")]
	public T LJADOJNOECE()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x41CFDB0", Offset = "0x41CEBB0", VA = "0x1841CFDB0")]
	private void NDMFDOJIBGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x41CFF10", Offset = "0x41CED10", VA = "0x1841CFF10")]
	public PJMMLCPFNIC()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		[SerializeField]
		[FHFEFOGEDAO(KLKJAELFHOF.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x61EAB20", Offset = "0x61E9920", VA = "0x1861EAB20")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x61EADF0", Offset = "0x61E9BF0", VA = "0x1861EADF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x61EAD00", Offset = "0x61E9B00", VA = "0x1861EAD00")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x61EAA70", Offset = "0x61E9870", VA = "0x1861EAA70")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x61EAD40", Offset = "0x61E9B40", VA = "0x1861EAD40")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x61EAC50", Offset = "0x61E9A50", VA = "0x1861EAC50")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x61EA9F0", Offset = "0x61E97F0", VA = "0x1861EA9F0")]
		public ReferencePoint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200005E")]
	public abstract class ResourcePrefabReference<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E8")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x43C8530", Offset = "0x43C7330", VA = "0x1843C8530", Slot = "4")]
		public virtual T GCLDGHOICFC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class LAAJJMFJOAG : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private Dictionary<byte, IDFMPJCMJCF> HNPFLALJCPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly ELNLLPJPMEE<IDFMPJCMJCF> DNLDFPCKOFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly bool ICMEHOIJPKK;

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public IDFMPJCMJCF JGPLPBPICLI
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x7B1BD0", Offset = "0x7B09D0", VA = "0x1807B1BD0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x7B1BC0", Offset = "0x7B09C0", VA = "0x1807B1BC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public Vector2 DGEIMDEIBON
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0xBAED40", Offset = "0xBADB40", VA = "0x180BAED40")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0xE9EFE0", Offset = "0xE9DDE0", VA = "0x180E9EFE0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	private Vector2 OHNCDOCOJOO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0xF10640", Offset = "0xF0F440", VA = "0x180F10640")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public Vector2 IGDDFJGKPJO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x61E9930", Offset = "0x61E8730", VA = "0x1861E9930")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x7BA860", Offset = "0x7B9660", VA = "0x1807BA860")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public int JINPLAIFGKD
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x7B1EE0", Offset = "0x7B0CE0", VA = "0x1807B1EE0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x7B20C0", Offset = "0x7B0EC0", VA = "0x1807B20C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x61EA8B0", Offset = "0x61E96B0", VA = "0x1861EA8B0")]
	public LAAJJMFJOAG(Bounds POIEEOAKPLB, Vector2[] DDACPHDJGBK, int LAAEMFGEPPG, byte DLJHEFPEFCO, float MNDAMLDKFLJ = 0f, [Optional] ELNLLPJPMEE<IDFMPJCMJCF> DNLDFPCKOFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x61E9950", Offset = "0x61E8750", VA = "0x1861E9950")]
	public void APIICINOMCP(Bounds POIEEOAKPLB, Vector2[] DDACPHDJGBK, int LAAEMFGEPPG, byte DLJHEFPEFCO, float MNDAMLDKFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x61E9E00", Offset = "0x61E8C00", VA = "0x1861E9E00")]
	public IDFMPJCMJCF BJOCOKJLGAD(byte AELAKOMEEDP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x61EA7E0", Offset = "0x61E95E0", VA = "0x1861EA7E0")]
	public void OHLJLPNFAGF(Vector3 JPLKOMKCHGP, float AHHALIDBDEP, float ACEJPKBGMGN, List<byte> INJEKIDLOEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x59526B0", Offset = "0x59514B0", VA = "0x1859526B0")]
	public void EPOIDEGCFEK(IDFMPJCMJCF.IEHGOEIKFNG GPHPHGHEELB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x61EA0E0", Offset = "0x61E8EE0", VA = "0x1861EA0E0")]
	public static int FOEOJKNHNDG(Vector2[] DDACPHDJGBK, int LAAEMFGEPPG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x61EA230", Offset = "0x61E9030", VA = "0x1861EA230")]
	private IDFMPJCMJCF GMNINBGPKHI(byte AELAKOMEEDP, IDFMPJCMJCF.LIHCFKKOJDE PAHBOGAIEJG, IDFMPJCMJCF OGCHMLDLLMJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x61EA430", Offset = "0x61E9230", VA = "0x1861EA430")]
	private void OGBADJADPBG(IDFMPJCMJCF OGCHMLDLLMJ, Vector2[] DDACPHDJGBK, int HMPPGOPBKDB, int NJOCIKEGAIO, int BJJAIOOMKHE, int GLKLJABEPCO, float MNDAMLDKFLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x61E9EC0", Offset = "0x61E8CC0", VA = "0x1861E9EC0")]
	private void EGAACBOIJPB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x61E9E60", Offset = "0x61E8C60", VA = "0x1861E9E60", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x61EA1D0", Offset = "0x61E8FD0", VA = "0x1861EA1D0", Slot = "1")]
	~LAAJJMFJOAG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class IDFMPJCMJCF
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public enum LIHCFKKOJDE
	{
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public enum IEHGOEIKFNG
	{
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	public byte FLJIHJMFGKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public Vector3 INGOJFMNOLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public Vector3 EDOPLBKMBBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public Vector3 JPFKCPJOONH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public Vector3 GMFMOKHHGOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public LIHCFKKOJDE OJELAEAEPMA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public IDFMPJCMJCF DBLFEIKNGIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public List<IDFMPJCMJCF> MIEFHCCHEEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public bool NDKFMAFPIKP;

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x61E9350", Offset = "0x61E8150", VA = "0x1861E9350")]
	public IDFMPJCMJCF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x61E8FD0", Offset = "0x61E7DD0", VA = "0x1861E8FD0")]
	public void LMOKIJJFMPI(IDFMPJCMJCF APEMCPNHEOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x7B07A0", Offset = "0x7AF5A0", VA = "0x1807B07A0")]
	public void EPOIDEGCFEK(int LONNPEGHJLG, IEHGOEIKFNG GPHPHGHEELB, int FEGBLIIJCJA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x61E90F0", Offset = "0x61E7EF0", VA = "0x1861E90F0")]
	public void OHLJLPNFAGF(List<byte> INJEKIDLOEK, Vector3 JPLKOMKCHGP, float AHHALIDBDEP, float ACEJPKBGMGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x61E8F10", Offset = "0x61E7D10", VA = "0x1861E8F10")]
	public bool GBDGFNBPOOB(Vector3 NJLPKKMGOKN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x61E8EE0", Offset = "0x61E7CE0", VA = "0x1861E8EE0")]
	public bool AJEMDPLBFAA(Vector3 NJLPKKMGOKN, float APINMCPOIPI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x61E8F40", Offset = "0x61E7D40", VA = "0x1861E8F40")]
	public void HBPIHILNAPB()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x2000064")]
		public struct OAEJCCEPIAJ<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			private readonly List<Component> GIJBOOPKLBM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			private readonly bool KKPAPBHAANO;

			[Cpp2IlInjected.Token(Token = "0x60001F4")]
			[Cpp2IlInjected.Address(RVA = "0x3A907A0", Offset = "0x3A8F5A0", VA = "0x183A907A0")]
			public OAEJCCEPIAJ(List<Component> GIJBOOPKLBM, bool KKPAPBHAANO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F5")]
			[Cpp2IlInjected.Address(RVA = "0x40FD640", Offset = "0x40FC440", VA = "0x1840FD640")]
			public OKHBHFMHFMG<T> CNEJODDGPIM()
			{
				return default(OKHBHFMHFMG<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x40FD6A0", Offset = "0x40FC4A0", VA = "0x1840FD6A0", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x40FD6A0", Offset = "0x40FC4A0", VA = "0x1840FD6A0", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000065")]
		public struct OKHBHFMHFMG<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000109")]
			private readonly List<Component> GIJBOOPKLBM;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			private readonly bool KKPAPBHAANO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010B")]
			private int AELAKOMEEDP;

			[Cpp2IlInjected.Token(Token = "0x17000059")]
			public T HKCIIOLPAGP
			{
				[Cpp2IlInjected.Token(Token = "0x60001F9")]
				[Cpp2IlInjected.Address(RVA = "0x4119FA0", Offset = "0x4118DA0", VA = "0x184119FA0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005A")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001FA")]
				[Cpp2IlInjected.Address(RVA = "0x4119F30", Offset = "0x4118D30", VA = "0x184119F30", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x4119F70", Offset = "0x4118D70", VA = "0x184119F70")]
			public OKHBHFMHFMG(List<Component> GIJBOOPKLBM, bool KKPAPBHAANO)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FB")]
			[Cpp2IlInjected.Address(RVA = "0x4119E70", Offset = "0x4118C70", VA = "0x184119E70", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FC")]
			[Cpp2IlInjected.Address(RVA = "0x4119E80", Offset = "0x4118C80", VA = "0x184119E80", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x35166D0", Offset = "0x35154D0", VA = "0x1835166D0", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x7B4080", Offset = "0x7B2E80", VA = "0x1807B4080")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x61EC570", Offset = "0x61EB370", VA = "0x1861EC570")]
		private void HBPIHILNAPB(GameObject ICOCFNDGAFN, bool NLMEJPDDFJD = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x61EC6E0", Offset = "0x61EB4E0", VA = "0x1861EC6E0")]
		public static void HBPIHILNAPB(GameObject ICOCFNDGAFN, ToolHierarchyCache GHOBDPKIBDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x2B938F0", Offset = "0x2B926F0", VA = "0x182B938F0")]
		public void IFKCPIJHAMD<T>(Action<T> GOECALGCLOK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x2B93B10", Offset = "0x2B92910", VA = "0x182B93B10")]
		public T PHAMECBEJLC<T>(bool KKPAPBHAANO = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x2B93830", Offset = "0x2B92630", VA = "0x182B93830")]
		public OAEJCCEPIAJ<T> HABPAKOBGFO<T>(bool KKPAPBHAANO = false) where T : class
		{
			return default(OAEJCCEPIAJ<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x61EC130", Offset = "0x61EAF30", VA = "0x1861EC130")]
		public List<Component> ADIHKFLJAPH(Type DDEINLAGLLL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x61EC480", Offset = "0x61EB280", VA = "0x1861EC480", Slot = "4")]
		public bool Equals(ToolHierarchyCache FCLAAGLFIOD, ToolHierarchyCache OJPNBFDBAHJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x61EC500", Offset = "0x61EB300", VA = "0x1861EC500", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache EIFMADKIHON)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class DIJFOOJOECM<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private int GIOLCDOMFDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private int GEHAFBFCDCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private List<T> LAIKHCJLDKC;

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public int BLPIMLOHMJK
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x3DCA3F0", Offset = "0x3DC91F0", VA = "0x183DCA3F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public T HFBNPFMLIOA
	{
		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x51516E0", Offset = "0x51504E0", VA = "0x1851516E0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public T LLHMMLPONAM
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x5151280", Offset = "0x5150080", VA = "0x185151280")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public T ANJJGNGJHCG
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x5151620", Offset = "0x5150420", VA = "0x185151620")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x5151830", Offset = "0x5150630", VA = "0x185151830")]
	public DIJFOOJOECM(int GIOLCDOMFDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x51513C0", Offset = "0x51501C0", VA = "0x1851513C0")]
	public void HDCMKJKDALC(T BGBONPJKDJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x5151590", Offset = "0x5150390", VA = "0x185151590")]
	public void HOCLBDDCDMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x51512F0", Offset = "0x51500F0", VA = "0x1851512F0")]
	public void DPHJNGHFHPI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x5151690", Offset = "0x5150490", VA = "0x185151690")]
	public void HPNPJLPPAHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x51513B0", Offset = "0x51501B0", VA = "0x1851513B0")]
	public void FKEBOLJOHKJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public class AAEICIGBGLG<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private struct NNIICJAJCIH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public int HCKLHOGNAFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public T ACOGNAIJGCD;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly Dictionary<object, NNIICJAJCIH> BHHBJAICHNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private readonly EqualityComparer<T> DIEFIGCPEJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private T KIPCDLNDDKA;

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public virtual T MFJIIINLKFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x104D2F0", Offset = "0x104C0F0", VA = "0x18104D2F0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x38D4920", Offset = "0x38D3720", VA = "0x1838D4920", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public bool HDADAKMDAKN
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x38D5390", Offset = "0x38D4190", VA = "0x1838D5390")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public object KAKAFAHLMKG
	{
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x7B8500", Offset = "0x7B7300", VA = "0x1807B8500")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x7B84F0", Offset = "0x7B72F0", VA = "0x1807B84F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x38D50C0", Offset = "0x38D3EC0", VA = "0x1838D50C0")]
	public bool HJOOJPBLNDO(T DIBNBLEEFNN, object ADNDMAGEPOK, int BLHNHPBIGKL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x38D5400", Offset = "0x38D4200", VA = "0x1838D5400")]
	public bool HPJCIBMLEPI(object ADNDMAGEPOK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x38D57F0", Offset = "0x38D45F0", VA = "0x1838D57F0")]
	public bool JJGGEGPCFME(object ADNDMAGEPOK, [Out] T DIBNBLEEFNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x38D53D0", Offset = "0x38D41D0", VA = "0x1838D53D0")]
	public void HOCLBDDCDMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x38D7330", Offset = "0x38D6130", VA = "0x1838D7330")]
	private bool PNMJGIBPLIB()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x38D83A0", Offset = "0x38D71A0", VA = "0x1838D83A0")]
	public AAEICIGBGLG()
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
