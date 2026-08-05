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
		[Cpp2IlInjected.Address(RVA = "0xA1A8A0", Offset = "0xA19AA0", VA = "0x180A1A8A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C5E690", Offset = "0x7C5D890", VA = "0x187C5E690")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xA1B770", Offset = "0xA1A970", VA = "0x180A1B770")]
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
		[Cpp2IlInjected.Address(RVA = "0xA1B7B0", Offset = "0xA1A9B0", VA = "0x180A1B7B0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class ALHMPNPDBIN : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2087970", Offset = "0x2086B70", VA = "0x182087970")]
	public ALHMPNPDBIN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HashableScriptableObject : ScriptableObject, ABOGIEJNNMO, JAMOOGIBOOM, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AC0", Offset = "0x9F0CC0", VA = "0x1809F1AC0", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xC84900", Offset = "0xC83B00", VA = "0x180C84900", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash BDJMEJKDJOJ);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0xBC3030", Offset = "0xBC2230", VA = "0x180BC3030")]
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
		[Cpp2IlInjected.Address(RVA = "0x7C60170", Offset = "0x7C5F370", VA = "0x187C60170")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x7C60130", Offset = "0x7C5F330", VA = "0x187C60130")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x7C601B0", Offset = "0x7C5F3B0", VA = "0x187C601B0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x7C60360", Offset = "0x7C5F560", VA = "0x187C60360")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x7C602D0", Offset = "0x7C5F4D0", VA = "0x187C602D0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xEE8B50", Offset = "0xEE7D50", VA = "0x180EE8B50")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xD407C0", Offset = "0xD3F9C0", VA = "0x180D407C0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x7C600F0", Offset = "0x7C5F2F0", VA = "0x187C600F0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x7C60240", Offset = "0x7C5F440", VA = "0x187C60240")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x7C5FD40", Offset = "0x7C5EF40", VA = "0x187C5FD40")]
	public void CopyBounds(SavedExtents FNJGMJGALLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x7C60040", Offset = "0x7C5F240", VA = "0x187C60040")]
	public void SetLocalSpaceBounds(Bounds EJEKMLHINCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1422780", Offset = "0x1421980", VA = "0x181422780")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x7C60030", Offset = "0x7C5F230", VA = "0x187C60030")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x7C5F550", Offset = "0x7C5E750", VA = "0x187C5F550")]
	private void AMIGJFGJPAJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x7C5FE30", Offset = "0x7C5F030", VA = "0x187C5FE30")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x7C5F700", Offset = "0x7C5E900", VA = "0x187C5F700")]
	public static void CalculateLocalBoundsFor(GameObject GNOLFLMODHC, [Out] Bounds EJEKMLHINCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x7C5FD70", Offset = "0x7C5EF70", VA = "0x187C5FD70")]
	private static void IAPFLNIFNFI(Bounds PMDPDEMGJJE, Color FLCLDMGPCKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x7C60060", Offset = "0x7C5F260", VA = "0x187C60060")]
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
		[Cpp2IlInjected.Address(RVA = "0x9EF1A0", Offset = "0x9EE3A0", VA = "0x1809EF1A0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x9FC7C0", Offset = "0x9FB9C0", VA = "0x1809FC7C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x18E5C10", Offset = "0x18E4E10", VA = "0x1818E5C10")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x585A3A0", Offset = "0x58595A0", VA = "0x18585A3A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public virtual void MPJJHOEBPLG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
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
	[ALHMPNPDBIN]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5859F10", Offset = "0x5859110", VA = "0x185859F10", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5858AE0", Offset = "0x5857CE0", VA = "0x185858AE0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x585A2C0", Offset = "0x58594C0", VA = "0x18585A2C0")]
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
	private sealed class AOBMJDIMHAN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public AOBMJDIMHAN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x4C91480", Offset = "0x4C90680", VA = "0x184C91480")]
		internal int NEAGAEPJIDM(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[SerializeField]
	[ALHMPNPDBIN]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x4553BF0", Offset = "0x4552DF0", VA = "0x184553BF0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4553C50", Offset = "0x4552E50", VA = "0x184553C50", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4553AD0", Offset = "0x4552CD0", VA = "0x184553AD0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey AGBHGDFILGO]
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4553B90", Offset = "0x4552D90", VA = "0x184553B90", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4553980", Offset = "0x4552B80", VA = "0x184553980", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4553620", Offset = "0x4552820", VA = "0x184553620", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x45529E0", Offset = "0x4551BE0", VA = "0x1845529E0", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4552950", Offset = "0x4551B50", VA = "0x184552950", Slot = "14")]
	protected virtual string HKPDGHHJHBK(TKeyVal EFEGEHDMNKM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4552850", Offset = "0x4551A50", VA = "0x184552850", Slot = "4")]
	public bool ContainsKey(TKey AGBHGDFILGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4553800", Offset = "0x4552A00", VA = "0x184553800", Slot = "5")]
	public bool TryGetValue(TKey AGBHGDFILGO, [Out] TVal MLCDCHNOCFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x45528B0", Offset = "0x4551AB0", VA = "0x1845528B0", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x45528B0", Offset = "0x4551AB0", VA = "0x1845528B0", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4553860", Offset = "0x4552A60", VA = "0x184553860")]
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
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x44F4310", Offset = "0x44F3510", VA = "0x1844F4310")]
		public SerializedReferenceKeyValuePair()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[SerializeField]
	[ALHMPNPDBIN]
	private List<SerializedReferenceKeyValuePair> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x585BD90", Offset = "0x585AF90", VA = "0x18585BD90")]
	protected SerializedReferenceDictionary()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x585B5D0", Offset = "0x585A7D0", VA = "0x18585B5D0", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x585AB80", Offset = "0x5859D80", VA = "0x18585AB80", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class FMNJAKCAIBB<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct GLOOGHIKDJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public T ABLHJAOAOGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public float MIOFIINCDIE;
	}

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private const int FJAELLAADPL = 16;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private const float KFHDKJOBKAH = -1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	protected readonly GLOOGHIKDJE[] CABEAFGDMFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	protected int DMMCKJJEDJK;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public float MCBLEOMNCCL
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xC22800", Offset = "0xC21A00", VA = "0x180C22800")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xC66390", Offset = "0xC65590", VA = "0x180C66390")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public T ICABEMKAPMP
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x49AFF40", Offset = "0x49AF140", VA = "0x1849AFF40")]
	protected FMNJAKCAIBB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x49AFF80", Offset = "0x49AF180", VA = "0x1849AFF80")]
	protected FMNJAKCAIBB(int JAFKPMJIGFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x49AFD10", Offset = "0x49AEF10", VA = "0x1849AFD10")]
	public void OOLDDNFEGEK(float ALBGFINLCPH, T MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool NEEKIDBPEGM(float EGLLDLKJACK, float EOPOJMMBBAN, [Out] T MLCDCHNOCFI);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool CEGGEEBMCGG(float EGLLDLKJACK, float EOPOJMMBBAN, [Out] T MLCDCHNOCFI);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x49AFC40", Offset = "0x49AEE40", VA = "0x1849AFC40")]
	public void FKFEALEGJFP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class CIDADBHGKPF : FMNJAKCAIBB<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x7C5C5E0", Offset = "0x7C5B7E0", VA = "0x187C5C5E0", Slot = "4")]
	public override bool NEEKIDBPEGM(float EGLLDLKJACK, float EOPOJMMBBAN, [Out] Vector3 MLCDCHNOCFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x7C5C4A0", Offset = "0x7C5B6A0", VA = "0x187C5C4A0", Slot = "5")]
	public override bool CEGGEEBMCGG(float EGLLDLKJACK, float EOPOJMMBBAN, [Out] Vector3 MLCDCHNOCFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x7C5C740", Offset = "0x7C5B940", VA = "0x187C5C740")]
	public CIDADBHGKPF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class NKMOKAJIIEP
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3987CE0", Offset = "0x3986EE0", VA = "0x183987CE0")]
	public static IONGDEHMNIL<T1, T2> EAIFKKLDBGP<T1, T2>(T1 FEAEDLBKGBE, T2 MADECNNMCPB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3987D80", Offset = "0x3986F80", VA = "0x183987D80")]
	public static JMKNJBFMIBB<T1, T2, T3> EAIFKKLDBGP<T1, T2, T3>(T1 FEAEDLBKGBE, T2 MADECNNMCPB, T3 NAHELCKONNA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x535D090", Offset = "0x535C290", VA = "0x18535D090")]
	internal static int DLMLAOPNFIN(int OHFFBILFLDC, int GKIEPCHKHKE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x6E60D00", Offset = "0x6E5FF00", VA = "0x186E60D00")]
	internal static int DLMLAOPNFIN(int OHFFBILFLDC, int GKIEPCHKHKE, int HMBKPLFBBDJ)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class IONGDEHMNIL<T1, T2> : IComparable<IONGDEHMNIL<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly T1 FEJMGLABIPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly T2 GJEEKACEFID;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x4CABD80", Offset = "0x4CAAF80", VA = "0x184CABD80")]
	public IONGDEHMNIL(T1 FEAEDLBKGBE, T2 MADECNNMCPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x4CAA330", Offset = "0x4CA9530", VA = "0x184CAA330", Slot = "4")]
	public int CompareTo(IONGDEHMNIL<T1, T2> FNJGMJGALLH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x4CAAA60", Offset = "0x4CA9C60", VA = "0x184CAAA60", Slot = "0")]
	public override bool Equals(object FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x4CAB250", Offset = "0x4CAA450", VA = "0x184CAB250", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x4CAB930", Offset = "0x4CAAB30", VA = "0x184CAB930", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class JMKNJBFMIBB<T1, T2, T3> : IComparable<JMKNJBFMIBB<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly T1 FEJMGLABIPK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly T2 GJEEKACEFID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly T3 BIAMDHFPBJO;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x4F03DD0", Offset = "0x4F02FD0", VA = "0x184F03DD0")]
	public JMKNJBFMIBB(T1 FEAEDLBKGBE, T2 MADECNNMCPB, T3 NAHELCKONNA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x4F035C0", Offset = "0x4F027C0", VA = "0x184F035C0", Slot = "4")]
	public int CompareTo(JMKNJBFMIBB<T1, T2, T3> FNJGMJGALLH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x4F03710", Offset = "0x4F02910", VA = "0x184F03710", Slot = "0")]
	public override bool Equals(object FNJGMJGALLH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x4F03A70", Offset = "0x4F02C70", VA = "0x184F03A70", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4F03B10", Offset = "0x4F02D10", VA = "0x184F03B10", Slot = "3")]
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
	public AnimationCurve IABNCHCCHCE
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public T KOOLPCKKOMB
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x12A6210", Offset = "0x12A5410", VA = "0x1812A6210")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T EJCNGPHLMCF
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xC12DF0", Offset = "0xC11FF0", VA = "0x180C12DF0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T ABLHJAOAOGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2B94180", Offset = "0x2B93380", VA = "0x182B94180")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2B94250", Offset = "0x2B93450", VA = "0x182B94250")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float INDJCIBJDOK
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xC07D70", Offset = "0xC06F70", VA = "0x180C07D70")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x5B1BAF0", Offset = "0x5B1ACF0", VA = "0x185B1BAF0")]
	public T FBNOGMLAPAC(float PNIEJJKFCEK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x5B1C0B0", Offset = "0x5B1B2B0", VA = "0x185B1C0B0")]
	public T OCLNAIGBDLE(float PNIEJJKFCEK)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T KCFJDGDPIKM(T OGNDHFPFEOJ, T ABBPAGLDFGP, float PNIEJJKFCEK);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x7C5CDD0", Offset = "0x7C5BFD0", VA = "0x187C5CDD0", Slot = "4")]
	protected override float KCFJDGDPIKM(float OGNDHFPFEOJ, float ABBPAGLDFGP, float PNIEJJKFCEK)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x7C5CE10", Offset = "0x7C5C010", VA = "0x187C5CE10")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1732BC0", Offset = "0x1731DC0", VA = "0x181732BC0", Slot = "4")]
	protected override Vector3 KCFJDGDPIKM(Vector3 OGNDHFPFEOJ, Vector3 ABBPAGLDFGP, float PNIEJJKFCEK)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x7C61130", Offset = "0x7C60330", VA = "0x187C61130")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x7C5C780", Offset = "0x7C5B980", VA = "0x187C5C780", Slot = "4")]
	protected override Color KCFJDGDPIKM(Color OGNDHFPFEOJ, Color ABBPAGLDFGP, float PNIEJJKFCEK)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x7C5C840", Offset = "0x7C5BA40", VA = "0x187C5C840")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class ANKBPLPGOPJ : AEMJFKONPIM<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x7C5C2B0", Offset = "0x7C5B4B0", VA = "0x187C5C2B0")]
	public ANKBPLPGOPJ(int PIBKMAHMMLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x7C5C240", Offset = "0x7C5B440", VA = "0x187C5C240", Slot = "6")]
	protected override uint OJONCDOEGCA(uint BDJMEJKDJOJ, string MLCDCHNOCFI)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class NKLLNMONGHM : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly IDisposable NDDGJHHDBNJ;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	public NKLLNMONGHM()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct GMGEOBMEODM<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> MMENCKLFJKK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int ANCIJMHBOPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private int CGFMHAHAABJ;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x4A77BA0", Offset = "0x4A76DA0", VA = "0x184A77BA0")]
	private GMGEOBMEODM(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> IBHEBBIOOBI, int DJOELJAEPEE, int ECNLOCBECHF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x4A77AA0", Offset = "0x4A76CA0", VA = "0x184A77AA0")]
	public static GMGEOBMEODM<T> OIKMHICCLEP()
	{
		return default(GMGEOBMEODM<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x4A76540", Offset = "0x4A75740", VA = "0x184A76540")]
	public (int, int, Task<T>) IPPOAIABDIA(int NAJOEFDLOFP, [Optional] CancellationToken HCELDNOKOAM, double ODIBCCLKMAC = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x4A75C10", Offset = "0x4A74E10", VA = "0x184A75C10")]
	public void FBPKEFJEELJ(int NAJOEFDLOFP, int ECNLOCBECHF, [In] T IGGKBIDIAJL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class BMPIPMCMGKA
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x7C5C3F0", Offset = "0x7C5B5F0", VA = "0x187C5C3F0")]
	public static GMGEOBMEODM<GKPOGNMPJHG> OIKMHICCLEP()
	{
		return default(GMGEOBMEODM<GKPOGNMPJHG>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x7C5C370", Offset = "0x7C5B570", VA = "0x187C5C370")]
	public static void FBPKEFJEELJ([In] this GMGEOBMEODM<GKPOGNMPJHG> CEENCLMGJAM, int NAJOEFDLOFP, int ECNLOCBECHF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[DefaultMember("Item")]
public class LCPDAGGPADI<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly Dictionary<TKey, TVal> JKPMGIDJADL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly Dictionary<TVal, TKey> KKBPBMLGALP;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int FAGABNHAKHN
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x40DBD40", Offset = "0x40DAF40", VA = "0x1840DBD40", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool FDKDJBEEIID
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TKey> NDCACBKNNLM
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x4C922E0", Offset = "0x4C914E0", VA = "0x184C922E0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ICollection<TVal> KIMMFFMKHPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x4B77F90", Offset = "0x4B77190", VA = "0x184B77F90", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TVal JCGKBEGFBHD
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x50BF1F0", Offset = "0x50BE3F0", VA = "0x1850BF1F0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x50BF290", Offset = "0x50BE490", VA = "0x1850BF290", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public TKey JCGKBEGFBHD
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x50BE6B0", Offset = "0x50BD8B0", VA = "0x1850BE6B0")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x50BE770", Offset = "0x50BD970", VA = "0x1850BE770", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x50BEF70", Offset = "0x50BE170", VA = "0x1850BEF70", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x50BE660", Offset = "0x50BD860", VA = "0x1850BE660", Slot = "9")]
	public void Add(TKey AGBHGDFILGO, TVal MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x50BE610", Offset = "0x50BD810", VA = "0x1850BE610", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> CKEIAGIGCJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x50BE810", Offset = "0x50BDA10", VA = "0x1850BE810", Slot = "8")]
	public bool ContainsKey(TKey AGBHGDFILGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x50BE8A0", Offset = "0x50BDAA0", VA = "0x1850BE8A0", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> CKEIAGIGCJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x50BEEF0", Offset = "0x50BE0F0", VA = "0x1850BEEF0", Slot = "10")]
	public bool Remove(TKey AGBHGDFILGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x50BEEB0", Offset = "0x50BE0B0", VA = "0x1850BEEB0", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> CKEIAGIGCJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x50BF010", Offset = "0x50BE210", VA = "0x1850BF010", Slot = "11")]
	public bool TryGetValue(TKey AGBHGDFILGO, [Out] TVal MLCDCHNOCFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x50BEBE0", Offset = "0x50BDDE0", VA = "0x1850BEBE0", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x50BE8E0", Offset = "0x50BDAE0", VA = "0x1850BE8E0", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] CABEAFGDMFF, int KLEAEAJOBHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x50BEB20", Offset = "0x50BDD20", VA = "0x1850BEB20")]
	public bool FLFGMEICIOC(TVal AGBHGDFILGO, [Out] TKey MLCDCHNOCFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x50BEA30", Offset = "0x50BDC30", VA = "0x1850BEA30")]
	private void FGDFPGGGCNB(TKey AGBHGDFILGO, TVal KFEGNKODPFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x50BE490", Offset = "0x50BD690", VA = "0x1850BE490")]
	private void ACMIDABLFCJ(TKey AGBHGDFILGO, TVal KFEGNKODPFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x50BED90", Offset = "0x50BDF90", VA = "0x1850BED90")]
	private bool HIIFFDCKMGN(TKey AGBHGDFILGO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x50BF070", Offset = "0x50BE270", VA = "0x1850BF070")]
	public LCPDAGGPADI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[DefaultMember("Item")]
public class BNINIHNAIGA<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private BNINIHNAIGA<T> buffer;

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
			[Cpp2IlInjected.Address(RVA = "0x1276860", Offset = "0x1275A60", VA = "0x181276860", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A5")]
			[Cpp2IlInjected.Address(RVA = "0x45B5B40", Offset = "0x45B4D40", VA = "0x1845B5B40", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A2")]
		[Cpp2IlInjected.Address(RVA = "0x45B6830", Offset = "0x45B5A30", VA = "0x1845B6830")]
		public Enumerator(BNINIHNAIGA<T> KKCFCHBPMCG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0x45B4350", Offset = "0x45B3550", VA = "0x1845B4350", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A6")]
		[Cpp2IlInjected.Address(RVA = "0x45B5080", Offset = "0x45B4280", VA = "0x1845B5080", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x45B3D10", Offset = "0x45B2F10", VA = "0x1845B3D10")]
		private void DPBKGACMMEH()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private T[] PHDEJHGJNAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private int AIGLIPKHKOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private int KNOIOHINDHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int COBPGHDNJHM;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int FAGABNHAKHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6079930", Offset = "0x6078B30", VA = "0x186079930")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public T JCGKBEGFBHD
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x6078840", Offset = "0x6077A40", VA = "0x186078840")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6078E40", Offset = "0x6078040", VA = "0x186078E40")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x607A240", Offset = "0x6079440", VA = "0x18607A240")]
	public BNINIHNAIGA(int PIBKMAHMMLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6079970", Offset = "0x6078B70", VA = "0x186079970")]
	public void OOLDDNFEGEK(T PNIEJJKFCEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6078BE0", Offset = "0x6077DE0", VA = "0x186078BE0")]
	public void FKFEALEGJFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x6078B10", Offset = "0x6077D10", VA = "0x186078B10")]
	public void FIMDNNDIHKM(int KIFHGDECLNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x60793D0", Offset = "0x60785D0", VA = "0x1860793D0")]
	public void LHEIMFHDGOA(T[] CABEAFGDMFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6079820", Offset = "0x6078A20", VA = "0x186079820")]
	public Enumerator MAJHBAEJHEK()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6079FE0", Offset = "0x60791E0", VA = "0x186079FE0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6079FE0", Offset = "0x60791E0", VA = "0x186079FE0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6078310", Offset = "0x6077510", VA = "0x186078310")]
	private int CGBGMKKGCFO(int NIBICIJAIGM)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6078AE0", Offset = "0x6077CE0", VA = "0x186078AE0")]
	private int CPLKGCAGPHO(int NIBICIJAIGM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class DHDBJOBDFMD<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public delegate Task<TResult> EGPIBDPOHHH(TRequest MGALKMHOLCM, CancellationToken HCELDNOKOAM);

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public enum NAOKJFFJMML
	{
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class EOLEMPMNNFC
	{
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private const float CDKOAIHPNOP = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TimeSpan LHGKJCNHLCK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int GCOKJMGGNKP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public NAOKJFFJMML LHEECDHICFG;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public static readonly EOLEMPMNNFC EMOEMPAFHHF;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public float MKJFMACAKKJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000B2")]
			[Cpp2IlInjected.Address(RVA = "0x4548430", Offset = "0x4547630", VA = "0x184548430")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public TimeSpan HBDDGPNEFJF
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B4")]
		[Cpp2IlInjected.Address(RVA = "0x4548660", Offset = "0x4547860", VA = "0x184548660")]
		public EOLEMPMNNFC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private readonly struct KAMGBGMPOLB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public readonly TRequest MGALKMHOLCM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public readonly CancellationToken HCELDNOKOAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public readonly TaskCompletionSource<TResult> LFLCFNCNIIA;

		[Cpp2IlInjected.Token(Token = "0x60000B6")]
		[Cpp2IlInjected.Address(RVA = "0x4FD1A50", Offset = "0x4FD0C50", VA = "0x184FD1A50")]
		public KAMGBGMPOLB(TRequest MGALKMHOLCM, TaskCompletionSource<TResult> LFLCFNCNIIA, CancellationToken HCELDNOKOAM)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private struct GGMNBCFGBNN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public DHDBJOBDFMD<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x4A66920", Offset = "0x4A65B20", VA = "0x184A66920", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x4A67180", Offset = "0x4A66380", VA = "0x184A67180", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct HIJJMACLHFH : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public DHDBJOBDFMD<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private KAMGBGMPOLB <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x4B89A90", Offset = "0x4B88C90", VA = "0x184B89A90", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x4B8A6C0", Offset = "0x4B898C0", VA = "0x184B8A6C0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly CancellationTokenSource DEBBNADMEIH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly List<KAMGBGMPOLB> KGFCLIGAOOI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly EOLEMPMNNFC HNFHAPDDOCF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly EGPIBDPOHHH EJMEMECIGPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private Task MOPJGPFDPDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int IDGGJMPBPCN;

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x6A232E0", Offset = "0x6A224E0", VA = "0x186A232E0")]
	public DHDBJOBDFMD(EGPIBDPOHHH EJMEMECIGPJ, [Optional] EOLEMPMNNFC HNFHAPDDOCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x6A21D50", Offset = "0x6A20F50", VA = "0x186A21D50")]
	public Task<TResult> HOBIIGCCDCN(TRequest MGALKMHOLCM, CancellationToken HCELDNOKOAM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x6A22120", Offset = "0x6A21320", VA = "0x186A22120")]
	private void JEKGPONHNJC(KAMGBGMPOLB LHIDLGEKJHA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x6A23140", Offset = "0x6A22340", VA = "0x186A23140")]
	[AsyncStateMachine(typeof(DHDBJOBDFMD<, >.GGMNBCFGBNN))]
	private Task POLCEOKMGKD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x6A224F0", Offset = "0x6A216F0", VA = "0x186A224F0")]
	private KAMGBGMPOLB JNDBFEDIOMB()
	{
		return default(KAMGBGMPOLB);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x6A22E90", Offset = "0x6A22090", VA = "0x186A22E90")]
	[AsyncStateMachine(typeof(DHDBJOBDFMD<, >.HIJJMACLHFH))]
	private Task MGIMLFMMGAK()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x6A223F0", Offset = "0x6A215F0", VA = "0x186A223F0")]
	private void JILNCAGMAGP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x6A21860", Offset = "0x6A20A60", VA = "0x186A21860", Slot = "4")]
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
public class IAKDONMGAOD<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly List<T> MEHAOGGFJIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private HashSet<T> IKLFKANEBAM;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int FAGABNHAKHN
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x40DBD40", Offset = "0x40DAF40", VA = "0x1840DBD40", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool FDKDJBEEIID
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0xA3B3E0", Offset = "0xA3A5E0", VA = "0x180A3B3E0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public T JCGKBEGFBHD
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x39A9030", Offset = "0x39A8230", VA = "0x1839A9030", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x4C6B930", Offset = "0x4C6AB30", VA = "0x184C6B930", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C0")]
	[Cpp2IlInjected.Address(RVA = "0x49CC6A0", Offset = "0x49CB8A0", VA = "0x1849CC6A0", Slot = "11")]
	public void Add(T CKEIAGIGCJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x4C6AEC0", Offset = "0x4C6A0C0", VA = "0x184C6AEC0")]
	public bool IEDEMMHGMJO(T CKEIAGIGCJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x4C6B610", Offset = "0x4C6A810", VA = "0x184C6B610", Slot = "15")]
	public bool Remove(T CKEIAGIGCJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x4C6AD30", Offset = "0x4C69F30", VA = "0x184C6AD30", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x49FEC70", Offset = "0x49FDE70", VA = "0x1849FEC70", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x4C6ABE0", Offset = "0x4C69DE0", VA = "0x184C6ABE0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x4C6AC80", Offset = "0x4C69E80", VA = "0x184C6AC80", Slot = "13")]
	public bool Contains(T CKEIAGIGCJK)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x4C6ACD0", Offset = "0x4C69ED0", VA = "0x184C6ACD0", Slot = "14")]
	public void CopyTo(T[] CABEAFGDMFF, int KLEAEAJOBHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4C6AFC0", Offset = "0x4C6A1C0", VA = "0x184C6AFC0", Slot = "6")]
	public int IndexOf(T CKEIAGIGCJK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4C6B020", Offset = "0x4C6A220", VA = "0x184C6B020", Slot = "7")]
	public void Insert(int NIBICIJAIGM, T CKEIAGIGCJK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4C6B2B0", Offset = "0x4C6A4B0", VA = "0x184C6B2B0", Slot = "8")]
	public void RemoveAt(int NIBICIJAIGM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x4C6B6D0", Offset = "0x4C6A8D0", VA = "0x184C6B6D0")]
	public IAKDONMGAOD()
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
			[Cpp2IlInjected.Address(RVA = "0x29FE530", Offset = "0x29FD730", VA = "0x1829FE530")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CD")]
		[Cpp2IlInjected.Address(RVA = "0x24F5BC0", Offset = "0x24F4DC0", VA = "0x1824F5BC0")]
		public SerializedGuid([In] Guid DIHOLCNHIND)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x7C605D0", Offset = "0x7C5F7D0", VA = "0x187C605D0")]
		public static SerializedGuid LMADPBJDKDD()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x7C60550", Offset = "0x7C5F750", VA = "0x187C60550")]
		public static SerializedGuid GHNAIECCDOP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x7C603F0", Offset = "0x7C5F5F0", VA = "0x187C603F0")]
		public bool BFALGEPOBJF()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x7C606D0", Offset = "0x7C5F8D0", VA = "0x187C606D0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x7C60650", Offset = "0x7C5F850", VA = "0x187C60650", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x7C60480", Offset = "0x7C5F680", VA = "0x187C60480", Slot = "7")]
		public bool Equals(SerializedGuid FNJGMJGALLH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x7C604C0", Offset = "0x7C5F6C0", VA = "0x187C604C0", Slot = "0")]
		public override bool Equals(object DBCLNEGBNLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x7C605C0", Offset = "0x7C5F7C0", VA = "0x187C605C0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x7C60450", Offset = "0x7C5F650", VA = "0x187C60450", Slot = "6")]
		public int CompareTo(SerializedGuid FNJGMJGALLH)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class BFLMLDEFDMF : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly Type LPNDNJLEFCK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly string NPOOINCCPIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly bool OLNHELCEJJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly bool JKBHJDNPGOK;

	[Cpp2IlInjected.Token(Token = "0x60000D7")]
	[Cpp2IlInjected.Address(RVA = "0x7C5C300", Offset = "0x7C5B500", VA = "0x187C5C300")]
	public BFLMLDEFDMF(Type GFENNJHGHHH, string BKEBNIJBFOJ, bool NODMDGLFBEI = false, bool JACMJMGIIDN = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface EMOKKCAIFDG<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	int DIPLICPDCFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000D9")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<T> CLOPGNPMAPL(float ALBGFINLCPH, [Optional] float? PCAPMJCNFBA);

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool BKMPINFMILJ(float ALBGFINLCPH, T MLCDCHNOCFI);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void FKFEALEGJFP();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
[Obsolete("Use ITimeSeriesRollingWindow<T> instead")]
public class FNOECKFKAIK<T> : EMOKKCAIFDG<T>
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private class OIGAFOABCLA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005C")]
		public float CFGOBPOFFPJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005D")]
		public T ABLHJAOAOGP;

		[Cpp2IlInjected.Token(Token = "0x60000E2")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public OIGAFOABCLA()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class ILGONFKANLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x60000E3")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public ILGONFKANLP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E4")]
		[Cpp2IlInjected.Address(RVA = "0x4CA1BE0", Offset = "0x4CA0DE0", VA = "0x184CA1BE0")]
		internal bool DGJPFIEHDPF(OIGAFOABCLA sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	public readonly float KHPILKKCHEN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	public readonly float JFDFFKBFMAO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private List<OIGAFOABCLA> FFGIEFCAONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private CKCBDAAIPAI<OIGAFOABCLA> KGMLBNJMNMN;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int DIPLICPDCFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x49B1A40", Offset = "0x49B0C40", VA = "0x1849B1A40", Slot = "4")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DD")]
	[Cpp2IlInjected.Address(RVA = "0x49B1D10", Offset = "0x49B0F10", VA = "0x1849B1D10")]
	public FNOECKFKAIK(float PKPBPAELJPF, float AHADOPFPFGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x49B0F60", Offset = "0x49B0160", VA = "0x1849B0F60", Slot = "6")]
	public bool BKMPINFMILJ(float ALBGFINLCPH, T MLCDCHNOCFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x49B1660", Offset = "0x49B0860", VA = "0x1849B1660", Slot = "5")]
	public IEnumerable<T> CLOPGNPMAPL(float ALBGFINLCPH, float? PCAPMJCNFBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x49B1AB0", Offset = "0x49B0CB0", VA = "0x1849B1AB0", Slot = "7")]
	public void FKFEALEGJFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x49B1B60", Offset = "0x49B0D60", VA = "0x1849B1B60")]
	private void KIJBDFJIKOE(float ALBGFINLCPH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000031")]
public class BLIOFCIBLOM<T> : EMOKKCAIFDG<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000032")]
	private readonly struct HDNPGKJMNMC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public readonly T ABLHJAOAOGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public readonly float CFGOBPOFFPJ;

		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x4B13490", Offset = "0x4B12690", VA = "0x184B13490")]
		public HDNPGKJMNMC(T MLCDCHNOCFI, float ALBGFINLCPH)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000033")]
	[CompilerGenerated]
	private sealed class GBBAEJHJDAE : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
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
		public BLIOFCIBLOM<T> <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0xE9E930", Offset = "0xE9DB30", VA = "0x180E9E930")]
		[DebuggerHidden]
		public GBBAEJHJDAE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x4A4FB90", Offset = "0x4A4ED90", VA = "0x184A4FB90", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F5")]
		[Cpp2IlInjected.Address(RVA = "0x4A4FF20", Offset = "0x4A4F120", VA = "0x184A4FF20", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x4A4FD60", Offset = "0x4A4EF60", VA = "0x184A4FD60", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x4A38C00", Offset = "0x4A37E00", VA = "0x184A38C00", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly float PKPBPAELJPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly float AHADOPFPFGP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private readonly List<HDNPGKJMNMC> FFGIEFCAONJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int AIGLIPKHKOK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private int CCFAAAOLCMD;

	[Cpp2IlInjected.Token(Token = "0x1700002F")]
	public int DIPLICPDCFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x9FB3A0", Offset = "0x9FA5A0", VA = "0x1809FB3A0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E9")]
	[Cpp2IlInjected.Address(RVA = "0x5F731A0", Offset = "0x5F723A0", VA = "0x185F731A0")]
	public BLIOFCIBLOM(float PKPBPAELJPF, float AHADOPFPFGP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EA")]
	[Cpp2IlInjected.Address(RVA = "0x5F72690", Offset = "0x5F71890", VA = "0x185F72690", Slot = "6")]
	public bool BKMPINFMILJ(float ALBGFINLCPH, T MLCDCHNOCFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EB")]
	[Cpp2IlInjected.Address(RVA = "0x5F73150", Offset = "0x5F72350", VA = "0x185F73150", Slot = "8")]
	public int NBFANKODBGP(float ALBGFINLCPH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000EC")]
	[Cpp2IlInjected.Address(RVA = "0x5F72CC0", Offset = "0x5F71EC0", VA = "0x185F72CC0", Slot = "5")]
	[IteratorStateMachine(typeof(BLIOFCIBLOM<>.GBBAEJHJDAE))]
	public IEnumerable<T> CLOPGNPMAPL(float ALBGFINLCPH, float? PCAPMJCNFBA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000ED")]
	[Cpp2IlInjected.Address(RVA = "0x5F72F60", Offset = "0x5F72160", VA = "0x185F72F60", Slot = "7")]
	public void FKFEALEGJFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EE")]
	[Cpp2IlInjected.Address(RVA = "0x5F72E70", Offset = "0x5F72070", VA = "0x185F72E70")]
	private void DGEOPOOKIJH(float ALBGFINLCPH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000EF")]
	[Cpp2IlInjected.Address(RVA = "0x5F73080", Offset = "0x5F72280", VA = "0x185F73080")]
	private HDNPGKJMNMC IGKLDMFHKNJ()
	{
		return default(HDNPGKJMNMC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000034")]
public class EAIPOBMEIGP<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000035")]
	public readonly struct JFIPIMKMCNF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public readonly long BCMAMMHFDOK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		public readonly long HIEADBGMKNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		public readonly int NGINKIEKOMB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		public readonly int MLFFEJONGBH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000081")]
		public readonly bool HJHJDPKDLOJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000082")]
		private readonly string CEBBMIDMMEM;

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x4EB8570", Offset = "0x4EB7770", VA = "0x184EB8570")]
		public JFIPIMKMCNF(long BCMAMMHFDOK, int NGINKIEKOMB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x4EB8540", Offset = "0x4EB7740", VA = "0x184EB8540")]
		public JFIPIMKMCNF(long BCMAMMHFDOK, long HIEADBGMKNO, int NGINKIEKOMB, int MLFFEJONGBH, bool HJHJDPKDLOJ, string CEBBMIDMMEM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x4EB84F0", Offset = "0x4EB76F0", VA = "0x184EB84F0")]
		public int HCGDNFKJNGE()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x4EB83D0", Offset = "0x4EB75D0", VA = "0x184EB83D0")]
		public int BAOJGPNHBKK(int MOOKJOACAEC)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x6000105")]
		[Cpp2IlInjected.Address(RVA = "0x4EB83F0", Offset = "0x4EB75F0", VA = "0x184EB83F0")]
		public double BHNKONICPHK()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x4EB8450", Offset = "0x4EB7650", VA = "0x184EB8450")]
		public JFIPIMKMCNF FGBBBIIJDCD(long HIEADBGMKNO, int MLFFEJONGBH)
		{
			return default(JFIPIMKMCNF);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public class MNKIBAEKPMC : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000037")]
		[CompilerGenerated]
		private struct BGKNAKNAOHH<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000088")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000089")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008A")]
			public MNKIBAEKPMC <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008B")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008C")]
			public Func<MNKIBAEKPMC, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008D")]
			private MNKIBAEKPMC <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400008E")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600010F")]
			[Cpp2IlInjected.Address(RVA = "0x5E8B720", Offset = "0x5E8A920", VA = "0x185E8B720", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000110")]
			[Cpp2IlInjected.Address(RVA = "0x562F210", Offset = "0x562E410", VA = "0x18562F210", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000083")]
		public readonly TKey AFPMCDIFDOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000084")]
		private readonly EAIPOBMEIGP<TKey> AGHDGMNHDIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public readonly FODGIOKBGBI FHEIHFBIKLF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private List<MNKIBAEKPMC> MODLLNLACKH;

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public string CMMAIIINJJJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x53280D0", Offset = "0x53272D0", VA = "0x1853280D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public IEnumerable<MNKIBAEKPMC> MKHNEOCCLNE
		{
			[Cpp2IlInjected.Token(Token = "0x6000108")]
			[Cpp2IlInjected.Address(RVA = "0x5328090", Offset = "0x5327290", VA = "0x185328090")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		public JFIPIMKMCNF ACHJMAFFHAO
		{
			[Cpp2IlInjected.Token(Token = "0x6000109")]
			[Cpp2IlInjected.Address(RVA = "0x5328370", Offset = "0x5327570", VA = "0x185328370")]
			[CompilerGenerated]
			get
			{
				return default(JFIPIMKMCNF);
			}
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x5328540", Offset = "0x5327740", VA = "0x185328540")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x5328570", Offset = "0x5327770", VA = "0x185328570")]
		internal MNKIBAEKPMC(EAIPOBMEIGP<TKey> AGHDGMNHDIP, TKey AGBHGDFILGO, FODGIOKBGBI FHEIHFBIKLF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010C")]
		[Cpp2IlInjected.Address(RVA = "0x5328390", Offset = "0x5327590", VA = "0x185328390")]
		public MNKIBAEKPMC LHPKNFOBGFN(TKey AGBHGDFILGO, [Optional] FODGIOKBGBI? GJKLMGMHEBH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x3F7BBE0", Offset = "0x3F7ADE0", VA = "0x183F7BBE0")]
		[AsyncStateMachine(typeof(BGKNAKNAOHH<>))]
		public Task<T> PFGDDPOBAGI<T>(TKey AGBHGDFILGO, Func<MNKIBAEKPMC, Task<T>> OOKJGLKPPPN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x5328120", Offset = "0x5327320", VA = "0x185328120", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private sealed class EGCLEEKBCCN : IEnumerable<(TKey, List<TKey>, JFIPIMKMCNF)>, IEnumerable, IEnumerator<(TKey, List<TKey>, JFIPIMKMCNF)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private (TKey key, List<TKey> path, JFIPIMKMCNF timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public EAIPOBMEIGP<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private IEnumerator<(TKey key, List<TKey> path, JFIPIMKMCNF timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		private (TKey, List<TKey>, JFIPIMKMCNF) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000115")]
			[Cpp2IlInjected.Address(RVA = "0x29E7170", Offset = "0x29E6370", VA = "0x1829E7170", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, JFIPIMKMCNF));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000117")]
			[Cpp2IlInjected.Address(RVA = "0x4534320", Offset = "0x4533520", VA = "0x184534320", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x29E7260", Offset = "0x29E6460", VA = "0x1829E7260")]
		[DebuggerHidden]
		public EGCLEEKBCCN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x4534380", Offset = "0x4533580", VA = "0x184534380", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x4533E20", Offset = "0x4533020", VA = "0x184533E20", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000114")]
		[Cpp2IlInjected.Address(RVA = "0x4533DD0", Offset = "0x4532FD0", VA = "0x184533DD0")]
		private void CKKMGPGLJAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000116")]
		[Cpp2IlInjected.Address(RVA = "0x45342D0", Offset = "0x45334D0", VA = "0x1845342D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x45341C0", Offset = "0x45333C0", VA = "0x1845341C0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, JFIPIMKMCNF)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000119")]
		[Cpp2IlInjected.Address(RVA = "0x4534290", Offset = "0x4533490", VA = "0x184534290", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000039")]
	[CompilerGenerated]
	private sealed class LICGEADMABF : IEnumerable<(TKey, List<TKey>, JFIPIMKMCNF)>, IEnumerable, IEnumerator<(TKey, List<TKey>, JFIPIMKMCNF)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000095")]
		private (TKey key, List<TKey> path, JFIPIMKMCNF timerEntry) <>2__current;

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
		private MNKIBAEKPMC timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009A")]
		public MNKIBAEKPMC <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009B")]
		public EAIPOBMEIGP<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		private IEnumerator<MNKIBAEKPMC> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private IEnumerator<(TKey key, List<TKey> path, JFIPIMKMCNF timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		private (TKey, List<TKey>, JFIPIMKMCNF) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600011F")]
			[Cpp2IlInjected.Address(RVA = "0x29E7170", Offset = "0x29E6370", VA = "0x1829E7170", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, JFIPIMKMCNF));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000121")]
			[Cpp2IlInjected.Address(RVA = "0x50D11A0", Offset = "0x50D03A0", VA = "0x1850D11A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600011A")]
		[Cpp2IlInjected.Address(RVA = "0x29E7260", Offset = "0x29E6460", VA = "0x1829E7260")]
		[DebuggerHidden]
		public LICGEADMABF(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011B")]
		[Cpp2IlInjected.Address(RVA = "0x50D1200", Offset = "0x50D0400", VA = "0x1850D1200", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011C")]
		[Cpp2IlInjected.Address(RVA = "0x50D0850", Offset = "0x50CFA50", VA = "0x1850D0850", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600011D")]
		[Cpp2IlInjected.Address(RVA = "0x50D0790", Offset = "0x50CF990", VA = "0x1850D0790")]
		private void CKKMGPGLJAA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600011E")]
		[Cpp2IlInjected.Address(RVA = "0x50D07F0", Offset = "0x50CF9F0", VA = "0x1850D07F0")]
		private void GCCIFBPGOJD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000120")]
		[Cpp2IlInjected.Address(RVA = "0x50D1150", Offset = "0x50D0350", VA = "0x1850D1150", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x50D1010", Offset = "0x50D0210", VA = "0x1850D1010", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, JFIPIMKMCNF)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x50D1110", Offset = "0x50D0310", VA = "0x1850D1110", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private readonly Action<TKey, JFIPIMKMCNF, FODGIOKBGBI> LHJKIEPKMDH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000074")]
	private readonly Action<TKey, JFIPIMKMCNF, FODGIOKBGBI> AAHOKOICLIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000075")]
	private readonly Action<EAIPOBMEIGP<TKey>, FODGIOKBGBI> MFHDNKFOIEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000076")]
	private readonly FODGIOKBGBI FHEIHFBIKLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000077")]
	private readonly MNKIBAEKPMC BMBOLLFFKEE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000078")]
	private bool DJOMNIEOFJP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000079")]
	private int LNDACEMECJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007A")]
	private readonly Stopwatch EGIPOFENIHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007B")]
	public readonly int LBNKJCAIOFC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400007C")]
	private string PHPNHFLGFPM;

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public MNKIBAEKPMC MCDIEAAHBLF
	{
		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x9F2480", Offset = "0x9F1680", VA = "0x1809F2480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000033")]
	[NotNull]
	public string CMMAIIINJJJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x9F3290", Offset = "0x9F2490", VA = "0x1809F3290")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x451FE80", Offset = "0x451F080", VA = "0x18451FE80")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000FC")]
	[Cpp2IlInjected.Address(RVA = "0x4520030", Offset = "0x451F230", VA = "0x184520030")]
	public EAIPOBMEIGP(TKey CCOMOEOMIEI, FODGIOKBGBI FHEIHFBIKLF, [Optional] int? NGINKIEKOMB, [Optional][CanBeNull] Stopwatch EGIPOFENIHD, [Optional] Action<TKey, JFIPIMKMCNF, FODGIOKBGBI> LHJKIEPKMDH, [Optional] Action<TKey, JFIPIMKMCNF, FODGIOKBGBI> AAHOKOICLIL, [Optional] Action<EAIPOBMEIGP<TKey>, FODGIOKBGBI> MFHDNKFOIEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FD")]
	[Cpp2IlInjected.Address(RVA = "0x451FEE0", Offset = "0x451F0E0", VA = "0x18451FEE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000FE")]
	[Cpp2IlInjected.Address(RVA = "0x451FDE0", Offset = "0x451EFE0", VA = "0x18451FDE0")]
	[IteratorStateMachine(typeof(EAIPOBMEIGP<>.EGCLEEKBCCN))]
	public IEnumerable<(TKey, List<TKey>, JFIPIMKMCNF)> AEODADPGJAJ()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000FF")]
	[Cpp2IlInjected.Address(RVA = "0x451FD00", Offset = "0x451EF00", VA = "0x18451FD00")]
	[IteratorStateMachine(typeof(EAIPOBMEIGP<>.LICGEADMABF))]
	private IEnumerable<(TKey, List<TKey>, JFIPIMKMCNF)> AEODADPGJAJ(List<TKey> PJPBBAPADDN, MNKIBAEKPMC PNMFADJPMPF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000100")]
	[Cpp2IlInjected.Address(RVA = "0x451FFB0", Offset = "0x451F1B0", VA = "0x18451FFB0")]
	private (long, int) JKJHDJNJBEN()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x200003A")]
public abstract class LIAINIODEKO<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut JDIEHLHHFIC(EAIPOBMEIGP<TKey> AGHDGMNHDIP);

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	protected LIAINIODEKO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public abstract class AHABDIMHFOL<TKey> : LIAINIODEKO<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	public delegate string JJEDAPOGMED(TKey AGBHGDFILGO);

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x4A89FA0", Offset = "0x4A891A0", VA = "0x184A89FA0")]
	private static string JNHPAFBODAK(TKey AGBHGDFILGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x4A89EC0", Offset = "0x4A890C0", VA = "0x184A89EC0", Slot = "4")]
	public override string JDIEHLHHFIC(EAIPOBMEIGP<TKey> AGHDGMNHDIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x4A89D70", Offset = "0x4A88F70", VA = "0x184A89D70")]
	public string JDIEHLHHFIC(EAIPOBMEIGP<TKey> AGHDGMNHDIP, [NotNull] JJEDAPOGMED NDIAEEGJAOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000129")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string IDHJIFHADLC(EAIPOBMEIGP<TKey> AGHDGMNHDIP, [NotNull] JJEDAPOGMED NDIAEEGJAOH);

	[Cpp2IlInjected.Token(Token = "0x600012A")]
	[Cpp2IlInjected.Address(RVA = "0x499BBD0", Offset = "0x499ADD0", VA = "0x18499BBD0")]
	protected AHABDIMHFOL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public class BNGFOPGDKCF<TKey> : LIAINIODEKO<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	public delegate string GAMDLCCHGGK(TKey AGBHGDFILGO);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private readonly string MOJGIAMBOHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009F")]
	private readonly double EDHLGKNONBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A0")]
	private readonly bool AGFJINDDCBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A1")]
	private readonly int GPCKAEKBMFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A2")]
	private readonly ISet<string> FONFCHJDFOO;

	[Cpp2IlInjected.Token(Token = "0x600012D")]
	[Cpp2IlInjected.Address(RVA = "0x6060280", Offset = "0x605F480", VA = "0x186060280")]
	private static string JNHPAFBODAK(TKey AGBHGDFILGO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x60602C0", Offset = "0x605F4C0", VA = "0x1860602C0")]
	public BNGFOPGDKCF(string MOJGIAMBOHJ = "F2", double EDHLGKNONBB = double.MaxValue, bool AGFJINDDCBM = false, int GPCKAEKBMFK = int.MaxValue, [Optional] ISet<string> FONFCHJDFOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x60601A0", Offset = "0x605F3A0", VA = "0x1860601A0", Slot = "4")]
	public override Dictionary<string, string> JDIEHLHHFIC(EAIPOBMEIGP<TKey> AGHDGMNHDIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x605FA80", Offset = "0x605EC80", VA = "0x18605FA80")]
	private bool IJKGNFDNAFO(string KDALBLHEOPF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x605FB60", Offset = "0x605ED60", VA = "0x18605FB60")]
	public Dictionary<string, string> JDIEHLHHFIC(EAIPOBMEIGP<TKey> AGHDGMNHDIP, GAMDLCCHGGK NDIAEEGJAOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x605F810", Offset = "0x605EA10", VA = "0x18605F810")]
	private string DEALHKBLLOG(StringBuilder PCOAHLAJBAA, List<TKey> KNIDJDLMPIJ, GAMDLCCHGGK NDIAEEGJAOH, bool CGAADIGBDPI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x605F6B0", Offset = "0x605E8B0", VA = "0x18605F6B0")]
	private static void BJOGCIOLMFB(StringBuilder LKEFDNOBOMH, string PKCMPLIBCCO, bool FNFFDAHLGGJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public class AINCJMMPNGN<TKey> : AHABDIMHFOL<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	[CompilerGenerated]
	private struct FBOBNDKIKHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A5")]
		public JJEDAPOGMED keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x40000A3")]
	public static AINCJMMPNGN<TKey> NDDGJHHDBNJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A4")]
	private readonly string[] ICJAIFCJMKL;

	[Cpp2IlInjected.Token(Token = "0x6000136")]
	[Cpp2IlInjected.Address(RVA = "0x4A97D30", Offset = "0x4A96F30", VA = "0x184A97D30")]
	private AINCJMMPNGN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000137")]
	[Cpp2IlInjected.Address(RVA = "0x4A96CD0", Offset = "0x4A95ED0", VA = "0x184A96CD0", Slot = "5")]
	protected override string IDHJIFHADLC(EAIPOBMEIGP<TKey> AGHDGMNHDIP, JJEDAPOGMED NDIAEEGJAOH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000139")]
	[Cpp2IlInjected.Address(RVA = "0x4A97AF0", Offset = "0x4A96CF0", VA = "0x184A97AF0")]
	[CompilerGenerated]
	internal static string KOKMCIPMBNB(string JKDKINEMEHD, TKey AGBHGDFILGO, FBOBNDKIKHA P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public sealed class DPLOPCPHIKI : EAIPOBMEIGP<string>
{
	[Cpp2IlInjected.Token(Token = "0x2000042")]
	[CompilerGenerated]
	private sealed class HBDJKJMMAIN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000A6")]
		public Action<DPLOPCPHIKI, FODGIOKBGBI> callback;

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public HBDJKJMMAIN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x7C5CE50", Offset = "0x7C5C050", VA = "0x187C5CE50")]
		internal void CKFAIOELOFH(EAIPOBMEIGP<string> timer, FODGIOKBGBI log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013A")]
	[Cpp2IlInjected.Address(RVA = "0x7C5CB80", Offset = "0x7C5BD80", VA = "0x187C5CB80")]
	public DPLOPCPHIKI(FODGIOKBGBI FHEIHFBIKLF, [Optional] string EMHIEHKFOKI, [Optional] int? NGINKIEKOMB, [Optional] Stopwatch EGIPOFENIHD, [Optional] Action<string, JFIPIMKMCNF, FODGIOKBGBI> LHJKIEPKMDH, [Optional] Action<string, JFIPIMKMCNF, FODGIOKBGBI> AAHOKOICLIL, [Optional] Action<DPLOPCPHIKI, FODGIOKBGBI> MFHDNKFOIEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600013B")]
	[Cpp2IlInjected.Address(RVA = "0x7C5CAC0", Offset = "0x7C5BCC0", VA = "0x187C5CAC0")]
	private static Action<EAIPOBMEIGP<string>, FODGIOKBGBI> AJOGCNPCDEM(Action<DPLOPCPHIKI, FODGIOKBGBI> LKEPFHDAAED)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public abstract class NJHMIMIKAGI
{
	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private class HMHCPCPECGF : NJHMIMIKAGI
	{
		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public static NJHMIMIKAGI NDDGJHHDBNJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x7C5CFD0", Offset = "0x7C5C1D0", VA = "0x187C5CFD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override float GFANFGKGFOI
		{
			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x11FBAF0", Offset = "0x11FACF0", VA = "0x1811FBAF0", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x7C5D0C0", Offset = "0x7C5C2C0", VA = "0x187C5D0C0")]
		public HMHCPCPECGF()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private static NJHMIMIKAGI DDPHMJOOKEB;

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public static NJHMIMIKAGI EMOEMPAFHHF
	{
		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x7C5E4C0", Offset = "0x7C5D6C0", VA = "0x187C5E4C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003C")]
	public abstract float GFANFGKGFOI
	{
		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	protected NJHMIMIKAGI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public interface NCBKHDICHNJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	bool GLGAHOJADMO
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public interface PAACHOBIIFN<T> : NCBKHDICHNJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000040")]
	[NotNull]
	Task<T> FMPPMCAKLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	[NotNull]
	CMEBMOPMCFP<T> PGNPLOLACCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000148")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000047")]
public static class OLMBPBGGGBD
{
	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(RVA = "0x39F7320", Offset = "0x39F6520", VA = "0x1839F7320")]
	public static PAACHOBIIFN<TResource> ABAAGLDGJLO<TResource, TId>(this KACGMINCHLD<TId, TResource> EBBLCJEIDAF, TId MKHHKDJKLDN, [Optional] Func<TId, CancellationToken, Task<TResource>>? FFFIDGNAACE) where TResource : notnull where TId : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000048")]
public static class ELCENEKPMMB
{
	[Cpp2IlInjected.Token(Token = "0x2000049")]
	private sealed class BPKGMLKINAB<T> : FBGDNDHDIBD<T?> where T : class
	{
		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override Task<T?> FMPPMCAKLGJ
		{
			[Cpp2IlInjected.Token(Token = "0x600014F")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override CMEBMOPMCFP<T?> PGNPLOLACCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x615F0B0", Offset = "0x615E2B0", VA = "0x18615F0B0")]
		public BPKGMLKINAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "10")]
		protected override void JHIKCOMNLGG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004A")]
	private sealed class NBDNCDEFNKL<T> : FBGDNDHDIBD<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		private readonly T DCPONLADMFF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AD")]
		private readonly Action<T>? PMGAJGOAJPD;

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override Task<T> FMPPMCAKLGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x9F2500", Offset = "0x9F1700", VA = "0x1809F2500", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override CMEBMOPMCFP<T> PGNPLOLACCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x9F6D90", Offset = "0x9F5F90", VA = "0x1809F6D90", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x5371570", Offset = "0x5370770", VA = "0x185371570")]
		public NBDNCDEFNKL(T ILLGDKFPAIL, Action<T>? NEBLENLODFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x53714C0", Offset = "0x53706C0", VA = "0x1853714C0", Slot = "10")]
		protected override void JHIKCOMNLGG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private sealed class MEHGANDPLEJ<T> : FBGDNDHDIBD<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override Task<T> FMPPMCAKLGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override CMEBMOPMCFP<T> PGNPLOLACCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x52D8E80", Offset = "0x52D8080", VA = "0x1852D8E80")]
		public MEHGANDPLEJ(Exception NHADLBPGDMN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "10")]
		protected override void JHIKCOMNLGG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004C")]
	private sealed class PMNAFGMBMEL<T> : FBGDNDHDIBD<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004D")]
		[CompilerGenerated]
		private struct EJIEBMOGMMJ : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B6")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B7")]
			public Task<PAACHOBIIFN<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			private TaskAwaiter<PAACHOBIIFN<T>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			private TaskAwaiter<T> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x4537230", Offset = "0x4536430", VA = "0x184537230", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x4537C10", Offset = "0x4536E10", VA = "0x184537C10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004E")]
		[CompilerGenerated]
		private struct MMMFIGENPEL : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public Task<PAACHOBIIFN<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private TaskAwaiter<PAACHOBIIFN<T>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000163")]
			[Cpp2IlInjected.Address(RVA = "0x5323E20", Offset = "0x5323020", VA = "0x185323E20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000164")]
			[Cpp2IlInjected.Address(RVA = "0x53242E0", Offset = "0x53234E0", VA = "0x1853242E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B2")]
		private readonly Task<PAACHOBIIFN<T>> HNOPLFFJAMM;

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override Task<T> FMPPMCAKLGJ
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override CMEBMOPMCFP<T> PGNPLOLACCK
		{
			[Cpp2IlInjected.Token(Token = "0x600015C")]
			[Cpp2IlInjected.Address(RVA = "0x9F2510", Offset = "0x9F1710", VA = "0x1809F2510", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x5638AA0", Offset = "0x5637CA0", VA = "0x185638AA0")]
		public PMNAFGMBMEL(Task<PAACHOBIIFN<T>> LDLKICLCOAG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x56387C0", Offset = "0x56379C0", VA = "0x1856387C0", Slot = "10")]
		protected override void JHIKCOMNLGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x5638650", Offset = "0x5637850", VA = "0x185638650")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(PMNAFGMBMEL<>.EJIEBMOGMMJ))]
		internal static Task<T> GDBIOJBKICJ(Task<PAACHOBIIFN<T>> LDLKICLCOAG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x56388E0", Offset = "0x5637AE0", VA = "0x1856388E0")]
		[AsyncStateMachine(typeof(PMNAFGMBMEL<>.MMMFIGENPEL))]
		[CompilerGenerated]
		internal static Task MOHLLKCKEAG(Task<PAACHOBIIFN<T>> LDLKICLCOAG)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004F")]
	private sealed class PJIDCKAFADK<TIn, TOut> : FBGDNDHDIBD<TOut> where TIn : notnull where TOut : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000050")]
		[CompilerGenerated]
		private struct MGFOJGOFOEP : IAsyncStateMachine
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
			[Cpp2IlInjected.Address(RVA = "0x52DD230", Offset = "0x52DC430", VA = "0x1852DD230", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600016B")]
			[Cpp2IlInjected.Address(RVA = "0x49AD3D0", Offset = "0x49AC5D0", VA = "0x1849AD3D0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		private readonly PAACHOBIIFN<TIn> OKAOIGGNJKH;

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public override Task<TOut> FMPPMCAKLGJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000165")]
			[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		public override CMEBMOPMCFP<TOut> PGNPLOLACCK
		{
			[Cpp2IlInjected.Token(Token = "0x6000166")]
			[Cpp2IlInjected.Address(RVA = "0x9F2510", Offset = "0x9F1710", VA = "0x1809F2510", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000167")]
		[Cpp2IlInjected.Address(RVA = "0x562F900", Offset = "0x562EB00", VA = "0x18562F900")]
		public PJIDCKAFADK(PAACHOBIIFN<TIn> MDONEFAMGGI, Func<TIn, TOut> NMHAFEDCMAA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0x562F860", Offset = "0x562EA60", VA = "0x18562F860", Slot = "10")]
		protected override void JHIKCOMNLGG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0x562F6E0", Offset = "0x562E8E0", VA = "0x18562F6E0")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(PJIDCKAFADK<, >.MGFOJGOFOEP))]
		internal static Task<TOut> EPKECNABILO(Task<TIn> IMEDKFLLIOK, Func<TIn, TOut> NMHAFEDCMAA)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014A")]
	[Cpp2IlInjected.Address(RVA = "0x36A0BB0", Offset = "0x369FDB0", VA = "0x1836A0BB0")]
	public static PAACHOBIIFN<T> MLINAHCDIHH<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014B")]
	[Cpp2IlInjected.Address(RVA = "0x36A0A60", Offset = "0x369FC60", VA = "0x1836A0A60")]
	public static PAACHOBIIFN<T> EMKCJPIKIPA<T>(T IGGKBIDIAJL, [Optional] Action<T>? NEBLENLODFH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014C")]
	[Cpp2IlInjected.Address(RVA = "0x3615CF0", Offset = "0x3614EF0", VA = "0x183615CF0")]
	public static PAACHOBIIFN<T> FDOGOHPNJFI<T>(Exception NHADLBPGDMN) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x3615CF0", Offset = "0x3614EF0", VA = "0x183615CF0")]
	public static PAACHOBIIFN<T> AGJJOBAMMDC<T>(Task<PAACHOBIIFN<T>> LDLKICLCOAG) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x36A0B10", Offset = "0x369FD10", VA = "0x1836A0B10")]
	public static PAACHOBIIFN<TOut> NBDDMFIBPFA<TOut, TIn>(PAACHOBIIFN<TIn> NLNGJFNOHGL, Func<TIn, TOut> NMHAFEDCMAA) where TOut : notnull where TIn : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public abstract class FBGDNDHDIBD<T> : PAACHOBIIFN<T>, NCBKHDICHNJ, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly string CMBFLFBAJKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private readonly PIJFLCEMDCN AJDADEFHJHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private bool DJOMNIEOFJP;

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public bool GLGAHOJADMO
	{
		[Cpp2IlInjected.Token(Token = "0x600016C")]
		[Cpp2IlInjected.Address(RVA = "0xC8D1F0", Offset = "0xC8C3F0", VA = "0x180C8D1F0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public abstract Task<T> FMPPMCAKLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600016D")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public abstract CMEBMOPMCFP<T> PGNPLOLACCK
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x498CE40", Offset = "0x498C040", VA = "0x18498CE40")]
	public FBGDNDHDIBD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x498CB30", Offset = "0x498BD30", VA = "0x18498CB30", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void JHIKCOMNLGG();
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public abstract class KDNGCMNJOMB<TTask, T> : FBGDNDHDIBD<T> where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000053")]
	[CompilerGenerated]
	private sealed class BACFNOHDNCA
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
			public BACFNOHDNCA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000D3")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600017B")]
			[Cpp2IlInjected.Address(RVA = "0x40CA170", Offset = "0x40C9370", VA = "0x1840CA170", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600017C")]
			[Cpp2IlInjected.Address(RVA = "0x40CA430", Offset = "0x40C9630", VA = "0x1840CA430", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public KDNGCMNJOMB<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000179")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public BACFNOHDNCA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600017A")]
		[Cpp2IlInjected.Address(RVA = "0x5E64D90", Offset = "0x5E63F90", VA = "0x185E64D90")]
		[AsyncStateMachine(typeof(KDNGCMNJOMB<, >.BACFNOHDNCA.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> JGNFAEOPGOL(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private readonly Task<T> LDLKICLCOAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	protected readonly CancellationTokenSource BDMFGMOCHPG;

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public override Task<T> FMPPMCAKLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public override CMEBMOPMCFP<T> PGNPLOLACCK
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x4FFDE50", Offset = "0x4FFD050", VA = "0x184FFDE50")]
	protected KDNGCMNJOMB(TTask LDLKICLCOAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x4FFDE00", Offset = "0x4FFD000", VA = "0x184FFDE00", Slot = "10")]
	protected override void JHIKCOMNLGG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract T DIPNANLPGNN(TTask OBBHLIEHBKJ);

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(Slot = "12")]
	protected abstract void OEOOAOLMMGM();
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class PMJLKAOHDOF<T> : FBGDNDHDIBD<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private readonly LGILIJIJPGJ<Task<T>> KJBINEOHIIP;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public override Task<T> FMPPMCAKLGJ
	{
		[Cpp2IlInjected.Token(Token = "0x600017D")]
		[Cpp2IlInjected.Address(RVA = "0x4992630", Offset = "0x4991830", VA = "0x184992630", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public override CMEBMOPMCFP<T> PGNPLOLACCK
	{
		[Cpp2IlInjected.Token(Token = "0x600017E")]
		[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x5638280", Offset = "0x5637480", VA = "0x185638280")]
	public PMJLKAOHDOF(LGILIJIJPGJ<Task<T>> EOLCGBNMDFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x5638260", Offset = "0x5637460", VA = "0x185638260", Slot = "10")]
	protected override void JHIKCOMNLGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public static class PABMNELGLBL
{
	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public static readonly HashAlgorithmName AHEPCGKDLGA;

	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private static readonly ThreadLocal<IncrementalHash> LMABACDOKAG;

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x7C5E710", Offset = "0x7C5D910", VA = "0x187C5E710")]
	public static int CECPKJAMAMA(this ABOGIEJNNMO KDLBJJHNOLG, IncrementalHash BDJMEJKDJOJ, byte[] CJGHAEANDGO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x7C5EAB0", Offset = "0x7C5DCB0", VA = "0x187C5EAB0")]
	public static bool EEPJHIIJJNG([CanBeNull] this ABOGIEJNNMO KDLBJJHNOLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x7C5E7A0", Offset = "0x7C5D9A0", VA = "0x187C5E7A0")]
	public static bool EEPJHIIJJNG([CanBeNull] this ABOGIEJNNMO KDLBJJHNOLG, [Out] string KOIHEPAFBFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x7C5EB10", Offset = "0x7C5DD10", VA = "0x187C5EB10")]
	public static bool EEPJHIIJJNG([CanBeNull] this ABOGIEJNNMO KDLBJJHNOLG, IncrementalHash BDJMEJKDJOJ, byte[] CJGHAEANDGO, [Out] string KOIHEPAFBFG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x7C5EE50", Offset = "0x7C5E050", VA = "0x187C5EE50")]
	private static bool LIPHMCOPHJF(byte[] CCIKKBNFBMO, Span<byte> DAGPIOGGDPN)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000058")]
public static class DAGJOMAIMHA
{
	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x7C5C880", Offset = "0x7C5BA80", VA = "0x187C5C880")]
	public static int FCHOKMEHBMI(HashAlgorithmName FLIBJPHGKDH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x3661CB0", Offset = "0x3660EB0", VA = "0x183661CB0")]
	public static int CECPKJAMAMA<T>(this T ACEFAEHKHHN, byte[] FHKGAODCJFA, IncrementalHash BDJMEJKDJOJ, byte[] IMAOOEEODGP) where T : JAMOOGIBOOM
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public interface JAMOOGIBOOM
{
	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash BDJMEJKDJOJ);
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public interface ABOGIEJNNMO : JAMOOGIBOOM
{
	[Cpp2IlInjected.Token(Token = "0x17000053")]
	[CanBeNull]
	byte[] ENINKHEMJKN
	{
		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	[CanBeNull]
	byte[] FDAHEJGENAD
	{
		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public static class NAIGOBLLPGO
{
	[Cpp2IlInjected.Token(Token = "0x40000D9")]
	private static bool KJEMCNLLDKA;

	[Cpp2IlInjected.Token(Token = "0x40000DA")]
	private static readonly ArrayPool<byte> IDBOGBKCICP;

	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private static readonly ArrayPool<char> EKJIJHIOPJO;

	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private static readonly Encoding JLGDELACAOK;

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private static readonly ThreadLocal<Encoder> NMICNKDPDFK;

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x397E6B0", Offset = "0x397D8B0", VA = "0x18397E6B0")]
	public static void JGALJIHCJBB<T>(this IncrementalHash KCHIGIMHCOG, [CanBeNull] T CBNJHLDNKAL) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x397E620", Offset = "0x397D820", VA = "0x18397E620")]
	public static void IFDJJDNNMKJ<T>(this IncrementalHash KCHIGIMHCOG, [CanBeNull] T ACEFAEHKHHN) where T : JAMOOGIBOOM
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x397EDA0", Offset = "0x397DFA0", VA = "0x18397EDA0")]
	public static void MBFEDFDCOFB<T>(this IncrementalHash KCHIGIMHCOG, [CanBeNull] IList<T> JPBKFHGAEOF) where T : JAMOOGIBOOM
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x7C5D9A0", Offset = "0x7C5CBA0", VA = "0x187C5D9A0")]
	private static bool HCMDKDAMNEH([CanBeNull] JAMOOGIBOOM ACEFAEHKHHN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x7C5DA90", Offset = "0x7C5CC90", VA = "0x187C5DA90")]
	public static void KEEHBKDLIGN(this IncrementalHash BDJMEJKDJOJ, string? BJOGJELELJA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x7C5D7D0", Offset = "0x7C5C9D0", VA = "0x187C5D7D0")]
	public static void FLGGGPBEGNG(this IncrementalHash BDJMEJKDJOJ, long GINCEGHLOJC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x7C5D490", Offset = "0x7C5C690", VA = "0x187C5D490")]
	public static void BPICJINKKBM(this IncrementalHash BDJMEJKDJOJ, int BNKOALGALDD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x7C5DEF0", Offset = "0x7C5D0F0", VA = "0x187C5DEF0")]
	public static void KMAKKGEEBBC(this IncrementalHash BDJMEJKDJOJ, short KHFEBDBLICF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x7C5D6C0", Offset = "0x7C5C8C0", VA = "0x187C5D6C0")]
	public static void EGGMGPBCICB(this IncrementalHash BDJMEJKDJOJ, byte CFBGALAAFIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x7C5D320", Offset = "0x7C5C520", VA = "0x187C5D320")]
	public static void AAKNFLAGIHC(this IncrementalHash BDJMEJKDJOJ, bool OAOEMOPKDDF, bool KNEAFKJIABK = false, bool KNOLNAMJLKD = false, bool KIAMBPBNIJA = false, bool JBBDHDMODAO = false, bool MPCEGKBDLAD = false, bool BFGCMLFOBPB = false, bool EFMMIFDJCJG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x397E770", Offset = "0x397D970", VA = "0x18397E770")]
	public static void KAKFJNIFOCK<T>(this IncrementalHash BDJMEJKDJOJ, T EJKIDBDKPMD) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x7C5DA30", Offset = "0x7C5CC30", VA = "0x187C5DA30")]
	public static void KABHLMAHCCP(this IncrementalHash BDJMEJKDJOJ, float MCACECMKMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x7C5E0C0", Offset = "0x7C5D2C0", VA = "0x187C5E0C0")]
	public static void OCANIMMFLHA(this IncrementalHash BDJMEJKDJOJ, ulong AGPJEAIIGGF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x7C5DE90", Offset = "0x7C5D090", VA = "0x187C5DE90")]
	public static void KJBOBAOOHNJ(this IncrementalHash BDJMEJKDJOJ, uint FNNBPLFOLJJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x7C5D660", Offset = "0x7C5C860", VA = "0x187C5D660")]
	public static void EALMLNHHEBE(this IncrementalHash BDJMEJKDJOJ, ushort COMMCAKCFOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x7C5E120", Offset = "0x7C5D320", VA = "0x187C5E120")]
	public static void PDANHMKLAAE(this IncrementalHash BDJMEJKDJOJ, Vector3 KCNCKIFKJAG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class CACPDKDELMO : Exception
{
	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x7C5C440", Offset = "0x7C5B640", VA = "0x187C5C440")]
	public CACPDKDELMO(string BDAAPBJEHGD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public abstract class DDPPKMGAECG
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public delegate void DPEFPHEBENO(ushort GGMKNPLMOEL, ushort HBNNCOBBFDP, ushort NKBJELMNMCP, ushort BKHDHPKFIMC);

	[Cpp2IlInjected.Token(Token = "0x2000060")]
	public delegate void HILJJPILOLF(ushort KGKHBACCFKH, ushort BNHEFBHINPM);

	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public delegate void CBCEGEHNNCA();

	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	public const ushort ICCDJDFJJAK = ushort.MaxValue;

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
	protected DDPPKMGAECG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public abstract class AACOOPOILGJ<T> : DDPPKMGAECG where T : AACOOPOILGJ<T>.GEJGMDLPMNM
{
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public interface GEJGMDLPMNM
	{
		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		HILJJPILOLF FKGALHADJAJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		HILJJPILOLF KIJMMLJEPHH
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		CBCEGEHNNCA KHEOBMHLFLK
		{
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private Dictionary<uint, T> KCEGLKNKIGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private CBCEGEHNNCA HHMMMJCHENF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private CBCEGEHNNCA MNMNACCOODN;

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public bool HIGNGFGMGFB
	{
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0xAACFF0", Offset = "0xAAC1F0", VA = "0x180AACFF0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x9F8320", Offset = "0x9F7520", VA = "0x1809F8320")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public ushort NIIMNDLFEKK
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x4A23E70", Offset = "0x4A23070", VA = "0x184A23E70")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x4A23E50", Offset = "0x4A23050", VA = "0x184A23E50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public ushort CNOIKEFOPFP
	{
		[Cpp2IlInjected.Token(Token = "0x60001B1")]
		[Cpp2IlInjected.Address(RVA = "0x4A22E20", Offset = "0x4A22020", VA = "0x184A22E20")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B2")]
		[Cpp2IlInjected.Address(RVA = "0x4A22E30", Offset = "0x4A22030", VA = "0x184A22E30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public ushort HIMHDCKFBKG
	{
		[Cpp2IlInjected.Token(Token = "0x60001B3")]
		[Cpp2IlInjected.Address(RVA = "0xDD6CF0", Offset = "0xDD5EF0", VA = "0x180DD6CF0")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B4")]
		[Cpp2IlInjected.Address(RVA = "0xDD6E00", Offset = "0xDD6000", VA = "0x180DD6E00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public ushort FCDALNAMNHJ
	{
		[Cpp2IlInjected.Token(Token = "0x60001B5")]
		[Cpp2IlInjected.Address(RVA = "0x4A23F00", Offset = "0x4A23100", VA = "0x184A23F00")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x4A22E10", Offset = "0x4A22010", VA = "0x184A22E10")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	protected bool BIAAEMGCLKI
	{
		[Cpp2IlInjected.Token(Token = "0x60001BA")]
		[Cpp2IlInjected.Address(RVA = "0x17ADAF0", Offset = "0x17ACCF0", VA = "0x1817ADAF0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	protected bool NCGICBNNAMO
	{
		[Cpp2IlInjected.Token(Token = "0x60001BB")]
		[Cpp2IlInjected.Address(RVA = "0xEA6760", Offset = "0xEA5960", VA = "0x180EA6760")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event DPEFPHEBENO FAPFJLFMAFG
	{
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x4A23260", Offset = "0x4A22460", VA = "0x184A23260")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x4A22F50", Offset = "0x4A22150", VA = "0x184A22F50")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x4A22E40", Offset = "0x4A22040", VA = "0x184A22E40")]
	private T CIKKAMALOHN(ushort HNJFMGHKBLF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x4A22FF0", Offset = "0x4A221F0", VA = "0x184A22FF0")]
	private T FDBDDIHOHOL(ushort HNJFMGHKBLF, ushort PABIOMNJEBL)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x4A23E80", Offset = "0x4A23080", VA = "0x184A23E80")]
	protected T NJECLDKMBAC(uint GJNFKAALFEM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x4A23F10", Offset = "0x4A23110", VA = "0x184A23F10")]
	protected AACOOPOILGJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x4A23220", Offset = "0x4A22420", VA = "0x184A23220")]
	public void GJINKAMNJKC(ushort NBBAPNKDABE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x4A231C0", Offset = "0x4A223C0", VA = "0x184A231C0")]
	public void GJINKAMNJKC(ushort NBBAPNKDABE, ushort IDFMEGKANPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x4A230B0", Offset = "0x4A222B0", VA = "0x184A230B0", Slot = "4")]
	protected virtual void GJINKAMNJKC(uint KOALPDBHIHB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x4A23570", Offset = "0x4A22770", VA = "0x184A23570")]
	protected void IFGIGLKAGKC(uint KOALPDBHIHB, uint IENIOEBFLKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x4A23DA0", Offset = "0x4A22FA0", VA = "0x184A23DA0")]
	protected void KHJGPBIBCAN(ushort HNJFMGHKBLF, ushort PABIOMNJEBL, T HPAPEOOKLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x4A22EF0", Offset = "0x4A220F0", VA = "0x184A22EF0")]
	private void DNPCBPGCHNP(uint GJNFKAALFEM, T HPAPEOOKLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x4A23300", Offset = "0x4A22500", VA = "0x184A23300")]
	protected void HFPAHEEFKPN(float PNLPAJFPFCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x4A23EE0", Offset = "0x4A230E0", VA = "0x184A23EE0")]
	protected uint OHCGDPJJBMK(ushort HNJFMGHKBLF, ushort PABIOMNJEBL)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x4A23EF0", Offset = "0x4A230F0", VA = "0x184A23EF0")]
	protected ushort PAJODJEGMKE(uint BMLJLAGJPMH)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x4A23E60", Offset = "0x4A23060", VA = "0x184A23E60")]
	protected ushort LAKOIBHOMKK(uint BMLJLAGJPMH)
	{
		return default(ushort);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public abstract class MIBAPJLCEDF : AACOOPOILGJ<MIBAPJLCEDF.JECMHLNOLJM>
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public class JECMHLNOLJM : GEJGMDLPMNM
	{
		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public HILJJPILOLF FKGALHADJAJ
		{
			[Cpp2IlInjected.Token(Token = "0x60001CE")]
			[Cpp2IlInjected.Address(RVA = "0x9F24E0", Offset = "0x9F16E0", VA = "0x1809F24E0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001CF")]
			[Cpp2IlInjected.Address(RVA = "0x9F24D0", Offset = "0x9F16D0", VA = "0x1809F24D0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public HILJJPILOLF KIJMMLJEPHH
		{
			[Cpp2IlInjected.Token(Token = "0x60001D0")]
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D1")]
			[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000061")]
		public CBCEGEHNNCA KHEOBMHLFLK
		{
			[Cpp2IlInjected.Token(Token = "0x60001D2")]
			[Cpp2IlInjected.Address(RVA = "0x9FA770", Offset = "0x9F9970", VA = "0x1809FA770", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001D3")]
			[Cpp2IlInjected.Address(RVA = "0x9F1AC0", Offset = "0x9F0CC0", VA = "0x1809F1AC0")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public JECMHLNOLJM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x7C5D110", Offset = "0x7C5C310", VA = "0x187C5D110")]
	public void BNGIAKLOCKM(ushort AOHJLFBLJBI, HILJJPILOLF BIEFJFAJJOK, HILJJPILOLF BOAJLMHMBCG, CBCEGEHNNCA KOAHJBCHANG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x7C5D1F0", Offset = "0x7C5C3F0", VA = "0x187C5D1F0")]
	public void BNGIAKLOCKM(ushort HNJFMGHKBLF, ushort PABIOMNJEBL, HILJJPILOLF BIEFJFAJJOK, HILJJPILOLF BOAJLMHMBCG, CBCEGEHNNCA KOAHJBCHANG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x7C5D2D0", Offset = "0x7C5C4D0", VA = "0x187C5D2D0")]
	public void IOJFMKAPHLJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x7C5CD90", Offset = "0x7C5BF90", VA = "0x187C5CD90")]
	protected MIBAPJLCEDF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class EMLFMIJEOGB : MIBAPJLCEDF
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private bool DAACGONLPME;

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public bool DBBHGEKFDEM
	{
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0xC1FDC0", Offset = "0xC1EFC0", VA = "0x180C1FDC0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0xCF9F40", Offset = "0xCF9140", VA = "0x180CF9F40")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x7C5CCD0", Offset = "0x7C5BED0", VA = "0x187C5CCD0")]
	public void ILLMBOBOELN(ushort GEOMLHKKCIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x7C5CD30", Offset = "0x7C5BF30", VA = "0x187C5CD30")]
	public void ILLMBOBOELN(ushort GEOMLHKKCIF, ushort OLONENEOJDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x7C5CD90", Offset = "0x7C5BF90", VA = "0x187C5CD90")]
	public EMLFMIJEOGB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public abstract class EEACKECOPGF<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	internal class MKDBLILOIPB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		public TNode CEENCLMGJAM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		public TNode NJHDJGHEICO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public ICFBMLBFNOG FNEFIOJLPDJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public List<ICFBMLBFNOG> LOKIJPFCDLC;

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public MKDBLILOIPB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000069")]
	internal struct ICFBMLBFNOG : IComparable<ICFBMLBFNOG>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public int NNIDLNKAMEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public TClaimant GNOMNPPKFAI;

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x1661190", Offset = "0x1660390", VA = "0x181661190")]
		public ICFBMLBFNOG(int NNIDLNKAMEF, TClaimant GNOMNPPKFAI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x4C6EA10", Offset = "0x4C6DC10", VA = "0x184C6EA10")]
		public bool JIBAJJNHCKF([In] ICFBMLBFNOG FNJGMJGALLH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x4C6EA00", Offset = "0x4C6DC00", VA = "0x184C6EA00")]
		public bool IIFALJDMDJP([In] ICFBMLBFNOG FNJGMJGALLH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x4C6E9F0", Offset = "0x4C6DBF0", VA = "0x184C6E9F0", Slot = "4")]
		public int CompareTo(ICFBMLBFNOG FNJGMJGALLH)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x4C6EA70", Offset = "0x4C6DC70", VA = "0x184C6EA70", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public enum NBILFHNAIKE
	{
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	[CompilerGenerated]
	private sealed class IFFIFIBIGLJ : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
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
		public EEACKECOPGF<TClaimant, TNode> <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0xE9E930", Offset = "0xE9DB30", VA = "0x180E9E930")]
		[DebuggerHidden]
		public IFFIFIBIGLJ(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F5")]
		[Cpp2IlInjected.Address(RVA = "0x9F07A0", Offset = "0x9EF9A0", VA = "0x1809F07A0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F6")]
		[Cpp2IlInjected.Address(RVA = "0x4C769F0", Offset = "0x4C75BF0", VA = "0x184C769F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F8")]
		[Cpp2IlInjected.Address(RVA = "0x4C76BD0", Offset = "0x4C75DD0", VA = "0x184C76BD0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x4C76AD0", Offset = "0x4C75CD0", VA = "0x184C76AD0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x49E2A10", Offset = "0x49E1C10", VA = "0x1849E2A10", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	private static readonly CKCBDAAIPAI<MKDBLILOIPB> BJIONBLFIHC;

	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private static readonly CKCBDAAIPAI<List<ICFBMLBFNOG>> OAMHKPCIKEC;

	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private static int LFJNDKIABBG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	internal readonly Dictionary<TClaimant, TNode> MACJJEJMHHJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	internal readonly Dictionary<TNode, MKDBLILOIPB> IJDFJKHONJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private NBILFHNAIKE BGIKBFMPDCC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private bool KBCJGENOOPH;

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode DICAHIEPFHK(TNode GCEDHPINDAM);

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void KCEPIOOBOFO(TNode GCEDHPINDAM, TClaimant KEMDDKEKMKD, TClaimant FMILAEGCOGK);

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x452C890", Offset = "0x452BA90", VA = "0x18452C890")]
	public EEACKECOPGF(NBILFHNAIKE BGIKBFMPDCC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x452C100", Offset = "0x452B300", VA = "0x18452C100")]
	public void KCAEFFOPMBB(TNode GCEDHPINDAM, TNode LMLNPPNKKKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x452C2B0", Offset = "0x452B4B0", VA = "0x18452C2B0")]
	public void LLKEEFBBKBO(TClaimant GNOMNPPKFAI, TNode CABADPGLDKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x452B5E0", Offset = "0x452A7E0", VA = "0x18452B5E0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x452C5F0", Offset = "0x452B7F0", VA = "0x18452C5F0")]
	private void OBAFKOEDBCI(TClaimant GNOMNPPKFAI, TNode EFEGHAJFAEK, TNode CABADPGLDKM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x452B7E0", Offset = "0x452A9E0", VA = "0x18452B7E0")]
	private int EKEGHJMGDLA()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x452B160", Offset = "0x452A360", VA = "0x18452B160")]
	private void CMEABNJONOK(TClaimant GNOMNPPKFAI, TNode FOGBMEONCIL, TNode GBGHCIFKFNP, int BHJODPNBDHA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x452BD40", Offset = "0x452AF40", VA = "0x18452BD40")]
	private void HNGANHDEKJF(ICFBMLBFNOG JCGIBPOLKNM, MKDBLILOIPB HHHCEJKIPDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x452BE10", Offset = "0x452B010", VA = "0x18452BE10")]
	private void JDAHDOFMIMO(TClaimant GNOMNPPKFAI, TNode FOGBMEONCIL, TNode GBGHCIFKFNP, int BHJODPNBDHA = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x452B4B0", Offset = "0x452A6B0", VA = "0x18452B4B0")]
	private void DGODIBPOBMI(ICFBMLBFNOG JCGIBPOLKNM, TNode GCEDHPINDAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x452B000", Offset = "0x452A200", VA = "0x18452B000")]
	private void BEFIJAADBOI(ICFBMLBFNOG JCGIBPOLKNM, MKDBLILOIPB HHHCEJKIPDB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x452ADA0", Offset = "0x4529FA0", VA = "0x18452ADA0")]
	private void ADLOIEJNALM(MKDBLILOIPB HHHCEJKIPDB, bool JNEHIAOJFJA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x452B9D0", Offset = "0x452ABD0", VA = "0x18452B9D0")]
	private void HGILANCICIE(MKDBLILOIPB HHHCEJKIPDB, TNode LMLNPPNKKKE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x452C1C0", Offset = "0x452B3C0", VA = "0x18452C1C0")]
	[IteratorStateMachine(typeof(EEACKECOPGF<, >.IFFIFIBIGLJ))]
	private IEnumerable<TNode> LDIELNHMPPO(TNode FOGBMEONCIL, TNode GBGHCIFKFNP, bool ODDANEHAIDA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x452AEF0", Offset = "0x452A0F0", VA = "0x18452AEF0")]
	private MKDBLILOIPB AOKJMADOPDB(TNode GCEDHPINDAM, TNode NJHDJGHEICO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x452B850", Offset = "0x452AA50", VA = "0x18452B850")]
	private MKDBLILOIPB HGHIJJOKPAM(TNode GCEDHPINDAM, TNode NJHDJGHEICO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x452C430", Offset = "0x452B630", VA = "0x18452C430")]
	private void LNBIFFBIHDM(MKDBLILOIPB HHHCEJKIPDB)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class AEMJFKONPIM<T> : IEnumerable<AEMJFKONPIM<T>.GKDGBMBHNBP>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200006D")]
	public struct GKDGBMBHNBP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		public T MLCDCHNOCFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		public int NIBICIJAIGM;
	}

	[Cpp2IlInjected.Token(Token = "0x200006E")]
	public class ECANGFCGEAI : IEnumerator<GKDGBMBHNBP>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		private AEMJFKONPIM<T> JPGJDFDDJJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		private int NIBICIJAIGM;

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x4523EB0", Offset = "0x45230B0", VA = "0x184523EB0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000068")]
		public GKDGBMBHNBP HJBNOIBEMOP
		{
			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x4523FF0", Offset = "0x45231F0", VA = "0x184523FF0", Slot = "4")]
			get
			{
				return default(GKDGBMBHNBP);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x4523FB0", Offset = "0x45231B0", VA = "0x184523FB0")]
		public ECANGFCGEAI(AEMJFKONPIM<T> JPGJDFDDJJG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x4523E20", Offset = "0x4523020", VA = "0x184523E20", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x4523EA0", Offset = "0x45230A0", VA = "0x184523EA0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x11530D0", Offset = "0x11522D0", VA = "0x1811530D0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006F")]
	private struct NGNJFFEGNNM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public bool FFJBLELFKFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public T MLCDCHNOCFI;
	}

	[Cpp2IlInjected.Token(Token = "0x4000107")]
	private const int LJKMCNCJMFO = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	private readonly Dictionary<T, int> MMOCCGPMCJA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private NGNJFFEGNNM[] GHPKKFJBAJO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private int JPCJFDEDNNJ;

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public int DLCDMLLHEJE
	{
		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0xD34630", Offset = "0xD33830", VA = "0x180D34630")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0xF275F0", Offset = "0xF267F0", VA = "0x180F275F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public int FAGABNHAKHN
	{
		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x40DBD40", Offset = "0x40DAF40", VA = "0x1840DBD40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x4A7FB80", Offset = "0x4A7ED80", VA = "0x184A7FB80")]
	public AEMJFKONPIM(int PIBKMAHMMLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x4A7FC70", Offset = "0x4A7EE70", VA = "0x184A7FC70")]
	public AEMJFKONPIM(GKDGBMBHNBP[] AOGOCGJHCAA, bool ICMPEHCJGKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000201")]
	[Cpp2IlInjected.Address(RVA = "0x4A7ED90", Offset = "0x4A7DF90", VA = "0x184A7ED90")]
	public int BABJJHCGOGD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000202")]
	[Cpp2IlInjected.Address(RVA = "0x4A7EE50", Offset = "0x4A7E050", VA = "0x184A7EE50")]
	private int CFBKNFIIFFC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000203")]
	[Cpp2IlInjected.Address(RVA = "0x4A7FA90", Offset = "0x4A7EC90", VA = "0x184A7FA90", Slot = "6")]
	protected virtual uint OJONCDOEGCA(uint BDJMEJKDJOJ, T MLCDCHNOCFI)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x4A7F930", Offset = "0x4A7EB30", VA = "0x184A7F930")]
	public bool IFKALMBLEBM(T MLCDCHNOCFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x4A7FA10", Offset = "0x4A7EC10", VA = "0x184A7FA10")]
	public int IILKBHODFDK(T MLCDCHNOCFI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x4A7ECD0", Offset = "0x4A7DED0", VA = "0x184A7ECD0")]
	public T AMMOCOJJGOL(int NIBICIJAIGM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x4A7F870", Offset = "0x4A7EA70", VA = "0x184A7F870")]
	public bool IEDEMMHGMJO(T MLCDCHNOCFI, bool IIHIAMMMMPG = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x4A7F320", Offset = "0x4A7E520", VA = "0x184A7F320")]
	public bool IEDEMMHGMJO(T MLCDCHNOCFI, int NIBICIJAIGM, bool IIHIAMMMMPG = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x4A7F2D0", Offset = "0x4A7E4D0", VA = "0x184A7F2D0")]
	private int EONPMPEAFHA(int AIGLIPKHKOK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x4A7FAE0", Offset = "0x4A7ECE0", VA = "0x184A7FAE0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x4A7FAE0", Offset = "0x4A7ECE0", VA = "0x184A7FAE0", Slot = "4")]
	private IEnumerator<GKDGBMBHNBP> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000070")]
public class CKCBDAAIPAI<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000112")]
	private readonly Stack<T> PLCKFFFKLMB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000113")]
	private readonly List<T> KNALMOLKPCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000114")]
	private readonly int PHMDEENEHMP;

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x654FCF0", Offset = "0x654EEF0", VA = "0x18654FCF0")]
	public static CKCBDAAIPAI<T> HBGGCFKAAAL(int PIBKMAHMMLH = 0, int PHMDEENEHMP = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x654F990", Offset = "0x654EB90", VA = "0x18654F990")]
	public static CKCBDAAIPAI<T> CKHMMMJDEOE(int PIBKMAHMMLH = 0, int PHMDEENEHMP = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x6550320", Offset = "0x654F520", VA = "0x186550320")]
	public CKCBDAAIPAI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x6550110", Offset = "0x654F310", VA = "0x186550110")]
	public CKCBDAAIPAI(int PIBKMAHMMLH, int PHMDEENEHMP = int.MaxValue, bool HIICKKDDOAF = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x654F7C0", Offset = "0x654E9C0", VA = "0x18654F7C0")]
	public T CANMOBCCPFJ()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x654FC10", Offset = "0x654EE10", VA = "0x18654FC10")]
	public void EFCGIOJACBM(T MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000218")]
	[Cpp2IlInjected.Address(RVA = "0x654FFD0", Offset = "0x654F1D0", VA = "0x18654FFD0")]
	private void HFMOAMAIIKL(T MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x65500D0", Offset = "0x654F2D0", VA = "0x1865500D0")]
	private void KHFKFOFGEHF(T MLCDCHNOCFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x654FA80", Offset = "0x654EC80", VA = "0x18654FA80", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x654FDE0", Offset = "0x654EFE0", VA = "0x18654FDE0")]
	private void HFHBMJDJONE(IEnumerable<T> CPMBLPBIGIH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000071")]
public class CGHKEOCFOIP<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000115")]
	private Dictionary<int, T> IEEHHNMCCEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000116")]
	private T MMAPFOMGHGF;

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public virtual T MBGCKICODPB
	{
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x9F2460", Offset = "0x9F1660", VA = "0x1809F2460", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021D")]
		[Cpp2IlInjected.Address(RVA = "0x9F1AB0", Offset = "0x9F0CB0", VA = "0x1809F1AB0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x653B340", Offset = "0x653A540", VA = "0x18653B340")]
	public bool DHOBLHFMEFC(T MLCDCHNOCFI, int NNIDLNKAMEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x4B1F630", Offset = "0x4B1E830", VA = "0x184B1F630")]
	public bool EJDGOKPPHLI(int NNIDLNKAMEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x653B670", Offset = "0x653A870", VA = "0x18653B670")]
	public T NGDFOBAMHKH(int FDHGIEGADPJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x653B1C0", Offset = "0x653A3C0", VA = "0x18653B1C0")]
	private bool BGEKCDDPAHJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x653B3E0", Offset = "0x653A5E0", VA = "0x18653B3E0")]
	public bool FLFGMEICIOC(int NNIDLNKAMEF, [Out] T MLCDCHNOCFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000223")]
	[Cpp2IlInjected.Address(RVA = "0x644D940", Offset = "0x644CB40", VA = "0x18644D940")]
	public CGHKEOCFOIP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public class EDGDLKALANB<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	protected struct JOAOCFCHCPH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		public T ABLHJAOAOGP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		public int AFKEOEFICMO;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000117")]
	protected readonly List<JOAOCFCHCPH> PHDEJHGJNAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000118")]
	private T KOIPPBMFADC;

	[Cpp2IlInjected.Token(Token = "0x1700006A")]
	public int FAGABNHAKHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x40DBD40", Offset = "0x40DAF40", VA = "0x1840DBD40")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x4529200", Offset = "0x4528400", VA = "0x184529200")]
	public bool HHAMPMLOBIE(T MLCDCHNOCFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x4529A90", Offset = "0x4528C90", VA = "0x184529A90")]
	public void OOLDDNFEGEK(T MLCDCHNOCFI, int NNIDLNKAMEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x45295F0", Offset = "0x45287F0", VA = "0x1845295F0")]
	public bool KKKHDEJPLIG(T MLCDCHNOCFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x4529160", Offset = "0x4528360", VA = "0x184529160")]
	public void FKFEALEGJFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x45299F0", Offset = "0x4528BF0", VA = "0x1845299F0")]
	public T NBGDLKAEOOL()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x4528FE0", Offset = "0x45281E0", VA = "0x184528FE0")]
	protected void DNKCOJOFNKM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600022B")]
	[Cpp2IlInjected.Address(RVA = "0x4529C20", Offset = "0x4528E20", VA = "0x184529C20")]
	public EDGDLKALANB()
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
		[GABLABEDCEL(HJNEPGJJFOF.Self, false, false, false)]
		[SerializeField]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x600022C")]
			[Cpp2IlInjected.Address(RVA = "0x7C5F150", Offset = "0x7C5E350", VA = "0x187C5F150")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x600022D")]
			[Cpp2IlInjected.Address(RVA = "0x7C5F420", Offset = "0x7C5E620", VA = "0x187C5F420")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x600022E")]
			[Cpp2IlInjected.Address(RVA = "0x7C5F330", Offset = "0x7C5E530", VA = "0x187C5F330")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x600022F")]
			[Cpp2IlInjected.Address(RVA = "0x7C5F0A0", Offset = "0x7C5E2A0", VA = "0x187C5F0A0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x6000230")]
			[Cpp2IlInjected.Address(RVA = "0x7C5F370", Offset = "0x7C5E570", VA = "0x187C5F370")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006F")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x6000231")]
			[Cpp2IlInjected.Address(RVA = "0x7C5F280", Offset = "0x7C5E480", VA = "0x187C5F280")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x7C5F020", Offset = "0x7C5E220", VA = "0x187C5F020")]
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
		[Cpp2IlInjected.Address(RVA = "0x580FCE0", Offset = "0x580EEE0", VA = "0x18580FCE0", Slot = "4")]
		public virtual T NAKBABNGGEJ()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public interface MANHGIFANOO
{
	[Cpp2IlInjected.Token(Token = "0x17000070")]
	ToolHierarchyCache PCPKOIACMHF
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
		public struct AEAOKDAILNM<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000124")]
			private readonly List<Component> MEHAOGGFJIO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000125")]
			private readonly bool AHIEFMDCCLG;

			[Cpp2IlInjected.Token(Token = "0x6000242")]
			[Cpp2IlInjected.Address(RVA = "0x17BD360", Offset = "0x17BC560", VA = "0x1817BD360")]
			public AEAOKDAILNM(List<Component> MEHAOGGFJIO, bool AHIEFMDCCLG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000243")]
			[Cpp2IlInjected.Address(RVA = "0x4A7DDA0", Offset = "0x4A7CFA0", VA = "0x184A7DDA0")]
			public ACOALMHMCHF<T> MAJHBAEJHEK()
			{
				return default(ACOALMHMCHF<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000244")]
			[Cpp2IlInjected.Address(RVA = "0x4A7DE00", Offset = "0x4A7D000", VA = "0x184A7DE00", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000245")]
			[Cpp2IlInjected.Address(RVA = "0x4A7DE00", Offset = "0x4A7D000", VA = "0x184A7DE00", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000079")]
		public struct ACOALMHMCHF<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000126")]
			private readonly List<Component> MEHAOGGFJIO;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000127")]
			private readonly bool AHIEFMDCCLG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000128")]
			private int NIBICIJAIGM;

			[Cpp2IlInjected.Token(Token = "0x17000072")]
			public T HJBNOIBEMOP
			{
				[Cpp2IlInjected.Token(Token = "0x6000247")]
				[Cpp2IlInjected.Address(RVA = "0x4A28EB0", Offset = "0x4A280B0", VA = "0x184A28EB0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000073")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000248")]
				[Cpp2IlInjected.Address(RVA = "0x4A28E40", Offset = "0x4A28040", VA = "0x184A28E40", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000246")]
			[Cpp2IlInjected.Address(RVA = "0x4A28E80", Offset = "0x4A28080", VA = "0x184A28E80")]
			public ACOALMHMCHF(List<Component> MEHAOGGFJIO, bool AHIEFMDCCLG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000249")]
			[Cpp2IlInjected.Address(RVA = "0x4A28D80", Offset = "0x4A27F80", VA = "0x184A28D80", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600024A")]
			[Cpp2IlInjected.Address(RVA = "0x4A28D90", Offset = "0x4A27F90", VA = "0x184A28D90", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600024B")]
			[Cpp2IlInjected.Address(RVA = "0x45A7280", Offset = "0x45A6480", VA = "0x1845A7280", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x7C60E10", Offset = "0x7C60010", VA = "0x187C60E10")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000237")]
		[Cpp2IlInjected.Address(RVA = "0x9F6BD0", Offset = "0x9F5DD0", VA = "0x1809F6BD0")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000238")]
		[Cpp2IlInjected.Address(RVA = "0x7C60C10", Offset = "0x7C5FE10", VA = "0x187C60C10")]
		private void ILLMBOBOELN(GameObject FOEGMFMLJCB, bool LIEHHNOLAGC = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000239")]
		[Cpp2IlInjected.Address(RVA = "0x7C60B80", Offset = "0x7C5FD80", VA = "0x187C60B80")]
		public static void ILLMBOBOELN(GameObject FOEGMFMLJCB, ToolHierarchyCache EBBLCJEIDAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023A")]
		[Cpp2IlInjected.Address(RVA = "0x7C60700", Offset = "0x7C5F900", VA = "0x187C60700")]
		public void EKKFJPFEFEC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023B")]
		[Cpp2IlInjected.Address(RVA = "0x3C15AC0", Offset = "0x3C14CC0", VA = "0x183C15AC0")]
		public void OKHOIHBMCJG<T>(Action<T> HDKINMMJOHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600023C")]
		[Cpp2IlInjected.Address(RVA = "0x3C15960", Offset = "0x3C14B60", VA = "0x183C15960")]
		public T CGIOFLHAHBH<T>(bool AHIEFMDCCLG = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023D")]
		[Cpp2IlInjected.Address(RVA = "0x3C15A00", Offset = "0x3C14C00", VA = "0x183C15A00")]
		public AEAOKDAILNM<T> DLHHNDIAHNL<T>(bool AHIEFMDCCLG = false) where T : class
		{
			return default(AEAOKDAILNM<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x600023E")]
		[Cpp2IlInjected.Address(RVA = "0x7C60800", Offset = "0x7C5FA00", VA = "0x187C60800")]
		public List<Component> ICGKBKFFMPA(Type EDLOHJEBKFM)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600023F")]
		[Cpp2IlInjected.Address(RVA = "0x7C60710", Offset = "0x7C5F910", VA = "0x187C60710", Slot = "4")]
		public bool Equals(ToolHierarchyCache CCOLDGJALNH, ToolHierarchyCache JCBKIOEHCDD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x7C60790", Offset = "0x7C5F990", VA = "0x187C60790", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache DBCLNEGBNLN)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200007A")]
public class DEDNOKIEACI<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000129")]
	private int PIBKMAHMMLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012A")]
	private int HCIHBGKFDCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012B")]
	private List<T> KNGFDIDKBJC;

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public int FAGABNHAKHN
	{
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x4992630", Offset = "0x4991830", VA = "0x184992630")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public T EIFAEANLFHP
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x6A18070", Offset = "0x6A17270", VA = "0x186A18070")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public T KNFLPJBJBGE
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0x6A18330", Offset = "0x6A17530", VA = "0x186A18330")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public T CHFJDIEGPPB
	{
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0x6A18290", Offset = "0x6A17490", VA = "0x186A18290")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x6A187A0", Offset = "0x6A179A0", VA = "0x186A187A0")]
	public DEDNOKIEACI(int PIBKMAHMMLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x6A184E0", Offset = "0x6A176E0", VA = "0x186A184E0")]
	public void OOLDDNFEGEK(T JIIDPCMGOEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x6A18010", Offset = "0x6A17210", VA = "0x186A18010")]
	public void FKFEALEGJFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x6A17EC0", Offset = "0x6A170C0", VA = "0x186A17EC0")]
	public void BPDEMLLPMAE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x6A17FB0", Offset = "0x6A171B0", VA = "0x186A17FB0")]
	public void DDMACJPHOOC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x6A18440", Offset = "0x6A17640", VA = "0x186A18440")]
	public void OAOOCMEIBGB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000256")]
	[Cpp2IlInjected.Address(RVA = "0x6A18450", Offset = "0x6A17650", VA = "0x186A18450")]
	public List<T> OLGEGFLCIKL()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200007B")]
public class HHBOOOHHBCL<T>
{
	[Cpp2IlInjected.Token(Token = "0x200007C")]
	private struct GPFKDBNCFNK
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000130")]
		public int AFKEOEFICMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000131")]
		public T ABLHJAOAOGP;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012C")]
	private readonly Dictionary<object, GPFKDBNCFNK> IEEHHNMCCEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012D")]
	private readonly EqualityComparer<T> DPAKLGFGBLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400012E")]
	private T MMAPFOMGHGF;

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public virtual T MBGCKICODPB
	{
		[Cpp2IlInjected.Token(Token = "0x6000257")]
		[Cpp2IlInjected.Address(RVA = "0xD34F00", Offset = "0xD34100", VA = "0x180D34F00", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000258")]
		[Cpp2IlInjected.Address(RVA = "0x4B789D0", Offset = "0x4B77BD0", VA = "0x184B789D0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public bool IIHHFONPMMJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000259")]
		[Cpp2IlInjected.Address(RVA = "0x4B78910", Offset = "0x4B77B10", VA = "0x184B78910")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700007A")]
	public object BHDHELEPCKO
	{
		[Cpp2IlInjected.Token(Token = "0x600025A")]
		[Cpp2IlInjected.Address(RVA = "0x9F2480", Offset = "0x9F1680", VA = "0x1809F2480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600025B")]
		[Cpp2IlInjected.Address(RVA = "0x9FA760", Offset = "0x9F9960", VA = "0x1809FA760")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600025C")]
	[Cpp2IlInjected.Address(RVA = "0x4B77930", Offset = "0x4B76B30", VA = "0x184B77930")]
	public bool DHOBLHFMEFC(T MLCDCHNOCFI, object PPOILDCNBFL, int NNIDLNKAMEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025D")]
	[Cpp2IlInjected.Address(RVA = "0x4B77ED0", Offset = "0x4B770D0", VA = "0x184B77ED0")]
	public bool EJDGOKPPHLI(object PPOILDCNBFL)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025E")]
	[Cpp2IlInjected.Address(RVA = "0x4B785E0", Offset = "0x4B777E0", VA = "0x184B785E0")]
	public bool FLFGMEICIOC(object PPOILDCNBFL, [Out] T MLCDCHNOCFI)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600025F")]
	[Cpp2IlInjected.Address(RVA = "0x4B77F90", Offset = "0x4B77190", VA = "0x184B77F90")]
	public void FKFEALEGJFP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000260")]
	[Cpp2IlInjected.Address(RVA = "0x4B74780", Offset = "0x4B73980", VA = "0x184B74780")]
	private bool BGEKCDDPAHJ()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000261")]
	[Cpp2IlInjected.Address(RVA = "0x4B78A10", Offset = "0x4B77C10", VA = "0x184B78A10")]
	public HHBOOOHHBCL()
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
