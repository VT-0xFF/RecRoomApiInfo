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
		[Cpp2IlInjected.Address(RVA = "0x88C9F0", Offset = "0x88AFF0", VA = "0x18088C9F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6912520", Offset = "0x6910B20", VA = "0x186912520")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x88D740", Offset = "0x88BD40", VA = "0x18088D740")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[Microsoft.CodeAnalysis.Embedded]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0x88D780", Offset = "0x88BD80", VA = "0x18088D780")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class GJKJCLJLDLA : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x14E19E0", Offset = "0x14DFFE0", VA = "0x1814E19E0")]
	public GJKJCLJLDLA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HashableScriptableObject : ScriptableObject, DNNDDGNBNEI, PCEOFOMKDKD, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x864DF0", Offset = "0x8633F0", VA = "0x180864DF0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8657D0", Offset = "0x863DD0", VA = "0x1808657D0", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x864E00", Offset = "0x863400", VA = "0x180864E00", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x92F360", Offset = "0x92D960", VA = "0x18092F360", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash HBFGLPMFMGA);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8CDE30", Offset = "0x8CC430", VA = "0x1808CDE30")]
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
	[HideInInspector]
	[ReadOnlyField]
	[SerializeField]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x6913A10", Offset = "0x6912010", VA = "0x186913A10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x69139D0", Offset = "0x6911FD0", VA = "0x1869139D0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x6913A50", Offset = "0x6912050", VA = "0x186913A50")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6913C00", Offset = "0x6912200", VA = "0x186913C00")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6913B70", Offset = "0x6912170", VA = "0x186913B70")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8CDE20", Offset = "0x8CC420", VA = "0x1808CDE20")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8CDDE0", Offset = "0x8CC3E0", VA = "0x1808CDDE0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6913990", Offset = "0x6911F90", VA = "0x186913990")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6913AE0", Offset = "0x69120E0", VA = "0x186913AE0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6913680", Offset = "0x6911C80", VA = "0x186913680")]
	public void CopyBounds(SavedExtents LJAAPFIIPOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x69138E0", Offset = "0x6911EE0", VA = "0x1869138E0")]
	public void SetLocalSpaceBounds(Bounds BIKGCKJDAPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xBA9E20", Offset = "0xBA8420", VA = "0x180BA9E20")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x69138D0", Offset = "0x6911ED0", VA = "0x1869138D0")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6912E50", Offset = "0x6911450", VA = "0x186912E50")]
	private void AFAJHALGKLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x69136B0", Offset = "0x6911CB0", VA = "0x1869136B0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6913010", Offset = "0x6911610", VA = "0x186913010")]
	public static void CalculateLocalBoundsFor(GameObject INALOLPJOHI, [Out] Bounds BIKGCKJDAPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6912D90", Offset = "0x6911390", VA = "0x186912D90")]
	private static void AANLFLCFCMP(Bounds HEOHCJKCOLM, Color DDKEAFEIAAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6913900", Offset = "0x6911F00", VA = "0x186913900")]
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
		[Cpp2IlInjected.Address(RVA = "0x8621A0", Offset = "0x8607A0", VA = "0x1808621A0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x867850", Offset = "0x865E50", VA = "0x180867850")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xFD69C0", Offset = "0xFD4FC0", VA = "0x180FD69C0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x4982940", Offset = "0x4980F40", VA = "0x184982940")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "4")]
	public virtual void EBDGCJOMMDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
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
	[SerializeField]
	[GJKJCLJLDLA]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4982470", Offset = "0x4980A70", VA = "0x184982470", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x4980B20", Offset = "0x497F120", VA = "0x184980B20", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x4982830", Offset = "0x4980E30", VA = "0x184982830")]
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
	private sealed class EBEDKFKPCAO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public EBEDKFKPCAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x37C5770", Offset = "0x37C3D70", VA = "0x1837C5770")]
		internal int GLAMKJMBFGD(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[SerializeField]
	[GJKJCLJLDLA]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x384A3B0", Offset = "0x38489B0", VA = "0x18384A3B0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x384A410", Offset = "0x3848A10", VA = "0x18384A410", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x384A280", Offset = "0x3848880", VA = "0x18384A280", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey BHEIPBKEDLG]
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x384A340", Offset = "0x3848940", VA = "0x18384A340", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x384A120", Offset = "0x3848720", VA = "0x18384A120", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3849DC0", Offset = "0x38483C0", VA = "0x183849DC0", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3849180", Offset = "0x3847780", VA = "0x183849180", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x38490A0", Offset = "0x38476A0", VA = "0x1838490A0", Slot = "14")]
	protected virtual string FICIFKBPONN(TKeyVal KGDKKABCDKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3848FE0", Offset = "0x38475E0", VA = "0x183848FE0", Slot = "4")]
	public bool ContainsKey(TKey BHEIPBKEDLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3849F90", Offset = "0x3848590", VA = "0x183849F90", Slot = "5")]
	public bool TryGetValue(TKey BHEIPBKEDLG, [Out] TVal CBAEIEAPLIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x38490D0", Offset = "0x38476D0", VA = "0x1838490D0", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x38490D0", Offset = "0x38476D0", VA = "0x1838490D0", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3849FF0", Offset = "0x38485F0", VA = "0x183849FF0")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class NPBAFNBLGPB<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private class LBFKHIIELDB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public float HBOJBHGLLIN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public T BLBBIKKJHJE;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public LBFKHIIELDB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class BAEJIELKKNO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public BAEJIELKKNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x4E414B0", Offset = "0x4E3FAB0", VA = "0x184E414B0")]
		internal bool IIGLDLFEEDL(LBFKHIIELDB sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly float ILAFNFMPCDN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly float ENBDCJMBDAA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private List<LBFKHIIELDB> HJIOBLDLLGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private DKMDBKIJEFM<LBFKHIIELDB> GMCBCBEMODK;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int ICEKCNJDAAF
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x45863F0", Offset = "0x45849F0", VA = "0x1845863F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x45866E0", Offset = "0x4584CE0", VA = "0x1845866E0")]
	public NPBAFNBLGPB(float GANMCIICMPI, float FMBGDNACDDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x4585A50", Offset = "0x4584050", VA = "0x184585A50")]
	public bool BJEOFKEBGAG(float IKBJFKDEOPL, T CBAEIEAPLIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x4585C40", Offset = "0x4584240", VA = "0x184585C40")]
	public IEnumerable<T> GDEDBMFAOOO(float IKBJFKDEOPL, [Optional] float? IPOCLCOKCLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x4586620", Offset = "0x4584C20", VA = "0x184586620")]
	public void OAIAOCAHOEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x4586460", Offset = "0x4584A60", VA = "0x184586460")]
	private void LOKFJAEGGDB(float IKBJFKDEOPL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class CLDODBECHFD<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct KBODAOONONB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public T BLBBIKKJHJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public float AOAAHHMBLFN;
	}

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private static float EFGPPHDLHPE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private List<T> IHOFBDPCJLN;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private const int CKMOBPPMNLA = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private KBODAOONONB[] GGEMIJICFPG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private int JKDBMFACKPP;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float PJINDKNJIGI
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9A3C60", Offset = "0x9A2260", VA = "0x1809A3C60")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9B8D90", Offset = "0x9B7390", VA = "0x1809B8D90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5243940", Offset = "0x5241F40", VA = "0x185243940")]
	public CLDODBECHFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5243800", Offset = "0x5241E00", VA = "0x185243800")]
	public CLDODBECHFD(int ENCFHCJIMBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x52433A0", Offset = "0x52419A0", VA = "0x1852433A0")]
	public void MJFEDCBJOBF(float IKBJFKDEOPL, T CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x52436B0", Offset = "0x5241CB0", VA = "0x1852436B0")]
	public void OAIAOCAHOEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5242A40", Offset = "0x5241040", VA = "0x185242A40")]
	public bool IINLJAHGCKK(float COKDJDHEACI, float EKNAPDJFFOB, [Out] T CBAEIEAPLIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5242FA0", Offset = "0x52415A0", VA = "0x185242FA0")]
	public bool LKHOJHPNNBB(float COKDJDHEACI, float EKNAPDJFFOB, [Out] T CBAEIEAPLIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5242870", Offset = "0x5240E70", VA = "0x185242870")]
	public void CNMELFEIEAI(float COKDJDHEACI, float EKNAPDJFFOB, List<T> EPBKIHMMALG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x5242F70", Offset = "0x5241570", VA = "0x185242F70")]
	private int LFADDPNBGEM(int FDLNFOLDHLB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x52429F0", Offset = "0x5240FF0", VA = "0x1852429F0")]
	private void FFFHCENDPBM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T LDBDNMDKFGP();

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T KHHMHIKNGEM(T CBAEIEAPLIH, float LBKJPGMAINP);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T GGJCCCNDEPE(T ILBMPADICAD, T BEOPIALHGPL);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T NBAENKBBCBE(T ILBMPADICAD, T BEOPIALHGPL);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class GEDMBAGKCFJ : CLDODBECHFD<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x872BC0", Offset = "0x8711C0", VA = "0x180872BC0", Slot = "4")]
	protected override Vector3 LDBDNMDKFGP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6910660", Offset = "0x690EC60", VA = "0x186910660", Slot = "5")]
	protected override Vector3 KHHMHIKNGEM(Vector3 CBAEIEAPLIH, float LBKJPGMAINP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6910610", Offset = "0x690EC10", VA = "0x186910610", Slot = "6")]
	protected override Vector3 GGJCCCNDEPE(Vector3 ILBMPADICAD, Vector3 BEOPIALHGPL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x69106A0", Offset = "0x690ECA0", VA = "0x1869106A0", Slot = "7")]
	protected override Vector3 NBAENKBBCBE(Vector3 ILBMPADICAD, Vector3 BEOPIALHGPL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6910720", Offset = "0x690ED20", VA = "0x186910720")]
	public GEDMBAGKCFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class HENHHMAPLNO
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2B07F70", Offset = "0x2B06570", VA = "0x182B07F70")]
	public static KKCDLHKOFNI<T1, T2> GIGNPOIHFIA<T1, T2>(T1 BCOCGDJMCCA, T2 APEPKAHODKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2B08010", Offset = "0x2B06610", VA = "0x182B08010")]
	public static FPHALOFBMIA<T1, T2, T3> GIGNPOIHFIA<T1, T2, T3>(T1 BCOCGDJMCCA, T2 APEPKAHODKG, T3 CPEOMKONCFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4521530", Offset = "0x451FB30", VA = "0x184521530")]
	internal static int BHIFOADBIEB(int PPEDDJNKALC, int HPPJDBCECKI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5CDAB70", Offset = "0x5CD9170", VA = "0x185CDAB70")]
	internal static int BHIFOADBIEB(int PPEDDJNKALC, int HPPJDBCECKI, int CNNICPDACBB)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class KKCDLHKOFNI<T1, T2> : IComparable<KKCDLHKOFNI<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly T1 NDGPFNOOGGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly T2 IOKMFFKPCKL;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x4207630", Offset = "0x4205C30", VA = "0x184207630")]
	public KKCDLHKOFNI(T1 BCOCGDJMCCA, T2 APEPKAHODKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x4205C00", Offset = "0x4204200", VA = "0x184205C00", Slot = "4")]
	public int CompareTo(KKCDLHKOFNI<T1, T2> LJAAPFIIPOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x4206300", Offset = "0x4204900", VA = "0x184206300", Slot = "0")]
	public override bool Equals(object LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x4206970", Offset = "0x4204F70", VA = "0x184206970", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x4207480", Offset = "0x4205A80", VA = "0x184207480", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class FPHALOFBMIA<T1, T2, T3> : IComparable<FPHALOFBMIA<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly T1 NDGPFNOOGGK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly T2 IOKMFFKPCKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly T3 AIPHDBGIDHF;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x3C81C20", Offset = "0x3C80220", VA = "0x183C81C20")]
	public FPHALOFBMIA(T1 BCOCGDJMCCA, T2 APEPKAHODKG, T3 CPEOMKONCFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3C81410", Offset = "0x3C7FA10", VA = "0x183C81410", Slot = "4")]
	public int CompareTo(FPHALOFBMIA<T1, T2, T3> LJAAPFIIPOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x3C81570", Offset = "0x3C7FB70", VA = "0x183C81570", Slot = "0")]
	public override bool Equals(object LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3C818B0", Offset = "0x3C7FEB0", VA = "0x183C818B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3C81950", Offset = "0x3C7FF50", VA = "0x183C81950", Slot = "3")]
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
	public T BLBBIKKJHJE
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x22F0320", Offset = "0x22EE920", VA = "0x1822F0320")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x22F0360", Offset = "0x22EE960", VA = "0x1822F0360")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public float BMOGHGOLKKN
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8CDD80", Offset = "0x8CC380", VA = "0x1808CDD80")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4BBBFA0", Offset = "0x4BBA5A0", VA = "0x184BBBFA0")]
	public T HMBNANGDNKP(float LBKJPGMAINP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x4BBC2E0", Offset = "0x4BBA8E0", VA = "0x184BBC2E0")]
	public T OKFLOLCGCLL(float LBKJPGMAINP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T INHECHKJPLF(T ILBMPADICAD, T BEOPIALHGPL, float LBKJPGMAINP);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6910590", Offset = "0x690EB90", VA = "0x186910590", Slot = "4")]
	protected override float INHECHKJPLF(float ILBMPADICAD, float BEOPIALHGPL, float LBKJPGMAINP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x69105D0", Offset = "0x690EBD0", VA = "0x1869105D0")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0xE79B50", Offset = "0xE78150", VA = "0x180E79B50", Slot = "4")]
	protected override Vector3 INHECHKJPLF(Vector3 ILBMPADICAD, Vector3 BEOPIALHGPL, float LBKJPGMAINP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x6914840", Offset = "0x6912E40", VA = "0x186914840")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6910210", Offset = "0x690E810", VA = "0x186910210", Slot = "4")]
	protected override Color INHECHKJPLF(Color ILBMPADICAD, Color BEOPIALHGPL, float LBKJPGMAINP)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x69102D0", Offset = "0x690E8D0", VA = "0x1869102D0")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class LMEAJLGDHMB : POKEMGHGOGK<string>
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x69123A0", Offset = "0x69109A0", VA = "0x1869123A0")]
	public LMEAJLGDHMB(int NAFKLJDAKHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6912330", Offset = "0x6910930", VA = "0x186912330", Slot = "6")]
	protected override uint KOJPGJKIHIL(uint HBFGLPMFMGA, string CBAEIEAPLIH)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class EEDAIGIAKFJ : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly IDisposable IBMHAACFGKI;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
	public EEDAIGIAKFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct PPBJHBKJKGF<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> FNKIOOANPBK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private int NLFHNJDDEHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int HAPCAEKNLKB;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x4523440", Offset = "0x4521A40", VA = "0x184523440")]
	private PPBJHBKJKGF(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> BNIGBKFGBCA, int HJAKNKEGBFE, int IKMCAHAKNPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x4794860", Offset = "0x4792E60", VA = "0x184794860")]
	public static PPBJHBKJKGF<T> HCLFOFEHDJP()
	{
		return default(PPBJHBKJKGF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x4794100", Offset = "0x4792700", VA = "0x184794100")]
	public (int, int, Task<T>) ENHPBHMBLGL(int IGGMMJMDDDD, [Optional] CancellationToken DADBOHKBJNO, double PJKHGIHPBDF = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x4792300", Offset = "0x4790900", VA = "0x184792300")]
	public void CFHJLHDKCIH(int IGGMMJMDDDD, int IKMCAHAKNPM, [In] T HJBJAPKPPFA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class NOLBAFODJBL
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x69124D0", Offset = "0x6910AD0", VA = "0x1869124D0")]
	public static PPBJHBKJKGF<HNKFFDNJINI> HCLFOFEHDJP()
	{
		return default(PPBJHBKJKGF<HNKFFDNJINI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6912450", Offset = "0x6910A50", VA = "0x186912450")]
	public static void CFHJLHDKCIH([In] this PPBJHBKJKGF<HNKFFDNJINI> OLDDCPCBGIL, int IGGMMJMDDDD, int IKMCAHAKNPM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[DefaultMember("Item")]
public class HGDBIBBGKNH<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly Dictionary<TKey, TVal> PEMOIOCDHMM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly Dictionary<TVal, TKey> JFODJGNGCBC;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int FGAKKPCAMNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x355CD00", Offset = "0x355B300", VA = "0x18355CD00", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool FAOLOMOFDJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8AAFC0", Offset = "0x8A95C0", VA = "0x1808AAFC0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public ICollection<TKey> NHIDLCIOKPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x3DCDEF0", Offset = "0x3DCC4F0", VA = "0x183DCDEF0", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public ICollection<TVal> HLMNKOOFAJL
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x3DCDF50", Offset = "0x3DCC550", VA = "0x183DCDF50", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public TVal PGDICMLLHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x3DCDE80", Offset = "0x3DCC480", VA = "0x183DCDE80", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x3DCDFB0", Offset = "0x3DCC5B0", VA = "0x183DCDFB0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public TKey PGDICMLLHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x3DCD4E0", Offset = "0x3DCBAE0", VA = "0x183DCD4E0")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3DCD320", Offset = "0x3DCB920", VA = "0x183DCD320", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3DCDBF0", Offset = "0x3DCC1F0", VA = "0x183DCDBF0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3DCD010", Offset = "0x3DCB610", VA = "0x183DCD010", Slot = "9")]
	public void Add(TKey BHEIPBKEDLG, TVal CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3DCD0F0", Offset = "0x3DCB6F0", VA = "0x183DCD0F0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> OPNLGJFHDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3D13EF0", Offset = "0x3D124F0", VA = "0x183D13EF0", Slot = "8")]
	public bool ContainsKey(TKey BHEIPBKEDLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3DCD3D0", Offset = "0x3DCB9D0", VA = "0x183DCD3D0", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> OPNLGJFHDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x3DCDB70", Offset = "0x3DCC170", VA = "0x183DCDB70", Slot = "10")]
	public bool Remove(TKey BHEIPBKEDLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3DCDBB0", Offset = "0x3DCC1B0", VA = "0x183DCDBB0", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> OPNLGJFHDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x3DCDC90", Offset = "0x3DCC290", VA = "0x183DCDC90", Slot = "11")]
	public bool TryGetValue(TKey BHEIPBKEDLG, [Out] TVal CBAEIEAPLIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3DCD5A0", Offset = "0x3DCBBA0", VA = "0x183DCD5A0", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3DCD450", Offset = "0x3DCBA50", VA = "0x183DCD450", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] GGEMIJICFPG, int MCEFCKDGOEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3DCD6A0", Offset = "0x3DCBCA0", VA = "0x183DCD6A0")]
	public bool MMCLNKMOKEF(TVal BHEIPBKEDLG, [Out] TKey CBAEIEAPLIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3DCD140", Offset = "0x3DCB740", VA = "0x183DCD140")]
	private void BPOJBMCLCIC(TKey BHEIPBKEDLG, TVal LECBAKCNNCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3DCD950", Offset = "0x3DCBF50", VA = "0x183DCD950")]
	private void NOLOALKHGHN(TKey BHEIPBKEDLG, TVal LECBAKCNNCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3DCD700", Offset = "0x3DCBD00", VA = "0x183DCD700")]
	private bool NMOOPAJILOI(TKey BHEIPBKEDLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3DCDCF0", Offset = "0x3DCC2F0", VA = "0x183DCDCF0")]
	public HGDBIBBGKNH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[DefaultMember("Item")]
public class MHLEGOIDLII<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private MHLEGOIDLII<T> buffer;

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
			[Cpp2IlInjected.Address(RVA = "0x3893800", Offset = "0x3891E00", VA = "0x183893800", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x389F220", Offset = "0x389D820", VA = "0x18389F220", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x38A01D0", Offset = "0x389E7D0", VA = "0x1838A01D0")]
		public Enumerator(MHLEGOIDLII<T> EPBKIHMMALG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x389DEC0", Offset = "0x389C4C0", VA = "0x18389DEC0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x389E910", Offset = "0x389CF10", VA = "0x18389E910", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x389D6B0", Offset = "0x389BCB0", VA = "0x18389D6B0")]
		private void CIFACDJHDHK()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private T[] LCIJAGELCDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private int GEIGDPFELPO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private int FJLMFNONBHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private int HNNOPDLCPBM;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int FGAKKPCAMNO
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x44CCEE0", Offset = "0x44CB4E0", VA = "0x1844CCEE0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public T PGDICMLLHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x44CB2B0", Offset = "0x44C98B0", VA = "0x1844CB2B0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x44CC3D0", Offset = "0x44CA9D0", VA = "0x1844CC3D0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x44CD210", Offset = "0x44CB810", VA = "0x1844CD210")]
	public MHLEGOIDLII(int NAFKLJDAKHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x44CC870", Offset = "0x44CAE70", VA = "0x1844CC870")]
	public void MJFEDCBJOBF(T LBKJPGMAINP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x44CCEC0", Offset = "0x44CB4C0", VA = "0x1844CCEC0")]
	public void OAIAOCAHOEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x44CC790", Offset = "0x44CAD90", VA = "0x1844CC790")]
	public void HHPDKEGNKMD(int JPBPNOCHNLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x44CC250", Offset = "0x44CA850", VA = "0x1844CC250")]
	public void FNIBGALIMHE(T[] GGEMIJICFPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x44CAFB0", Offset = "0x44C95B0", VA = "0x1844CAFB0")]
	public Enumerator AKHPNFMFJMK()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x44CD0E0", Offset = "0x44CB6E0", VA = "0x1844CD0E0", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x44CD0E0", Offset = "0x44CB6E0", VA = "0x1844CD0E0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x44CB990", Offset = "0x44C9F90", VA = "0x1844CB990")]
	private int FGIAIDNBEEC(int LLPJHIPCNFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x44CC760", Offset = "0x44CAD60", VA = "0x1844CC760")]
	private int HAKIAPNBKAE(int LLPJHIPCNFD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class OEGIOJIPBCE<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public delegate Task<TResult> CIEDDCMHHDL(TRequest BDMHFDNBPPE, CancellationToken DADBOHKBJNO);

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public enum LCKEPDINHBO
	{
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class BFGFPNEPNBP
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private const float DDMJBDCNCBE = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TimeSpan BPOGMICCPEF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int DMGONKJALBK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public LCKEPDINHBO PIJJFHKGFNG;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public static readonly BFGFPNEPNBP BMMJODHNHHN;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float PJMKEALDKAJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x4E54400", Offset = "0x4E52A00", VA = "0x184E54400")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public TimeSpan LEKGHGKKEBD
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x8657C0", Offset = "0x863DC0", VA = "0x1808657C0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x4E54550", Offset = "0x4E52B50", VA = "0x184E54550")]
		public BFGFPNEPNBP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	private readonly struct BIBDIFDBDOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly TRequest BDMHFDNBPPE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly CancellationToken DADBOHKBJNO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly TaskCompletionSource<TResult> DOBFIJDMMAG;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x4E70970", Offset = "0x4E6EF70", VA = "0x184E70970")]
		public BIBDIFDBDOH(TRequest BDMHFDNBPPE, TaskCompletionSource<TResult> DOBFIJDMMAG, CancellationToken DADBOHKBJNO)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct CFEBGFBKBNJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public OEGIOJIPBCE<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x5152030", Offset = "0x5150630", VA = "0x185152030", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x51524A0", Offset = "0x5150AA0", VA = "0x1851524A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct PMOGJLLFGLN : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public OEGIOJIPBCE<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private BIBDIFDBDOH <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x478D740", Offset = "0x478BD40", VA = "0x18478D740", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x478DD40", Offset = "0x478C340", VA = "0x18478DD40", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly CancellationTokenSource IOIDMMKCIDB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly List<BIBDIFDBDOH> EKCFEIKIDFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly BFGFPNEPNBP IKNGJBDNIAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly CIEDDCMHHDL EDHAPIHPKFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Task HOCEAPPMOIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private int LAKDIHFPBBA;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x4665780", Offset = "0x4663D80", VA = "0x184665780")]
	public OEGIOJIPBCE(CIEDDCMHHDL EDHAPIHPKFG, [Optional] BFGFPNEPNBP IKNGJBDNIAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x46653A0", Offset = "0x46639A0", VA = "0x1846653A0")]
	public Task<TResult> JLOMEBMMDLF(TRequest BDMHFDNBPPE, CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x4664C40", Offset = "0x4663240", VA = "0x184664C40")]
	private void IEOIENOKJFM(BIBDIFDBDOH PPDKAHPOCJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x4664B70", Offset = "0x4663170", VA = "0x184664B70")]
	[AsyncStateMachine(typeof(OEGIOJIPBCE<, >.CFEBGFBKBNJ))]
	private Task HFLDDDKEKJM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x46643F0", Offset = "0x46629F0", VA = "0x1846643F0")]
	private BIBDIFDBDOH FLNMMEMEIDM()
	{
		return default(BIBDIFDBDOH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x4663B70", Offset = "0x4662170", VA = "0x184663B70")]
	[AsyncStateMachine(typeof(OEGIOJIPBCE<, >.PMOGJLLFGLN))]
	private Task AMKENCOJKBD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x4663E70", Offset = "0x4662470", VA = "0x184663E70")]
	private void CCCBIDGAOIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x4664090", Offset = "0x4662690", VA = "0x184664090", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DefaultMember("Item")]
public class AEBCNKGCLDL<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly List<T> DNOAHHGKGFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private HashSet<T> PDGHONNCIEM;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int FGAKKPCAMNO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x355CD00", Offset = "0x355B300", VA = "0x18355CD00", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool FAOLOMOFDJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x8AAFC0", Offset = "0x8A95C0", VA = "0x1808AAFC0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public T PGDICMLLHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x27420B0", Offset = "0x27406B0", VA = "0x1827420B0", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x3CCE0E0", Offset = "0x3CCC6E0", VA = "0x183CCE0E0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x3C8F3B0", Offset = "0x3C8D9B0", VA = "0x183C8F3B0", Slot = "11")]
	public void Add(T OPNLGJFHDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x3CCDA40", Offset = "0x3CCC040", VA = "0x183CCDA40")]
	public bool PFKIIIIKFDA(T OPNLGJFHDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x3CCDEE0", Offset = "0x3CCC4E0", VA = "0x183CCDEE0", Slot = "15")]
	public bool Remove(T OPNLGJFHDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x37C5FA0", Offset = "0x37C45A0", VA = "0x1837C5FA0", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3BE9810", Offset = "0x3BE7E10", VA = "0x183BE9810", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3CCD4C0", Offset = "0x3CCBAC0", VA = "0x183CCD4C0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3CCD570", Offset = "0x3CCBB70", VA = "0x183CCD570", Slot = "13")]
	public bool Contains(T OPNLGJFHDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x3CCD5D0", Offset = "0x3CCBBD0", VA = "0x183CCD5D0", Slot = "14")]
	public void CopyTo(T[] GGEMIJICFPG, int MCEFCKDGOEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x3CCD630", Offset = "0x3CCBC30", VA = "0x183CCD630", Slot = "6")]
	public int IndexOf(T OPNLGJFHDEP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3CCD690", Offset = "0x3CCBC90", VA = "0x183CCD690", Slot = "7")]
	public void Insert(int LLPJHIPCNFD, T OPNLGJFHDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x3CCDCB0", Offset = "0x3CCC2B0", VA = "0x183CCDCB0", Slot = "8")]
	public void RemoveAt(int LLPJHIPCNFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3CCDFB0", Offset = "0x3CCC5B0", VA = "0x183CCDFB0")]
	public AEBCNKGCLDL()
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
			[Cpp2IlInjected.Address(RVA = "0x2195DA0", Offset = "0x21943A0", VA = "0x182195DA0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x6913FA0", Offset = "0x69125A0", VA = "0x186913FA0")]
		public SerializedGuid([In] Guid NNFEKLKANBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x6913E70", Offset = "0x6912470", VA = "0x186913E70")]
		public static SerializedGuid NKMJBAODIPB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x6913DF0", Offset = "0x69123F0", VA = "0x186913DF0")]
		public static SerializedGuid GLDEMEOELCM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x6913CC0", Offset = "0x69122C0", VA = "0x186913CC0")]
		public bool DFLAHLKBLGO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6913F70", Offset = "0x6912570", VA = "0x186913F70", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x6913EF0", Offset = "0x69124F0", VA = "0x186913EF0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6913D20", Offset = "0x6912320", VA = "0x186913D20", Slot = "7")]
		public bool Equals(SerializedGuid LJAAPFIIPOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x6913D60", Offset = "0x6912360", VA = "0x186913D60", Slot = "0")]
		public override bool Equals(object HBFCGFKGCAF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x6913E60", Offset = "0x6912460", VA = "0x186913E60", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x6913C90", Offset = "0x6912290", VA = "0x186913C90", Slot = "6")]
		public int CompareTo(SerializedGuid LJAAPFIIPOF)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class OIKMPEEDFJP : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly Type DJCFCGPHOIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly string JMMFFNDEGKD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly bool AIDFDAOOIIF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly bool LGDPGDAIJMA;

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x69125A0", Offset = "0x6910BA0", VA = "0x1869125A0")]
	public OIKMPEEDFJP(Type HHJGPDLLEFC, string NEEBFHEIMLD, bool BKANEFJEDPP = false, bool JFBCFCCFMPM = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class DJJFGNEEIPJ<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public readonly struct NKDDOICNFBI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public readonly long DHJLMLEJJGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public readonly long KFLGCIFBBNK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public readonly int CFOAJMHFKMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly int IOFLCOBFBCE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public readonly bool KNFBOGEIAEG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly string INABEHJJLFH;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x456A690", Offset = "0x4568C90", VA = "0x18456A690")]
		public NKDDOICNFBI(long DHJLMLEJJGL, int CFOAJMHFKMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x456A660", Offset = "0x4568C60", VA = "0x18456A660")]
		public NKDDOICNFBI(long DHJLMLEJJGL, long KFLGCIFBBNK, int CFOAJMHFKMO, int IOFLCOBFBCE, bool KNFBOGEIAEG, string INABEHJJLFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x456A610", Offset = "0x4568C10", VA = "0x18456A610")]
		public int PHIEGNBOOGC()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x456A4F0", Offset = "0x4568AF0", VA = "0x18456A4F0")]
		public int BFIBGPFAOJI(int KJANKENDGBI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x456A510", Offset = "0x4568B10", VA = "0x18456A510")]
		public double DHJEPFNJGOK()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x456A570", Offset = "0x4568B70", VA = "0x18456A570")]
		public NKDDOICNFBI KHDBLKNIDBK(long KFLGCIFBBNK, int IOFLCOBFBCE)
		{
			return default(NKDDOICNFBI);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class DIJMCCGECOP : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private struct LGOBMNMBKNG<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public DIJMCCGECOP <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public Func<DIJMCCGECOP, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			private DIJMCCGECOP <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x42B5B20", Offset = "0x42B4120", VA = "0x1842B5B20", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x3E77E10", Offset = "0x3E76410", VA = "0x183E77E10", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public readonly TKey IGAHPOGKKJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly DJJFGNEEIPJ<TKey> OPELNCJDKIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public readonly ICJNMGNJFIN CAJBNIGHKAB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private List<DIJMCCGECOP> CNHPMDGMKHC;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public string EEOEAFKCDKI
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x3C58AC0", Offset = "0x3C570C0", VA = "0x183C58AC0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public IEnumerable<DIJMCCGECOP> ACNCGBCHAHF
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x5805FE0", Offset = "0x58045E0", VA = "0x185805FE0")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public NKDDOICNFBI IGBHFBBEGJJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x5806020", Offset = "0x5804620", VA = "0x185806020")]
			[CompilerGenerated]
			get
			{
				return default(NKDDOICNFBI);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x5806200", Offset = "0x5804800", VA = "0x185806200")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x5806230", Offset = "0x5804830", VA = "0x185806230")]
		internal DIJMCCGECOP(DJJFGNEEIPJ<TKey> OPELNCJDKIK, TKey BHEIPBKEDLG, ICJNMGNJFIN CAJBNIGHKAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x5806040", Offset = "0x5804640", VA = "0x185806040")]
		public DIJMCCGECOP NOKGBJLMPML(TKey BHEIPBKEDLG, [Optional] ICJNMGNJFIN? EEGMELOJAAG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x2742B50", Offset = "0x2741150", VA = "0x182742B50")]
		[AsyncStateMachine(typeof(LGOBMNMBKNG<>))]
		public Task<T> CODKLMIAMEJ<T>(TKey BHEIPBKEDLG, Func<DIJMCCGECOP, Task<T>> LHGGEBICOGB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x5805D80", Offset = "0x5804380", VA = "0x185805D80", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class BPNFJMOJIDB : IEnumerable<(TKey, List<TKey>, NKDDOICNFBI)>, IEnumerable, IEnumerator<(TKey, List<TKey>, NKDDOICNFBI)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private (TKey key, List<TKey> path, NKDDOICNFBI timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public DJJFGNEEIPJ<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private IEnumerator<(TKey key, List<TKey> path, NKDDOICNFBI timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		private (TKey, List<TKey>, NKDDOICNFBI) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x21938F0", Offset = "0x2191EF0", VA = "0x1821938F0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, NKDDOICNFBI));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x4E919A0", Offset = "0x4E8FFA0", VA = "0x184E919A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x21939E0", Offset = "0x2191FE0", VA = "0x1821939E0")]
		[DebuggerHidden]
		public BPNFJMOJIDB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x3969AD0", Offset = "0x39680D0", VA = "0x183969AD0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x4E91470", Offset = "0x4E8FA70", VA = "0x184E91470", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x4E91820", Offset = "0x4E8FE20", VA = "0x184E91820")]
		private void PEOGCCBKFKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x4E91950", Offset = "0x4E8FF50", VA = "0x184E91950", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x4E91870", Offset = "0x4E8FE70", VA = "0x184E91870", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, NKDDOICNFBI)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x3AC5010", Offset = "0x3AC3610", VA = "0x183AC5010", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class EHNIIJJGOHN : IEnumerable<(TKey, List<TKey>, NKDDOICNFBI)>, IEnumerable, IEnumerator<(TKey, List<TKey>, NKDDOICNFBI)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private (TKey key, List<TKey> path, NKDDOICNFBI timerEntry) <>2__current;

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
		private DIJMCCGECOP timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public DIJMCCGECOP <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public DJJFGNEEIPJ<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private IEnumerator<DIJMCCGECOP> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private IEnumerator<(TKey key, List<TKey> path, NKDDOICNFBI timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private (TKey, List<TKey>, NKDDOICNFBI) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x21938F0", Offset = "0x2191EF0", VA = "0x1821938F0", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, NKDDOICNFBI));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x37EB920", Offset = "0x37E9F20", VA = "0x1837EB920", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x21939E0", Offset = "0x2191FE0", VA = "0x1821939E0")]
		[DebuggerHidden]
		public EHNIIJJGOHN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x37EB980", Offset = "0x37E9F80", VA = "0x1837EB980", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x37EAF40", Offset = "0x37E9540", VA = "0x1837EAF40", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x37EB730", Offset = "0x37E9D30", VA = "0x1837EB730")]
		private void PEOGCCBKFKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x37EAEE0", Offset = "0x37E94E0", VA = "0x1837EAEE0")]
		private void LAOHPFDNJCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x37EB8D0", Offset = "0x37E9ED0", VA = "0x1837EB8D0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x37EB790", Offset = "0x37E9D90", VA = "0x1837EB790", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, NKDDOICNFBI)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x37EB890", Offset = "0x37E9E90", VA = "0x1837EB890", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly Action<TKey, NKDDOICNFBI, ICJNMGNJFIN> OELKPCFGNNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly Action<TKey, NKDDOICNFBI, ICJNMGNJFIN> FHCECICIANB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly Action<DJJFGNEEIPJ<TKey>, ICJNMGNJFIN> DMHLNBLLNJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly ICJNMGNJFIN CAJBNIGHKAB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly DIJMCCGECOP GADCJNDJGMI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private bool KIHONPKCMEM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int LLIMNOKHDAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly Stopwatch JBABMCMIKHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly int HNHNPHAKCLH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private string HIKGOMNFBAD;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public DIJMCCGECOP ONNKFBBELGC
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x865820", Offset = "0x863E20", VA = "0x180865820")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	[NotNull]
	public string EEOEAFKCDKI
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x863DF0", Offset = "0x8623F0", VA = "0x180863DF0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x5808E00", Offset = "0x5807400", VA = "0x185808E00")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x5809080", Offset = "0x5807680", VA = "0x185809080")]
	public DJJFGNEEIPJ(TKey FIBNPFLNDAH, ICJNMGNJFIN CAJBNIGHKAB, [Optional] int? CFOAJMHFKMO, [Optional][CanBeNull] Stopwatch JBABMCMIKHE, [Optional] Action<TKey, NKDDOICNFBI, ICJNMGNJFIN> OELKPCFGNNC, [Optional] Action<TKey, NKDDOICNFBI, ICJNMGNJFIN> FHCECICIANB, [Optional] Action<DJJFGNEEIPJ<TKey>, ICJNMGNJFIN> DMHLNBLLNJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x5808D20", Offset = "0x5807320", VA = "0x185808D20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x5808E60", Offset = "0x5807460", VA = "0x185808E60")]
	[IteratorStateMachine(typeof(DJJFGNEEIPJ<>.BPNFJMOJIDB))]
	public IEnumerable<(TKey, List<TKey>, NKDDOICNFBI)> IHHMNALBBNE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x5808F10", Offset = "0x5807510", VA = "0x185808F10")]
	[IteratorStateMachine(typeof(DJJFGNEEIPJ<>.EHNIIJJGOHN))]
	private IEnumerable<(TKey, List<TKey>, NKDDOICNFBI)> IHHMNALBBNE(List<TKey> AKCHJOKAGJB, DIJMCCGECOP PGFNMJEGAHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x5809000", Offset = "0x5807600", VA = "0x185809000")]
	private (long, int) LCKAANELJBF()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public abstract class FGPLHDNGOIJ<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut HONEKPGFJIH(DJJFGNEEIPJ<TKey> OPELNCJDKIK);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
	protected FGPLHDNGOIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public abstract class EONOKHAACBK<TKey> : FGPLHDNGOIJ<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public delegate string BBFDKELHKOA(TKey BHEIPBKEDLG);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x383C0F0", Offset = "0x383A6F0", VA = "0x18383C0F0")]
	private static string CHHLEACKEIC(TKey BHEIPBKEDLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x383C290", Offset = "0x383A890", VA = "0x18383C290", Slot = "4")]
	public override string HONEKPGFJIH(DJJFGNEEIPJ<TKey> OPELNCJDKIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x383C130", Offset = "0x383A730", VA = "0x18383C130")]
	public string HONEKPGFJIH(DJJFGNEEIPJ<TKey> OPELNCJDKIK, [NotNull] BBFDKELHKOA FCPOOFAKGGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string GEGLHCMGHFE(DJJFGNEEIPJ<TKey> OPELNCJDKIK, [NotNull] BBFDKELHKOA FCPOOFAKGGN);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x383C380", Offset = "0x383A980", VA = "0x18383C380")]
	protected EONOKHAACBK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class JDGGCKLKOMM<TKey> : FGPLHDNGOIJ<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public delegate string GCCPMHCGJCJ(TKey BHEIPBKEDLG);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly string CGPGNAFHDBD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly double LPMLPPNLEMK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly bool HJCJCMKHLKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly int LAJHHJGIINL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly ISet<string> CNBAILFOENJ;

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x406EF30", Offset = "0x406D530", VA = "0x18406EF30")]
	private static string CHHLEACKEIC(TKey BHEIPBKEDLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x406FB70", Offset = "0x406E170", VA = "0x18406FB70")]
	public JDGGCKLKOMM(string CGPGNAFHDBD = "F2", double LPMLPPNLEMK = double.MaxValue, bool HJCJCMKHLKB = false, int LAJHHJGIINL = int.MaxValue, [Optional] ISet<string> CNBAILFOENJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x406F350", Offset = "0x406D950", VA = "0x18406F350", Slot = "4")]
	public override Dictionary<string, string> HONEKPGFJIH(DJJFGNEEIPJ<TKey> OPELNCJDKIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x406FA90", Offset = "0x406E090", VA = "0x18406FA90")]
	private bool LKPBOGIIPNI(string LCANFHLDCOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x406F440", Offset = "0x406DA40", VA = "0x18406F440")]
	public Dictionary<string, string> HONEKPGFJIH(DJJFGNEEIPJ<TKey> OPELNCJDKIK, GCCPMHCGJCJ FCPOOFAKGGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x406F0D0", Offset = "0x406D6D0", VA = "0x18406F0D0")]
	private string GCPBLDCAMFF(StringBuilder KLHCOPAEHIC, List<TKey> CDHHADCICAH, GCCPMHCGJCJ FCPOOFAKGGN, bool EFKNEBJEPBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x406EF70", Offset = "0x406D570", VA = "0x18406EF70")]
	private static void FBPMABEAAGE(StringBuilder EEPIMNKAJNN, string BCLGMLEEKBD, bool GJNMBDFOIHI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class CBMOLBONIHO<TKey> : EONOKHAACBK<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct PNPMNINPHOJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public BBFDKELHKOA keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public static CBMOLBONIHO<TKey> IBMHAACFGKI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly string[] HBBJENCKLPL;

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5044FB0", Offset = "0x50435B0", VA = "0x185044FB0")]
	private CBMOLBONIHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x5043EB0", Offset = "0x50424B0", VA = "0x185043EB0", Slot = "5")]
	protected override string GEGLHCMGHFE(DJJFGNEEIPJ<TKey> OPELNCJDKIK, BBFDKELHKOA FCPOOFAKGGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5044D50", Offset = "0x5043350", VA = "0x185044D50")]
	[CompilerGenerated]
	internal static string JOJEGAJHPIP(string GHEPFBANENK, TKey BHEIPBKEDLG, PNPMNINPHOJ P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class CFPLEGNHFFN : DJJFGNEEIPJ<string>
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class EPKDOEMBBHH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public Action<CFPLEGNHFFN, ICJNMGNJFIN> callback;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public EPKDOEMBBHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x6910390", Offset = "0x690E990", VA = "0x186910390")]
		internal void GIKBLOMMBJH(DJJFGNEEIPJ<string> timer, ICJNMGNJFIN log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x69100C0", Offset = "0x690E6C0", VA = "0x1869100C0")]
	public CFPLEGNHFFN(ICJNMGNJFIN CAJBNIGHKAB, [Optional] string KCHDIPBIBMC, [Optional] int? CFOAJMHFKMO, [Optional] Stopwatch JBABMCMIKHE, [Optional] Action<string, NKDDOICNFBI, ICJNMGNJFIN> OELKPCFGNNC, [Optional] Action<string, NKDDOICNFBI, ICJNMGNJFIN> FHCECICIANB, [Optional] Action<CFPLEGNHFFN, ICJNMGNJFIN> DMHLNBLLNJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6910000", Offset = "0x690E600", VA = "0x186910000")]
	private static Action<DJJFGNEEIPJ<string>, ICJNMGNJFIN> JAJKOAEBLGO(Action<CFPLEGNHFFN, ICJNMGNJFIN> AHJILKLLLDE)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public abstract class FCFCDOKMMCJ
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	private class HELCOENHDAE : FCFCDOKMMCJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public static FCFCDOKMMCJ IBMHAACFGKI
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x6910780", Offset = "0x690ED80", VA = "0x186910780")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override float HMNOFLLLMOH
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x9AE280", Offset = "0x9AC880", VA = "0x1809AE280", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x6910880", Offset = "0x690EE80", VA = "0x186910880")]
		public HELCOENHDAE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static FCFCDOKMMCJ FILODDEGFDB;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static FCFCDOKMMCJ BMMJODHNHHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x6910420", Offset = "0x690EA20", VA = "0x186910420")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public abstract float HMNOFLLLMOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
	protected FCFCDOKMMCJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface EGGKBNFDHIC : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	bool MENDGOLEHOE
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface FMHOFFFMGIN<T> : EGGKBNFDHIC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	[NotNull]
	Task<T> ADMBNEIFAEN
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	[NotNull]
	HCGNNEJAOHI<T> PCBEFABIIFC
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class PGAGHLHNINK
{
	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x2CBBAA0", Offset = "0x2CBA0A0", VA = "0x182CBBAA0")]
	public static FMHOFFFMGIN<TResource> AIMPBCGNGGE<TResource, TId>(this KMPILIIFONB<TId, TResource> AMAMLMNLJEL, TId BLCJLIJFBDL, [Optional] Func<TId, CancellationToken, Task<TResource>>? JFILKDJICOM) where TResource : notnull where TId : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class FLOLGJJGDHC
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private sealed class KECGCIOCKIK<T> : OCGDHNPKGKG<T?> where T : class
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override Task<T?> ADMBNEIFAEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override HCGNNEJAOHI<T?> PCBEFABIIFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x8657D0", Offset = "0x863DD0", VA = "0x1808657D0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x41EB700", Offset = "0x41E9D00", VA = "0x1841EB700")]
		public KECGCIOCKIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "10")]
		protected override void LFGLBHDCMLI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	private sealed class LPMANNPBAMH<T> : OCGDHNPKGKG<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly T ALJGHBIIELD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly Action<T>? DHAABJGHDFH;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override Task<T> ADMBNEIFAEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x86CF30", Offset = "0x86B530", VA = "0x18086CF30", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override HCGNNEJAOHI<T> PCBEFABIIFC
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x86DC70", Offset = "0x86C270", VA = "0x18086DC70", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x42E43D0", Offset = "0x42E29D0", VA = "0x1842E43D0")]
		public LPMANNPBAMH(T HHMLOJPFGAO, Action<T>? DPHFDCIPJAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x42E4180", Offset = "0x42E2780", VA = "0x1842E4180", Slot = "10")]
		protected override void LFGLBHDCMLI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private sealed class EOGJJLECEEL<T> : OCGDHNPKGKG<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override Task<T> ADMBNEIFAEN
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override HCGNNEJAOHI<T> PCBEFABIIFC
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x8657D0", Offset = "0x863DD0", VA = "0x1808657D0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x383AB90", Offset = "0x3839190", VA = "0x18383AB90")]
		public EOGJJLECEEL(Exception PHPBNDIBHHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "10")]
		protected override void LFGLBHDCMLI()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private sealed class OIBGJDDIGHB<T> : OCGDHNPKGKG<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[CompilerGenerated]
		private struct POFCDICGJAB : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			public Task<FMHOFFFMGIN<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			private TaskAwaiter<FMHOFFFMGIN<T>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			private TaskAwaiter<T> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x478E780", Offset = "0x478CD80", VA = "0x18478E780", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x478ECC0", Offset = "0x478D2C0", VA = "0x18478ECC0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[CompilerGenerated]
		private struct BGIJNMPKGAE : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			public Task<FMHOFFFMGIN<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			private TaskAwaiter<FMHOFFFMGIN<T>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x4E6EEB0", Offset = "0x4E6D4B0", VA = "0x184E6EEB0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x4E6F390", Offset = "0x4E6D990", VA = "0x184E6F390", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private readonly Task<FMHOFFFMGIN<T>> DABGOGHGHBB;

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override Task<T> ADMBNEIFAEN
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x8657D0", Offset = "0x863DD0", VA = "0x1808657D0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override HCGNNEJAOHI<T> PCBEFABIIFC
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x866520", Offset = "0x864B20", VA = "0x180866520", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x4671A30", Offset = "0x4670030", VA = "0x184671A30")]
		public OIBGJDDIGHB(Task<FMHOFFFMGIN<T>> PEBIPFJADEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x4671730", Offset = "0x466FD30", VA = "0x184671730", Slot = "10")]
		protected override void LFGLBHDCMLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x4671430", Offset = "0x466FA30", VA = "0x184671430")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(OIBGJDDIGHB<>.POFCDICGJAB))]
		internal static Task<T> KPMAODGMBPM(Task<FMHOFFFMGIN<T>> PEBIPFJADEI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x4671940", Offset = "0x466FF40", VA = "0x184671940")]
		[AsyncStateMachine(typeof(OIBGJDDIGHB<>.BGIJNMPKGAE))]
		[CompilerGenerated]
		internal static Task MEFFPPPGFLH(Task<FMHOFFFMGIN<T>> PEBIPFJADEI)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private sealed class ODFCPONFBPE<TIn, TOut> : OCGDHNPKGKG<TOut> where TIn : notnull where TOut : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[CompilerGenerated]
		private struct GLBKAKPKJFG : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			public AsyncTaskMethodBuilder<TOut> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			public Func<TIn, TOut> transformFunc;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			public Task<TIn> innerTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			private Func<TIn, TOut> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			private TaskAwaiter<TIn> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0x3D31430", Offset = "0x3D2FA30", VA = "0x183D31430", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x3D317B0", Offset = "0x3D2FDB0", VA = "0x183D317B0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private readonly FMHOFFFMGIN<TIn> GPMMNKJBPGD;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override Task<TOut> ADMBNEIFAEN
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x8657D0", Offset = "0x863DD0", VA = "0x1808657D0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override HCGNNEJAOHI<TOut> PCBEFABIIFC
		{
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x866520", Offset = "0x864B20", VA = "0x180866520", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x46619C0", Offset = "0x465FFC0", VA = "0x1846619C0")]
		public ODFCPONFBPE(FMHOFFFMGIN<TIn> GBHPFBOLEOG, Func<TIn, TOut> LGIPGOJHOED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x4661920", Offset = "0x465FF20", VA = "0x184661920", Slot = "10")]
		protected override void LFGLBHDCMLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x4661600", Offset = "0x465FC00", VA = "0x184661600")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(ODFCPONFBPE<, >.GLBKAKPKJFG))]
		internal static Task<TOut> KMFMIPKMNIB(Task<TIn> CBCFOFOIDKK, Func<TIn, TOut> LGIPGOJHOED)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x2AF3A40", Offset = "0x2AF2040", VA = "0x182AF3A40")]
	public static FMHOFFFMGIN<T> BHJAMJDAEMH<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x2AF3AC0", Offset = "0x2AF20C0", VA = "0x182AF3AC0")]
	public static FMHOFFFMGIN<T> LGMJFFKFMFI<T>(T HJBJAPKPPFA, [Optional] Action<T>? DPHFDCIPJAD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x291FA00", Offset = "0x291E000", VA = "0x18291FA00")]
	public static FMHOFFFMGIN<T> NBILMDDIICK<T>(Exception PHPBNDIBHHP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x291FA00", Offset = "0x291E000", VA = "0x18291FA00")]
	public static FMHOFFFMGIN<T> DFOPKHNBLJB<T>(Task<FMHOFFFMGIN<T>> PEBIPFJADEI) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x29248C0", Offset = "0x2922EC0", VA = "0x1829248C0")]
	public static FMHOFFFMGIN<TOut> ODNLGPAEKMF<TOut, TIn>(FMHOFFFMGIN<TIn> JNKGLDBBIBB, Func<TIn, TOut> LGIPGOJHOED) where TOut : notnull where TIn : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public abstract class OCGDHNPKGKG<T> : FMHOFFFMGIN<T>, EGGKBNFDHIC, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private static readonly string PNNKLLPFDLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private readonly AJJOLPGOGOH ELBCJPIIFCL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private bool KIHONPKCMEM;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public bool MENDGOLEHOE
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0xB8B450", Offset = "0xB89A50", VA = "0x180B8B450", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public abstract Task<T> ADMBNEIFAEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public abstract HCGNNEJAOHI<T> PCBEFABIIFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x465FE10", Offset = "0x465E410", VA = "0x18465FE10")]
	public OCGDHNPKGKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x465F9E0", Offset = "0x465DFE0", VA = "0x18465F9E0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void LFGLBHDCMLI();
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public abstract class NAEBCHGCLLJ<TTask, T> : OCGDHNPKGKG<T> where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class AFBJHGALBHB
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		private struct <<-ctor>g__AwaitThenTransformTaskResult|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			public TTask originalTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			public AFBJHGALBHB <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x354A6B0", Offset = "0x3548CB0", VA = "0x18354A6B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x354A980", Offset = "0x3548F80", VA = "0x18354A980", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public NAEBCHGCLLJ<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public AFBJHGALBHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x3CD25B0", Offset = "0x3CD0BB0", VA = "0x183CD25B0")]
		[AsyncStateMachine(typeof(NAEBCHGCLLJ<, >.AFBJHGALBHB.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> DJOCHNMFIGM(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private readonly Task<T> PEBIPFJADEI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	protected readonly CancellationTokenSource GKNCGENIMLH;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public override Task<T> ADMBNEIFAEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public override HCGNNEJAOHI<T> PCBEFABIIFC
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8657D0", Offset = "0x863DD0", VA = "0x1808657D0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x452F420", Offset = "0x452DA20", VA = "0x18452F420")]
	protected NAEBCHGCLLJ(TTask PEBIPFJADEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x452F3D0", Offset = "0x452D9D0", VA = "0x18452F3D0", Slot = "10")]
	protected override void LFGLBHDCMLI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract T NAOBMEPDGHG(TTask MAELDPCECFD);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	protected abstract void DNKELGKLJFP();
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class KELCFLLEPAG<T> : OCGDHNPKGKG<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly BCBDLBGONLF<Task<T>> KBHLJHOPICO;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public override Task<T> ADMBNEIFAEN
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x3C26800", Offset = "0x3C24E00", VA = "0x183C26800", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public override HCGNNEJAOHI<T> PCBEFABIIFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x8657D0", Offset = "0x863DD0", VA = "0x1808657D0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x41ECFE0", Offset = "0x41EB5E0", VA = "0x1841ECFE0")]
	public KELCFLLEPAG(BCBDLBGONLF<Task<T>> NBKPLIGNOED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x41ECFC0", Offset = "0x41EB5C0", VA = "0x1841ECFC0", Slot = "10")]
	protected override void LFGLBHDCMLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class KAGMKKEBLHO
{
	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x6910D80", Offset = "0x690F380", VA = "0x186910D80")]
	[NotNull]
	public static byte[] CJNHHIIEMNO(this DNNDDGNBNEI OOONJNFFKAA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x6910DF0", Offset = "0x690F3F0", VA = "0x186910DF0")]
	[NotNull]
	public static byte[] CJNHHIIEMNO(this DNNDDGNBNEI OOONJNFFKAA, HashAlgorithmName OHHOOMFBFJG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x6910E60", Offset = "0x690F460", VA = "0x186910E60")]
	public static bool LDBLDLIGFGB([CanBeNull] this DNNDDGNBNEI OOONJNFFKAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x6910FF0", Offset = "0x690F5F0", VA = "0x186910FF0")]
	public static bool LDBLDLIGFGB([CanBeNull] this DNNDDGNBNEI OOONJNFFKAA, [Out] string JCBCIJOKIDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x6911190", Offset = "0x690F790", VA = "0x186911190")]
	private static bool MKGAOBGJLCP([NotNull] DNNDDGNBNEI OOONJNFFKAA, [Out][CanBeNull] byte[] PADJINFDHCP, [Out][CanBeNull] byte[] FCJGLLAAABI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x200004F")]
public static class OKIIMIPNKLG
{
	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(RVA = "0x6912610", Offset = "0x6910C10", VA = "0x186912610")]
	[NotNull]
	public static byte[] CJNHHIIEMNO(this PCEOFOMKDKD CJMHHPHEDBE, HashAlgorithmName OHHOOMFBFJG, byte[] GICDBPGEGMN)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public interface PCEOFOMKDKD
{
	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash HBFGLPMFMGA);
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface DNNDDGNBNEI : PCEOFOMKDKD
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	[CanBeNull]
	byte[] BNFFHLEJONE
	{
		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	[CanBeNull]
	byte[] EAJBNADLLLA
	{
		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class CDEBIDLKMAN
{
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private static readonly ArrayPool<byte> CCGHKJAFNNO;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static bool INHFMPEJIBG;

	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x2917660", Offset = "0x2915C60", VA = "0x182917660")]
	public static void GBPHDEFJEDK<T>(this IncrementalHash DBKLKBAPPBJ, [CanBeNull] T ADPKHCOJMDE) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x2917720", Offset = "0x2915D20", VA = "0x182917720")]
	public static void NEFFNNDOHEG<T>(this IncrementalHash DBKLKBAPPBJ, [CanBeNull] T CJMHHPHEDBE) where T : PCEOFOMKDKD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(RVA = "0x2917140", Offset = "0x2915740", VA = "0x182917140")]
	public static void DMDNFHDOJAB<T>(this IncrementalHash DBKLKBAPPBJ, [CanBeNull] IList<T> FFDMHNMMJBO) where T : PCEOFOMKDKD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000173")]
	[Cpp2IlInjected.Address(RVA = "0x690F360", Offset = "0x690D960", VA = "0x18690F360")]
	private static bool AKDPBCHKGFK([CanBeNull] PCEOFOMKDKD CJMHHPHEDBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x690F980", Offset = "0x690DF80", VA = "0x18690F980")]
	public static void LAGINJNDHEN(this IncrementalHash HBFGLPMFMGA, [CanBeNull] string CKKOHDHLNOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x690F620", Offset = "0x690DC20", VA = "0x18690F620")]
	public static void FLEOOOJHBPE(this IncrementalHash HBFGLPMFMGA, long CMPFGKCKFBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x690F3F0", Offset = "0x690D9F0", VA = "0x18690F3F0")]
	public static void DEJKFPJEBME(this IncrementalHash HBFGLPMFMGA, int OFNCOECPHHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x690FAA0", Offset = "0x690E0A0", VA = "0x18690FAA0")]
	public static void MOJNNNCPKHH(this IncrementalHash HBFGLPMFMGA, short CHJMCIKMHCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x690FDE0", Offset = "0x690E3E0", VA = "0x18690FDE0")]
	public static void OCMHCOAJNGB(this IncrementalHash HBFGLPMFMGA, byte GKDCAJJJAHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x690FC70", Offset = "0x690E270", VA = "0x18690FC70")]
	public static void NGKOLNBODDE(this IncrementalHash HBFGLPMFMGA, bool PHPPJNGCHIL, bool PPIMALODFAD = false, bool LLNNBPMHEJP = false, bool GNHGADBIHIH = false, bool BJJGMJLJBJI = false, bool ONGGGIEINGG = false, bool OBDCILOBPEJ = false, bool MDOOABKDGBE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x29177B0", Offset = "0x2915DB0", VA = "0x1829177B0")]
	public static void NFJCELHDDFD<T>(this IncrementalHash HBFGLPMFMGA, T HEJFAMNFDIC) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x690F920", Offset = "0x690DF20", VA = "0x18690F920")]
	public static void KPDJPEDHOIM(this IncrementalHash HBFGLPMFMGA, float HMHJCDOJINH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x690F9E0", Offset = "0x690DFE0", VA = "0x18690F9E0")]
	public static void LLIGCOFDNEC(this IncrementalHash HBFGLPMFMGA, ulong DPHPDCIPPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x690F5C0", Offset = "0x690DBC0", VA = "0x18690F5C0")]
	public static void DOECGFMLDAJ(this IncrementalHash HBFGLPMFMGA, uint MCGOJDMCCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x690FA40", Offset = "0x690E040", VA = "0x18690FA40")]
	public static void MANLDPANDHO(this IncrementalHash HBFGLPMFMGA, ushort HHAFJGFBLMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x690F7F0", Offset = "0x690DDF0", VA = "0x18690F7F0")]
	public static void JEGDFMGKHFM(this IncrementalHash HBFGLPMFMGA, Vector3 GIIBLGKHAOA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public class MFMEFJPDNLF : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x69123F0", Offset = "0x69109F0", VA = "0x1869123F0")]
	public MFMEFJPDNLF(string NFOHONOFFAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public abstract class INFAELCLPHC<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000055")]
	internal class DMMCBDBDCJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CA")]
		public TNode OLDDCPCBGIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CB")]
		public TNode HHMPHBNGMGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CC")]
		public BABEIKLBGFG BMDINFODMJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CD")]
		public List<BABEIKLBGFG> ALGAJJDIKFB;

		[Cpp2IlInjected.Token(Token = "0x6000196")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public DMMCBDBDCJE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000056")]
	internal struct BABEIKLBGFG : IComparable<BABEIKLBGFG>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CE")]
		public int NPMDLCEJBKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000CF")]
		public TClaimant HOIIPDJHIKH;

		[Cpp2IlInjected.Token(Token = "0x6000197")]
		[Cpp2IlInjected.Address(RVA = "0xD985F0", Offset = "0xD96BF0", VA = "0x180D985F0")]
		public BABEIKLBGFG(int NPMDLCEJBKO, TClaimant HOIIPDJHIKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000198")]
		[Cpp2IlInjected.Address(RVA = "0x4E41290", Offset = "0x4E3F890", VA = "0x184E41290")]
		public bool LAMFCFLDJCH([In] BABEIKLBGFG LJAAPFIIPOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000199")]
		[Cpp2IlInjected.Address(RVA = "0x4E41280", Offset = "0x4E3F880", VA = "0x184E41280")]
		public bool IEEJEMKLJNC([In] BABEIKLBGFG LJAAPFIIPOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600019A")]
		[Cpp2IlInjected.Address(RVA = "0x4E41270", Offset = "0x4E3F870", VA = "0x184E41270", Slot = "4")]
		public int CompareTo(BABEIKLBGFG LJAAPFIIPOF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x600019B")]
		[Cpp2IlInjected.Address(RVA = "0x4E412F0", Offset = "0x4E3F8F0", VA = "0x184E412F0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000057")]
	public enum KMNCJBJKGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	[CompilerGenerated]
	private sealed class AOOCDFBBOIE : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D7")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		public INFAELCLPHC<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600019F")]
			[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001A1")]
			[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600019C")]
		[Cpp2IlInjected.Address(RVA = "0x8BC660", Offset = "0x8BAC60", VA = "0x1808BC660")]
		[DebuggerHidden]
		public AOOCDFBBOIE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019D")]
		[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x3E7E0E0", Offset = "0x3E7C6E0", VA = "0x183E7E0E0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x3E7E2C0", Offset = "0x3E7C8C0", VA = "0x183E7E2C0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x3E7E1C0", Offset = "0x3E7C7C0", VA = "0x183E7E1C0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x396B0E0", Offset = "0x39696E0", VA = "0x18396B0E0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	private static readonly DKMDBKIJEFM<DMMCBDBDCJE> DBDMMILNJAF;

	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static readonly DKMDBKIJEFM<List<BABEIKLBGFG>> KGHPBONCHHF;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static int KMEOGCMHOFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	internal readonly Dictionary<TClaimant, TNode> LNMOBNIMNCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	internal readonly Dictionary<TNode, DMMCBDBDCJE> ILDPJJHGGMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private KMNCJBJKGLJ LAHMDGOAKPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C9")]
	private bool MMNAIEEGDFD;

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode NEBBPAGEGKE(TNode MPJOKOKILNG);

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void LHILHJPLLPE(TNode MPJOKOKILNG, TClaimant JFMFKMBDOFI, TClaimant AIDKEDKFFBA);

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x3EC4180", Offset = "0x3EC2780", VA = "0x183EC4180")]
	public INFAELCLPHC(KMNCJBJKGLJ LAHMDGOAKPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x3EC32E0", Offset = "0x3EC18E0", VA = "0x183EC32E0")]
	public void IGJFNKOECBO(TNode MPJOKOKILNG, TNode NAEADMGDGFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x3EC2800", Offset = "0x3EC0E00", VA = "0x183EC2800")]
	public void DAGFJCKCIAF(TClaimant HOIIPDJHIKH, TNode PKBOBNEDJDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x3EC29A0", Offset = "0x3EC0FA0", VA = "0x183EC29A0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x3EC2BD0", Offset = "0x3EC11D0", VA = "0x183EC2BD0")]
	private void EEPFLNGCOPH(TClaimant HOIIPDJHIKH, TNode BFIAACADPHE, TNode PKBOBNEDJDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x3EC3270", Offset = "0x3EC1870", VA = "0x183EC3270")]
	private int HKCKLLMGCNH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x3EC33B0", Offset = "0x3EC19B0", VA = "0x183EC33B0")]
	private void KPCKGAKHOJF(TClaimant HOIIPDJHIKH, TNode HMFDFHFCKOK, TNode OIEOMIHHCCH, int OKDJKMDHJGO = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x3EC3A00", Offset = "0x3EC2000", VA = "0x183EC3A00")]
	private void NFKDFOOHNCG(BABEIKLBGFG BOPEKCLNHDH, DMMCBDBDCJE LFGOPFNHKKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x3EC2F70", Offset = "0x3EC1570", VA = "0x183EC2F70")]
	private void GJNOKMBKKOF(TClaimant HOIIPDJHIKH, TNode HMFDFHFCKOK, TNode OIEOMIHHCCH, int OKDJKMDHJGO = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x3EC3E50", Offset = "0x3EC2450", VA = "0x183EC3E50")]
	private void OEFCEJAKDLH(BABEIKLBGFG BOPEKCLNHDH, TNode MPJOKOKILNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x3EC2CA0", Offset = "0x3EC12A0", VA = "0x183EC2CA0")]
	private void EIOFDAEDALL(BABEIKLBGFG BOPEKCLNHDH, DMMCBDBDCJE LFGOPFNHKKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x3EC2E10", Offset = "0x3EC1410", VA = "0x183EC2E10")]
	private void GBBHICHNAFK(DMMCBDBDCJE LFGOPFNHKKH, bool JPIHGDGKHKI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x3EC3AE0", Offset = "0x3EC20E0", VA = "0x183EC3AE0")]
	private void NOBGOIJOOCD(DMMCBDBDCJE LFGOPFNHKKH, TNode NAEADMGDGFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x3EC2700", Offset = "0x3EC0D00", VA = "0x183EC2700")]
	[IteratorStateMachine(typeof(INFAELCLPHC<, >.AOOCDFBBOIE))]
	private IEnumerable<TNode> CGNGOJNEEAH(TNode HMFDFHFCKOK, TNode OIEOMIHHCCH, bool CNFGDMMICAA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x3EC38E0", Offset = "0x3EC1EE0", VA = "0x183EC38E0")]
	private DMMCBDBDCJE NELPMHNDHLH(TNode MPJOKOKILNG, TNode HHMPHBNGMGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x3EC2570", Offset = "0x3EC0B70", VA = "0x183EC2570")]
	private DMMCBDBDCJE APNDBOMBPEL(TNode MPJOKOKILNG, TNode HHMPHBNGMGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x3EC3710", Offset = "0x3EC1D10", VA = "0x183EC3710")]
	private void LBMPBAHAFLC(DMMCBDBDCJE LFGOPFNHKKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class POKEMGHGOGK<T> : IEnumerable<POKEMGHGOGK<T>.NMFDIEPGDOH>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200005A")]
	public struct NMFDIEPGDOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		public T CBAEIEAPLIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public int LLPJHIPCNFD;
	}

	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public class MCMOPNPPABO : IEnumerator<NMFDIEPGDOH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E4")]
		private POKEMGHGOGK<T> JFPGMJFEBIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E5")]
		private int LLPJHIPCNFD;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001B4")]
			[Cpp2IlInjected.Address(RVA = "0x384AAE0", Offset = "0x38490E0", VA = "0x18384AAE0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public NMFDIEPGDOH NKNICMABPJA
		{
			[Cpp2IlInjected.Token(Token = "0x60001B5")]
			[Cpp2IlInjected.Address(RVA = "0x44B39B0", Offset = "0x44B1FB0", VA = "0x1844B39B0", Slot = "4")]
			get
			{
				return default(NMFDIEPGDOH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001B6")]
		[Cpp2IlInjected.Address(RVA = "0x44B38C0", Offset = "0x44B1EC0", VA = "0x1844B38C0")]
		public MCMOPNPPABO(POKEMGHGOGK<T> JFPGMJFEBIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B7")]
		[Cpp2IlInjected.Address(RVA = "0x44B3840", Offset = "0x44B1E40", VA = "0x1844B3840", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001B8")]
		[Cpp2IlInjected.Address(RVA = "0x389E7E0", Offset = "0x389CDE0", VA = "0x18389E7E0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001B9")]
		[Cpp2IlInjected.Address(RVA = "0x938EE0", Offset = "0x9374E0", VA = "0x180938EE0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	private struct PPBBCDOLDJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E6")]
		public bool AJAPEAEMNGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E7")]
		public T CBAEIEAPLIH;
	}

	[Cpp2IlInjected.Token(Token = "0x40000DD")]
	private const int LLDCFEHMCCG = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private readonly Dictionary<T, int> LENGGCPEAHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private PPBBCDOLDJL[] BAMOACLFMDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E0")]
	private int LPGNCNHMEAM;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public int EGHJDBFBCCK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x8A1FC0", Offset = "0x8A05C0", VA = "0x1808A1FC0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x8A1DF0", Offset = "0x8A03F0", VA = "0x1808A1DF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public int FGAKKPCAMNO
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x355CD00", Offset = "0x355B300", VA = "0x18355CD00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001A7")]
	[Cpp2IlInjected.Address(RVA = "0x4790210", Offset = "0x478E810", VA = "0x184790210")]
	public POKEMGHGOGK(int NAFKLJDAKHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A8")]
	[Cpp2IlInjected.Address(RVA = "0x4790300", Offset = "0x478E900", VA = "0x184790300")]
	public POKEMGHGOGK(NMFDIEPGDOH[] OECAFMGFKCI, bool HGFNPMIOACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001A9")]
	[Cpp2IlInjected.Address(RVA = "0x478F430", Offset = "0x478DA30", VA = "0x18478F430")]
	public int GPMKHPLAPFG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AA")]
	[Cpp2IlInjected.Address(RVA = "0x478F170", Offset = "0x478D770", VA = "0x18478F170")]
	private int DGBHBAFDBLD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AB")]
	[Cpp2IlInjected.Address(RVA = "0x478F610", Offset = "0x478DC10", VA = "0x18478F610", Slot = "6")]
	protected virtual uint KOJPGJKIHIL(uint HBFGLPMFMGA, T CBAEIEAPLIH)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x478F670", Offset = "0x478DC70", VA = "0x18478F670")]
	public bool OPOGKFMEAHP(T CBAEIEAPLIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x478F500", Offset = "0x478DB00", VA = "0x18478F500")]
	public int INDADLDEPLA(T CBAEIEAPLIH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x478EEE0", Offset = "0x478D4E0", VA = "0x18478EEE0")]
	public T CMHCDGKNPKK(int LLPJHIPCNFD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x478FC50", Offset = "0x478E250", VA = "0x18478FC50")]
	public bool PFKIIIIKFDA(T CBAEIEAPLIH, bool BMGIBDDFKFD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x478F9E0", Offset = "0x478DFE0", VA = "0x18478F9E0")]
	public bool PFKIIIIKFDA(T CBAEIEAPLIH, int LLPJHIPCNFD, bool BMGIBDDFKFD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x478F3E0", Offset = "0x478D9E0", VA = "0x18478F3E0")]
	private int ECMHHPJCFIP(int GEIGDPFELPO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x478FD20", Offset = "0x478E320", VA = "0x18478FD20", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x478FD20", Offset = "0x478E320", VA = "0x18478FD20", Slot = "4")]
	private IEnumerator<NMFDIEPGDOH> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005D")]
public class DKMDBKIJEFM<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	private readonly Stack<T> LELPBFPMPGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private readonly List<T> MOBIOIJHMJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private readonly int MLFJOKLMFNK;

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x582EBA0", Offset = "0x582D1A0", VA = "0x18582EBA0")]
	public static DKMDBKIJEFM<T> EGKLNGNLINK(int NAFKLJDAKHD = 0, int MLFJOKLMFNK = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x582F050", Offset = "0x582D650", VA = "0x18582F050")]
	public static DKMDBKIJEFM<T> KBGAOIMKKPI(int NAFKLJDAKHD = 0, int MLFJOKLMFNK = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BC")]
	[Cpp2IlInjected.Address(RVA = "0x582F250", Offset = "0x582D850", VA = "0x18582F250")]
	public DKMDBKIJEFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BD")]
	[Cpp2IlInjected.Address(RVA = "0x582F2A0", Offset = "0x582D8A0", VA = "0x18582F2A0")]
	public DKMDBKIJEFM(int NAFKLJDAKHD, int MLFJOKLMFNK = int.MaxValue, bool HANIHNJCOGC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001BE")]
	[Cpp2IlInjected.Address(RVA = "0x582E9E0", Offset = "0x582CFE0", VA = "0x18582E9E0")]
	public T EBAPBDCJHHO()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x582ECA0", Offset = "0x582D2A0", VA = "0x18582ECA0")]
	public void HLGENIPLFCF(T CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x582F150", Offset = "0x582D750", VA = "0x18582F150")]
	private void KHPJLAACEAL(T CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x582ED80", Offset = "0x582D380", VA = "0x18582ED80")]
	private void IBLCILDMDII(T CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x582E850", Offset = "0x582CE50", VA = "0x18582E850", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x582EDD0", Offset = "0x582D3D0", VA = "0x18582EDD0")]
	private void IPAGLIBOPOG(IEnumerable<T> CNNODMDOLAC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public class FOFJOCGLDFI<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EB")]
	private Dictionary<int, T> OLGJECBHAKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EC")]
	private T EICDBNPOLLD;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public virtual T HONNLEHENLK
	{
		[Cpp2IlInjected.Token(Token = "0x60001C4")]
		[Cpp2IlInjected.Address(RVA = "0x866510", Offset = "0x864B10", VA = "0x180866510", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001C5")]
		[Cpp2IlInjected.Address(RVA = "0x864DF0", Offset = "0x8633F0", VA = "0x180864DF0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x3C80800", Offset = "0x3C7EE00", VA = "0x183C80800")]
	public bool PBGBCGOCNGM(T CBAEIEAPLIH, int NPMDLCEJBKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x3C80430", Offset = "0x3C7EA30", VA = "0x183C80430")]
	public bool JHPDIDIEFLE(int NPMDLCEJBKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x3C80AC0", Offset = "0x3C7F0C0", VA = "0x183C80AC0")]
	public T PEHIIINHNFH(int FKEFBODPAFA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x3C80540", Offset = "0x3C7EB40", VA = "0x183C80540")]
	private bool OHFJJEKHMLL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x3C804E0", Offset = "0x3C7EAE0", VA = "0x183C804E0")]
	public bool MMCLNKMOKEF(int NPMDLCEJBKO, [Out] T CBAEIEAPLIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x3C80CC0", Offset = "0x3C7F2C0", VA = "0x183C80CC0")]
	public FOFJOCGLDFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class HBPMCKBOIAG<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000060")]
	protected struct CKEPMNAOKDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public T BLBBIKKJHJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public int FCJPGHMLOML;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000ED")]
	protected readonly List<CKEPMNAOKDG> LCIJAGELCDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EE")]
	private T MEFCCJKJJDO;

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public int FGAKKPCAMNO
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x355CD00", Offset = "0x355B300", VA = "0x18355CD00")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x3DB04B0", Offset = "0x3DAEAB0", VA = "0x183DB04B0")]
	public bool PMELAKIMKGE(T CBAEIEAPLIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x3DAFEE0", Offset = "0x3DAE4E0", VA = "0x183DAFEE0")]
	public void MJFEDCBJOBF(T CBAEIEAPLIH, int NPMDLCEJBKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x3DAFA60", Offset = "0x3DAE060", VA = "0x183DAFA60")]
	public bool GAGDAFIMOPK(T CBAEIEAPLIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x3DAFFA0", Offset = "0x3DAE5A0", VA = "0x183DAFFA0")]
	public void OAIAOCAHOEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x3DAF9B0", Offset = "0x3DADFB0", VA = "0x183DAF9B0")]
	public T ANFJKGOCCNE()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x3DB01B0", Offset = "0x3DAE7B0", VA = "0x183DB01B0")]
	protected void PEECCLCNBKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x3DB06E0", Offset = "0x3DAECE0", VA = "0x183DB06E0")]
	public HBPMCKBOIAG()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F1")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		[AIILLFBIOKD(CKKEEFADMDD.Self, false, false, false)]
		[SerializeField]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60001D4")]
			[Cpp2IlInjected.Address(RVA = "0x6912990", Offset = "0x6910F90", VA = "0x186912990")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001D5")]
			[Cpp2IlInjected.Address(RVA = "0x6912C60", Offset = "0x6911260", VA = "0x186912C60")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60001D6")]
			[Cpp2IlInjected.Address(RVA = "0x6912B70", Offset = "0x6911170", VA = "0x186912B70")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60001D7")]
			[Cpp2IlInjected.Address(RVA = "0x69128E0", Offset = "0x6910EE0", VA = "0x1869128E0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60001D8")]
			[Cpp2IlInjected.Address(RVA = "0x6912BB0", Offset = "0x69111B0", VA = "0x186912BB0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60001D9")]
			[Cpp2IlInjected.Address(RVA = "0x6912AC0", Offset = "0x69110C0", VA = "0x186912AC0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001DA")]
		[Cpp2IlInjected.Address(RVA = "0x6912850", Offset = "0x6910E50", VA = "0x186912850")]
		public ReferencePoint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	public abstract class ResourcePrefabReference<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60001DB")]
		[Cpp2IlInjected.Address(RVA = "0x4945E20", Offset = "0x4944420", VA = "0x184945E20", Slot = "4")]
		public virtual T AAJDLNJKMEF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001DC")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public class LAFPMBLNGOO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x40000FB")]
	private Dictionary<byte, JONJLFJIMBK> JJDIEHCEOPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000FC")]
	private readonly DKMDBKIJEFM<JONJLFJIMBK> KNKFEMPKPLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x40000FD")]
	private readonly bool PCIBDJDJLCI;

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public JONJLFJIMBK EGNFKMGGDNB
	{
		[Cpp2IlInjected.Token(Token = "0x60001DD")]
		[Cpp2IlInjected.Address(RVA = "0x8657C0", Offset = "0x863DC0", VA = "0x1808657C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001DE")]
		[Cpp2IlInjected.Address(RVA = "0x8657E0", Offset = "0x863DE0", VA = "0x1808657E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public Vector2 IMKJAGFMKPE
	{
		[Cpp2IlInjected.Token(Token = "0x60001DF")]
		[Cpp2IlInjected.Address(RVA = "0xD35E50", Offset = "0xD34450", VA = "0x180D35E50")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E0")]
		[Cpp2IlInjected.Address(RVA = "0x1015E30", Offset = "0x1014430", VA = "0x181015E30")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	private Vector2 KNNFPOHPLBG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E1")]
		[Cpp2IlInjected.Address(RVA = "0x107B940", Offset = "0x1079F40", VA = "0x18107B940")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public Vector2 AOFCHLKOPOG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x6911370", Offset = "0x690F970", VA = "0x186911370")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x86CF00", Offset = "0x86B500", VA = "0x18086CF00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public int CDCHHNENAFN
	{
		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x86E1C0", Offset = "0x86C7C0", VA = "0x18086E1C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x86DC60", Offset = "0x86C260", VA = "0x18086DC60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001E6")]
	[Cpp2IlInjected.Address(RVA = "0x6912270", Offset = "0x6910870", VA = "0x186912270")]
	public LAFPMBLNGOO(Bounds ENKDCGIMNDP, Vector2[] PJJIPKDGHPH, int EPILGPKFIEO, byte GEIGDPFELPO, float PGJDDCEFNGO = 0f, [Optional] DKMDBKIJEFM<JONJLFJIMBK> KNKFEMPKPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E7")]
	[Cpp2IlInjected.Address(RVA = "0x6911DD0", Offset = "0x69103D0", VA = "0x186911DD0")]
	public void OOGFFGLNAAK(Bounds ENKDCGIMNDP, Vector2[] PJJIPKDGHPH, int EPILGPKFIEO, byte GEIGDPFELPO, float PGJDDCEFNGO = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001E8")]
	[Cpp2IlInjected.Address(RVA = "0x69112B0", Offset = "0x690F8B0", VA = "0x1869112B0")]
	public JONJLFJIMBK DJMBNPDGGNN(byte LLPJHIPCNFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E9")]
	[Cpp2IlInjected.Address(RVA = "0x69115C0", Offset = "0x690FBC0", VA = "0x1869115C0")]
	public void FKJPIIJCPGJ(Vector3 MOIICCIPACK, float BPAGEBDGFKJ, float AEOLGPMGKGH, List<byte> NPMODPFBIBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EA")]
	[Cpp2IlInjected.Address(RVA = "0x6911690", Offset = "0x690FC90", VA = "0x186911690")]
	public void FNEGPKLPAIL(JONJLFJIMBK.AFGMJBOPCMJ NBFJLICFPFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EB")]
	[Cpp2IlInjected.Address(RVA = "0x6911CE0", Offset = "0x69102E0", VA = "0x186911CE0")]
	public static int ONGIFNKMLNC(Vector2[] PJJIPKDGHPH, int EPILGPKFIEO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001EC")]
	[Cpp2IlInjected.Address(RVA = "0x6911390", Offset = "0x690F990", VA = "0x186911390")]
	private JONJLFJIMBK EJNHCINBENB(byte LLPJHIPCNFD, JONJLFJIMBK.ONBDKIKDMGH DNHPFFOEEHL, JONJLFJIMBK HHMPHBNGMGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001ED")]
	[Cpp2IlInjected.Address(RVA = "0x6911930", Offset = "0x690FF30", VA = "0x186911930")]
	private void MKJJPBCABOK(JONJLFJIMBK HHMPHBNGMGF, Vector2[] PJJIPKDGHPH, int FNLCJEELAEJ, int JFBPLADNENM, int FFIDMODDNBO, int NCPBIFDMNBM, float PGJDDCEFNGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x6911710", Offset = "0x690FD10", VA = "0x186911710")]
	private void MJNKLIGAOML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x6911310", Offset = "0x690F910", VA = "0x186911310", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x69116B0", Offset = "0x690FCB0", VA = "0x1869116B0", Slot = "1")]
	~LAFPMBLNGOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000064")]
public class JONJLFJIMBK
{
	[Cpp2IlInjected.Token(Token = "0x2000065")]
	public enum ONBDKIKDMGH
	{
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000109")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x400010A")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public enum AFGMJBOPCMJ
	{
		[Cpp2IlInjected.Token(Token = "0x400010C")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x400010D")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x400010E")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	public byte FDMEMBGGBHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	public Vector3 PGGBDIGHJFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	public Vector3 PMILGDKKIIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	public Vector3 BGMPDHODCNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	public Vector3 HJGJMIBPKHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	public ONBDKIKDMGH HHOOFCPEKDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	public JONJLFJIMBK EGEBOODOFAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public List<JONJLFJIMBK> IGBHKOEONFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public bool COMMBDLAOKO;

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x6910D60", Offset = "0x690F360", VA = "0x186910D60")]
	public JONJLFJIMBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x6910BC0", Offset = "0x690F1C0", VA = "0x186910BC0")]
	public void GAMMKDIBDLH(JONJLFJIMBK FLFKBMMIINC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x863350", Offset = "0x861950", VA = "0x180863350")]
	public void FNEGPKLPAIL(int BEHDJHJCKHM, AFGMJBOPCMJ NBFJLICFPFP, int LEKBLIFLCLN = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x6910960", Offset = "0x690EF60", VA = "0x186910960")]
	public void FKJPIIJCPGJ(List<byte> NPMODPFBIBJ, Vector3 MOIICCIPACK, float BPAGEBDGFKJ, float AEOLGPMGKGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x6910D30", Offset = "0x690F330", VA = "0x186910D30")]
	public bool ODOFBNDEKHK(Vector3 BJEINPMOICP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x6910D00", Offset = "0x690F300", VA = "0x186910D00")]
	public bool GPHPEGIHHJC(Vector3 BJEINPMOICP, float JNADDPDGDFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x69108D0", Offset = "0x690EED0", VA = "0x1869108D0")]
	public void BGGINNGCCML()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x2000068")]
		public struct BFCNMAKKHCA<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000114")]
			private readonly List<Component> DNOAHHGKGFF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000115")]
			private readonly bool MECPBBLPKPA;

			[Cpp2IlInjected.Token(Token = "0x6000204")]
			[Cpp2IlInjected.Address(RVA = "0x3D20E20", Offset = "0x3D1F420", VA = "0x183D20E20")]
			public BFCNMAKKHCA(List<Component> DNOAHHGKGFF, bool MECPBBLPKPA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000205")]
			[Cpp2IlInjected.Address(RVA = "0x4E54250", Offset = "0x4E52850", VA = "0x184E54250")]
			public AMHLNHBPGEC<T> AKHPNFMFJMK()
			{
				return default(AMHLNHBPGEC<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000206")]
			[Cpp2IlInjected.Address(RVA = "0x4E542C0", Offset = "0x4E528C0", VA = "0x184E542C0", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000207")]
			[Cpp2IlInjected.Address(RVA = "0x4E542C0", Offset = "0x4E528C0", VA = "0x184E542C0", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000069")]
		public struct AMHLNHBPGEC<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000116")]
			private readonly List<Component> DNOAHHGKGFF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000117")]
			private readonly bool MECPBBLPKPA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000118")]
			private int LLPJHIPCNFD;

			[Cpp2IlInjected.Token(Token = "0x1700005E")]
			public T NKNICMABPJA
			{
				[Cpp2IlInjected.Token(Token = "0x6000209")]
				[Cpp2IlInjected.Address(RVA = "0x3E75F70", Offset = "0x3E74570", VA = "0x183E75F70", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600020A")]
				[Cpp2IlInjected.Address(RVA = "0x3E75F00", Offset = "0x3E74500", VA = "0x183E75F00", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000208")]
			[Cpp2IlInjected.Address(RVA = "0x3E75F40", Offset = "0x3E74540", VA = "0x183E75F40")]
			public AMHLNHBPGEC(List<Component> DNOAHHGKGFF, bool MECPBBLPKPA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020B")]
			[Cpp2IlInjected.Address(RVA = "0x3E75E40", Offset = "0x3E74440", VA = "0x183E75E40", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x3E75E50", Offset = "0x3E74450", VA = "0x183E75E50", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x38914A0", Offset = "0x388FAA0", VA = "0x1838914A0", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x60001F8")]
			[Cpp2IlInjected.Address(RVA = "0x69146B0", Offset = "0x6912CB0", VA = "0x1869146B0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001F9")]
		[Cpp2IlInjected.Address(RVA = "0x86B790", Offset = "0x869D90", VA = "0x18086B790")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FA")]
		[Cpp2IlInjected.Address(RVA = "0x6913FD0", Offset = "0x69125D0", VA = "0x186913FD0")]
		private void BGGINNGCCML(GameObject EFDDHMOHOKH, bool BAKDLGCFEEB = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FB")]
		[Cpp2IlInjected.Address(RVA = "0x6914140", Offset = "0x6912740", VA = "0x186914140")]
		public static void BGGINNGCCML(GameObject EFDDHMOHOKH, ToolHierarchyCache AMAMLMNLJEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FC")]
		[Cpp2IlInjected.Address(RVA = "0x6914610", Offset = "0x6912C10", VA = "0x186914610")]
		public void PMBGKANLDAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FD")]
		[Cpp2IlInjected.Address(RVA = "0x2E26580", Offset = "0x2E24B80", VA = "0x182E26580")]
		public void JALBOCHMIPI<T>(Action<T> OGLJLDNLGIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001FE")]
		[Cpp2IlInjected.Address(RVA = "0x2E26420", Offset = "0x2E24A20", VA = "0x182E26420")]
		public T EIGKBHBFDCJ<T>(bool MECPBBLPKPA = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001FF")]
		[Cpp2IlInjected.Address(RVA = "0x2E264C0", Offset = "0x2E24AC0", VA = "0x182E264C0")]
		public BFCNMAKKHCA<T> IDJDBADHHEI<T>(bool MECPBBLPKPA = false) where T : class
		{
			return default(BFCNMAKKHCA<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000200")]
		[Cpp2IlInjected.Address(RVA = "0x69141D0", Offset = "0x69127D0", VA = "0x1869141D0")]
		public List<Component> CJBKIHCMKJH(Type PBLNJHEPKAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x6914520", Offset = "0x6912B20", VA = "0x186914520", Slot = "4")]
		public bool Equals(ToolHierarchyCache OOALEDCPNBJ, ToolHierarchyCache HDFOCKKCOOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x69145A0", Offset = "0x6912BA0", VA = "0x1869145A0", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache HBFCGFKGCAF)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006A")]
public class JELPAGKGOPA<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000119")]
	private int NAFKLJDAKHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011A")]
	private int JEAOFIHABKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011B")]
	private List<T> FOGJCPKBILL;

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public int FGAKKPCAMNO
	{
		[Cpp2IlInjected.Token(Token = "0x600020E")]
		[Cpp2IlInjected.Address(RVA = "0x3C26800", Offset = "0x3C24E00", VA = "0x183C26800")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public T AOODDNLKEHF
	{
		[Cpp2IlInjected.Token(Token = "0x600020F")]
		[Cpp2IlInjected.Address(RVA = "0x407B950", Offset = "0x4079F50", VA = "0x18407B950")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public T IMIJMGLDOAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0x407B320", Offset = "0x4079920", VA = "0x18407B320")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public T BEMPDGJHIEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0x407B410", Offset = "0x4079A10", VA = "0x18407B410")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x407BB00", Offset = "0x407A100", VA = "0x18407BB00")]
	public JELPAGKGOPA(int NAFKLJDAKHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x407B610", Offset = "0x4079C10", VA = "0x18407B610")]
	public void MJFEDCBJOBF(T NIBEIDMELHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x407B8F0", Offset = "0x4079EF0", VA = "0x18407B8F0")]
	public void OAIAOCAHOEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x407B4A0", Offset = "0x4079AA0", VA = "0x18407B4A0")]
	public void KEIDJNNFHMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x407B5A0", Offset = "0x4079BA0", VA = "0x18407B5A0")]
	public void LBGBECMFECD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x407B490", Offset = "0x4079A90", VA = "0x18407B490")]
	public void KCNNJPKBAHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006B")]
public class BBAKHMHBGDD<T>
{
	[Cpp2IlInjected.Token(Token = "0x200006C")]
	private struct DDKIFJGBJEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000120")]
		public int FCJPGHMLOML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000121")]
		public T BLBBIKKJHJE;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011C")]
	private readonly Dictionary<object, DDKIFJGBJEB> OLGJECBHAKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011D")]
	private readonly EqualityComparer<T> MIFDEBLGINO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400011E")]
	private T EICDBNPOLLD;

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public virtual T HONNLEHENLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x8D47A0", Offset = "0x8D2DA0", VA = "0x1808D47A0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x4E46890", Offset = "0x4E44E90", VA = "0x184E46890", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public bool OFLLKLACFCI
	{
		[Cpp2IlInjected.Token(Token = "0x600021A")]
		[Cpp2IlInjected.Address(RVA = "0x4E46820", Offset = "0x4E44E20", VA = "0x184E46820")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public object DANIGNPKJBG
	{
		[Cpp2IlInjected.Token(Token = "0x600021B")]
		[Cpp2IlInjected.Address(RVA = "0x865820", Offset = "0x863E20", VA = "0x180865820")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600021C")]
		[Cpp2IlInjected.Address(RVA = "0x865800", Offset = "0x863E00", VA = "0x180865800")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x4E4A060", Offset = "0x4E48660", VA = "0x184E4A060")]
	public bool PBGBCGOCNGM(T CBAEIEAPLIH, object OEDJKICDDGA, int NPMDLCEJBKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x4E46760", Offset = "0x4E44D60", VA = "0x184E46760")]
	public bool JHPDIDIEFLE(object OEDJKICDDGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x4E46E90", Offset = "0x4E45490", VA = "0x184E46E90")]
	public bool MMCLNKMOKEF(object OEDJKICDDGA, [Out] T CBAEIEAPLIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000220")]
	[Cpp2IlInjected.Address(RVA = "0x3DCDF50", Offset = "0x3DCC550", VA = "0x183DCDF50")]
	public void OAIAOCAHOEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000221")]
	[Cpp2IlInjected.Address(RVA = "0x4E48940", Offset = "0x4E46F40", VA = "0x184E48940")]
	private bool OHFJJEKHMLL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000222")]
	[Cpp2IlInjected.Address(RVA = "0x4E4AD70", Offset = "0x4E49370", VA = "0x184E4AD70")]
	public BBAKHMHBGDD()
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
