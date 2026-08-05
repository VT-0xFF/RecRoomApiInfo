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
		[Cpp2IlInjected.Address(RVA = "0x86CBD0", Offset = "0x86B3D0", VA = "0x18086CBD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x68298A0", Offset = "0x68280A0", VA = "0x1868298A0")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x86D840", Offset = "0x86C040", VA = "0x18086D840")]
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
		[Cpp2IlInjected.Address(RVA = "0x86D880", Offset = "0x86C080", VA = "0x18086D880")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class MMAAOAPHMJN : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x1483A10", Offset = "0x1482210", VA = "0x181483A10")]
	public MMAAOAPHMJN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HashableScriptableObject : ScriptableObject, AGNKDDANICP, KLLEFOEOKEJ, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x844F20", Offset = "0x843720", VA = "0x180844F20", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x84A260", Offset = "0x848A60", VA = "0x18084A260", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x844F30", Offset = "0x843730", VA = "0x180844F30", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8E2600", Offset = "0x8E0E00", VA = "0x1808E2600", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash MOKMMDBCGBN);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8B1970", Offset = "0x8B0170", VA = "0x1808B1970")]
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
		[Cpp2IlInjected.Address(RVA = "0x682B110", Offset = "0x6829910", VA = "0x18682B110")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x682B0D0", Offset = "0x68298D0", VA = "0x18682B0D0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x682B150", Offset = "0x6829950", VA = "0x18682B150")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x682B300", Offset = "0x6829B00", VA = "0x18682B300")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x682B270", Offset = "0x6829A70", VA = "0x18682B270")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8B1960", Offset = "0x8B0160", VA = "0x1808B1960")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8B1920", Offset = "0x8B0120", VA = "0x1808B1920")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x682B090", Offset = "0x6829890", VA = "0x18682B090")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x682B1E0", Offset = "0x68299E0", VA = "0x18682B1E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x682AB00", Offset = "0x6829300", VA = "0x18682AB00")]
	public void CopyBounds(SavedExtents OGFCKBADKBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x682AFE0", Offset = "0x68297E0", VA = "0x18682AFE0")]
	public void SetLocalSpaceBounds(Bounds CEPBAOFAMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xB550D0", Offset = "0xB538D0", VA = "0x180B550D0")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x682AFD0", Offset = "0x68297D0", VA = "0x18682AFD0")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x682AB30", Offset = "0x6829330", VA = "0x18682AB30")]
	private void DHEKAEOFINI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x682ADB0", Offset = "0x68295B0", VA = "0x18682ADB0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x682A4C0", Offset = "0x6828CC0", VA = "0x18682A4C0")]
	public static void CalculateLocalBoundsFor(GameObject DLBGNHFNDNP, [Out] Bounds CEPBAOFAMLB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x682ACF0", Offset = "0x68294F0", VA = "0x18682ACF0")]
	private static void NDGNDPHECNH(Bounds ICPBHPBDLLK, Color FFEGACHBGBH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x682B000", Offset = "0x6829800", VA = "0x18682B000")]
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
		[Cpp2IlInjected.Address(RVA = "0x8421A0", Offset = "0x8409A0", VA = "0x1808421A0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x84CEA0", Offset = "0x84B6A0", VA = "0x18084CEA0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xF8C930", Offset = "0xF8B130", VA = "0x180F8C930")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x48661F0", Offset = "0x48649F0", VA = "0x1848661F0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "4")]
	public virtual void EDDFKNIGDMN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
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
	[MMAAOAPHMJN]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4865D20", Offset = "0x4864520", VA = "0x184865D20", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x48643D0", Offset = "0x4862BD0", VA = "0x1848643D0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x48660E0", Offset = "0x48648E0", VA = "0x1848660E0")]
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
	private sealed class IILHGADLOCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public IILHGADLOCO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x3D90680", Offset = "0x3D8EE80", VA = "0x183D90680")]
		internal int INKDKBILOEB(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[MMAAOAPHMJN]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x377EB10", Offset = "0x377D310", VA = "0x18377EB10", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x377EB70", Offset = "0x377D370", VA = "0x18377EB70", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x377E9E0", Offset = "0x377D1E0", VA = "0x18377E9E0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey JOEHGGMHBAA]
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x377EAA0", Offset = "0x377D2A0", VA = "0x18377EAA0", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x377E880", Offset = "0x377D080", VA = "0x18377E880", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x377E520", Offset = "0x377CD20", VA = "0x18377E520", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x377D8E0", Offset = "0x377C0E0", VA = "0x18377D8E0", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x377D7A0", Offset = "0x377BFA0", VA = "0x18377D7A0", Slot = "14")]
	protected virtual string BCHJBAGDDMI(TKeyVal LDIAAJCGIFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x377D7D0", Offset = "0x377BFD0", VA = "0x18377D7D0", Slot = "4")]
	public bool ContainsKey(TKey JOEHGGMHBAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x377E6F0", Offset = "0x377CEF0", VA = "0x18377E6F0", Slot = "5")]
	public bool TryGetValue(TKey JOEHGGMHBAA, [Out] TVal IPHHABIKCHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x377D830", Offset = "0x377C030", VA = "0x18377D830", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x377D830", Offset = "0x377C030", VA = "0x18377D830", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x377E750", Offset = "0x377CF50", VA = "0x18377E750")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class AKPAEANEGPO<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private class FAAGDGLKIGC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public float PHLODIIEKHN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public T JDDKPJKLOJP;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public FAAGDGLKIGC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class LFEJFMAMJOE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public LFEJFMAMJOE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x4144A10", Offset = "0x4143210", VA = "0x184144A10")]
		internal bool GMMBOBDFJMP(FAAGDGLKIGC sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly float OMEDPAHADEC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly float FDMEBKGOODN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private List<FAAGDGLKIGC> DPFBGPEMLPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private KNEFICJFKBO<FAAGDGLKIGC> EIHENGBPMHB;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int NGDGANAMOPN
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x3C4D480", Offset = "0x3C4BC80", VA = "0x183C4D480")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x3C4D560", Offset = "0x3C4BD60", VA = "0x183C4D560")]
	public AKPAEANEGPO(float MPPHAMAFAHB, float AFFPMHPPACP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x3C4CA90", Offset = "0x3C4B290", VA = "0x183C4CA90")]
	public bool EOLBAINDPKE(float KJAPNCDOIOK, T IPHHABIKCHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x3C4CD40", Offset = "0x3C4B540", VA = "0x183C4CD40")]
	public IEnumerable<T> KHMMOGJDCPG(float KJAPNCDOIOK, [Optional] float? NCKLFKCGGOB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x3C4CC80", Offset = "0x3C4B480", VA = "0x183C4CC80")]
	public void GLOOIBDLHCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x3C4C6F0", Offset = "0x3C4AEF0", VA = "0x183C4C6F0")]
	private void BPIMKNGBFKJ(float KJAPNCDOIOK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class KDEKPOOKHBL<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct FKEEBJGLOAC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public T JDDKPJKLOJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public float GDDPMDEKDPG;
	}

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private static float PJPNKJEDGKC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private List<T> GIIANNHDBKP;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private const int LHNPBEBKHDO = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private FKEEBJGLOAC[] JAOFFCELONG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private int IJMCADKINKJ;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float CNKDJIEEAMF
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x962F10", Offset = "0x961710", VA = "0x180962F10")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x981D50", Offset = "0x980550", VA = "0x180981D50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x40851D0", Offset = "0x40839D0", VA = "0x1840851D0")]
	public KDEKPOOKHBL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x4085210", Offset = "0x4083A10", VA = "0x184085210")]
	public KDEKPOOKHBL(int GGKCGCGFHKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x40846E0", Offset = "0x4082EE0", VA = "0x1840846E0")]
	public void CNLMKNIMMKA(float KJAPNCDOIOK, T IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x4084870", Offset = "0x4083070", VA = "0x184084870")]
	public void GLOOIBDLHCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x40840A0", Offset = "0x40828A0", VA = "0x1840840A0")]
	public bool BHIHGHMBKGJ(float AINMCCGACCK, float NOHMAHIJEGB, [Out] T IPHHABIKCHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x4084C80", Offset = "0x4083480", VA = "0x184084C80")]
	public bool HFLGPMMNNFB(float AINMCCGACCK, float NOHMAHIJEGB, [Out] T IPHHABIKCHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x4084E50", Offset = "0x4083650", VA = "0x184084E50")]
	public void PGBKGPACGOP(float AINMCCGACCK, float NOHMAHIJEGB, List<T> PAJEBKJPIBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x4084840", Offset = "0x4083040", VA = "0x184084840")]
	private int EPCBOIANJBN(int ONLAKOHJFFE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x40847F0", Offset = "0x4082FF0", VA = "0x1840847F0")]
	private void DDJACKCEDBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T HICAHFKEGBH();

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T HIIKKDBGJAB(T IPHHABIKCHD, float AFCJJMLHKMJ);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T BPKBHINCJIP(T JOMKMIJJPCA, T DFLDBCDDIFI);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T FLEGGAABPHD(T JOMKMIJJPCA, T DFLDBCDDIFI);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class ACAAMAFAMAF : KDEKPOOKHBL<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x852D10", Offset = "0x851510", VA = "0x180852D10", Slot = "4")]
	protected override Vector3 HICAHFKEGBH()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6826CE0", Offset = "0x68254E0", VA = "0x186826CE0", Slot = "5")]
	protected override Vector3 HIIKKDBGJAB(Vector3 IPHHABIKCHD, float AFCJJMLHKMJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6826C10", Offset = "0x6825410", VA = "0x186826C10", Slot = "6")]
	protected override Vector3 BPKBHINCJIP(Vector3 JOMKMIJJPCA, Vector3 DFLDBCDDIFI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x6826C60", Offset = "0x6825460", VA = "0x186826C60", Slot = "7")]
	protected override Vector3 FLEGGAABPHD(Vector3 JOMKMIJJPCA, Vector3 DFLDBCDDIFI)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6826D20", Offset = "0x6825520", VA = "0x186826D20")]
	public ACAAMAFAMAF()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class NNBEFLGFCOE
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2BE8EB0", Offset = "0x2BE76B0", VA = "0x182BE8EB0")]
	public static DALEBAFJKFJ<T1, T2> DLNFHNOLCMJ<T1, T2>(T1 PIDAGCGPFEP, T2 HCNOBCPEHLH)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2BE8F50", Offset = "0x2BE7750", VA = "0x182BE8F50")]
	public static MIIMCAJEBJG<T1, T2, T3> DLNFHNOLCMJ<T1, T2, T3>(T1 PIDAGCGPFEP, T2 HCNOBCPEHLH, T3 INMCJMICEAD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x43F2EF0", Offset = "0x43F16F0", VA = "0x1843F2EF0")]
	internal static int MLBFAAFALID(int BNNPLLJDCGO, int KJEMHNEMDKA)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5C344A0", Offset = "0x5C32CA0", VA = "0x185C344A0")]
	internal static int MLBFAAFALID(int BNNPLLJDCGO, int KJEMHNEMDKA, int AOGNEEILOHD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class DALEBAFJKFJ<T1, T2> : IComparable<DALEBAFJKFJ<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly T1 FODHJBNKDGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly T2 CAPIGDPADPC;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x56DAB30", Offset = "0x56D9330", VA = "0x1856DAB30")]
	public DALEBAFJKFJ(T1 PIDAGCGPFEP, T2 HCNOBCPEHLH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x56D8D80", Offset = "0x56D7580", VA = "0x1856D8D80", Slot = "4")]
	public int CompareTo(DALEBAFJKFJ<T1, T2> OGFCKBADKBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x56D92E0", Offset = "0x56D7AE0", VA = "0x1856D92E0", Slot = "0")]
	public override bool Equals(object OGFCKBADKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x56D9D30", Offset = "0x56D8530", VA = "0x1856D9D30", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x56DA440", Offset = "0x56D8C40", VA = "0x1856DA440", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class MIIMCAJEBJG<T1, T2, T3> : IComparable<MIIMCAJEBJG<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly T1 FODHJBNKDGF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly T2 CAPIGDPADPC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly T3 MAAIBNNGGLF;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x436D2D0", Offset = "0x436BAD0", VA = "0x18436D2D0")]
	public MIIMCAJEBJG(T1 PIDAGCGPFEP, T2 HCNOBCPEHLH, T3 INMCJMICEAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x436CAC0", Offset = "0x436B2C0", VA = "0x18436CAC0", Slot = "4")]
	public int CompareTo(MIIMCAJEBJG<T1, T2, T3> OGFCKBADKBE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x436CD20", Offset = "0x436B520", VA = "0x18436CD20", Slot = "0")]
	public override bool Equals(object OGFCKBADKBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x436CF60", Offset = "0x436B760", VA = "0x18436CF60", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x436D110", Offset = "0x436B910", VA = "0x18436D110", Slot = "3")]
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
	public T JDDKPJKLOJP
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x228C850", Offset = "0x228B050", VA = "0x18228C850")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x228C560", Offset = "0x228AD60", VA = "0x18228C560")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public float DCIDLHNEJDB
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8B18C0", Offset = "0x8B00C0", VA = "0x1808B18C0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4A993F0", Offset = "0x4A97BF0", VA = "0x184A993F0")]
	public T OMDHMALFIBF(float AFCJJMLHKMJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x4A99140", Offset = "0x4A97940", VA = "0x184A99140")]
	public T AJPPJJKEFAO(float AFCJJMLHKMJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T IBDIPFHDKON(T JOMKMIJJPCA, T DFLDBCDDIFI, float AFCJJMLHKMJ);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6826FB0", Offset = "0x68257B0", VA = "0x186826FB0", Slot = "4")]
	protected override float IBDIPFHDKON(float JOMKMIJJPCA, float DFLDBCDDIFI, float AFCJJMLHKMJ)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6826FF0", Offset = "0x68257F0", VA = "0x186826FF0")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0xE34680", Offset = "0xE32E80", VA = "0x180E34680", Slot = "4")]
	protected override Vector3 IBDIPFHDKON(Vector3 JOMKMIJJPCA, Vector3 DFLDBCDDIFI, float AFCJJMLHKMJ)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x682BF30", Offset = "0x682A730", VA = "0x18682BF30")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6826EB0", Offset = "0x68256B0", VA = "0x186826EB0", Slot = "4")]
	protected override Color IBDIPFHDKON(Color JOMKMIJJPCA, Color DFLDBCDDIFI, float AFCJJMLHKMJ)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6826F70", Offset = "0x6825770", VA = "0x186826F70")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class CJCODFDNFIJ : HCKDJLOKFBI<string>
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x6826E60", Offset = "0x6825660", VA = "0x186826E60")]
	public CJCODFDNFIJ(int MELGOCPNHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6826DF0", Offset = "0x68255F0", VA = "0x186826DF0", Slot = "6")]
	protected override uint ECMHHMNAJJL(uint MOKMMDBCGBN, string IPHHABIKCHD)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class ANECMELINJD : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly IDisposable DCEJKJKKEPJ;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	public ANECMELINJD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct BBOKIADHGPA<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> JHAFGMEDLLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private int FCELNPGABDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int PLPIMBNJNIM;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x43F3C00", Offset = "0x43F2400", VA = "0x1843F3C00")]
	private BBOKIADHGPA(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> PKJDMAJEBJK, int ODBBDDGKILL, int EFNPOFGBGLO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x4D1A580", Offset = "0x4D18D80", VA = "0x184D1A580")]
	public static BBOKIADHGPA<T> OJFFIHPLODM()
	{
		return default(BBOKIADHGPA<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x4D18F60", Offset = "0x4D17760", VA = "0x184D18F60")]
	public (int, int, Task<T>) DJMGNIGCGJJ(int HKJHDCJABMO, [Optional] CancellationToken ODNHMAMKFFP, double JCJNKLHAGJK = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x4D181F0", Offset = "0x4D169F0", VA = "0x184D181F0")]
	public void DANHPMPEKIL(int HKJHDCJABMO, int EFNPOFGBGLO, [In] T KKBKNCNBBJP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class OLKKLNJPHIH
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x68299A0", Offset = "0x68281A0", VA = "0x1868299A0")]
	public static BBOKIADHGPA<KNDENJDHONE> OJFFIHPLODM()
	{
		return default(BBOKIADHGPA<KNDENJDHONE>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6829920", Offset = "0x6828120", VA = "0x186829920")]
	public static void DANHPMPEKIL([In] this BBOKIADHGPA<KNDENJDHONE> EGJINJKGIAK, int HKJHDCJABMO, int EFNPOFGBGLO)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[DefaultMember("Item")]
public class EHLMNKGOHPH<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly Dictionary<TKey, TVal> KJBMGGKPLCO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly Dictionary<TVal, TKey> NGEJGAAPBAM;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int HJCFDKBBGAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x34C1040", Offset = "0x34BF840", VA = "0x1834C1040", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool HJHOCNCEBAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x88B320", Offset = "0x889B20", VA = "0x18088B320", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public ICollection<TKey> BPAFOBLIEGK
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x373E220", Offset = "0x373CA20", VA = "0x18373E220", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public ICollection<TVal> OLMEJCHIBMG
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x3750F60", Offset = "0x374F760", VA = "0x183750F60", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public TVal EDCCAJFFILN
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x3750E90", Offset = "0x374F690", VA = "0x183750E90", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x3750FC0", Offset = "0x374F7C0", VA = "0x183750FC0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public TKey EDCCAJFFILN
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x374FFA0", Offset = "0x374E7A0", VA = "0x18374FFA0")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x374FD40", Offset = "0x374E540", VA = "0x18374FD40", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3750C10", Offset = "0x374F410", VA = "0x183750C10", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x374FC20", Offset = "0x374E420", VA = "0x18374FC20", Slot = "9")]
	public void Add(TKey JOEHGGMHBAA, TVal IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x374FBD0", Offset = "0x374E3D0", VA = "0x18374FBD0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> ECMCDEIDGLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x374FDF0", Offset = "0x374E5F0", VA = "0x18374FDF0", Slot = "8")]
	public bool ContainsKey(TKey JOEHGGMHBAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x374FED0", Offset = "0x374E6D0", VA = "0x18374FED0", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> ECMCDEIDGLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x3750B90", Offset = "0x374F390", VA = "0x183750B90", Slot = "10")]
	public bool Remove(TKey JOEHGGMHBAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3750B50", Offset = "0x374F350", VA = "0x183750B50", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> ECMCDEIDGLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x3750D00", Offset = "0x374F500", VA = "0x183750D00", Slot = "11")]
	public bool TryGetValue(TKey JOEHGGMHBAA, [Out] TVal IPHHABIKCHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3750120", Offset = "0x374E920", VA = "0x183750120", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x374FF10", Offset = "0x374E710", VA = "0x18374FF10", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] JAOFFCELONG, int FAIGDKFEIOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3750060", Offset = "0x374E860", VA = "0x183750060")]
	public bool GFIHGBPIMCF(TVal JOEHGGMHBAA, [Out] TKey IPHHABIKCHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3750890", Offset = "0x374F090", VA = "0x183750890")]
	private void NLFMGIJIPGF(TKey JOEHGGMHBAA, TVal FCGMGAOCKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x37506B0", Offset = "0x374EEB0", VA = "0x1837506B0")]
	private void MBOKMMDJEAA(TKey JOEHGGMHBAA, TVal FCGMGAOCKCN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3750260", Offset = "0x374EA60", VA = "0x183750260")]
	private bool LIMCENFGDCJ(TKey JOEHGGMHBAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3750D60", Offset = "0x374F560", VA = "0x183750D60")]
	public EHLMNKGOHPH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[DefaultMember("Item")]
public class AOCIDIBCGCM<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private AOCIDIBCGCM<T> buffer;

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
			[Cpp2IlInjected.Address(RVA = "0x37D0480", Offset = "0x37CEC80", VA = "0x1837D0480", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x37DADD0", Offset = "0x37D95D0", VA = "0x1837DADD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x37DBA20", Offset = "0x37DA220", VA = "0x1837DBA20")]
		public Enumerator(AOCIDIBCGCM<T> PAJEBKJPIBK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x37D8960", Offset = "0x37D7160", VA = "0x1837D8960", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x37D9350", Offset = "0x37D7B50", VA = "0x1837D9350", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x37D9180", Offset = "0x37D7980", VA = "0x1837D9180")]
		private void OLLDDDJHAED()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private T[] MALBEOPJKJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private int JDPLFEPKJAC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private int ELFBGAEOPBB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private int MBDJOBPGDCG;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int HJCFDKBBGAL
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x3C58660", Offset = "0x3C56E60", VA = "0x183C58660")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public T EDCCAJFFILN
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x3C57AE0", Offset = "0x3C562E0", VA = "0x183C57AE0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x3C58730", Offset = "0x3C56F30", VA = "0x183C58730")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x3C58D20", Offset = "0x3C57520", VA = "0x183C58D20")]
	public AOCIDIBCGCM(int MELGOCPNHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x3C575E0", Offset = "0x3C55DE0", VA = "0x183C575E0")]
	public void CNLMKNIMMKA(T AFCJJMLHKMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x3C58640", Offset = "0x3C56E40", VA = "0x183C58640")]
	public void GLOOIBDLHCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x3C58560", Offset = "0x3C56D60", VA = "0x183C58560")]
	public void FENJEBJDGPJ(int POAAACAIHKJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x3C580B0", Offset = "0x3C568B0", VA = "0x183C580B0")]
	public void ELKHOEHJIOF(T[] JAOFFCELONG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x3C56AC0", Offset = "0x3C552C0", VA = "0x183C56AC0")]
	public Enumerator ALKLFOKMKDP()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x3C58C60", Offset = "0x3C57460", VA = "0x183C58C60", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x3C58C60", Offset = "0x3C57460", VA = "0x183C58C60", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x3C56C80", Offset = "0x3C55480", VA = "0x183C56C80")]
	private int BMINILHEECN(int JBDLDJOINOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x3C58530", Offset = "0x3C56D30", VA = "0x183C58530")]
	private int FBKFHKGPLGI(int JBDLDJOINOF)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class INJFFGCPKLN<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public delegate Task<TResult> ILJLCJPCPCF(TRequest LOGLBHMJLPF, CancellationToken ODNHMAMKFFP);

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public enum NHCNINKEMOP
	{
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class OPDMNGDHEDI
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private const float OJNKIOLAJIP = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TimeSpan CAFDNAFKHLL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int IAHHOEDPEHL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public NHCNINKEMOP JKIDDFBBDON;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public static readonly OPDMNGDHEDI BMGLDIIFJMA;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float GFAMOFMBAKB
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x45A45B0", Offset = "0x45A2DB0", VA = "0x1845A45B0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public TimeSpan FJDNDMMALIG
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x846800", Offset = "0x845000", VA = "0x180846800")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x45A4700", Offset = "0x45A2F00", VA = "0x1845A4700")]
		public OPDMNGDHEDI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	private readonly struct PHNKGLLCNAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly TRequest LOGLBHMJLPF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly CancellationToken ODNHMAMKFFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly TaskCompletionSource<TResult> KCOFFNCLPOP;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x4658B10", Offset = "0x4657310", VA = "0x184658B10")]
		public PHNKGLLCNAO(TRequest LOGLBHMJLPF, TaskCompletionSource<TResult> KCOFFNCLPOP, CancellationToken ODNHMAMKFFP)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct GLOBCGPBLNJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public INJFFGCPKLN<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x3BE89D0", Offset = "0x3BE71D0", VA = "0x183BE89D0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x3BE8EA0", Offset = "0x3BE76A0", VA = "0x183BE8EA0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct OIELOBKJPDG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public INJFFGCPKLN<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private PHNKGLLCNAO <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x457E760", Offset = "0x457CF60", VA = "0x18457E760", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x457EE20", Offset = "0x457D620", VA = "0x18457EE20", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly CancellationTokenSource DGNMIGGCIKM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly List<PHNKGLLCNAO> GDCOCDOAKPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly OPDMNGDHEDI CHEKHOOAOBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly ILJLCJPCPCF ADNJMMAMBCM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Task CPCENNMIJDJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private int PCJKKGOPCOA;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x3DBC1A0", Offset = "0x3DBA9A0", VA = "0x183DBC1A0")]
	public INJFFGCPKLN(ILJLCJPCPCF ADNJMMAMBCM, [Optional] OPDMNGDHEDI CHEKHOOAOBM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x3DBAB40", Offset = "0x3DB9340", VA = "0x183DBAB40")]
	public Task<TResult> LMJCGFHANNP(TRequest LOGLBHMJLPF, CancellationToken ODNHMAMKFFP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x3DBA320", Offset = "0x3DB8B20", VA = "0x183DBA320")]
	private void DOGCCPJIFHF(PHNKGLLCNAO PPEFBEELGOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x3DBA790", Offset = "0x3DB8F90", VA = "0x183DBA790")]
	[AsyncStateMachine(typeof(INJFFGCPKLN<, >.GLOBCGPBLNJ))]
	private Task ENGJHKCGIBH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x3DBB8A0", Offset = "0x3DBA0A0", VA = "0x183DBB8A0")]
	private PHNKGLLCNAO PIOKGPFEOJI()
	{
		return default(PHNKGLLCNAO);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x3DBA860", Offset = "0x3DB9060", VA = "0x183DBA860")]
	[AsyncStateMachine(typeof(INJFFGCPKLN<, >.OIELOBKJPDG))]
	private Task FDBNOJOLNIG()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x3DBB250", Offset = "0x3DB9A50", VA = "0x183DBB250")]
	private void NFPFAKHLEEH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x3DBA5B0", Offset = "0x3DB8DB0", VA = "0x183DBA5B0", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DefaultMember("Item")]
public class CJDPLJIMKLJ<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly List<T> MAKDKEMHGGE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private HashSet<T> HOBLHJMEDBL;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int HJCFDKBBGAL
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x34C1040", Offset = "0x34BF840", VA = "0x1834C1040", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool HJHOCNCEBAA
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x88B320", Offset = "0x889B20", VA = "0x18088B320", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public T EDCCAJFFILN
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x24EAA80", Offset = "0x24E9280", VA = "0x1824EAA80", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x4F8D040", Offset = "0x4F8B840", VA = "0x184F8D040", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x3B46CE0", Offset = "0x3B454E0", VA = "0x183B46CE0", Slot = "11")]
	public void Add(T ECMCDEIDGLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x4F8C440", Offset = "0x4F8AC40", VA = "0x184F8C440")]
	public bool BOGMKCJDBDF(T ECMCDEIDGLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x4F8CC20", Offset = "0x4F8B420", VA = "0x184F8CC20", Slot = "15")]
	public bool Remove(T ECMCDEIDGLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x4663090", Offset = "0x4661890", VA = "0x184663090", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3B30C70", Offset = "0x3B2F470", VA = "0x183B30C70", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x4F8C550", Offset = "0x4F8AD50", VA = "0x184F8C550", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x4F8C600", Offset = "0x4F8AE00", VA = "0x184F8C600", Slot = "13")]
	public bool Contains(T ECMCDEIDGLC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x4F8C660", Offset = "0x4F8AE60", VA = "0x184F8C660", Slot = "14")]
	public void CopyTo(T[] JAOFFCELONG, int FAIGDKFEIOE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x40EA150", Offset = "0x40E8950", VA = "0x1840EA150", Slot = "6")]
	public int IndexOf(T ECMCDEIDGLC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x4F8C6C0", Offset = "0x4F8AEC0", VA = "0x184F8C6C0", Slot = "7")]
	public void Insert(int JBDLDJOINOF, T ECMCDEIDGLC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x4F8CAC0", Offset = "0x4F8B2C0", VA = "0x184F8CAC0", Slot = "8")]
	public void RemoveAt(int JBDLDJOINOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x4F8CDC0", Offset = "0x4F8B5C0", VA = "0x184F8CDC0")]
	public CJDPLJIMKLJ()
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
			[Cpp2IlInjected.Address(RVA = "0x210F210", Offset = "0x210DA10", VA = "0x18210F210")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x682B6A0", Offset = "0x6829EA0", VA = "0x18682B6A0")]
		public SerializedGuid([In] Guid PGOHCHKMLGH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x682B430", Offset = "0x6829C30", VA = "0x18682B430")]
		public static SerializedGuid EGBMCJLMIPA()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x682B390", Offset = "0x6829B90", VA = "0x18682B390")]
		public static SerializedGuid BNFODKPAKEO()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x682B590", Offset = "0x6829D90", VA = "0x18682B590")]
		public bool HACFJPDLFNP()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x682B670", Offset = "0x6829E70", VA = "0x18682B670", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x682B5F0", Offset = "0x6829DF0", VA = "0x18682B5F0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x682B4B0", Offset = "0x6829CB0", VA = "0x18682B4B0", Slot = "7")]
		public bool Equals(SerializedGuid OGFCKBADKBE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x682B4F0", Offset = "0x6829CF0", VA = "0x18682B4F0", Slot = "0")]
		public override bool Equals(object GHDJADLHPAA)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x682B580", Offset = "0x6829D80", VA = "0x18682B580", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x682B400", Offset = "0x6829C00", VA = "0x18682B400", Slot = "6")]
		public int CompareTo(SerializedGuid OGFCKBADKBE)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class PPANJIIMBHB : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly Type FLOBLBOACKO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly string GAHLFFMCGKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly bool DEONJMLJGOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly bool NGAPPFKFIEN;

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x6829F20", Offset = "0x6828720", VA = "0x186829F20")]
	public PPANJIIMBHB(Type DCOAPKKKPBN, string HEJBINHNMOF, bool BPIHGJDDICJ = false, bool PNAIHEEOCMH = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class NLBODGALKPJ<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public readonly struct CPCLIEOLOEG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public readonly long KAECOPJCFOA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public readonly long CAAKAPMJCJI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public readonly int NFOKLHDHKOF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly int KFCPDBNLPFK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public readonly bool OOCKFHKNLPK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly string EIKIFKAHNNB;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x508CA10", Offset = "0x508B210", VA = "0x18508CA10")]
		public CPCLIEOLOEG(long KAECOPJCFOA, int NFOKLHDHKOF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x508C9E0", Offset = "0x508B1E0", VA = "0x18508C9E0")]
		public CPCLIEOLOEG(long KAECOPJCFOA, long CAAKAPMJCJI, int NFOKLHDHKOF, int KFCPDBNLPFK, bool OOCKFHKNLPK, string EIKIFKAHNNB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x508C990", Offset = "0x508B190", VA = "0x18508C990")]
		public int OHODGMCHEOJ()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x508C8D0", Offset = "0x508B0D0", VA = "0x18508C8D0")]
		public int JIPACADOCKC(int GNADIMENHME)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x508C870", Offset = "0x508B070", VA = "0x18508C870")]
		public double CNJELOLMEGF()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x508C8F0", Offset = "0x508B0F0", VA = "0x18508C8F0")]
		public CPCLIEOLOEG MPANMOACKNP(long CAAKAPMJCJI, int KFCPDBNLPFK)
		{
			return default(CPCLIEOLOEG);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class EICLBAKIMEK : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private struct OPPBIDLLOMI<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public EICLBAKIMEK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public Func<EICLBAKIMEK, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			private EICLBAKIMEK <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x45A4AB0", Offset = "0x45A32B0", VA = "0x1845A4AB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x3B92100", Offset = "0x3B90900", VA = "0x183B92100", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public readonly TKey PJOIFALPHGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly NLBODGALKPJ<TKey> JPMGDEGBMJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public readonly MMJHHDEPGMK LPJFGGMIIEB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private List<EICLBAKIMEK> OMFCGLGDPME;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public string JMDPNBBEAKN
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x3755EE0", Offset = "0x37546E0", VA = "0x183755EE0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public IEnumerable<EICLBAKIMEK> EHFDECEFDOD
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x37561A0", Offset = "0x37549A0", VA = "0x1837561A0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public CPCLIEOLOEG OIKNMJJGFNK
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x3755EC0", Offset = "0x37546C0", VA = "0x183755EC0")]
			[CompilerGenerated]
			get
			{
				return default(CPCLIEOLOEG);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x37561E0", Offset = "0x37549E0", VA = "0x1837561E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x37563D0", Offset = "0x3754BD0", VA = "0x1837563D0")]
		internal EICLBAKIMEK(NLBODGALKPJ<TKey> JPMGDEGBMJK, TKey JOEHGGMHBAA, MMJHHDEPGMK LPJFGGMIIEB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x3756210", Offset = "0x3754A10", VA = "0x183756210")]
		public EICLBAKIMEK NLKGDOHPGJD(TKey JOEHGGMHBAA, [Optional] MMJHHDEPGMK? NHPBJMKMJLN)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x28DD9C0", Offset = "0x28DC1C0", VA = "0x1828DD9C0")]
		[AsyncStateMachine(typeof(OPPBIDLLOMI<>))]
		public Task<T> NMPGCFMDBKK<T>(TKey JOEHGGMHBAA, Func<EICLBAKIMEK, Task<T>> CPDLACEKNJL)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x3755F40", Offset = "0x3754740", VA = "0x183755F40", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class JLDAHNHCGIL : IEnumerable<(TKey, List<TKey>, CPCLIEOLOEG)>, IEnumerable, IEnumerator<(TKey, List<TKey>, CPCLIEOLOEG)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private (TKey key, List<TKey> path, CPCLIEOLOEG timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public NLBODGALKPJ<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private IEnumerator<(TKey key, List<TKey> path, CPCLIEOLOEG timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		private (TKey, List<TKey>, CPCLIEOLOEG) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x210E8E0", Offset = "0x210D0E0", VA = "0x18210E8E0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, CPCLIEOLOEG));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x3FAAA20", Offset = "0x3FA9220", VA = "0x183FAAA20", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x210E9D0", Offset = "0x210D1D0", VA = "0x18210E9D0")]
		[DebuggerHidden]
		public JLDAHNHCGIL(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x39F0F30", Offset = "0x39EF730", VA = "0x1839F0F30", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x3FAA4F0", Offset = "0x3FA8CF0", VA = "0x183FAA4F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x3FAA8A0", Offset = "0x3FA90A0", VA = "0x183FAA8A0")]
		private void OLLLOCKLGDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x3FAA9D0", Offset = "0x3FA91D0", VA = "0x183FAA9D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x3FAA8F0", Offset = "0x3FA90F0", VA = "0x183FAA8F0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, CPCLIEOLOEG)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x39F94F0", Offset = "0x39F7CF0", VA = "0x1839F94F0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class OAAOPDBLIHC : IEnumerable<(TKey, List<TKey>, CPCLIEOLOEG)>, IEnumerable, IEnumerator<(TKey, List<TKey>, CPCLIEOLOEG)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private (TKey key, List<TKey> path, CPCLIEOLOEG timerEntry) <>2__current;

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
		private EICLBAKIMEK timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public EICLBAKIMEK <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public NLBODGALKPJ<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private IEnumerator<EICLBAKIMEK> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private IEnumerator<(TKey key, List<TKey> path, CPCLIEOLOEG timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private (TKey, List<TKey>, CPCLIEOLOEG) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x210E8E0", Offset = "0x210D0E0", VA = "0x18210E8E0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, CPCLIEOLOEG));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x4533BA0", Offset = "0x45323A0", VA = "0x184533BA0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x210E9D0", Offset = "0x210D1D0", VA = "0x18210E9D0")]
		[DebuggerHidden]
		public OAAOPDBLIHC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x4533C00", Offset = "0x4532400", VA = "0x184533C00", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x45331C0", Offset = "0x45319C0", VA = "0x1845331C0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x45339B0", Offset = "0x45321B0", VA = "0x1845339B0")]
		private void OLLLOCKLGDG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x4533160", Offset = "0x4531960", VA = "0x184533160")]
		private void LBICBBCOFMC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x4533B50", Offset = "0x4532350", VA = "0x184533B50", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x4533A10", Offset = "0x4532210", VA = "0x184533A10", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, CPCLIEOLOEG)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x4533B10", Offset = "0x4532310", VA = "0x184533B10", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly Action<TKey, CPCLIEOLOEG, MMJHHDEPGMK> EKJCMCNCFIG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly Action<TKey, CPCLIEOLOEG, MMJHHDEPGMK> BOOMOHNLEKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly Action<NLBODGALKPJ<TKey>, MMJHHDEPGMK> AFOMHLJOHAG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly MMJHHDEPGMK LPJFGGMIIEB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly EICLBAKIMEK PNEKPHAHLDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private bool NIKEPOPPBPF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int IFCIAPPKNIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly Stopwatch GJIFNLLPGAL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly int LDJGJFGFDPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private string EPDBKBCKIGM;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public EICLBAKIMEK NGLOHBHFJKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x847480", Offset = "0x845C80", VA = "0x180847480")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	[NotNull]
	public string JMDPNBBEAKN
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x844010", Offset = "0x842810", VA = "0x180844010")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x4460EC0", Offset = "0x445F6C0", VA = "0x184460EC0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x4461220", Offset = "0x445FA20", VA = "0x184461220")]
	public NLBODGALKPJ(TKey LEHFBBPLMGJ, MMJHHDEPGMK LPJFGGMIIEB, [Optional] int? NFOKLHDHKOF, [Optional][CanBeNull] Stopwatch GJIFNLLPGAL, [Optional] Action<TKey, CPCLIEOLOEG, MMJHHDEPGMK> EKJCMCNCFIG, [Optional] Action<TKey, CPCLIEOLOEG, MMJHHDEPGMK> BOOMOHNLEKG, [Optional] Action<NLBODGALKPJ<TKey>, MMJHHDEPGMK> AFOMHLJOHAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x4460FA0", Offset = "0x445F7A0", VA = "0x184460FA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x4461170", Offset = "0x445F970", VA = "0x184461170")]
	[IteratorStateMachine(typeof(NLBODGALKPJ<>.JLDAHNHCGIL))]
	public IEnumerable<(TKey, List<TKey>, CPCLIEOLOEG)> HIJPCLMNCDH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x4461080", Offset = "0x445F880", VA = "0x184461080")]
	[IteratorStateMachine(typeof(NLBODGALKPJ<>.OAAOPDBLIHC))]
	private IEnumerable<(TKey, List<TKey>, CPCLIEOLOEG)> HIJPCLMNCDH(List<TKey> FKOPBOJEAII, EICLBAKIMEK NONGNJHHIEO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x4460F20", Offset = "0x445F720", VA = "0x184460F20")]
	private (long, int) CEGNPAABHNC()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public abstract class CHLFKFGKGGD<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut BBJJLCNLNGO(NLBODGALKPJ<TKey> JPMGDEGBMJK);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	protected CHLFKFGKGGD()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public abstract class INFMPCJDDBO<TKey> : CHLFKFGKGGD<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public delegate string OKODLECEAHK(TKey JOEHGGMHBAA);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x3DBA2A0", Offset = "0x3DB8AA0", VA = "0x183DBA2A0")]
	private static string DGEIELPIMBH(TKey JOEHGGMHBAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x3DBA050", Offset = "0x3DB8850", VA = "0x183DBA050", Slot = "4")]
	public override string BBJJLCNLNGO(NLBODGALKPJ<TKey> JPMGDEGBMJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x3DBA140", Offset = "0x3DB8940", VA = "0x183DBA140")]
	public string BBJJLCNLNGO(NLBODGALKPJ<TKey> JPMGDEGBMJK, [NotNull] OKODLECEAHK IGFKGFNFCLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string BBAFNICOIPJ(NLBODGALKPJ<TKey> JPMGDEGBMJK, [NotNull] OKODLECEAHK IGFKGFNFCLJ);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x3DBA2E0", Offset = "0x3DB8AE0", VA = "0x183DBA2E0")]
	protected INFMPCJDDBO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class EILFBKHNAPD<TKey> : CHLFKFGKGGD<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public delegate string KKHKCMMHADI(TKey JOEHGGMHBAA);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly string PJEKECOBIDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly double IECODKFBANH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly bool FOBEDLNAECD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly int DDMLFAFBOLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly ISet<string> BIMGCJOELMN;

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x37572D0", Offset = "0x3755AD0", VA = "0x1837572D0")]
	private static string DGEIELPIMBH(TKey JOEHGGMHBAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x37577D0", Offset = "0x3755FD0", VA = "0x1837577D0")]
	public EILFBKHNAPD(string PJEKECOBIDP = "F2", double IECODKFBANH = double.MaxValue, bool FOBEDLNAECD = false, int DDMLFAFBOLD = int.MaxValue, [Optional] ISet<string> BIMGCJOELMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x37571E0", Offset = "0x37559E0", VA = "0x1837571E0", Slot = "4")]
	public override Dictionary<string, string> BBJJLCNLNGO(NLBODGALKPJ<TKey> JPMGDEGBMJK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x3757310", Offset = "0x3755B10", VA = "0x183757310")]
	private bool EHFELCMMDAN(string MMEPJEHOBOE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x3756B90", Offset = "0x3755390", VA = "0x183756B90")]
	public Dictionary<string, string> BBJJLCNLNGO(NLBODGALKPJ<TKey> JPMGDEGBMJK, KKHKCMMHADI IGFKGFNFCLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x37573F0", Offset = "0x3755BF0", VA = "0x1837573F0")]
	private string ICOPLOFMDCL(StringBuilder DIOIBJIHOEB, List<TKey> IJHMKGAKHNC, KKHKCMMHADI IGFKGFNFCLJ, bool IEGKEDHGPJA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x3757670", Offset = "0x3755E70", VA = "0x183757670")]
	private static void LAJLLNOIDKE(StringBuilder EIMMDNPGGKF, string HINGDDPBDIH, bool CPNGDHEJBBM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class BGFOPLAFJAP<TKey> : INFMPCJDDBO<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct EFIGDCAOCFB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public OKODLECEAHK keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public static BGFOPLAFJAP<TKey> DCEJKJKKEPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly string[] PHDLMACNPDP;

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x4D27BF0", Offset = "0x4D263F0", VA = "0x184D27BF0")]
	private BGFOPLAFJAP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x4D26B30", Offset = "0x4D25330", VA = "0x184D26B30", Slot = "5")]
	protected override string BBAFNICOIPJ(NLBODGALKPJ<TKey> JPMGDEGBMJK, OKODLECEAHK IGFKGFNFCLJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x4D27990", Offset = "0x4D26190", VA = "0x184D27990")]
	[CompilerGenerated]
	internal static string EIDHBANFIDN(string MLLEKBHNNAA, TKey JOEHGGMHBAA, EFIGDCAOCFB P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class HDKMKPMOEMI : NLBODGALKPJ<string>
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class MDDNBDDGLKF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public Action<HDKMKPMOEMI, MMJHHDEPGMK> callback;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public MDDNBDDGLKF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x6829810", Offset = "0x6828010", VA = "0x186829810")]
		internal void PBAIJPABAIH(NLBODGALKPJ<string> timer, MMJHHDEPGMK log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x68272B0", Offset = "0x6825AB0", VA = "0x1868272B0")]
	public HDKMKPMOEMI(MMJHHDEPGMK LPJFGGMIIEB, [Optional] string LOOAEBPKNEA, [Optional] int? NFOKLHDHKOF, [Optional] Stopwatch GJIFNLLPGAL, [Optional] Action<string, CPCLIEOLOEG, MMJHHDEPGMK> EKJCMCNCFIG, [Optional] Action<string, CPCLIEOLOEG, MMJHHDEPGMK> BOOMOHNLEKG, [Optional] Action<HDKMKPMOEMI, MMJHHDEPGMK> AFOMHLJOHAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x68271F0", Offset = "0x68259F0", VA = "0x1868271F0")]
	private static Action<NLBODGALKPJ<string>, MMJHHDEPGMK> NLLNKDLBIEN(Action<HDKMKPMOEMI, MMJHHDEPGMK> GLJPAFELCNE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public abstract class GKOPGKCADIO
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	private class ABMNNAKFOBP : GKOPGKCADIO
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public static GKOPGKCADIO DCEJKJKKEPJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x6826AD0", Offset = "0x68252D0", VA = "0x186826AD0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override float OFLFOFEDBEJ
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x9595E0", Offset = "0x957DE0", VA = "0x1809595E0", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x6826BC0", Offset = "0x68253C0", VA = "0x186826BC0")]
		public ABMNNAKFOBP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static GKOPGKCADIO JEJMNCMALEL;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static GKOPGKCADIO BMGLDIIFJMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x6827030", Offset = "0x6825830", VA = "0x186827030")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public abstract float OFLFOFEDBEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
	protected GKOPGKCADIO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface FAIOIOPAKIG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	bool MNHFNMLEMKK
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface MJMNDKPKIPJ<T> : FAIOIOPAKIG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	[NotNull]
	Task<T> DNDGGIIEMCI
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	[NotNull]
	MOJHALOLCAP<T> NLEDEKFNGOD
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class JHECCCMEBHE
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	private sealed class POAENNGMDLG<T> : ENCFPIMNNAD<T?> where T : class
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override Task<T?> DNDGGIIEMCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000132")]
			[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override MOJHALOLCAP<T?> NLEDEKFNGOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000133")]
			[Cpp2IlInjected.Address(RVA = "0x84A260", Offset = "0x848A60", VA = "0x18084A260", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(RVA = "0x4683100", Offset = "0x4681900", VA = "0x184683100")]
		public POAENNGMDLG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000135")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "10")]
		protected override void HFGHGPHLEFG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private sealed class NHBDMGPAGKO<T> : ENCFPIMNNAD<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override Task<T> DNDGGIIEMCI
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override MOJHALOLCAP<T> NLEDEKFNGOD
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x84A260", Offset = "0x848A60", VA = "0x18084A260", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x442C900", Offset = "0x442B100", VA = "0x18442C900")]
		public NHBDMGPAGKO(Exception JLOICJBFAKG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "10")]
		protected override void HFGHGPHLEFG()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	private sealed class FMCDKLGLFFP<T> : ENCFPIMNNAD<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000043")]
		[CompilerGenerated]
		private struct IPDJBPONKMM : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009C")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009D")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009E")]
			public Task<MJMNDKPKIPJ<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400009F")]
			private TaskAwaiter<MJMNDKPKIPJ<T>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			private TaskAwaiter<T> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000140")]
			[Cpp2IlInjected.Address(RVA = "0x3DC1320", Offset = "0x3DBFB20", VA = "0x183DC1320", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x3DC1840", Offset = "0x3DC0040", VA = "0x183DC1840", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000044")]
		[CompilerGenerated]
		private struct KNIDMKJNNMO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			public Task<MJMNDKPKIPJ<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			private TaskAwaiter<MJMNDKPKIPJ<T>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x40B8B00", Offset = "0x40B7300", VA = "0x1840B8B00", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000143")]
			[Cpp2IlInjected.Address(RVA = "0x40B8D40", Offset = "0x40B7540", VA = "0x1840B8D40", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000099")]
		private readonly Task<MJMNDKPKIPJ<T>> DCMJCDCDPPM;

		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override Task<T> DNDGGIIEMCI
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x84A260", Offset = "0x848A60", VA = "0x18084A260", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override MOJHALOLCAP<T> NLEDEKFNGOD
		{
			[Cpp2IlInjected.Token(Token = "0x600013B")]
			[Cpp2IlInjected.Address(RVA = "0x8472F0", Offset = "0x845AF0", VA = "0x1808472F0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x3B03B40", Offset = "0x3B02340", VA = "0x183B03B40")]
		public FMCDKLGLFFP(Task<MJMNDKPKIPJ<T>> GECIOHOBBCH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(RVA = "0x3B03930", Offset = "0x3B02130", VA = "0x183B03930", Slot = "10")]
		protected override void HFGHGPHLEFG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013E")]
		[Cpp2IlInjected.Address(RVA = "0x3B039C0", Offset = "0x3B021C0", VA = "0x183B039C0")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(FMCDKLGLFFP<>.IPDJBPONKMM))]
		internal static Task<T> IFDEDLAEKEN(Task<MJMNDKPKIPJ<T>> GECIOHOBBCH)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x3B03840", Offset = "0x3B02040", VA = "0x183B03840")]
		[AsyncStateMachine(typeof(FMCDKLGLFFP<>.KNIDMKJNNMO))]
		[CompilerGenerated]
		internal static Task CMLEKBFDPJE(Task<MJMNDKPKIPJ<T>> GECIOHOBBCH)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x2AE7730", Offset = "0x2AE5F30", VA = "0x182AE7730")]
	public static MJMNDKPKIPJ<T> IJLPDDOKCDN<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x28A7A00", Offset = "0x28A6200", VA = "0x1828A7A00")]
	public static MJMNDKPKIPJ<T> CBOCNOKGAOD<T>(Exception JLOICJBFAKG) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x28A7A00", Offset = "0x28A6200", VA = "0x1828A7A00")]
	public static MJMNDKPKIPJ<T> LENAMJILHDN<T>(Task<MJMNDKPKIPJ<T>> GECIOHOBBCH) where T : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000045")]
public abstract class ENCFPIMNNAD<T> : MJMNDKPKIPJ<T>, FAIOIOPAKIG, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000A5")]
	private static readonly string PNPDFAEEJPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A6")]
	private readonly GCDKEKMPKHA BOPBDFOOBID;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A7")]
	private bool NIKEPOPPBPF;

	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	public bool MNHFNMLEMKK
	{
		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0xB358C0", Offset = "0xB340C0", VA = "0x180B358C0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	public abstract Task<T> DNDGGIIEMCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	public abstract MOJHALOLCAP<T> NLEDEKFNGOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000147")]
	[Cpp2IlInjected.Address(RVA = "0x376BBA0", Offset = "0x376A3A0", VA = "0x18376BBA0")]
	public ENCFPIMNNAD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000148")]
	[Cpp2IlInjected.Address(RVA = "0x376B900", Offset = "0x376A100", VA = "0x18376B900", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000149")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void HFGHGPHLEFG();
}
[Cpp2IlInjected.Token(Token = "0x2000046")]
public abstract class IEPJLDNFPDO<TTask, T> : ENCFPIMNNAD<T> where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x2000047")]
	[CompilerGenerated]
	private sealed class KDKOOBOHKIM
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
			public KDKOOBOHKIM <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000153")]
			[Cpp2IlInjected.Address(RVA = "0x34AF840", Offset = "0x34AE040", VA = "0x1834AF840", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000154")]
			[Cpp2IlInjected.Address(RVA = "0x34AFB10", Offset = "0x34AE310", VA = "0x1834AFB10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AB")]
		public IEPJLDNFPDO<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000AC")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x6000151")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public KDKOOBOHKIM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x4085ED0", Offset = "0x40846D0", VA = "0x184085ED0")]
		[AsyncStateMachine(typeof(IEPJLDNFPDO<, >.KDKOOBOHKIM.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> LOJACABLKKO(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000A8")]
	private readonly Task<T> GECIOHOBBCH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000AA")]
	protected readonly CancellationTokenSource NPNHNCBGLOD;

	[Cpp2IlInjected.Token(Token = "0x17000041")]
	public override Task<T> DNDGGIIEMCI
	{
		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public override MOJHALOLCAP<T> NLEDEKFNGOD
	{
		[Cpp2IlInjected.Token(Token = "0x600014C")]
		[Cpp2IlInjected.Address(RVA = "0x84A260", Offset = "0x848A60", VA = "0x18084A260", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600014D")]
	[Cpp2IlInjected.Address(RVA = "0x3D86CE0", Offset = "0x3D854E0", VA = "0x183D86CE0")]
	protected IEPJLDNFPDO(TTask GECIOHOBBCH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014E")]
	[Cpp2IlInjected.Address(RVA = "0x3D86C90", Offset = "0x3D85490", VA = "0x183D86C90", Slot = "10")]
	protected override void HFGHGPHLEFG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600014F")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract T OENINFANCFD(TTask JNLJBGECHEJ);

	[Cpp2IlInjected.Token(Token = "0x6000150")]
	[Cpp2IlInjected.Address(Slot = "12")]
	protected abstract void LDFLPKEEIGJ();
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public class EAAADFJBMLO<T> : ENCFPIMNNAD<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private readonly HHIKLOPOAIH<Task<T>> DFHPGEGPJCN;

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public override Task<T> DNDGGIIEMCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x373D830", Offset = "0x373C030", VA = "0x18373D830", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public override MOJHALOLCAP<T> NLEDEKFNGOD
	{
		[Cpp2IlInjected.Token(Token = "0x6000156")]
		[Cpp2IlInjected.Address(RVA = "0x84A260", Offset = "0x848A60", VA = "0x18084A260", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(RVA = "0x373D890", Offset = "0x373C090", VA = "0x18373D890")]
	public EAAADFJBMLO(HHIKLOPOAIH<Task<T>> FPJFPCDFPPC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000158")]
	[Cpp2IlInjected.Address(RVA = "0x373D810", Offset = "0x373C010", VA = "0x18373D810", Slot = "10")]
	protected override void HFGHGPHLEFG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public static class OPBNCDMKOKI
{
	[Cpp2IlInjected.Token(Token = "0x6000159")]
	[Cpp2IlInjected.Address(RVA = "0x6829D90", Offset = "0x6828590", VA = "0x186829D90")]
	[NotNull]
	public static byte[] FDGDPMMEDAO(this AGNKDDANICP IEIFLOADOEJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015A")]
	[Cpp2IlInjected.Address(RVA = "0x6829D20", Offset = "0x6828520", VA = "0x186829D20")]
	[NotNull]
	public static byte[] FDGDPMMEDAO(this AGNKDDANICP IEIFLOADOEJ, HashAlgorithmName KDDELOHKOIP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x68299F0", Offset = "0x68281F0", VA = "0x1868299F0")]
	public static bool AIBJJIBBEFL([CanBeNull] this AGNKDDANICP IEIFLOADOEJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x6829B80", Offset = "0x6828380", VA = "0x186829B80")]
	public static bool AIBJJIBBEFL([CanBeNull] this AGNKDDANICP IEIFLOADOEJ, [Out] string EBFMCGAMIGF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(RVA = "0x6829E00", Offset = "0x6828600", VA = "0x186829E00")]
	private static bool NAGNOHHJGFE([NotNull] AGNKDDANICP IEIFLOADOEJ, [Out][CanBeNull] byte[] KAJBDCCBCFA, [Out][CanBeNull] byte[] DPCJHOHNIJE)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004B")]
public static class LEAELLIOMKB
{
	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(RVA = "0x68295D0", Offset = "0x6827DD0", VA = "0x1868295D0")]
	[NotNull]
	public static byte[] FDGDPMMEDAO(this KLLEFOEOKEJ MEEFINBMAKH, HashAlgorithmName KDDELOHKOIP, byte[] BAPIDBAIFOJ)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004C")]
public interface KLLEFOEOKEJ
{
	[Cpp2IlInjected.Token(Token = "0x600015F")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash MOKMMDBCGBN);
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public interface AGNKDDANICP : KLLEFOEOKEJ
{
	[Cpp2IlInjected.Token(Token = "0x17000045")]
	[CanBeNull]
	byte[] EMDJDBFEPLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	[CanBeNull]
	byte[] JDHBKJFHGKH
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class IALJIOGEAHE
{
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private static readonly ArrayPool<byte> EHIIKIJCPCF;

	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private static bool HEHIPKMPHPP;

	[Cpp2IlInjected.Token(Token = "0x6000162")]
	[Cpp2IlInjected.Address(RVA = "0x2AC3920", Offset = "0x2AC2120", VA = "0x182AC3920")]
	public static void LJKAAHLNJCE<T>(this IncrementalHash FDMPCAKJHKH, [CanBeNull] T KFMACDKHBNH) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000163")]
	[Cpp2IlInjected.Address(RVA = "0x2AC4010", Offset = "0x2AC2810", VA = "0x182AC4010")]
	public static void PJPJBGKKNEH<T>(this IncrementalHash FDMPCAKJHKH, [CanBeNull] T MEEFINBMAKH) where T : KLLEFOEOKEJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x2AC3400", Offset = "0x2AC1C00", VA = "0x182AC3400")]
	public static void LJGECMLDOHI<T>(this IncrementalHash FDMPCAKJHKH, [CanBeNull] IList<T> KEFKKBHGAGO) where T : KLLEFOEOKEJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x68277C0", Offset = "0x6825FC0", VA = "0x1868277C0")]
	private static bool LAKILNNNOHM([CanBeNull] KLLEFOEOKEJ MEEFINBMAKH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x6827700", Offset = "0x6825F00", VA = "0x186827700")]
	public static void HPJGGLDDIFD(this IncrementalHash MOKMMDBCGBN, [CanBeNull] string PGOODFFKNJN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x6827850", Offset = "0x6826050", VA = "0x186827850")]
	public static void LCNBLCHPOEC(this IncrementalHash MOKMMDBCGBN, long GAOCDMMGIFF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x6827DC0", Offset = "0x68265C0", VA = "0x186827DC0")]
	public static void PDANMBFMCEF(this IncrementalHash MOKMMDBCGBN, int EKHBBBBMHEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x6827BF0", Offset = "0x68263F0", VA = "0x186827BF0")]
	public static void ODGKGABPBDD(this IncrementalHash MOKMMDBCGBN, short MBONEBPPFFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x68275F0", Offset = "0x6825DF0", VA = "0x1868275F0")]
	public static void EGDECBEMPIA(this IncrementalHash MOKMMDBCGBN, byte MMONHKLBGIO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x6827A80", Offset = "0x6826280", VA = "0x186827A80")]
	public static void OBJIDDCAGCI(this IncrementalHash MOKMMDBCGBN, bool NKGFELNKMFO, bool LIBJJHOEICG = false, bool EBINFKPAPEJ = false, bool GBOKNAPJDLH = false, bool LEBDEACMFMK = false, bool FGNDGCLJBPC = false, bool DKBOFDDFHEB = false, bool LDODGHEFDGA = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x2AC39E0", Offset = "0x2AC21E0", VA = "0x182AC39E0")]
	public static void MNABGDIGNMH<T>(this IncrementalHash MOKMMDBCGBN, T GNHCOHKDBJO) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(RVA = "0x6827760", Offset = "0x6825F60", VA = "0x186827760")]
	public static void JBBPAKINKHL(this IncrementalHash MOKMMDBCGBN, float AJPHHAAJMOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016E")]
	[Cpp2IlInjected.Address(RVA = "0x6827400", Offset = "0x6825C00", VA = "0x186827400")]
	public static void ADIHIGLBFAI(this IncrementalHash MOKMMDBCGBN, ulong LHCKCJDGFDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016F")]
	[Cpp2IlInjected.Address(RVA = "0x6827590", Offset = "0x6825D90", VA = "0x186827590")]
	public static void DNBBJEIDGOD(this IncrementalHash MOKMMDBCGBN, uint DAMFAIEONMG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6827A20", Offset = "0x6826220", VA = "0x186827A20")]
	public static void MGNBDFEBEKD(this IncrementalHash MOKMMDBCGBN, ushort IDNFPHOAGBP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x6827460", Offset = "0x6825C60", VA = "0x186827460")]
	public static void CFGGDOFAPGG(this IncrementalHash MOKMMDBCGBN, Vector3 JKJFKEEIOJA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public class GLBAAMFIHBM : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x6827190", Offset = "0x6825990", VA = "0x186827190")]
	public GLBAAMFIHBM(string CLBGCJICGJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public abstract class CKGADFMLCLJ<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000051")]
	internal class BBEJKNLIEJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BD")]
		public TNode EGJINJKGIAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BE")]
		public TNode GGJNHHDMGON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000BF")]
		public IOGOJKOHJMH ECKNMNLLOJH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C0")]
		public List<IOGOJKOHJMH> NKFCCPPHGHN;

		[Cpp2IlInjected.Token(Token = "0x6000188")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public BBEJKNLIEJL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000052")]
	internal struct IOGOJKOHJMH : IComparable<IOGOJKOHJMH>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C1")]
		public int PNLPPPCKGCA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C2")]
		public TClaimant KKHOFGLIBGL;

		[Cpp2IlInjected.Token(Token = "0x6000189")]
		[Cpp2IlInjected.Address(RVA = "0xD63BE0", Offset = "0xD623E0", VA = "0x180D63BE0")]
		public IOGOJKOHJMH(int PNLPPPCKGCA, TClaimant KKHOFGLIBGL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018A")]
		[Cpp2IlInjected.Address(RVA = "0x3DBE3B0", Offset = "0x3DBCBB0", VA = "0x183DBE3B0")]
		public bool PIHHJCKLEEO([In] IOGOJKOHJMH OGFCKBADKBE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018B")]
		[Cpp2IlInjected.Address(RVA = "0x3DBE3A0", Offset = "0x3DBCBA0", VA = "0x183DBE3A0")]
		public bool JABCHDOBJEA([In] IOGOJKOHJMH OGFCKBADKBE)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600018C")]
		[Cpp2IlInjected.Address(RVA = "0x3DBE390", Offset = "0x3DBCB90", VA = "0x183DBE390", Slot = "4")]
		public int CompareTo(IOGOJKOHJMH OGFCKBADKBE)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600018D")]
		[Cpp2IlInjected.Address(RVA = "0x3DBE410", Offset = "0x3DBCC10", VA = "0x183DBE410", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000053")]
	public enum JEBOIKHCFGA
	{
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x2000054")]
	[CompilerGenerated]
	private sealed class MOEJIDDDMGG : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
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
		public CKGADFMLCLJ<TClaimant, TNode> <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600018E")]
		[Cpp2IlInjected.Address(RVA = "0x898540", Offset = "0x896D40", VA = "0x180898540")]
		[DebuggerHidden]
		public MOEJIDDDMGG(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600018F")]
		[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000190")]
		[Cpp2IlInjected.Address(RVA = "0x43C17F0", Offset = "0x43BFFF0", VA = "0x1843C17F0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000192")]
		[Cpp2IlInjected.Address(RVA = "0x43C19D0", Offset = "0x43C01D0", VA = "0x1843C19D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000194")]
		[Cpp2IlInjected.Address(RVA = "0x43C18D0", Offset = "0x43C00D0", VA = "0x1843C18D0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000195")]
		[Cpp2IlInjected.Address(RVA = "0x376DA30", Offset = "0x376C230", VA = "0x18376DA30", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000B6")]
	private static readonly KNEFICJFKBO<BBEJKNLIEJL> BJGJKJPNIDG;

	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	private static readonly KNEFICJFKBO<List<IOGOJKOHJMH>> INMPMAJCFFD;

	[Cpp2IlInjected.Token(Token = "0x40000B8")]
	private static int GGODKMKCGPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B9")]
	internal readonly Dictionary<TClaimant, TNode> KHOGDCFNHOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BA")]
	internal readonly Dictionary<TNode, BBEJKNLIEJL> JFJPBDBNPIK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BB")]
	private JEBOIKHCFGA MCJDOPPFHLD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BC")]
	private bool HOBFAPAFPHM;

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode BPHPODIDNCF(TNode DDLCNKGIKEK);

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void LIGEEKKAKGL(TNode DDLCNKGIKEK, TClaimant KFBBFAKOEAE, TClaimant KHDFOEMHPHM);

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x4F8F6D0", Offset = "0x4F8DED0", VA = "0x184F8F6D0")]
	public CKGADFMLCLJ(JEBOIKHCFGA MCJDOPPFHLD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x4F8E670", Offset = "0x4F8CE70", VA = "0x184F8E670")]
	public void JIBOAPEBHBN(TNode DDLCNKGIKEK, TNode OGAPKPCGEHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x4F8E8D0", Offset = "0x4F8D0D0", VA = "0x184F8E8D0")]
	public void KIFOPIPGCKN(TClaimant KKHOFGLIBGL, TNode EMFJFLGBEOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x4F8DAE0", Offset = "0x4F8C2E0", VA = "0x184F8DAE0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x4F8DD00", Offset = "0x4F8C500", VA = "0x184F8DD00")]
	private void FBANMFGKCBM(TClaimant KKHOFGLIBGL, TNode AACBAMIOKGJ, TNode EMFJFLGBEOA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x4F8EA70", Offset = "0x4F8D270", VA = "0x184F8EA70")]
	private int LGFHCAPCMHH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x4F8EAE0", Offset = "0x4F8D2E0", VA = "0x184F8EAE0")]
	private void LMFCHHGAFGH(TClaimant KKHOFGLIBGL, TNode BHNNBEAEHCJ, TNode FOFBODJKPLN, int FCCEJKDMIOC = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x4F8F0A0", Offset = "0x4F8D8A0", VA = "0x184F8F0A0")]
	private void OEACAJIFFNC(IOGOJKOHJMH COPGMMMFIOO, BBEJKNLIEJL JDHFDNPAKDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x4F8E1A0", Offset = "0x4F8C9A0", VA = "0x184F8E1A0")]
	private void IEGLHINLENB(TClaimant KKHOFGLIBGL, TNode BHNNBEAEHCJ, TNode FOFBODJKPLN, int FCCEJKDMIOC = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x4F8EF60", Offset = "0x4F8D760", VA = "0x184F8EF60")]
	private void NCNDNGIGEIK(IOGOJKOHJMH COPGMMMFIOO, TNode DDLCNKGIKEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x4F8DDD0", Offset = "0x4F8C5D0", VA = "0x184F8DDD0")]
	private void FDBFOILKCKB(IOGOJKOHJMH COPGMMMFIOO, BBEJKNLIEJL JDHFDNPAKDL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x4F8DF40", Offset = "0x4F8C740", VA = "0x184F8DF40")]
	private void FIJFFOGKFBN(BBEJKNLIEJL JDHFDNPAKDL, bool KDKPPGMJOLO = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x4F8F180", Offset = "0x4F8D980", VA = "0x184F8F180")]
	private void OKMEHGKHMNE(BBEJKNLIEJL JDHFDNPAKDL, TNode OGAPKPCGEHM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x4F8E0A0", Offset = "0x4F8C8A0", VA = "0x184F8E0A0")]
	[IteratorStateMachine(typeof(CKGADFMLCLJ<, >.MOEJIDDDMGG))]
	private IEnumerable<TNode> HMCPGCNOBPI(TNode BHNNBEAEHCJ, TNode FOFBODJKPLN, bool BBHAKDHCONL = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x4F8EE40", Offset = "0x4F8D640", VA = "0x184F8EE40")]
	private BBEJKNLIEJL MGNGIBDACCO(TNode DDLCNKGIKEK, TNode GGJNHHDMGON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x4F8E740", Offset = "0x4F8CF40", VA = "0x184F8E740")]
	private BBEJKNLIEJL JJNAPAJCIDC(TNode DDLCNKGIKEK, TNode GGJNHHDMGON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x4F8E4A0", Offset = "0x4F8CCA0", VA = "0x184F8E4A0")]
	private void IPPOOMKNMBO(BBEJKNLIEJL JDHFDNPAKDL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class HCKDJLOKFBI<T> : IEnumerable<HCKDJLOKFBI<T>.BKNHJGLMFCH>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000056")]
	public struct BKNHJGLMFCH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public T IPHHABIKCHD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public int JBDLDJOINOF;
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public class MCHHBDNIEPO : IEnumerator<BKNHJGLMFCH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		private HCKDJLOKFBI<T> DJIDBBHKILF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		private int JBDLDJOINOF;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001A6")]
			[Cpp2IlInjected.Address(RVA = "0x377F5E0", Offset = "0x377DDE0", VA = "0x18377F5E0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		public BKNHJGLMFCH APOKPICBEBA
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x433F3B0", Offset = "0x433DBB0", VA = "0x18433F3B0", Slot = "4")]
			get
			{
				return default(BKNHJGLMFCH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x433F370", Offset = "0x433DB70", VA = "0x18433F370")]
		public MCHHBDNIEPO(HCKDJLOKFBI<T> DJIDBBHKILF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0x433F2F0", Offset = "0x433DAF0", VA = "0x18433F2F0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x37D5530", Offset = "0x37D3D30", VA = "0x1837D5530", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x8FB4F0", Offset = "0x8F9CF0", VA = "0x1808FB4F0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	private struct IJIKOEGPGHA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		public bool FNJCMNHKEFP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public T IPHHABIKCHD;
	}

	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private const int FPBLDNJFGIP = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private readonly Dictionary<T, int> HMPGLHFFGLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private IJIKOEGPGHA[] DAKDFECKPBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private int JDEEBHNMPKD;

	[Cpp2IlInjected.Token(Token = "0x17000049")]
	public int AKNLEBMMCLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x882440", Offset = "0x880C40", VA = "0x180882440")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0x881B20", Offset = "0x880320", VA = "0x180881B20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	public int HJCFDKBBGAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x34C1040", Offset = "0x34BF840", VA = "0x1834C1040")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x3C7F9B0", Offset = "0x3C7E1B0", VA = "0x183C7F9B0")]
	public HCKDJLOKFBI(int MELGOCPNHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x3C7FEF0", Offset = "0x3C7E6F0", VA = "0x183C7FEF0")]
	public HCKDJLOKFBI(BKNHJGLMFCH[] MLJOCMGNADG, bool CMDFDLJLKME)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x3C7EA80", Offset = "0x3C7D280", VA = "0x183C7EA80")]
	public int AGKIBJOECGP()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x3C7F300", Offset = "0x3C7DB00", VA = "0x183C7F300")]
	private int LBKDDJNNPOO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600019D")]
	[Cpp2IlInjected.Address(RVA = "0x3C7F210", Offset = "0x3C7DA10", VA = "0x183C7F210", Slot = "6")]
	protected virtual uint ECMHHMNAJJL(uint MOKMMDBCGBN, T IPHHABIKCHD)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x600019E")]
	[Cpp2IlInjected.Address(RVA = "0x3C7F2A0", Offset = "0x3C7DAA0", VA = "0x183C7F2A0")]
	public bool KHKEGLAOLPO(T IPHHABIKCHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600019F")]
	[Cpp2IlInjected.Address(RVA = "0x3C7F880", Offset = "0x3C7E080", VA = "0x183C7F880")]
	public int NMCNHKCBLOH(T IPHHABIKCHD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A0")]
	[Cpp2IlInjected.Address(RVA = "0x3C7F740", Offset = "0x3C7DF40", VA = "0x183C7F740")]
	public T LOHAKJGKIFE(int JBDLDJOINOF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A1")]
	[Cpp2IlInjected.Address(RVA = "0x3C7EC50", Offset = "0x3C7D450", VA = "0x183C7EC50")]
	public bool BOGMKCJDBDF(T IPHHABIKCHD, bool JEOMBLGBIIM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A2")]
	[Cpp2IlInjected.Address(RVA = "0x3C7EF70", Offset = "0x3C7D770", VA = "0x183C7EF70")]
	public bool BOGMKCJDBDF(T IPHHABIKCHD, int JBDLDJOINOF, bool JEOMBLGBIIM = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A3")]
	[Cpp2IlInjected.Address(RVA = "0x3C7EBA0", Offset = "0x3C7D3A0", VA = "0x183C7EBA0")]
	private int AJLIAHCMGNO(int JDPLFEPKJAC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001A4")]
	[Cpp2IlInjected.Address(RVA = "0x3C7F910", Offset = "0x3C7E110", VA = "0x183C7F910", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001A5")]
	[Cpp2IlInjected.Address(RVA = "0x3C7F910", Offset = "0x3C7E110", VA = "0x183C7F910", Slot = "4")]
	private IEnumerator<BKNHJGLMFCH> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class KNEFICJFKBO<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DB")]
	private readonly Stack<T> DJHGEDHADKF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DC")]
	private readonly List<T> JOAHHDNCNBF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private readonly int IKGJDAKFJOH;

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x40B7F60", Offset = "0x40B6760", VA = "0x1840B7F60")]
	public static KNEFICJFKBO<T> BKNHEMIHOEF(int MELGOCPNHFM = 0, int IKGJDAKFJOH = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x40B82D0", Offset = "0x40B6AD0", VA = "0x1840B82D0")]
	public static KNEFICJFKBO<T> LNCEGJODEEF(int MELGOCPNHFM = 0, int IKGJDAKFJOH = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x40B8AB0", Offset = "0x40B72B0", VA = "0x1840B8AB0")]
	public KNEFICJFKBO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x40B8890", Offset = "0x40B7090", VA = "0x1840B8890")]
	public KNEFICJFKBO(int MELGOCPNHFM, int IKGJDAKFJOH = int.MaxValue, bool EOJFNAMELCO = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x40B86D0", Offset = "0x40B6ED0", VA = "0x1840B86D0")]
	public T PODNPIFMDJJ()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x40B8060", Offset = "0x40B6860", VA = "0x1840B8060")]
	public void CHEAPHHCLBO(T IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x40B85D0", Offset = "0x40B6DD0", VA = "0x1840B85D0")]
	private void PHKHOPACOAB(T IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x40B7F10", Offset = "0x40B6710", VA = "0x1840B7F10")]
	private void AAHHDBOGAJD(T IPHHABIKCHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x40B8140", Offset = "0x40B6940", VA = "0x1840B8140", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x40B83D0", Offset = "0x40B6BD0", VA = "0x1840B83D0")]
	private void MOHNCNPMKBE(IEnumerable<T> AHHBLMGMEGC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public class MJCEEDLKKNP<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private Dictionary<int, T> MGOJPELCHEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private T OCMNBOBNAKH;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public virtual T PJKKOBLGKGB
	{
		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x847510", Offset = "0x845D10", VA = "0x180847510", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x844F20", Offset = "0x843720", VA = "0x180844F20", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x436E6A0", Offset = "0x436CEA0", VA = "0x18436E6A0")]
	public bool IOHFIDJCCAN(T IPHHABIKCHD, int PNLPPPCKGCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x436E960", Offset = "0x436D160", VA = "0x18436E960")]
	public bool LLIKHMBMBAE(int PNLPPPCKGCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x436E180", Offset = "0x436C980", VA = "0x18436E180")]
	public T COPIMAFAMGN(int IGEEPENOIIJ)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x436E810", Offset = "0x436D010", VA = "0x18436E810")]
	private bool JKDLCFEAHHG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x436E590", Offset = "0x436CD90", VA = "0x18436E590")]
	public bool GFIHGBPIMCF(int PNLPPPCKGCA, [Out] T IPHHABIKCHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x436EA10", Offset = "0x436D210", VA = "0x18436EA10")]
	public MJCEEDLKKNP()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class MJNOOFOMMAI<T>
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	protected struct IFFCBLBMGOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public T JDDKPJKLOJP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public int JJBEADNLDFI;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	protected readonly List<IFFCBLBMGOJ> MALBEOPJKJI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E1")]
	private T CNMMJKHOPKP;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public int HJCFDKBBGAL
	{
		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x34C1040", Offset = "0x34BF840", VA = "0x1834C1040")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x4375720", Offset = "0x4373F20", VA = "0x184375720")]
	public bool HFKAHFAOINF(T IPHHABIKCHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x4375130", Offset = "0x4373930", VA = "0x184375130")]
	public void CNLMKNIMMKA(T IPHHABIKCHD, int PNLPPPCKGCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x4375460", Offset = "0x4373C60", VA = "0x184375460")]
	public bool GALPDKBCKMP(T IPHHABIKCHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x4375670", Offset = "0x4373E70", VA = "0x184375670")]
	public void GLOOIBDLHCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x4375DB0", Offset = "0x43745B0", VA = "0x184375DB0")]
	public T PIJIDAKEMMH()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x4375C30", Offset = "0x4374430", VA = "0x184375C30")]
	protected void MJEINDEDNFK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x4375EF0", Offset = "0x43746F0", VA = "0x184375EF0")]
	public MJNOOFOMMAI()
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
		[GMBLIEHBOLK(EEKFPEEGEKF.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0x682A0C0", Offset = "0x68288C0", VA = "0x18682A0C0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0x682A390", Offset = "0x6828B90", VA = "0x18682A390")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0x682A2A0", Offset = "0x6828AA0", VA = "0x18682A2A0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000051")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60001C9")]
			[Cpp2IlInjected.Address(RVA = "0x682A010", Offset = "0x6828810", VA = "0x18682A010")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000052")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60001CA")]
			[Cpp2IlInjected.Address(RVA = "0x682A2E0", Offset = "0x6828AE0", VA = "0x18682A2E0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60001CB")]
			[Cpp2IlInjected.Address(RVA = "0x682A1F0", Offset = "0x68289F0", VA = "0x18682A1F0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x6829F90", Offset = "0x6828790", VA = "0x186829F90")]
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
		[Cpp2IlInjected.Address(RVA = "0x481FE80", Offset = "0x481E680", VA = "0x18481FE80", Slot = "4")]
		public virtual T GIHBHOILOBC()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001CE")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class JKJDDIDNHHJ : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private Dictionary<byte, KKACNIOKJAC> LJFPIEFFPKE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly KNEFICJFKBO<KKACNIOKJAC> NMFJMBGKPOL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly bool LHPCKILEECP;

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public KKACNIOKJAC KAJHBIOFONE
	{
		[Cpp2IlInjected.Token(Token = "0x60001CF")]
		[Cpp2IlInjected.Address(RVA = "0x846800", Offset = "0x845000", VA = "0x180846800")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001D0")]
		[Cpp2IlInjected.Address(RVA = "0x8467F0", Offset = "0x844FF0", VA = "0x1808467F0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public Vector2 IMKGHPINLLO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D1")]
		[Cpp2IlInjected.Address(RVA = "0xCE9A80", Offset = "0xCE8280", VA = "0x180CE9A80")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D2")]
		[Cpp2IlInjected.Address(RVA = "0xFC8530", Offset = "0xFC6D30", VA = "0x180FC8530")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	private Vector2 PCHBINGLGJH
	{
		[Cpp2IlInjected.Token(Token = "0x60001D3")]
		[Cpp2IlInjected.Address(RVA = "0x10266D0", Offset = "0x1024ED0", VA = "0x1810266D0")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public Vector2 DLDHPOACDPI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x6828450", Offset = "0x6826C50", VA = "0x186828450")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D5")]
		[Cpp2IlInjected.Address(RVA = "0x847490", Offset = "0x845C90", VA = "0x180847490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public int OCKPENEADOI
	{
		[Cpp2IlInjected.Token(Token = "0x60001D6")]
		[Cpp2IlInjected.Address(RVA = "0x84B8F0", Offset = "0x84A0F0", VA = "0x18084B8F0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001D7")]
		[Cpp2IlInjected.Address(RVA = "0x84B750", Offset = "0x849F50", VA = "0x18084B750")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x6829060", Offset = "0x6827860", VA = "0x186829060")]
	public JKJDDIDNHHJ(Bounds DMDIHGJIMJK, Vector2[] JKKOKCIGJAM, int BLKCLDAPCGI, byte JDPLFEPKJAC, float JFCBLCIJMBN = 0f, [Optional] KNEFICJFKBO<KKACNIOKJAC> NMFJMBGKPOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x6828470", Offset = "0x6826C70", VA = "0x186828470")]
	public void JCPDFDMGAFJ(Bounds DMDIHGJIMJK, Vector2[] JKKOKCIGJAM, int BLKCLDAPCGI, byte JDPLFEPKJAC, float JFCBLCIJMBN = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x6828930", Offset = "0x6827130", VA = "0x186828930")]
	public KKACNIOKJAC NAFCAOIFOGM(byte JBDLDJOINOF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x68282C0", Offset = "0x6826AC0", VA = "0x1868282C0")]
	public void CJDJODNLPBN(Vector3 GBKEBGLIOFD, float DPODFPCIEBP, float KFLAGLGEGFH, List<byte> PCIDFICLJAF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x6828910", Offset = "0x6827110", VA = "0x186828910")]
	public void KBABKPLFDGF(KKACNIOKJAC.OEBNDPJNJJA DEOHJGGPPKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x6828BC0", Offset = "0x68273C0", VA = "0x186828BC0")]
	public static int NHKFCCNHFIB(Vector2[] JKKOKCIGJAM, int BLKCLDAPCGI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x6828990", Offset = "0x6827190", VA = "0x186828990")]
	private KKACNIOKJAC NBHNJHMLNFB(byte JBDLDJOINOF, KKACNIOKJAC.NHGIFGLBDPI DPNBGCMIJDI, KKACNIOKJAC GGJNHHDMGON)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x6828CB0", Offset = "0x68274B0", VA = "0x186828CB0")]
	private void PNOFINFPAEP(KKACNIOKJAC GGJNHHDMGON, Vector2[] JKKOKCIGJAM, int GDKFOOJEBCD, int CKJLDJJGPCI, int HHFMBOPEKNF, int GJEJMHMNIKF, float JFCBLCIJMBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x68280A0", Offset = "0x68268A0", VA = "0x1868280A0")]
	private void AKCGAGBDABF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x6828390", Offset = "0x6826B90", VA = "0x186828390", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E2")]
	[Cpp2IlInjected.Address(RVA = "0x68283F0", Offset = "0x6826BF0", VA = "0x1868283F0", Slot = "1")]
	~JKJDDIDNHHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class KKACNIOKJAC
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public enum NHGIFGLBDPI
	{
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public enum OEBNDPJNJJA
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
	public byte ACEJJAKLDLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	public Vector3 HMDCNOODKPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	public Vector3 JAFNMFMLFDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	public Vector3 IGOMLAHDJOC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	public Vector3 GOJNBAHFEHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x40000F6")]
	public NHGIFGLBDPI NPMGNKEMPLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000F7")]
	public KKACNIOKJAC GFHKLHCNBBP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x40000F8")]
	public List<KKACNIOKJAC> OCMFEGKCLIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x40000F9")]
	public bool MIGDNKHGFFM;

	[Cpp2IlInjected.Token(Token = "0x60001E3")]
	[Cpp2IlInjected.Address(RVA = "0x68295B0", Offset = "0x6827DB0", VA = "0x1868295B0")]
	public KKACNIOKJAC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E4")]
	[Cpp2IlInjected.Address(RVA = "0x6829410", Offset = "0x6827C10", VA = "0x186829410")]
	public void FMNJLOIFMNG(KKACNIOKJAC CKKNFOBALJL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E5")]
	[Cpp2IlInjected.Address(RVA = "0x843530", Offset = "0x841D30", VA = "0x180843530")]
	public void KBABKPLFDGF(int DNLAAAANFML, OEBNDPJNJJA DEOHJGGPPKI, int KPGPHGOAFPC = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x6829120", Offset = "0x6827920", VA = "0x186829120")]
	public void CJDJODNLPBN(List<byte> PCIDFICLJAF, Vector3 GBKEBGLIOFD, float DPODFPCIEBP, float KFLAGLGEGFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x6829550", Offset = "0x6827D50", VA = "0x186829550")]
	public bool MIJDLAJFJFC(Vector3 BGLKCAHKMON)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x6829580", Offset = "0x6827D80", VA = "0x186829580")]
	public bool OBIKBEOINLM(Vector3 BGLKCAHKMON, float HFFPINALFOD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x6829380", Offset = "0x6827B80", VA = "0x186829380")]
	public void DIHNAABPOCM()
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
		public struct MMICMOLMPFL<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000107")]
			private readonly List<Component> MAKDKEMHGGE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000108")]
			private readonly bool HMOKADIDIGG;

			[Cpp2IlInjected.Token(Token = "0x60001F6")]
			[Cpp2IlInjected.Address(RVA = "0x3D91D90", Offset = "0x3D90590", VA = "0x183D91D90")]
			public MMICMOLMPFL(List<Component> MAKDKEMHGGE, bool HMOKADIDIGG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001F7")]
			[Cpp2IlInjected.Address(RVA = "0x43B2F50", Offset = "0x43B1750", VA = "0x1843B2F50")]
			public JNDABDKNKBF<T> ALKLFOKMKDP()
			{
				return default(JNDABDKNKBF<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x43B2FC0", Offset = "0x43B17C0", VA = "0x1843B2FC0", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x60001F9")]
			[Cpp2IlInjected.Address(RVA = "0x43B2FC0", Offset = "0x43B17C0", VA = "0x1843B2FC0", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000065")]
		public struct JNDABDKNKBF<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000109")]
			private readonly List<Component> MAKDKEMHGGE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010A")]
			private readonly bool HMOKADIDIGG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400010B")]
			private int JBDLDJOINOF;

			[Cpp2IlInjected.Token(Token = "0x1700005A")]
			public T APOKPICBEBA
			{
				[Cpp2IlInjected.Token(Token = "0x60001FB")]
				[Cpp2IlInjected.Address(RVA = "0x3FAECF0", Offset = "0x3FAD4F0", VA = "0x183FAECF0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005B")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x60001FC")]
				[Cpp2IlInjected.Address(RVA = "0x3FAEC80", Offset = "0x3FAD480", VA = "0x183FAEC80", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x60001FA")]
			[Cpp2IlInjected.Address(RVA = "0x3FAECC0", Offset = "0x3FAD4C0", VA = "0x183FAECC0")]
			public JNDABDKNKBF(List<Component> MAKDKEMHGGE, bool HMOKADIDIGG)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FD")]
			[Cpp2IlInjected.Address(RVA = "0x3FAEBC0", Offset = "0x3FAD3C0", VA = "0x183FAEBC0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60001FE")]
			[Cpp2IlInjected.Address(RVA = "0x3FAEBD0", Offset = "0x3FAD3D0", VA = "0x183FAEBD0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x60001FF")]
			[Cpp2IlInjected.Address(RVA = "0x37C74D0", Offset = "0x37C5CD0", VA = "0x1837C74D0", Slot = "8")]
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

		[Cpp2IlInjected.Token(Token = "0x17000059")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x60001EA")]
			[Cpp2IlInjected.Address(RVA = "0x682BDB0", Offset = "0x682A5B0", VA = "0x18682BDB0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x8467E0", Offset = "0x844FE0", VA = "0x1808467E0")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x682B770", Offset = "0x6829F70", VA = "0x18682B770")]
		private void DIHNAABPOCM(GameObject IGGPONJBFJL, bool AIDFLNGPPBP = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x682B6E0", Offset = "0x6829EE0", VA = "0x18682B6E0")]
		public static void DIHNAABPOCM(GameObject IGGPONJBFJL, ToolHierarchyCache FLJDKJIJGIC)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EE")]
		[Cpp2IlInjected.Address(RVA = "0x682B6D0", Offset = "0x6829ED0", VA = "0x18682B6D0")]
		public void APFCBHEHGOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x2DBA6F0", Offset = "0x2DB8EF0", VA = "0x182DBA6F0")]
		public void LBICLGFGHBC<T>(Action<T> BMOCGPMNBAF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x2DBA650", Offset = "0x2DB8E50", VA = "0x182DBA650")]
		public T ELAOLMALLGA<T>(bool HMOKADIDIGG = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0x2DBA590", Offset = "0x2DB8D90", VA = "0x182DBA590")]
		public MMICMOLMPFL<T> AOOICKDOBCP<T>(bool HMOKADIDIGG = false) where T : class
		{
			return default(MMICMOLMPFL<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x682B9D0", Offset = "0x682A1D0", VA = "0x18682B9D0")]
		public List<Component> LDJOLLHLKND(Type HKAKMPIMEOA)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x682B8E0", Offset = "0x682A0E0", VA = "0x18682B8E0", Slot = "4")]
		public bool Equals(ToolHierarchyCache PNGIKMLKECD, ToolHierarchyCache MADKMAGKKBH)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001F4")]
		[Cpp2IlInjected.Address(RVA = "0x682B960", Offset = "0x682A160", VA = "0x18682B960", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache GHDJADLHPAA)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class FBGBGBCFFNE<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private int MELGOCPNHFM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private int HCCCIDBNKBL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	private List<T> KOMHLEPKPKC;

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public int HJCFDKBBGAL
	{
		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x373D830", Offset = "0x373C030", VA = "0x18373D830")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005D")]
	public T AOCMNLBJEJA
	{
		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x3ACBEB0", Offset = "0x3ACA6B0", VA = "0x183ACBEB0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005E")]
	public T MBPELKBHPGF
	{
		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x3ACBCD0", Offset = "0x3ACA4D0", VA = "0x183ACBCD0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005F")]
	public T JIOINOBCMKI
	{
		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x3ACC0D0", Offset = "0x3ACA8D0", VA = "0x183ACC0D0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000204")]
	[Cpp2IlInjected.Address(RVA = "0x3ACC1C0", Offset = "0x3ACA9C0", VA = "0x183ACC1C0")]
	public FBGBGBCFFNE(int MELGOCPNHFM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000205")]
	[Cpp2IlInjected.Address(RVA = "0x3ACBAE0", Offset = "0x3ACA2E0", VA = "0x183ACBAE0")]
	public void CNLMKNIMMKA(T ENDMODAMBGN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000206")]
	[Cpp2IlInjected.Address(RVA = "0x3ACBD50", Offset = "0x3ACA550", VA = "0x183ACBD50")]
	public void GLOOIBDLHCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x3ACBDB0", Offset = "0x3ACA5B0", VA = "0x183ACBDB0")]
	public void JFMMNMIOBOO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x3ACC150", Offset = "0x3ACA950", VA = "0x183ACC150")]
	public void MDMEIGEKFIL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x3ACBC50", Offset = "0x3ACA450", VA = "0x183ACBC50")]
	public void DIGCJFIFOGE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000067")]
public class KFGJOHOFFJG<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000068")]
	private struct FNOKBDLOLOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public int JJBEADNLDFI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public T JDDKPJKLOJP;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private readonly Dictionary<object, FNOKBDLOLOB> MGOJPELCHEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000110")]
	private readonly EqualityComparer<T> NMDBFOAPDHM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000111")]
	private T OCMNBOBNAKH;

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public virtual T PJKKOBLGKGB
	{
		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x8BAAF0", Offset = "0x8B92F0", VA = "0x1808BAAF0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600020B")]
		[Cpp2IlInjected.Address(RVA = "0x4090AB0", Offset = "0x408F2B0", VA = "0x184090AB0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public bool DKNPBHHPJHN
	{
		[Cpp2IlInjected.Token(Token = "0x600020C")]
		[Cpp2IlInjected.Address(RVA = "0x408C540", Offset = "0x408AD40", VA = "0x18408C540")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public object LBJKMOMJABP
	{
		[Cpp2IlInjected.Token(Token = "0x600020D")]
		[Cpp2IlInjected.Address(RVA = "0x847480", Offset = "0x845C80", VA = "0x180847480")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x84A240", Offset = "0x848A40", VA = "0x18084A240")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x408D5F0", Offset = "0x408BDF0", VA = "0x18408D5F0")]
	public bool IOHFIDJCCAN(T IPHHABIKCHD, object OECMOOGGOOF, int PNLPPPCKGCA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000210")]
	[Cpp2IlInjected.Address(RVA = "0x40909E0", Offset = "0x408F1E0", VA = "0x1840909E0")]
	public bool LLIKHMBMBAE(object OECMOOGGOOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000211")]
	[Cpp2IlInjected.Address(RVA = "0x408C8A0", Offset = "0x408B0A0", VA = "0x18408C8A0")]
	public bool GFIHGBPIMCF(object OECMOOGGOOF, [Out] T IPHHABIKCHD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x3750F60", Offset = "0x374F760", VA = "0x183750F60")]
	public void GLOOIBDLHCC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x408F2E0", Offset = "0x408DAE0", VA = "0x18408F2E0")]
	private bool JKDLCFEAHHG()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x4090B50", Offset = "0x408F350", VA = "0x184090B50")]
	public KFGJOHOFFJG()
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
