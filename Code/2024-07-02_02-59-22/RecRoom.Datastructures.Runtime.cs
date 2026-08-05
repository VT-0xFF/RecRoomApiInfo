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
		[Cpp2IlInjected.Address(RVA = "0x88F9F0", Offset = "0x88E9F0", VA = "0x18088F9F0")]
		public EmbeddedAttribute()
		{
		}
	}
}
namespace System.Runtime.CompilerServices
{
	[Cpp2IlInjected.Token(Token = "0x2000003")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Parameter | AttributeTargets.ReturnValue | AttributeTargets.GenericParameter, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000001")]
		public readonly byte[] NullableFlags;

		[Cpp2IlInjected.Token(Token = "0x6000002")]
		[Cpp2IlInjected.Address(RVA = "0x6945340", Offset = "0x6944340", VA = "0x186945340")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x890740", Offset = "0x88F740", VA = "0x180890740")]
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
		[Cpp2IlInjected.Address(RVA = "0x890780", Offset = "0x88F780", VA = "0x180890780")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class GJKJCLJLDLA : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x14E9870", Offset = "0x14E8870", VA = "0x1814E9870")]
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
		[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x867DF0", Offset = "0x866DF0", VA = "0x180867DF0", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8687D0", Offset = "0x8677D0", VA = "0x1808687D0", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x867E00", Offset = "0x866E00", VA = "0x180867E00", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9322F0", Offset = "0x9312F0", VA = "0x1809322F0", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash HBFGLPMFMGA);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8D0B80", Offset = "0x8CFB80", VA = "0x1808D0B80")]
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
		[Cpp2IlInjected.Address(RVA = "0x69469A0", Offset = "0x69459A0", VA = "0x1869469A0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x6946960", Offset = "0x6945960", VA = "0x186946960")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x69469E0", Offset = "0x69459E0", VA = "0x1869469E0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x6946B90", Offset = "0x6945B90", VA = "0x186946B90")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x6946B00", Offset = "0x6945B00", VA = "0x186946B00")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8D0B70", Offset = "0x8CFB70", VA = "0x1808D0B70")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8D0B30", Offset = "0x8CFB30", VA = "0x1808D0B30")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x6946920", Offset = "0x6945920", VA = "0x186946920")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x6946A70", Offset = "0x6945A70", VA = "0x186946A70")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x6946610", Offset = "0x6945610", VA = "0x186946610")]
	public void CopyBounds(SavedExtents LJAAPFIIPOF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x6946870", Offset = "0x6945870", VA = "0x186946870")]
	public void SetLocalSpaceBounds(Bounds BIKGCKJDAPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xBAFCC0", Offset = "0xBAECC0", VA = "0x180BAFCC0")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x6946860", Offset = "0x6945860", VA = "0x186946860")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x6945DE0", Offset = "0x6944DE0", VA = "0x186945DE0")]
	private void AFAJHALGKLE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x6946640", Offset = "0x6945640", VA = "0x186946640")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x6945FA0", Offset = "0x6944FA0", VA = "0x186945FA0")]
	public static void CalculateLocalBoundsFor(GameObject INALOLPJOHI, [Out] Bounds BIKGCKJDAPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x6945D20", Offset = "0x6944D20", VA = "0x186945D20")]
	private static void AANLFLCFCMP(Bounds HEOHCJKCOLM, Color DDKEAFEIAAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x6946890", Offset = "0x6945890", VA = "0x186946890")]
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
		[Cpp2IlInjected.Address(RVA = "0x8651A0", Offset = "0x8641A0", VA = "0x1808651A0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x86A850", Offset = "0x869850", VA = "0x18086A850")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xFDEFF0", Offset = "0xFDDFF0", VA = "0x180FDEFF0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x49A8B60", Offset = "0x49A7B60", VA = "0x1849A8B60")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "4")]
	public virtual void EBDGCJOMMDP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
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
	[Cpp2IlInjected.Address(RVA = "0x49A8690", Offset = "0x49A7690", VA = "0x1849A8690", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x49A6D40", Offset = "0x49A5D40", VA = "0x1849A6D40", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x49A8A50", Offset = "0x49A7A50", VA = "0x1849A8A50")]
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
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
		public EBEDKFKPCAO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x37E02E0", Offset = "0x37DF2E0", VA = "0x1837E02E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x3864D40", Offset = "0x3863D40", VA = "0x183864D40", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3864DA0", Offset = "0x3863DA0", VA = "0x183864DA0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x3864C10", Offset = "0x3863C10", VA = "0x183864C10", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey BHEIPBKEDLG]
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3864CD0", Offset = "0x3863CD0", VA = "0x183864CD0", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3864AB0", Offset = "0x3863AB0", VA = "0x183864AB0", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3864750", Offset = "0x3863750", VA = "0x183864750", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3863B10", Offset = "0x3862B10", VA = "0x183863B10", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3863A30", Offset = "0x3862A30", VA = "0x183863A30", Slot = "14")]
	protected virtual string FICIFKBPONN(TKeyVal KGDKKABCDKA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3863970", Offset = "0x3862970", VA = "0x183863970", Slot = "4")]
	public bool ContainsKey(TKey BHEIPBKEDLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x3864920", Offset = "0x3863920", VA = "0x183864920", Slot = "5")]
	public bool TryGetValue(TKey BHEIPBKEDLG, [Out] TVal CBAEIEAPLIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3863A60", Offset = "0x3862A60", VA = "0x183863A60", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3863A60", Offset = "0x3862A60", VA = "0x183863A60", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3864980", Offset = "0x3863980", VA = "0x183864980")]
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
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
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
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
		public BAEJIELKKNO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x4E6ABD0", Offset = "0x4E69BD0", VA = "0x184E6ABD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x45B59F0", Offset = "0x45B49F0", VA = "0x1845B59F0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x45B5CE0", Offset = "0x45B4CE0", VA = "0x1845B5CE0")]
	public NPBAFNBLGPB(float GANMCIICMPI, float FMBGDNACDDK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x45B5050", Offset = "0x45B4050", VA = "0x1845B5050")]
	public bool BJEOFKEBGAG(float IKBJFKDEOPL, T CBAEIEAPLIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x45B5240", Offset = "0x45B4240", VA = "0x1845B5240")]
	public IEnumerable<T> GDEDBMFAOOO(float IKBJFKDEOPL, [Optional] float? IPOCLCOKCLM)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x45B5C20", Offset = "0x45B4C20", VA = "0x1845B5C20")]
	public void OAIAOCAHOEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x45B5A60", Offset = "0x45B4A60", VA = "0x1845B5A60")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A7D00", Offset = "0x9A6D00", VA = "0x1809A7D00")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9BD680", Offset = "0x9BC680", VA = "0x1809BD680")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x5259DC0", Offset = "0x5258DC0", VA = "0x185259DC0")]
	public CLDODBECHFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x5259C80", Offset = "0x5258C80", VA = "0x185259C80")]
	public CLDODBECHFD(int ENCFHCJIMBE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x5259820", Offset = "0x5258820", VA = "0x185259820")]
	public void MJFEDCBJOBF(float IKBJFKDEOPL, T CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x5259B30", Offset = "0x5258B30", VA = "0x185259B30")]
	public void OAIAOCAHOEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x5258EC0", Offset = "0x5257EC0", VA = "0x185258EC0")]
	public bool IINLJAHGCKK(float COKDJDHEACI, float EKNAPDJFFOB, [Out] T CBAEIEAPLIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x5259420", Offset = "0x5258420", VA = "0x185259420")]
	public bool LKHOJHPNNBB(float COKDJDHEACI, float EKNAPDJFFOB, [Out] T CBAEIEAPLIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x5258CF0", Offset = "0x5257CF0", VA = "0x185258CF0")]
	public void CNMELFEIEAI(float COKDJDHEACI, float EKNAPDJFFOB, List<T> EPBKIHMMALG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x52593F0", Offset = "0x52583F0", VA = "0x1852593F0")]
	private int LFADDPNBGEM(int FDLNFOLDHLB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x5258E70", Offset = "0x5257E70", VA = "0x185258E70")]
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
	[Cpp2IlInjected.Address(RVA = "0x875BC0", Offset = "0x874BC0", VA = "0x180875BC0", Slot = "4")]
	protected override Vector3 LDBDNMDKFGP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x69430B0", Offset = "0x69420B0", VA = "0x1869430B0", Slot = "5")]
	protected override Vector3 KHHMHIKNGEM(Vector3 CBAEIEAPLIH, float LBKJPGMAINP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6943060", Offset = "0x6942060", VA = "0x186943060", Slot = "6")]
	protected override Vector3 GGJCCCNDEPE(Vector3 ILBMPADICAD, Vector3 BEOPIALHGPL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x69430F0", Offset = "0x69420F0", VA = "0x1869430F0", Slot = "7")]
	protected override Vector3 NBAENKBBCBE(Vector3 ILBMPADICAD, Vector3 BEOPIALHGPL)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x6943170", Offset = "0x6942170", VA = "0x186943170")]
	public GEDMBAGKCFJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class HENHHMAPLNO
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2B20CA0", Offset = "0x2B1FCA0", VA = "0x182B20CA0")]
	public static KKCDLHKOFNI<T1, T2> GIGNPOIHFIA<T1, T2>(T1 BCOCGDJMCCA, T2 APEPKAHODKG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2B20D40", Offset = "0x2B1FD40", VA = "0x182B20D40")]
	public static FPHALOFBMIA<T1, T2, T3> GIGNPOIHFIA<T1, T2, T3>(T1 BCOCGDJMCCA, T2 APEPKAHODKG, T3 CPEOMKONCFJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x4541670", Offset = "0x4540670", VA = "0x184541670")]
	internal static int BHIFOADBIEB(int PPEDDJNKALC, int HPPJDBCECKI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5D03780", Offset = "0x5D02780", VA = "0x185D03780")]
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
	[Cpp2IlInjected.Address(RVA = "0x4224F60", Offset = "0x4223F60", VA = "0x184224F60")]
	public KKCDLHKOFNI(T1 BCOCGDJMCCA, T2 APEPKAHODKG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x4223530", Offset = "0x4222530", VA = "0x184223530", Slot = "4")]
	public int CompareTo(KKCDLHKOFNI<T1, T2> LJAAPFIIPOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x4223C30", Offset = "0x4222C30", VA = "0x184223C30", Slot = "0")]
	public override bool Equals(object LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x42242A0", Offset = "0x42232A0", VA = "0x1842242A0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x4224DB0", Offset = "0x4223DB0", VA = "0x184224DB0", Slot = "3")]
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
	[Cpp2IlInjected.Address(RVA = "0x3C9C7E0", Offset = "0x3C9B7E0", VA = "0x183C9C7E0")]
	public FPHALOFBMIA(T1 BCOCGDJMCCA, T2 APEPKAHODKG, T3 CPEOMKONCFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x3C9BFD0", Offset = "0x3C9AFD0", VA = "0x183C9BFD0", Slot = "4")]
	public int CompareTo(FPHALOFBMIA<T1, T2, T3> LJAAPFIIPOF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x3C9C130", Offset = "0x3C9B130", VA = "0x183C9C130", Slot = "0")]
	public override bool Equals(object LJAAPFIIPOF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x3C9C470", Offset = "0x3C9B470", VA = "0x183C9C470", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x3C9C510", Offset = "0x3C9B510", VA = "0x183C9C510", Slot = "3")]
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
		[Cpp2IlInjected.Address(RVA = "0x22FE210", Offset = "0x22FD210", VA = "0x1822FE210")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x22FE250", Offset = "0x22FD250", VA = "0x1822FE250")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public float BMOGHGOLKKN
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8D0AD0", Offset = "0x8CFAD0", VA = "0x1808D0AD0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4BE5000", Offset = "0x4BE4000", VA = "0x184BE5000")]
	public T HMBNANGDNKP(float LBKJPGMAINP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x4BE5340", Offset = "0x4BE4340", VA = "0x184BE5340")]
	public T OKFLOLCGCLL(float LBKJPGMAINP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T INHECHKJPLF(T ILBMPADICAD, T BEOPIALHGPL, float LBKJPGMAINP);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x6942FE0", Offset = "0x6941FE0", VA = "0x186942FE0", Slot = "4")]
	protected override float INHECHKJPLF(float ILBMPADICAD, float BEOPIALHGPL, float LBKJPGMAINP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x6943020", Offset = "0x6942020", VA = "0x186943020")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0xE79530", Offset = "0xE78530", VA = "0x180E79530", Slot = "4")]
	protected override Vector3 INHECHKJPLF(Vector3 ILBMPADICAD, Vector3 BEOPIALHGPL, float LBKJPGMAINP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x69479A0", Offset = "0x69469A0", VA = "0x1869479A0")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x6942C60", Offset = "0x6941C60", VA = "0x186942C60", Slot = "4")]
	protected override Color INHECHKJPLF(Color ILBMPADICAD, Color BEOPIALHGPL, float LBKJPGMAINP)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x6942D20", Offset = "0x6941D20", VA = "0x186942D20")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class LMEAJLGDHMB : POKEMGHGOGK<string>
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x69451C0", Offset = "0x69441C0", VA = "0x1869451C0")]
	public LMEAJLGDHMB(int NAFKLJDAKHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x6945150", Offset = "0x6944150", VA = "0x186945150", Slot = "6")]
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
	[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
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
	[Cpp2IlInjected.Address(RVA = "0x4542370", Offset = "0x4541370", VA = "0x184542370")]
	private PPBJHBKJKGF(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> BNIGBKFGBCA, int HJAKNKEGBFE, int IKMCAHAKNPM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x47B9C80", Offset = "0x47B8C80", VA = "0x1847B9C80")]
	public static PPBJHBKJKGF<T> HCLFOFEHDJP()
	{
		return default(PPBJHBKJKGF<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x47B9520", Offset = "0x47B8520", VA = "0x1847B9520")]
	public (int, int, Task<T>) ENHPBHMBLGL(int IGGMMJMDDDD, [Optional] CancellationToken DADBOHKBJNO, double PJKHGIHPBDF = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x47B7720", Offset = "0x47B6720", VA = "0x1847B7720")]
	public void CFHJLHDKCIH(int IGGMMJMDDDD, int IKMCAHAKNPM, [In] T HJBJAPKPPFA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class NOLBAFODJBL
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x69452F0", Offset = "0x69442F0", VA = "0x1869452F0")]
	public static PPBJHBKJKGF<HNKFFDNJINI> HCLFOFEHDJP()
	{
		return default(PPBJHBKJKGF<HNKFFDNJINI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x6945270", Offset = "0x6944270", VA = "0x186945270")]
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
		[Cpp2IlInjected.Address(RVA = "0x3574890", Offset = "0x3573890", VA = "0x183574890", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool FAOLOMOFDJM
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8ADFC0", Offset = "0x8ACFC0", VA = "0x1808ADFC0", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public ICollection<TKey> NHIDLCIOKPK
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x3DE5020", Offset = "0x3DE4020", VA = "0x183DE5020", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public ICollection<TVal> HLMNKOOFAJL
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x3DE5080", Offset = "0x3DE4080", VA = "0x183DE5080", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public TVal PGDICMLLHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x3DE4FB0", Offset = "0x3DE3FB0", VA = "0x183DE4FB0", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x3DE50E0", Offset = "0x3DE40E0", VA = "0x183DE50E0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public TKey PGDICMLLHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x3DE4610", Offset = "0x3DE3610", VA = "0x183DE4610")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3DE4450", Offset = "0x3DE3450", VA = "0x183DE4450", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3DE4D20", Offset = "0x3DE3D20", VA = "0x183DE4D20", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3DE4140", Offset = "0x3DE3140", VA = "0x183DE4140", Slot = "9")]
	public void Add(TKey BHEIPBKEDLG, TVal CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3DE4220", Offset = "0x3DE3220", VA = "0x183DE4220", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> OPNLGJFHDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x3D2E080", Offset = "0x3D2D080", VA = "0x183D2E080", Slot = "8")]
	public bool ContainsKey(TKey BHEIPBKEDLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3DE4500", Offset = "0x3DE3500", VA = "0x183DE4500", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> OPNLGJFHDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x3DE4CA0", Offset = "0x3DE3CA0", VA = "0x183DE4CA0", Slot = "10")]
	public bool Remove(TKey BHEIPBKEDLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3DE4CE0", Offset = "0x3DE3CE0", VA = "0x183DE4CE0", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> OPNLGJFHDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x3DE4DC0", Offset = "0x3DE3DC0", VA = "0x183DE4DC0", Slot = "11")]
	public bool TryGetValue(TKey BHEIPBKEDLG, [Out] TVal CBAEIEAPLIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3DE46D0", Offset = "0x3DE36D0", VA = "0x183DE46D0", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3DE4580", Offset = "0x3DE3580", VA = "0x183DE4580", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] GGEMIJICFPG, int MCEFCKDGOEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3DE47D0", Offset = "0x3DE37D0", VA = "0x183DE47D0")]
	public bool MMCLNKMOKEF(TVal BHEIPBKEDLG, [Out] TKey CBAEIEAPLIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3DE4270", Offset = "0x3DE3270", VA = "0x183DE4270")]
	private void BPOJBMCLCIC(TKey BHEIPBKEDLG, TVal LECBAKCNNCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3DE4A80", Offset = "0x3DE3A80", VA = "0x183DE4A80")]
	private void NOLOALKHGHN(TKey BHEIPBKEDLG, TVal LECBAKCNNCK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3DE4830", Offset = "0x3DE3830", VA = "0x183DE4830")]
	private bool NMOOPAJILOI(TKey BHEIPBKEDLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3DE4E20", Offset = "0x3DE3E20", VA = "0x183DE4E20")]
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
			[Cpp2IlInjected.Address(RVA = "0x38B0E40", Offset = "0x38AFE40", VA = "0x1838B0E40", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x38B9900", Offset = "0x38B8900", VA = "0x1838B9900", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x38BA770", Offset = "0x38B9770", VA = "0x1838BA770")]
		public Enumerator(MHLEGOIDLII<T> EPBKIHMMALG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x38B8840", Offset = "0x38B7840", VA = "0x1838B8840", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x38B9190", Offset = "0x38B8190", VA = "0x1838B9190", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x38B8080", Offset = "0x38B7080", VA = "0x1838B8080")]
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
		[Cpp2IlInjected.Address(RVA = "0x44ECE70", Offset = "0x44EBE70", VA = "0x1844ECE70")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public T PGDICMLLHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x44EB240", Offset = "0x44EA240", VA = "0x1844EB240")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x44EC360", Offset = "0x44EB360", VA = "0x1844EC360")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x44ED1A0", Offset = "0x44EC1A0", VA = "0x1844ED1A0")]
	public MHLEGOIDLII(int NAFKLJDAKHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x44EC800", Offset = "0x44EB800", VA = "0x1844EC800")]
	public void MJFEDCBJOBF(T LBKJPGMAINP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x44ECE50", Offset = "0x44EBE50", VA = "0x1844ECE50")]
	public void OAIAOCAHOEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x44EC720", Offset = "0x44EB720", VA = "0x1844EC720")]
	public void HHPDKEGNKMD(int JPBPNOCHNLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x44EC1E0", Offset = "0x44EB1E0", VA = "0x1844EC1E0")]
	public void FNIBGALIMHE(T[] GGEMIJICFPG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x44EAF40", Offset = "0x44E9F40", VA = "0x1844EAF40")]
	public Enumerator AKHPNFMFJMK()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x44ED070", Offset = "0x44EC070", VA = "0x1844ED070", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x44ED070", Offset = "0x44EC070", VA = "0x1844ED070", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x44EB920", Offset = "0x44EA920", VA = "0x1844EB920")]
	private int FGIAIDNBEEC(int LLPJHIPCNFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x44EC6F0", Offset = "0x44EB6F0", VA = "0x1844EC6F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x4E7DB20", Offset = "0x4E7CB20", VA = "0x184E7DB20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public TimeSpan LEKGHGKKEBD
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x8687C0", Offset = "0x8677C0", VA = "0x1808687C0")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x4E7DC70", Offset = "0x4E7CC70", VA = "0x184E7DC70")]
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
		[Cpp2IlInjected.Address(RVA = "0x4E9A090", Offset = "0x4E99090", VA = "0x184E9A090")]
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
		[Cpp2IlInjected.Address(RVA = "0x51660A0", Offset = "0x51650A0", VA = "0x1851660A0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x5166510", Offset = "0x5165510", VA = "0x185166510", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x47B2BF0", Offset = "0x47B1BF0", VA = "0x1847B2BF0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x47B31F0", Offset = "0x47B21F0", VA = "0x1847B31F0", Slot = "5")]
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
	[Cpp2IlInjected.Address(RVA = "0x4686E10", Offset = "0x4685E10", VA = "0x184686E10")]
	public OEGIOJIPBCE(CIEDDCMHHDL EDHAPIHPKFG, [Optional] BFGFPNEPNBP IKNGJBDNIAM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x4686A30", Offset = "0x4685A30", VA = "0x184686A30")]
	public Task<TResult> JLOMEBMMDLF(TRequest BDMHFDNBPPE, CancellationToken DADBOHKBJNO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x46862D0", Offset = "0x46852D0", VA = "0x1846862D0")]
	private void IEOIENOKJFM(BIBDIFDBDOH PPDKAHPOCJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x4686200", Offset = "0x4685200", VA = "0x184686200")]
	[AsyncStateMachine(typeof(OEGIOJIPBCE<, >.CFEBGFBKBNJ))]
	private Task HFLDDDKEKJM()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x4685A80", Offset = "0x4684A80", VA = "0x184685A80")]
	private BIBDIFDBDOH FLNMMEMEIDM()
	{
		return default(BIBDIFDBDOH);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x4685200", Offset = "0x4684200", VA = "0x184685200")]
	[AsyncStateMachine(typeof(OEGIOJIPBCE<, >.PMOGJLLFGLN))]
	private Task AMKENCOJKBD()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x4685500", Offset = "0x4684500", VA = "0x184685500")]
	private void CCCBIDGAOIG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x4685720", Offset = "0x4684720", VA = "0x184685720", Slot = "4")]
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
		[Cpp2IlInjected.Address(RVA = "0x3574890", Offset = "0x3573890", VA = "0x183574890", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool FAOLOMOFDJM
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x8ADFC0", Offset = "0x8ACFC0", VA = "0x1808ADFC0", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public T PGDICMLLHEJ
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x274BB40", Offset = "0x274AB40", VA = "0x18274BB40", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x3CE8BB0", Offset = "0x3CE7BB0", VA = "0x183CE8BB0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x3CB4AD0", Offset = "0x3CB3AD0", VA = "0x183CB4AD0", Slot = "11")]
	public void Add(T OPNLGJFHDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x3CE8510", Offset = "0x3CE7510", VA = "0x183CE8510")]
	public bool PFKIIIIKFDA(T OPNLGJFHDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x3CE89B0", Offset = "0x3CE79B0", VA = "0x183CE89B0", Slot = "15")]
	public bool Remove(T OPNLGJFHDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x37E0B10", Offset = "0x37DFB10", VA = "0x1837E0B10", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3C001D0", Offset = "0x3BFF1D0", VA = "0x183C001D0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3CE7F90", Offset = "0x3CE6F90", VA = "0x183CE7F90", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3CE8040", Offset = "0x3CE7040", VA = "0x183CE8040", Slot = "13")]
	public bool Contains(T OPNLGJFHDEP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x3CE80A0", Offset = "0x3CE70A0", VA = "0x183CE80A0", Slot = "14")]
	public void CopyTo(T[] GGEMIJICFPG, int MCEFCKDGOEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x3CE8100", Offset = "0x3CE7100", VA = "0x183CE8100", Slot = "6")]
	public int IndexOf(T OPNLGJFHDEP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3CE8160", Offset = "0x3CE7160", VA = "0x183CE8160", Slot = "7")]
	public void Insert(int LLPJHIPCNFD, T OPNLGJFHDEP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x3CE8780", Offset = "0x3CE7780", VA = "0x183CE8780", Slot = "8")]
	public void RemoveAt(int LLPJHIPCNFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3CE8A80", Offset = "0x3CE7A80", VA = "0x183CE8A80")]
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
			[Cpp2IlInjected.Address(RVA = "0x21A49A0", Offset = "0x21A39A0", VA = "0x1821A49A0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x6946F30", Offset = "0x6945F30", VA = "0x186946F30")]
		public SerializedGuid([In] Guid NNFEKLKANBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x6946E00", Offset = "0x6945E00", VA = "0x186946E00")]
		public static SerializedGuid NKMJBAODIPB()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x6946D80", Offset = "0x6945D80", VA = "0x186946D80")]
		public static SerializedGuid GLDEMEOELCM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x6946C50", Offset = "0x6945C50", VA = "0x186946C50")]
		public bool DFLAHLKBLGO()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x6946F00", Offset = "0x6945F00", VA = "0x186946F00", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x6946E80", Offset = "0x6945E80", VA = "0x186946E80", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x6946CB0", Offset = "0x6945CB0", VA = "0x186946CB0", Slot = "7")]
		public bool Equals(SerializedGuid LJAAPFIIPOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x6946CF0", Offset = "0x6945CF0", VA = "0x186946CF0", Slot = "0")]
		public override bool Equals(object HBFCGFKGCAF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x6946DF0", Offset = "0x6945DF0", VA = "0x186946DF0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x6946C20", Offset = "0x6945C20", VA = "0x186946C20", Slot = "6")]
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
	[Cpp2IlInjected.Address(RVA = "0x69453C0", Offset = "0x69443C0", VA = "0x1869453C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x458C2D0", Offset = "0x458B2D0", VA = "0x18458C2D0")]
		public NKDDOICNFBI(long DHJLMLEJJGL, int CFOAJMHFKMO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x458C2A0", Offset = "0x458B2A0", VA = "0x18458C2A0")]
		public NKDDOICNFBI(long DHJLMLEJJGL, long KFLGCIFBBNK, int CFOAJMHFKMO, int IOFLCOBFBCE, bool KNFBOGEIAEG, string INABEHJJLFH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x458C250", Offset = "0x458B250", VA = "0x18458C250")]
		public int PHIEGNBOOGC()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x458C130", Offset = "0x458B130", VA = "0x18458C130")]
		public int BFIBGPFAOJI(int KJANKENDGBI)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x458C150", Offset = "0x458B150", VA = "0x18458C150")]
		public double DHJEPFNJGOK()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x458C1B0", Offset = "0x458B1B0", VA = "0x18458C1B0")]
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
			[Cpp2IlInjected.Address(RVA = "0x42D5390", Offset = "0x42D4390", VA = "0x1842D5390", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x3E836C0", Offset = "0x3E826C0", VA = "0x183E836C0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x3C736D0", Offset = "0x3C726D0", VA = "0x183C736D0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public IEnumerable<DIJMCCGECOP> ACNCGBCHAHF
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x582E150", Offset = "0x582D150", VA = "0x18582E150")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public NKDDOICNFBI IGBHFBBEGJJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x582E190", Offset = "0x582D190", VA = "0x18582E190")]
			[CompilerGenerated]
			get
			{
				return default(NKDDOICNFBI);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x582E370", Offset = "0x582D370", VA = "0x18582E370")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x582E3A0", Offset = "0x582D3A0", VA = "0x18582E3A0")]
		internal DIJMCCGECOP(DJJFGNEEIPJ<TKey> OPELNCJDKIK, TKey BHEIPBKEDLG, ICJNMGNJFIN CAJBNIGHKAB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x582E1B0", Offset = "0x582D1B0", VA = "0x18582E1B0")]
		public DIJMCCGECOP NOKGBJLMPML(TKey BHEIPBKEDLG, [Optional] ICJNMGNJFIN? EEGMELOJAAG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x274C5E0", Offset = "0x274B5E0", VA = "0x18274C5E0")]
		[AsyncStateMachine(typeof(LGOBMNMBKNG<>))]
		public Task<T> CODKLMIAMEJ<T>(TKey BHEIPBKEDLG, Func<DIJMCCGECOP, Task<T>> LHGGEBICOGB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x582DEF0", Offset = "0x582CEF0", VA = "0x18582DEF0", Slot = "4")]
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
			[Cpp2IlInjected.Address(RVA = "0x21A24F0", Offset = "0x21A14F0", VA = "0x1821A24F0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x4EBB3B0", Offset = "0x4EBA3B0", VA = "0x184EBB3B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x21A25E0", Offset = "0x21A15E0", VA = "0x1821A25E0")]
		[DebuggerHidden]
		public BPNFJMOJIDB(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x397F010", Offset = "0x397E010", VA = "0x18397F010", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x4EBAE80", Offset = "0x4EB9E80", VA = "0x184EBAE80", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x4EBB230", Offset = "0x4EBA230", VA = "0x184EBB230")]
		private void PEOGCCBKFKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x4EBB360", Offset = "0x4EBA360", VA = "0x184EBB360", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x4EBB280", Offset = "0x4EBA280", VA = "0x184EBB280", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, NKDDOICNFBI)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x3ADA900", Offset = "0x3AD9900", VA = "0x183ADA900", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x21A24F0", Offset = "0x21A14F0", VA = "0x1821A24F0", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x38062B0", Offset = "0x38052B0", VA = "0x1838062B0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x21A25E0", Offset = "0x21A15E0", VA = "0x1821A25E0")]
		[DebuggerHidden]
		public EHNIIJJGOHN(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x3806310", Offset = "0x3805310", VA = "0x183806310", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x38058D0", Offset = "0x38048D0", VA = "0x1838058D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x38060C0", Offset = "0x38050C0", VA = "0x1838060C0")]
		private void PEOGCCBKFKO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x3805870", Offset = "0x3804870", VA = "0x183805870")]
		private void LAOHPFDNJCL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x3806260", Offset = "0x3805260", VA = "0x183806260", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x3806120", Offset = "0x3805120", VA = "0x183806120", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, NKDDOICNFBI)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x3806220", Offset = "0x3805220", VA = "0x183806220", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x868820", Offset = "0x867820", VA = "0x180868820")]
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
		[Cpp2IlInjected.Address(RVA = "0x866DF0", Offset = "0x865DF0", VA = "0x180866DF0")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x5830F70", Offset = "0x582FF70", VA = "0x185830F70")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x58311F0", Offset = "0x58301F0", VA = "0x1858311F0")]
	public DJJFGNEEIPJ(TKey FIBNPFLNDAH, ICJNMGNJFIN CAJBNIGHKAB, [Optional] int? CFOAJMHFKMO, [Optional][CanBeNull] Stopwatch JBABMCMIKHE, [Optional] Action<TKey, NKDDOICNFBI, ICJNMGNJFIN> OELKPCFGNNC, [Optional] Action<TKey, NKDDOICNFBI, ICJNMGNJFIN> FHCECICIANB, [Optional] Action<DJJFGNEEIPJ<TKey>, ICJNMGNJFIN> DMHLNBLLNJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x5830E90", Offset = "0x582FE90", VA = "0x185830E90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x5830FD0", Offset = "0x582FFD0", VA = "0x185830FD0")]
	[IteratorStateMachine(typeof(DJJFGNEEIPJ<>.BPNFJMOJIDB))]
	public IEnumerable<(TKey, List<TKey>, NKDDOICNFBI)> IHHMNALBBNE()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x5831080", Offset = "0x5830080", VA = "0x185831080")]
	[IteratorStateMachine(typeof(DJJFGNEEIPJ<>.EHNIIJJGOHN))]
	private IEnumerable<(TKey, List<TKey>, NKDDOICNFBI)> IHHMNALBBNE(List<TKey> AKCHJOKAGJB, DIJMCCGECOP PGFNMJEGAHN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x5831170", Offset = "0x5830170", VA = "0x185831170")]
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
	[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
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
	[Cpp2IlInjected.Address(RVA = "0x3856A80", Offset = "0x3855A80", VA = "0x183856A80")]
	private static string CHHLEACKEIC(TKey BHEIPBKEDLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x3856C20", Offset = "0x3855C20", VA = "0x183856C20", Slot = "4")]
	public override string HONEKPGFJIH(DJJFGNEEIPJ<TKey> OPELNCJDKIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x3856AC0", Offset = "0x3855AC0", VA = "0x183856AC0")]
	public string HONEKPGFJIH(DJJFGNEEIPJ<TKey> OPELNCJDKIK, [NotNull] BBFDKELHKOA FCPOOFAKGGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string GEGLHCMGHFE(DJJFGNEEIPJ<TKey> OPELNCJDKIK, [NotNull] BBFDKELHKOA FCPOOFAKGGN);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x3856D10", Offset = "0x3855D10", VA = "0x183856D10")]
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
	[Cpp2IlInjected.Address(RVA = "0x408C760", Offset = "0x408B760", VA = "0x18408C760")]
	private static string CHHLEACKEIC(TKey BHEIPBKEDLG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x408D3A0", Offset = "0x408C3A0", VA = "0x18408D3A0")]
	public JDGGCKLKOMM(string CGPGNAFHDBD = "F2", double LPMLPPNLEMK = double.MaxValue, bool HJCJCMKHLKB = false, int LAJHHJGIINL = int.MaxValue, [Optional] ISet<string> CNBAILFOENJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x408CB80", Offset = "0x408BB80", VA = "0x18408CB80", Slot = "4")]
	public override Dictionary<string, string> HONEKPGFJIH(DJJFGNEEIPJ<TKey> OPELNCJDKIK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x408D2C0", Offset = "0x408C2C0", VA = "0x18408D2C0")]
	private bool LKPBOGIIPNI(string LCANFHLDCOB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x408CC70", Offset = "0x408BC70", VA = "0x18408CC70")]
	public Dictionary<string, string> HONEKPGFJIH(DJJFGNEEIPJ<TKey> OPELNCJDKIK, GCCPMHCGJCJ FCPOOFAKGGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x408C900", Offset = "0x408B900", VA = "0x18408C900")]
	private string GCPBLDCAMFF(StringBuilder KLHCOPAEHIC, List<TKey> CDHHADCICAH, GCCPMHCGJCJ FCPOOFAKGGN, bool EFKNEBJEPBF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x408C7A0", Offset = "0x408B7A0", VA = "0x18408C7A0")]
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
	[Cpp2IlInjected.Address(RVA = "0x5058570", Offset = "0x5057570", VA = "0x185058570")]
	private CBMOLBONIHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x5057470", Offset = "0x5056470", VA = "0x185057470", Slot = "5")]
	protected override string GEGLHCMGHFE(DJJFGNEEIPJ<TKey> OPELNCJDKIK, BBFDKELHKOA FCPOOFAKGGN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x5058310", Offset = "0x5057310", VA = "0x185058310")]
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
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
		public EPKDOEMBBHH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x6942DE0", Offset = "0x6941DE0", VA = "0x186942DE0")]
		internal void GIKBLOMMBJH(DJJFGNEEIPJ<string> timer, ICJNMGNJFIN log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x6942B10", Offset = "0x6941B10", VA = "0x186942B10")]
	public CFPLEGNHFFN(ICJNMGNJFIN CAJBNIGHKAB, [Optional] string KCHDIPBIBMC, [Optional] int? CFOAJMHFKMO, [Optional] Stopwatch JBABMCMIKHE, [Optional] Action<string, NKDDOICNFBI, ICJNMGNJFIN> OELKPCFGNNC, [Optional] Action<string, NKDDOICNFBI, ICJNMGNJFIN> FHCECICIANB, [Optional] Action<CFPLEGNHFFN, ICJNMGNJFIN> DMHLNBLLNJD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x6942A50", Offset = "0x6941A50", VA = "0x186942A50")]
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
			[Cpp2IlInjected.Address(RVA = "0x69431D0", Offset = "0x69421D0", VA = "0x1869431D0")]
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
			[Cpp2IlInjected.Address(RVA = "0x9B2320", Offset = "0x9B1320", VA = "0x1809B2320", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x69432D0", Offset = "0x69422D0", VA = "0x1869432D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x6942E70", Offset = "0x6941E70", VA = "0x186942E70")]
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
	[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
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
	[Cpp2IlInjected.Address(RVA = "0x2CD55F0", Offset = "0x2CD45F0", VA = "0x182CD55F0")]
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
			[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x8687D0", Offset = "0x8677D0", VA = "0x1808687D0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x4207DB0", Offset = "0x4206DB0", VA = "0x184207DB0")]
		public KECGCIOCKIK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0x86FF30", Offset = "0x86EF30", VA = "0x18086FF30", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x870C70", Offset = "0x86FC70", VA = "0x180870C70", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x4313020", Offset = "0x4312020", VA = "0x184313020")]
		public LPMANNPBAMH(T HHMLOJPFGAO, Action<T>? DPHFDCIPJAD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x4312DD0", Offset = "0x4311DD0", VA = "0x184312DD0", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x8687D0", Offset = "0x8677D0", VA = "0x1808687D0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x3855520", Offset = "0x3854520", VA = "0x183855520")]
		public EOGJJLECEEL(Exception PHPBNDIBHHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "10")]
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
			[Cpp2IlInjected.Address(RVA = "0x47B3C30", Offset = "0x47B2C30", VA = "0x1847B3C30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x47B4170", Offset = "0x47B3170", VA = "0x1847B4170", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x4E985D0", Offset = "0x4E975D0", VA = "0x184E985D0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x4E98AB0", Offset = "0x4E97AB0", VA = "0x184E98AB0", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8687D0", Offset = "0x8677D0", VA = "0x1808687D0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x869520", Offset = "0x868520", VA = "0x180869520", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x46A3730", Offset = "0x46A2730", VA = "0x1846A3730")]
		public OIBGJDDIGHB(Task<FMHOFFFMGIN<T>> PEBIPFJADEI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x46A3430", Offset = "0x46A2430", VA = "0x1846A3430", Slot = "10")]
		protected override void LFGLBHDCMLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x46A3130", Offset = "0x46A2130", VA = "0x1846A3130")]
		[AsyncStateMachine(typeof(OIBGJDDIGHB<>.POFCDICGJAB))]
		[CompilerGenerated]
		internal static Task<T> KPMAODGMBPM(Task<FMHOFFFMGIN<T>> PEBIPFJADEI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x46A3640", Offset = "0x46A2640", VA = "0x1846A3640")]
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
			[Cpp2IlInjected.Address(RVA = "0x3D4B6B0", Offset = "0x3D4A6B0", VA = "0x183D4B6B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x3D4BA30", Offset = "0x3D4AA30", VA = "0x183D4BA30", Slot = "5")]
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
			[Cpp2IlInjected.Address(RVA = "0x8687D0", Offset = "0x8677D0", VA = "0x1808687D0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x869520", Offset = "0x868520", VA = "0x180869520", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x4683050", Offset = "0x4682050", VA = "0x184683050")]
		public ODFCPONFBPE(FMHOFFFMGIN<TIn> GBHPFBOLEOG, Func<TIn, TOut> LGIPGOJHOED)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x4682FB0", Offset = "0x4681FB0", VA = "0x184682FB0", Slot = "10")]
		protected override void LFGLBHDCMLI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x4682C90", Offset = "0x4681C90", VA = "0x184682C90")]
		[AsyncStateMachine(typeof(ODFCPONFBPE<, >.GLBKAKPKJFG))]
		[CompilerGenerated]
		internal static Task<TOut> KMFMIPKMNIB(Task<TIn> CBCFOFOIDKK, Func<TIn, TOut> LGIPGOJHOED)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x2B0C390", Offset = "0x2B0B390", VA = "0x182B0C390")]
	public static FMHOFFFMGIN<T> BHJAMJDAEMH<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x2B0C410", Offset = "0x2B0B410", VA = "0x182B0C410")]
	public static FMHOFFFMGIN<T> LGMJFFKFMFI<T>(T HJBJAPKPPFA, [Optional] Action<T>? DPHFDCIPJAD) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x2930300", Offset = "0x292F300", VA = "0x182930300")]
	public static FMHOFFFMGIN<T> NBILMDDIICK<T>(Exception PHPBNDIBHHP) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x2930300", Offset = "0x292F300", VA = "0x182930300")]
	public static FMHOFFFMGIN<T> DFOPKHNBLJB<T>(Task<FMHOFFFMGIN<T>> PEBIPFJADEI) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x29351C0", Offset = "0x29341C0", VA = "0x1829351C0")]
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
		[Cpp2IlInjected.Address(RVA = "0xB91320", Offset = "0xB90320", VA = "0x180B91320", Slot = "6")]
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
	[Cpp2IlInjected.Address(RVA = "0x46814A0", Offset = "0x46804A0", VA = "0x1846814A0")]
	public OCGDHNPKGKG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x4681070", Offset = "0x4680070", VA = "0x184681070", Slot = "7")]
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
			[Cpp2IlInjected.Address(RVA = "0x3562240", Offset = "0x3561240", VA = "0x183562240", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x3562510", Offset = "0x3561510", VA = "0x183562510", Slot = "5")]
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
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
		public AFBJHGALBHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x3CED110", Offset = "0x3CEC110", VA = "0x183CED110")]
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
		[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public override HCGNNEJAOHI<T> PCBEFABIIFC
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x8687D0", Offset = "0x8677D0", VA = "0x1808687D0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x4550EE0", Offset = "0x454FEE0", VA = "0x184550EE0")]
	protected NAEBCHGCLLJ(TTask PEBIPFJADEI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x4550E90", Offset = "0x454FE90", VA = "0x184550E90", Slot = "10")]
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
		[Cpp2IlInjected.Address(RVA = "0x3C412A0", Offset = "0x3C402A0", VA = "0x183C412A0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public override HCGNNEJAOHI<T> PCBEFABIIFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x8687D0", Offset = "0x8677D0", VA = "0x1808687D0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x42095F0", Offset = "0x42085F0", VA = "0x1842095F0")]
	public KELCFLLEPAG(BCBDLBGONLF<Task<T>> NBKPLIGNOED)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x42095D0", Offset = "0x42085D0", VA = "0x1842095D0", Slot = "10")]
	protected override void LFGLBHDCMLI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class KAGMKKEBLHO
{
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public static readonly HashAlgorithmName PMBHDJOCDFD;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly ThreadLocal<IncrementalHash> JFGKJANALDG;

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x69437D0", Offset = "0x69427D0", VA = "0x1869437D0")]
	public static int CJNHHIIEMNO(this DNNDDGNBNEI OOONJNFFKAA, IncrementalHash HBFGLPMFMGA, byte[] BLJLCKOCMLH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x6943850", Offset = "0x6942850", VA = "0x186943850")]
	public static bool LDBLDLIGFGB([CanBeNull] this DNNDDGNBNEI OOONJNFFKAA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x6943BE0", Offset = "0x6942BE0", VA = "0x186943BE0")]
	public static bool LDBLDLIGFGB([CanBeNull] this DNNDDGNBNEI OOONJNFFKAA, [Out] string JCBCIJOKIDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x69438B0", Offset = "0x69428B0", VA = "0x1869438B0")]
	public static bool LDBLDLIGFGB([CanBeNull] this DNNDDGNBNEI OOONJNFFKAA, IncrementalHash HBFGLPMFMGA, byte[] BLJLCKOCMLH, [Out] string JCBCIJOKIDD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x6943EF0", Offset = "0x6942EF0", VA = "0x186943EF0")]
	private static bool MKGAOBGJLCP(byte[] PADJINFDHCP, Span<byte> FCJGLLAAABI)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class OKIIMIPNKLG
{
	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x6945690", Offset = "0x6944690", VA = "0x186945690")]
	public static int NBKNABCDBPL(HashAlgorithmName OHHOOMFBFJG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x6945430", Offset = "0x6944430", VA = "0x186945430")]
	public static int CJNHHIIEMNO(this PCEOFOMKDKD CJMHHPHEDBE, byte[] GICDBPGEGMN, IncrementalHash HBFGLPMFMGA, byte[] PLGOPGOHPLD)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface PCEOFOMKDKD
{
	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash HBFGLPMFMGA);
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface DNNDDGNBNEI : PCEOFOMKDKD
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	[CanBeNull]
	byte[] BNFFHLEJONE
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	[CanBeNull]
	byte[] EAJBNADLLLA
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class CDEBIDLKMAN
{
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static bool INHFMPEJIBG;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly ArrayPool<byte> CCGHKJAFNNO;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static readonly ArrayPool<char> OBAMAGGCGKM;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly Encoding CBCJIPCMBDO;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly ThreadLocal<Encoder> MJJCJCCCPMO;

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x2927F60", Offset = "0x2926F60", VA = "0x182927F60")]
	public static void GBPHDEFJEDK<T>(this IncrementalHash DBKLKBAPPBJ, [CanBeNull] T ADPKHCOJMDE) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x2928020", Offset = "0x2927020", VA = "0x182928020")]
	public static void NEFFNNDOHEG<T>(this IncrementalHash DBKLKBAPPBJ, [CanBeNull] T CJMHHPHEDBE) where T : PCEOFOMKDKD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x2927A40", Offset = "0x2926A40", VA = "0x182927A40")]
	public static void DMDNFHDOJAB<T>(this IncrementalHash DBKLKBAPPBJ, [CanBeNull] IList<T> FFDMHNMMJBO) where T : PCEOFOMKDKD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x6941870", Offset = "0x6940870", VA = "0x186941870")]
	private static bool AKDPBCHKGFK([CanBeNull] PCEOFOMKDKD CJMHHPHEDBE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x6941E90", Offset = "0x6940E90", VA = "0x186941E90")]
	public static void LAGINJNDHEN(this IncrementalHash HBFGLPMFMGA, string? CKKOHDHLNOO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x6941B30", Offset = "0x6940B30", VA = "0x186941B30")]
	public static void FLEOOOJHBPE(this IncrementalHash HBFGLPMFMGA, long CMPFGKCKFBN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x6941900", Offset = "0x6940900", VA = "0x186941900")]
	public static void DEJKFPJEBME(this IncrementalHash HBFGLPMFMGA, int OFNCOECPHHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x6942360", Offset = "0x6941360", VA = "0x186942360")]
	public static void MOJNNNCPKHH(this IncrementalHash HBFGLPMFMGA, short CHJMCIKMHCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x69426A0", Offset = "0x69416A0", VA = "0x1869426A0")]
	public static void OCMHCOAJNGB(this IncrementalHash HBFGLPMFMGA, byte GKDCAJJJAHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x6942530", Offset = "0x6941530", VA = "0x186942530")]
	public static void NGKOLNBODDE(this IncrementalHash HBFGLPMFMGA, bool PHPPJNGCHIL, bool PPIMALODFAD = false, bool LLNNBPMHEJP = false, bool GNHGADBIHIH = false, bool BJJGMJLJBJI = false, bool ONGGGIEINGG = false, bool OBDCILOBPEJ = false, bool MDOOABKDGBE = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x29280B0", Offset = "0x29270B0", VA = "0x1829280B0")]
	public static void NFJCELHDDFD<T>(this IncrementalHash HBFGLPMFMGA, T HEJFAMNFDIC) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x6941E30", Offset = "0x6940E30", VA = "0x186941E30")]
	public static void KPDJPEDHOIM(this IncrementalHash HBFGLPMFMGA, float HMHJCDOJINH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x69422A0", Offset = "0x69412A0", VA = "0x1869422A0")]
	public static void LLIGCOFDNEC(this IncrementalHash HBFGLPMFMGA, ulong DPHPDCIPPEH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x6941AD0", Offset = "0x6940AD0", VA = "0x186941AD0")]
	public static void DOECGFMLDAJ(this IncrementalHash HBFGLPMFMGA, uint MCGOJDMCCOK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x6942300", Offset = "0x6941300", VA = "0x186942300")]
	public static void MANLDPANDHO(this IncrementalHash HBFGLPMFMGA, ushort HHAFJGFBLMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x6941D00", Offset = "0x6940D00", VA = "0x186941D00")]
	public static void JEGDFMGKHFM(this IncrementalHash HBFGLPMFMGA, Vector3 GIIBLGKHAOA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class MFMEFJPDNLF : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x6945210", Offset = "0x6944210", VA = "0x186945210")]
	public MFMEFJPDNLF(string NFOHONOFFAP)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public abstract class INFAELCLPHC<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	internal class DMMCBDBDCJE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public TNode OLDDCPCBGIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public TNode HHMPHBNGMGF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public BABEIKLBGFG BMDINFODMJG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public List<BABEIKLBGFG> ALGAJJDIKFB;

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
		public DMMCBDBDCJE()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	internal struct BABEIKLBGFG : IComparable<BABEIKLBGFG>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public int NPMDLCEJBKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public TClaimant HOIIPDJHIKH;

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0xD91A30", Offset = "0xD90A30", VA = "0x180D91A30")]
		public BABEIKLBGFG(int NPMDLCEJBKO, TClaimant HOIIPDJHIKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x4E6A9B0", Offset = "0x4E699B0", VA = "0x184E6A9B0")]
		public bool LAMFCFLDJCH([In] BABEIKLBGFG LJAAPFIIPOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x4E6A9A0", Offset = "0x4E699A0", VA = "0x184E6A9A0")]
		public bool IEEJEMKLJNC([In] BABEIKLBGFG LJAAPFIIPOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x4E6A990", Offset = "0x4E69990", VA = "0x184E6A990", Slot = "4")]
		public int CompareTo(BABEIKLBGFG LJAAPFIIPOF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x4E6AA10", Offset = "0x4E69A10", VA = "0x184E6AA10", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public enum KMNCJBJKGLJ
	{
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class AOOCDFBBOIE : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DA")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DB")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DC")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DD")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DE")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000DF")]
		public INFAELCLPHC<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E0")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E1")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E2")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E3")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x1700004B")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001A7")]
			[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004C")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001A9")]
			[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x8BF370", Offset = "0x8BE370", VA = "0x1808BF370")]
		[DebuggerHidden]
		public AOOCDFBBOIE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x3E89B30", Offset = "0x3E88B30", VA = "0x183E89B30", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x3E89D10", Offset = "0x3E88D10", VA = "0x183E89D10", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x3E89C10", Offset = "0x3E88C10", VA = "0x183E89C10", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x3980620", Offset = "0x397F620", VA = "0x183980620", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly DKMDBKIJEFM<DMMCBDBDCJE> DBDMMILNJAF;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly DKMDBKIJEFM<List<BABEIKLBGFG>> KGHPBONCHHF;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static int KMEOGCMHOFF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	internal readonly Dictionary<TClaimant, TNode> LNMOBNIMNCI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	internal readonly Dictionary<TNode, DMMCBDBDCJE> ILDPJJHGGMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private KMNCJBJKGLJ LAHMDGOAKPJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private bool MMNAIEEGDFD;

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode NEBBPAGEGKE(TNode MPJOKOKILNG);

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void LHILHJPLLPE(TNode MPJOKOKILNG, TClaimant JFMFKMBDOFI, TClaimant AIDKEDKFFBA);

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x3EE1960", Offset = "0x3EE0960", VA = "0x183EE1960")]
	public INFAELCLPHC(KMNCJBJKGLJ LAHMDGOAKPJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x3EE0AC0", Offset = "0x3EDFAC0", VA = "0x183EE0AC0")]
	public void IGJFNKOECBO(TNode MPJOKOKILNG, TNode NAEADMGDGFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x3EDFFE0", Offset = "0x3EDEFE0", VA = "0x183EDFFE0")]
	public void DAGFJCKCIAF(TClaimant HOIIPDJHIKH, TNode PKBOBNEDJDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x3EE0180", Offset = "0x3EDF180", VA = "0x183EE0180", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x3EE03B0", Offset = "0x3EDF3B0", VA = "0x183EE03B0")]
	private void EEPFLNGCOPH(TClaimant HOIIPDJHIKH, TNode BFIAACADPHE, TNode PKBOBNEDJDF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x3EE0A50", Offset = "0x3EDFA50", VA = "0x183EE0A50")]
	private int HKCKLLMGCNH()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x3EE0B90", Offset = "0x3EDFB90", VA = "0x183EE0B90")]
	private void KPCKGAKHOJF(TClaimant HOIIPDJHIKH, TNode HMFDFHFCKOK, TNode OIEOMIHHCCH, int OKDJKMDHJGO = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x3EE11E0", Offset = "0x3EE01E0", VA = "0x183EE11E0")]
	private void NFKDFOOHNCG(BABEIKLBGFG BOPEKCLNHDH, DMMCBDBDCJE LFGOPFNHKKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x3EE0750", Offset = "0x3EDF750", VA = "0x183EE0750")]
	private void GJNOKMBKKOF(TClaimant HOIIPDJHIKH, TNode HMFDFHFCKOK, TNode OIEOMIHHCCH, int OKDJKMDHJGO = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x3EE1630", Offset = "0x3EE0630", VA = "0x183EE1630")]
	private void OEFCEJAKDLH(BABEIKLBGFG BOPEKCLNHDH, TNode MPJOKOKILNG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x3EE0480", Offset = "0x3EDF480", VA = "0x183EE0480")]
	private void EIOFDAEDALL(BABEIKLBGFG BOPEKCLNHDH, DMMCBDBDCJE LFGOPFNHKKH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x3EE05F0", Offset = "0x3EDF5F0", VA = "0x183EE05F0")]
	private void GBBHICHNAFK(DMMCBDBDCJE LFGOPFNHKKH, bool JPIHGDGKHKI = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x3EE12C0", Offset = "0x3EE02C0", VA = "0x183EE12C0")]
	private void NOBGOIJOOCD(DMMCBDBDCJE LFGOPFNHKKH, TNode NAEADMGDGFI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x3EDFEE0", Offset = "0x3EDEEE0", VA = "0x183EDFEE0")]
	[IteratorStateMachine(typeof(INFAELCLPHC<, >.AOOCDFBBOIE))]
	private IEnumerable<TNode> CGNGOJNEEAH(TNode HMFDFHFCKOK, TNode OIEOMIHHCCH, bool CNFGDMMICAA = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x3EE10C0", Offset = "0x3EE00C0", VA = "0x183EE10C0")]
	private DMMCBDBDCJE NELPMHNDHLH(TNode MPJOKOKILNG, TNode HHMPHBNGMGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x3EDFD50", Offset = "0x3EDED50", VA = "0x183EDFD50")]
	private DMMCBDBDCJE APNDBOMBPEL(TNode MPJOKOKILNG, TNode HHMPHBNGMGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x3EE0EF0", Offset = "0x3EDFEF0", VA = "0x183EE0EF0")]
	private void LBMPBAHAFLC(DMMCBDBDCJE LFGOPFNHKKH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class POKEMGHGOGK<T> : IEnumerable<POKEMGHGOGK<T>.NMFDIEPGDOH>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public struct NMFDIEPGDOH
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public T CBAEIEAPLIH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public int LLPJHIPCNFD;
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class MCMOPNPPABO : IEnumerator<NMFDIEPGDOH>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private POKEMGHGOGK<T> JFPGMJFEBIM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private int LLPJHIPCNFD;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x3865390", Offset = "0x3864390", VA = "0x183865390", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public NMFDIEPGDOH NKNICMABPJA
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x44D3860", Offset = "0x44D2860", VA = "0x1844D3860", Slot = "4")]
			get
			{
				return default(NMFDIEPGDOH);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x44D3770", Offset = "0x44D2770", VA = "0x1844D3770")]
		public MCMOPNPPABO(POKEMGHGOGK<T> JFPGMJFEBIM)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x44D36F0", Offset = "0x44D26F0", VA = "0x1844D36F0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x38B9060", Offset = "0x38B8060", VA = "0x1838B9060", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x93CBF0", Offset = "0x93BBF0", VA = "0x18093CBF0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	private struct PPBBCDOLDJL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public bool AJAPEAEMNGL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public T CBAEIEAPLIH;
	}

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private const int LLDCFEHMCCG = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private readonly Dictionary<T, int> LENGGCPEAHH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private PPBBCDOLDJL[] BAMOACLFMDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private int LPGNCNHMEAM;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public int EGHJDBFBCCK
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x8A4FC0", Offset = "0x8A3FC0", VA = "0x1808A4FC0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x8A4DF0", Offset = "0x8A3DF0", VA = "0x1808A4DF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public int FGAKKPCAMNO
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x3574890", Offset = "0x3573890", VA = "0x183574890")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x47B56C0", Offset = "0x47B46C0", VA = "0x1847B56C0")]
	public POKEMGHGOGK(int NAFKLJDAKHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x47B57B0", Offset = "0x47B47B0", VA = "0x1847B57B0")]
	public POKEMGHGOGK(NMFDIEPGDOH[] OECAFMGFKCI, bool HGFNPMIOACG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x47B48E0", Offset = "0x47B38E0", VA = "0x1847B48E0")]
	public int GPMKHPLAPFG()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x47B4620", Offset = "0x47B3620", VA = "0x1847B4620")]
	private int DGBHBAFDBLD()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x47B4AC0", Offset = "0x47B3AC0", VA = "0x1847B4AC0", Slot = "6")]
	protected virtual uint KOJPGJKIHIL(uint HBFGLPMFMGA, T CBAEIEAPLIH)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x47B4B20", Offset = "0x47B3B20", VA = "0x1847B4B20")]
	public bool OPOGKFMEAHP(T CBAEIEAPLIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x47B49B0", Offset = "0x47B39B0", VA = "0x1847B49B0")]
	public int INDADLDEPLA(T CBAEIEAPLIH)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x47B4390", Offset = "0x47B3390", VA = "0x1847B4390")]
	public T CMHCDGKNPKK(int LLPJHIPCNFD)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x47B5100", Offset = "0x47B4100", VA = "0x1847B5100")]
	public bool PFKIIIIKFDA(T CBAEIEAPLIH, bool BMGIBDDFKFD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x47B4E90", Offset = "0x47B3E90", VA = "0x1847B4E90")]
	public bool PFKIIIIKFDA(T CBAEIEAPLIH, int LLPJHIPCNFD, bool BMGIBDDFKFD = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x47B4890", Offset = "0x47B3890", VA = "0x1847B4890")]
	private int ECMHHPJCFIP(int GEIGDPFELPO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x47B51D0", Offset = "0x47B41D0", VA = "0x1847B51D0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x47B51D0", Offset = "0x47B41D0", VA = "0x1847B51D0", Slot = "4")]
	private IEnumerator<NMFDIEPGDOH> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class DKMDBKIJEFM<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly Stack<T> LELPBFPMPGI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly List<T> MOBIOIJHMJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private readonly int MLFJOKLMFNK;

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x5856D10", Offset = "0x5855D10", VA = "0x185856D10")]
	public static DKMDBKIJEFM<T> EGKLNGNLINK(int NAFKLJDAKHD = 0, int MLFJOKLMFNK = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x58571C0", Offset = "0x58561C0", VA = "0x1858571C0")]
	public static DKMDBKIJEFM<T> KBGAOIMKKPI(int NAFKLJDAKHD = 0, int MLFJOKLMFNK = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x58573C0", Offset = "0x58563C0", VA = "0x1858573C0")]
	public DKMDBKIJEFM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x5857410", Offset = "0x5856410", VA = "0x185857410")]
	public DKMDBKIJEFM(int NAFKLJDAKHD, int MLFJOKLMFNK = int.MaxValue, bool HANIHNJCOGC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x5856B50", Offset = "0x5855B50", VA = "0x185856B50")]
	public T EBAPBDCJHHO()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x5856E10", Offset = "0x5855E10", VA = "0x185856E10")]
	public void HLGENIPLFCF(T CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x58572C0", Offset = "0x58562C0", VA = "0x1858572C0")]
	private void KHPJLAACEAL(T CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x5856EF0", Offset = "0x5855EF0", VA = "0x185856EF0")]
	private void IBLCILDMDII(T CBAEIEAPLIH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x58569C0", Offset = "0x58559C0", VA = "0x1858569C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x5856F40", Offset = "0x5855F40", VA = "0x185856F40")]
	private void IPAGLIBOPOG(IEnumerable<T> CNNODMDOLAC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class FOFJOCGLDFI<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private Dictionary<int, T> OLGJECBHAKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private T EICDBNPOLLD;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public virtual T HONNLEHENLK
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x869510", Offset = "0x868510", VA = "0x180869510", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x867DF0", Offset = "0x866DF0", VA = "0x180867DF0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x3C9B3C0", Offset = "0x3C9A3C0", VA = "0x183C9B3C0")]
	public bool PBGBCGOCNGM(T CBAEIEAPLIH, int NPMDLCEJBKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x3C9AFF0", Offset = "0x3C99FF0", VA = "0x183C9AFF0")]
	public bool JHPDIDIEFLE(int NPMDLCEJBKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x3C9B680", Offset = "0x3C9A680", VA = "0x183C9B680")]
	public T PEHIIINHNFH(int FKEFBODPAFA)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x3C9B100", Offset = "0x3C9A100", VA = "0x183C9B100")]
	private bool OHFJJEKHMLL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x3C9B0A0", Offset = "0x3C9A0A0", VA = "0x183C9B0A0")]
	public bool MMCLNKMOKEF(int NPMDLCEJBKO, [Out] T CBAEIEAPLIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x3C9B880", Offset = "0x3C9A880", VA = "0x183C9B880")]
	public FOFJOCGLDFI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class HBPMCKBOIAG<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	protected struct CKEPMNAOKDG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public T BLBBIKKJHJE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public int FCJPGHMLOML;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	protected readonly List<CKEPMNAOKDG> LCIJAGELCDA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private T MEFCCJKJJDO;

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public int FGAKKPCAMNO
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x3574890", Offset = "0x3573890", VA = "0x183574890")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x3DC68E0", Offset = "0x3DC58E0", VA = "0x183DC68E0")]
	public bool PMELAKIMKGE(T CBAEIEAPLIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x3DC6310", Offset = "0x3DC5310", VA = "0x183DC6310")]
	public void MJFEDCBJOBF(T CBAEIEAPLIH, int NPMDLCEJBKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x3DC5E90", Offset = "0x3DC4E90", VA = "0x183DC5E90")]
	public bool GAGDAFIMOPK(T CBAEIEAPLIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x3DC63D0", Offset = "0x3DC53D0", VA = "0x183DC63D0")]
	public void OAIAOCAHOEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x3DC5DE0", Offset = "0x3DC4DE0", VA = "0x183DC5DE0")]
	public T ANFJKGOCCNE()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x3DC65E0", Offset = "0x3DC55E0", VA = "0x183DC65E0")]
	protected void PEECCLCNBKI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x3DC6B10", Offset = "0x3DC5B10", VA = "0x183DC6B10")]
	public HBPMCKBOIAG()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000063")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		[SerializeField]
		[AIILLFBIOKD(CKKEEFADMDD.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x6945920", Offset = "0x6944920", VA = "0x186945920")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x6945BF0", Offset = "0x6944BF0", VA = "0x186945BF0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x6945B00", Offset = "0x6944B00", VA = "0x186945B00")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x6945870", Offset = "0x6944870", VA = "0x186945870")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x6945B40", Offset = "0x6944B40", VA = "0x186945B40")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x6945A50", Offset = "0x6944A50", VA = "0x186945A50")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x69457E0", Offset = "0x69447E0", VA = "0x1869457E0")]
		public ReferencePoint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	public abstract class ResourcePrefabReference<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0x496C040", Offset = "0x496B040", VA = "0x18496C040", Slot = "4")]
		public virtual T AAJDLNJKMEF()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class LAFPMBLNGOO : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private Dictionary<byte, JONJLFJIMBK> JJDIEHCEOPM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private readonly DKMDBKIJEFM<JONJLFJIMBK> KNKFEMPKPLL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private readonly bool PCIBDJDJLCI;

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public JONJLFJIMBK EGNFKMGGDNB
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x8687C0", Offset = "0x8677C0", VA = "0x1808687C0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x8687E0", Offset = "0x8677E0", VA = "0x1808687E0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public Vector2 IMKJAGFMKPE
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0xD3BE20", Offset = "0xD3AE20", VA = "0x180D3BE20")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x101E450", Offset = "0x101D450", VA = "0x18101E450")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	private Vector2 KNNFPOHPLBG
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x1083F60", Offset = "0x1082F60", VA = "0x181083F60")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public Vector2 AOFCHLKOPOG
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x6944190", Offset = "0x6943190", VA = "0x186944190")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x86FF00", Offset = "0x86EF00", VA = "0x18086FF00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public int CDCHHNENAFN
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x8711C0", Offset = "0x8701C0", VA = "0x1808711C0")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x870C60", Offset = "0x86FC60", VA = "0x180870C60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x6945090", Offset = "0x6944090", VA = "0x186945090")]
	public LAFPMBLNGOO(Bounds ENKDCGIMNDP, Vector2[] PJJIPKDGHPH, int EPILGPKFIEO, byte GEIGDPFELPO, float PGJDDCEFNGO = 0f, [Optional] DKMDBKIJEFM<JONJLFJIMBK> KNKFEMPKPLL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x6944BF0", Offset = "0x6943BF0", VA = "0x186944BF0")]
	public void OOGFFGLNAAK(Bounds ENKDCGIMNDP, Vector2[] PJJIPKDGHPH, int EPILGPKFIEO, byte GEIGDPFELPO, float PGJDDCEFNGO = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x69440D0", Offset = "0x69430D0", VA = "0x1869440D0")]
	public JONJLFJIMBK DJMBNPDGGNN(byte LLPJHIPCNFD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x69443E0", Offset = "0x69433E0", VA = "0x1869443E0")]
	public void FKJPIIJCPGJ(Vector3 MOIICCIPACK, float BPAGEBDGFKJ, float AEOLGPMGKGH, List<byte> NPMODPFBIBJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x69444B0", Offset = "0x69434B0", VA = "0x1869444B0")]
	public void FNEGPKLPAIL(JONJLFJIMBK.AFGMJBOPCMJ NBFJLICFPFP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x6944B00", Offset = "0x6943B00", VA = "0x186944B00")]
	public static int ONGIFNKMLNC(Vector2[] PJJIPKDGHPH, int EPILGPKFIEO)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x69441B0", Offset = "0x69431B0", VA = "0x1869441B0")]
	private JONJLFJIMBK EJNHCINBENB(byte LLPJHIPCNFD, JONJLFJIMBK.ONBDKIKDMGH DNHPFFOEEHL, JONJLFJIMBK HHMPHBNGMGF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x6944750", Offset = "0x6943750", VA = "0x186944750")]
	private void MKJJPBCABOK(JONJLFJIMBK HHMPHBNGMGF, Vector2[] PJJIPKDGHPH, int FNLCJEELAEJ, int JFBPLADNENM, int FFIDMODDNBO, int NCPBIFDMNBM, float PGJDDCEFNGO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x6944530", Offset = "0x6943530", VA = "0x186944530")]
	private void MJNKLIGAOML()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x6944130", Offset = "0x6943130", VA = "0x186944130", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x69444D0", Offset = "0x69434D0", VA = "0x1869444D0", Slot = "1")]
	~LAFPMBLNGOO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class JONJLFJIMBK
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public enum ONBDKIKDMGH
	{
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public enum AFGMJBOPCMJ
	{
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		LeavesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		NodesOnly,
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		RootOnly,
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		All
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
	[Cpp2IlInjected.Token(Token = "0x4000105")]
	public byte FDMEMBGGBHO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public Vector3 PGGBDIGHJFD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public Vector3 PMILGDKKIIM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public Vector3 BGMPDHODCNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public Vector3 HJGJMIBPKHI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public ONBDKIKDMGH HHOOFCPEKDO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public JONJLFJIMBK EGEBOODOFAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public List<JONJLFJIMBK> IGBHKOEONFG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public bool COMMBDLAOKO;

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x69437B0", Offset = "0x69427B0", VA = "0x1869437B0")]
	public JONJLFJIMBK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x6943610", Offset = "0x6942610", VA = "0x186943610")]
	public void GAMMKDIBDLH(JONJLFJIMBK FLFKBMMIINC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x866350", Offset = "0x865350", VA = "0x180866350")]
	public void FNEGPKLPAIL(int BEHDJHJCKHM, AFGMJBOPCMJ NBFJLICFPFP, int LEKBLIFLCLN = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x69433B0", Offset = "0x69423B0", VA = "0x1869433B0")]
	public void FKJPIIJCPGJ(List<byte> NPMODPFBIBJ, Vector3 MOIICCIPACK, float BPAGEBDGFKJ, float AEOLGPMGKGH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x6943780", Offset = "0x6942780", VA = "0x186943780")]
	public bool ODOFBNDEKHK(Vector3 BJEINPMOICP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x6943750", Offset = "0x6942750", VA = "0x186943750")]
	public bool GPHPEGIHHJC(Vector3 BJEINPMOICP, float JNADDPDGDFE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x6943320", Offset = "0x6942320", VA = "0x186943320")]
	public void BGGINNGCCML()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x200006A")]
		public struct BFCNMAKKHCA<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			private readonly List<Component> DNOAHHGKGFF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			private readonly bool MECPBBLPKPA;

			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x3D3AFB0", Offset = "0x3D39FB0", VA = "0x183D3AFB0")]
			public BFCNMAKKHCA(List<Component> DNOAHHGKGFF, bool MECPBBLPKPA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x4E7D970", Offset = "0x4E7C970", VA = "0x184E7D970")]
			public AMHLNHBPGEC<T> AKHPNFMFJMK()
			{
				return default(AMHLNHBPGEC<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x4E7D9E0", Offset = "0x4E7C9E0", VA = "0x184E7D9E0", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x4E7D9E0", Offset = "0x4E7C9E0", VA = "0x184E7D9E0", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006B")]
		public struct AMHLNHBPGEC<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			private readonly List<Component> DNOAHHGKGFF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			private readonly bool MECPBBLPKPA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			private int LLPJHIPCNFD;

			[Cpp2IlInjected.Token(Token = "0x1700005E")]
			public T NKNICMABPJA
			{
				[Cpp2IlInjected.Token(Token = "0x6000211")]
				[Cpp2IlInjected.Address(RVA = "0x3E81820", Offset = "0x3E80820", VA = "0x183E81820", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000212")]
				[Cpp2IlInjected.Address(RVA = "0x3E817B0", Offset = "0x3E807B0", VA = "0x183E817B0", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x3E817F0", Offset = "0x3E807F0", VA = "0x183E817F0")]
			public AMHLNHBPGEC(List<Component> DNOAHHGKGFF, bool MECPBBLPKPA)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x3E816F0", Offset = "0x3E806F0", VA = "0x183E816F0", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x3E81700", Offset = "0x3E80700", VA = "0x183E81700", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x38ABF50", Offset = "0x38AAF50", VA = "0x1838ABF50", Slot = "8")]
			public void Reset()
			{
			}
		}

		[NonSerialized]
		[Cpp2IlInjected.Token(Token = "0x4000117")]
		private static List<Component> INSTANTANEOUS_COMPONENT_LIST;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000118")]
		[SerializeField]
		private GameObject root;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000119")]
		[SerializeField]
		private List<Transform> descendents;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x400011A")]
		private Dictionary<Type, List<Component>> componentCache;

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x6000200")]
			[Cpp2IlInjected.Address(RVA = "0x6947640", Offset = "0x6946640", VA = "0x186947640")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x86E790", Offset = "0x86D790", VA = "0x18086E790")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x6946F60", Offset = "0x6945F60", VA = "0x186946F60")]
		private void BGGINNGCCML(GameObject EFDDHMOHOKH, bool BAKDLGCFEEB = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x69470D0", Offset = "0x69460D0", VA = "0x1869470D0")]
		public static void BGGINNGCCML(GameObject EFDDHMOHOKH, ToolHierarchyCache AMAMLMNLJEL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x69475A0", Offset = "0x69465A0", VA = "0x1869475A0")]
		public void PMBGKANLDAP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x2E3C1B0", Offset = "0x2E3B1B0", VA = "0x182E3C1B0")]
		public void JALBOCHMIPI<T>(Action<T> OGLJLDNLGIJ)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x2E3C050", Offset = "0x2E3B050", VA = "0x182E3C050")]
		public T EIGKBHBFDCJ<T>(bool MECPBBLPKPA = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x2E3C0F0", Offset = "0x2E3B0F0", VA = "0x182E3C0F0")]
		public BFCNMAKKHCA<T> IDJDBADHHEI<T>(bool MECPBBLPKPA = false) where T : class
		{
			return default(BFCNMAKKHCA<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x6947160", Offset = "0x6946160", VA = "0x186947160")]
		public List<Component> CJBKIHCMKJH(Type PBLNJHEPKAE)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x69474B0", Offset = "0x69464B0", VA = "0x1869474B0", Slot = "4")]
		public bool Equals(ToolHierarchyCache OOALEDCPNBJ, ToolHierarchyCache HDFOCKKCOOF)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x6947530", Offset = "0x6946530", VA = "0x186947530", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache HBFCGFKGCAF)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class JELPAGKGOPA<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private int NAFKLJDAKHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private int JEAOFIHABKG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private List<T> FOGJCPKBILL;

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public int FGAKKPCAMNO
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x3C412A0", Offset = "0x3C402A0", VA = "0x183C412A0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public T AOODDNLKEHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x4099250", Offset = "0x4098250", VA = "0x184099250")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public T IMIJMGLDOAA
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x4098C20", Offset = "0x4097C20", VA = "0x184098C20")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public T BEMPDGJHIEB
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x4098D10", Offset = "0x4097D10", VA = "0x184098D10")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x4099400", Offset = "0x4098400", VA = "0x184099400")]
	public JELPAGKGOPA(int NAFKLJDAKHD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x4098F10", Offset = "0x4097F10", VA = "0x184098F10")]
	public void MJFEDCBJOBF(T NIBEIDMELHN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x40991F0", Offset = "0x40981F0", VA = "0x1840991F0")]
	public void OAIAOCAHOEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x4098DA0", Offset = "0x4097DA0", VA = "0x184098DA0")]
	public void KEIDJNNFHMM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x4098EA0", Offset = "0x4097EA0", VA = "0x184098EA0")]
	public void LBGBECMFECD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x4098D90", Offset = "0x4097D90", VA = "0x184098D90")]
	public void KCNNJPKBAHH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class BBAKHMHBGDD<T>
{
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private struct DDKIFJGBJEB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public int FCJPGHMLOML;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public T BLBBIKKJHJE;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private readonly Dictionary<object, DDKIFJGBJEB> OLGJECBHAKN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private readonly EqualityComparer<T> MIFDEBLGINO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private T EICDBNPOLLD;

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public virtual T HONNLEHENLK
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x8D74F0", Offset = "0x8D64F0", VA = "0x1808D74F0", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x4E6FFB0", Offset = "0x4E6EFB0", VA = "0x184E6FFB0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public bool OFLLKLACFCI
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x4E6FF40", Offset = "0x4E6EF40", VA = "0x184E6FF40")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public object DANIGNPKJBG
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x868820", Offset = "0x867820", VA = "0x180868820")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x868800", Offset = "0x867800", VA = "0x180868800")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x4E73780", Offset = "0x4E72780", VA = "0x184E73780")]
	public bool PBGBCGOCNGM(T CBAEIEAPLIH, object OEDJKICDDGA, int NPMDLCEJBKO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x4E6FE80", Offset = "0x4E6EE80", VA = "0x184E6FE80")]
	public bool JHPDIDIEFLE(object OEDJKICDDGA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x4E705B0", Offset = "0x4E6F5B0", VA = "0x184E705B0")]
	public bool MMCLNKMOKEF(object OEDJKICDDGA, [Out] T CBAEIEAPLIH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x3DE5080", Offset = "0x3DE4080", VA = "0x183DE5080")]
	public void OAIAOCAHOEL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x4E72060", Offset = "0x4E71060", VA = "0x184E72060")]
	private bool OHFJJEKHMLL()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x4E74490", Offset = "0x4E73490", VA = "0x184E74490")]
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
