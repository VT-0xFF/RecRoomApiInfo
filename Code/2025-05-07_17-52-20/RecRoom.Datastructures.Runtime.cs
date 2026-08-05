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
		[Cpp2IlInjected.Address(RVA = "0xA1A700", Offset = "0xA19700", VA = "0x180A1A700")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C2BD50", Offset = "0x7C2AD50", VA = "0x187C2BD50")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA1B220", Offset = "0xA1A220", VA = "0x180A1B220")]
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
		[Cpp2IlInjected.Address(RVA = "0xA1B260", Offset = "0xA1A260", VA = "0x180A1B260")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class NJOFEBADJIN : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2051A20", Offset = "0x2050A20", VA = "0x182051A20")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CD0", Offset = "0x9EFCD0", VA = "0x1809F0CD0", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xC771F0", Offset = "0xC761F0", VA = "0x180C771F0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash CNOOJBJPLMK);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0xBA1DF0", Offset = "0xBA0DF0", VA = "0x180BA1DF0")]
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
	[HideInInspector]
	[ReadOnlyField]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x7C2CFC0", Offset = "0x7C2BFC0", VA = "0x187C2CFC0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7C2CF80", Offset = "0x7C2BF80", VA = "0x187C2CF80")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7C2D000", Offset = "0x7C2C000", VA = "0x187C2D000")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7C2D1B0", Offset = "0x7C2C1B0", VA = "0x187C2D1B0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7C2D120", Offset = "0x7C2C120", VA = "0x187C2D120")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xECEA30", Offset = "0xECDA30", VA = "0x180ECEA30")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17E40", VA = "0x180D18E40")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7C2CF40", Offset = "0x7C2BF40", VA = "0x187C2CF40")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7C2D090", Offset = "0x7C2C090", VA = "0x187C2D090")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7C2CB90", Offset = "0x7C2BB90", VA = "0x187C2CB90")]
	public void CopyBounds(SavedExtents MIJLJBIHDMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7C2CE90", Offset = "0x7C2BE90", VA = "0x187C2CE90")]
	public void SetLocalSpaceBounds(Bounds GBDEJJCEIID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x13FC410", Offset = "0x13FB410", VA = "0x1813FC410")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7C2CE80", Offset = "0x7C2BE80", VA = "0x187C2CE80")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7C2C370", Offset = "0x7C2B370", VA = "0x187C2C370")]
	private void CELJPBCMFIE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7C2CC80", Offset = "0x7C2BC80", VA = "0x187C2CC80")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7C2C520", Offset = "0x7C2B520", VA = "0x187C2C520")]
	public static void CalculateLocalBoundsFor(GameObject CEKGANCAJPA, [Out] Bounds GBDEJJCEIID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7C2CBC0", Offset = "0x7C2BBC0", VA = "0x187C2CBC0")]
	private static void EEPILJLNMGM(Bounds CNIMJCCKEDM, Color JKIBOICMIDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7C2CEB0", Offset = "0x7C2BEB0", VA = "0x187C2CEB0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE1A0", VA = "0x1809EF1A0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D30", Offset = "0x9EFD30", VA = "0x1809F0D30")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x18A5DC0", Offset = "0x18A4DC0", VA = "0x1818A5DC0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5844C60", Offset = "0x5843C60", VA = "0x185844C60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public virtual void GBHHIMAPMMF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
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
	[Cpp2IlInjected.Address(RVA = "0x58447A0", Offset = "0x58437A0", VA = "0x1858447A0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x58432C0", Offset = "0x58422C0", VA = "0x1858432C0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5844B70", Offset = "0x5843B70", VA = "0x185844B70")]
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
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public EFFICMJNHOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x44C3FB0", Offset = "0x44C2FB0", VA = "0x1844C3FB0")]
		internal int ELDJJCDOMAN(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[NJOFEBADJIN]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x44F9DA0", Offset = "0x44F8DA0", VA = "0x1844F9DA0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x44F9E00", Offset = "0x44F8E00", VA = "0x1844F9E00", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x44F9C70", Offset = "0x44F8C70", VA = "0x1844F9C70", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey OEHHKNIGGMI]
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x44F9D30", Offset = "0x44F8D30", VA = "0x1844F9D30", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x44F9B10", Offset = "0x44F8B10", VA = "0x1844F9B10", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x44F9710", Offset = "0x44F8710", VA = "0x1844F9710", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x44F8AA0", Offset = "0x44F7AA0", VA = "0x1844F8AA0", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x44F9900", Offset = "0x44F8900", VA = "0x1844F9900", Slot = "14")]
	protected virtual string PKIBKHPNHMC(TKeyVal MKENHCDLPKE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x44F8990", Offset = "0x44F7990", VA = "0x1844F8990", Slot = "4")]
	public bool ContainsKey(TKey OEHHKNIGGMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x44F9990", Offset = "0x44F8990", VA = "0x1844F9990", Slot = "5")]
	public bool TryGetValue(TKey OEHHKNIGGMI, [Out] TVal OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x44F89F0", Offset = "0x44F79F0", VA = "0x1844F89F0", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x44F89F0", Offset = "0x44F79F0", VA = "0x1844F89F0", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x44F99F0", Offset = "0x44F89F0", VA = "0x1844F99F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
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
		[Cpp2IlInjected.Address(RVA = "0x4487280", Offset = "0x4486280", VA = "0x184487280")]
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
	[Cpp2IlInjected.Address(RVA = "0x58466C0", Offset = "0x58456C0", VA = "0x1858466C0")]
	protected SerializedReferenceDictionary()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5845EC0", Offset = "0x5844EC0", VA = "0x185845EC0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5845420", Offset = "0x5844420", VA = "0x185845420", Slot = "47")]
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
		[Cpp2IlInjected.Address(RVA = "0xBFE690", Offset = "0xBFD690", VA = "0x180BFE690")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xC4A0C0", Offset = "0xC490C0", VA = "0x180C4A0C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public T GHJEAJCFOKM
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x4C11E50", Offset = "0x4C10E50", VA = "0x184C11E50")]
	protected INPGGBKMAEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x4C11DB0", Offset = "0x4C10DB0", VA = "0x184C11DB0")]
	protected INPGGBKMAEO(int CFNMLMNHCMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4C11AA0", Offset = "0x4C10AA0", VA = "0x184C11AA0")]
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
	[Cpp2IlInjected.Address(RVA = "0x4C11D40", Offset = "0x4C10D40", VA = "0x184C11D40")]
	public void INBDHNEFJBE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class FMOLKLBGDFE : INPGGBKMAEO<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7C2A340", Offset = "0x7C29340", VA = "0x187C2A340", Slot = "4")]
	public override bool MAEKIKKKDDB(float OMDABEJMMKM, float MKDGBOGGCJD, [Out] Vector3 OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7C2A200", Offset = "0x7C29200", VA = "0x187C2A200", Slot = "5")]
	public override bool AAJCDDFGDIL(float OMDABEJMMKM, float MKDGBOGGCJD, [Out] Vector3 OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7C2A4A0", Offset = "0x7C294A0", VA = "0x187C2A4A0")]
	public FMOLKLBGDFE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class HLPPLMKFOCK
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x386A890", Offset = "0x3869890", VA = "0x18386A890")]
	public static HMGCNMGOPPM<T1, T2> FLLMCNLHKNL<T1, T2>(T1 DOKIGGDJIPL, T2 DIKLDOJBCJC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x386A930", Offset = "0x3869930", VA = "0x18386A930")]
	public static LEGOPPDCCEI<T1, T2, T3> FLLMCNLHKNL<T1, T2, T3>(T1 DOKIGGDJIPL, T2 DIKLDOJBCJC, T3 FBEKHHFKGAP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x538CC40", Offset = "0x538BC40", VA = "0x18538CC40")]
	internal static int OCIIMJDKACM(int OJGEEEBKPNG, int GNEHPDMBGJL)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6E26E70", Offset = "0x6E25E70", VA = "0x186E26E70")]
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
	[Cpp2IlInjected.Address(RVA = "0x4B0C7E0", Offset = "0x4B0B7E0", VA = "0x184B0C7E0")]
	public HMGCNMGOPPM(T1 DOKIGGDJIPL, T2 DIKLDOJBCJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x4B0ACC0", Offset = "0x4B09CC0", VA = "0x184B0ACC0", Slot = "4")]
	public int CompareTo(HMGCNMGOPPM<T1, T2> MIJLJBIHDMP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x4B0B630", Offset = "0x4B0A630", VA = "0x184B0B630", Slot = "0")]
	public override bool Equals(object MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4B0BA80", Offset = "0x4B0AA80", VA = "0x184B0BA80", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x4B0C2C0", Offset = "0x4B0B2C0", VA = "0x184B0C2C0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x50E6460", Offset = "0x50E5460", VA = "0x1850E6460")]
	public LEGOPPDCCEI(T1 DOKIGGDJIPL, T2 DIKLDOJBCJC, T3 FBEKHHFKGAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x50E5C20", Offset = "0x50E4C20", VA = "0x1850E5C20", Slot = "4")]
	public int CompareTo(LEGOPPDCCEI<T1, T2, T3> MIJLJBIHDMP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x50E5EA0", Offset = "0x50E4EA0", VA = "0x1850E5EA0", Slot = "0")]
	public override bool Equals(object MIJLJBIHDMP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x50E60F0", Offset = "0x50E50F0", VA = "0x1850E60F0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x50E6190", Offset = "0x50E5190", VA = "0x1850E6190", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public T POEFMBBDOON
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x1286C40", Offset = "0x1285C40", VA = "0x181286C40")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T OGKJEFIOBMM
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xBFFAA0", Offset = "0xBFEAA0", VA = "0x180BFFAA0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T FPGFCMMHMJG
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2B43F20", Offset = "0x2B42F20", VA = "0x182B43F20")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2B43F70", Offset = "0x2B42F70", VA = "0x182B43F70")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float GKIGMCHANCJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xBFBD40", Offset = "0xBFAD40", VA = "0x180BFBD40")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5B104B0", Offset = "0x5B0F4B0", VA = "0x185B104B0")]
	public T ELFKPHICMCJ(float LEMBKBGMCDG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5B10990", Offset = "0x5B0F990", VA = "0x185B10990")]
	public T NNMAIOBAJPP(float LEMBKBGMCDG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T BKJDABAAONM(T OBNCJFFHHLB, T ODHPFGNCGDP, float LEMBKBGMCDG);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7C2A4E0", Offset = "0x7C294E0", VA = "0x187C2A4E0", Slot = "4")]
	protected override float BKJDABAAONM(float OBNCJFFHHLB, float ODHPFGNCGDP, float LEMBKBGMCDG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7C2A520", Offset = "0x7C29520", VA = "0x187C2A520")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x16F6BA0", Offset = "0x16F5BA0", VA = "0x1816F6BA0", Slot = "4")]
	protected override Vector3 BKJDABAAONM(Vector3 OBNCJFFHHLB, Vector3 ODHPFGNCGDP, float LEMBKBGMCDG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7C2DFD0", Offset = "0x7C2CFD0", VA = "0x187C2DFD0")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7C27FD0", Offset = "0x7C26FD0", VA = "0x187C27FD0", Slot = "4")]
	protected override Color BKJDABAAONM(Color OBNCJFFHHLB, Color ODHPFGNCGDP, float LEMBKBGMCDG)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7C28090", Offset = "0x7C27090", VA = "0x187C28090")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class DHGMCGGGGNC : HOBCNHIEEIJ<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7C28140", Offset = "0x7C27140", VA = "0x187C28140")]
	public DHGMCGGGGNC(int GDBMBEIFFOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7C280D0", Offset = "0x7C270D0", VA = "0x187C280D0", Slot = "6")]
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
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
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
	[Cpp2IlInjected.Address(RVA = "0x4F5FC50", Offset = "0x4F5EC50", VA = "0x184F5FC50")]
	private KNAIKKDHPNB(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> KGBFIONNDLC, int NICAKCBKIBI, int IELIEGDMFFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x4FED090", Offset = "0x4FEC090", VA = "0x184FED090")]
	public static KNAIKKDHPNB<T> ACADPGMDEBE()
	{
		return default(KNAIKKDHPNB<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4FED1A0", Offset = "0x4FEC1A0", VA = "0x184FED1A0")]
	public (int, int, Task<T>) CAKEOFOFIAD(int GIBLACJPDHG, [Optional] CancellationToken CBJPDIFOEKF, double EPOJNFBFHFP = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4FEF0B0", Offset = "0x4FEE0B0", VA = "0x184FEF0B0")]
	public void NEMFFPKLNCP(int GIBLACJPDHG, int IELIEGDMFFE, [In] T OBOOAPELMPF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class BDGPCNOIGDD
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7C27B40", Offset = "0x7C26B40", VA = "0x187C27B40")]
	public static KNAIKKDHPNB<BONGKMFJEJA> ACADPGMDEBE()
	{
		return default(KNAIKKDHPNB<BONGKMFJEJA>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7C27B90", Offset = "0x7C26B90", VA = "0x187C27B90")]
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
		[Cpp2IlInjected.Address(RVA = "0x404C6F0", Offset = "0x404B6F0", VA = "0x18404C6F0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool DJCGEFIJFFP
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA3A820", Offset = "0xA39820", VA = "0x180A3A820", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TKey> JABHKAJJCDH
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x44BBFD0", Offset = "0x44BAFD0", VA = "0x1844BBFD0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ICollection<TVal> CLOMIHCLDKJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x4AF9F90", Offset = "0x4AF8F90", VA = "0x184AF9F90", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TVal OEMFNNCKNFG
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x4AF9F20", Offset = "0x4AF8F20", VA = "0x184AF9F20", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x4AF9FF0", Offset = "0x4AF8FF0", VA = "0x184AF9FF0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public TKey OEMFNNCKNFG
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x4AF9090", Offset = "0x4AF8090", VA = "0x184AF9090")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x4AF9280", Offset = "0x4AF8280", VA = "0x184AF9280", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x4AF9CF0", Offset = "0x4AF8CF0", VA = "0x184AF9CF0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x4AF91E0", Offset = "0x4AF81E0", VA = "0x184AF91E0", Slot = "9")]
	public void Add(TKey OEHHKNIGGMI, TVal OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x4AF9190", Offset = "0x4AF8190", VA = "0x184AF9190", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> HOJKNIMMINF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x4AF9330", Offset = "0x4AF8330", VA = "0x184AF9330", Slot = "8")]
	public bool ContainsKey(TKey OEHHKNIGGMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x4AF9390", Offset = "0x4AF8390", VA = "0x184AF9390", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x4AF9BE0", Offset = "0x4AF8BE0", VA = "0x184AF9BE0", Slot = "10")]
	public bool Remove(TKey OEHHKNIGGMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x4AF9C60", Offset = "0x4AF8C60", VA = "0x184AF9C60", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x4AF9D40", Offset = "0x4AF8D40", VA = "0x184AF9D40", Slot = "11")]
	public bool TryGetValue(TKey OEHHKNIGGMI, [Out] TVal OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x4AF9670", Offset = "0x4AF8670", VA = "0x184AF9670", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x4AF9410", Offset = "0x4AF8410", VA = "0x184AF9410", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] NBBLCIBNPBK, int DDFLLHIGBFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x4AF9710", Offset = "0x4AF8710", VA = "0x184AF9710")]
	public bool LKMKPGKLGLC(TVal OEHHKNIGGMI, [Out] TKey OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x4AF9580", Offset = "0x4AF8580", VA = "0x184AF9580")]
	private void EPFBABNADFL(TKey OEHHKNIGGMI, TVal GCDAJLDGOIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x4AF98B0", Offset = "0x4AF88B0", VA = "0x184AF98B0")]
	private void PEEGBDMODGD(TKey OEHHKNIGGMI, TVal GCDAJLDGOIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x4AF99A0", Offset = "0x4AF89A0", VA = "0x184AF99A0")]
	private bool PGAFKNEHGID(TKey OEHHKNIGGMI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x4AF9DA0", Offset = "0x4AF8DA0", VA = "0x184AF9DA0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4553D40", Offset = "0x4552D40", VA = "0x184553D40", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x4567CB0", Offset = "0x4566CB0", VA = "0x184567CB0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x4569C20", Offset = "0x4568C20", VA = "0x184569C20")]
		public Enumerator(COCLBOJKODC<T> IIGKBHIENFB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x4565920", Offset = "0x4564920", VA = "0x184565920", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x4567740", Offset = "0x4566740", VA = "0x184567740", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x4564DD0", Offset = "0x4563DD0", VA = "0x184564DD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x67F7700", Offset = "0x67F6700", VA = "0x1867F7700")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public T OEMFNNCKNFG
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x67F6570", Offset = "0x67F5570", VA = "0x1867F6570")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x67F7900", Offset = "0x67F6900", VA = "0x1867F7900")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x67F87F0", Offset = "0x67F77F0", VA = "0x1867F87F0")]
	public COCLBOJKODC(int GDBMBEIFFOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x67F7260", Offset = "0x67F6260", VA = "0x1867F7260")]
	public void IIGLPCDPOEE(T LEMBKBGMCDG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x67F76B0", Offset = "0x67F66B0", VA = "0x1867F76B0")]
	public void INBDHNEFJBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x67F6FB0", Offset = "0x67F5FB0", VA = "0x1867F6FB0")]
	public void HAILHNMFFGN(int JAALIADHHOC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x67F8380", Offset = "0x67F7380", VA = "0x1867F8380")]
	public void PNJIDJCBNNF(T[] NBBLCIBNPBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x67F7B10", Offset = "0x67F6B10", VA = "0x1867F7B10")]
	public Enumerator OMLAPONJPHN()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x67F8680", Offset = "0x67F7680", VA = "0x1867F8680", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x67F8680", Offset = "0x67F7680", VA = "0x1867F8680", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x67F6C20", Offset = "0x67F5C20", VA = "0x1867F6C20")]
	private int FBGOCIPPCKC(int OHHMJGCBCKD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x67F76D0", Offset = "0x67F66D0", VA = "0x1867F76D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4F60500", Offset = "0x4F5F500", VA = "0x184F60500")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public TimeSpan GHODKACCJDG
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x4F605E0", Offset = "0x4F5F5E0", VA = "0x184F605E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x552FED0", Offset = "0x552EED0", VA = "0x18552FED0")]
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
		[Cpp2IlInjected.Address(RVA = "0x60C3A80", Offset = "0x60C2A80", VA = "0x1860C3A80", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x60C4360", Offset = "0x60C3360", VA = "0x1860C4360", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x4C76280", Offset = "0x4C75280", VA = "0x184C76280", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x4C76940", Offset = "0x4C75940", VA = "0x184C76940", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x63A8F50", Offset = "0x63A7F50", VA = "0x1863A8F50")]
	public BHHEEFEODGH(HGHCKAMNGOP GFGHJNLGNEC, [Optional] ANNKHFIEAPK JPIKKANLOGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x63A7610", Offset = "0x63A6610", VA = "0x1863A7610")]
	public Task<TResult> AFNOPJDJEBM(TRequest HOOJNAMGGBC, CancellationToken CBJPDIFOEKF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x63A89B0", Offset = "0x63A79B0", VA = "0x1863A89B0")]
	private void OGAHDHCDJIF(OLNGEDHHDKK OAAOOLHHJIJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x63A8300", Offset = "0x63A7300", VA = "0x1863A8300")]
	[AsyncStateMachine(typeof(BHHEEFEODGH<, >.BAJAECHAOLL))]
	private Task IKCNLBOPEDP()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x63A7E70", Offset = "0x63A6E70", VA = "0x1863A7E70")]
	private OLNGEDHHDKK GBOPKPFONCA()
	{
		return default(OLNGEDHHDKK);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x63A85C0", Offset = "0x63A75C0", VA = "0x1863A85C0")]
	[AsyncStateMachine(typeof(BHHEEFEODGH<, >.AJLNAKOPBPO))]
	private Task JDCGGFLCIJL()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x63A86B0", Offset = "0x63A76B0", VA = "0x1863A86B0")]
	private void MBOLIFJJGIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x63A7840", Offset = "0x63A6840", VA = "0x1863A7840", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x404C6F0", Offset = "0x404B6F0", VA = "0x18404C6F0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool DJCGEFIJFFP
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xA3A820", Offset = "0xA39820", VA = "0x180A3A820", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public T OEMFNNCKNFG
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x3CA44E0", Offset = "0x3CA34E0", VA = "0x183CA44E0", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x67F62F0", Offset = "0x67F52F0", VA = "0x1867F62F0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x49B5230", Offset = "0x49B4230", VA = "0x1849B5230", Slot = "11")]
	public void Add(T HOJKNIMMINF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x67F5790", Offset = "0x67F4790", VA = "0x1867F5790")]
	public bool EBIHDMMAINL(T HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x67F5FC0", Offset = "0x67F4FC0", VA = "0x1867F5FC0", Slot = "15")]
	public bool Remove(T HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x496DF50", Offset = "0x496CF50", VA = "0x18496DF50", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x49EAFE0", Offset = "0x49E9FE0", VA = "0x1849EAFE0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x67F5620", Offset = "0x67F4620", VA = "0x1867F5620", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x67F56D0", Offset = "0x67F46D0", VA = "0x1867F56D0", Slot = "13")]
	public bool Contains(T HOJKNIMMINF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x67F5730", Offset = "0x67F4730", VA = "0x1867F5730", Slot = "14")]
	public void CopyTo(T[] NBBLCIBNPBK, int DDFLLHIGBFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x506F390", Offset = "0x506E390", VA = "0x18506F390", Slot = "6")]
	public int IndexOf(T HOJKNIMMINF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x67F5B00", Offset = "0x67F4B00", VA = "0x1867F5B00", Slot = "7")]
	public void Insert(int OHHMJGCBCKD, T HOJKNIMMINF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x67F5C50", Offset = "0x67F4C50", VA = "0x1867F5C50", Slot = "8")]
	public void RemoveAt(int OHHMJGCBCKD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x67F6080", Offset = "0x67F5080", VA = "0x1867F6080")]
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
			[Cpp2IlInjected.Address(RVA = "0x29C5BF0", Offset = "0x29C4BF0", VA = "0x1829C5BF0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x24CE4A0", Offset = "0x24CD4A0", VA = "0x1824CE4A0")]
		public SerializedGuid([In] Guid DGNNPFFMIEE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7C2D340", Offset = "0x7C2C340", VA = "0x187C2D340")]
		public static SerializedGuid FGFFHJFPMHM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7C2D3D0", Offset = "0x7C2C3D0", VA = "0x187C2D3D0")]
		public static SerializedGuid KKNAIOBAEHP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7C2D440", Offset = "0x7C2C440", VA = "0x187C2D440")]
		public bool NOJJAOAIMCB()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7C2D520", Offset = "0x7C2C520", VA = "0x187C2D520", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x7C2D4A0", Offset = "0x7C2C4A0", VA = "0x187C2D4A0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x7C2D270", Offset = "0x7C2C270", VA = "0x187C2D270", Slot = "7")]
		public bool Equals(SerializedGuid MIJLJBIHDMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x7C2D2B0", Offset = "0x7C2C2B0", VA = "0x187C2D2B0", Slot = "0")]
		public override bool Equals(object BOMDCGFKGKF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x7C2D3C0", Offset = "0x7C2C3C0", VA = "0x187C2D3C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x7C2D240", Offset = "0x7C2C240", VA = "0x187C2D240", Slot = "6")]
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
	[Cpp2IlInjected.Address(RVA = "0x7C2BBF0", Offset = "0x7C2ABF0", VA = "0x187C2BBF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
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
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public OPOGGMGLGFP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x553F7B0", Offset = "0x553E7B0", VA = "0x18553F7B0")]
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
		[Cpp2IlInjected.Address(RVA = "0x54FFA50", Offset = "0x54FEA50", VA = "0x1854FFA50", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x54FFB30", Offset = "0x54FEB30", VA = "0x1854FFB30")]
	public OBAHHFJPMPC(float JMOAINMKOFN, float FABKPLEELCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x54FECF0", Offset = "0x54FDCF0", VA = "0x1854FECF0", Slot = "6")]
	public bool CFIIEABGMCD(float EPGNCELGAFP, T OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x54FF0C0", Offset = "0x54FE0C0", VA = "0x1854FF0C0", Slot = "5")]
	public IEnumerable<T> EBJLCJPKBML(float EPGNCELGAFP, float? ANGACKADLAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x54FF7E0", Offset = "0x54FE7E0", VA = "0x1854FF7E0", Slot = "7")]
	public void INBDHNEFJBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x54FF8A0", Offset = "0x54FE8A0", VA = "0x1854FF8A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x44DF880", Offset = "0x44DE880", VA = "0x1844DF880")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xE8B5B0", Offset = "0xE8A5B0", VA = "0x180E8B5B0")]
		[DebuggerHidden]
		public KKGDIFFEFGI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x4FE6B60", Offset = "0x4FE5B60", VA = "0x184FE6B60", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x4FE6EF0", Offset = "0x4FE5EF0", VA = "0x184FE6EF0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x4FE6E10", Offset = "0x4FE5E10", VA = "0x184FE6E10", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x4A0A850", Offset = "0x4A09850", VA = "0x184A0A850", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F0C90", Offset = "0x9EFC90", VA = "0x1809F0C90", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x4A51E50", Offset = "0x4A50E50", VA = "0x184A51E50")]
	public GCOCBCNAICG(float JMOAINMKOFN, float FABKPLEELCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x4A51590", Offset = "0x4A50590", VA = "0x184A51590", Slot = "6")]
	public bool CFIIEABGMCD(float EPGNCELGAFP, T OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x4A51E00", Offset = "0x4A50E00", VA = "0x184A51E00", Slot = "8")]
	public int ONIGNBHFPKD(float EPGNCELGAFP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x4A51C00", Offset = "0x4A50C00", VA = "0x184A51C00", Slot = "5")]
	[IteratorStateMachine(typeof(GCOCBCNAICG<>.KKGDIFFEFGI))]
	public IEnumerable<T> EBJLCJPKBML(float EPGNCELGAFP, float? ANGACKADLAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x4A51DA0", Offset = "0x4A50DA0", VA = "0x184A51DA0", Slot = "7")]
	public void INBDHNEFJBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x4A51960", Offset = "0x4A50960", VA = "0x184A51960")]
	private void DDLBHNAPPKJ(float EPGNCELGAFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x4A51B20", Offset = "0x4A50B20", VA = "0x184A51B20")]
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
		[Cpp2IlInjected.Address(RVA = "0x4A85670", Offset = "0x4A84670", VA = "0x184A85670")]
		public GIIEEMBKJKE(long FAJHKGBHFNJ, int DGECAFEDAOD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x4A856E0", Offset = "0x4A846E0", VA = "0x184A856E0")]
		public GIIEEMBKJKE(long FAJHKGBHFNJ, long ACJGMFMAPGN, int DGECAFEDAOD, int PAPAJLFGGGB, bool PKKKOLOEADF, string KEBFMIBJDMG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x4A85620", Offset = "0x4A84620", VA = "0x184A85620")]
		public int PEMOBIMANMF()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x4A85600", Offset = "0x4A84600", VA = "0x184A85600")]
		public int PDOLLJIBCGC(int COCEFBEJJAI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x4A855A0", Offset = "0x4A845A0", VA = "0x184A855A0")]
		public double PCOPLMJKAHG()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x4A85510", Offset = "0x4A84510", VA = "0x184A85510")]
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
			[Cpp2IlInjected.Address(RVA = "0x67E2B30", Offset = "0x67E1B30", VA = "0x1867E2B30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x44BB500", Offset = "0x44BA500", VA = "0x1844BB500", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x5AAB250", Offset = "0x5AAA250", VA = "0x185AAB250")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public IEnumerable<CKHHEKIPJDF> CKOCFIAIKJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x67E6BA0", Offset = "0x67E5BA0", VA = "0x1867E6BA0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public GIIEEMBKJKE EMPOHNHBPKC
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x67E6740", Offset = "0x67E5740", VA = "0x1867E6740")]
			[CompilerGenerated]
			get
			{
				return default(GIIEEMBKJKE);
			}
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x67E69B0", Offset = "0x67E59B0", VA = "0x1867E69B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x67E6BE0", Offset = "0x67E5BE0", VA = "0x1867E6BE0")]
		internal CKHHEKIPJDF(LDCGKGNFMMI<TKey> DCCJGOAMNIL, TKey OEHHKNIGGMI, JBBHIJHGEPM PAJIGEJCNAP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x67E69E0", Offset = "0x67E59E0", VA = "0x1867E69E0")]
		public CKHHEKIPJDF LGCKMCLLPBB(TKey OEHHKNIGGMI, [Optional] JBBHIJHGEPM? LOHAHHGGBOK)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x3CA36D0", Offset = "0x3CA26D0", VA = "0x183CA36D0")]
		[AsyncStateMachine(typeof(CJBHLEJPBFD<>))]
		public Task<T> FBMBODPAFOA<T>(TKey OEHHKNIGGMI, Func<CKHHEKIPJDF, Task<T>> NPLDOOBBCLG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x67E6760", Offset = "0x67E5760", VA = "0x1867E6760", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x29B7CE0", Offset = "0x29B6CE0", VA = "0x1829B7CE0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x67CD650", Offset = "0x67CC650", VA = "0x1867CD650", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x29B7DD0", Offset = "0x29B6DD0", VA = "0x1829B7DD0")]
		[DebuggerHidden]
		public CGDBJDCFFGJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x48C4F60", Offset = "0x48C3F60", VA = "0x1848C4F60", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x67CD170", Offset = "0x67CC170", VA = "0x1867CD170", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x67CD120", Offset = "0x67CC120", VA = "0x1867CD120")]
		private void KILKBHNKCHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x67CD600", Offset = "0x67CC600", VA = "0x1867CD600", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x67CD520", Offset = "0x67CC520", VA = "0x1867CD520", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, GIIEEMBKJKE)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x4068960", Offset = "0x4067960", VA = "0x184068960", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x29B7CE0", Offset = "0x29B6CE0", VA = "0x1829B7CE0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x4FE1210", Offset = "0x4FE0210", VA = "0x184FE1210", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x29B7DD0", Offset = "0x29B6DD0", VA = "0x1829B7DD0")]
		[DebuggerHidden]
		public KJICIBEPCAN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x4FE1270", Offset = "0x4FE0270", VA = "0x184FE1270", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x4FE0850", Offset = "0x4FDF850", VA = "0x184FE0850", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x4FE07F0", Offset = "0x4FDF7F0", VA = "0x184FE07F0")]
		private void KILKBHNKCHN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x4FE1020", Offset = "0x4FE0020", VA = "0x184FE1020")]
		private void PJDCPOGKKBJ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x4FE11C0", Offset = "0x4FE01C0", VA = "0x184FE11C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x4FE1080", Offset = "0x4FE0080", VA = "0x184FE1080", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, GIIEEMBKJKE)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x4FE1180", Offset = "0x4FE0180", VA = "0x184FE1180", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F1510", Offset = "0x9F0510", VA = "0x1809F1510")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F4700", Offset = "0x9F3700", VA = "0x1809F4700")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x50D2450", Offset = "0x50D1450", VA = "0x1850D2450")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x50D2530", Offset = "0x50D1530", VA = "0x1850D2530")]
	public LDCGKGNFMMI(TKey KEPAHPNECDC, JBBHIJHGEPM PAJIGEJCNAP, [Optional] int? DGECAFEDAOD, [Optional][CanBeNull] Stopwatch GNFGHEJOPEM, [Optional] Action<TKey, GIIEEMBKJKE, JBBHIJHGEPM> PAJIOJGBFLE, [Optional] Action<TKey, GIIEEMBKJKE, JBBHIJHGEPM> MJODGLPGLIM, [Optional] Action<LDCGKGNFMMI<TKey>, JBBHIJHGEPM> HBDCHLJNKMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x50D2370", Offset = "0x50D1370", VA = "0x1850D2370", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x50D21D0", Offset = "0x50D11D0", VA = "0x1850D21D0")]
	[IteratorStateMachine(typeof(LDCGKGNFMMI<>.CGDBJDCFFGJ))]
	public IEnumerable<(TKey, List<TKey>, GIIEEMBKJKE)> BEHLMKMGCLO()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x50D2280", Offset = "0x50D1280", VA = "0x1850D2280")]
	[IteratorStateMachine(typeof(LDCGKGNFMMI<>.KJICIBEPCAN))]
	private IEnumerable<(TKey, List<TKey>, GIIEEMBKJKE)> BEHLMKMGCLO(List<TKey> IGFKNGAMFIG, CKHHEKIPJDF MCLBGLJLFCK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x50D24B0", Offset = "0x50D14B0", VA = "0x1850D24B0")]
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
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
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
	[Cpp2IlInjected.Address(RVA = "0x5528F90", Offset = "0x5527F90", VA = "0x185528F90")]
	private static string FLBLFBLDMFN(TKey OEHHKNIGGMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x5528EA0", Offset = "0x5527EA0", VA = "0x185528EA0", Slot = "4")]
	public override string BKMNGMHFDIG(LDCGKGNFMMI<TKey> DCCJGOAMNIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x5528D50", Offset = "0x5527D50", VA = "0x185528D50")]
	public string BKMNGMHFDIG(LDCGKGNFMMI<TKey> DCCJGOAMNIL, [NotNull] ANGFAPGHIFG AOKHCIEGKHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string ILJGBKFGBMA(LDCGKGNFMMI<TKey> DCCJGOAMNIL, [NotNull] ANGFAPGHIFG AOKHCIEGKHD);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x44DFDF0", Offset = "0x44DEDF0", VA = "0x1844DFDF0")]
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
	[Cpp2IlInjected.Address(RVA = "0x53AB4D0", Offset = "0x53AA4D0", VA = "0x1853AB4D0")]
	private static string FLBLFBLDMFN(TKey OEHHKNIGGMI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x53AB8F0", Offset = "0x53AA8F0", VA = "0x1853AB8F0")]
	public NEOBNBDMFBE(string AOLBOEAAAKC = "F2", double MIHCOBDANEO = double.MaxValue, bool JPKBNHMMECK = false, int MGLELLPMPDJ = int.MaxValue, [Optional] ISet<string> KENHPKJIKFE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x53AB300", Offset = "0x53AA300", VA = "0x1853AB300", Slot = "4")]
	public override Dictionary<string, string> BKMNGMHFDIG(LDCGKGNFMMI<TKey> DCCJGOAMNIL)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x53AB3F0", Offset = "0x53AA3F0", VA = "0x1853AB3F0")]
	private bool CGBMPKDKIIH(string EMJGDNEIDKA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x53AACB0", Offset = "0x53A9CB0", VA = "0x1853AACB0")]
	public Dictionary<string, string> BKMNGMHFDIG(LDCGKGNFMMI<TKey> DCCJGOAMNIL, KHPDKNOBJCO AOKHCIEGKHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x53AB670", Offset = "0x53AA670", VA = "0x1853AB670")]
	private string OKJBEPDBEEB(StringBuilder EDJHPMEPCCE, List<TKey> PPFBAOLBBPC, KHPDKNOBJCO AOKHCIEGKHD, bool NAGJEBLOGML)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x53AB510", Offset = "0x53AA510", VA = "0x1853AB510")]
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
	[Cpp2IlInjected.Address(RVA = "0x67FCC50", Offset = "0x67FBC50", VA = "0x1867FCC50")]
	private COOLPEMNBIP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x67FBC40", Offset = "0x67FAC40", VA = "0x1867FBC40", Slot = "5")]
	protected override string ILJGBKFGBMA(LDCGKGNFMMI<TKey> DCCJGOAMNIL, ANGFAPGHIFG AOKHCIEGKHD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x67FBB40", Offset = "0x67FAB40", VA = "0x1867FBB40")]
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
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public BCOPDCNOAFH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x7C27AB0", Offset = "0x7C26AB0", VA = "0x187C27AB0")]
		internal void HNHAFOLDMAP(LDCGKGNFMMI<string> timer, JBBHIJHGEPM log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x7C28250", Offset = "0x7C27250", VA = "0x187C28250")]
	public EEEGNIHNGIE(JBBHIJHGEPM PAJIGEJCNAP, [Optional] string FPFAFHGGBCN, [Optional] int? DGECAFEDAOD, [Optional] Stopwatch GNFGHEJOPEM, [Optional] Action<string, GIIEEMBKJKE, JBBHIJHGEPM> PAJIOJGBFLE, [Optional] Action<string, GIIEEMBKJKE, JBBHIJHGEPM> MJODGLPGLIM, [Optional] Action<EEEGNIHNGIE, JBBHIJHGEPM> HBDCHLJNKMD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x7C28190", Offset = "0x7C27190", VA = "0x187C28190")]
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
			[Cpp2IlInjected.Address(RVA = "0x7C283A0", Offset = "0x7C273A0", VA = "0x187C283A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x11D2860", Offset = "0x11D1860", VA = "0x1811D2860", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7C284A0", Offset = "0x7C274A0", VA = "0x187C284A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C27D10", Offset = "0x7C26D10", VA = "0x187C27D10")]
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
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
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
	[Cpp2IlInjected.Address(RVA = "0x383A2A0", Offset = "0x38392A0", VA = "0x18383A2A0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x552C0F0", Offset = "0x552B0F0", VA = "0x18552C0F0")]
		public OKBLDIIOBDB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F1780", Offset = "0x9F0780", VA = "0x1809F1780", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F6810", Offset = "0x9F5810", VA = "0x1809F6810", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x4FD68C0", Offset = "0x4FD58C0", VA = "0x184FD68C0")]
		public KGNKHKPFHFK(T LJEENFPIGIA, Action<T>? AAMIKNLELJB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x4FD6680", Offset = "0x4FD5680", VA = "0x184FD6680", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x552BF50", Offset = "0x552AF50", VA = "0x18552BF50")]
		public OJMLJMDMOOF(Exception GGOAKKKDCJN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0x6A64820", Offset = "0x6A63820", VA = "0x186A64820", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x6A64D50", Offset = "0x6A63D50", VA = "0x186A64D50", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x6A54E20", Offset = "0x6A53E20", VA = "0x186A54E20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x6A552A0", Offset = "0x6A542A0", VA = "0x186A552A0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F1550", Offset = "0x9F0550", VA = "0x1809F1550", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x4C737E0", Offset = "0x4C727E0", VA = "0x184C737E0")]
		public AJCGPDOGGKI(Task<GKHPBLLBAIL<T>> BGKKDAHMDLM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x4C736C0", Offset = "0x4C726C0", VA = "0x184C736C0", Slot = "10")]
		protected override void OOJMHCEGIPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x4C73220", Offset = "0x4C72220", VA = "0x184C73220")]
		[AsyncStateMachine(typeof(AJCGPDOGGKI<>.DKLEJHBPBPI))]
		[CompilerGenerated]
		internal static Task<T> CIEKCBHCMDG(Task<GKHPBLLBAIL<T>> BGKKDAHMDLM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x4C735E0", Offset = "0x4C725E0", VA = "0x184C735E0")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(AJCGPDOGGKI<>.DDHILFJLJIE))]
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
			[Cpp2IlInjected.Address(RVA = "0x6A6C670", Offset = "0x6A6B670", VA = "0x186A6C670", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x44F35F0", Offset = "0x44F25F0", VA = "0x1844F35F0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F1550", Offset = "0x9F0550", VA = "0x1809F1550", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x44BCDF0", Offset = "0x44BBDF0", VA = "0x1844BCDF0")]
		public EDHEJEIMPBC(GKHPBLLBAIL<TIn> DJINKFAKHDB, Func<TIn, TOut> JFBCMFKBFGD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x44BCD50", Offset = "0x44BBD50", VA = "0x1844BCD50", Slot = "10")]
		protected override void OOJMHCEGIPO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x44BCA30", Offset = "0x44BBA30", VA = "0x1844BCA30")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(EDHEJEIMPBC<, >.DOCGPFCBNJK))]
		internal static Task<TOut> OJHNGICMHGA(Task<TIn> JMCJINFHCPM, Func<TIn, TOut> JFBCMFKBFGD)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x38EE160", Offset = "0x38ED160", VA = "0x1838EE160")]
	public static GKHPBLLBAIL<T> KKKNNENCOAG<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x38EE1E0", Offset = "0x38ED1E0", VA = "0x1838EE1E0")]
	public static GKHPBLLBAIL<T> LLKNAJOIBFC<T>(T OBOOAPELMPF, [Optional] Action<T>? AAMIKNLELJB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x36A7050", Offset = "0x36A6050", VA = "0x1836A7050")]
	public static GKHPBLLBAIL<T> JNFNLNKDDKN<T>(Exception GGOAKKKDCJN) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x36A7050", Offset = "0x36A6050", VA = "0x1836A7050")]
	public static GKHPBLLBAIL<T> MPGIFLAHCPM<T>(Task<GKHPBLLBAIL<T>> BGKKDAHMDLM) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x36E6230", Offset = "0x36E5230", VA = "0x1836E6230")]
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
		[Cpp2IlInjected.Address(RVA = "0xC64A00", Offset = "0xC63A00", VA = "0x180C64A00", Slot = "6")]
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
	[Cpp2IlInjected.Address(RVA = "0x4FDED00", Offset = "0x4FDDD00", VA = "0x184FDED00")]
	public KILOAPHPNHN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x4FDE940", Offset = "0x4FDD940", VA = "0x184FDE940", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x403A4D0", Offset = "0x40394D0", VA = "0x18403A4D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x403A7A0", Offset = "0x40397A0", VA = "0x18403A7A0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public LGEMMOGNKGN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x510B810", Offset = "0x510A810", VA = "0x18510B810")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public override KGAPFDAFEHM<T> EGIIHJEIKEG
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x4A79BF0", Offset = "0x4A78BF0", VA = "0x184A79BF0")]
	protected GFMCNLLODOK(TTask BGKKDAHMDLM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x4A79990", Offset = "0x4A78990", VA = "0x184A79990", Slot = "10")]
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
		[Cpp2IlInjected.Address(RVA = "0x495A190", Offset = "0x4959190", VA = "0x18495A190", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public override KGAPFDAFEHM<T> EGIIHJEIKEG
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x5306DF0", Offset = "0x5305DF0", VA = "0x185306DF0")]
	public MCEGMPENJEF(CLCFAKNAJCK<Task<T>> GBHMCDAPJFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x5306DD0", Offset = "0x5305DD0", VA = "0x185306DD0", Slot = "10")]
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
	[Cpp2IlInjected.Address(RVA = "0x7C284F0", Offset = "0x7C274F0", VA = "0x187C284F0")]
	public static int AOIHFEDMPNN(this EJMDGDGNKJJ NDBNPOHKMHJ, IncrementalHash CNOOJBJPLMK, byte[] KFJFCJKAIMO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x7C28C60", Offset = "0x7C27C60", VA = "0x187C28C60")]
	public static bool NLCCKIDEGGG([CanBeNull] this EJMDGDGNKJJ NDBNPOHKMHJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x7C28610", Offset = "0x7C27610", VA = "0x187C28610")]
	public static bool NLCCKIDEGGG([CanBeNull] this EJMDGDGNKJJ NDBNPOHKMHJ, [Out] string JHEMEKBLBHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x7C28920", Offset = "0x7C27920", VA = "0x187C28920")]
	public static bool NLCCKIDEGGG([CanBeNull] this EJMDGDGNKJJ NDBNPOHKMHJ, IncrementalHash CNOOJBJPLMK, byte[] KFJFCJKAIMO, [Out] string JHEMEKBLBHP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x7C28580", Offset = "0x7C27580", VA = "0x187C28580")]
	private static bool LBAIKBOCCMP(byte[] JKLKIJJHOOF, Span<byte> DOGJODDEIFE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class CNEOFNBHKHD
{
	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x7C27E80", Offset = "0x7C26E80", VA = "0x187C27E80")]
	public static int CMFADHJCKNM(HashAlgorithmName FOECKGNFIID)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x36591F0", Offset = "0x36581F0", VA = "0x1836591F0")]
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
	[Cpp2IlInjected.Address(RVA = "0x3839BB0", Offset = "0x3838BB0", VA = "0x183839BB0")]
	public static void NJGJGEAOBMF<T>(this IncrementalHash FOFBMAJGNBJ, [CanBeNull] T HABFEKNHDFB) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x3839600", Offset = "0x3838600", VA = "0x183839600")]
	public static void JADKJPDOKAL<T>(this IncrementalHash FOFBMAJGNBJ, [CanBeNull] T OEJCHKIAEOP) where T : MFJKOPKJMGJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x3839690", Offset = "0x3838690", VA = "0x183839690")]
	public static void LONIFHELBOC<T>(this IncrementalHash FOFBMAJGNBJ, [CanBeNull] IList<T> MDIHNBCKKBB) where T : MFJKOPKJMGJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x7C295C0", Offset = "0x7C285C0", VA = "0x187C295C0")]
	private static bool EKMICEANEBI([CanBeNull] MFJKOPKJMGJ OEJCHKIAEOP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x7C291B0", Offset = "0x7C281B0", VA = "0x187C291B0")]
	public static void EGLAKJBLCCB(this IncrementalHash CNOOJBJPLMK, string? JFHBGFEOFIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x7C29650", Offset = "0x7C28650", VA = "0x187C29650")]
	public static void EOOGCGENELJ(this IncrementalHash CNOOJBJPLMK, long GPCCHDDCNJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x7C29A50", Offset = "0x7C28A50", VA = "0x187C29A50")]
	public static void LPEGADLGHBK(this IncrementalHash CNOOJBJPLMK, int LKALAMMFPOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x7C29880", Offset = "0x7C28880", VA = "0x187C29880")]
	public static void GNCCNEKJIFA(this IncrementalHash CNOOJBJPLMK, short HDJMAOIGMDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x7C29040", Offset = "0x7C28040", VA = "0x187C29040")]
	public static void BCJAAJCAHJL(this IncrementalHash CNOOJBJPLMK, byte LHNLFPPOHNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x7C28ED0", Offset = "0x7C27ED0", VA = "0x187C28ED0")]
	public static void ANOEMAFOOKJ(this IncrementalHash CNOOJBJPLMK, bool CDKMIEFFONM, bool CFLIMHPAPHG = false, bool KEJMOFONKLI = false, bool IFPDKJHKCGA = false, bool OLNDCAKGOJB = false, bool DFGJIOABGEG = false, bool IHALKGMEGIO = false, bool KCHBBKNBJDG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x3839C70", Offset = "0x3838C70", VA = "0x183839C70")]
	public static void OGPFFMNHMKL<T>(this IncrementalHash CNOOJBJPLMK, T PCHMHBNEGIN) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x7C28E10", Offset = "0x7C27E10", VA = "0x187C28E10")]
	public static void AGMJLAICHBF(this IncrementalHash CNOOJBJPLMK, float OBIIIEEADDN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x7C28E70", Offset = "0x7C27E70", VA = "0x187C28E70")]
	public static void AMJKEBEEEEH(this IncrementalHash CNOOJBJPLMK, ulong GIEJBNNIGBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x7C29820", Offset = "0x7C28820", VA = "0x187C29820")]
	public static void FGMCLMDIPNG(this IncrementalHash CNOOJBJPLMK, uint JOHNHCMHGCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x7C29150", Offset = "0x7C28150", VA = "0x187C29150")]
	public static void DCHKGFJBFNJ(this IncrementalHash CNOOJBJPLMK, ushort NJBBLNAAOKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x7C29C20", Offset = "0x7C28C20", VA = "0x187C29C20")]
	public static void OPCDEIJOLDL(this IncrementalHash CNOOJBJPLMK, Vector3 EMNAKJMLLAC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class PBOIFHAMLJC : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x7C2BDD0", Offset = "0x7C2ADD0", VA = "0x187C2BDD0")]
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
	[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
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
		[Cpp2IlInjected.Address(RVA = "0xAA5F80", Offset = "0xAA4F80", VA = "0x180AA5F80")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x9FA1F0", Offset = "0x9F91F0", VA = "0x1809FA1F0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public ushort HKIAMEGFMEI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x512AFA0", Offset = "0x5129FA0", VA = "0x18512AFA0")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x512AF90", Offset = "0x5129F90", VA = "0x18512AF90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public ushort IAFOLNGIPDH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x512AAD0", Offset = "0x5129AD0", VA = "0x18512AAD0")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x512B130", Offset = "0x512A130", VA = "0x18512B130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public ushort DGCDCEMBNKL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0xDB99E0", Offset = "0xDB89E0", VA = "0x180DB99E0")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0xDB9B00", Offset = "0xDB8B00", VA = "0x180DB9B00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public ushort BDBJIADCAOL
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x512B120", Offset = "0x512A120", VA = "0x18512B120")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x512AAC0", Offset = "0x5129AC0", VA = "0x18512AAC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	protected bool NDPCDNBFANI
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x1777490", Offset = "0x1776490", VA = "0x181777490")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	protected bool PDLMNDCONLL
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0xE8ADD0", Offset = "0xE89DD0", VA = "0x180E8ADD0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event MLIKPCFOPFB ILAGNNCHHDN
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x512AB90", Offset = "0x5129B90", VA = "0x18512AB90")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x512B010", Offset = "0x512A010", VA = "0x18512B010")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x512AE10", Offset = "0x5129E10", VA = "0x18512AE10")]
	private T HKAFEFLBPMG(ushort EHGEBFKCFJN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x512AED0", Offset = "0x5129ED0", VA = "0x18512AED0")]
	private T IGHHCMHDLPO(ushort EHGEBFKCFJN, ushort JLKINIEJBPN)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x512AFB0", Offset = "0x5129FB0", VA = "0x18512AFB0")]
	protected T IOEKEKIPDIB(uint EABPCDDIDGM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x512B3C0", Offset = "0x512A3C0", VA = "0x18512B3C0")]
	protected LNLNIOAFPJB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x512ADD0", Offset = "0x5129DD0", VA = "0x18512ADD0")]
	public void HCAGGNMMFPB(ushort NBFPFCLEDAC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x512AD70", Offset = "0x5129D70", VA = "0x18512AD70")]
	public void HCAGGNMMFPB(ushort NBFPFCLEDAC, ushort NPBMAEKFKJP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x512AC50", Offset = "0x5129C50", VA = "0x18512AC50", Slot = "4")]
	protected virtual void HCAGGNMMFPB(uint JNHCFBDFJKN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x512A230", Offset = "0x5129230", VA = "0x18512A230")]
	protected void BDELHCBPDNC(uint JNHCFBDFJKN, uint IMPNBPMIBHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x512AAE0", Offset = "0x5129AE0", VA = "0x18512AAE0")]
	protected void CIEBNDLEGFH(ushort EHGEBFKCFJN, ushort JLKINIEJBPN, T IDAKFFICKHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x512B0B0", Offset = "0x512A0B0", VA = "0x18512B0B0")]
	private void JOFOBNKNIKP(uint EABPCDDIDGM, T IDAKFFICKHC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x512B140", Offset = "0x512A140", VA = "0x18512B140")]
	protected void OHMINKCNCLK(float CJIPMCGKHCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x512B110", Offset = "0x512A110", VA = "0x18512B110")]
	protected uint LFIFACILCCO(ushort EHGEBFKCFJN, ushort JLKINIEJBPN)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x512AC40", Offset = "0x5129C40", VA = "0x18512AC40")]
	protected ushort EOHCAHBHMJC(uint AGLEOCCBHLD)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x512AC30", Offset = "0x5129C30", VA = "0x18512AC30")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public KDMNGAPOHLH KBJHOKBMNDG
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public MKDNPGPMJEC DFHPHCDPEKO
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x9F0CB0", Offset = "0x9EFCB0", VA = "0x1809F0CB0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x9F0CD0", Offset = "0x9EFCD0", VA = "0x1809F0CD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public DFAOIKNCMBF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x7C29FF0", Offset = "0x7C28FF0", VA = "0x187C29FF0")]
	public void ENAFEFPGJOD(ushort BHBMPIOAMGL, KDMNGAPOHLH LLDFJBJLGLA, KDMNGAPOHLH ADOOLNILPJJ, MKDNPGPMJEC GLPILNDJAPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x7C2A0D0", Offset = "0x7C290D0", VA = "0x187C2A0D0")]
	public void ENAFEFPGJOD(ushort EHGEBFKCFJN, ushort JLKINIEJBPN, KDMNGAPOHLH LLDFJBJLGLA, KDMNGAPOHLH ADOOLNILPJJ, MKDNPGPMJEC GLPILNDJAPD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x7C2A1B0", Offset = "0x7C291B0", VA = "0x187C2A1B0")]
	public void IEKHBJGOAKB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x7C27CD0", Offset = "0x7C26CD0", VA = "0x187C27CD0")]
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
		[Cpp2IlInjected.Address(RVA = "0xC11900", Offset = "0xC10900", VA = "0x180C11900")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0xCDD520", Offset = "0xCDC520", VA = "0x180CDD520")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x7C27C70", Offset = "0x7C26C70", VA = "0x187C27C70")]
	public void ANJKPBDKBKO(ushort EPKKNLPDGFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x7C27C10", Offset = "0x7C26C10", VA = "0x187C27C10")]
	public void ANJKPBDKBKO(ushort EPKKNLPDGFO, ushort NMFFAPHEICD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x7C27CD0", Offset = "0x7C26CD0", VA = "0x187C27CD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
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
		[Cpp2IlInjected.Address(RVA = "0x162A720", Offset = "0x1629720", VA = "0x18162A720")]
		public GJLHODNMILJ(int DPEJEDCKJBD, TClaimant FNMMPCMKINA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x4A87540", Offset = "0x4A86540", VA = "0x184A87540")]
		public bool GMLAKKFLBOI([In] GJLHODNMILJ MIJLJBIHDMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x4A87530", Offset = "0x4A86530", VA = "0x184A87530")]
		public bool EIFCEJJPAAH([In] GJLHODNMILJ MIJLJBIHDMP)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x4A87520", Offset = "0x4A86520", VA = "0x184A87520", Slot = "4")]
		public int CompareTo(GJLHODNMILJ MIJLJBIHDMP)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x4A875A0", Offset = "0x4A865A0", VA = "0x184A875A0", Slot = "3")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0xE8B5B0", Offset = "0xE8A5B0", VA = "0x180E8B5B0")]
		[DebuggerHidden]
		public BJMAEDMABOA(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x63ABA00", Offset = "0x63AAA00", VA = "0x1863ABA00", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x63ABBE0", Offset = "0x63AABE0", VA = "0x1863ABBE0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x63ABAE0", Offset = "0x63AAAE0", VA = "0x1863ABAE0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x48C65B0", Offset = "0x48C55B0", VA = "0x1848C65B0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x512A070", Offset = "0x5129070", VA = "0x18512A070")]
	public LNKLJKBFMLI(DEOFKAABGIP MECLDBHCDJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x5128A10", Offset = "0x5127A10", VA = "0x185128A10")]
	public void DEFKBCPBPOF(TNode GOJJJBGJPAM, TNode FAMAONKAFDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x5128D00", Offset = "0x5127D00", VA = "0x185128D00")]
	public void EIKIFGINMNF(TClaimant FNMMPCMKINA, TNode NKOAGGOOJFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x5128AE0", Offset = "0x5127AE0", VA = "0x185128AE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x51284C0", Offset = "0x51274C0", VA = "0x1851284C0")]
	private void CDLMAKMBBIO(TClaimant FNMMPCMKINA, TNode BGIDPOPGKNJ, TNode NKOAGGOOJFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x5129310", Offset = "0x5128310", VA = "0x185129310")]
	private int GHGHMLNHJLJ()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x5128FB0", Offset = "0x5127FB0", VA = "0x185128FB0")]
	private void GAAPACIDHGO(TClaimant FNMMPCMKINA, TNode MLHHCEEFKIE, TNode GPLPPJLEDDP, int JGJHENCFMAJ = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x51294B0", Offset = "0x51284B0", VA = "0x1851294B0")]
	private void HLDJILOLHHK(GJLHODNMILJ GLDPDMHFJNG, DFOMKGEABGF MECICAJOHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x5128720", Offset = "0x5127720", VA = "0x185128720")]
	private void CIDCOCCJBBD(TClaimant FNMMPCMKINA, TNode MLHHCEEFKIE, TNode GPLPPJLEDDP, int JGJHENCFMAJ = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x5129380", Offset = "0x5128380", VA = "0x185129380")]
	private void HGGGBIMFKDF(GJLHODNMILJ GLDPDMHFJNG, TNode GOJJJBGJPAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x5129D20", Offset = "0x5128D20", VA = "0x185129D20")]
	private void PEFIDHACNPJ(GJLHODNMILJ GLDPDMHFJNG, DFOMKGEABGF MECICAJOHBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x5129BC0", Offset = "0x5128BC0", VA = "0x185129BC0")]
	private void MAENNJKDDOD(DFOMKGEABGF MECICAJOHBD, bool BLEOHBMKKAD = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x5129580", Offset = "0x5128580", VA = "0x185129580")]
	private void JHLPLMHLEIG(DFOMKGEABGF MECICAJOHBD, TNode FAMAONKAFDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x5129AD0", Offset = "0x5128AD0", VA = "0x185129AD0")]
	[IteratorStateMachine(typeof(LNKLJKBFMLI<, >.BJMAEDMABOA))]
	private IEnumerable<TNode> LFODIIFACBN(TNode MLHHCEEFKIE, TNode GPLPPJLEDDP, bool PLHHHGFHKPP = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x5128E90", Offset = "0x5127E90", VA = "0x185128E90")]
	private DFOMKGEABGF FKAEIKKBMIK(TNode GOJJJBGJPAM, TNode JHDAOHEONAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x5128590", Offset = "0x5127590", VA = "0x185128590")]
	private DFOMKGEABGF CGLCMPPDCHC(TNode GOJJJBGJPAM, TNode JHDAOHEONAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x5129900", Offset = "0x5128900", VA = "0x185129900")]
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
			[Cpp2IlInjected.Address(RVA = "0x44FAC80", Offset = "0x44F9C80", VA = "0x1844FAC80", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public HOFJAOLMJEK FFKIBMLIABP
		{
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x63A6E00", Offset = "0x63A5E00", VA = "0x1863A6E00", Slot = "4")]
			get
			{
				return default(HOFJAOLMJEK);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x63A6DC0", Offset = "0x63A5DC0", VA = "0x1863A6DC0")]
		public BHEEPHDOGKB(HOBCNHIEEIJ<T> DHPEMHCCIBM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x63A6D40", Offset = "0x63A5D40", VA = "0x1863A6D40", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x4560110", Offset = "0x455F110", VA = "0x184560110", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x112CAB0", Offset = "0x112BAB0", VA = "0x18112CAB0", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0xCFC9B0", Offset = "0xCFB9B0", VA = "0x180CFC9B0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xF0C6F0", Offset = "0xF0B6F0", VA = "0x180F0C6F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public int CMIOJAJFIMN
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x404C6F0", Offset = "0x404B6F0", VA = "0x18404C6F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x4B1F2C0", Offset = "0x4B1E2C0", VA = "0x184B1F2C0")]
	public HOBCNHIEEIJ(int GDBMBEIFFOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x4B1EA50", Offset = "0x4B1DA50", VA = "0x184B1EA50")]
	public HOBCNHIEEIJ(HOFJAOLMJEK[] JFDNIJOKIAG, bool HJHCMDKKBLP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x4B1E600", Offset = "0x4B1D600", VA = "0x184B1E600")]
	public int IHKAENPJNME()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x4B1DD30", Offset = "0x4B1CD30", VA = "0x184B1DD30")]
	private int AKABHHEBMIA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x4B1E950", Offset = "0x4B1D950", VA = "0x184B1E950", Slot = "6")]
	protected virtual uint MAJBBDAIHEL(uint CNOOJBJPLMK, T OHLIHBDBKCE)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x4B1E730", Offset = "0x4B1D730", VA = "0x184B1E730")]
	public bool JAOEPNGFPMK(T OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x4B1E790", Offset = "0x4B1D790", VA = "0x184B1E790")]
	public int KOMODOIIBMM(T OHLIHBDBKCE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x4B1E8E0", Offset = "0x4B1D8E0", VA = "0x184B1E8E0")]
	public T LNLLCGCJJDK(int OHHMJGCBCKD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x4B1E1E0", Offset = "0x4B1D1E0", VA = "0x184B1E1E0")]
	public bool EBIHDMMAINL(T OHLIHBDBKCE, bool FONIBMLGNKN = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x4B1DF70", Offset = "0x4B1CF70", VA = "0x184B1DF70")]
	public bool EBIHDMMAINL(T OHLIHBDBKCE, int OHHMJGCBCKD, bool FONIBMLGNKN = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x4B1E560", Offset = "0x4B1D560", VA = "0x184B1E560")]
	private int HGEAHADEFCP(int NGFMNKONPKM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x4B1E9B0", Offset = "0x4B1D9B0", VA = "0x184B1E9B0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x4B1E9B0", Offset = "0x4B1D9B0", VA = "0x184B1E9B0", Slot = "4")]
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
	[Cpp2IlInjected.Address(RVA = "0x63AF910", Offset = "0x63AE910", VA = "0x1863AF910")]
	public static BNJDBKKIAKE<T> BHOMFPFMNFM(int GDBMBEIFFOO = 0, int NKBLPCDBBDM = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x63AFEC0", Offset = "0x63AEEC0", VA = "0x1863AFEC0")]
	public static BNJDBKKIAKE<T> HKNPNJNHIHC(int GDBMBEIFFOO = 0, int NKBLPCDBBDM = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x63B02F0", Offset = "0x63AF2F0", VA = "0x1863B02F0")]
	public BNJDBKKIAKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x63B0340", Offset = "0x63AF340", VA = "0x1863B0340")]
	public BNJDBKKIAKE(int GDBMBEIFFOO, int NKBLPCDBBDM = int.MaxValue, bool FLLBLIPCPNC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x63AFB50", Offset = "0x63AEB50", VA = "0x1863AFB50")]
	public T CILCEMKBDAL()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x63AFFB0", Offset = "0x63AEFB0", VA = "0x1863AFFB0")]
	public void KKIPOBFIFOD(T OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x63AFA00", Offset = "0x63AEA00", VA = "0x1863AFA00")]
	private void BNDJLNJBCLN(T OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x63AFB00", Offset = "0x63AEB00", VA = "0x1863AFB00")]
	private void CCMDACKKPLK(T OHLIHBDBKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x63AFD30", Offset = "0x63AED30", VA = "0x1863AFD30", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x63B0090", Offset = "0x63AF090", VA = "0x1863B0090")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F0D20", Offset = "0x9EFD20", VA = "0x1809F0D20", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x9F0CC0", Offset = "0x9EFCC0", VA = "0x1809F0CC0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x4B0CA50", Offset = "0x4B0BA50", VA = "0x184B0CA50")]
	public bool KEOHOAAEDBA(T OHLIHBDBKCE, int DPEJEDCKJBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x4A44DD0", Offset = "0x4A43DD0", VA = "0x184A44DD0")]
	public bool BLDIAILIAMJ(int DPEJEDCKJBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x4B0CC00", Offset = "0x4B0BC00", VA = "0x184B0CC00")]
	public T NHAMDKOBEPI(int OMGGKMJKDGD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x4B0C970", Offset = "0x4B0B970", VA = "0x184B0C970")]
	private bool JJIOGHKNFOF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x4B0CBA0", Offset = "0x4B0BBA0", VA = "0x184B0CBA0")]
	public bool LKMKPGKLGLC(int DPEJEDCKJBD, [Out] T OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x4A4AAA0", Offset = "0x4A49AA0", VA = "0x184A4AAA0")]
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
		[Cpp2IlInjected.Address(RVA = "0x404C6F0", Offset = "0x404B6F0", VA = "0x18404C6F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x67A4790", Offset = "0x67A3790", VA = "0x1867A4790")]
	public bool DGAEJOHLCDJ(T OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x67A4EB0", Offset = "0x67A3EB0", VA = "0x1867A4EB0")]
	public void IIGLPCDPOEE(T OHLIHBDBKCE, int DPEJEDCKJBD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x67A4CB0", Offset = "0x67A3CB0", VA = "0x1867A4CB0")]
	public bool GNAALOCCJEL(T OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x67A5050", Offset = "0x67A4050", VA = "0x1867A5050")]
	public void INBDHNEFJBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x67A4A80", Offset = "0x67A3A80", VA = "0x1867A4A80")]
	public T FDCPMAJFLLE()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x67A5270", Offset = "0x67A4270", VA = "0x1867A5270")]
	protected void PIPAHOHNGCN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x67A5400", Offset = "0x67A4400", VA = "0x1867A5400")]
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
			[Cpp2IlInjected.Address(RVA = "0x7C2BF70", Offset = "0x7C2AF70", VA = "0x187C2BF70")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x7C2C240", Offset = "0x7C2B240", VA = "0x187C2C240")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x7C2C150", Offset = "0x7C2B150", VA = "0x187C2C150")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x7C2BEC0", Offset = "0x7C2AEC0", VA = "0x187C2BEC0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x7C2C190", Offset = "0x7C2B190", VA = "0x187C2C190")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x7C2C0A0", Offset = "0x7C2B0A0", VA = "0x187C2C0A0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x7C2BE30", Offset = "0x7C2AE30", VA = "0x187C2BE30")]
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
		[Cpp2IlInjected.Address(RVA = "0x5807DA0", Offset = "0x5806DA0", VA = "0x185807DA0", Slot = "4")]
		public virtual T AAIJCDOFJJE()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class HAKEILCBHCI : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private Dictionary<byte, IKAGKBMGHOM> MIEMFKOJIKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000126")]
	private readonly BNJDBKKIAKE<IKAGKBMGHOM> MBHAFFLCNKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000127")]
	private readonly bool DNMNNCKHHKN;

	[Cpp2IlInjected.Token(Token = "0x17000070")]
	public IKAGKBMGHOM PNPFICMPHFH
	{
		[Cpp2IlInjected.Token(Token = "0x6000235")]
		[Cpp2IlInjected.Address(RVA = "0x9F1570", Offset = "0x9F0570", VA = "0x1809F1570")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000236")]
		[Cpp2IlInjected.Address(RVA = "0x9F1540", Offset = "0x9F0540", VA = "0x1809F1540")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000071")]
	public Vector2 MCEIDGGEKNG
	{
		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x15B0DD0", Offset = "0x15AFDD0", VA = "0x1815B0DD0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0xC5C130", Offset = "0xC5B130", VA = "0x180C5C130")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000072")]
	private Vector2 ANKHCJPOABP
	{
		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0xC8C980", Offset = "0xC8B980", VA = "0x180C8C980")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public Vector2 KKKJBLMLFKL
	{
		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x7C2B440", Offset = "0x7C2A440", VA = "0x187C2B440")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x9F1790", Offset = "0x9F0790", VA = "0x1809F1790")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public int LICEFKHPNEA
	{
		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x9F6440", Offset = "0x9F5440", VA = "0x1809F6440")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x9F67F0", Offset = "0x9F57F0", VA = "0x1809F67F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600023E")]
	[Cpp2IlInjected.Address(RVA = "0x7C2B590", Offset = "0x7C2A590", VA = "0x187C2B590")]
	public HAKEILCBHCI(Bounds CFBONCKIPEA, Vector2[] HAAKMDMCFJF, int ABBFFJJKAOA, byte NGFMNKONPKM, float EACAFFDKFHO = 0f, [Optional] BNJDBKKIAKE<IKAGKBMGHOM> MBHAFFLCNKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600023F")]
	[Cpp2IlInjected.Address(RVA = "0x7C2AD90", Offset = "0x7C29D90", VA = "0x187C2AD90")]
	public void JHIHLMOHKAE(Bounds CFBONCKIPEA, Vector2[] HAAKMDMCFJF, int ABBFFJJKAOA, byte NGFMNKONPKM, float EACAFFDKFHO = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000240")]
	[Cpp2IlInjected.Address(RVA = "0x7C2B460", Offset = "0x7C2A460", VA = "0x187C2B460")]
	public IKAGKBMGHOM NIJCMKLJOHJ(byte OHHMJGCBCKD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000241")]
	[Cpp2IlInjected.Address(RVA = "0x7C2B4C0", Offset = "0x7C2A4C0", VA = "0x187C2B4C0")]
	public void NPCFLBOACGL(Vector3 EPCLGOKLIPO, float GAJEILJFJMF, float EDAEECFOGJI, List<byte> LOIJHAOAPAO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000242")]
	[Cpp2IlInjected.Address(RVA = "0x7C2AD70", Offset = "0x7C29D70", VA = "0x187C2AD70")]
	public void HPIKLCIJIJF(IKAGKBMGHOM.GKABJEIKACI BLFAPIFJFDA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000243")]
	[Cpp2IlInjected.Address(RVA = "0x7C2A5E0", Offset = "0x7C295E0", VA = "0x187C2A5E0")]
	public static int BJGBEHMBHMC(Vector2[] HAAKMDMCFJF, int ABBFFJJKAOA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x7C2AA80", Offset = "0x7C29A80", VA = "0x187C2AA80")]
	private IKAGKBMGHOM DDMDEEBOKFL(byte OHHMJGCBCKD, IKAGKBMGHOM.BPCGHEJDIEN PHMEJPGIIAA, IKAGKBMGHOM JHDAOHEONAC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x7C2A6C0", Offset = "0x7C296C0", VA = "0x187C2A6C0")]
	private void BKAKCFFKOLG(IKAGKBMGHOM JHDAOHEONAC, Vector2[] HAAKMDMCFJF, int KFHNOPFIPLD, int ILJFBECOIOB, int GCIKBMDDHKB, int JBLKMMIHCHH, float EACAFFDKFHO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x7C2B220", Offset = "0x7C2A220", VA = "0x187C2B220")]
	private void KJOJBNECHKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x7C2ACB0", Offset = "0x7C29CB0", VA = "0x187C2ACB0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x7C2AD10", Offset = "0x7C29D10", VA = "0x187C2AD10", Slot = "1")]
	~HAKEILCBHCI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public class IKAGKBMGHOM
{
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	public enum BPCGHEJDIEN
	{
		[Cpp2IlInjected.Token(Token = "0x4000132")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000133")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000134")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x2000079")]
	public enum GKABJEIKACI
	{
		[Cpp2IlInjected.Token(Token = "0x4000136")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000137")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000138")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x4000139")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000128")]
	public byte OJLJBFKDCDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	public Vector3 OFCFOHFJKJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	public Vector3 EOMGDLMNCFL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	public Vector3 MHNLLIBMOAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	public Vector3 KKBBHFMIKCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	public BPCGHEJDIEN LIJJKLIKGOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	public IKAGKBMGHOM LHCPKJJPDMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400012F")]
	public List<IKAGKBMGHOM> FEMHMJJCBAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000130")]
	public bool CJGABMGAGDM;

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x7C2BAE0", Offset = "0x7C2AAE0", VA = "0x187C2BAE0")]
	public IKAGKBMGHOM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x7C2B710", Offset = "0x7C2A710", VA = "0x187C2B710")]
	public void JHHBOOEOKAN(IKAGKBMGHOM HMCFPGIFOED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024B")]
	[Cpp2IlInjected.Address(RVA = "0x9F0220", Offset = "0x9EF220", VA = "0x1809F0220")]
	public void HPIKLCIJIJF(int LMINPDMIGNO, GKABJEIKACI BLFAPIFJFDA, int GIPBFCLFIAF = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024C")]
	[Cpp2IlInjected.Address(RVA = "0x7C2B880", Offset = "0x7C2A880", VA = "0x187C2B880")]
	public void NPCFLBOACGL(List<byte> LOIJHAOAPAO, Vector3 EPCLGOKLIPO, float GAJEILJFJMF, float EDAEECFOGJI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024D")]
	[Cpp2IlInjected.Address(RVA = "0x7C2B850", Offset = "0x7C2A850", VA = "0x187C2B850")]
	public bool LOCONKLPIOJ(Vector3 DJHCIGKJNEI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024E")]
	[Cpp2IlInjected.Address(RVA = "0x7C2B6E0", Offset = "0x7C2A6E0", VA = "0x187C2B6E0")]
	public bool CAILMMCLPOD(Vector3 DJHCIGKJNEI, float PLMHPCKKFNF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600024F")]
	[Cpp2IlInjected.Address(RVA = "0x7C2B650", Offset = "0x7C2A650", VA = "0x187C2B650")]
	public void ANJKPBDKBKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public interface ECFMAOOGLDK
{
	[Cpp2IlInjected.Token(Token = "0x17000075")]
	ToolHierarchyCache JCLAPKGEIFE
	{
		[Cpp2IlInjected.Token(Token = "0x6000250")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x200007B")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x200007C")]
		public struct KJMLNCDOFEF<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400013E")]
			private readonly List<Component> OLEDHEBBJPH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400013F")]
			private readonly bool PLJFHNDJAFC;

			[Cpp2IlInjected.Token(Token = "0x600025D")]
			[Cpp2IlInjected.Address(RVA = "0x17930E0", Offset = "0x17920E0", VA = "0x1817930E0")]
			public KJMLNCDOFEF(List<Component> OLEDHEBBJPH, bool PLJFHNDJAFC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600025E")]
			[Cpp2IlInjected.Address(RVA = "0x4FE18F0", Offset = "0x4FE08F0", VA = "0x184FE18F0")]
			public MNLJEBIDHMH<T> OMLAPONJPHN()
			{
				return default(MNLJEBIDHMH<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x600025F")]
			[Cpp2IlInjected.Address(RVA = "0x4FE1950", Offset = "0x4FE0950", VA = "0x184FE1950", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000260")]
			[Cpp2IlInjected.Address(RVA = "0x4FE1950", Offset = "0x4FE0950", VA = "0x184FE1950", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200007D")]
		public struct MNLJEBIDHMH<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000140")]
			private readonly List<Component> OLEDHEBBJPH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000141")]
			private readonly bool PLJFHNDJAFC;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000142")]
			private int OHHMJGCBCKD;

			[Cpp2IlInjected.Token(Token = "0x17000077")]
			public T FFKIBMLIABP
			{
				[Cpp2IlInjected.Token(Token = "0x6000262")]
				[Cpp2IlInjected.Address(RVA = "0x5352E70", Offset = "0x5351E70", VA = "0x185352E70", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000078")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000263")]
				[Cpp2IlInjected.Address(RVA = "0x5352E00", Offset = "0x5351E00", VA = "0x185352E00", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000261")]
			[Cpp2IlInjected.Address(RVA = "0x5352E40", Offset = "0x5351E40", VA = "0x185352E40")]
			public MNLJEBIDHMH(List<Component> OLEDHEBBJPH, bool PLJFHNDJAFC)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000264")]
			[Cpp2IlInjected.Address(RVA = "0x5352D40", Offset = "0x5351D40", VA = "0x185352D40", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000265")]
			[Cpp2IlInjected.Address(RVA = "0x5352D50", Offset = "0x5351D50", VA = "0x185352D50", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000266")]
			[Cpp2IlInjected.Address(RVA = "0x454D940", Offset = "0x454C940", VA = "0x18454D940", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x400013A")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400013B")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x400013C")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400013D")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x17000076")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000251")]
			[Cpp2IlInjected.Address(RVA = "0x7C2DC70", Offset = "0x7C2CC70", VA = "0x187C2DC70")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000252")]
		[Cpp2IlInjected.Address(RVA = "0x9FFF60", Offset = "0x9FEF60", VA = "0x1809FFF60")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000253")]
		[Cpp2IlInjected.Address(RVA = "0x7C2D550", Offset = "0x7C2C550", VA = "0x187C2D550")]
		private void ANJKPBDKBKO(GameObject NHAAFJKFJLE, bool ECOALLGHBMI = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000254")]
		[Cpp2IlInjected.Address(RVA = "0x7C2D6C0", Offset = "0x7C2C6C0", VA = "0x187C2D6C0")]
		public static void ANJKPBDKBKO(GameObject NHAAFJKFJLE, ToolHierarchyCache FEHNEKGGBGC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000255")]
		[Cpp2IlInjected.Address(RVA = "0x7C2D750", Offset = "0x7C2C750", VA = "0x187C2D750")]
		public void CBCKGPMMHOP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000256")]
		[Cpp2IlInjected.Address(RVA = "0x3B5B060", Offset = "0x3B5A060", VA = "0x183B5B060")]
		public void KKFNFICBAJF<T>(Action<T> BDCLNIJAFBF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0x3B5AFC0", Offset = "0x3B59FC0", VA = "0x183B5AFC0")]
		public T JGDPLOLFKKH<T>(bool PLJFHNDJAFC = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x3B5B2A0", Offset = "0x3B5A2A0", VA = "0x183B5B2A0")]
		public KJMLNCDOFEF<T> LFLCKMKGJPH<T>(bool PLJFHNDJAFC = false) where T : class
		{
			return default(KJMLNCDOFEF<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x7C2D850", Offset = "0x7C2C850", VA = "0x187C2D850")]
		public List<Component> IGOBHIAFLKF(Type MLCOGCMJLBB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x7C2D760", Offset = "0x7C2C760", VA = "0x187C2D760", Slot = "4")]
		public bool Equals(ToolHierarchyCache CEJAAIDLEPA, ToolHierarchyCache IMNDAJIDDFG)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x7C2D7E0", Offset = "0x7C2C7E0", VA = "0x187C2D7E0", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache BOMDCGFKGKF)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007E")]
public class FLPGFEDBKGN<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000143")]
	private int GDBMBEIFFOO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000144")]
	private int ONNLBAOHLJN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000145")]
	private List<T> PFOGKPFJJDP;

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public int CMIOJAJFIMN
	{
		[Cpp2IlInjected.Token(Token = "0x6000267")]
		[Cpp2IlInjected.Address(RVA = "0x495A190", Offset = "0x4959190", VA = "0x18495A190")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public T ACAGEKDEDPM
	{
		[Cpp2IlInjected.Token(Token = "0x6000268")]
		[Cpp2IlInjected.Address(RVA = "0x498DF10", Offset = "0x498CF10", VA = "0x18498DF10")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007B")]
	public T IJHOAMOEKLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000269")]
		[Cpp2IlInjected.Address(RVA = "0x498DAA0", Offset = "0x498CAA0", VA = "0x18498DAA0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007C")]
	public T LNKGIBKMBKP
	{
		[Cpp2IlInjected.Token(Token = "0x600026A")]
		[Cpp2IlInjected.Address(RVA = "0x498D810", Offset = "0x498C810", VA = "0x18498D810")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600026B")]
	[Cpp2IlInjected.Address(RVA = "0x498E140", Offset = "0x498D140", VA = "0x18498E140")]
	public FLPGFEDBKGN(int GDBMBEIFFOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026C")]
	[Cpp2IlInjected.Address(RVA = "0x498DB40", Offset = "0x498CB40", VA = "0x18498DB40")]
	public void IIGLPCDPOEE(T FJMDAONKMLE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026D")]
	[Cpp2IlInjected.Address(RVA = "0x498DE20", Offset = "0x498CE20", VA = "0x18498DE20")]
	public void INBDHNEFJBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026E")]
	[Cpp2IlInjected.Address(RVA = "0x498D930", Offset = "0x498C930", VA = "0x18498D930")]
	public void GJJOHGHPMKN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600026F")]
	[Cpp2IlInjected.Address(RVA = "0x498E0D0", Offset = "0x498D0D0", VA = "0x18498E0D0")]
	public void POOEPECNPOE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000270")]
	[Cpp2IlInjected.Address(RVA = "0x498D920", Offset = "0x498C920", VA = "0x18498D920")]
	public void DDNANNMFEPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000271")]
	[Cpp2IlInjected.Address(RVA = "0x498DE80", Offset = "0x498CE80", VA = "0x18498DE80")]
	public List<T> MLOOJOLJFJO()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007F")]
public class LBBJFFOLGFF<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000080")]
	private struct PFICOGHMJAF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014A")]
		public int MHNIDGOLKKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400014B")]
		public T FPGFCMMHMJG;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000146")]
	private readonly Dictionary<object, PFICOGHMJAF> BCFIBNCLPAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000147")]
	private readonly EqualityComparer<T> IPPEFIAKPDE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000148")]
	private T LLKFHJPNIMF;

	[Cpp2IlInjected.Token(Token = "0x1700007D")]
	public virtual T KKHJPLHIMOJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000272")]
		[Cpp2IlInjected.Address(RVA = "0xD021C0", Offset = "0xD011C0", VA = "0x180D021C0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000273")]
		[Cpp2IlInjected.Address(RVA = "0x50A3F20", Offset = "0x50A2F20", VA = "0x1850A3F20", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007E")]
	public bool HJEIAMHJLEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000274")]
		[Cpp2IlInjected.Address(RVA = "0x50A3F60", Offset = "0x50A2F60", VA = "0x1850A3F60")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007F")]
	public object GADKFGKFHAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000275")]
		[Cpp2IlInjected.Address(RVA = "0x9F1510", Offset = "0x9F0510", VA = "0x1809F1510")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000276")]
		[Cpp2IlInjected.Address(RVA = "0x9F32B0", Offset = "0x9F22B0", VA = "0x1809F32B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000277")]
	[Cpp2IlInjected.Address(RVA = "0x50A6E10", Offset = "0x50A5E10", VA = "0x1850A6E10")]
	public bool KEOHOAAEDBA(T OHLIHBDBKCE, object EJJDDFFADPC, int DPEJEDCKJBD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000278")]
	[Cpp2IlInjected.Address(RVA = "0x50A3E00", Offset = "0x50A2E00", VA = "0x1850A3E00")]
	public bool BLDIAILIAMJ(object EJJDDFFADPC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000279")]
	[Cpp2IlInjected.Address(RVA = "0x50A7C90", Offset = "0x50A6C90", VA = "0x1850A7C90")]
	public bool LKMKPGKLGLC(object EJJDDFFADPC, [Out] T OHLIHBDBKCE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027A")]
	[Cpp2IlInjected.Address(RVA = "0x4AF9F90", Offset = "0x4AF8F90", VA = "0x184AF9F90")]
	public void INBDHNEFJBE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600027B")]
	[Cpp2IlInjected.Address(RVA = "0x50A5770", Offset = "0x50A4770", VA = "0x1850A5770")]
	private bool JJIOGHKNFOF()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600027C")]
	[Cpp2IlInjected.Address(RVA = "0x50A8510", Offset = "0x50A7510", VA = "0x1850A8510")]
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
