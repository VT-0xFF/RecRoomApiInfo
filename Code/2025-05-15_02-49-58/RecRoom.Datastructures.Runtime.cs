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
using RecRoom.Core.DataStructures;
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
		[Cpp2IlInjected.Address(RVA = "0xA149D0", Offset = "0xA12FD0", VA = "0x180A149D0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[CompilerGenerated]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x7BF7750", Offset = "0x7BF5D50", VA = "0x187BF7750")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA154F0", Offset = "0xA13AF0", VA = "0x180A154F0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xA15530", Offset = "0xA13B30", VA = "0x180A15530")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class NJOFEBADJIN : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2065F80", Offset = "0x2064580", VA = "0x182065F80")]
	public NJOFEBADJIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HashableScriptableObject : ScriptableObject, EJMDGDGNKJJ, MFJKOPKJMGJ, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9EACD0", Offset = "0x9E92D0", VA = "0x1809EACD0", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xC7C260", Offset = "0xC7A860", VA = "0x180C7C260", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash CNOOJBJPLMK);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0xBBABA0", Offset = "0xBB91A0", VA = "0x180BBABA0")]
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
	[SerializeField]
	[ReadOnlyField]
	private Bounds localSpaceBounds;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000008")]
	[SerializeField]
	[ReadOnlyField]
	[HideInInspector]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7BF8980", Offset = "0x7BF6F80", VA = "0x187BF8980")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7BF8940", Offset = "0x7BF6F40", VA = "0x187BF8940")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7BF89C0", Offset = "0x7BF6FC0", VA = "0x187BF89C0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7BF8B70", Offset = "0x7BF7170", VA = "0x187BF8B70")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7BF8AE0", Offset = "0x7BF70E0", VA = "0x187BF8AE0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xEDF1A0", Offset = "0xEDD7A0", VA = "0x180EDF1A0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xD47950", Offset = "0xD45F50", VA = "0x180D47950")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7BF8900", Offset = "0x7BF6F00", VA = "0x187BF8900")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7BF8A50", Offset = "0x7BF7050", VA = "0x187BF8A50")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7BF8550", Offset = "0x7BF6B50", VA = "0x187BF8550")]
	public void CopyBounds(SavedExtents MIJLJBIHDMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7BF8850", Offset = "0x7BF6E50", VA = "0x187BF8850")]
	public void SetLocalSpaceBounds(Bounds GBDEJJCEIID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1417AD0", Offset = "0x14160D0", VA = "0x181417AD0")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7BF8840", Offset = "0x7BF6E40", VA = "0x187BF8840")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7BF7D60", Offset = "0x7BF6360", VA = "0x187BF7D60")]
	private void CELJPBCMFIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7BF8640", Offset = "0x7BF6C40", VA = "0x187BF8640")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7BF7F10", Offset = "0x7BF6510", VA = "0x187BF7F10")]
	public static void CalculateLocalBoundsFor(GameObject CEKGANCAJPA, [Out] Bounds GBDEJJCEIID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7BF8580", Offset = "0x7BF6B80", VA = "0x187BF8580")]
	private static void EEPILJLNMGM(Bounds CNIMJCCKEDM, Color JKIBOICMIDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7BF8870", Offset = "0x7BF6E70", VA = "0x187BF8870")]
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
		[Cpp2IlInjected.Address(RVA = "0x9E91A0", Offset = "0x9E77A0", VA = "0x1809E91A0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD30", Offset = "0x9E9330", VA = "0x1809EAD30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x18BFF00", Offset = "0x18BE500", VA = "0x1818BFF00")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5846ED0", Offset = "0x58454D0", VA = "0x185846ED0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public virtual void GBHHIMAPMMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
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
	[NJOFEBADJIN]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5846A40", Offset = "0x5845040", VA = "0x185846A40", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5845610", Offset = "0x5843C10", VA = "0x185845610", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5846DF0", Offset = "0x58453F0", VA = "0x185846DF0")]
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
	private sealed class EFFICMJNHOA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public EFFICMJNHOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x45017B0", Offset = "0x44FFDB0", VA = "0x1845017B0")]
		internal int ELDJJCDOMAN(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[SerializeField]
	[NJOFEBADJIN]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x4534020", Offset = "0x4532620", VA = "0x184534020", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4534080", Offset = "0x4532680", VA = "0x184534080", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4533F00", Offset = "0x4532500", VA = "0x184533F00", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey OEHHKNIGGMI]
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4533FC0", Offset = "0x45325C0", VA = "0x184533FC0", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4533DB0", Offset = "0x45323B0", VA = "0x184533DB0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x45339C0", Offset = "0x4531FC0", VA = "0x1845339C0", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4532D80", Offset = "0x4531380", VA = "0x184532D80", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4533BA0", Offset = "0x45321A0", VA = "0x184533BA0", Slot = "14")]
	protected virtual string PKIBKHPNHMC(TKeyVal MKENHCDLPKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4532C80", Offset = "0x4531280", VA = "0x184532C80", Slot = "4")]
	public bool ContainsKey(TKey OEHHKNIGGMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4533C30", Offset = "0x4532230", VA = "0x184533C30", Slot = "5")]
	public bool TryGetValue(TKey OEHHKNIGGMI, [Out] TVal OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4532CE0", Offset = "0x45312E0", VA = "0x184532CE0", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4532CE0", Offset = "0x45312E0", VA = "0x184532CE0", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4533C90", Offset = "0x4532290", VA = "0x184533C90")]
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
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
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
		[Cpp2IlInjected.Address(RVA = "0x44C62B0", Offset = "0x44C48B0", VA = "0x1844C62B0")]
		public SerializedReferenceKeyValuePair()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[SerializeField]
	[NJOFEBADJIN]
	private List<SerializedReferenceKeyValuePair> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5848880", Offset = "0x5846E80", VA = "0x185848880")]
	protected SerializedReferenceDictionary()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x58480C0", Offset = "0x58466C0", VA = "0x1858480C0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5847670", Offset = "0x5845C70", VA = "0x185847670", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class INPGGBKMAEO<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct FCBLJBMNIFE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public T FPGFCMMHMJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public float IOJHJCADCHO;
	}

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private const int DHDMLEJOCHP = 16;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private const float HDIBKKHKKAL = -1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	protected readonly FCBLJBMNIFE[] NBBLCIBNPBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	protected int KOHMOIMIEKH;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public float CKMPHLAIBBO
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xC19D70", Offset = "0xC18370", VA = "0x180C19D70")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xC6F490", Offset = "0xC6DA90", VA = "0x180C6F490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public T GHJEAJCFOKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4C46470", Offset = "0x4C44A70", VA = "0x184C46470")]
	protected INPGGBKMAEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4C463D0", Offset = "0x4C449D0", VA = "0x184C463D0")]
	protected INPGGBKMAEO(int CFNMLMNHCMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4C460D0", Offset = "0x4C446D0", VA = "0x184C460D0")]
	public void IIGLPCDPOEE(float EPGNCELGAFP, T OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool MAEKIKKKDDB(float OMDABEJMMKM, float MKDGBOGGCJD, [Out] T OHLIHBDBKCE);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool AAJCDDFGDIL(float OMDABEJMMKM, float MKDGBOGGCJD, [Out] T OHLIHBDBKCE);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x4C46360", Offset = "0x4C44960", VA = "0x184C46360")]
	public void INBDHNEFJBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class FMOLKLBGDFE : INPGGBKMAEO<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7BF7270", Offset = "0x7BF5870", VA = "0x187BF7270", Slot = "4")]
	public override bool MAEKIKKKDDB(float OMDABEJMMKM, float MKDGBOGGCJD, [Out] Vector3 OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7BF7130", Offset = "0x7BF5730", VA = "0x187BF7130", Slot = "5")]
	public override bool AAJCDDFGDIL(float OMDABEJMMKM, float MKDGBOGGCJD, [Out] Vector3 OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7BF73D0", Offset = "0x7BF59D0", VA = "0x187BF73D0")]
	public FMOLKLBGDFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class HLPPLMKFOCK
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3888A10", Offset = "0x3887010", VA = "0x183888A10")]
	public static HMGCNMGOPPM<T1, T2> FLLMCNLHKNL<T1, T2>(T1 DOKIGGDJIPL, T2 DIKLDOJBCJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3888AB0", Offset = "0x38870B0", VA = "0x183888AB0")]
	public static LEGOPPDCCEI<T1, T2, T3> FLLMCNLHKNL<T1, T2, T3>(T1 DOKIGGDJIPL, T2 DIKLDOJBCJC, T3 FBEKHHFKGAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x53BBE40", Offset = "0x53BA440", VA = "0x1853BBE40")]
	internal static int OCIIMJDKACM(int OJGEEEBKPNG, int GNEHPDMBGJL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6E00060", Offset = "0x6DFE660", VA = "0x186E00060")]
	internal static int OCIIMJDKACM(int OJGEEEBKPNG, int GNEHPDMBGJL, int BNGJHLDBAAG)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class HMGCNMGOPPM<T1, T2> : IComparable<HMGCNMGOPPM<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly T1 HHHOKMDCIOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly T2 NDGEHALNEEF;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4B655B0", Offset = "0x4B63BB0", VA = "0x184B655B0")]
	public HMGCNMGOPPM(T1 DOKIGGDJIPL, T2 DIKLDOJBCJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x4B63AE0", Offset = "0x4B620E0", VA = "0x184B63AE0", Slot = "4")]
	public int CompareTo(HMGCNMGOPPM<T1, T2> MIJLJBIHDMP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x4B64410", Offset = "0x4B62A10", VA = "0x184B64410", Slot = "0")]
	public override bool Equals(object MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4B64850", Offset = "0x4B62E50", VA = "0x184B64850", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x4B65090", Offset = "0x4B63690", VA = "0x184B65090", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class LEGOPPDCCEI<T1, T2, T3> : IComparable<LEGOPPDCCEI<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly T1 HHHOKMDCIOB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly T2 NDGEHALNEEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly T3 GENCHJLNLNG;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5117CB0", Offset = "0x51162B0", VA = "0x185117CB0")]
	public LEGOPPDCCEI(T1 DOKIGGDJIPL, T2 DIKLDOJBCJC, T3 FBEKHHFKGAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x51174A0", Offset = "0x5115AA0", VA = "0x1851174A0", Slot = "4")]
	public int CompareTo(LEGOPPDCCEI<T1, T2, T3> MIJLJBIHDMP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5117710", Offset = "0x5115D10", VA = "0x185117710", Slot = "0")]
	public override bool Equals(object MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5117950", Offset = "0x5115F50", VA = "0x185117950", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x51179F0", Offset = "0x5115FF0", VA = "0x1851179F0", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public abstract class ValueCurve<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000023")]
	[SerializeField]
	protected AnimationCurve curve;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	[SerializeField]
	protected T minValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	[SerializeField]
	protected T maxValue;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	[SerializeField]
	protected float duration;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public AnimationCurve CAMPINBGKPL
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public T POEFMBBDOON
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x12A0680", Offset = "0x129EC80", VA = "0x1812A0680")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T OGKJEFIOBMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xC0A830", Offset = "0xC08E30", VA = "0x180C0A830")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T FPGFCMMHMJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2B45490", Offset = "0x2B43A90", VA = "0x182B45490")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2B454E0", Offset = "0x2B43AE0", VA = "0x182B454E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float GKIGMCHANCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xC07340", Offset = "0xC05940", VA = "0x180C07340")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5B1C450", Offset = "0x5B1AA50", VA = "0x185B1C450")]
	public T ELFKPHICMCJ(float LEMBKBGMCDG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5B1C920", Offset = "0x5B1AF20", VA = "0x185B1C920")]
	public T NNMAIOBAJPP(float LEMBKBGMCDG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T BKJDABAAONM(T OBNCJFFHHLB, T ODHPFGNCGDP, float LEMBKBGMCDG);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7BF7410", Offset = "0x7BF5A10", VA = "0x187BF7410", Slot = "4")]
	protected override float BKJDABAAONM(float OBNCJFFHHLB, float ODHPFGNCGDP, float LEMBKBGMCDG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7BF7450", Offset = "0x7BF5A50", VA = "0x187BF7450")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x17103B0", Offset = "0x170E9B0", VA = "0x1817103B0", Slot = "4")]
	protected override Vector3 BKJDABAAONM(Vector3 OBNCJFFHHLB, Vector3 ODHPFGNCGDP, float LEMBKBGMCDG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7BF9940", Offset = "0x7BF7F40", VA = "0x187BF9940")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7BF4F60", Offset = "0x7BF3560", VA = "0x187BF4F60", Slot = "4")]
	protected override Color BKJDABAAONM(Color OBNCJFFHHLB, Color ODHPFGNCGDP, float LEMBKBGMCDG)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7BF5020", Offset = "0x7BF3620", VA = "0x187BF5020")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class DHGMCGGGGNC : HOBCNHIEEIJ<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7BF50D0", Offset = "0x7BF36D0", VA = "0x187BF50D0")]
	public DHGMCGGGGNC(int GDBMBEIFFOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7BF5060", Offset = "0x7BF3660", VA = "0x187BF5060", Slot = "6")]
	protected override uint MAJBBDAIHEL(uint CNOOJBJPLMK, string OHLIHBDBKCE)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class GMGJACIIKNC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly IDisposable MLIJHBGBMKP;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	public GMGJACIIKNC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct KNAIKKDHPNB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> FPLBBKNCGCN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int DNBFMONACKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private int NIPFBCPKOAJ;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x4F58A00", Offset = "0x4F57000", VA = "0x184F58A00")]
	private KNAIKKDHPNB(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> KGBFIONNDLC, int NICAKCBKIBI, int IELIEGDMFFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x501D030", Offset = "0x501B630", VA = "0x18501D030")]
	public static KNAIKKDHPNB<T> ACADPGMDEBE()
	{
		return default(KNAIKKDHPNB<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x501D130", Offset = "0x501B730", VA = "0x18501D130")]
	public (int, int, Task<T>) CAKEOFOFIAD(int GIBLACJPDHG, [Optional] CancellationToken CBJPDIFOEKF, double EPOJNFBFHFP = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x501EFC0", Offset = "0x501D5C0", VA = "0x18501EFC0")]
	public void NEMFFPKLNCP(int GIBLACJPDHG, int IELIEGDMFFE, [In] T OBOOAPELMPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class BDGPCNOIGDD
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7BF4AE0", Offset = "0x7BF30E0", VA = "0x187BF4AE0")]
	public static KNAIKKDHPNB<BONGKMFJEJA> ACADPGMDEBE()
	{
		return default(KNAIKKDHPNB<BONGKMFJEJA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7BF4B30", Offset = "0x7BF3130", VA = "0x187BF4B30")]
	public static void NEMFFPKLNCP([In] this KNAIKKDHPNB<BONGKMFJEJA> OCACDKEJIIB, int GIBLACJPDHG, int IELIEGDMFFE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[DefaultMember("Item")]
public class HIMOGHLLMID<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly Dictionary<TKey, TVal> IGIDJDKHMNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly Dictionary<TVal, TKey> DGDECFHHJML;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int CMIOJAJFIMN
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x408CB60", Offset = "0x408B160", VA = "0x18408CB60", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool DJCGEFIJFFP
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TKey> JABHKAJJCDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x44F9F80", Offset = "0x44F8580", VA = "0x1844F9F80", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ICollection<TVal> CLOMIHCLDKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x4B537D0", Offset = "0x4B51DD0", VA = "0x184B537D0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TVal OEMFNNCKNFG
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x4B53770", Offset = "0x4B51D70", VA = "0x184B53770", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x4B53820", Offset = "0x4B51E20", VA = "0x184B53820", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public TKey OEMFNNCKNFG
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x4B52940", Offset = "0x4B50F40", VA = "0x184B52940")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x4B52B30", Offset = "0x4B51130", VA = "0x184B52B30", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x4B53540", Offset = "0x4B51B40", VA = "0x184B53540", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x4B52A90", Offset = "0x4B51090", VA = "0x184B52A90", Slot = "9")]
	public void Add(TKey OEHHKNIGGMI, TVal OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x4B52A40", Offset = "0x4B51040", VA = "0x184B52A40", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> HOJKNIMMINF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x4B52BD0", Offset = "0x4B511D0", VA = "0x184B52BD0", Slot = "8")]
	public bool ContainsKey(TKey OEHHKNIGGMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x4B52C20", Offset = "0x4B51220", VA = "0x184B52C20", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4B53430", Offset = "0x4B51A30", VA = "0x184B53430", Slot = "10")]
	public bool Remove(TKey OEHHKNIGGMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4B534B0", Offset = "0x4B51AB0", VA = "0x184B534B0", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4B53590", Offset = "0x4B51B90", VA = "0x184B53590", Slot = "11")]
	public bool TryGetValue(TKey OEHHKNIGGMI, [Out] TVal OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4B52EE0", Offset = "0x4B514E0", VA = "0x184B52EE0", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x4B52CA0", Offset = "0x4B512A0", VA = "0x184B52CA0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] NBBLCIBNPBK, int DDFLLHIGBFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x4B52F80", Offset = "0x4B51580", VA = "0x184B52F80")]
	public bool LKMKPGKLGLC(TVal OEHHKNIGGMI, [Out] TKey OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x4B52DF0", Offset = "0x4B513F0", VA = "0x184B52DF0")]
	private void EPFBABNADFL(TKey OEHHKNIGGMI, TVal GCDAJLDGOIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x4B53110", Offset = "0x4B51710", VA = "0x184B53110")]
	private void PEEGBDMODGD(TKey OEHHKNIGGMI, TVal GCDAJLDGOIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x4B53200", Offset = "0x4B51800", VA = "0x184B53200")]
	private bool PGAFKNEHGID(TKey OEHHKNIGGMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4B535F0", Offset = "0x4B51BF0", VA = "0x184B535F0")]
	public HIMOGHLLMID()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[DefaultMember("Item")]
public class COCLBOJKODC<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private COCLBOJKODC<T> buffer;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000033")]
		private int index;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000034")]
		private int version;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000035")]
		private T current;

		[Cpp2IlInjected.Token(Token = "0x17000025")]
		public T Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A1")]
			[Cpp2IlInjected.Address(RVA = "0x458D110", Offset = "0x458B710", VA = "0x18458D110", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x45A02F0", Offset = "0x459E8F0", VA = "0x1845A02F0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x45A13B0", Offset = "0x459F9B0", VA = "0x1845A13B0")]
		public Enumerator(COCLBOJKODC<T> IIGKBHIENFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x459F420", Offset = "0x459DA20", VA = "0x18459F420", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x45A00C0", Offset = "0x459E6C0", VA = "0x1845A00C0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x459ED80", Offset = "0x459D380", VA = "0x18459ED80")]
		private void KPIBGBDIGBG()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private T[] PPBIAJGFOEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private int NGFMNKONPKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private int AHEINAHGGJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int DJNGLBELENN;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int CMIOJAJFIMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x67D91C0", Offset = "0x67D77C0", VA = "0x1867D91C0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public T OEMFNNCKNFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x67D8080", Offset = "0x67D6680", VA = "0x1867D8080")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x67D93C0", Offset = "0x67D79C0", VA = "0x1867D93C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x67DA210", Offset = "0x67D8810", VA = "0x1867DA210")]
	public COCLBOJKODC(int GDBMBEIFFOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x67D8D50", Offset = "0x67D7350", VA = "0x1867D8D50")]
	public void IIGLPCDPOEE(T LEMBKBGMCDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x67D9170", Offset = "0x67D7770", VA = "0x1867D9170")]
	public void INBDHNEFJBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x67D8AB0", Offset = "0x67D70B0", VA = "0x1867D8AB0")]
	public void HAILHNMFFGN(int JAALIADHHOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x67D9DC0", Offset = "0x67D83C0", VA = "0x1867D9DC0")]
	public void PNJIDJCBNNF(T[] NBBLCIBNPBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x67D95B0", Offset = "0x67D7BB0", VA = "0x1867D95B0")]
	public Enumerator OMLAPONJPHN()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x67DA0B0", Offset = "0x67D86B0", VA = "0x1867DA0B0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x67DA0B0", Offset = "0x67D86B0", VA = "0x1867DA0B0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x67D8720", Offset = "0x67D6D20", VA = "0x1867D8720")]
	private int FBGOCIPPCKC(int OHHMJGCBCKD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x67D9190", Offset = "0x67D7790", VA = "0x1867D9190")]
	private int KFNBPIDNLFP(int OHHMJGCBCKD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class BHHEEFEODGH<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public delegate Task<TResult> HGHCKAMNGOP(TRequest HOOJNAMGGBC, CancellationToken CBJPDIFOEKF);

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public enum AGDCLFFGFFG
	{
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class ANNKHFIEAPK
	{
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private const float GHEGAKMGCGJ = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TimeSpan PDJMNGILGHI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int HDNAEANNAJF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public AGDCLFFGFFG AJLGNCLDHCC;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public static readonly ANNKHFIEAPK OPJKGEJPJBC;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public float JJHKNEHMNEF
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x4F592B0", Offset = "0x4F578B0", VA = "0x184F592B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public TimeSpan GHODKACCJDG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x4F59390", Offset = "0x4F57990", VA = "0x184F59390")]
		public ANNKHFIEAPK()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private readonly struct OLNGEDHHDKK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public readonly TRequest HOOJNAMGGBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public readonly CancellationToken CBJPDIFOEKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public readonly TaskCompletionSource<TResult> NDDCKHOMMDA;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x5544820", Offset = "0x5542E20", VA = "0x185544820")]
		public OLNGEDHHDKK(TRequest HOOJNAMGGBC, TaskCompletionSource<TResult> NDDCKHOMMDA, CancellationToken CBJPDIFOEKF)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private struct BAJAECHAOLL : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public BHHEEFEODGH<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x60551E0", Offset = "0x60537E0", VA = "0x1860551E0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x6055AA0", Offset = "0x60540A0", VA = "0x186055AA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct AJLNAKOPBPO : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public BHHEEFEODGH<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private OLNGEDHHDKK <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x4C7EBD0", Offset = "0x4C7D1D0", VA = "0x184C7EBD0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x4C7F270", Offset = "0x4C7D870", VA = "0x184C7F270", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly CancellationTokenSource DLMEJPIKCAF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly List<OLNGEDHHDKK> GGBKGOGHHJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly ANNKHFIEAPK JPIKKANLOGG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly HGHCKAMNGOP GFGHJNLGNEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private Task AGJEPLIBGPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int GOCIILIBKOL;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6339630", Offset = "0x6337C30", VA = "0x186339630")]
	public BHHEEFEODGH(HGHCKAMNGOP GFGHJNLGNEC, [Optional] ANNKHFIEAPK JPIKKANLOGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6337D40", Offset = "0x6336340", VA = "0x186337D40")]
	public Task<TResult> AFNOPJDJEBM(TRequest HOOJNAMGGBC, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6339090", Offset = "0x6337690", VA = "0x186339090")]
	private void OGAHDHCDJIF(OLNGEDHHDKK OAAOOLHHJIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x63389E0", Offset = "0x6336FE0", VA = "0x1863389E0")]
	[AsyncStateMachine(typeof(BHHEEFEODGH<, >.BAJAECHAOLL))]
	private Task IKCNLBOPEDP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6338570", Offset = "0x6336B70", VA = "0x186338570")]
	private OLNGEDHHDKK GBOPKPFONCA()
	{
		return default(OLNGEDHHDKK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6338CA0", Offset = "0x63372A0", VA = "0x186338CA0")]
	[AsyncStateMachine(typeof(BHHEEFEODGH<, >.AJLNAKOPBPO))]
	private Task JDCGGFLCIJL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6338D90", Offset = "0x6337390", VA = "0x186338D90")]
	private void MBOLIFJJGIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6337F60", Offset = "0x6336560", VA = "0x186337F60", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.AppUI
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public interface IRRUISpriteLookup
	{
		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool TryFindSpriteByName(string spriteName, [Out] Sprite sprite);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DefaultMember("Item")]
public class CNIGADIEOEC<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly List<T> OLEDHEBBJPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private HashSet<T> IAPBGHPGJBH;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int CMIOJAJFIMN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x408CB60", Offset = "0x408B160", VA = "0x18408CB60", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool DJCGEFIJFFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xA34DD0", Offset = "0xA333D0", VA = "0x180A34DD0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public T OEMFNNCKNFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x3CA6920", Offset = "0x3CA4F20", VA = "0x183CA6920", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x67D7E00", Offset = "0x67D6400", VA = "0x1867D7E00", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x49F7FC0", Offset = "0x49F65C0", VA = "0x1849F7FC0", Slot = "11")]
	public void Add(T HOJKNIMMINF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x67D72F0", Offset = "0x67D58F0", VA = "0x1867D72F0")]
	public bool EBIHDMMAINL(T HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x67D7AE0", Offset = "0x67D60E0", VA = "0x1867D7AE0", Slot = "15")]
	public bool Remove(T HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x49ACEF0", Offset = "0x49AB4F0", VA = "0x1849ACEF0", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x4A2AB80", Offset = "0x4A29180", VA = "0x184A2AB80", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x67D71A0", Offset = "0x67D57A0", VA = "0x1867D71A0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x67D7240", Offset = "0x67D5840", VA = "0x1867D7240", Slot = "13")]
	public bool Contains(T HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x67D7290", Offset = "0x67D5890", VA = "0x1867D7290", Slot = "14")]
	public void CopyTo(T[] NBBLCIBNPBK, int DDFLLHIGBFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x50A2B10", Offset = "0x50A1110", VA = "0x1850A2B10", Slot = "6")]
	public int IndexOf(T HOJKNIMMINF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x67D7640", Offset = "0x67D5C40", VA = "0x1867D7640", Slot = "7")]
	public void Insert(int OHHMJGCBCKD, T HOJKNIMMINF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x67D7780", Offset = "0x67D5D80", VA = "0x1867D7780", Slot = "8")]
	public void RemoveAt(int OHHMJGCBCKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x67D7BA0", Offset = "0x67D61A0", VA = "0x1867D7BA0")]
	public CNIGADIEOEC()
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
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		[SerializeField]
		private byte[] bytes;

		[NonSerialized]
		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		private Guid _value;

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public Guid Value
		{
			[Cpp2IlInjected.Token(Token = "0x60000CC")]
			[Cpp2IlInjected.Address(RVA = "0x29C6C80", Offset = "0x29C5280", VA = "0x1829C6C80")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x24DA130", Offset = "0x24D8730", VA = "0x1824DA130")]
		public SerializedGuid([In] Guid DGNNPFFMIEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7BF8D00", Offset = "0x7BF7300", VA = "0x187BF8D00")]
		public static SerializedGuid FGFFHJFPMHM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7BF8D90", Offset = "0x7BF7390", VA = "0x187BF8D90")]
		public static SerializedGuid KKNAIOBAEHP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7BF8E00", Offset = "0x7BF7400", VA = "0x187BF8E00")]
		public bool NOJJAOAIMCB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7BF8EE0", Offset = "0x7BF74E0", VA = "0x187BF8EE0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x7BF8E60", Offset = "0x7BF7460", VA = "0x187BF8E60", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x7BF8C30", Offset = "0x7BF7230", VA = "0x187BF8C30", Slot = "7")]
		public bool Equals(SerializedGuid MIJLJBIHDMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x7BF8C70", Offset = "0x7BF7270", VA = "0x187BF8C70", Slot = "0")]
		public override bool Equals(object BOMDCGFKGKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x7BF8D80", Offset = "0x7BF7380", VA = "0x187BF8D80", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x7BF8C00", Offset = "0x7BF7200", VA = "0x187BF8C00", Slot = "6")]
		public int CompareTo(SerializedGuid MIJLJBIHDMP)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class LGBDLFCHIKO : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly Type KIIFHJNHBLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly string CDABGPDCHBC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly bool GJDFJBIGBHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly bool EKOAAJENINA;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7BF75F0", Offset = "0x7BF5BF0", VA = "0x187BF75F0")]
	public LGBDLFCHIKO(Type MFOMHCJCEOD, string KJPHDNPHOGG, bool GOBJGOHONNC = false, bool LEFCPPNMNLE = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface OLGMFAJNLME<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	int AEJOAGMOOLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<T> EBJLCJPKBML(float EPGNCELGAFP, [Optional] float? ANGACKADLAM);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool CFIIEABGMCD(float EPGNCELGAFP, T OHLIHBDBKCE);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void INBDHNEFJBE();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[Obsolete("Use ITimeSeriesRollingWindow<T> instead")]
public class OBAHHFJPMPC<T> : OLGMFAJNLME<T>
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private class GMNPPDBMANI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public float MDGNLFFDOMA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public T FPGFCMMHMJG;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public GMNPPDBMANI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class OPOGGMGLGFP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public OPOGGMGLGFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x5553890", Offset = "0x5551E90", VA = "0x185553890")]
		internal bool OJBCPELIKBK(GMNPPDBMANI sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly float PKJGIBFEPHG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly float KNABOFMFAAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private List<GMNPPDBMANI> IJEHPOHJIOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private BNJDBKKIAKE<GMNPPDBMANI> OEEDMDLCHDL;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int AEJOAGMOOLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x5515710", Offset = "0x5513D10", VA = "0x185515710", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x55157F0", Offset = "0x5513DF0", VA = "0x1855157F0")]
	public OBAHHFJPMPC(float JMOAINMKOFN, float FABKPLEELCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x5514A40", Offset = "0x5513040", VA = "0x185514A40", Slot = "6")]
	public bool CFIIEABGMCD(float EPGNCELGAFP, T OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x5514DD0", Offset = "0x55133D0", VA = "0x185514DD0", Slot = "5")]
	public IEnumerable<T> EBJLCJPKBML(float EPGNCELGAFP, float? ANGACKADLAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x55154B0", Offset = "0x5513AB0", VA = "0x1855154B0", Slot = "7")]
	public void INBDHNEFJBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x5515560", Offset = "0x5513B60", VA = "0x185515560")]
	private void MBLPGEBDFGI(float EPGNCELGAFP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class GCOCBCNAICG<T> : OLGMFAJNLME<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private readonly struct BBPDKJGKMMB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public readonly T FPGFCMMHMJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public readonly float MDGNLFFDOMA;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x45203F0", Offset = "0x451E9F0", VA = "0x1845203F0")]
		public BBPDKJGKMMB(T OHLIHBDBKCE, float EPGNCELGAFP)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class KKGDIFFEFGI : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public GCOCBCNAICG<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public float <>3__time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private float? minTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public float? <>3__minTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private int <count>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000072")]
		private int <i>5__3;

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F4")]
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000031")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xE9CA20", Offset = "0xE9B020", VA = "0x180E9CA20")]
		[DebuggerHidden]
		public KKGDIFFEFGI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x5017A70", Offset = "0x5016070", VA = "0x185017A70", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x5017E00", Offset = "0x5016400", VA = "0x185017E00", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x5017D20", Offset = "0x5016320", VA = "0x185017D20", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x4A648B0", Offset = "0x4A62EB0", VA = "0x184A648B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly float JMOAINMKOFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly float FABKPLEELCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly List<BBPDKJGKMMB> IJEHPOHJIOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int NGFMNKONPKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private int MNLADNCOCAL;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public int AEJOAGMOOLI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x9EAC90", Offset = "0x9E9290", VA = "0x1809EAC90", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x4AA8D70", Offset = "0x4AA7370", VA = "0x184AA8D70")]
	public GCOCBCNAICG(float JMOAINMKOFN, float FABKPLEELCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x4AA8780", Offset = "0x4AA6D80", VA = "0x184AA8780", Slot = "6")]
	public bool CFIIEABGMCD(float EPGNCELGAFP, T OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x4AA8D20", Offset = "0x4AA7320", VA = "0x184AA8D20", Slot = "8")]
	public int ONIGNBHFPKD(float EPGNCELGAFP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x4AA8C00", Offset = "0x4AA7200", VA = "0x184AA8C00", Slot = "5")]
	[IteratorStateMachine(typeof(GCOCBCNAICG<>.KKGDIFFEFGI))]
	public IEnumerable<T> EBJLCJPKBML(float EPGNCELGAFP, float? ANGACKADLAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x4AA8CC0", Offset = "0x4AA72C0", VA = "0x184AA8CC0", Slot = "7")]
	public void INBDHNEFJBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x4AA8A40", Offset = "0x4AA7040", VA = "0x184AA8A40")]
	private void DDLBHNAPPKJ(float EPGNCELGAFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x4AA8B30", Offset = "0x4AA7130", VA = "0x184AA8B30")]
	private BBPDKJGKMMB DFNFOJOJABD()
	{
		return default(BBPDKJGKMMB);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class LDCGKGNFMMI<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public readonly struct GIIEEMBKJKE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public readonly long FAJHKGBHFNJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public readonly long ACJGMFMAPGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public readonly int DGECAFEDAOD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public readonly int PAPAJLFGGGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public readonly bool PKKKOLOEADF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly string KEBFMIBJDMG;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x4AC0C30", Offset = "0x4ABF230", VA = "0x184AC0C30")]
		public GIIEEMBKJKE(long FAJHKGBHFNJ, int DGECAFEDAOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x4AC0CA0", Offset = "0x4ABF2A0", VA = "0x184AC0CA0")]
		public GIIEEMBKJKE(long FAJHKGBHFNJ, long ACJGMFMAPGN, int DGECAFEDAOD, int PAPAJLFGGGB, bool PKKKOLOEADF, string KEBFMIBJDMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x4AC0BE0", Offset = "0x4ABF1E0", VA = "0x184AC0BE0")]
		public int PEMOBIMANMF()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x4AC0BC0", Offset = "0x4ABF1C0", VA = "0x184AC0BC0")]
		public int PDOLLJIBCGC(int COCEFBEJJAI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x4AC0B60", Offset = "0x4ABF160", VA = "0x184AC0B60")]
		public double PCOPLMJKAHG()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x4AC0AC0", Offset = "0x4ABF0C0", VA = "0x184AC0AC0")]
		public GIIEEMBKJKE GCBKICGIOEI(long ACJGMFMAPGN, int PAPAJLFGGGB)
		{
			return default(GIIEEMBKJKE);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class CKHHEKIPJDF : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[CompilerGenerated]
		private struct CJBHLEJPBFD<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public CKHHEKIPJDF <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public Func<CKHHEKIPJDF, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private CKHHEKIPJDF <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x67CECE0", Offset = "0x67CD2E0", VA = "0x1867CECE0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x44F9550", Offset = "0x44F7B50", VA = "0x1844F9550", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public readonly TKey LCHJEPJMOOO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private readonly LDCGKGNFMMI<TKey> DCCJGOAMNIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public readonly JBBHIJHGEPM PAJIGEJCNAP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private List<CKHHEKIPJDF> ODJGJKGMDMH;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public string PLCJNPJMOAB
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x5AAAFE0", Offset = "0x5AA95E0", VA = "0x185AAAFE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public IEnumerable<CKHHEKIPJDF> CKOCFIAIKJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x67D2A40", Offset = "0x67D1040", VA = "0x1867D2A40")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public GIIEEMBKJKE EMPOHNHBPKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x67D25F0", Offset = "0x67D0BF0", VA = "0x1867D25F0")]
			[CompilerGenerated]
			get
			{
				return default(GIIEEMBKJKE);
			}
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x67D2860", Offset = "0x67D0E60", VA = "0x1867D2860")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x67D2A80", Offset = "0x67D1080", VA = "0x1867D2A80")]
		internal CKHHEKIPJDF(LDCGKGNFMMI<TKey> DCCJGOAMNIL, TKey OEHHKNIGGMI, JBBHIJHGEPM PAJIGEJCNAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x67D2890", Offset = "0x67D0E90", VA = "0x1867D2890")]
		public CKHHEKIPJDF LGCKMCLLPBB(TKey OEHHKNIGGMI, [Optional] JBBHIJHGEPM? LOHAHHGGBOK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x3CA5B30", Offset = "0x3CA4130", VA = "0x183CA5B30")]
		[AsyncStateMachine(typeof(CJBHLEJPBFD<>))]
		public Task<T> FBMBODPAFOA<T>(TKey OEHHKNIGGMI, Func<CKHHEKIPJDF, Task<T>> NPLDOOBBCLG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x67D2610", Offset = "0x67D0C10", VA = "0x1867D2610", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class CGDBJDCFFGJ : IEnumerable<(TKey, List<TKey>, GIIEEMBKJKE)>, IEnumerable, IEnumerator<(TKey, List<TKey>, GIIEEMBKJKE)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private (TKey key, List<TKey> path, GIIEEMBKJKE timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public LDCGKGNFMMI<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private IEnumerator<(TKey key, List<TKey> path, GIIEEMBKJKE timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		private (TKey, List<TKey>, GIIEEMBKJKE) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x29B9A20", Offset = "0x29B8020", VA = "0x1829B9A20", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, GIIEEMBKJKE));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x67AAE00", Offset = "0x67A9400", VA = "0x1867AAE00", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x29B9B10", Offset = "0x29B8110", VA = "0x1829B9B10")]
		[DebuggerHidden]
		public CGDBJDCFFGJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x49F97D0", Offset = "0x49F7DD0", VA = "0x1849F97D0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x67AA940", Offset = "0x67A8F40", VA = "0x1867AA940", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x67AA8F0", Offset = "0x67A8EF0", VA = "0x1867AA8F0")]
		private void KILKBHNKCHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x67AADB0", Offset = "0x67A93B0", VA = "0x1867AADB0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x67AACE0", Offset = "0x67A92E0", VA = "0x1867AACE0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, GIIEEMBKJKE)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x40AB2C0", Offset = "0x40A98C0", VA = "0x1840AB2C0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class KJICIBEPCAN : IEnumerable<(TKey, List<TKey>, GIIEEMBKJKE)>, IEnumerable, IEnumerator<(TKey, List<TKey>, GIIEEMBKJKE)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private (TKey key, List<TKey> path, GIIEEMBKJKE timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000096")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private CKHHEKIPJDF timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public CKHHEKIPJDF <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public LDCGKGNFMMI<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private IEnumerator<CKHHEKIPJDF> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private IEnumerator<(TKey key, List<TKey> path, GIIEEMBKJKE timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		private (TKey, List<TKey>, GIIEEMBKJKE) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x29B9A20", Offset = "0x29B8020", VA = "0x1829B9A20", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, GIIEEMBKJKE));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x500FCE0", Offset = "0x500E2E0", VA = "0x18500FCE0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x29B9B10", Offset = "0x29B8110", VA = "0x1829B9B10")]
		[DebuggerHidden]
		public KJICIBEPCAN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x500FD40", Offset = "0x500E340", VA = "0x18500FD40", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x500F330", Offset = "0x500D930", VA = "0x18500F330", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x500F2D0", Offset = "0x500D8D0", VA = "0x18500F2D0")]
		private void KILKBHNKCHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x500FAF0", Offset = "0x500E0F0", VA = "0x18500FAF0")]
		private void PJDCPOGKKBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x500FC90", Offset = "0x500E290", VA = "0x18500FC90", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x500FB50", Offset = "0x500E150", VA = "0x18500FB50", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, GIIEEMBKJKE)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x500FC50", Offset = "0x500E250", VA = "0x18500FC50", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Action<TKey, GIIEEMBKJKE, JBBHIJHGEPM> PAJIOJGBFLE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly Action<TKey, GIIEEMBKJKE, JBBHIJHGEPM> MJODGLPGLIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly Action<LDCGKGNFMMI<TKey>, JBBHIJHGEPM> HBDCHLJNKMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly JBBHIJHGEPM PAJIGEJCNAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly CKHHEKIPJDF AOHNPEPHKHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private bool CIAFEFCBLPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private int LPGMGJNFNMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly Stopwatch GNFGHEJOPEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly int EEBJDDKBKLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private string DLHICONLALK;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public CKHHEKIPJDF OJLOAACDDCE
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x9EB510", Offset = "0x9E9B10", VA = "0x1809EB510")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	[NotNull]
	public string PLCJNPJMOAB
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x9EE6F0", Offset = "0x9ECCF0", VA = "0x1809EE6F0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x5103670", Offset = "0x5101C70", VA = "0x185103670")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x5103750", Offset = "0x5101D50", VA = "0x185103750")]
	public LDCGKGNFMMI(TKey KEPAHPNECDC, JBBHIJHGEPM PAJIGEJCNAP, [Optional] int? DGECAFEDAOD, [Optional][CanBeNull] Stopwatch GNFGHEJOPEM, [Optional] Action<TKey, GIIEEMBKJKE, JBBHIJHGEPM> PAJIOJGBFLE, [Optional] Action<TKey, GIIEEMBKJKE, JBBHIJHGEPM> MJODGLPGLIM, [Optional] Action<LDCGKGNFMMI<TKey>, JBBHIJHGEPM> HBDCHLJNKMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x51035A0", Offset = "0x5101BA0", VA = "0x1851035A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x5103420", Offset = "0x5101A20", VA = "0x185103420")]
	[IteratorStateMachine(typeof(LDCGKGNFMMI<>.CGDBJDCFFGJ))]
	public IEnumerable<(TKey, List<TKey>, GIIEEMBKJKE)> BEHLMKMGCLO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x51034C0", Offset = "0x5101AC0", VA = "0x1851034C0")]
	[IteratorStateMachine(typeof(LDCGKGNFMMI<>.KJICIBEPCAN))]
	private IEnumerable<(TKey, List<TKey>, GIIEEMBKJKE)> BEHLMKMGCLO(List<TKey> IGFKNGAMFIG, CKHHEKIPJDF MCLBGLJLFCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x51036D0", Offset = "0x5101CD0", VA = "0x1851036D0")]
	private (long, int) NPFDHBBPODK()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public abstract class CIGFNGICIPH<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut BKMNGMHFDIG(LDCGKGNFMMI<TKey> DCCJGOAMNIL);

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	protected CIGFNGICIPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public abstract class OIJCIJBFHAF<TKey> : CIGFNGICIPH<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public delegate string ANGFAPGHIFG(TKey OEHHKNIGGMI);

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x553DA80", Offset = "0x553C080", VA = "0x18553DA80")]
	private static string FLBLFBLDMFN(TKey OEHHKNIGGMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x553D9A0", Offset = "0x553BFA0", VA = "0x18553D9A0", Slot = "4")]
	public override string BKMNGMHFDIG(LDCGKGNFMMI<TKey> DCCJGOAMNIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x553D850", Offset = "0x553BE50", VA = "0x18553D850")]
	public string BKMNGMHFDIG(LDCGKGNFMMI<TKey> DCCJGOAMNIL, [NotNull] ANGFAPGHIFG AOKHCIEGKHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string ILJGBKFGBMA(LDCGKGNFMMI<TKey> DCCJGOAMNIL, [NotNull] ANGFAPGHIFG AOKHCIEGKHD);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x4520960", Offset = "0x451EF60", VA = "0x184520960")]
	protected OIJCIJBFHAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class NEOBNBDMFBE<TKey> : CIGFNGICIPH<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public delegate string KHPDKNOBJCO(TKey OEHHKNIGGMI);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly string AOLBOEAAAKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly double MIHCOBDANEO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly bool JPKBNHMMECK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly int MGLELLPMPDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly ISet<string> KENHPKJIKFE;

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x53DAAA0", Offset = "0x53D90A0", VA = "0x1853DAAA0")]
	private static string FLBLFBLDMFN(TKey OEHHKNIGGMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x53DAEB0", Offset = "0x53D94B0", VA = "0x1853DAEB0")]
	public NEOBNBDMFBE(string AOLBOEAAAKC = "F2", double MIHCOBDANEO = double.MaxValue, bool JPKBNHMMECK = false, int MGLELLPMPDJ = int.MaxValue, [Optional] ISet<string> KENHPKJIKFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x53DA8E0", Offset = "0x53D8EE0", VA = "0x1853DA8E0", Slot = "4")]
	public override Dictionary<string, string> BKMNGMHFDIG(LDCGKGNFMMI<TKey> DCCJGOAMNIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x53DA9C0", Offset = "0x53D8FC0", VA = "0x1853DA9C0")]
	private bool CGBMPKDKIIH(string EMJGDNEIDKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x53DA2A0", Offset = "0x53D88A0", VA = "0x1853DA2A0")]
	public Dictionary<string, string> BKMNGMHFDIG(LDCGKGNFMMI<TKey> DCCJGOAMNIL, KHPDKNOBJCO AOKHCIEGKHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x53DAC40", Offset = "0x53D9240", VA = "0x1853DAC40")]
	private string OKJBEPDBEEB(StringBuilder EDJHPMEPCCE, List<TKey> PPFBAOLBBPC, KHPDKNOBJCO AOKHCIEGKHD, bool NAGJEBLOGML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x53DAAE0", Offset = "0x53D90E0", VA = "0x1853DAAE0")]
	private static void JPIHDIDNALC(StringBuilder DGGMLAEEEDP, string OICFJFAEMJB, bool NKBMFJNILBG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class COOLPEMNBIP<TKey> : OIJCIJBFHAF<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct AEOALEMFGDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public ANGFAPGHIFG keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public static COOLPEMNBIP<TKey> MLIJHBGBMKP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly string[] LPFANOGMKLD;

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x67DE420", Offset = "0x67DCA20", VA = "0x1867DE420")]
	private COOLPEMNBIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x67DD4C0", Offset = "0x67DBAC0", VA = "0x1867DD4C0", Slot = "5")]
	protected override string ILJGBKFGBMA(LDCGKGNFMMI<TKey> DCCJGOAMNIL, ANGFAPGHIFG AOKHCIEGKHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x67DD3C0", Offset = "0x67DB9C0", VA = "0x1867DD3C0")]
	[CompilerGenerated]
	internal static string ABFIDLAECLF(string IHOCGIFBFOG, TKey OEHHKNIGGMI, AEOALEMFGDB P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public sealed class EEEGNIHNGIE : LDCGKGNFMMI<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class BCOPDCNOAFH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Action<EEEGNIHNGIE, JBBHIJHGEPM> callback;

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public BCOPDCNOAFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x7BF4A50", Offset = "0x7BF3050", VA = "0x187BF4A50")]
		internal void HNHAFOLDMAP(LDCGKGNFMMI<string> timer, JBBHIJHGEPM log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x7BF51E0", Offset = "0x7BF37E0", VA = "0x187BF51E0")]
	public EEEGNIHNGIE(JBBHIJHGEPM PAJIGEJCNAP, [Optional] string FPFAFHGGBCN, [Optional] int? DGECAFEDAOD, [Optional] Stopwatch GNFGHEJOPEM, [Optional] Action<string, GIIEEMBKJKE, JBBHIJHGEPM> PAJIOJGBFLE, [Optional] Action<string, GIIEEMBKJKE, JBBHIJHGEPM> MJODGLPGLIM, [Optional] Action<EEEGNIHNGIE, JBBHIJHGEPM> HBDCHLJNKMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x7BF5120", Offset = "0x7BF3720", VA = "0x187BF5120")]
	private static Action<LDCGKGNFMMI<string>, JBBHIJHGEPM> HINACHCHCON(Action<EEEGNIHNGIE, JBBHIJHGEPM> COLEJLDPDCO)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public abstract class CGIFFNJCPHF
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private class EGIKJEMLIBI : CGIFFNJCPHF
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public static CGIFFNJCPHF MLIJHBGBMKP
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x7BF5330", Offset = "0x7BF3930", VA = "0x187BF5330")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override float OJMJBBKEHNG
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x11E6500", Offset = "0x11E4B00", VA = "0x1811E6500", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7BF5420", Offset = "0x7BF3A20", VA = "0x187BF5420")]
		public EGIKJEMLIBI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private static CGIFFNJCPHF BNDLEJCINJA;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public static CGIFFNJCPHF OPJKGEJPJBC
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x7BF4CB0", Offset = "0x7BF32B0", VA = "0x187BF4CB0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public abstract float OJMJBBKEHNG
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	protected CGIFFNJCPHF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface KBJDIMPKBHI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	bool NAKOJHKEHHA
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface GKHPBLLBAIL<T> : KBJDIMPKBHI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000040")]
	[NotNull]
	Task<T> IJODDLOIILC
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	[NotNull]
	KGAPFDAFEHM<T> EGIIHJEIKEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class FCHILKOGDEH
{
	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x3858BB0", Offset = "0x38571B0", VA = "0x183858BB0")]
	public static GKHPBLLBAIL<TResource> IICAPLJDDNG<TResource, TId>(this DCMNDOHINLE<TId, TResource> FEHNEKGGBGC, TId HJPLNJNIFLL, [Optional] Func<TId, CancellationToken, Task<TResource>>? CBBEBIHJHCE) where TResource : notnull where TId : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class KKDMMMKGLAO
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private sealed class OKBLDIIOBDB<T> : KILOAPHPNHN<T?> where T : class
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override Task<T?> IJODDLOIILC
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override KGAPFDAFEHM<T?> EGIIHJEIKEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x5540B80", Offset = "0x553F180", VA = "0x185540B80")]
		public OKBLDIIOBDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "10")]
		protected override void OOJMHCEGIPO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private sealed class KGNKHKPFHFK<T> : KILOAPHPNHN<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly T HHFHEIMGHGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly Action<T>? EJKMLLMKNIN;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override Task<T> IJODDLOIILC
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x9EB780", Offset = "0x9E9D80", VA = "0x1809EB780", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override KGAPFDAFEHM<T> EGIIHJEIKEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x9F0820", Offset = "0x9EEE20", VA = "0x1809F0820", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x5005A90", Offset = "0x5004090", VA = "0x185005A90")]
		public KGNKHKPFHFK(T LJEENFPIGIA, Action<T>? AAMIKNLELJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x5005850", Offset = "0x5003E50", VA = "0x185005850", Slot = "10")]
		protected override void OOJMHCEGIPO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private sealed class OJMLJMDMOOF<T> : KILOAPHPNHN<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override Task<T> IJODDLOIILC
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override KGAPFDAFEHM<T> EGIIHJEIKEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x55409F0", Offset = "0x553EFF0", VA = "0x1855409F0")]
		public OJMLJMDMOOF(Exception GGOAKKKDCJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "10")]
		protected override void OOJMHCEGIPO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private sealed class AJCGPDOGGKI<T> : KILOAPHPNHN<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private struct DKLEJHBPBPI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public Task<GKHPBLLBAIL<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private TaskAwaiter<GKHPBLLBAIL<T>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			private TaskAwaiter<T> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x6A45B00", Offset = "0x6A44100", VA = "0x186A45B00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x6A46000", Offset = "0x6A44600", VA = "0x186A46000", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[CompilerGenerated]
		private struct DDHILFJLJIE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public Task<GKHPBLLBAIL<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private TaskAwaiter<GKHPBLLBAIL<T>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x6A37020", Offset = "0x6A35620", VA = "0x186A37020", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x6A37480", Offset = "0x6A35A80", VA = "0x186A37480", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private readonly Task<GKHPBLLBAIL<T>> PNCLEEGHOIJ;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override Task<T> IJODDLOIILC
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override KGAPFDAFEHM<T> EGIIHJEIKEG
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x9EB550", Offset = "0x9E9B50", VA = "0x1809EB550", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x4C7B6C0", Offset = "0x4C79CC0", VA = "0x184C7B6C0")]
		public AJCGPDOGGKI(Task<GKHPBLLBAIL<T>> BGKKDAHMDLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x4C7B5A0", Offset = "0x4C79BA0", VA = "0x184C7B5A0", Slot = "10")]
		protected override void OOJMHCEGIPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x4C7B100", Offset = "0x4C79700", VA = "0x184C7B100")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(AJCGPDOGGKI<>.DKLEJHBPBPI))]
		internal static Task<T> CIEKCBHCMDG(Task<GKHPBLLBAIL<T>> BGKKDAHMDLM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x4C7B4C0", Offset = "0x4C79AC0", VA = "0x184C7B4C0")]
		[AsyncStateMachine(typeof(AJCGPDOGGKI<>.DDHILFJLJIE))]
		[CompilerGenerated]
		internal static Task NOEMKPBOJMN(Task<GKHPBLLBAIL<T>> BGKKDAHMDLM)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private sealed class EDHEJEIMPBC<TIn, TOut> : KILOAPHPNHN<TOut> where TIn : notnull where TOut : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000050")]
		[CompilerGenerated]
		private struct DOCGPFCBNJK : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C2")]
			public AsyncTaskMethodBuilder<TOut> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C3")]
			public Func<TIn, TOut> transformFunc;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C4")]
			public Task<TIn> innerTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C5")]
			private Func<TIn, TOut> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			private TaskAwaiter<TIn> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600016A")]
			[Cpp2IlInjected.Address(RVA = "0x6A4E310", Offset = "0x6A4C910", VA = "0x186A4E310", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x452D920", Offset = "0x452BF20", VA = "0x18452D920", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private readonly GKHPBLLBAIL<TIn> POMOGDOFIHL;

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public override Task<TOut> IJODDLOIILC
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public override KGAPFDAFEHM<TOut> EGIIHJEIKEG
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x9EB550", Offset = "0x9E9B50", VA = "0x1809EB550", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x44FAD50", Offset = "0x44F9350", VA = "0x1844FAD50")]
		public EDHEJEIMPBC(GKHPBLLBAIL<TIn> DJINKFAKHDB, Func<TIn, TOut> JFBCMFKBFGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x44FACB0", Offset = "0x44F92B0", VA = "0x1844FACB0", Slot = "10")]
		protected override void OOJMHCEGIPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x44FA9B0", Offset = "0x44F8FB0", VA = "0x1844FA9B0")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(EDHEJEIMPBC<, >.DOCGPFCBNJK))]
		internal static Task<TOut> OJHNGICMHGA(Task<TIn> JMCJINFHCPM, Func<TIn, TOut> JFBCMFKBFGD)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x390C780", Offset = "0x390AD80", VA = "0x18390C780")]
	public static GKHPBLLBAIL<T> KKKNNENCOAG<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x390C800", Offset = "0x390AE00", VA = "0x18390C800")]
	public static GKHPBLLBAIL<T> LLKNAJOIBFC<T>(T OBOOAPELMPF, [Optional] Action<T>? AAMIKNLELJB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x36C4FE0", Offset = "0x36C35E0", VA = "0x1836C4FE0")]
	public static GKHPBLLBAIL<T> JNFNLNKDDKN<T>(Exception GGOAKKKDCJN) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x36C4FE0", Offset = "0x36C35E0", VA = "0x1836C4FE0")]
	public static GKHPBLLBAIL<T> MPGIFLAHCPM<T>(Task<GKHPBLLBAIL<T>> BGKKDAHMDLM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x37041B0", Offset = "0x37027B0", VA = "0x1837041B0")]
	public static GKHPBLLBAIL<TOut> IOFGLPCMIME<TOut, TIn>(GKHPBLLBAIL<TIn> BOJCEMEJOMP, Func<TIn, TOut> JFBCMFKBFGD) where TOut : notnull where TIn : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public abstract class KILOAPHPNHN<T> : GKHPBLLBAIL<T>, KBJDIMPKBHI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly string MFEEFOFBDMF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private readonly JMJECAHGFJF DLDCNIOFMNE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private bool CIAFEFCBLPC;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool NAKOJHKEHHA
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0xC8F7F0", Offset = "0xC8DDF0", VA = "0x180C8F7F0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public abstract Task<T> IJODDLOIILC
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public abstract KGAPFDAFEHM<T> EGIIHJEIKEG
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x500D860", Offset = "0x500BE60", VA = "0x18500D860")]
	public KILOAPHPNHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x500D4D0", Offset = "0x500BAD0", VA = "0x18500D4D0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void OOJMHCEGIPO();
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public abstract class GFMCNLLODOK<TTask, T> : KILOAPHPNHN<T> where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class LGEMMOGNKGN
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000054")]
		private struct <<-ctor>g__AwaitThenTransformTaskResult|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CF")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D0")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D1")]
			public TTask originalTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D2")]
			public LGEMMOGNKGN <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x407AF50", Offset = "0x4079550", VA = "0x18407AF50", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x407B210", Offset = "0x4079810", VA = "0x18407B210", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public GFMCNLLODOK<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public LGEMMOGNKGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x513B8D0", Offset = "0x5139ED0", VA = "0x18513B8D0")]
		[AsyncStateMachine(typeof(GFMCNLLODOK<, >.LGEMMOGNKGN.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> MILBIMBKPAD(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Task<T> BGKKDAHMDLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	protected readonly CancellationTokenSource CLDKCMPEHDC;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public override Task<T> IJODDLOIILC
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public override KGAPFDAFEHM<T> EGIIHJEIKEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x4AB3040", Offset = "0x4AB1640", VA = "0x184AB3040")]
	protected GFMCNLLODOK(TTask BGKKDAHMDLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x4AB2DF0", Offset = "0x4AB13F0", VA = "0x184AB2DF0", Slot = "10")]
	protected override void OOJMHCEGIPO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract T JJMIGMFGBMB(TTask KBOFPPNJEHF);

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "12")]
	protected abstract void OAEBBEFCKCM();
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class MCEGMPENJEF<T> : KILOAPHPNHN<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly CLCFAKNAJCK<Task<T>> KPGBMDPBJGE;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public override Task<T> IJODDLOIILC
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x4998BE0", Offset = "0x49971E0", VA = "0x184998BE0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public override KGAPFDAFEHM<T> EGIIHJEIKEG
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x532E270", Offset = "0x532C870", VA = "0x18532E270")]
	public MCEGMPENJEF(CLCFAKNAJCK<Task<T>> GBHMCDAPJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x532E250", Offset = "0x532C850", VA = "0x18532E250", Slot = "10")]
	protected override void OOJMHCEGIPO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class ELCCNOCMEFE
{
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public static readonly HashAlgorithmName GBKAPNFGLEN;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static readonly ThreadLocal<IncrementalHash> BDJLDKBHCKM;

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x7BF5470", Offset = "0x7BF3A70", VA = "0x187BF5470")]
	public static int AOIHFEDMPNN(this EJMDGDGNKJJ NDBNPOHKMHJ, IncrementalHash CNOOJBJPLMK, byte[] KFJFCJKAIMO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x7BF5BE0", Offset = "0x7BF41E0", VA = "0x187BF5BE0")]
	public static bool NLCCKIDEGGG([CanBeNull] this EJMDGDGNKJJ NDBNPOHKMHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x7BF5590", Offset = "0x7BF3B90", VA = "0x187BF5590")]
	public static bool NLCCKIDEGGG([CanBeNull] this EJMDGDGNKJJ NDBNPOHKMHJ, [Out] string JHEMEKBLBHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x7BF58A0", Offset = "0x7BF3EA0", VA = "0x187BF58A0")]
	public static bool NLCCKIDEGGG([CanBeNull] this EJMDGDGNKJJ NDBNPOHKMHJ, IncrementalHash CNOOJBJPLMK, byte[] KFJFCJKAIMO, [Out] string JHEMEKBLBHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x7BF5500", Offset = "0x7BF3B00", VA = "0x187BF5500")]
	private static bool LBAIKBOCCMP(byte[] JKLKIJJHOOF, Span<byte> DOGJODDEIFE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class CNEOFNBHKHD
{
	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x7BF4E10", Offset = "0x7BF3410", VA = "0x187BF4E10")]
	public static int CMFADHJCKNM(HashAlgorithmName FOECKGNFIID)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x3675F10", Offset = "0x3674510", VA = "0x183675F10")]
	public static int AOIHFEDMPNN<T>(this T OEJCHKIAEOP, byte[] OKILAJMHAEB, IncrementalHash CNOOJBJPLMK, byte[] JHPJJKPJGIN) where T : MFJKOPKJMGJ
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface MFJKOPKJMGJ
{
	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash CNOOJBJPLMK);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface EJMDGDGNKJJ : MFJKOPKJMGJ
{
	[Cpp2IlInjected.Token(Token = "0x17000053")]
	[CanBeNull]
	byte[] BCAOEDPMJFG
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	[CanBeNull]
	byte[] KBGGKMBIMFO
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class FCFHCMLEJJA
{
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static bool CCALPNEGEJD;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly ArrayPool<byte> MFEALHPLKJJ;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly ArrayPool<char> FKPOIDELFJH;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly Encoding EICNJEAELIG;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly ThreadLocal<Encoder> JDHEGFBKIHN;

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x38584C0", Offset = "0x3856AC0", VA = "0x1838584C0")]
	public static void NJGJGEAOBMF<T>(this IncrementalHash FOFBMAJGNBJ, [CanBeNull] T HABFEKNHDFB) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x3857F10", Offset = "0x3856510", VA = "0x183857F10")]
	public static void JADKJPDOKAL<T>(this IncrementalHash FOFBMAJGNBJ, [CanBeNull] T OEJCHKIAEOP) where T : MFJKOPKJMGJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x3857FA0", Offset = "0x38565A0", VA = "0x183857FA0")]
	public static void LONIFHELBOC<T>(this IncrementalHash FOFBMAJGNBJ, [CanBeNull] IList<T> MDIHNBCKKBB) where T : MFJKOPKJMGJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x7BF6520", Offset = "0x7BF4B20", VA = "0x187BF6520")]
	private static bool EKMICEANEBI([CanBeNull] MFJKOPKJMGJ OEJCHKIAEOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x7BF6120", Offset = "0x7BF4720", VA = "0x187BF6120")]
	public static void EGLAKJBLCCB(this IncrementalHash CNOOJBJPLMK, string? JFHBGFEOFIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x7BF65B0", Offset = "0x7BF4BB0", VA = "0x187BF65B0")]
	public static void EOOGCGENELJ(this IncrementalHash CNOOJBJPLMK, long GPCCHDDCNJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x7BF69B0", Offset = "0x7BF4FB0", VA = "0x187BF69B0")]
	public static void LPEGADLGHBK(this IncrementalHash CNOOJBJPLMK, int LKALAMMFPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x7BF67E0", Offset = "0x7BF4DE0", VA = "0x187BF67E0")]
	public static void GNCCNEKJIFA(this IncrementalHash CNOOJBJPLMK, short HDJMAOIGMDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x7BF5FB0", Offset = "0x7BF45B0", VA = "0x187BF5FB0")]
	public static void BCJAAJCAHJL(this IncrementalHash CNOOJBJPLMK, byte LHNLFPPOHNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x7BF5E40", Offset = "0x7BF4440", VA = "0x187BF5E40")]
	public static void ANOEMAFOOKJ(this IncrementalHash CNOOJBJPLMK, bool CDKMIEFFONM, bool CFLIMHPAPHG = false, bool KEJMOFONKLI = false, bool IFPDKJHKCGA = false, bool OLNDCAKGOJB = false, bool DFGJIOABGEG = false, bool IHALKGMEGIO = false, bool KCHBBKNBJDG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x3858580", Offset = "0x3856B80", VA = "0x183858580")]
	public static void OGPFFMNHMKL<T>(this IncrementalHash CNOOJBJPLMK, T PCHMHBNEGIN) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x7BF5D80", Offset = "0x7BF4380", VA = "0x187BF5D80")]
	public static void AGMJLAICHBF(this IncrementalHash CNOOJBJPLMK, float OBIIIEEADDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x7BF5DE0", Offset = "0x7BF43E0", VA = "0x187BF5DE0")]
	public static void AMJKEBEEEEH(this IncrementalHash CNOOJBJPLMK, ulong GIEJBNNIGBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x7BF6780", Offset = "0x7BF4D80", VA = "0x187BF6780")]
	public static void FGMCLMDIPNG(this IncrementalHash CNOOJBJPLMK, uint JOHNHCMHGCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x7BF60C0", Offset = "0x7BF46C0", VA = "0x187BF60C0")]
	public static void DCHKGFJBFNJ(this IncrementalHash CNOOJBJPLMK, ushort NJBBLNAAOKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x7BF6B80", Offset = "0x7BF5180", VA = "0x187BF6B80")]
	public static void OPCDEIJOLDL(this IncrementalHash CNOOJBJPLMK, Vector3 EMNAKJMLLAC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class PBOIFHAMLJC : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x7BF77D0", Offset = "0x7BF5DD0", VA = "0x187BF77D0")]
	public PBOIFHAMLJC(string NAAMEAFIHJI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public abstract class KAOEKDKPIPC
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public delegate void MLIKPCFOPFB(ushort BNDHDJHCHFM, ushort ALBEKDCKCFL, ushort MFECHLNLCNG, ushort NNGNLCELOGG);

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public delegate void KDMNGAPOHLH(ushort CKCANEKHNDO, ushort HHFCECJGICM);

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public delegate void MKDNPGPMJEC();

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public const ushort KLKAGKMLIFG = ushort.MaxValue;

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
	protected KAOEKDKPIPC()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public abstract class LNLNIOAFPJB<T> : KAOEKDKPIPC where T : LNLNIOAFPJB<T>.FHKJCPNLAHP
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public interface FHKJCPNLAHP
	{
		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		KDMNGAPOHLH LAEGJJMFJAH
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		KDMNGAPOHLH KBJHOKBMNDG
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		MKDNPGPMJEC DFHPHCDPEKO
		{
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private Dictionary<uint, T> BDEKILIMDCB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private MKDNPGPMJEC GMLKCNPKBDK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private MKDNPGPMJEC BMHHOHFFCPM;

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool KBJPCBPOJIL
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xAB6E90", Offset = "0xAB5490", VA = "0x180AB6E90")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x9F41E0", Offset = "0x9F27E0", VA = "0x1809F41E0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public ushort HKIAMEGFMEI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x5159690", Offset = "0x5157C90", VA = "0x185159690")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x5159680", Offset = "0x5157C80", VA = "0x185159680")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public ushort IAFOLNGIPDH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x51591E0", Offset = "0x51577E0", VA = "0x1851591E0")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x5159820", Offset = "0x5157E20", VA = "0x185159820")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public ushort DGCDCEMBNKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0xDCB7D0", Offset = "0xDC9DD0", VA = "0x180DCB7D0")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0xDCB8E0", Offset = "0xDC9EE0", VA = "0x180DCB8E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public ushort BDBJIADCAOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x5159810", Offset = "0x5157E10", VA = "0x185159810")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x51591D0", Offset = "0x51577D0", VA = "0x1851591D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	protected bool NDPCDNBFANI
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x1791820", Offset = "0x178FE20", VA = "0x181791820")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	protected bool PDLMNDCONLL
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0xE9C240", Offset = "0xE9A840", VA = "0x180E9C240")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event MLIKPCFOPFB ILAGNNCHHDN
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x51592A0", Offset = "0x51578A0", VA = "0x1851592A0")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x5159700", Offset = "0x5157D00", VA = "0x185159700")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x5159510", Offset = "0x5157B10", VA = "0x185159510")]
	private T HKAFEFLBPMG(ushort EHGEBFKCFJN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x51595C0", Offset = "0x5157BC0", VA = "0x1851595C0")]
	private T IGHHCMHDLPO(ushort EHGEBFKCFJN, ushort JLKINIEJBPN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x51596A0", Offset = "0x5157CA0", VA = "0x1851596A0")]
	protected T IOEKEKIPDIB(uint EABPCDDIDGM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x5159AA0", Offset = "0x51580A0", VA = "0x185159AA0")]
	protected LNLNIOAFPJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x51594D0", Offset = "0x5157AD0", VA = "0x1851594D0")]
	public void HCAGGNMMFPB(ushort NBFPFCLEDAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x5159470", Offset = "0x5157A70", VA = "0x185159470")]
	public void HCAGGNMMFPB(ushort NBFPFCLEDAC, ushort NPBMAEKFKJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x5159360", Offset = "0x5157960", VA = "0x185159360", Slot = "4")]
	protected virtual void HCAGGNMMFPB(uint JNHCFBDFJKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x51589A0", Offset = "0x5156FA0", VA = "0x1851589A0")]
	protected void BDELHCBPDNC(uint JNHCFBDFJKN, uint IMPNBPMIBHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x51591F0", Offset = "0x51577F0", VA = "0x1851591F0")]
	protected void CIEBNDLEGFH(ushort EHGEBFKCFJN, ushort JLKINIEJBPN, T IDAKFFICKHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x51597A0", Offset = "0x5157DA0", VA = "0x1851597A0")]
	private void JOFOBNKNIKP(uint EABPCDDIDGM, T IDAKFFICKHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x5159830", Offset = "0x5157E30", VA = "0x185159830")]
	protected void OHMINKCNCLK(float CJIPMCGKHCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x5159800", Offset = "0x5157E00", VA = "0x185159800")]
	protected uint LFIFACILCCO(ushort EHGEBFKCFJN, ushort JLKINIEJBPN)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x5159350", Offset = "0x5157950", VA = "0x185159350")]
	protected ushort EOHCAHBHMJC(uint AGLEOCCBHLD)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x5159340", Offset = "0x5157940", VA = "0x185159340")]
	protected ushort CPMIJMGGPFM(uint AGLEOCCBHLD)
	{
		return default(ushort);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public abstract class FKGHIJGABNF : LNLNIOAFPJB<FKGHIJGABNF.DFAOIKNCMBF>
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class DFAOIKNCMBF : FHKJCPNLAHP
	{
		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public KDMNGAPOHLH LAEGJJMFJAH
		{
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x9EB570", Offset = "0x9E9B70", VA = "0x1809EB570", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x9EB540", Offset = "0x9E9B40", VA = "0x1809EB540")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public KDMNGAPOHLH KBJHOKBMNDG
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public MKDNPGPMJEC DFHPHCDPEKO
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x9EACB0", Offset = "0x9E92B0", VA = "0x1809EACB0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x9EACD0", Offset = "0x9E92D0", VA = "0x1809EACD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public DFAOIKNCMBF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x7BF6F20", Offset = "0x7BF5520", VA = "0x187BF6F20")]
	public void ENAFEFPGJOD(ushort BHBMPIOAMGL, KDMNGAPOHLH LLDFJBJLGLA, KDMNGAPOHLH ADOOLNILPJJ, MKDNPGPMJEC GLPILNDJAPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x7BF7000", Offset = "0x7BF5600", VA = "0x187BF7000")]
	public void ENAFEFPGJOD(ushort EHGEBFKCFJN, ushort JLKINIEJBPN, KDMNGAPOHLH LLDFJBJLGLA, KDMNGAPOHLH ADOOLNILPJJ, MKDNPGPMJEC GLPILNDJAPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x7BF70E0", Offset = "0x7BF56E0", VA = "0x187BF70E0")]
	public void IEKHBJGOAKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x7BF4C70", Offset = "0x7BF3270", VA = "0x187BF4C70")]
	protected FKGHIJGABNF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class BELFFFDFKLH : FKGHIJGABNF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private bool INLAHEKHDGL;

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool DINPHDIMOPN
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0xC17800", Offset = "0xC15E00", VA = "0x180C17800")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0xCF1F40", Offset = "0xCF0540", VA = "0x180CF1F40")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x7BF4C10", Offset = "0x7BF3210", VA = "0x187BF4C10")]
	public void ANJKPBDKBKO(ushort EPKKNLPDGFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x7BF4BB0", Offset = "0x7BF31B0", VA = "0x187BF4BB0")]
	public void ANJKPBDKBKO(ushort EPKKNLPDGFO, ushort NMFFAPHEICD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x7BF4C70", Offset = "0x7BF3270", VA = "0x187BF4C70")]
	public BELFFFDFKLH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public abstract class LNKLJKBFMLI<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	internal class DFOMKGEABGF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public TNode OCACDKEJIIB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public TNode JHDAOHEONAC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public GJLHODNMILJ AMICCGMJHBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public List<GJLHODNMILJ> FEFKNJDBJLC;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public DFOMKGEABGF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	internal struct GJLHODNMILJ : IComparable<GJLHODNMILJ>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public int DPEJEDCKJBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public TClaimant FNMMPCMKINA;

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x16451F0", Offset = "0x16437F0", VA = "0x1816451F0")]
		public GJLHODNMILJ(int DPEJEDCKJBD, TClaimant FNMMPCMKINA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x4AC38F0", Offset = "0x4AC1EF0", VA = "0x184AC38F0")]
		public bool GMLAKKFLBOI([In] GJLHODNMILJ MIJLJBIHDMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x4AC38E0", Offset = "0x4AC1EE0", VA = "0x184AC38E0")]
		public bool EIFCEJJPAAH([In] GJLHODNMILJ MIJLJBIHDMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x4AC38D0", Offset = "0x4AC1ED0", VA = "0x184AC38D0", Slot = "4")]
		public int CompareTo(GJLHODNMILJ MIJLJBIHDMP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x4AC3950", Offset = "0x4AC1F50", VA = "0x184AC3950", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public enum DEOFKAABGIP
	{
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class BJMAEDMABOA : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FE")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FF")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000100")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000101")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000102")]
		public LNKLJKBFMLI<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000064")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0xE9CA20", Offset = "0xE9B020", VA = "0x180E9CA20")]
		[DebuggerHidden]
		public BJMAEDMABOA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x9EA220", Offset = "0x9E8820", VA = "0x1809EA220", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x633BCC0", Offset = "0x633A2C0", VA = "0x18633BCC0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x633BEA0", Offset = "0x633A4A0", VA = "0x18633BEA0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x633BDA0", Offset = "0x633A3A0", VA = "0x18633BDA0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x49FAD80", Offset = "0x49F9380", VA = "0x1849FAD80", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static readonly BNJDBKKIAKE<DFOMKGEABGF> COGNIDJENEN;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private static readonly BNJDBKKIAKE<List<GJLHODNMILJ>> OKPEDGPCBAP;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private static int ICBCBEKDOON;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	internal readonly Dictionary<TClaimant, TNode> CAMFKJMIFNL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	internal readonly Dictionary<TNode, DFOMKGEABGF> BFAKEMFMAMG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private DEOFKAABGIP MECLDBHCDJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private bool DPFEMHMCJBH;

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode AGDGBBECAOP(TNode GOJJJBGJPAM);

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void AAIPHPEPPHI(TNode GOJJJBGJPAM, TClaimant IOLNECBMENK, TClaimant CCMFOKHGMEC);

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x51587F0", Offset = "0x5156DF0", VA = "0x1851587F0")]
	public LNKLJKBFMLI(DEOFKAABGIP MECLDBHCDJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x5157240", Offset = "0x5155840", VA = "0x185157240")]
	public void DEFKBCPBPOF(TNode GOJJJBGJPAM, TNode FAMAONKAFDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x5157500", Offset = "0x5155B00", VA = "0x185157500")]
	public void EIKIFGINMNF(TClaimant FNMMPCMKINA, TNode NKOAGGOOJFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x5157300", Offset = "0x5155900", VA = "0x185157300", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x5156D00", Offset = "0x5155300", VA = "0x185156D00")]
	private void CDLMAKMBBIO(TClaimant FNMMPCMKINA, TNode BGIDPOPGKNJ, TNode NKOAGGOOJFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x5157AE0", Offset = "0x51560E0", VA = "0x185157AE0")]
	private int GHGHMLNHJLJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x5157790", Offset = "0x5155D90", VA = "0x185157790")]
	private void GAAPACIDHGO(TClaimant FNMMPCMKINA, TNode MLHHCEEFKIE, TNode GPLPPJLEDDP, int JGJHENCFMAJ = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x5157C80", Offset = "0x5156280", VA = "0x185157C80")]
	private void HLDJILOLHHK(GJLHODNMILJ GLDPDMHFJNG, DFOMKGEABGF MECICAJOHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x5156F50", Offset = "0x5155550", VA = "0x185156F50")]
	private void CIDCOCCJBBD(TClaimant FNMMPCMKINA, TNode MLHHCEEFKIE, TNode GPLPPJLEDDP, int JGJHENCFMAJ = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x5157B50", Offset = "0x5156150", VA = "0x185157B50")]
	private void HGGGBIMFKDF(GJLHODNMILJ GLDPDMHFJNG, TNode GOJJJBGJPAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x51584C0", Offset = "0x5156AC0", VA = "0x1851584C0")]
	private void PEFIDHACNPJ(GJLHODNMILJ GLDPDMHFJNG, DFOMKGEABGF MECICAJOHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x5158370", Offset = "0x5156970", VA = "0x185158370")]
	private void MAENNJKDDOD(DFOMKGEABGF MECICAJOHBD, bool BLEOHBMKKAD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x5157D50", Offset = "0x5156350", VA = "0x185157D50")]
	private void JHLPLMHLEIG(DFOMKGEABGF MECICAJOHBD, TNode FAMAONKAFDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x5158280", Offset = "0x5156880", VA = "0x185158280")]
	[IteratorStateMachine(typeof(LNKLJKBFMLI<, >.BJMAEDMABOA))]
	private IEnumerable<TNode> LFODIIFACBN(TNode MLHHCEEFKIE, TNode GPLPPJLEDDP, bool PLHHHGFHKPP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x5157680", Offset = "0x5155C80", VA = "0x185157680")]
	private DFOMKGEABGF FKAEIKKBMIK(TNode GOJJJBGJPAM, TNode JHDAOHEONAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x5156DD0", Offset = "0x51553D0", VA = "0x185156DD0")]
	private DFOMKGEABGF CGLCMPPDCHC(TNode GOJJJBGJPAM, TNode JHDAOHEONAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x51580C0", Offset = "0x51566C0", VA = "0x1851580C0")]
	private void KCIIAKNPJLI(DFOMKGEABGF MECICAJOHBD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class HOBCNHIEEIJ<T> : IEnumerable<HOBCNHIEEIJ<T>.HOFJAOLMJEK>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public struct HOFJAOLMJEK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public T OHLIHBDBKCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public int OHHMJGCBCKD;
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public class BHEEPHDOGKB : IEnumerator<HOFJAOLMJEK>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private HOBCNHIEEIJ<T> DHPEMHCCIBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private int OHHMJGCBCKD;

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x4534920", Offset = "0x4532F20", VA = "0x184534920", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public HOFJAOLMJEK FFKIBMLIABP
		{
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x6337560", Offset = "0x6335B60", VA = "0x186337560", Slot = "4")]
			get
			{
				return default(HOFJAOLMJEK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x6337520", Offset = "0x6335B20", VA = "0x186337520")]
		public BHEEPHDOGKB(HOBCNHIEEIJ<T> DHPEMHCCIBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x63374A0", Offset = "0x6335AA0", VA = "0x1863374A0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x4599850", Offset = "0x4597E50", VA = "0x184599850", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x1142790", Offset = "0x1140D90", VA = "0x181142790", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	private struct KPEAKOGKEJC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public bool PHPNMCDJGEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public T OHLIHBDBKCE;
	}

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private const int HCAMNGFJAJP = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly Dictionary<T, int> MLGIIMHOAOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private KPEAKOGKEJC[] CLDEDCNEDEG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private int LCOFGKLPDPE;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public int IFKGCMOKNLB
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0xD2BF30", Offset = "0xD2A530", VA = "0x180D2BF30")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xF1E020", Offset = "0xF1C620", VA = "0x180F1E020")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public int CMIOJAJFIMN
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x408CB60", Offset = "0x408B160", VA = "0x18408CB60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x4B775D0", Offset = "0x4B75BD0", VA = "0x184B775D0")]
	public HOBCNHIEEIJ(int GDBMBEIFFOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x4B76D80", Offset = "0x4B75380", VA = "0x184B76D80")]
	public HOBCNHIEEIJ(HOFJAOLMJEK[] JFDNIJOKIAG, bool HJHCMDKKBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x4B76950", Offset = "0x4B74F50", VA = "0x184B76950")]
	public int IHKAENPJNME()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x4B760E0", Offset = "0x4B746E0", VA = "0x184B760E0")]
	private int AKABHHEBMIA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x4B76C90", Offset = "0x4B75290", VA = "0x184B76C90", Slot = "6")]
	protected virtual uint MAJBBDAIHEL(uint CNOOJBJPLMK, T OHLIHBDBKCE)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x4B76A70", Offset = "0x4B75070", VA = "0x184B76A70")]
	public bool JAOEPNGFPMK(T OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x4B76AD0", Offset = "0x4B750D0", VA = "0x184B76AD0")]
	public int KOMODOIIBMM(T OHLIHBDBKCE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x4B76C20", Offset = "0x4B75220", VA = "0x184B76C20")]
	public T LNLLCGCJJDK(int OHHMJGCBCKD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x4B76560", Offset = "0x4B74B60", VA = "0x184B76560")]
	public bool EBIHDMMAINL(T OHLIHBDBKCE, bool FONIBMLGNKN = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x4B76300", Offset = "0x4B74900", VA = "0x184B76300")]
	public bool EBIHDMMAINL(T OHLIHBDBKCE, int OHHMJGCBCKD, bool FONIBMLGNKN = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x4B768B0", Offset = "0x4B74EB0", VA = "0x184B768B0")]
	private int HGEAHADEFCP(int NGFMNKONPKM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x4B76CE0", Offset = "0x4B752E0", VA = "0x184B76CE0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x4B76CE0", Offset = "0x4B752E0", VA = "0x184B76CE0", Slot = "4")]
	private IEnumerator<HOFJAOLMJEK> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class BNJDBKKIAKE<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly Stack<T> CNODPANFMJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly List<T> FNJDGOKAJJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly int NKBLPCDBBDM;

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x633F900", Offset = "0x633DF00", VA = "0x18633F900")]
	public static BNJDBKKIAKE<T> BHOMFPFMNFM(int GDBMBEIFFOO = 0, int NKBLPCDBBDM = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x633FE90", Offset = "0x633E490", VA = "0x18633FE90")]
	public static BNJDBKKIAKE<T> HKNPNJNHIHC(int GDBMBEIFFOO = 0, int NKBLPCDBBDM = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x63402C0", Offset = "0x633E8C0", VA = "0x1863402C0")]
	public BNJDBKKIAKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x6340310", Offset = "0x633E910", VA = "0x186340310")]
	public BNJDBKKIAKE(int GDBMBEIFFOO, int NKBLPCDBBDM = int.MaxValue, bool FLLBLIPCPNC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x633FB30", Offset = "0x633E130", VA = "0x18633FB30")]
	public T CILCEMKBDAL()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x633FF80", Offset = "0x633E580", VA = "0x18633FF80")]
	public void KKIPOBFIFOD(T OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x633F9F0", Offset = "0x633DFF0", VA = "0x18633F9F0")]
	private void BNDJLNJBCLN(T OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x633FAF0", Offset = "0x633E0F0", VA = "0x18633FAF0")]
	private void CCMDACKKPLK(T OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x633FD00", Offset = "0x633E300", VA = "0x18633FD00", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x6340060", Offset = "0x633E660", VA = "0x186340060")]
	private void NLJFEJANBIO(IEnumerable<T> DHLGAIMCINE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class HMGNGAPKGED<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private Dictionary<int, T> BCFIBNCLPAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private T LLKFHJPNIMF;

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public virtual T KKHJPLHIMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x9EAD20", Offset = "0x9E9320", VA = "0x1809EAD20", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x9EACC0", Offset = "0x9E92C0", VA = "0x1809EACC0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x4B65870", Offset = "0x4B63E70", VA = "0x184B65870")]
	public bool KEOHOAAEDBA(T OHLIHBDBKCE, int DPEJEDCKJBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x4A9C630", Offset = "0x4A9AC30", VA = "0x184A9C630")]
	public bool BLDIAILIAMJ(int DPEJEDCKJBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x4B65A10", Offset = "0x4B64010", VA = "0x184B65A10")]
	public T NHAMDKOBEPI(int OMGGKMJKDGD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x4B65730", Offset = "0x4B63D30", VA = "0x184B65730")]
	private bool JJIOGHKNFOF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x4B659B0", Offset = "0x4B63FB0", VA = "0x184B659B0")]
	public bool LKMKPGKLGLC(int DPEJEDCKJBD, [Out] T OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x4AA2150", Offset = "0x4AA0750", VA = "0x184AA2150")]
	public HMGNGAPKGED()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class CCOKFPFFHDL<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	protected struct GNGIHLGJNGL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public T FPGFCMMHMJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public int MHNIDGOLKKJ;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	protected readonly List<GNGIHLGJNGL> PPBIAJGFOEK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private T AMLGNADHKFH;

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public int CMIOJAJFIMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x408CB60", Offset = "0x408B160", VA = "0x18408CB60")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x6721650", Offset = "0x671FC50", VA = "0x186721650")]
	public bool DGAEJOHLCDJ(T OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x6721D40", Offset = "0x6720340", VA = "0x186721D40")]
	public void IIGLPCDPOEE(T OHLIHBDBKCE, int DPEJEDCKJBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x6721B50", Offset = "0x6720150", VA = "0x186721B50")]
	public bool GNAALOCCJEL(T OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x6721ED0", Offset = "0x67204D0", VA = "0x186721ED0")]
	public void INBDHNEFJBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x6721930", Offset = "0x671FF30", VA = "0x186721930")]
	public T FDCPMAJFLLE()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x67220F0", Offset = "0x67206F0", VA = "0x1867220F0")]
	protected void PIPAHOHNGCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x6722270", Offset = "0x6720870", VA = "0x186722270")]
	public CCOKFPFFHDL()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000074")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400011B")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x400011C")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x400011D")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400011E")]
		[ANKANEOPOFH(JINCPHMLLKA.Self, false, false, false)]
		[SerializeField]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x7BF7960", Offset = "0x7BF5F60", VA = "0x187BF7960")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x7BF7C30", Offset = "0x7BF6230", VA = "0x187BF7C30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x7BF7B40", Offset = "0x7BF6140", VA = "0x187BF7B40")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x7BF78B0", Offset = "0x7BF5EB0", VA = "0x187BF78B0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x7BF7B80", Offset = "0x7BF6180", VA = "0x187BF7B80")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x7BF7A90", Offset = "0x7BF6090", VA = "0x187BF7A90")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x7BF7830", Offset = "0x7BF5E30", VA = "0x187BF7830")]
		public ReferencePoint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000075")]
	public abstract class ResourcePrefabReference<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011F")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x580C390", Offset = "0x580A990", VA = "0x18580C390", Slot = "4")]
		public virtual T AAIJCDOFJJE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public interface ECFMAOOGLDK
{
	[Cpp2IlInjected.Token(Token = "0x17000070")]
	ToolHierarchyCache JCLAPKGEIFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000077")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x2000078")]
		public struct KJMLNCDOFEF<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			private readonly List<Component> OLEDHEBBJPH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			private readonly bool PLJFHNDJAFC;

			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x17AD290", Offset = "0x17AB890", VA = "0x1817AD290")]
			public KJMLNCDOFEF(List<Component> OLEDHEBBJPH, bool PLJFHNDJAFC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x50101E0", Offset = "0x500E7E0", VA = "0x1850101E0")]
			public MNLJEBIDHMH<T> OMLAPONJPHN()
			{
				return default(MNLJEBIDHMH<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x5010240", Offset = "0x500E840", VA = "0x185010240", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x5010240", Offset = "0x500E840", VA = "0x185010240", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000079")]
		public struct MNLJEBIDHMH<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			private readonly List<Component> OLEDHEBBJPH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			private readonly bool PLJFHNDJAFC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			private int OHHMJGCBCKD;

			[Cpp2IlInjected.Token(Token = "0x17000072")]
			public T FFKIBMLIABP
			{
				[Cpp2IlInjected.Token(Token = "0x6000247")]
				[Cpp2IlInjected.Address(RVA = "0x5376210", Offset = "0x5374810", VA = "0x185376210", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000073")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000248")]
				[Cpp2IlInjected.Address(RVA = "0x53761A0", Offset = "0x53747A0", VA = "0x1853761A0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x53761E0", Offset = "0x53747E0", VA = "0x1853761E0")]
			public MNLJEBIDHMH(List<Component> OLEDHEBBJPH, bool PLJFHNDJAFC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x53760E0", Offset = "0x53746E0", VA = "0x1853760E0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x53760F0", Offset = "0x53746F0", VA = "0x1853760F0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x4587A00", Offset = "0x4586000", VA = "0x184587A00", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000122")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000123")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x17000071")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0x7BF9620", Offset = "0x7BF7C20", VA = "0x187BF9620")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x9F9F60", Offset = "0x9F8560", VA = "0x1809F9F60")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x7BF8F10", Offset = "0x7BF7510", VA = "0x187BF8F10")]
		private void ANJKPBDKBKO(GameObject NHAAFJKFJLE, bool ECOALLGHBMI = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x7BF9080", Offset = "0x7BF7680", VA = "0x187BF9080")]
		public static void ANJKPBDKBKO(GameObject NHAAFJKFJLE, ToolHierarchyCache FEHNEKGGBGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x7BF9110", Offset = "0x7BF7710", VA = "0x187BF9110")]
		public void CBCKGPMMHOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x3BC5120", Offset = "0x3BC3720", VA = "0x183BC5120")]
		public void KKFNFICBAJF<T>(Action<T> BDCLNIJAFBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x3BC5080", Offset = "0x3BC3680", VA = "0x183BC5080")]
		public T JGDPLOLFKKH<T>(bool PLJFHNDJAFC = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x3BC5360", Offset = "0x3BC3960", VA = "0x183BC5360")]
		public KJMLNCDOFEF<T> LFLCKMKGJPH<T>(bool PLJFHNDJAFC = false) where T : class
		{
			return default(KJMLNCDOFEF<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x7BF9210", Offset = "0x7BF7810", VA = "0x187BF9210")]
		public List<Component> IGOBHIAFLKF(Type MLCOGCMJLBB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x7BF9120", Offset = "0x7BF7720", VA = "0x187BF9120", Slot = "4")]
		public bool Equals(ToolHierarchyCache CEJAAIDLEPA, ToolHierarchyCache IMNDAJIDDFG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x7BF91A0", Offset = "0x7BF77A0", VA = "0x187BF91A0", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache BOMDCGFKGKF)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class FLPGFEDBKGN<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private int GDBMBEIFFOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private int ONNLBAOHLJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private List<T> PFOGKPFJJDP;

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public int CMIOJAJFIMN
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x4998BE0", Offset = "0x49971E0", VA = "0x184998BE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public T ACAGEKDEDPM
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x49CC810", Offset = "0x49CAE10", VA = "0x1849CC810")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public T IJHOAMOEKLM
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x49CC3C0", Offset = "0x49CA9C0", VA = "0x1849CC3C0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public T LNKGIBKMBKP
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x49CC140", Offset = "0x49CA740", VA = "0x1849CC140")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x49CCA20", Offset = "0x49CB020", VA = "0x1849CCA20")]
	public FLPGFEDBKGN(int GDBMBEIFFOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x49CC460", Offset = "0x49CAA60", VA = "0x1849CC460")]
	public void IIGLPCDPOEE(T FJMDAONKMLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x49CC720", Offset = "0x49CAD20", VA = "0x1849CC720")]
	public void INBDHNEFJBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x49CC260", Offset = "0x49CA860", VA = "0x1849CC260")]
	public void GJJOHGHPMKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x49CC9C0", Offset = "0x49CAFC0", VA = "0x1849CC9C0")]
	public void POOEPECNPOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x49CC250", Offset = "0x49CA850", VA = "0x1849CC250")]
	public void DDNANNMFEPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x49CC780", Offset = "0x49CAD80", VA = "0x1849CC780")]
	public List<T> MLOOJOLJFJO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class LBBJFFOLGFF<T>
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	private struct PFICOGHMJAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public int MHNIDGOLKKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public T FPGFCMMHMJG;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private readonly Dictionary<object, PFICOGHMJAF> BCFIBNCLPAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private readonly EqualityComparer<T> IPPEFIAKPDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private T LLKFHJPNIMF;

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public virtual T KKHJPLHIMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0xD316E0", Offset = "0xD2FCE0", VA = "0x180D316E0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x50D3B70", Offset = "0x50D2170", VA = "0x1850D3B70", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public bool HJEIAMHJLEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x50D3BB0", Offset = "0x50D21B0", VA = "0x1850D3BB0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public object GADKFGKFHAL
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x9EB510", Offset = "0x9E9B10", VA = "0x1809EB510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x9ED2B0", Offset = "0x9EB8B0", VA = "0x1809ED2B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x50D6980", Offset = "0x50D4F80", VA = "0x1850D6980")]
	public bool KEOHOAAEDBA(T OHLIHBDBKCE, object EJJDDFFADPC, int DPEJEDCKJBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x50D3A50", Offset = "0x50D2050", VA = "0x1850D3A50")]
	public bool BLDIAILIAMJ(object EJJDDFFADPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x50D7760", Offset = "0x50D5D60", VA = "0x1850D7760")]
	public bool LKMKPGKLGLC(object EJJDDFFADPC, [Out] T OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x4B537D0", Offset = "0x4B51DD0", VA = "0x184B537D0")]
	public void INBDHNEFJBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x50D5350", Offset = "0x50D3950", VA = "0x1850D5350")]
	private bool JJIOGHKNFOF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x50D7FD0", Offset = "0x50D65D0", VA = "0x1850D7FD0")]
	public LBBJFFOLGFF()
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
