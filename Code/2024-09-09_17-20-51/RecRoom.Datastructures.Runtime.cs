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
		[Cpp2IlInjected.Address(RVA = "0x8AE160", Offset = "0x8ACB60", VA = "0x1808AE160")]
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
		[Cpp2IlInjected.Address(RVA = "0x6B6C950", Offset = "0x6B6B350", VA = "0x186B6C950")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x8AE5A0", Offset = "0x8ACFA0", VA = "0x1808AE5A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8AE5E0", Offset = "0x8ACFE0", VA = "0x1808AE5E0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class FPPLCICHMFJ : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x183C420", Offset = "0x183AE20", VA = "0x18183C420")]
	public FPPLCICHMFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HashableScriptableObject : ScriptableObject, NEANMDAOLDD, HEFBBMMKKOC, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x886A70", Offset = "0x885470", VA = "0x180886A70", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x885610", Offset = "0x884010", VA = "0x180885610", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x885640", Offset = "0x884040", VA = "0x180885640", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x933670", Offset = "0x932070", VA = "0x180933670", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash IHNIDNBHBBH);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x994550", Offset = "0x992F50", VA = "0x180994550")]
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
		[Cpp2IlInjected.Address(RVA = "0x6B6DBB0", Offset = "0x6B6C5B0", VA = "0x186B6DBB0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6B6DB70", Offset = "0x6B6C570", VA = "0x186B6DB70")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6B6DBF0", Offset = "0x6B6C5F0", VA = "0x186B6DBF0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6B6DDA0", Offset = "0x6B6C7A0", VA = "0x186B6DDA0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6B6DD10", Offset = "0x6B6C710", VA = "0x186B6DD10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x9B3E20", Offset = "0x9B2820", VA = "0x1809B3E20")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xAF17E0", Offset = "0xAF01E0", VA = "0x180AF17E0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6B6DB30", Offset = "0x6B6C530", VA = "0x186B6DB30")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6B6DC80", Offset = "0x6B6C680", VA = "0x186B6DC80")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6B6D5D0", Offset = "0x6B6BFD0", VA = "0x186B6D5D0")]
	public void CopyBounds(SavedExtents CGCLEIBHLHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6B6DA80", Offset = "0x6B6C480", VA = "0x186B6DA80")]
	public void SetLocalSpaceBounds(Bounds KMPLHNNCEIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xDDCE70", Offset = "0xDDB870", VA = "0x180DDCE70")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6B6DA70", Offset = "0x6B6C470", VA = "0x186B6DA70")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6B6D6C0", Offset = "0x6B6C0C0", VA = "0x186B6D6C0")]
	private void MCFCGLENOED()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6B6D870", Offset = "0x6B6C270", VA = "0x186B6D870")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6B6CF90", Offset = "0x6B6B990", VA = "0x186B6CF90")]
	public static void CalculateLocalBoundsFor(GameObject BICFCMICGIH, [Out] Bounds KMPLHNNCEIG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6B6D600", Offset = "0x6B6C000", VA = "0x186B6D600")]
	private static void DNJCBOLDCAL(Bounds NGNLLOFPDHF, Color JGMIDFFABNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6B6DAA0", Offset = "0x6B6C4A0", VA = "0x186B6DAA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x8821A0", Offset = "0x880BA0", VA = "0x1808821A0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x889F40", Offset = "0x888940", VA = "0x180889F40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x120F260", Offset = "0x120DC60", VA = "0x18120F260")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x4BAB570", Offset = "0x4BA9F70", VA = "0x184BAB570")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "4")]
	public virtual void EOIFKFMODAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
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
	[FPPLCICHMFJ]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4BAB0C0", Offset = "0x4BA9AC0", VA = "0x184BAB0C0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4BA9800", Offset = "0x4BA8200", VA = "0x184BA9800", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4BAB470", Offset = "0x4BA9E70", VA = "0x184BAB470")]
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
	private sealed class JPJPDKEMIHB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public JPJPDKEMIHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x43101D0", Offset = "0x430EBD0", VA = "0x1843101D0")]
		internal int IHPDFPOKHED(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[FPPLCICHMFJ]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x3A51BA0", Offset = "0x3A505A0", VA = "0x183A51BA0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3A51C00", Offset = "0x3A50600", VA = "0x183A51C00", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3A51A80", Offset = "0x3A50480", VA = "0x183A51A80", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey COMNIKKFEEB]
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3A51B40", Offset = "0x3A50540", VA = "0x183A51B40", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3A51930", Offset = "0x3A50330", VA = "0x183A51930", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3A51540", Offset = "0x3A4FF40", VA = "0x183A51540", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3A50900", Offset = "0x3A4F300", VA = "0x183A50900", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3A51750", Offset = "0x3A50150", VA = "0x183A51750", Slot = "14")]
	protected virtual string PNJHIBHGDHM(TKeyVal EHHCOJBHDLA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3A50800", Offset = "0x3A4F200", VA = "0x183A50800", Slot = "4")]
	public bool ContainsKey(TKey COMNIKKFEEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3A517B0", Offset = "0x3A501B0", VA = "0x183A517B0", Slot = "5")]
	public bool TryGetValue(TKey COMNIKKFEEB, [Out] TVal IPHMAHBENGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3A50860", Offset = "0x3A4F260", VA = "0x183A50860", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3A50860", Offset = "0x3A4F260", VA = "0x183A50860", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3A51810", Offset = "0x3A50210", VA = "0x183A51810")]
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
		[Cpp2IlInjected.Address(RVA = "0x885670", Offset = "0x884070", VA = "0x180885670")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8855F0", Offset = "0x883FF0", VA = "0x1808855F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x886A70", Offset = "0x885470", VA = "0x180886A70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
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
		[Cpp2IlInjected.Address(RVA = "0x3DE89D0", Offset = "0x3DE73D0", VA = "0x183DE89D0")]
		public SerializedReferenceKeyValuePair()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[SerializeField]
	[FPPLCICHMFJ]
	private List<SerializedReferenceKeyValuePair> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4BAC770", Offset = "0x4BAB170", VA = "0x184BAC770", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x4BABD20", Offset = "0x4BAA720", VA = "0x184BABD20", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x4BAB470", Offset = "0x4BA9E70", VA = "0x184BAB470")]
	protected SerializedReferenceDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public class HLAKJODDPJE<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	private class DPFHCMFIFNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001A")]
		public float NDFAGPFICFD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001B")]
		public T ADJCIFCGLHC;

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public DPFHCMFIFNM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000012")]
	[CompilerGenerated]
	private sealed class CNKHMCFFAKI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public CNKHMCFFAKI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600004F")]
		[Cpp2IlInjected.Address(RVA = "0x57A4980", Offset = "0x57A3380", VA = "0x1857A4980")]
		internal bool HMBOEAHPNMP(DPFHCMFIFNM sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	public readonly float AFNCINEFBAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000017")]
	public readonly float EPKHDNPEEKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000018")]
	private List<DPFHCMFIFNM> CFCNNOENEMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000019")]
	private EJFLOJLFCKH<DPFHCMFIFNM> BJAIPADGEDH;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public int NAAHDKDBDBM
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x3FC6E30", Offset = "0x3FC5830", VA = "0x183FC6E30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000048")]
	[Cpp2IlInjected.Address(RVA = "0x3FC7850", Offset = "0x3FC6250", VA = "0x183FC7850")]
	public HLAKJODDPJE(float HIMHGPIBAGK, float NAOPAIOLIKB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000049")]
	[Cpp2IlInjected.Address(RVA = "0x3FC6C60", Offset = "0x3FC5660", VA = "0x183FC6C60")]
	public bool FDFIBNIHGDA(float EPEPMIIMOCL, T IPHMAHBENGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600004A")]
	[Cpp2IlInjected.Address(RVA = "0x3FC7430", Offset = "0x3FC5E30", VA = "0x183FC7430")]
	public IEnumerable<T> NBDNGDIHLNB(float EPEPMIIMOCL, [Optional] float? IGDJDKALLCB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x3FC77A0", Offset = "0x3FC61A0", VA = "0x183FC77A0")]
	public void ODPBLJHKGDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3FC6F10", Offset = "0x3FC5910", VA = "0x183FC6F10")]
	private void LIJPAPOJKJJ(float EPEPMIIMOCL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public abstract class NIMFJDPHOKP<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	public struct BMPHPGNIMNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000025")]
		public T ADJCIFCGLHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000026")]
		public float AAHGBGABHOF;
	}

	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private static float MAPEKJBINLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private List<T> MFELHIDMMLL;

	[Cpp2IlInjected.Token(Token = "0x4000022")]
	private const int LCEGEBFPFMO = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	private BMPHPGNIMNK[] FEMJEOMOEIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	private int MKCODMGNGJN;

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public float KMLEHJEOIOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000053")]
		[Cpp2IlInjected.Address(RVA = "0xBE5C60", Offset = "0xBE4660", VA = "0x180BE5C60")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000054")]
		[Cpp2IlInjected.Address(RVA = "0xC23E30", Offset = "0xC22830", VA = "0x180C23E30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x47EEA40", Offset = "0x47ED440", VA = "0x1847EEA40")]
	public NIMFJDPHOKP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x47EE910", Offset = "0x47ED310", VA = "0x1847EE910")]
	public NIMFJDPHOKP(int ECFPAOHDFEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x47EDFC0", Offset = "0x47EC9C0", VA = "0x1847EDFC0")]
	public void KDCHLCHLBCK(float EPEPMIIMOCL, T IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x47EE1D0", Offset = "0x47ECBD0", VA = "0x1847EE1D0")]
	public void ODPBLJHKGDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x47EE3B0", Offset = "0x47ECDB0", VA = "0x1847EE3B0")]
	public bool PPLDJMNOMIC(float HAFKJBOIPFP, float PGHNEKBFHNG, [Out] T IPHMAHBENGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x47ED8B0", Offset = "0x47EC2B0", VA = "0x1847ED8B0")]
	public bool FLHMKFCCAGP(float HAFKJBOIPFP, float PGHNEKBFHNG, [Out] T IPHMAHBENGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x47EDCA0", Offset = "0x47EC6A0", VA = "0x1847EDCA0")]
	public void IHCHGDGKPPH(float HAFKJBOIPFP, float PGHNEKBFHNG, List<T> FJOBMDHPMBB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x47ED830", Offset = "0x47EC230", VA = "0x1847ED830")]
	private int AGIEHBGLCLM(int DMNIPPJFMHL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x47ED860", Offset = "0x47EC260", VA = "0x1847ED860")]
	private void BILHBBJAADK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T OMBFADBJOGE();

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T MFKPNACDNJG(T IPHMAHBENGI, float NNEFLDDEJJK);

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T IHAOACPIFFJ(T MFLKJAHENBP, T PLHCHKLJLJD);

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T NDDGJGMPKFO(T MFLKJAHENBP, T PLHCHKLJLJD);
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class JLEJEPDDJHA : NIMFJDPHOKP<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x8939F0", Offset = "0x8923F0", VA = "0x1808939F0", Slot = "4")]
	protected override Vector3 OMBFADBJOGE()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x6B6BBF0", Offset = "0x6B6A5F0", VA = "0x186B6BBF0", Slot = "5")]
	protected override Vector3 MFKPNACDNJG(Vector3 IPHMAHBENGI, float NNEFLDDEJJK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x6B6BBA0", Offset = "0x6B6A5A0", VA = "0x186B6BBA0", Slot = "6")]
	protected override Vector3 IHAOACPIFFJ(Vector3 MFLKJAHENBP, Vector3 PLHCHKLJLJD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x6B6BC30", Offset = "0x6B6A630", VA = "0x186B6BC30", Slot = "7")]
	protected override Vector3 NDDGJGMPKFO(Vector3 MFLKJAHENBP, Vector3 PLHCHKLJLJD)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x6B6BCB0", Offset = "0x6B6A6B0", VA = "0x186B6BCB0")]
	public JLEJEPDDJHA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000017")]
public static class EOJKFKEDLLK
{
	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x2BD40B0", Offset = "0x2BD2AB0", VA = "0x182BD40B0")]
	public static JMENLDKBDDJ<T1, T2> EMJKOLAJLFI<T1, T2>(T1 KHDAEIIDPKG, T2 DMANDNEKKKL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x2BD4150", Offset = "0x2BD2B50", VA = "0x182BD4150")]
	public static JDMPIAMOMBL<T1, T2, T3> EMJKOLAJLFI<T1, T2, T3>(T1 KHDAEIIDPKG, T2 DMANDNEKKKL, T3 BHPPAAMINHL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x4772810", Offset = "0x4771210", VA = "0x184772810")]
	internal static int DBOGNBLFLBK(int LPDFMCDLOFJ, int ILHOMNINONG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x5F14260", Offset = "0x5F12C60", VA = "0x185F14260")]
	internal static int DBOGNBLFLBK(int LPDFMCDLOFJ, int ILHOMNINONG, int JJMGPIBNEBJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class JMENLDKBDDJ<T1, T2> : IComparable<JMENLDKBDDJ<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly T1 ENPMCCNGDIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly T2 FBJGJNLKJGF;

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4307FB0", Offset = "0x43069B0", VA = "0x184307FB0")]
	public JMENLDKBDDJ(T1 KHDAEIIDPKG, T2 DMANDNEKKKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x4306360", Offset = "0x4304D60", VA = "0x184306360", Slot = "4")]
	public int CompareTo(JMENLDKBDDJ<T1, T2> CGCLEIBHLHF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x4306DE0", Offset = "0x43057E0", VA = "0x184306DE0", Slot = "0")]
	public override bool Equals(object CGCLEIBHLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x4307530", Offset = "0x4305F30", VA = "0x184307530", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4307A70", Offset = "0x4306470", VA = "0x184307A70", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class JDMPIAMOMBL<T1, T2, T3> : IComparable<JDMPIAMOMBL<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	public readonly T1 ENPMCCNGDIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	public readonly T2 FBJGJNLKJGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	public readonly T3 NOCNFJMGEIP;

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x42E0890", Offset = "0x42DF290", VA = "0x1842E0890")]
	public JDMPIAMOMBL(T1 KHDAEIIDPKG, T2 DMANDNEKKKL, T3 BHPPAAMINHL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x42E0080", Offset = "0x42DEA80", VA = "0x1842E0080", Slot = "4")]
	public int CompareTo(JDMPIAMOMBL<T1, T2, T3> CGCLEIBHLHF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x42E02F0", Offset = "0x42DECF0", VA = "0x1842E02F0", Slot = "0")]
	public override bool Equals(object CGCLEIBHLHF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x42E0530", Offset = "0x42DEF30", VA = "0x1842E0530", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x42E06E0", Offset = "0x42DF0E0", VA = "0x1842E06E0", Slot = "3")]
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
	public T ADJCIFCGLHC
	{
		[Cpp2IlInjected.Token(Token = "0x6000076")]
		[Cpp2IlInjected.Address(RVA = "0x2480A60", Offset = "0x247F460", VA = "0x182480A60")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000077")]
		[Cpp2IlInjected.Address(RVA = "0x2480A50", Offset = "0x247F450", VA = "0x182480A50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public float HOBJGBBNKGL
	{
		[Cpp2IlInjected.Token(Token = "0x6000078")]
		[Cpp2IlInjected.Address(RVA = "0x9B6D80", Offset = "0x9B5780", VA = "0x1809B6D80")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4DFD7A0", Offset = "0x4DFC1A0", VA = "0x184DFD7A0")]
	public T IOFDKNNPLLI(float NNEFLDDEJJK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4DFD250", Offset = "0x4DFBC50", VA = "0x184DFD250")]
	public T EAPGJEBLGEF(float NNEFLDDEJJK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T PKEDGJBOHJJ(T MFLKJAHENBP, T PLHCHKLJLJD, float NNEFLDDEJJK);

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x6B69700", Offset = "0x6B68100", VA = "0x186B69700", Slot = "4")]
	protected override float PKEDGJBOHJJ(float MFLKJAHENBP, float PLHCHKLJLJD, float NNEFLDDEJJK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600007E")]
	[Cpp2IlInjected.Address(RVA = "0x6B69740", Offset = "0x6B68140", VA = "0x186B69740")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x10AAD70", Offset = "0x10A9770", VA = "0x1810AAD70", Slot = "4")]
	protected override Vector3 PKEDGJBOHJJ(Vector3 MFLKJAHENBP, Vector3 PLHCHKLJLJD, float NNEFLDDEJJK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x6B6EB70", Offset = "0x6B6D570", VA = "0x186B6EB70")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001D")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x6B68C40", Offset = "0x6B67640", VA = "0x186B68C40", Slot = "4")]
	protected override Color PKEDGJBOHJJ(Color MFLKJAHENBP, Color PLHCHKLJLJD, float NNEFLDDEJJK)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x6B68D00", Offset = "0x6B67700", VA = "0x186B68D00")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public class ADDIMJEENDB : KMFJPCIBHGK<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x6B68BF0", Offset = "0x6B675F0", VA = "0x186B68BF0")]
	public ADDIMJEENDB(int PAODLCPDLEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6B68B80", Offset = "0x6B67580", VA = "0x186B68B80", Slot = "6")]
	protected override uint ICBIPEAPFCF(uint IHNIDNBHBBH, string IPHMAHBENGI)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
public class FDAODHGFMJK : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	public static readonly IDisposable GHBFIIGNNDE;

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	public FDAODHGFMJK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
public struct DAGEOEMCEJK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> PFKAEPEAOIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private int DBNEJJCDEHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private int DCIJIKAMFID;

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3EDD5B0", Offset = "0x3EDBFB0", VA = "0x183EDD5B0")]
	private DAGEOEMCEJK(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> HICMCNGPDLM, int LBPLANOOMED, int CHCOAFEDHAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x5A6E190", Offset = "0x5A6CB90", VA = "0x185A6E190")]
	public static DAGEOEMCEJK<T> OOAFHJGKFEK()
	{
		return default(DAGEOEMCEJK<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x5A6D2D0", Offset = "0x5A6BCD0", VA = "0x185A6D2D0")]
	public (int, int, Task<T>) EHPHGDGAMGP(int EKEAKMCADMP, [Optional] CancellationToken LOIOCMLGMKH, double PEDHHHMMIGP = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x5A6DDC0", Offset = "0x5A6C7C0", VA = "0x185A6DDC0")]
	public void OEOBINPAPLH(int EKEAKMCADMP, int CHCOAFEDHAF, [In] T NLAECIHBKHE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public static class GMGBNFABNCF
{
	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x6B69800", Offset = "0x6B68200", VA = "0x186B69800")]
	public static DAGEOEMCEJK<AJBBHDJGBPP> OOAFHJGKFEK()
	{
		return default(DAGEOEMCEJK<AJBBHDJGBPP>);
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x6B69780", Offset = "0x6B68180", VA = "0x186B69780")]
	public static void OEOBINPAPLH([In] this DAGEOEMCEJK<AJBBHDJGBPP> NKCEKILMAAM, int EKEAKMCADMP, int CHCOAFEDHAF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
[DefaultMember("Item")]
public class GLNMNAKLAEF<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private readonly Dictionary<TKey, TVal> DLCLKJBCFKJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly Dictionary<TVal, TKey> NFCHNMMNLEP;

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public int LEDCMOMLPMG
	{
		[Cpp2IlInjected.Token(Token = "0x600008E")]
		[Cpp2IlInjected.Address(RVA = "0x3764D90", Offset = "0x3763790", VA = "0x183764D90", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public bool MEAEOHJNNNH
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x8CCAB0", Offset = "0x8CB4B0", VA = "0x1808CCAB0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public ICollection<TKey> HMCGKPKIHLL
	{
		[Cpp2IlInjected.Token(Token = "0x6000092")]
		[Cpp2IlInjected.Address(RVA = "0x3DF77B0", Offset = "0x3DF61B0", VA = "0x183DF77B0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public ICollection<TVal> AMANFBLOFLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000093")]
		[Cpp2IlInjected.Address(RVA = "0x3EE0290", Offset = "0x3EDEC90", VA = "0x183EE0290", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public TVal BAKKPFJHLEM
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x3EE0230", Offset = "0x3EDEC30", VA = "0x183EE0230", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x3EE0320", Offset = "0x3EDED20", VA = "0x183EE0320", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public TKey BAKKPFJHLEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A0")]
		[Cpp2IlInjected.Address(RVA = "0x3EDFE90", Offset = "0x3EDE890", VA = "0x183EDFE90")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3EDF530", Offset = "0x3EDDF30", VA = "0x183EDF530", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x3EE0000", Offset = "0x3EDEA00", VA = "0x183EE0000", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000094")]
	[Cpp2IlInjected.Address(RVA = "0x3EDF450", Offset = "0x3EDDE50", VA = "0x183EDF450", Slot = "9")]
	public void Add(TKey COMNIKKFEEB, TVal IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000095")]
	[Cpp2IlInjected.Address(RVA = "0x3EDF400", Offset = "0x3EDDE00", VA = "0x183EDF400", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> LHFGBAJKEKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3EDF5D0", Offset = "0x3EDDFD0", VA = "0x183EDF5D0", Slot = "8")]
	public bool ContainsKey(TKey COMNIKKFEEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x3EDF660", Offset = "0x3EDE060", VA = "0x183EDF660", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> LHFGBAJKEKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3EDFF30", Offset = "0x3EDE930", VA = "0x183EDFF30", Slot = "10")]
	public bool Remove(TKey COMNIKKFEEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3EDFEF0", Offset = "0x3EDE8F0", VA = "0x183EDFEF0", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> LHFGBAJKEKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3EE0050", Offset = "0x3EDEA50", VA = "0x183EE0050", Slot = "11")]
	public bool TryGetValue(TKey COMNIKKFEEB, [Out] TVal IPHMAHBENGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3EDF7E0", Offset = "0x3EDE1E0", VA = "0x183EDF7E0", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x3EDF6A0", Offset = "0x3EDE0A0", VA = "0x183EDF6A0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] FEMJEOMOEIN, int CFALBIKCKCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3EDF780", Offset = "0x3EDE180", VA = "0x183EDF780")]
	public bool FJHIBPMOMDE(TVal COMNIKKFEEB, [Out] TKey IPHMAHBENGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3EDFAB0", Offset = "0x3EDE4B0", VA = "0x183EDFAB0")]
	private void LAPGKIGBBFC(TKey COMNIKKFEEB, TVal POCLHBJGKBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3EDFD40", Offset = "0x3EDE740", VA = "0x183EDFD40")]
	private void MLBKPGDGPEG(TKey COMNIKKFEEB, TVal POCLHBJGKBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3EDF990", Offset = "0x3EDE390", VA = "0x183EDF990")]
	private bool HLBJLKCMCID(TKey COMNIKKFEEB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3EE00B0", Offset = "0x3EDEAB0", VA = "0x183EE00B0")]
	public GLNMNAKLAEF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000023")]
[DefaultMember("Item")]
public class ECAFPIHPAGI<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400003B")]
		private ECAFPIHPAGI<T> buffer;

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
			[Cpp2IlInjected.Address(RVA = "0x3A9D7F0", Offset = "0x3A9C1F0", VA = "0x183A9D7F0", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000B6")]
			[Cpp2IlInjected.Address(RVA = "0x3AADDD0", Offset = "0x3AAC7D0", VA = "0x183AADDD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B3")]
		[Cpp2IlInjected.Address(RVA = "0x3AAEAA0", Offset = "0x3AAD4A0", VA = "0x183AAEAA0")]
		public Enumerator(ECAFPIHPAGI<T> FJOBMDHPMBB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x3AAB420", Offset = "0x3AA9E20", VA = "0x183AAB420", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x3AAC5E0", Offset = "0x3AAAFE0", VA = "0x183AAC5E0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x3AAC090", Offset = "0x3AAAA90", VA = "0x183AAC090")]
		private void NEKKJGJGAKH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private T[] LFCFJOHJOPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private int BHLKMIGNPBH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private int DFHDKEMDHCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private int MOOGIOAAOOM;

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public int LEDCMOMLPMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x3A007A0", Offset = "0x39FF1A0", VA = "0x183A007A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public T BAKKPFJHLEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x3A013E0", Offset = "0x39FFDE0", VA = "0x183A013E0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x3A00F50", Offset = "0x39FF950", VA = "0x183A00F50")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x3A02900", Offset = "0x3A01300", VA = "0x183A02900")]
	public ECAFPIHPAGI(int PAODLCPDLEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x3A009A0", Offset = "0x39FF3A0", VA = "0x183A009A0")]
	public void KDCHLCHLBCK(T NNEFLDDEJJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x3A01DD0", Offset = "0x3A007D0", VA = "0x183A01DD0")]
	public void ODPBLJHKGDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x3A007E0", Offset = "0x39FF1E0", VA = "0x183A007E0")]
	public void HFDNEBEEDKA(int CMNDBGDABDM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x3A01810", Offset = "0x3A00210", VA = "0x183A01810")]
	public void NJPICHJAHLD(T[] FEMJEOMOEIN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x3A01E80", Offset = "0x3A00880", VA = "0x183A01E80")]
	public Enumerator PBHEMGCNMMA()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x3A02620", Offset = "0x3A01020", VA = "0x183A02620", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x3A02620", Offset = "0x3A01020", VA = "0x183A02620", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x3A02030", Offset = "0x3A00A30", VA = "0x183A02030")]
	private int PFIELBGMJIJ(int ENMILGHAHOM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3A00770", Offset = "0x39FF170", VA = "0x183A00770")]
	private int BPNMCEBLFOB(int ENMILGHAHOM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000025")]
public class MLLDFGMFKPE<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	public delegate Task<TResult> HBFHCFFIFBE(TRequest MGBHCKLJEHL, CancellationToken LOIOCMLGMKH);

	[Cpp2IlInjected.Token(Token = "0x2000027")]
	public enum JLAEGLIBKBG
	{
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public class DENCNHBDPNC
	{
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		private const float NPDKMEJKNNG = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		private TimeSpan AOKODKKECEI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public int BMPAHHIBIKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public JLAEGLIBKBG PEDCLIPBJLF;

		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public static readonly DENCNHBDPNC ANDDCLMCCKL;

		[Cpp2IlInjected.Token(Token = "0x17000024")]
		public float PICOJKLGLDG
		{
			[Cpp2IlInjected.Token(Token = "0x60000C3")]
			[Cpp2IlInjected.Address(RVA = "0x5A7C620", Offset = "0x5A7B020", VA = "0x185A7C620")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public TimeSpan KOAGJIPACEC
		{
			[Cpp2IlInjected.Token(Token = "0x60000C4")]
			[Cpp2IlInjected.Address(RVA = "0x885670", Offset = "0x884070", VA = "0x180885670")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x5A7C700", Offset = "0x5A7B100", VA = "0x185A7C700")]
		public DENCNHBDPNC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000029")]
	private readonly struct HHHNKHMAPNL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public readonly TRequest MGBHCKLJEHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public readonly CancellationToken LOIOCMLGMKH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public readonly TaskCompletionSource<TResult> GGJEANCABJK;

		[Cpp2IlInjected.Token(Token = "0x60000C7")]
		[Cpp2IlInjected.Address(RVA = "0x3F8D090", Offset = "0x3F8BA90", VA = "0x183F8D090")]
		public HHHNKHMAPNL(TRequest MGBHCKLJEHL, TaskCompletionSource<TResult> GGJEANCABJK, CancellationToken LOIOCMLGMKH)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002A")]
	[CompilerGenerated]
	private struct GHIEHNDMDEI : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public MLLDFGMFKPE<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C8")]
		[Cpp2IlInjected.Address(RVA = "0x3ED2B50", Offset = "0x3ED1550", VA = "0x183ED2B50", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C9")]
		[Cpp2IlInjected.Address(RVA = "0x3ED37B0", Offset = "0x3ED21B0", VA = "0x183ED37B0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200002B")]
	[CompilerGenerated]
	private struct PJGEFEODPGM : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000056")]
		public MLLDFGMFKPE<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000057")]
		private HHHNKHMAPNL <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000058")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000CA")]
		[Cpp2IlInjected.Address(RVA = "0x49B4E80", Offset = "0x49B3880", VA = "0x1849B4E80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CB")]
		[Cpp2IlInjected.Address(RVA = "0x49B5A50", Offset = "0x49B4450", VA = "0x1849B5A50", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly CancellationTokenSource GCPDPGPAJJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private readonly List<HHHNKHMAPNL> FJAHLFBAAPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private readonly DENCNHBDPNC LEDGCCILKON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000042")]
	private readonly HBFHCFFIFBE ANDCBBLFDAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000043")]
	private Task NBDHNFIOADM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000044")]
	private int NLGCNODAPCC;

	[Cpp2IlInjected.Token(Token = "0x60000B9")]
	[Cpp2IlInjected.Address(RVA = "0x472F850", Offset = "0x472E250", VA = "0x18472F850")]
	public MLLDFGMFKPE(HBFHCFFIFBE ANDCBBLFDAI, [Optional] DENCNHBDPNC LEDGCCILKON)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BA")]
	[Cpp2IlInjected.Address(RVA = "0x472EB20", Offset = "0x472D520", VA = "0x18472EB20")]
	public Task<TResult> DEHJDIIMABL(TRequest MGBHCKLJEHL, CancellationToken LOIOCMLGMKH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BB")]
	[Cpp2IlInjected.Address(RVA = "0x472F780", Offset = "0x472E180", VA = "0x18472F780")]
	private void NKBGADKOEBP(HHHNKHMAPNL NDILADHFOHJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000BC")]
	[Cpp2IlInjected.Address(RVA = "0x472F500", Offset = "0x472DF00", VA = "0x18472F500")]
	[AsyncStateMachine(typeof(MLLDFGMFKPE<, >.GHIEHNDMDEI))]
	private Task NGPFFDBKEOG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BD")]
	[Cpp2IlInjected.Address(RVA = "0x472E0D0", Offset = "0x472CAD0", VA = "0x18472E0D0")]
	private HHHNKHMAPNL AFGCOMHIFBA()
	{
		return default(HHHNKHMAPNL);
	}

	[Cpp2IlInjected.Token(Token = "0x60000BE")]
	[Cpp2IlInjected.Address(RVA = "0x472EF70", Offset = "0x472D970", VA = "0x18472EF70")]
	[AsyncStateMachine(typeof(MLLDFGMFKPE<, >.PJGEFEODPGM))]
	private Task IHBOGNLLMEF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000BF")]
	[Cpp2IlInjected.Address(RVA = "0x472F060", Offset = "0x472DA60", VA = "0x18472F060")]
	private void INKADJNDMKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x472ED40", Offset = "0x472D740", VA = "0x18472ED40", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
[DefaultMember("Item")]
public class PDJNJCFOEJH<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly List<T> GLCCIANLCJC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private HashSet<T> EBNJEEFHLME;

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public int LEDCMOMLPMG
	{
		[Cpp2IlInjected.Token(Token = "0x60000CC")]
		[Cpp2IlInjected.Address(RVA = "0x3764D90", Offset = "0x3763790", VA = "0x183764D90", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000027")]
	public bool MEAEOHJNNNH
	{
		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x8CCAB0", Offset = "0x8CB4B0", VA = "0x1808CCAB0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public T BAKKPFJHLEM
	{
		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x2BF8050", Offset = "0x2BF6A50", VA = "0x182BF8050", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x49A2DE0", Offset = "0x49A17E0", VA = "0x1849A2DE0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3E22BF0", Offset = "0x3E215F0", VA = "0x183E22BF0", Slot = "11")]
	public void Add(T LHFGBAJKEKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x49A2410", Offset = "0x49A0E10", VA = "0x1849A2410")]
	public bool HFCAFMPEHCO(T LHFGBAJKEKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x49A2B40", Offset = "0x49A1540", VA = "0x1849A2B40", Slot = "15")]
	public bool Remove(T LHFGBAJKEKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D3")]
	[Cpp2IlInjected.Address(RVA = "0x46957F0", Offset = "0x46941F0", VA = "0x1846957F0", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D4")]
	[Cpp2IlInjected.Address(RVA = "0x3E3C200", Offset = "0x3E3AC00", VA = "0x183E3C200", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D5")]
	[Cpp2IlInjected.Address(RVA = "0x49A22C0", Offset = "0x49A0CC0", VA = "0x1849A22C0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D6")]
	[Cpp2IlInjected.Address(RVA = "0x49A2360", Offset = "0x49A0D60", VA = "0x1849A2360", Slot = "13")]
	public bool Contains(T LHFGBAJKEKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x49A23B0", Offset = "0x49A0DB0", VA = "0x1849A23B0", Slot = "14")]
	public void CopyTo(T[] FEMJEOMOEIN, int CFALBIKCKCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x44470A0", Offset = "0x4445AA0", VA = "0x1844470A0", Slot = "6")]
	public int IndexOf(T LHFGBAJKEKO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(RVA = "0x49A2610", Offset = "0x49A1010", VA = "0x1849A2610", Slot = "7")]
	public void Insert(int ENMILGHAHOM, T LHFGBAJKEKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(RVA = "0x49A28A0", Offset = "0x49A12A0", VA = "0x1849A28A0", Slot = "8")]
	public void RemoveAt(int ENMILGHAHOM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(RVA = "0x49A2CC0", Offset = "0x49A16C0", VA = "0x1849A2CC0")]
	public PDJNJCFOEJH()
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
			[Cpp2IlInjected.Address(RVA = "0x232A2C0", Offset = "0x2328CC0", VA = "0x18232A2C0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x6B6E140", Offset = "0x6B6CB40", VA = "0x186B6E140")]
		public SerializedGuid([In] Guid OKMPNEEAGBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DE")]
		[Cpp2IlInjected.Address(RVA = "0x6B6E010", Offset = "0x6B6CA10", VA = "0x186B6E010")]
		public static SerializedGuid NJBGFCCIDPD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x6B6DF90", Offset = "0x6B6C990", VA = "0x186B6DF90")]
		public static SerializedGuid GPLMDCBKKLC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x6B6DE60", Offset = "0x6B6C860", VA = "0x186B6DE60")]
		public bool EMCJBNDMBFI()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x6B6E110", Offset = "0x6B6CB10", VA = "0x186B6E110", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x6B6E090", Offset = "0x6B6CA90", VA = "0x186B6E090", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x6B6DEC0", Offset = "0x6B6C8C0", VA = "0x186B6DEC0", Slot = "7")]
		public bool Equals(SerializedGuid CGCLEIBHLHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x6B6DF00", Offset = "0x6B6C900", VA = "0x186B6DF00", Slot = "0")]
		public override bool Equals(object FHFDEAHMMBI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x6B6E000", Offset = "0x6B6CA00", VA = "0x186B6E000", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0x6B6DE30", Offset = "0x6B6C830", VA = "0x186B6DE30", Slot = "6")]
		public int CompareTo(SerializedGuid CGCLEIBHLHF)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002E")]
public class NEFPDLBPHLN : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly Type MCKFAGNECPP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	public readonly string DNONABHJDJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	public readonly bool GIBNBALHEAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	public readonly bool NBLAGHPMNEP;

	[Cpp2IlInjected.Token(Token = "0x60000E7")]
	[Cpp2IlInjected.Address(RVA = "0x6B6C3D0", Offset = "0x6B6ADD0", VA = "0x186B6C3D0")]
	public NEFPDLBPHLN(Type PHLIDLHBEMP, string DNKDGCGELKO, bool FPDLAANKKKI = false, bool MNLDKOHKIAE = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002F")]
public class GOLFJDFFGLD<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000030")]
	public readonly struct LCHNLPKCACH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly long ENKCLFPPKKI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public readonly long PDHEODKJCLK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		public readonly int FPMOKMOFNKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public readonly int KALLIEEHPMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		public readonly bool HONLMBNBGKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		private readonly string IOIOACBCDFH;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x4478A40", Offset = "0x4477440", VA = "0x184478A40")]
		public LCHNLPKCACH(long ENKCLFPPKKI, int FPMOKMOFNKM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x4478AB0", Offset = "0x44774B0", VA = "0x184478AB0")]
		public LCHNLPKCACH(long ENKCLFPPKKI, long PDHEODKJCLK, int FPMOKMOFNKM, int KALLIEEHPMG, bool HONLMBNBGKA, string IOIOACBCDFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x44788F0", Offset = "0x44772F0", VA = "0x1844788F0")]
		public int HKHCACLODNG()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x44788D0", Offset = "0x44772D0", VA = "0x1844788D0")]
		public int BAIFOGOINBH(int CNEFFOIBKDO)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x44789E0", Offset = "0x44773E0", VA = "0x1844789E0")]
		public double MAJGGJMNNAA()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x4478940", Offset = "0x4477340", VA = "0x184478940")]
		public LCHNLPKCACH LIEGMBFNHGJ(long PDHEODKJCLK, int KALLIEEHPMG)
		{
			return default(LCHNLPKCACH);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public class EFMHMOBJFGI : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000032")]
		[CompilerGenerated]
		private struct FPFKDDMOIKM<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			public EFMHMOBJFGI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007A")]
			public Func<EFMHMOBJFGI, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007B")]
			private EFMHMOBJFGI <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007C")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x3E09440", Offset = "0x3E07E40", VA = "0x183E09440", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x3E09970", Offset = "0x3E08370", VA = "0x183E09970", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		public readonly TKey NJIIHIBALEA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private readonly GOLFJDFFGLD<TKey> MBHLFFACPEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000073")]
		public readonly CAFGMNLACIN FEMNEHJOJBN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		private List<EFMHMOBJFGI> AJIOPLLDCMH;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public string APIGODDEMGO
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x3A0F8B0", Offset = "0x3A0E2B0", VA = "0x183A0F8B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		public IEnumerable<EFMHMOBJFGI> EGPJBHPFBGO
		{
			[Cpp2IlInjected.Token(Token = "0x60000F7")]
			[Cpp2IlInjected.Address(RVA = "0x3A0FAB0", Offset = "0x3A0E4B0", VA = "0x183A0FAB0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		public LCHNLPKCACH PCIGFOJNGOD
		{
			[Cpp2IlInjected.Token(Token = "0x60000F8")]
			[Cpp2IlInjected.Address(RVA = "0x3A0FB20", Offset = "0x3A0E520", VA = "0x183A0FB20")]
			[CompilerGenerated]
			get
			{
				return default(LCHNLPKCACH);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F9")]
			[Cpp2IlInjected.Address(RVA = "0x3A0FAF0", Offset = "0x3A0E4F0", VA = "0x183A0FAF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x3A0FB40", Offset = "0x3A0E540", VA = "0x183A0FB40")]
		internal EFMHMOBJFGI(GOLFJDFFGLD<TKey> MBHLFFACPEB, TKey COMNIKKFEEB, CAFGMNLACIN FEMNEHJOJBN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x3A0F900", Offset = "0x3A0E300", VA = "0x183A0F900")]
		public EFMHMOBJFGI GINBNJACOHJ(TKey COMNIKKFEEB, [Optional] CAFGMNLACIN? GMFFKCJBCPG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x2C02240", Offset = "0x2C00C40", VA = "0x182C02240")]
		[AsyncStateMachine(typeof(FPFKDDMOIKM<>))]
		public Task<T> HBJMLCKOHGG<T>(TKey COMNIKKFEEB, Func<EFMHMOBJFGI, Task<T>> EDFBCBDPOLM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FD")]
		[Cpp2IlInjected.Address(RVA = "0x3A0F660", Offset = "0x3A0E060", VA = "0x183A0F660", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class AJGEOKOPLMB : IEnumerable<(TKey, List<TKey>, LCHNLPKCACH)>, IEnumerable, IEnumerator<(TKey, List<TKey>, LCHNLPKCACH)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private (TKey key, List<TKey> path, LCHNLPKCACH timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public GOLFJDFFGLD<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		private IEnumerator<(TKey key, List<TKey> path, LCHNLPKCACH timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private (TKey, List<TKey>, LCHNLPKCACH) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x232D730", Offset = "0x232C130", VA = "0x18232D730", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, LCHNLPKCACH));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000106")]
			[Cpp2IlInjected.Address(RVA = "0x3E99DE0", Offset = "0x3E987E0", VA = "0x183E99DE0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x232D820", Offset = "0x232C220", VA = "0x18232D820")]
		[DebuggerHidden]
		public AJGEOKOPLMB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x3C0EED0", Offset = "0x3C0D8D0", VA = "0x183C0EED0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3E99920", Offset = "0x3E98320", VA = "0x183E99920", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x3E998D0", Offset = "0x3E982D0", VA = "0x183E998D0")]
		private void JDIKFIOLCDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x3E99D90", Offset = "0x3E98790", VA = "0x183E99D90", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x3E99CC0", Offset = "0x3E986C0", VA = "0x183E99CC0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, LCHNLPKCACH)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x3C16320", Offset = "0x3C14D20", VA = "0x183C16320", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private sealed class IMAABGKIJIE : IEnumerable<(TKey, List<TKey>, LCHNLPKCACH)>, IEnumerable, IEnumerator<(TKey, List<TKey>, LCHNLPKCACH)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		private (TKey key, List<TKey> path, LCHNLPKCACH timerEntry) <>2__current;

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
		private EFMHMOBJFGI timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		public EFMHMOBJFGI <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public GOLFJDFFGLD<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private IEnumerator<EFMHMOBJFGI> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private IEnumerator<(TKey key, List<TKey> path, LCHNLPKCACH timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		private (TKey, List<TKey>, LCHNLPKCACH) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010E")]
			[Cpp2IlInjected.Address(RVA = "0x232D730", Offset = "0x232C130", VA = "0x18232D730", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, LCHNLPKCACH));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000032")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x40A9720", Offset = "0x40A8120", VA = "0x1840A9720", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x232D820", Offset = "0x232C220", VA = "0x18232D820")]
		[DebuggerHidden]
		public IMAABGKIJIE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010A")]
		[Cpp2IlInjected.Address(RVA = "0x40A9780", Offset = "0x40A8180", VA = "0x1840A9780", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x40A8DD0", Offset = "0x40A77D0", VA = "0x1840A8DD0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x40A8D70", Offset = "0x40A7770", VA = "0x1840A8D70")]
		private void JDIKFIOLCDK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x40A8D10", Offset = "0x40A7710", VA = "0x1840A8D10")]
		private void EEFNKGAPPJM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x40A96D0", Offset = "0x40A80D0", VA = "0x1840A96D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x40A9590", Offset = "0x40A7F90", VA = "0x1840A9590", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, LCHNLPKCACH)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x40A9690", Offset = "0x40A8090", VA = "0x1840A9690", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly Action<TKey, LCHNLPKCACH, CAFGMNLACIN> IIGMJCLNBJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly Action<TKey, LCHNLPKCACH, CAFGMNLACIN> MNMBPMKOGCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly Action<GOLFJDFFGLD<TKey>, CAFGMNLACIN> MJFJGNMOOAK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private readonly CAFGMNLACIN FEMNEHJOJBN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly EFMHMOBJFGI LCPKJAKFCIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	private bool PJFKAIJIJGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private int MGDMFABCDEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000068")]
	private readonly Stopwatch PAJEADPNBGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000069")]
	public readonly int KAMABBGGONB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private string CJFFLFEBLFP;

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public EFMHMOBJFGI LKCKMGHOCLJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x885660", Offset = "0x884060", VA = "0x180885660")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	[NotNull]
	public string APIGODDEMGO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x88B2B0", Offset = "0x889CB0", VA = "0x18088B2B0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x3EE3D60", Offset = "0x3EE2760", VA = "0x183EE3D60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x3EE3FC0", Offset = "0x3EE29C0", VA = "0x183EE3FC0")]
	public GOLFJDFFGLD(TKey NNEPEBOBNMK, CAFGMNLACIN FEMNEHJOJBN, [Optional] int? FPMOKMOFNKM, [Optional][CanBeNull] Stopwatch PAJEADPNBGD, [Optional] Action<TKey, LCHNLPKCACH, CAFGMNLACIN> IIGMJCLNBJA, [Optional] Action<TKey, LCHNLPKCACH, CAFGMNLACIN> MNMBPMKOGCH, [Optional] Action<GOLFJDFFGLD<TKey>, CAFGMNLACIN> MJFJGNMOOAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x3EE3C90", Offset = "0x3EE2690", VA = "0x183EE3C90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x3EE3DC0", Offset = "0x3EE27C0", VA = "0x183EE3DC0")]
	[IteratorStateMachine(typeof(GOLFJDFFGLD<>.AJGEOKOPLMB))]
	public IEnumerable<(TKey, List<TKey>, LCHNLPKCACH)> GHHLFJLGCCH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x3EE3E60", Offset = "0x3EE2860", VA = "0x183EE3E60")]
	[IteratorStateMachine(typeof(GOLFJDFFGLD<>.IMAABGKIJIE))]
	private IEnumerable<(TKey, List<TKey>, LCHNLPKCACH)> GHHLFJLGCCH(List<TKey> KCEMGCAKHDC, EFMHMOBJFGI ANBADFODAKB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x3EE3F40", Offset = "0x3EE2940", VA = "0x183EE3F40")]
	private (long, int) IIDDHHGMJJG()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public abstract class EINGPBIIBFH<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut ILDLOHKKAEO(GOLFJDFFGLD<TKey> MBHLFFACPEB);

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	protected EINGPBIIBFH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public abstract class LGJNAIMNNCN<TKey> : EINGPBIIBFH<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x2000037")]
	public delegate string PNGFOOFKEMP(TKey COMNIKKFEEB);

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x448C260", Offset = "0x448AC60", VA = "0x18448C260")]
	private static string MLIBMNICHPI(TKey COMNIKKFEEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x448C180", Offset = "0x448AB80", VA = "0x18448C180", Slot = "4")]
	public override string ILDLOHKKAEO(GOLFJDFFGLD<TKey> MBHLFFACPEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x448C030", Offset = "0x448AA30", VA = "0x18448C030")]
	public string ILDLOHKKAEO(GOLFJDFFGLD<TKey> MBHLFFACPEB, [NotNull] PNGFOOFKEMP GIMBPKKAPIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string PDOPNOOIKAE(GOLFJDFFGLD<TKey> MBHLFFACPEB, [NotNull] PNGFOOFKEMP GIMBPKKAPIK);

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x40DA8A0", Offset = "0x40D92A0", VA = "0x1840DA8A0")]
	protected LGJNAIMNNCN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000038")]
public class KEJELHIAHCE<TKey> : EINGPBIIBFH<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000039")]
	public delegate string PGHDANNOHCB(TKey COMNIKKFEEB);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly string DCIDIPMBHKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly double AGGAHIAHADI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008E")]
	private readonly bool FKOPNBEMDAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly int MKJDJCPBPIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000090")]
	private readonly ISet<string> LPBNGDIPMCD;

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x43D1670", Offset = "0x43D0070", VA = "0x1843D1670")]
	private static string MLIBMNICHPI(TKey COMNIKKFEEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x43D16B0", Offset = "0x43D00B0", VA = "0x1843D16B0")]
	public KEJELHIAHCE(string DCIDIPMBHKA = "F2", double AGGAHIAHADI = double.MaxValue, bool FKOPNBEMDAP = false, int MKJDJCPBPIM = int.MaxValue, [Optional] ISet<string> LPBNGDIPMCD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(RVA = "0x43D0F50", Offset = "0x43CF950", VA = "0x1843D0F50", Slot = "4")]
	public override Dictionary<string, string> ILDLOHKKAEO(GOLFJDFFGLD<TKey> MBHLFFACPEB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x43D0E70", Offset = "0x43CF870", VA = "0x1843D0E70")]
	private bool EDJNDHNJDIL(string IEIBAEODNAE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x43D1030", Offset = "0x43CFA30", VA = "0x1843D1030")]
	public Dictionary<string, string> ILDLOHKKAEO(GOLFJDFFGLD<TKey> MBHLFFACPEB, PGHDANNOHCB GIMBPKKAPIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x43D0C00", Offset = "0x43CF600", VA = "0x1843D0C00")]
	private string CJCFHGOLEFB(StringBuilder ABKCFLHONEJ, List<TKey> IOCBEBPFLJB, PGHDANNOHCB GIMBPKKAPIK, bool LFFCIBLAPDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x43D0AA0", Offset = "0x43CF4A0", VA = "0x1843D0AA0")]
	private static void BLNDNIGHIBC(StringBuilder EOJFFDGGMBP, string PGCDMLKKKNK, bool OKKNPIFOOCN)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public class KJHJGKLAKDC<TKey> : LGJNAIMNNCN<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003B")]
	[CompilerGenerated]
	private struct BLMEIGJOHPF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		public PNGFOOFKEMP keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x4000091")]
	public static KJHJGKLAKDC<TKey> GHBFIIGNNDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private readonly string[] NHEOCNEHKIC;

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x43DB270", Offset = "0x43D9C70", VA = "0x1843DB270")]
	private KJHJGKLAKDC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x43DA230", Offset = "0x43D8C30", VA = "0x1843DA230", Slot = "5")]
	protected override string PDOPNOOIKAE(GOLFJDFFGLD<TKey> MBHLFFACPEB, PNGFOOFKEMP GIMBPKKAPIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x43DA130", Offset = "0x43D8B30", VA = "0x1843DA130")]
	[CompilerGenerated]
	internal static string KFLOGMJKAMP(string CNPOLILLBPB, TKey COMNIKKFEEB, BLMEIGJOHPF P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003C")]
public sealed class NBCNNNALMEH : GOLFJDFFGLD<string>
{
	[Cpp2IlInjected.Token(Token = "0x200003D")]
	[CompilerGenerated]
	private sealed class PIBMKCAELKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		public Action<NBCNNNALMEH, CAFGMNLACIN> callback;

		[Cpp2IlInjected.Token(Token = "0x600012B")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public PIBMKCAELKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(RVA = "0x6B6C9D0", Offset = "0x6B6B3D0", VA = "0x186B6C9D0")]
		internal void EAALMBLDIIG(GOLFJDFFGLD<string> timer, CAFGMNLACIN log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(RVA = "0x6B6BDD0", Offset = "0x6B6A7D0", VA = "0x186B6BDD0")]
	public NBCNNNALMEH(CAFGMNLACIN FEMNEHJOJBN, [Optional] string LODNIHJAOOD, [Optional] int? FPMOKMOFNKM, [Optional] Stopwatch PAJEADPNBGD, [Optional] Action<string, LCHNLPKCACH, CAFGMNLACIN> IIGMJCLNBJA, [Optional] Action<string, LCHNLPKCACH, CAFGMNLACIN> MNMBPMKOGCH, [Optional] Action<NBCNNNALMEH, CAFGMNLACIN> MJFJGNMOOAK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x6B6BD10", Offset = "0x6B6A710", VA = "0x186B6BD10")]
	private static Action<GOLFJDFFGLD<string>, CAFGMNLACIN> JEKCDCCKBKF(Action<NBCNNNALMEH, CAFGMNLACIN> AGMLFHLAIFJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public abstract class NGEDLNBCILD
{
	[Cpp2IlInjected.Token(Token = "0x200003F")]
	private class IHNBNPEMEGI : NGEDLNBCILD
	{
		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public static NGEDLNBCILD GHBFIIGNNDE
		{
			[Cpp2IlInjected.Token(Token = "0x6000131")]
			[Cpp2IlInjected.Address(RVA = "0x6B6BA60", Offset = "0x6B6A460", VA = "0x186B6BA60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public override float BLEHAIFOLMC
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0xBD4660", Offset = "0xBD3060", VA = "0x180BD4660", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x6B6BB50", Offset = "0x6B6A550", VA = "0x186B6BB50")]
		public IHNBNPEMEGI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private static NGEDLNBCILD EBIKDBMDFCA;

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	public static NGEDLNBCILD ANDDCLMCCKL
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(RVA = "0x6B6C440", Offset = "0x6B6AE40", VA = "0x186B6C440")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000034")]
	public abstract float BLEHAIFOLMC
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
	protected NGEDLNBCILD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public interface NLFKKAGDIKB : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000037")]
	bool LOJKAIEMICI
	{
		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface NNLLBGLJADF<T> : NLFKKAGDIKB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000038")]
	[NotNull]
	Task<T> HCAPDGOHAPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000136")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000039")]
	[NotNull]
	HABLMKCEIGL<T> NKAJGKIADPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public static class GNLBCHMGDDA
{
	[Cpp2IlInjected.Token(Token = "0x6000138")]
	[Cpp2IlInjected.Address(RVA = "0x2D71C70", Offset = "0x2D70670", VA = "0x182D71C70")]
	public static NNLLBGLJADF<TResource> GDEFGOCONEG<TResource, TId>(this FCBLFPACJGL<TId, TResource> CJEEOBCMPEP, TId DNICIAANFHD, [Optional] Func<TId, CancellationToken, Task<TResource>>? OKEKDBIOKPE) where TResource : notnull where TId : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class FMKEFPCOJEI
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private sealed class AGMDLPPKOIA<T> : DMDKAPLFOGD<T?> where T : class
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override Task<T?> HCAPDGOHAPC
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override HABLMKCEIGL<T?> NKAJGKIADPF
		{
			[Cpp2IlInjected.Token(Token = "0x600013F")]
			[Cpp2IlInjected.Address(RVA = "0x885610", Offset = "0x884010", VA = "0x180885610", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x3E96EC0", Offset = "0x3E958C0", VA = "0x183E96EC0")]
		public AGMDLPPKOIA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000141")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "10")]
		protected override void CMDBJDEBKDO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private sealed class BDNPDCPDOEA<T> : DMDKAPLFOGD<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		private readonly T CIMGEIMBIBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		private readonly Action<T>? AANCALDPLDG;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override Task<T> HCAPDGOHAPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x8892A0", Offset = "0x887CA0", VA = "0x1808892A0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override HABLMKCEIGL<T> NKAJGKIADPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x889090", Offset = "0x887A90", VA = "0x180889090", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x50AA010", Offset = "0x50A8A10", VA = "0x1850AA010")]
		public BDNPDCPDOEA(T FHNCCICEJBE, Action<T>? PPNPMEBLOML)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x50A9E20", Offset = "0x50A8820", VA = "0x1850A9E20", Slot = "10")]
		protected override void CMDBJDEBKDO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private sealed class GICLABKFOKL<T> : DMDKAPLFOGD<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override Task<T> HCAPDGOHAPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000146")]
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override HABLMKCEIGL<T> NKAJGKIADPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x885610", Offset = "0x884010", VA = "0x180885610", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(RVA = "0x3EDA530", Offset = "0x3ED8F30", VA = "0x183EDA530")]
		public GICLABKFOKL(Exception OANLHKKGJFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000149")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "10")]
		protected override void CMDBJDEBKDO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private sealed class KFHNFAMGMDG<T> : DMDKAPLFOGD<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[CompilerGenerated]
		private struct MJKACIHJFCP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public Task<NNLLBGLJADF<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			private TaskAwaiter<NNLLBGLJADF<T>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			private TaskAwaiter<T> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x46FAC20", Offset = "0x46F9620", VA = "0x1846FAC20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x46FB600", Offset = "0x46FA000", VA = "0x1846FB600", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		[CompilerGenerated]
		private struct LCJJCGOBJHL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A9")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AA")]
			public Task<NNLLBGLJADF<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AB")]
			private TaskAwaiter<NNLLBGLJADF<T>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000152")]
			[Cpp2IlInjected.Address(RVA = "0x4478AE0", Offset = "0x44774E0", VA = "0x184478AE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x4478F40", Offset = "0x4477940", VA = "0x184478F40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A0")]
		private readonly Task<NNLLBGLJADF<T>> OPGEGIMPIBG;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override Task<T> HCAPDGOHAPC
		{
			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x885610", Offset = "0x884010", VA = "0x180885610", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override HABLMKCEIGL<T> NKAJGKIADPF
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x888EA0", Offset = "0x8878A0", VA = "0x180888EA0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x43D3930", Offset = "0x43D2330", VA = "0x1843D3930")]
		public KFHNFAMGMDG(Task<NNLLBGLJADF<T>> DJIALEEMCOO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x43D3400", Offset = "0x43D1E00", VA = "0x1843D3400", Slot = "10")]
		protected override void CMDBJDEBKDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x43D3600", Offset = "0x43D2000", VA = "0x1843D3600")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(KFHNFAMGMDG<>.MJKACIHJFCP))]
		internal static Task<T> DDBMBNPDDEJ(Task<NNLLBGLJADF<T>> DJIALEEMCOO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x43D3850", Offset = "0x43D2250", VA = "0x1843D3850")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(KFHNFAMGMDG<>.LCJJCGOBJHL))]
		internal static Task DEIGEMIAADL(Task<NNLLBGLJADF<T>> DJIALEEMCOO)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private sealed class FDFINGLBNIF<TIn, TOut> : DMDKAPLFOGD<TOut> where TIn : notnull where TOut : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004B")]
		[CompilerGenerated]
		private struct JLKIECOGKAC : IAsyncStateMachine
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
			[Cpp2IlInjected.Address(RVA = "0x42FE8E0", Offset = "0x42FD2E0", VA = "0x1842FE8E0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0x3DF6E80", Offset = "0x3DF5880", VA = "0x183DF6E80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly NNLLBGLJADF<TIn> GDNEEPOPJBC;

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override Task<TOut> HCAPDGOHAPC
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x885610", Offset = "0x884010", VA = "0x180885610", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override HABLMKCEIGL<TOut> NKAJGKIADPF
		{
			[Cpp2IlInjected.Token(Token = "0x6000155")]
			[Cpp2IlInjected.Address(RVA = "0x888EA0", Offset = "0x8878A0", VA = "0x180888EA0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x3DE3090", Offset = "0x3DE1A90", VA = "0x183DE3090")]
		public FDFINGLBNIF(NNLLBGLJADF<TIn> BGFDGEKJGHJ, Func<TIn, TOut> LBLKKKPOMJE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000157")]
		[Cpp2IlInjected.Address(RVA = "0x3DE2FF0", Offset = "0x3DE19F0", VA = "0x183DE2FF0", Slot = "10")]
		protected override void CMDBJDEBKDO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000158")]
		[Cpp2IlInjected.Address(RVA = "0x3DE2E70", Offset = "0x3DE1870", VA = "0x183DE2E70")]
		[AsyncStateMachine(typeof(FDFINGLBNIF<, >.JLKIECOGKAC))]
		[CompilerGenerated]
		internal static Task<TOut> BNJKJGPDHGH(Task<TIn> HNKEBDJKBHK, Func<TIn, TOut> LBLKKKPOMJE)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x2D57330", Offset = "0x2D55D30", VA = "0x182D57330")]
	public static NNLLBGLJADF<T> CKLKOBNMKJP<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x2D573B0", Offset = "0x2D55DB0", VA = "0x182D573B0")]
	public static NNLLBGLJADF<T> OJILBFFAFEF<T>(T NLAECIHBKHE, [Optional] Action<T>? PPNPMEBLOML) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x2BD0970", Offset = "0x2BCF370", VA = "0x182BD0970")]
	public static NNLLBGLJADF<T> MBJLDILAMHO<T>(Exception OANLHKKGJFA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013C")]
	[Cpp2IlInjected.Address(RVA = "0x2BD0970", Offset = "0x2BCF370", VA = "0x182BD0970")]
	public static NNLLBGLJADF<T> LONIFBIDLPN<T>(Task<NNLLBGLJADF<T>> DJIALEEMCOO) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600013D")]
	[Cpp2IlInjected.Address(RVA = "0x2ACCAF0", Offset = "0x2ACB4F0", VA = "0x182ACCAF0")]
	public static NNLLBGLJADF<TOut> LFKJKOHKNFF<TOut, TIn>(NNLLBGLJADF<TIn> DKMIJDPJCBM, Func<TIn, TOut> LBLKKKPOMJE) where TOut : notnull where TIn : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public abstract class DMDKAPLFOGD<T> : NNLLBGLJADF<T>, NLFKKAGDIKB, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private static readonly string IMOFKKBKBKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private readonly DBDJPHJPOCF NCPGBIJHDEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private bool PJFKAIJIJGP;

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public bool LOJKAIEMICI
	{
		[Cpp2IlInjected.Token(Token = "0x600015B")]
		[Cpp2IlInjected.Address(RVA = "0xDBE7C0", Offset = "0xDBD1C0", VA = "0x180DBE7C0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public abstract Task<T> HCAPDGOHAPC
	{
		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public abstract HABLMKCEIGL<T> NKAJGKIADPF
	{
		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x5AA48A0", Offset = "0x5AA32A0", VA = "0x185AA48A0")]
	public DMDKAPLFOGD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(RVA = "0x5AA4420", Offset = "0x5AA2E20", VA = "0x185AA4420", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000160")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void CMDBJDEBKDO();
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public abstract class GJODJEIKLLK<TTask, T> : DMDKAPLFOGD<T> where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x200004E")]
	[CompilerGenerated]
	private sealed class BCJGMGNDBMB
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
			public BCJGMGNDBMB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x3752B30", Offset = "0x3751530", VA = "0x183752B30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x3753080", Offset = "0x3751A80", VA = "0x183753080", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BB")]
		public GJODJEIKLLK<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BC")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public BCJGMGNDBMB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x5099170", Offset = "0x5097B70", VA = "0x185099170")]
		[AsyncStateMachine(typeof(GJODJEIKLLK<, >.BCJGMGNDBMB.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> OBOEFCAEDHC(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private readonly Task<T> DJIALEEMCOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	protected readonly CancellationTokenSource OJIENHCHFHH;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public override Task<T> HCAPDGOHAPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public override HABLMKCEIGL<T> NKAJGKIADPF
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x885610", Offset = "0x884010", VA = "0x180885610", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x3EDD990", Offset = "0x3EDC390", VA = "0x183EDD990")]
	protected GJODJEIKLLK(TTask DJIALEEMCOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x3EDD740", Offset = "0x3EDC140", VA = "0x183EDD740", Slot = "10")]
	protected override void CMDBJDEBKDO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract T AMKKOAOBGEI(TTask BNHGAHJPDNO);

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(Slot = "12")]
	protected abstract void EHACANLJJKL();
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public class GPGAPBNCBEH<T> : DMDKAPLFOGD<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private readonly JOELGMAPIIB<Task<T>> HCMMFJBAHFJ;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public override Task<T> HCAPDGOHAPC
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0x3E07B50", Offset = "0x3E06550", VA = "0x183E07B50", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public override HABLMKCEIGL<T> NKAJGKIADPF
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(RVA = "0x885610", Offset = "0x884010", VA = "0x180885610", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x3EE5CA0", Offset = "0x3EE46A0", VA = "0x183EE5CA0")]
	public GPGAPBNCBEH(JOELGMAPIIB<Task<T>> DNNDFEACIOD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x3EE5C80", Offset = "0x3EE4680", VA = "0x183EE5C80", Slot = "10")]
	protected override void CMDBJDEBKDO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public static class FODEFHBHDCN
{
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	public static readonly HashAlgorithmName EAHJCHHIEHC;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly ThreadLocal<IncrementalHash> IFHMAIABBAN;

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6B68E10", Offset = "0x6B67810", VA = "0x186B68E10")]
	public static int DBNJACDNNDF(this NEANMDAOLDD KJJNIJNMNJD, IncrementalHash IHNIDNBHBBH, byte[] PDMOFPOFBPG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x6B68E90", Offset = "0x6B67890", VA = "0x186B68E90")]
	public static bool JFLACFHHFAF([CanBeNull] this NEANMDAOLDD KJJNIJNMNJD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x6B69220", Offset = "0x6B67C20", VA = "0x186B69220")]
	public static bool JFLACFHHFAF([CanBeNull] this NEANMDAOLDD KJJNIJNMNJD, [Out] string EJIIMGEBDBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x6B68EF0", Offset = "0x6B678F0", VA = "0x186B68EF0")]
	public static bool JFLACFHHFAF([CanBeNull] this NEANMDAOLDD KJJNIJNMNJD, IncrementalHash IHNIDNBHBBH, byte[] PDMOFPOFBPG, [Out] string EJIIMGEBDBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x6B69530", Offset = "0x6B67F30", VA = "0x186B69530")]
	private static bool NCMAJKAJNNL(byte[] DEELICNCFAB, Span<byte> OBNIOLEOMLL)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class NIDBPLFIFLN
{
	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x6B6C800", Offset = "0x6B6B200", VA = "0x186B6C800")]
	public static int GLNICPIIEKF(HashAlgorithmName IPANFGNLGPA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6B6C5A0", Offset = "0x6B6AFA0", VA = "0x186B6C5A0")]
	public static int DBNJACDNNDF(this HEFBBMMKKOC DCLHOPHLEBJ, byte[] MOBBCIFHPPI, IncrementalHash IHNIDNBHBBH, byte[] KLBKNECCOAC)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public interface HEFBBMMKKOC
{
	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash IHNIDNBHBBH);
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface NEANMDAOLDD : HEFBBMMKKOC
{
	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	[CanBeNull]
	byte[] HKPOECBFLLM
	{
		[Cpp2IlInjected.Token(Token = "0x600017C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	[CanBeNull]
	byte[] LFINELAGOCE
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class HGACIJOMCIH
{
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static bool LLAHGKPOLAA;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly ArrayPool<byte> DGHKMILNLBE;

	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private static readonly ArrayPool<char> MELONMHFLIO;

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly Encoding JHFHMJDPDDB;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly ThreadLocal<Encoder> PCFBAFBJNJA;

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x2D7B350", Offset = "0x2D79D50", VA = "0x182D7B350")]
	public static void GOLCEKIKGDL<T>(this IncrementalHash OEICNEIKLMO, [CanBeNull] T ANHGADCFANN) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x2D7B930", Offset = "0x2D7A330", VA = "0x182D7B930")]
	public static void MBBDNJGOIKI<T>(this IncrementalHash OEICNEIKLMO, [CanBeNull] T DCLHOPHLEBJ) where T : HEFBBMMKKOC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x2D7B410", Offset = "0x2D79E10", VA = "0x182D7B410")]
	public static void JEPAEFPDJKM<T>(this IncrementalHash OEICNEIKLMO, [CanBeNull] IList<T> OICKKMIOFJI) where T : HEFBBMMKKOC
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x6B6B3C0", Offset = "0x6B69DC0", VA = "0x186B6B3C0")]
	private static bool MJLAAGHMLBA([CanBeNull] HEFBBMMKKOC DCLHOPHLEBJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x6B6ACC0", Offset = "0x6B696C0", VA = "0x186B6ACC0")]
	public static void ILOBLJKJPCP(this IncrementalHash IHNIDNBHBBH, string? DFONMHNAHEN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x6B6A9E0", Offset = "0x6B693E0", VA = "0x186B6A9E0")]
	public static void HJIADGNPJMF(this IncrementalHash IHNIDNBHBBH, long NLCHMMBHFCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x6B6B620", Offset = "0x6B6A020", VA = "0x186B6B620")]
	public static void OLPGNBGBHMB(this IncrementalHash IHNIDNBHBBH, int CNGEJFLBKEC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x6B6B450", Offset = "0x6B69E50", VA = "0x186B6B450")]
	public static void MKDOLGEEMLE(this IncrementalHash IHNIDNBHBBH, short GKEPNNDBFOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x6B6ABB0", Offset = "0x6B695B0", VA = "0x186B6ABB0")]
	public static void HPIFKGPADDE(this IncrementalHash IHNIDNBHBBH, byte MICIGFDCCAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x6B6B1F0", Offset = "0x6B69BF0", VA = "0x186B6B1F0")]
	public static void JKPNGHBJJKC(this IncrementalHash IHNIDNBHBBH, bool JIPKFICGLPJ, bool IPJEIFGIMLA = false, bool OPBFKPHMECB = false, bool PICANDMONLG = false, bool JEFHKHGFIKH = false, bool KKDJJELCPLD = false, bool FBPGHBEANDJ = false, bool OJMIEBMINAI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x2D7B9C0", Offset = "0x2D7A3C0", VA = "0x182D7B9C0")]
	public static void MBCMKKDELMP<T>(this IncrementalHash IHNIDNBHBBH, T OEDIDFDHHOH) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x6B6A920", Offset = "0x6B69320", VA = "0x186B6A920")]
	public static void EGPFHPLOFLE(this IncrementalHash IHNIDNBHBBH, float ALBFFPKNFAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x6B6B360", Offset = "0x6B69D60", VA = "0x186B6B360")]
	public static void KBIKJHAMGIG(this IncrementalHash IHNIDNBHBBH, ulong FONOLAKAABD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x6B6A980", Offset = "0x6B69380", VA = "0x186B6A980")]
	public static void HCHNGIJLCNK(this IncrementalHash IHNIDNBHBBH, uint OPGEMADNDKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x6B6A8C0", Offset = "0x6B692C0", VA = "0x186B6A8C0")]
	public static void DGGOJEDNKMP(this IncrementalHash IHNIDNBHBBH, ushort KPIIIDDKJFA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x6B6B0C0", Offset = "0x6B69AC0", VA = "0x186B6B0C0")]
	public static void IMBCHNEFGCC(this IncrementalHash IHNIDNBHBBH, Vector3 IEOPPDKOJGO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public class FDMHGLENGJG : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x6B68DB0", Offset = "0x6B677B0", VA = "0x186B68DB0")]
	public FDMHGLENGJG(string BBDGOIMNDJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public abstract class LMKLPLFOOOD<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	internal class BKGKNAGKGBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public TNode NKCEKILMAAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public TNode KMAENCDMJDN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public AEAKEKNBJFF LKDGGBDDBJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public List<AEAKEKNBJFF> AECCMJGDAGO;

		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public BKGKNAGKGBN()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	internal struct AEAKEKNBJFF : IComparable<AEAKEKNBJFF>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public int FLCNNPBENEH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public TClaimant EFDOPBEECHK;

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xFFE660", Offset = "0xFFD060", VA = "0x180FFE660")]
		public AEAKEKNBJFF(int FLCNNPBENEH, TClaimant EFDOPBEECHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x3E83270", Offset = "0x3E81C70", VA = "0x183E83270")]
		public bool KAJKDHKPIPJ([In] AEAKEKNBJFF CGCLEIBHLHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x3E83250", Offset = "0x3E81C50", VA = "0x183E83250")]
		public bool AKNNDJDKCDA([In] AEAKEKNBJFF CGCLEIBHLHF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x3E83260", Offset = "0x3E81C60", VA = "0x183E83260", Slot = "4")]
		public int CompareTo(AEAKEKNBJFF CGCLEIBHLHF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x3E832D0", Offset = "0x3E81CD0", VA = "0x183E832D0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public enum NHEJOOCCKAE
	{
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	[CompilerGenerated]
	private sealed class PGEELDNKMCO : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
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
		public LMKLPLFOOOD<TClaimant, TNode> <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x976660", Offset = "0x975060", VA = "0x180976660")]
		[DebuggerHidden]
		public PGEELDNKMCO(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x49A62D0", Offset = "0x49A4CD0", VA = "0x1849A62D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x49A64B0", Offset = "0x49A4EB0", VA = "0x1849A64B0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0x49A63B0", Offset = "0x49A4DB0", VA = "0x1849A63B0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0x3C10440", Offset = "0x3C0EE40", VA = "0x183C10440", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	private static readonly EJFLOJLFCKH<BKGKNAGKGBN> BPGKFAPEOHD;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly EJFLOJLFCKH<List<AEAKEKNBJFF>> IGDBHOJPDNK;

	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private static int MDNDNCGPCPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	internal readonly Dictionary<TClaimant, TNode> JOPKMPDHPIJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	internal readonly Dictionary<TNode, BKGKNAGKGBN> GCPGMJCHADE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private NHEJOOCCKAE LKBCPIIGDOH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private bool NMOEEADIFFA;

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode DLBCCIGLBHE(TNode AOOGCKADIHP);

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void JLGIEHJJBMG(TNode AOOGCKADIHP, TClaimant DELOFEHNPOA, TClaimant HCALKBIMEHC);

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x44A5C90", Offset = "0x44A4690", VA = "0x1844A5C90")]
	public LMKLPLFOOOD(NHEJOOCCKAE LKBCPIIGDOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x44A42B0", Offset = "0x44A2CB0", VA = "0x1844A42B0")]
	public void DBMPLJICFCB(TNode AOOGCKADIHP, TNode AAJANANFHLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x44A4BD0", Offset = "0x44A35D0", VA = "0x1844A4BD0")]
	public void KCJIMIHBNBF(TClaimant EFDOPBEECHK, TNode JNJNIOEFEEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x44A44C0", Offset = "0x44A2EC0", VA = "0x1844A44C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x44A4B00", Offset = "0x44A3500", VA = "0x1844A4B00")]
	private void JBDEPEPIMGD(TClaimant EFDOPBEECHK, TNode OPPKLOOGNON, TNode JNJNIOEFEEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x44A5410", Offset = "0x44A3E10", VA = "0x1844A5410")]
	private int MMLHNFDJGCB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x44A5770", Offset = "0x44A4170", VA = "0x1844A5770")]
	private void OHNBLEDJIAA(TClaimant EFDOPBEECHK, TNode MCAKFFIJFGL, TNode MODBHFMJGIB, int PPHFDHLNCOG = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x44A46C0", Offset = "0x44A30C0", VA = "0x1844A46C0")]
	private void EIHONFNCPPP(AEAKEKNBJFF IJEFIKBBKBG, BKGKNAGKGBN EDAMHICEDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x44A5480", Offset = "0x44A3E80", VA = "0x1844A5480")]
	private void ODMHNPEBKEM(TClaimant EFDOPBEECHK, TNode MCAKFFIJFGL, TNode MODBHFMJGIB, int PPHFDHLNCOG = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x44A5090", Offset = "0x44A3A90", VA = "0x1844A5090")]
	private void KJIHKHBMLBD(AEAKEKNBJFF IJEFIKBBKBG, TNode AOOGCKADIHP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x44A51C0", Offset = "0x44A3BC0", VA = "0x1844A51C0")]
	private void KMLPCDBPPBA(AEAKEKNBJFF IJEFIKBBKBG, BKGKNAGKGBN EDAMHICEDPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x44A4370", Offset = "0x44A2D70", VA = "0x1844A4370")]
	private void DOBEGLBMPJN(BKGKNAGKGBN EDAMHICEDPD, bool EFLIPNMAOOB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x44A4790", Offset = "0x44A3190", VA = "0x1844A4790")]
	private void HENJELENFAJ(BKGKNAGKGBN EDAMHICEDPD, TNode AAJANANFHLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x44A5320", Offset = "0x44A3D20", VA = "0x1844A5320")]
	[IteratorStateMachine(typeof(LMKLPLFOOOD<, >.PGEELDNKMCO))]
	private IEnumerable<TNode> MJBCFPNDDEI(TNode MCAKFFIJFGL, TNode MODBHFMJGIB, bool GPDHLKCEMLH = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x44A41A0", Offset = "0x44A2BA0", VA = "0x1844A41A0")]
	private BKGKNAGKGBN ACPKHCHAAON(TNode AOOGCKADIHP, TNode KMAENCDMJDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x44A4F10", Offset = "0x44A3910", VA = "0x1844A4F10")]
	private BKGKNAGKGBN KHDBMIEBHED(TNode AOOGCKADIHP, TNode KMAENCDMJDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x44A4D50", Offset = "0x44A3750", VA = "0x1844A4D50")]
	private void KFDLDBJNGOD(BKGKNAGKGBN EDAMHICEDPD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class KMFJPCIBHGK<T> : IEnumerable<KMFJPCIBHGK<T>.INKPOKJCKOF>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public struct INKPOKJCKOF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public T IPHMAHBENGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public int ENMILGHAHOM;
	}

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public class EMDACGEIKFC : IEnumerator<INKPOKJCKOF>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		private KMFJPCIBHGK<T> ECGBCMKEIMC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		private int ENMILGHAHOM;

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0x3A3B910", Offset = "0x3A3A310", VA = "0x183A3B910", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public INKPOKJCKOF EEAPHIFBJLL
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x3A3B9D0", Offset = "0x3A3A3D0", VA = "0x183A3B9D0", Slot = "4")]
			get
			{
				return default(INKPOKJCKOF);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C7")]
		[Cpp2IlInjected.Address(RVA = "0x3A3B990", Offset = "0x3A3A390", VA = "0x183A3B990")]
		public EMDACGEIKFC(KMFJPCIBHGK<T> ECGBCMKEIMC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C8")]
		[Cpp2IlInjected.Address(RVA = "0x3A3B800", Offset = "0x3A3A200", VA = "0x183A3B800", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0x3A3B880", Offset = "0x3A3A280", VA = "0x183A3B880", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0xB84E20", Offset = "0xB83820", VA = "0x180B84E20", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	private struct DNLFCHOJPAD
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public bool JDHPPDIPKEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public T IPHMAHBENGI;
	}

	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private const int OPHGGPNGOPN = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly Dictionary<T, int> JFMOCPPEGBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private DNLFCHOJPAD[] FPNOCDFEIEA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private int AGFMMLIEBMG;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public int IMIBHOMIDKM
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x8C4080", Offset = "0x8C2A80", VA = "0x1808C4080")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x8C3670", Offset = "0x8C2070", VA = "0x1808C3670")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public int LEDCMOMLPMG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x3764D90", Offset = "0x3763790", VA = "0x183764D90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x43E2A80", Offset = "0x43E1480", VA = "0x1843E2A80")]
	public KMFJPCIBHGK(int PAODLCPDLEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x43E2B70", Offset = "0x43E1570", VA = "0x1843E2B70")]
	public KMFJPCIBHGK(INKPOKJCKOF[] MAKPJCLEDMK, bool PGBONNJIDHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x43E2860", Offset = "0x43E1260", VA = "0x1843E2860")]
	public int LJNKIEFMBBD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x43E2430", Offset = "0x43E0E30", VA = "0x1843E2430")]
	private int KFADHOHKHMK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x43E23E0", Offset = "0x43E0DE0", VA = "0x1843E23E0", Slot = "6")]
	protected virtual uint ICBIPEAPFCF(uint IHNIDNBHBBH, T IPHMAHBENGI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x43E1D70", Offset = "0x43E0770", VA = "0x1843E1D70")]
	public bool CJNMODHIIHL(T IPHMAHBENGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x43E1BD0", Offset = "0x43E05D0", VA = "0x1843E1BD0")]
	public int BCNLOINKNAD(T IPHMAHBENGI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x43E2920", Offset = "0x43E1320", VA = "0x1843E2920")]
	public T LNFDLNBFLOL(int ENMILGHAHOM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x43E1E30", Offset = "0x43E0830", VA = "0x1843E1E30")]
	public bool HFCAFMPEHCO(T IPHMAHBENGI, bool OBPFHGPPOPL = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x43E2130", Offset = "0x43E0B30", VA = "0x1843E2130")]
	public bool HFCAFMPEHCO(T IPHMAHBENGI, int ENMILGHAHOM, bool OBPFHGPPOPL = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x43E1D20", Offset = "0x43E0720", VA = "0x1843E1D20")]
	private int BFGMAGHOFHI(int BHLKMIGNPBH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x43E29E0", Offset = "0x43E13E0", VA = "0x1843E29E0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x43E29E0", Offset = "0x43E13E0", VA = "0x1843E29E0", Slot = "4")]
	private IEnumerator<INKPOKJCKOF> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class EJFLOJLFCKH<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private readonly Stack<T> HMIMBMEPECC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private readonly List<T> OHDBLLFDIEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	private readonly int DOMIFANGNNG;

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x3A245A0", Offset = "0x3A22FA0", VA = "0x183A245A0")]
	public static EJFLOJLFCKH<T> DDMKJEBPHDK(int PAODLCPDLEP = 0, int DOMIFANGNNG = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x3A24A30", Offset = "0x3A23430", VA = "0x183A24A30")]
	public static EJFLOJLFCKH<T> FAPHDDMBPKB(int PAODLCPDLEP = 0, int DOMIFANGNNG = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x3A24F20", Offset = "0x3A23920", VA = "0x183A24F20")]
	public EJFLOJLFCKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x3A24D10", Offset = "0x3A23710", VA = "0x183A24D10")]
	public EJFLOJLFCKH(int PAODLCPDLEP, int DOMIFANGNNG = int.MaxValue, bool BDBMAFLMLMG = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x3A24690", Offset = "0x3A23090", VA = "0x183A24690")]
	public T DJJCLMNJKEF()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x3A243C0", Offset = "0x3A22DC0", VA = "0x183A243C0")]
	public void CADFCIHNIMB(T IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x3A244A0", Offset = "0x3A22EA0", VA = "0x183A244A0")]
	private void CBBIBEGKGKO(T IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x3A249F0", Offset = "0x3A233F0", VA = "0x183A249F0")]
	private void EIADCCPIPLM(T IPHMAHBENGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x3A24860", Offset = "0x3A23260", VA = "0x183A24860", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x3A24B20", Offset = "0x3A23520", VA = "0x183A24B20")]
	private void JCLLEPMPIBF(IEnumerable<T> KIAGDMGGGNM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class FOJBMMILPKK<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private Dictionary<int, T> BHMPBJAIPDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	private T NPDIFFMDIMI;

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	public virtual T CONHOIPKHFL
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x8892B0", Offset = "0x887CB0", VA = "0x1808892B0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x886A70", Offset = "0x885470", VA = "0x180886A70", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x3E07370", Offset = "0x3E05D70", VA = "0x183E07370")]
	public bool FALBPNDCFJG(T IPHMAHBENGI, int FLCNNPBENEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x3E07230", Offset = "0x3E05C30", VA = "0x183E07230")]
	public bool AAGAMFHOOMJ(int FLCNNPBENEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x3E07660", Offset = "0x3E06060", VA = "0x183E07660")]
	public T GBMMGOLCJCC(int OJPBNLKBOHH)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x3E07520", Offset = "0x3E05F20", VA = "0x183E07520")]
	private bool FLBELJFCDKP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x3E07410", Offset = "0x3E05E10", VA = "0x183E07410")]
	public bool FJHIBPMOMDE(int FLCNNPBENEH, [Out] T IPHMAHBENGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x3E07AA0", Offset = "0x3E064A0", VA = "0x183E07AA0")]
	public FOJBMMILPKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class BILABOLEGCJ<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	protected struct MJJLBHJBIEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public T ADJCIFCGLHC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public int KJFNGJJCDOE;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	protected readonly List<MJJLBHJBIEG> LFCFJOHJOPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	private T HKLDIPAICBJ;

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public int LEDCMOMLPMG
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x3764D90", Offset = "0x3763790", VA = "0x183764D90")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x50C28C0", Offset = "0x50C12C0", VA = "0x1850C28C0")]
	public bool DDGNJIHOIKG(T IPHMAHBENGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x50C32B0", Offset = "0x50C1CB0", VA = "0x1850C32B0")]
	public void KDCHLCHLBCK(T IPHMAHBENGI, int FLCNNPBENEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x50C2F90", Offset = "0x50C1990", VA = "0x1850C2F90")]
	public bool GDFNAHCIADO(T IPHMAHBENGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x50C3440", Offset = "0x50C1E40", VA = "0x1850C3440")]
	public void ODPBLJHKGDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x50C3180", Offset = "0x50C1B80", VA = "0x1850C3180")]
	public T JEDAFEMPPKM()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x50C2C90", Offset = "0x50C1690", VA = "0x1850C2C90")]
	protected void EBALEBDEEPL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x50C34E0", Offset = "0x50C1EE0", VA = "0x1850C34E0")]
	public BILABOLEGCJ()
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
		[CCFGIEGBFJM(NEFCELJHDOC.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60001E5")]
			[Cpp2IlInjected.Address(RVA = "0x6B6CB90", Offset = "0x6B6B590", VA = "0x186B6CB90")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001E6")]
			[Cpp2IlInjected.Address(RVA = "0x6B6CE60", Offset = "0x6B6B860", VA = "0x186B6CE60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60001E7")]
			[Cpp2IlInjected.Address(RVA = "0x6B6CD70", Offset = "0x6B6B770", VA = "0x186B6CD70")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60001E8")]
			[Cpp2IlInjected.Address(RVA = "0x6B6CAE0", Offset = "0x6B6B4E0", VA = "0x186B6CAE0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000058")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60001E9")]
			[Cpp2IlInjected.Address(RVA = "0x6B6CDB0", Offset = "0x6B6B7B0", VA = "0x186B6CDB0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x6B6CCC0", Offset = "0x6B6B6C0", VA = "0x186B6CCC0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x6B6CA60", Offset = "0x6B6B460", VA = "0x186B6CA60")]
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
		[Cpp2IlInjected.Address(RVA = "0x4B70B30", Offset = "0x4B6F530", VA = "0x184B70B30", Slot = "4")]
		public virtual T IBDKMOLAPDN()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class HEOILPAEMKC : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	private Dictionary<byte, NCOHDIACELO> JFMCAGOGICP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	private readonly EJFLOJLFCKH<NCOHDIACELO> JPLENHDPMBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private readonly bool BJLFCEMKIOH;

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	public NCOHDIACELO PDLAOAPCHIF
	{
		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x885670", Offset = "0x884070", VA = "0x180885670")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x8855F0", Offset = "0x883FF0", VA = "0x1808855F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public Vector2 MCPCFMIGEDD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0xF6E0F0", Offset = "0xF6CAF0", VA = "0x180F6E0F0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x1270100", Offset = "0x126EB00", VA = "0x181270100")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	private Vector2 NGOJCIDBEFD
	{
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x92A990", Offset = "0x929390", VA = "0x18092A990")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public Vector2 EJGPMBGNNBA
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x6B6A340", Offset = "0x6B68D40", VA = "0x186B6A340")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x88B3C0", Offset = "0x889DC0", VA = "0x18088B3C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public int JAGLFGNOKOB
	{
		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x8892E0", Offset = "0x887CE0", VA = "0x1808892E0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x8890A0", Offset = "0x887AA0", VA = "0x1808890A0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x6B6A800", Offset = "0x6B69200", VA = "0x186B6A800")]
	public HEOILPAEMKC(Bounds CABMONOACBF, Vector2[] DKPLEKOPKNO, int JMIHGCPFAFF, byte BHLKMIGNPBH, float LHDMICCMCAG = 0f, [Optional] EJFLOJLFCKH<NCOHDIACELO> JPLENHDPMBG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x6B69DC0", Offset = "0x6B687C0", VA = "0x186B69DC0")]
	public void KCHDNAHMIEL(Bounds CABMONOACBF, Vector2[] DKPLEKOPKNO, int JMIHGCPFAFF, byte BHLKMIGNPBH, float LHDMICCMCAG = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x6B69B30", Offset = "0x6B68530", VA = "0x186B69B30")]
	public NCOHDIACELO HNNIFJIGLFE(byte ENMILGHAHOM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x6B6A270", Offset = "0x6B68C70", VA = "0x186B6A270")]
	public void LGJMBFMHEGH(Vector3 EJEBFMEPKGF, float FFALNOPNOGJ, float FNNFPDALPJI, List<byte> HPBFKIEPIJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x6B6A250", Offset = "0x6B68C50", VA = "0x186B6A250")]
	public void KLADDCCFHDI(NCOHDIACELO.GCGIHNDNCGD IBIMDEFGKLF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x6B6A720", Offset = "0x6B69120", VA = "0x186B6A720")]
	public static int PINCFPCBKEA(Vector2[] DKPLEKOPKNO, int JMIHGCPFAFF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x6B69B90", Offset = "0x6B68590", VA = "0x186B69B90")]
	private NCOHDIACELO ICFHLNPKKDP(byte ENMILGHAHOM, NCOHDIACELO.CKAEBOCLMLI GBDFDMEIGAE, NCOHDIACELO KMAENCDMJDN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x6B6A360", Offset = "0x6B68D60", VA = "0x186B6A360")]
	private void OGOGFADFPCE(NCOHDIACELO KMAENCDMJDN, Vector2[] DKPLEKOPKNO, int EENHLGJFAOG, int BFFBCBOEMGD, int GBNECNKHHPC, int NPPHBIKIIII, float LHDMICCMCAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x6B698B0", Offset = "0x6B682B0", VA = "0x186B698B0")]
	private void EFCCJDFGJOD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x6B69850", Offset = "0x6B68250", VA = "0x186B69850", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x6B69AD0", Offset = "0x6B684D0", VA = "0x186B69AD0", Slot = "1")]
	~HEOILPAEMKC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000069")]
public class NCOHDIACELO
{
	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public enum CKAEBOCLMLI
	{
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	public enum GCGIHNDNCGD
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
	public byte POAGINPHPCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public Vector3 HNBIDONPKBJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public Vector3 BKOAINILKFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public Vector3 FJDLPEFDCOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public Vector3 LCGCIOKIPHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public CKAEBOCLMLI NKJGPNJOCCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	public NCOHDIACELO JEBILDNGPEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	public List<NCOHDIACELO> DFGDDBNGJDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	public bool BHHJIDMJDCM;

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x6B6C3B0", Offset = "0x6B6ADB0", VA = "0x186B6C3B0")]
	public NCOHDIACELO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x6B6BF20", Offset = "0x6B6A920", VA = "0x186B6BF20")]
	public void EBLGBIHLLBM(NCOHDIACELO PPFEFKBKBLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x883230", Offset = "0x881C30", VA = "0x180883230")]
	public void KLADDCCFHDI(int DFFAGFGJGKJ, GCGIHNDNCGD IBIMDEFGKLF, int AOOIPMOHGIC = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x6B6C120", Offset = "0x6B6AB20", VA = "0x186B6C120")]
	public void LGJMBFMHEGH(List<byte> HPBFKIEPIJK, Vector3 EJEBFMEPKGF, float FFALNOPNOGJ, float FNNFPDALPJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x6B6C060", Offset = "0x6B6AA60", VA = "0x186B6C060")]
	public bool FEOJNDIJHAE(Vector3 CJFPFKBEIIC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x6B6C380", Offset = "0x6B6AD80", VA = "0x186B6C380")]
	public bool PMMOJGEABEI(Vector3 CJFPFKBEIIC, float HNBOCENGLEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x6B6C090", Offset = "0x6B6AA90", VA = "0x186B6C090")]
	public void HINDDHMAHAN()
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
		public struct BGHFEKCJJHL<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			private readonly List<Component> GLCCIANLCJC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			private readonly bool OPJMMHPELBJ;

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x446E310", Offset = "0x446CD10", VA = "0x18446E310")]
			public BGHFEKCJJHL(List<Component> GLCCIANLCJC, bool OPJMMHPELBJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000216")]
			[Cpp2IlInjected.Address(RVA = "0x50AD8D0", Offset = "0x50AC2D0", VA = "0x1850AD8D0")]
			public DKHJIJNIDCK<T> PBHEMGCNMMA()
			{
				return default(DKHJIJNIDCK<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000217")]
			[Cpp2IlInjected.Address(RVA = "0x50AD930", Offset = "0x50AC330", VA = "0x1850AD930", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000218")]
			[Cpp2IlInjected.Address(RVA = "0x50AD930", Offset = "0x50AC330", VA = "0x1850AD930", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006E")]
		public struct DKHJIJNIDCK<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000120")]
			private readonly List<Component> GLCCIANLCJC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000121")]
			private readonly bool OPJMMHPELBJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000122")]
			private int ENMILGHAHOM;

			[Cpp2IlInjected.Token(Token = "0x17000060")]
			public T EEAPHIFBJLL
			{
				[Cpp2IlInjected.Token(Token = "0x600021A")]
				[Cpp2IlInjected.Address(RVA = "0x5AA2240", Offset = "0x5AA0C40", VA = "0x185AA2240", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000061")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600021B")]
				[Cpp2IlInjected.Address(RVA = "0x5AA21D0", Offset = "0x5AA0BD0", VA = "0x185AA21D0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000219")]
			[Cpp2IlInjected.Address(RVA = "0x5AA2210", Offset = "0x5AA0C10", VA = "0x185AA2210")]
			public DKHJIJNIDCK(List<Component> GLCCIANLCJC, bool OPJMMHPELBJ)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021C")]
			[Cpp2IlInjected.Address(RVA = "0x5AA2110", Offset = "0x5AA0B10", VA = "0x185AA2110", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600021D")]
			[Cpp2IlInjected.Address(RVA = "0x5AA2120", Offset = "0x5AA0B20", VA = "0x185AA2120", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600021E")]
			[Cpp2IlInjected.Address(RVA = "0x3A9D8E0", Offset = "0x3A9C2E0", VA = "0x183A9D8E0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x6B6E850", Offset = "0x6B6D250", VA = "0x186B6E850")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x888E90", Offset = "0x887890", VA = "0x180888E90")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x6B6E5B0", Offset = "0x6B6CFB0", VA = "0x186B6E5B0")]
		private void HINDDHMAHAN(GameObject IHJCDAFDGLD, bool LCIPAAAOEPD = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x6B6E720", Offset = "0x6B6D120", VA = "0x186B6E720")]
		public static void HINDDHMAHAN(GameObject IHJCDAFDGLD, ToolHierarchyCache CJEEOBCMPEP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x6B6E7B0", Offset = "0x6B6D1B0", VA = "0x186B6E7B0")]
		public void NAALDIIKIJJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x307EB10", Offset = "0x307D510", VA = "0x18307EB10")]
		public void KOADDEMANGG<T>(Action<T> GGEEGOKOMKJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x307ED50", Offset = "0x307D750", VA = "0x18307ED50")]
		public T PLOHCCAFKLN<T>(bool OPJMMHPELBJ = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x307EA50", Offset = "0x307D450", VA = "0x18307EA50")]
		public BGHFEKCJJHL<T> FBOMDFDEBKH<T>(bool OPJMMHPELBJ = false) where T : class
		{
			return default(BGHFEKCJJHL<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x6B6E170", Offset = "0x6B6CB70", VA = "0x186B6E170")]
		public List<Component> EJELELGAAOP(Type AOGCIMANLIJ)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000212")]
		[Cpp2IlInjected.Address(RVA = "0x6B6E4C0", Offset = "0x6B6CEC0", VA = "0x186B6E4C0", Slot = "4")]
		public bool Equals(ToolHierarchyCache OFCNMBDJPHM, ToolHierarchyCache CONCKFNNMJO)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000213")]
		[Cpp2IlInjected.Address(RVA = "0x6B6E540", Offset = "0x6B6CF40", VA = "0x186B6E540", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache FHFDEAHMMBI)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006F")]
public class NDJPPHNKELL<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private int PAODLCPDLEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private int IAFJMHBODKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private List<T> BBBCJIECHAD;

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public int LEDCMOMLPMG
	{
		[Cpp2IlInjected.Token(Token = "0x600021F")]
		[Cpp2IlInjected.Address(RVA = "0x3E07B50", Offset = "0x3E06550", VA = "0x183E07B50")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public T PNIOHMAODCA
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x4794250", Offset = "0x4792C50", VA = "0x184794250")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public T MNPAIJPPNNP
	{
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x47948D0", Offset = "0x47932D0", VA = "0x1847948D0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public T LJKLJPBHDLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x4794440", Offset = "0x4792E40", VA = "0x184794440")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x4794A30", Offset = "0x4793430", VA = "0x184794A30")]
	public NDJPPHNKELL(int PAODLCPDLEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000224")]
	[Cpp2IlInjected.Address(RVA = "0x4794530", Offset = "0x4792F30", VA = "0x184794530")]
	public void KDCHLCHLBCK(T JMBIPKJONBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x47949D0", Offset = "0x47933D0", VA = "0x1847949D0")]
	public void ODPBLJHKGDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x47947E0", Offset = "0x47931E0", VA = "0x1847947E0")]
	public void LIFJAHOKCBJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x47943E0", Offset = "0x4792DE0", VA = "0x1847943E0")]
	public void GJLGNHKJEMA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x47949C0", Offset = "0x47933C0", VA = "0x1847949C0")]
	public void NHHJCPODINF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x47941C0", Offset = "0x4792BC0", VA = "0x1847941C0")]
	public List<T> ADKHFAMFOOP()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class MBHHGPMABJE<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	private struct FEFLEOAGINL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012A")]
		public int KJFNGJJCDOE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400012B")]
		public T ADJCIFCGLHC;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private readonly Dictionary<object, FEFLEOAGINL> BHMPBJAIPDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly EqualityComparer<T> OFFKABKFFLA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	private T NPDIFFMDIMI;

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public virtual T CONHOIPKHFL
	{
		[Cpp2IlInjected.Token(Token = "0x600022A")]
		[Cpp2IlInjected.Address(RVA = "0x964810", Offset = "0x963210", VA = "0x180964810", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0x467BE70", Offset = "0x467A870", VA = "0x18467BE70", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000067")]
	public bool KDBJPNBHPCC
	{
		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x467BE00", Offset = "0x467A800", VA = "0x18467BE00")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public object IMNFHGMNCBP
	{
		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x885660", Offset = "0x884060", VA = "0x180885660")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x885620", Offset = "0x884020", VA = "0x180885620")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600022F")]
	[Cpp2IlInjected.Address(RVA = "0x4677F80", Offset = "0x4676980", VA = "0x184677F80")]
	public bool FALBPNDCFJG(T IPHMAHBENGI, object OEELDHBFFAF, int FLCNNPBENEH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000230")]
	[Cpp2IlInjected.Address(RVA = "0x46779A0", Offset = "0x46763A0", VA = "0x1846779A0")]
	public bool AAGAMFHOOMJ(object OEELDHBFFAF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000231")]
	[Cpp2IlInjected.Address(RVA = "0x4678970", Offset = "0x4677370", VA = "0x184678970")]
	public bool FJHIBPMOMDE(object OEELDHBFFAF, [Out] T IPHMAHBENGI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000232")]
	[Cpp2IlInjected.Address(RVA = "0x3EE0290", Offset = "0x3EDEC90", VA = "0x183EE0290")]
	public void ODPBLJHKGDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000233")]
	[Cpp2IlInjected.Address(RVA = "0x4679D60", Offset = "0x4678760", VA = "0x184679D60")]
	private bool FLBELJFCDKP()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000234")]
	[Cpp2IlInjected.Address(RVA = "0x467BF00", Offset = "0x467A900", VA = "0x18467BF00")]
	public MBHHGPMABJE()
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
