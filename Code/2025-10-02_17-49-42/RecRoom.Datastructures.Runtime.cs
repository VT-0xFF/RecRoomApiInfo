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
		[Cpp2IlInjected.Address(RVA = "0xAD77F0", Offset = "0xAD61F0", VA = "0x180AD77F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x84B4B10", Offset = "0x84B3510", VA = "0x1884B4B10")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0xAD85C0", Offset = "0xAD6FC0", VA = "0x180AD85C0")]
		public NullableAttribute(byte[] P_0)
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000004")]
	[Microsoft.CodeAnalysis.Embedded]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate, AllowMultiple = false, Inherited = false)]
	[CompilerGenerated]
	internal sealed class NullableContextAttribute : Attribute
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000002")]
		public readonly byte Flag;

		[Cpp2IlInjected.Token(Token = "0x6000004")]
		[Cpp2IlInjected.Address(RVA = "0xAD8600", Offset = "0xAD7000", VA = "0x180AD8600")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class FJJLKMKOEBI : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x2421520", Offset = "0x241FF20", VA = "0x182421520")]
	public FJJLKMKOEBI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HashableScriptableObject : ScriptableObject, JMJMLMPFNDK, GGAIAGHDLPJ, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0xE2F470", Offset = "0xE2DE70", VA = "0x180E2F470", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash LMLHBIBFOGI);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0xD5D430", Offset = "0xD5BE30", VA = "0x180D5D430")]
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
	[ReadOnlyField]
	[SerializeField]
	[HideInInspector]
	private List<Vector3> innerLocalPoints;

	[Cpp2IlInjected.Token(Token = "0x17000004")]
	public Vector3 LocalSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x600000F")]
		[Cpp2IlInjected.Address(RVA = "0x84B5DE0", Offset = "0x84B47E0", VA = "0x1884B5DE0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x84B5DA0", Offset = "0x84B47A0", VA = "0x1884B5DA0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x84B5E20", Offset = "0x84B4820", VA = "0x1884B5E20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x84B5FD0", Offset = "0x84B49D0", VA = "0x1884B5FD0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x84B5F40", Offset = "0x84B4940", VA = "0x1884B5F40")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0xB05990", Offset = "0xB04390", VA = "0x180B05990")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0xB059A0", Offset = "0xB043A0", VA = "0x180B059A0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x84B5D60", Offset = "0x84B4760", VA = "0x1884B5D60")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x84B5EB0", Offset = "0x84B48B0", VA = "0x1884B5EB0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x84B5800", Offset = "0x84B4200", VA = "0x1884B5800")]
	public void CopyBounds(SavedExtents GOCNHGEHNFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x84B5CB0", Offset = "0x84B46B0", VA = "0x1884B5CB0")]
	public void SetLocalSpaceBounds(Bounds OGNLLMANMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0x1745970", Offset = "0x1744370", VA = "0x181745970")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x84B5CA0", Offset = "0x84B46A0", VA = "0x1884B5CA0")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x84B58F0", Offset = "0x84B42F0", VA = "0x1884B58F0")]
	private void LNDMCDAPNIH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x84B5AA0", Offset = "0x84B44A0", VA = "0x1884B5AA0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x84B5190", Offset = "0x84B3B90", VA = "0x1884B5190")]
	public static void CalculateLocalBoundsFor(GameObject FNCBMCHNDJI, [Out] Bounds OGNLLMANMFH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x84B5830", Offset = "0x84B4230", VA = "0x1884B5830")]
	private static void ECJKCFKEBBI(Bounds MIBIEOGGIAP, Color DMCCCPMAFCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x84B5CD0", Offset = "0x84B46D0", VA = "0x1884B5CD0")]
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
		[Cpp2IlInjected.Address(RVA = "0xAAC180", Offset = "0xAAAB80", VA = "0x180AAC180")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xAB8CD0", Offset = "0xAB76D0", VA = "0x180AB8CD0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x1C21A70", Offset = "0x1C20470", VA = "0x181C21A70")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x5EFC700", Offset = "0x5EFB100", VA = "0x185EFC700")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public virtual void DEJGLIBJDHI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
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
	[FJJLKMKOEBI]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x5EFC300", Offset = "0x5EFAD00", VA = "0x185EFC300", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x5EFB010", Offset = "0x5EF9A10", VA = "0x185EFB010", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x5EFC660", Offset = "0x5EFB060", VA = "0x185EFC660")]
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
	private sealed class LGDILNCABDA
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public LGDILNCABDA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x5729D00", Offset = "0x5728700", VA = "0x185729D00")]
		internal int HPHGPMDFBJF(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[FJJLKMKOEBI]
	[SerializeField]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x4B47E30", Offset = "0x4B46830", VA = "0x184B47E30", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x4B47E80", Offset = "0x4B46880", VA = "0x184B47E80", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x4B47D30", Offset = "0x4B46730", VA = "0x184B47D30", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey HPFHOBCPNEF]
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x4B47DD0", Offset = "0x4B467D0", VA = "0x184B47DD0", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x4B47C20", Offset = "0x4B46620", VA = "0x184B47C20", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x4B47930", Offset = "0x4B46330", VA = "0x184B47930", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x4B46DA0", Offset = "0x4B457A0", VA = "0x184B46DA0", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x4B46CA0", Offset = "0x4B456A0", VA = "0x184B46CA0", Slot = "14")]
	protected virtual string GANGEJKJFBJ(TKeyVal IFHPIFMHEPP)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x4B46C20", Offset = "0x4B45620", VA = "0x184B46C20", Slot = "4")]
	public bool ContainsKey(TKey HPFHOBCPNEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x4B47AE0", Offset = "0x4B464E0", VA = "0x184B47AE0", Slot = "5")]
	public bool TryGetValue(TKey HPFHOBCPNEF, [Out] TVal KMAFNKGMDCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x4B46D00", Offset = "0x4B45700", VA = "0x184B46D00", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x4B46D00", Offset = "0x4B45700", VA = "0x184B46D00", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x4B47B30", Offset = "0x4B46530", VA = "0x184B47B30")]
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
	[SerializeField]
	[SerializeReference]
	private TVal _val;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public TKey Key
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000040")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000041")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
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
		[Cpp2IlInjected.Address(RVA = "0x45C5A90", Offset = "0x45C4490", VA = "0x1845C5A90")]
		public SerializedReferenceKeyValuePair()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	[FJJLKMKOEBI]
	[SerializeField]
	private List<SerializedReferenceKeyValuePair> serializedData;

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x5EFDEB0", Offset = "0x5EFC8B0", VA = "0x185EFDEB0")]
	protected SerializedReferenceDictionary()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000044")]
	[Cpp2IlInjected.Address(RVA = "0x5EFD780", Offset = "0x5EFC180", VA = "0x185EFD780", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000045")]
	[Cpp2IlInjected.Address(RVA = "0x5EFCD80", Offset = "0x5EFB780", VA = "0x185EFCD80", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000010")]
public abstract class IMOKGLJIOFD<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000011")]
	public struct NDIAPBINOBG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		public T AFPBILBCKEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		public float LOCFPHLBLIP;
	}

	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private const int BEADIGJFFLC = 16;

	[Cpp2IlInjected.Token(Token = "0x4000017")]
	private const float MCJEFCFKCMF = -1f;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001A")]
	protected readonly NDIAPBINOBG[] BHEONMJLANC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001B")]
	protected int BJKDHKPMAHI;

	[Cpp2IlInjected.Token(Token = "0x17000016")]
	public float JCHLEBLEEDI
	{
		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0xDA71D0", Offset = "0xDA5BD0", VA = "0x180DA71D0")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0xE217B0", Offset = "0xE201B0", VA = "0x180E217B0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public T IGBAKDDOHDD
	{
		[Cpp2IlInjected.Token(Token = "0x6000049")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004B")]
	[Cpp2IlInjected.Address(RVA = "0x52F4680", Offset = "0x52F3080", VA = "0x1852F4680")]
	protected IMOKGLJIOFD()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x52F46A0", Offset = "0x52F30A0", VA = "0x1852F46A0")]
	protected IMOKGLJIOFD(int BCAJFCGHDKI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x52F44B0", Offset = "0x52F2EB0", VA = "0x1852F44B0")]
	public void HMDNMGBNKIA(float LKKNOPLOOPB, T KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract bool CDJEICBHCIA(float OFLPMAPNJKG, float PDIIAGIDEOG, [Out] T KMAFNKGMDCF);

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	public abstract bool EBHJGKABBOM(float OFLPMAPNJKG, float PDIIAGIDEOG, [Out] T KMAFNKGMDCF);

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x52F4450", Offset = "0x52F2E50", VA = "0x1852F4450")]
	public void EMMOLKMNHIK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000012")]
public class EACLOILJBCA : IMOKGLJIOFD<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x84B2110", Offset = "0x84B0B10", VA = "0x1884B2110", Slot = "4")]
	public override bool CDJEICBHCIA(float OFLPMAPNJKG, float PDIIAGIDEOG, [Out] Vector3 KMAFNKGMDCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x84B2270", Offset = "0x84B0C70", VA = "0x1884B2270", Slot = "5")]
	public override bool EBHJGKABBOM(float OFLPMAPNJKG, float PDIIAGIDEOG, [Out] Vector3 KMAFNKGMDCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x84B23B0", Offset = "0x84B0DB0", VA = "0x1884B23B0")]
	public EACLOILJBCA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public static class BOJKPDFLPIG
{
	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3B2F140", Offset = "0x3B2DB40", VA = "0x183B2F140")]
	public static CPMDBLLCOLH<T1, T2> MLAHKGEEKLJ<T1, T2>(T1 DLNKGOFPLPN, T2 CALJIGCLFDI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(RVA = "0x3B2F1C0", Offset = "0x3B2DBC0", VA = "0x183B2F1C0")]
	public static KHAIHDNCBDG<T1, T2, T3> MLAHKGEEKLJ<T1, T2, T3>(T1 DLNKGOFPLPN, T2 CALJIGCLFDI, T3 GCNFNKEIKDJ)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(RVA = "0x5A27470", Offset = "0x5A25E70", VA = "0x185A27470")]
	internal static int KADNJECGHBJ(int ECGFCFCOCOO, int PMDKNLBIBBP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(RVA = "0x75F99D0", Offset = "0x75F83D0", VA = "0x1875F99D0")]
	internal static int KADNJECGHBJ(int ECGFCFCOCOO, int PMDKNLBIBBP, int DIAEPFOJICM)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public class CPMDBLLCOLH<T1, T2> : IComparable<CPMDBLLCOLH<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	public readonly T1 NFPNKFHIKHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001F")]
	public readonly T2 OOBLEOAPAPL;

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(RVA = "0x6EC05A0", Offset = "0x6EBEFA0", VA = "0x186EC05A0")]
	public CPMDBLLCOLH(T1 DLNKGOFPLPN, T2 CALJIGCLFDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000059")]
	[Cpp2IlInjected.Address(RVA = "0x6EBE9F0", Offset = "0x6EBD3F0", VA = "0x186EBE9F0", Slot = "4")]
	public int CompareTo(CPMDBLLCOLH<T1, T2> GOCNHGEHNFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x6EBF110", Offset = "0x6EBDB10", VA = "0x186EBF110", Slot = "0")]
	public override bool Equals(object GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x6EBFAA0", Offset = "0x6EBE4A0", VA = "0x186EBFAA0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x6EBFE50", Offset = "0x6EBE850", VA = "0x186EBFE50", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class KHAIHDNCBDG<T1, T2, T3> : IComparable<KHAIHDNCBDG<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	public readonly T1 NFPNKFHIKHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	public readonly T2 OOBLEOAPAPL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000022")]
	public readonly T3 JLGMJKCMLCK;

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x5662750", Offset = "0x5661150", VA = "0x185662750")]
	public KHAIHDNCBDG(T1 DLNKGOFPLPN, T2 CALJIGCLFDI, T3 GCNFNKEIKDJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x5661E00", Offset = "0x5660800", VA = "0x185661E00", Slot = "4")]
	public int CompareTo(KHAIHDNCBDG<T1, T2, T3> GOCNHGEHNFD)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x5662190", Offset = "0x5660B90", VA = "0x185662190", Slot = "0")]
	public override bool Equals(object GOCNHGEHNFD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x5662350", Offset = "0x5660D50", VA = "0x185662350", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x5662590", Offset = "0x5660F90", VA = "0x185662590", Slot = "3")]
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
	public AnimationCurve ABHLBBKFEHF
	{
		[Cpp2IlInjected.Token(Token = "0x6000062")]
		[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public T PNOBECOFBIJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000063")]
		[Cpp2IlInjected.Address(RVA = "0x14523C0", Offset = "0x1450DC0", VA = "0x1814523C0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public T PNHIOKCDOLO
	{
		[Cpp2IlInjected.Token(Token = "0x6000064")]
		[Cpp2IlInjected.Address(RVA = "0xBF9200", Offset = "0xBF7C00", VA = "0x180BF9200")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public T AFPBILBCKEL
	{
		[Cpp2IlInjected.Token(Token = "0x6000065")]
		[Cpp2IlInjected.Address(RVA = "0x2FC8650", Offset = "0x2FC7050", VA = "0x182FC8650")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000066")]
		[Cpp2IlInjected.Address(RVA = "0x2FC8730", Offset = "0x2FC7130", VA = "0x182FC8730")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public float FLKBEKIMIFC
	{
		[Cpp2IlInjected.Token(Token = "0x6000067")]
		[Cpp2IlInjected.Address(RVA = "0xAFF3B0", Offset = "0xAFDDB0", VA = "0x180AFF3B0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x61D02F0", Offset = "0x61CECF0", VA = "0x1861D02F0")]
	public T MKCNKKPIFFB(float GGMLEPFJHKP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x61D00D0", Offset = "0x61CEAD0", VA = "0x1861D00D0")]
	public T IOBBDDLJLFG(float GGMLEPFJHKP)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T KCEPGJPLJJH(T CFAKKPGMPGD, T KMGOFHJBCKL, float GGMLEPFJHKP);

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000017")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x84B3720", Offset = "0x84B2120", VA = "0x1884B3720", Slot = "4")]
	protected override float KCEPGJPLJJH(float CFAKKPGMPGD, float KMGOFHJBCKL, float GGMLEPFJHKP)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x600006D")]
	[Cpp2IlInjected.Address(RVA = "0x84B3760", Offset = "0x84B2160", VA = "0x1884B3760")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600006E")]
	[Cpp2IlInjected.Address(RVA = "0x1A63920", Offset = "0x1A62320", VA = "0x181A63920", Slot = "4")]
	protected override Vector3 KCEPGJPLJJH(Vector3 CFAKKPGMPGD, Vector3 KMGOFHJBCKL, float GGMLEPFJHKP)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600006F")]
	[Cpp2IlInjected.Address(RVA = "0x84B6E20", Offset = "0x84B5820", VA = "0x1884B6E20")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x84B2010", Offset = "0x84B0A10", VA = "0x1884B2010", Slot = "4")]
	protected override Color KCEPGJPLJJH(Color CFAKKPGMPGD, Color KMGOFHJBCKL, float GGMLEPFJHKP)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x84B20D0", Offset = "0x84B0AD0", VA = "0x1884B20D0")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class OEEJLFFDKMI : IEICPJBCMAE<string>
{
	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(RVA = "0x84B4C00", Offset = "0x84B3600", VA = "0x1884B4C00")]
	public OEEJLFFDKMI(int JHAGJEMJCCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x84B4B90", Offset = "0x84B3590", VA = "0x1884B4B90", Slot = "6")]
	protected override uint OOKIHJHEOLL(uint LMLHBIBFOGI, string KMAFNKGMDCF)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class JJJACIAMCNG : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public static readonly IDisposable FLGHCDNLMND;

	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	public JJJACIAMCNG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public struct AMKBHIDCDJH<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000029")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> CJANMFKCNME;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002A")]
	private int LAHFOHAALFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002B")]
	private int KKHIHOKMNKN;

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x52E14F0", Offset = "0x52DFEF0", VA = "0x1852E14F0")]
	private AMKBHIDCDJH(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> CHCLCGPMIEJ, int IKHNADKGMJF, int OOLNKBEPLKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x54DC6C0", Offset = "0x54DB0C0", VA = "0x1854DC6C0")]
	public static AMKBHIDCDJH<T> KDBDJPAJKDJ()
	{
		return default(AMKBHIDCDJH<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x54DB940", Offset = "0x54DA340", VA = "0x1854DB940")]
	public (int, int, Task<T>) CCMEOBHPLHI(int JIHMJMCIFOI, [Optional] CancellationToken AHOMALKMHKK, double JHMKMDEDCJN = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x54DC950", Offset = "0x54DB350", VA = "0x1854DC950")]
	public void MDBNCLHCKDJ(int JIHMJMCIFOI, int OOLNKBEPLKK, [In] T GGIKEMCHAAA)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public static class CFLGJKFKIHC
{
	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x84B1F40", Offset = "0x84B0940", VA = "0x1884B1F40")]
	public static AMKBHIDCDJH<LJBIGLJNMFO> KDBDJPAJKDJ()
	{
		return default(AMKBHIDCDJH<LJBIGLJNMFO>);
	}

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x84B1F90", Offset = "0x84B0990", VA = "0x1884B1F90")]
	public static void MDBNCLHCKDJ([In] this AMKBHIDCDJH<LJBIGLJNMFO> DKGBCFDLMOI, int JIHMJMCIFOI, int OOLNKBEPLKK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
[DefaultMember("Item")]
public class LCJNFGLAGGL<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002C")]
	private readonly Dictionary<TKey, TVal> DPBNJFNFJNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002D")]
	private readonly Dictionary<TVal, TKey> DFHGBOACDDO;

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public int BEFNAMGOJCC
	{
		[Cpp2IlInjected.Token(Token = "0x600007D")]
		[Cpp2IlInjected.Address(RVA = "0x45C05E0", Offset = "0x45BEFE0", VA = "0x1845C05E0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public bool MECKNDEFNLE
	{
		[Cpp2IlInjected.Token(Token = "0x600007E")]
		[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public ICollection<TKey> OKJNLJDHMBJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000081")]
		[Cpp2IlInjected.Address(RVA = "0x5211570", Offset = "0x520FF70", VA = "0x185211570", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000020")]
	public ICollection<TVal> LPDDCCJKGDF
	{
		[Cpp2IlInjected.Token(Token = "0x6000082")]
		[Cpp2IlInjected.Address(RVA = "0x5710970", Offset = "0x570F370", VA = "0x185710970", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000021")]
	public TVal PCCJLFHFGOC
	{
		[Cpp2IlInjected.Token(Token = "0x600008C")]
		[Cpp2IlInjected.Address(RVA = "0x5710890", Offset = "0x570F290", VA = "0x185710890", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600008D")]
		[Cpp2IlInjected.Address(RVA = "0x57109B0", Offset = "0x570F3B0", VA = "0x1857109B0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000022")]
	public TKey PCCJLFHFGOC
	{
		[Cpp2IlInjected.Token(Token = "0x600008F")]
		[Cpp2IlInjected.Address(RVA = "0x570FE70", Offset = "0x570E870", VA = "0x18570FE70")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x570F970", Offset = "0x570E370", VA = "0x18570F970", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x57105C0", Offset = "0x570EFC0", VA = "0x1857105C0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x570F8A0", Offset = "0x570E2A0", VA = "0x18570F8A0", Slot = "9")]
	public void Add(TKey HPFHOBCPNEF, TVal KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x570F7D0", Offset = "0x570E1D0", VA = "0x18570F7D0", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> EOJOFJJBHLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000085")]
	[Cpp2IlInjected.Address(RVA = "0x570F9D0", Offset = "0x570E3D0", VA = "0x18570F9D0", Slot = "8")]
	public bool ContainsKey(TKey HPFHOBCPNEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000086")]
	[Cpp2IlInjected.Address(RVA = "0x570FAC0", Offset = "0x570E4C0", VA = "0x18570FAC0", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> EOJOFJJBHLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x57104E0", Offset = "0x570EEE0", VA = "0x1857104E0", Slot = "10")]
	public bool Remove(TKey HPFHOBCPNEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x5710510", Offset = "0x570EF10", VA = "0x185710510", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> EOJOFJJBHLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000089")]
	[Cpp2IlInjected.Address(RVA = "0x57106B0", Offset = "0x570F0B0", VA = "0x1857106B0", Slot = "11")]
	public bool TryGetValue(TKey HPFHOBCPNEF, [Out] TVal KMAFNKGMDCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008A")]
	[Cpp2IlInjected.Address(RVA = "0x570FF70", Offset = "0x570E970", VA = "0x18570FF70", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x570FB20", Offset = "0x570E520", VA = "0x18570FB20", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] BHEONMJLANC, int LKIFOIIFCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x570F8D0", Offset = "0x570E2D0", VA = "0x18570F8D0")]
	public bool BMFHANOLGIO(TVal HPFHOBCPNEF, [Out] TKey KMAFNKGMDCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x570FC20", Offset = "0x570E620", VA = "0x18570FC20")]
	private void FKOBKEODOBP(TKey HPFHOBCPNEF, TVal MKDEBCJNKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x5710010", Offset = "0x570EA10", VA = "0x185710010")]
	private void NECABIJDOBE(TKey HPFHOBCPNEF, TVal MKDEBCJNKCE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x5710220", Offset = "0x570EC20", VA = "0x185710220")]
	private bool OPCMCPONGFA(TKey HPFHOBCPNEF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x5710750", Offset = "0x570F150", VA = "0x185710750")]
	public LCJNFGLAGGL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[DefaultMember("Item")]
public class BDGFODODOFJ<T> : IEnumerable<T>, IEnumerable, IReadOnlyCollection<T>
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000020")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000032")]
		private BDGFODODOFJ<T> buffer;

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
			[Cpp2IlInjected.Token(Token = "0x60000A2")]
			[Cpp2IlInjected.Address(RVA = "0x4B9CC40", Offset = "0x4B9B640", VA = "0x184B9CC40", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000026")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000A6")]
			[Cpp2IlInjected.Address(RVA = "0x4BB0FD0", Offset = "0x4BAF9D0", VA = "0x184BB0FD0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000A3")]
		[Cpp2IlInjected.Address(RVA = "0x4BB2100", Offset = "0x4BB0B00", VA = "0x184BB2100")]
		public Enumerator(BDGFODODOFJ<T> FPGJFOLEKAK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A4")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A5")]
		[Cpp2IlInjected.Address(RVA = "0x4BAEC90", Offset = "0x4BAD690", VA = "0x184BAEC90", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000A7")]
		[Cpp2IlInjected.Address(RVA = "0x4BAFB30", Offset = "0x4BAE530", VA = "0x184BAFB30", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000A8")]
		[Cpp2IlInjected.Address(RVA = "0x4BADC30", Offset = "0x4BAC630", VA = "0x184BADC30")]
		private void DAABJNPHJMG()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	private T[] AIBKAFMFLDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private int MHADOGLMBLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private int LBJEGLLBLMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int PKNNCMNKNHL;

	[Cpp2IlInjected.Token(Token = "0x17000023")]
	public int BEFNAMGOJCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x6686AE0", Offset = "0x66854E0", VA = "0x186686AE0", Slot = "6")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public T PCCJLFHFGOC
	{
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x66840E0", Offset = "0x6682AE0", VA = "0x1866840E0")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000096")]
		[Cpp2IlInjected.Address(RVA = "0x6686590", Offset = "0x6684F90", VA = "0x186686590")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000097")]
	[Cpp2IlInjected.Address(RVA = "0x6686A60", Offset = "0x6685460", VA = "0x186686A60")]
	public BDGFODODOFJ(int JHAGJEMJCCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x6684410", Offset = "0x6682E10", VA = "0x186684410")]
	public void HMDNMGBNKIA(T GGMLEPFJHKP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x6685850", Offset = "0x6684250", VA = "0x186685850")]
	public void KNKHDDEKIFO(IEnumerable<T> FBOHMIMNCKO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x66837E0", Offset = "0x66821E0", VA = "0x1866837E0")]
	public void EMMOLKMNHIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x66841D0", Offset = "0x6682BD0", VA = "0x1866841D0")]
	public void HCDDDDOAMDM(int MHMCOJIKNCI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009C")]
	[Cpp2IlInjected.Address(RVA = "0x6685BF0", Offset = "0x66845F0", VA = "0x186685BF0")]
	public void KPNIEKPKGAM(T[] BHEONMJLANC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009D")]
	[Cpp2IlInjected.Address(RVA = "0x6683880", Offset = "0x6682280", VA = "0x186683880")]
	public Enumerator FIIFAFDLDFC()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x600009E")]
	[Cpp2IlInjected.Address(RVA = "0x6686770", Offset = "0x6685170", VA = "0x186686770", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x6686770", Offset = "0x6685170", VA = "0x186686770", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x6683D30", Offset = "0x6682730", VA = "0x186683D30")]
	private int GICJDGONPKL(int KABGMIEBEFC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x66837B0", Offset = "0x66821B0", VA = "0x1866837B0")]
	private int ECEEIJPLKMH(int KABGMIEBEFC)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000021")]
public class HOBAPCBIFBD<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000022")]
	public delegate Task<TResult> GMOBDIMBKDK(TRequest KGHMNJMLIBE, CancellationToken AHOMALKMHKK);

	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public enum PJBEDELDEPK
	{
		[Cpp2IlInjected.Token(Token = "0x400003D")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x400003E")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public class PCIIFPPIBNL
	{
		[Cpp2IlInjected.Token(Token = "0x400003F")]
		private const float MLIBOOFAMEN = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000040")]
		private TimeSpan PFIHPHHBHFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000041")]
		public int BKIBOBAHLHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000042")]
		public PJBEDELDEPK FDPDCFDOGFO;

		[Cpp2IlInjected.Token(Token = "0x4000043")]
		public static readonly PCIIFPPIBNL IIDHIFPMCOA;

		[Cpp2IlInjected.Token(Token = "0x17000027")]
		public float BOAMFLMOOBP
		{
			[Cpp2IlInjected.Token(Token = "0x60000B3")]
			[Cpp2IlInjected.Address(RVA = "0x5C96D30", Offset = "0x5C95730", VA = "0x185C96D30")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000028")]
		public TimeSpan CDICPKNELJB
		{
			[Cpp2IlInjected.Token(Token = "0x60000B4")]
			[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000B5")]
		[Cpp2IlInjected.Address(RVA = "0x5C96E80", Offset = "0x5C95880", VA = "0x185C96E80")]
		public PCIIFPPIBNL()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	private readonly struct ADNDAAGNADM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		public readonly TRequest KGHMNJMLIBE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		public readonly CancellationToken AHOMALKMHKK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		public readonly TaskCompletionSource<TResult> BGKCGDAEDOI;

		[Cpp2IlInjected.Token(Token = "0x60000B7")]
		[Cpp2IlInjected.Address(RVA = "0x53031F0", Offset = "0x5301BF0", VA = "0x1853031F0")]
		public ADNDAAGNADM(TRequest KGHMNJMLIBE, TaskCompletionSource<TResult> BGKCGDAEDOI, CancellationToken AHOMALKMHKK)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000026")]
	[CompilerGenerated]
	private struct ECOCCNIDNCP : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public HOBAPCBIFBD<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000B8")]
		[Cpp2IlInjected.Address(RVA = "0x4AFBDA0", Offset = "0x4AFA7A0", VA = "0x184AFBDA0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000B9")]
		[Cpp2IlInjected.Address(RVA = "0x4AFC910", Offset = "0x4AFB310", VA = "0x184AFC910", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct IGFOJELGHMJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public HOBAPCBIFBD<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		private ADNDAAGNADM <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000BA")]
		[Cpp2IlInjected.Address(RVA = "0x52E82B0", Offset = "0x52E6CB0", VA = "0x1852E82B0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000BB")]
		[Cpp2IlInjected.Address(RVA = "0x52E9420", Offset = "0x52E7E20", VA = "0x1852E9420", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private readonly CancellationTokenSource KECAGHNFIJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private readonly List<ADNDAAGNADM> JPPOCNJMIEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000038")]
	private readonly PCIIFPPIBNL OGOJFIKCHIL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000039")]
	private readonly GMOBDIMBKDK DHLOMECOGDD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003A")]
	private Task NEIDBOAFOIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003B")]
	private int ADGOCJPCHHG;

	[Cpp2IlInjected.Token(Token = "0x60000A9")]
	[Cpp2IlInjected.Address(RVA = "0x521CFC0", Offset = "0x521B9C0", VA = "0x18521CFC0")]
	public HOBAPCBIFBD(GMOBDIMBKDK DHLOMECOGDD, [Optional] PCIIFPPIBNL OGOJFIKCHIL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AA")]
	[Cpp2IlInjected.Address(RVA = "0x521BA90", Offset = "0x521A490", VA = "0x18521BA90")]
	public Task<TResult> GFNODOGDHEN(TRequest KGHMNJMLIBE, CancellationToken AHOMALKMHKK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AB")]
	[Cpp2IlInjected.Address(RVA = "0x521C200", Offset = "0x521AC00", VA = "0x18521C200")]
	private void HOLOEGAMPNH(ADNDAAGNADM PAAKNFKEMCA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000AC")]
	[Cpp2IlInjected.Address(RVA = "0x521C370", Offset = "0x521AD70", VA = "0x18521C370")]
	[AsyncStateMachine(typeof(HOBAPCBIFBD<, >.ECOCCNIDNCP))]
	private Task IOJIJFIHOIH()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AD")]
	[Cpp2IlInjected.Address(RVA = "0x521CA50", Offset = "0x521B450", VA = "0x18521CA50")]
	private ADNDAAGNADM MDPHCHEFGJH()
	{
		return default(ADNDAAGNADM);
	}

	[Cpp2IlInjected.Token(Token = "0x60000AE")]
	[Cpp2IlInjected.Address(RVA = "0x521CED0", Offset = "0x521B8D0", VA = "0x18521CED0")]
	[AsyncStateMachine(typeof(HOBAPCBIFBD<, >.IGFOJELGHMJ))]
	private Task OAOLOMPGPDB()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000AF")]
	[Cpp2IlInjected.Address(RVA = "0x521B870", Offset = "0x521A270", VA = "0x18521B870")]
	private void AFAINBBPIHM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x521BA50", Offset = "0x521A450", VA = "0x18521BA50", Slot = "4")]
	public void Dispose()
	{
	}
}
namespace RecRoom.AppUI
{
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	public interface IRRUISpriteLookup
	{
		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(Slot = "0")]
		bool TryFindSpriteByName(string spriteName, [Out] Sprite sprite);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DefaultMember("Item")]
public class GKAOAIDCCJI<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000050")]
	private readonly List<T> GBEHGKLEJFE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000051")]
	private HashSet<T> PPIOAGJNDPJ;

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	public int BEFNAMGOJCC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BD")]
		[Cpp2IlInjected.Address(RVA = "0x45C05E0", Offset = "0x45BEFE0", VA = "0x1845C05E0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002A")]
	public bool MECKNDEFNLE
	{
		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0xAF8250", Offset = "0xAF6C50", VA = "0x180AF8250", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700002B")]
	public T PCCJLFHFGOC
	{
		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x51307A0", Offset = "0x512F1A0", VA = "0x1851307A0", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x51307E0", Offset = "0x512F1E0", VA = "0x1851307E0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C1")]
	[Cpp2IlInjected.Address(RVA = "0x5038890", Offset = "0x5037290", VA = "0x185038890", Slot = "11")]
	public void Add(T EOJOFJJBHLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C2")]
	[Cpp2IlInjected.Address(RVA = "0x5130220", Offset = "0x512EC20", VA = "0x185130220")]
	public bool JILDHIFEDKN(T EOJOFJJBHLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C3")]
	[Cpp2IlInjected.Address(RVA = "0x5130620", Offset = "0x512F020", VA = "0x185130620", Slot = "15")]
	public bool Remove(T EOJOFJJBHLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C4")]
	[Cpp2IlInjected.Address(RVA = "0x512FF90", Offset = "0x512E990", VA = "0x18512FF90", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C5")]
	[Cpp2IlInjected.Address(RVA = "0x50FBAE0", Offset = "0x50FA4E0", VA = "0x1850FBAE0", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000C6")]
	[Cpp2IlInjected.Address(RVA = "0x512FEC0", Offset = "0x512E8C0", VA = "0x18512FEC0", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x512FF20", Offset = "0x512E920", VA = "0x18512FF20", Slot = "13")]
	public bool Contains(T EOJOFJJBHLN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x512FF60", Offset = "0x512E960", VA = "0x18512FF60", Slot = "14")]
	public void CopyTo(T[] BHEONMJLANC, int LKIFOIIFCGG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x5130020", Offset = "0x512EA20", VA = "0x185130020", Slot = "6")]
	public int IndexOf(T EOJOFJJBHLN)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x5130150", Offset = "0x512EB50", VA = "0x185130150", Slot = "7")]
	public void Insert(int KABGMIEBEFC, T EOJOFJJBHLN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x5130490", Offset = "0x512EE90", VA = "0x185130490", Slot = "8")]
	public void RemoveAt(int KABGMIEBEFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x51306B0", Offset = "0x512F0B0", VA = "0x1851306B0")]
	public GKAOAIDCCJI()
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
			[Cpp2IlInjected.Token(Token = "0x60000CD")]
			[Cpp2IlInjected.Address(RVA = "0x2DF69C0", Offset = "0x2DF53C0", VA = "0x182DF69C0")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000CE")]
		[Cpp2IlInjected.Address(RVA = "0x84B6370", Offset = "0x84B4D70", VA = "0x1884B6370")]
		public SerializedGuid([In] Guid OCONCDFGCOB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000CF")]
		[Cpp2IlInjected.Address(RVA = "0x84B6240", Offset = "0x84B4C40", VA = "0x1884B6240")]
		public static SerializedGuid HKBEGBPMHPI()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D0")]
		[Cpp2IlInjected.Address(RVA = "0x84B61C0", Offset = "0x84B4BC0", VA = "0x1884B61C0")]
		public static SerializedGuid GPFEFGCNNDP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D1")]
		[Cpp2IlInjected.Address(RVA = "0x84B6090", Offset = "0x84B4A90", VA = "0x1884B6090")]
		public bool DGOCJDKBCHH()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D2")]
		[Cpp2IlInjected.Address(RVA = "0x84B6340", Offset = "0x84B4D40", VA = "0x1884B6340", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D3")]
		[Cpp2IlInjected.Address(RVA = "0x84B62C0", Offset = "0x84B4CC0", VA = "0x1884B62C0", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x84B60F0", Offset = "0x84B4AF0", VA = "0x1884B60F0", Slot = "7")]
		public bool Equals(SerializedGuid GOCNHGEHNFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x84B6130", Offset = "0x84B4B30", VA = "0x1884B6130", Slot = "0")]
		public override bool Equals(object PMNHIPACJLN)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x84B6230", Offset = "0x84B4C30", VA = "0x1884B6230", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x84B6060", Offset = "0x84B4A60", VA = "0x1884B6060", Slot = "6")]
		public int CompareTo(SerializedGuid GOCNHGEHNFD)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class JIEIPGIEBFI : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x4000054")]
	public readonly Type JGHPJOEJDLI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000055")]
	public readonly string LENNEIDIFAM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	public readonly bool MGKGKBPFFAI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	public readonly bool CKMJHBILFFP;

	[Cpp2IlInjected.Token(Token = "0x60000D8")]
	[Cpp2IlInjected.Address(RVA = "0x84B3B10", Offset = "0x84B2510", VA = "0x1884B3B10")]
	public JIEIPGIEBFI(Type GIGDJFLCENK, string LJPKBMEJGKC, bool AHNOAMHPAJG = false, bool COODAJNBCEF = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public interface FCLOFCPOPGF<T>
{
	[Cpp2IlInjected.Token(Token = "0x1700002D")]
	int BIPECFFPMHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x60000DA")]
	[Cpp2IlInjected.Address(Slot = "1")]
	IEnumerable<T> MELBNLOHLCC(float LKKNOPLOOPB, [Optional] float? AMIAHEHNGDA);

	[Cpp2IlInjected.Token(Token = "0x60000DB")]
	[Cpp2IlInjected.Address(Slot = "2")]
	bool DPCCOKOKLEB(float LKKNOPLOOPB, T KMAFNKGMDCF);

	[Cpp2IlInjected.Token(Token = "0x60000DC")]
	[Cpp2IlInjected.Address(Slot = "3")]
	void EMMOLKMNHIK();
}
[Cpp2IlInjected.Token(Token = "0x200002D")]
public class LDKEPNNOEKP<T> : FCLOFCPOPGF<T>
{
	[Cpp2IlInjected.Token(Token = "0x200002E")]
	private readonly struct JMFBHLPKEEC
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005E")]
		public readonly T AFPBILBCKEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400005F")]
		public readonly float IBJIMPNBLHE;

		[Cpp2IlInjected.Token(Token = "0x60000E5")]
		[Cpp2IlInjected.Address(RVA = "0x5548D80", Offset = "0x5547780", VA = "0x185548D80")]
		public JMFBHLPKEEC(T KMAFNKGMDCF, float LKKNOPLOOPB)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002F")]
	[CompilerGenerated]
	private sealed class FMFOJNNGFGI : IEnumerable<T>, IEnumerable, IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000060")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000061")]
		private T <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000062")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000063")]
		public LDKEPNNOEKP<T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000064")]
		private float time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000065")]
		public float <>3__time;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000066")]
		private float? minTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000067")]
		public float? <>3__minTime;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		private int <count>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		private int <i>5__3;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		T IEnumerator<T>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000E9")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000EB")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000E6")]
		[Cpp2IlInjected.Address(RVA = "0xBE39C0", Offset = "0xBE23C0", VA = "0x180BE39C0")]
		[DebuggerHidden]
		public FMFOJNNGFGI(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x500DA50", Offset = "0x500C450", VA = "0x18500DA50", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x500DF80", Offset = "0x500C980", VA = "0x18500DF80", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x500DE40", Offset = "0x500C840", VA = "0x18500DE40", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<T> IEnumerable<T>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000ED")]
		[Cpp2IlInjected.Address(RVA = "0x500DF00", Offset = "0x500C900", VA = "0x18500DF00", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000058")]
	private readonly float DMGJADGCLAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000059")]
	private readonly float PCKKLEJCKKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	private readonly List<JMFBHLPKEEC> EFNPFAIMEFP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	private int MHADOGLMBLF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	private int EINJIEJIMOP;

	[Cpp2IlInjected.Token(Token = "0x1700002E")]
	public int BIPECFFPMHH
	{
		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0xAB33E0", Offset = "0xAB1DE0", VA = "0x180AB33E0", Slot = "4")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x571A1E0", Offset = "0x5718BE0", VA = "0x18571A1E0")]
	public LDKEPNNOEKP(float DMGJADGCLAJ, float PCKKLEJCKKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000DF")]
	[Cpp2IlInjected.Address(RVA = "0x57198A0", Offset = "0x57182A0", VA = "0x1857198A0", Slot = "6")]
	public bool DPCCOKOKLEB(float LKKNOPLOOPB, T KMAFNKGMDCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E0")]
	[Cpp2IlInjected.Address(RVA = "0x5719B40", Offset = "0x5718540", VA = "0x185719B40", Slot = "8")]
	public int GFGCJDNPPIK(float LKKNOPLOOPB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000E1")]
	[Cpp2IlInjected.Address(RVA = "0x5719D80", Offset = "0x5718780", VA = "0x185719D80", Slot = "5")]
	[IteratorStateMachine(typeof(LDKEPNNOEKP<>.FMFOJNNGFGI))]
	public IEnumerable<T> MELBNLOHLCC(float LKKNOPLOOPB, float? AMIAHEHNGDA)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x5719B00", Offset = "0x5718500", VA = "0x185719B00", Slot = "7")]
	public void EMMOLKMNHIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x5719EF0", Offset = "0x57188F0", VA = "0x185719EF0")]
	private void PCNKDEAGBEL(float LKKNOPLOOPB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x5719C00", Offset = "0x5718600", VA = "0x185719C00")]
	private JMFBHLPKEEC HEOGHECCIHG()
	{
		return default(JMFBHLPKEEC);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000030")]
public class OEEGBKAOPAE<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000031")]
	public readonly struct CPIBCMIEOFL
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000074")]
		public readonly long CHDJDIDFAJM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000075")]
		public readonly long IHAMPKJOLIC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000076")]
		public readonly int NDKEOPOAEBO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000077")]
		public readonly int KGKCOGDDMPO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000078")]
		public readonly bool NJIKCHPEHND;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000079")]
		private readonly string HAMIIHKKDLO;

		[Cpp2IlInjected.Token(Token = "0x60000F6")]
		[Cpp2IlInjected.Address(RVA = "0x6EBE7A0", Offset = "0x6EBD1A0", VA = "0x186EBE7A0")]
		public CPIBCMIEOFL(long CHDJDIDFAJM, int NDKEOPOAEBO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x6EBE770", Offset = "0x6EBD170", VA = "0x186EBE770")]
		public CPIBCMIEOFL(long CHDJDIDFAJM, long IHAMPKJOLIC, int NDKEOPOAEBO, int KGKCOGDDMPO, bool NJIKCHPEHND, string HAMIIHKKDLO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x6EBE600", Offset = "0x6EBD000", VA = "0x186EBE600")]
		public int ALGOFMDBALK()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x6EBE6F0", Offset = "0x6EBD0F0", VA = "0x186EBE6F0")]
		public int MONNDJHKHEE(int BDJLOBJNFIG)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x6EBE710", Offset = "0x6EBD110", VA = "0x186EBE710")]
		public double NJCPPJGFCMM()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FB")]
		[Cpp2IlInjected.Address(RVA = "0x6EBE650", Offset = "0x6EBD050", VA = "0x186EBE650")]
		public CPIBCMIEOFL BCBHBCOCOIE(long IHAMPKJOLIC, int KGKCOGDDMPO)
		{
			return default(CPIBCMIEOFL);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000032")]
	public class BANCHJBJHFK : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000033")]
		[CompilerGenerated]
		private struct OKKBJDBKCBO<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400007F")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000080")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000081")]
			public BANCHJBJHFK <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000082")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000083")]
			public Func<BANCHJBJHFK, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000084")]
			private BANCHJBJHFK <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000085")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000104")]
			[Cpp2IlInjected.Address(RVA = "0x5BBC520", Offset = "0x5BBAF20", VA = "0x185BBC520", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x4B35850", Offset = "0x4B34250", VA = "0x184B35850", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		public readonly TKey PHLFNBHNCJK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private readonly OEEGBKAOPAE<TKey> KIGHMIAOFFO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		public readonly OLFEOKKCIEG JHGFKLHHPJD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		private List<BANCHJBJHFK> OPHHIJJMJHE;

		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public string NELLPHDHEKH
		{
			[Cpp2IlInjected.Token(Token = "0x60000FC")]
			[Cpp2IlInjected.Address(RVA = "0x667AE20", Offset = "0x6679820", VA = "0x18667AE20")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public IEnumerable<BANCHJBJHFK> CFJCMLOIJEE
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x667AB90", Offset = "0x6679590", VA = "0x18667AB90")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000035")]
		public CPIBCMIEOFL CKIIGCLJCFM
		{
			[Cpp2IlInjected.Token(Token = "0x60000FE")]
			[Cpp2IlInjected.Address(RVA = "0x667ADD0", Offset = "0x66797D0", VA = "0x18667ADD0")]
			[CompilerGenerated]
			get
			{
				return default(CPIBCMIEOFL);
			}
			[Cpp2IlInjected.Token(Token = "0x60000FF")]
			[Cpp2IlInjected.Address(RVA = "0x667ADF0", Offset = "0x66797F0", VA = "0x18667ADF0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x667AFB0", Offset = "0x66799B0", VA = "0x18667AFB0")]
		internal BANCHJBJHFK(OEEGBKAOPAE<TKey> KIGHMIAOFFO, TKey HPFHOBCPNEF, OLFEOKKCIEG JHGFKLHHPJD)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x667AE50", Offset = "0x6679850", VA = "0x18667AE50")]
		public BANCHJBJHFK PJMBCJFCKMI(TKey HPFHOBCPNEF, [Optional] OLFEOKKCIEG? GLFNPNNGHCO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x3F26300", Offset = "0x3F24D00", VA = "0x183F26300")]
		[AsyncStateMachine(typeof(OKKBJDBKCBO<>))]
		public Task<T> AFLBPEGPNFM<T>(TKey HPFHOBCPNEF, Func<BANCHJBJHFK, Task<T>> DHFPPCMKNFO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x667ABD0", Offset = "0x66795D0", VA = "0x18667ABD0", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000034")]
	[CompilerGenerated]
	private sealed class GADHGLJMMNK : IEnumerable<(TKey, List<TKey>, CPIBCMIEOFL)>, IEnumerable, IEnumerator<(TKey, List<TKey>, CPIBCMIEOFL)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private (TKey key, List<TKey> path, CPIBCMIEOFL timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000089")]
		public OEEGBKAOPAE<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008A")]
		private IEnumerator<(TKey key, List<TKey> path, CPIBCMIEOFL timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x17000036")]
		private (TKey, List<TKey>, CPIBCMIEOFL) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010A")]
			[Cpp2IlInjected.Address(RVA = "0x2DF4A50", Offset = "0x2DF3450", VA = "0x182DF4A50", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, CPIBCMIEOFL));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000037")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x600010C")]
			[Cpp2IlInjected.Address(RVA = "0x509C180", Offset = "0x509AB80", VA = "0x18509C180", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x2DF4B40", Offset = "0x2DF3540", VA = "0x182DF4B40")]
		[DebuggerHidden]
		public GADHGLJMMNK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000107")]
		[Cpp2IlInjected.Address(RVA = "0x5065630", Offset = "0x5064030", VA = "0x185065630", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x509BC70", Offset = "0x509A670", VA = "0x18509BC70", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x509BC20", Offset = "0x509A620", VA = "0x18509BC20")]
		private void LLDKJPCFHKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010B")]
		[Cpp2IlInjected.Address(RVA = "0x509C130", Offset = "0x509AB30", VA = "0x18509C130", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600010D")]
		[Cpp2IlInjected.Address(RVA = "0x509C070", Offset = "0x509AA70", VA = "0x18509C070", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, CPIBCMIEOFL)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600010E")]
		[Cpp2IlInjected.Address(RVA = "0x4697EB0", Offset = "0x46968B0", VA = "0x184697EB0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000035")]
	[CompilerGenerated]
	private sealed class ECLBCHHANPH : IEnumerable<(TKey, List<TKey>, CPIBCMIEOFL)>, IEnumerable, IEnumerator<(TKey, List<TKey>, CPIBCMIEOFL)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008B")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008C")]
		private (TKey key, List<TKey> path, CPIBCMIEOFL timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008D")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008E")]
		private List<TKey> path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400008F")]
		public List<TKey> <>3__path;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		private BANCHJBJHFK timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public BANCHJBJHFK <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000092")]
		public OEEGBKAOPAE<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000093")]
		private IEnumerator<BANCHJBJHFK> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000094")]
		private IEnumerator<(TKey key, List<TKey> path, CPIBCMIEOFL timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x17000038")]
		private (TKey, List<TKey>, CPIBCMIEOFL) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000114")]
			[Cpp2IlInjected.Address(RVA = "0x2DF4A50", Offset = "0x2DF3450", VA = "0x182DF4A50", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, CPIBCMIEOFL));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000116")]
			[Cpp2IlInjected.Address(RVA = "0x4AFBBE0", Offset = "0x4AFA5E0", VA = "0x184AFBBE0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600010F")]
		[Cpp2IlInjected.Address(RVA = "0x2DF4B40", Offset = "0x2DF3540", VA = "0x182DF4B40")]
		[DebuggerHidden]
		public ECLBCHHANPH(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000110")]
		[Cpp2IlInjected.Address(RVA = "0x4AFBC40", Offset = "0x4AFA640", VA = "0x184AFBC40", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000111")]
		[Cpp2IlInjected.Address(RVA = "0x4AFB290", Offset = "0x4AF9C90", VA = "0x184AFB290", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000112")]
		[Cpp2IlInjected.Address(RVA = "0x4AFB230", Offset = "0x4AF9C30", VA = "0x184AFB230")]
		private void LLDKJPCFHKC()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000113")]
		[Cpp2IlInjected.Address(RVA = "0x4AFBA20", Offset = "0x4AFA420", VA = "0x184AFBA20")]
		private void OCOHJFDHCPG()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000115")]
		[Cpp2IlInjected.Address(RVA = "0x4AFBB90", Offset = "0x4AFA590", VA = "0x184AFBB90", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000117")]
		[Cpp2IlInjected.Address(RVA = "0x4AFBA80", Offset = "0x4AFA480", VA = "0x184AFBA80", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, CPIBCMIEOFL)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000118")]
		[Cpp2IlInjected.Address(RVA = "0x4AFBB60", Offset = "0x4AFA560", VA = "0x184AFBB60", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006A")]
	private readonly Action<TKey, CPIBCMIEOFL, OLFEOKKCIEG> IGMIKEEJFNP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006B")]
	private readonly Action<TKey, CPIBCMIEOFL, OLFEOKKCIEG> CPGAKGNHPHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006C")]
	private readonly Action<OEEGBKAOPAE<TKey>, OLFEOKKCIEG> FKENPHAOBIP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006D")]
	private readonly OLFEOKKCIEG JHGFKLHHPJD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006E")]
	private readonly BANCHJBJHFK KCJEJJHCOLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400006F")]
	private bool ICPNMNBNLKA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000070")]
	private int IJGNICFOLOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000071")]
	private readonly Stopwatch BIDELJPMOKB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000072")]
	public readonly int DBHIJCNLDLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000073")]
	private string FAKOINLDOPL;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public BANCHJBJHFK GAAGJALNFFN
	{
		[Cpp2IlInjected.Token(Token = "0x60000EE")]
		[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	[NotNull]
	public string NELLPHDHEKH
	{
		[Cpp2IlInjected.Token(Token = "0x60000EF")]
		[Cpp2IlInjected.Address(RVA = "0xAB4860", Offset = "0xAB3260", VA = "0x180AB4860")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000F0")]
		[Cpp2IlInjected.Address(RVA = "0x5BA2CB0", Offset = "0x5BA16B0", VA = "0x185BA2CB0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000F1")]
	[Cpp2IlInjected.Address(RVA = "0x5BA2E70", Offset = "0x5BA1870", VA = "0x185BA2E70")]
	public OEEGBKAOPAE(TKey EMDPHNFNNHP, OLFEOKKCIEG JHGFKLHHPJD, [Optional] int? NDKEOPOAEBO, [Optional][CanBeNull] Stopwatch BIDELJPMOKB, [Optional] Action<TKey, CPIBCMIEOFL, OLFEOKKCIEG> IGMIKEEJFNP, [Optional] Action<TKey, CPIBCMIEOFL, OLFEOKKCIEG> CPGAKGNHPHE, [Optional] Action<OEEGBKAOPAE<TKey>, OLFEOKKCIEG> FKENPHAOBIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F2")]
	[Cpp2IlInjected.Address(RVA = "0x5BA2C20", Offset = "0x5BA1620", VA = "0x185BA2C20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000F3")]
	[Cpp2IlInjected.Address(RVA = "0x5BA2DE0", Offset = "0x5BA17E0", VA = "0x185BA2DE0")]
	[IteratorStateMachine(typeof(OEEGBKAOPAE<>.GADHGLJMMNK))]
	public IEnumerable<(TKey, List<TKey>, CPIBCMIEOFL)> OOBMDJLLDLF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F4")]
	[Cpp2IlInjected.Address(RVA = "0x5BA2D10", Offset = "0x5BA1710", VA = "0x185BA2D10")]
	[IteratorStateMachine(typeof(OEEGBKAOPAE<>.ECLBCHHANPH))]
	private IEnumerable<(TKey, List<TKey>, CPIBCMIEOFL)> OOBMDJLLDLF(List<TKey> HEEMGKHJLID, BANCHJBJHFK IPOALAHOCJI)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000F5")]
	[Cpp2IlInjected.Address(RVA = "0x5BA2BA0", Offset = "0x5BA15A0", VA = "0x185BA2BA0")]
	private (long, int) AAJLOGHECAJ()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000036")]
public abstract class AMIIEJPGHNE<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut DBFLIDEOLNL(OEEGBKAOPAE<TKey> KIGHMIAOFFO);

	[Cpp2IlInjected.Token(Token = "0x600011A")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	protected AMIIEJPGHNE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public abstract class NNNOFFFICLE<TKey> : AMIIEJPGHNE<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	public delegate string CBAACGCJJLM(TKey HPFHOBCPNEF);

	[Cpp2IlInjected.Token(Token = "0x600011B")]
	[Cpp2IlInjected.Address(RVA = "0x5A68D50", Offset = "0x5A67750", VA = "0x185A68D50")]
	private static string BHLKJIGELCD(TKey HPFHOBCPNEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x5A68ED0", Offset = "0x5A678D0", VA = "0x185A68ED0", Slot = "4")]
	public override string DBFLIDEOLNL(OEEGBKAOPAE<TKey> KIGHMIAOFFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x5A68D90", Offset = "0x5A67790", VA = "0x185A68D90")]
	public string DBFLIDEOLNL(OEEGBKAOPAE<TKey> KIGHMIAOFFO, [NotNull] CBAACGCJJLM KPOCIOFCGNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011E")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string KAOFLCANJJC(OEEGBKAOPAE<TKey> KIGHMIAOFFO, [NotNull] CBAACGCJJLM KPOCIOFCGNF);

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x52EF700", Offset = "0x52EE100", VA = "0x1852EF700")]
	protected NNNOFFFICLE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public class FHMDDNGKNJB<TKey> : AMIIEJPGHNE<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	public delegate string NNFCOCIKKBL(TKey HPFHOBCPNEF);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000095")]
	private readonly string BNCHPIMPJCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000096")]
	private readonly double JAPBLPGIFEJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000097")]
	private readonly bool DGCBEFEFIPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000098")]
	private readonly int OLIJGHPHEMH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000099")]
	private readonly ISet<string> GPOFHENIEMN;

	[Cpp2IlInjected.Token(Token = "0x6000122")]
	[Cpp2IlInjected.Address(RVA = "0x4FF7D00", Offset = "0x4FF6700", VA = "0x184FF7D00")]
	private static string BHLKJIGELCD(TKey HPFHOBCPNEF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000123")]
	[Cpp2IlInjected.Address(RVA = "0x4FF8850", Offset = "0x4FF7250", VA = "0x184FF8850")]
	public FHMDDNGKNJB(string BNCHPIMPJCA = "F2", double JAPBLPGIFEJ = double.MaxValue, bool DGCBEFEFIPB = false, int OLIJGHPHEMH = int.MaxValue, [Optional] ISet<string> GPOFHENIEMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000124")]
	[Cpp2IlInjected.Address(RVA = "0x4FF7D40", Offset = "0x4FF6740", VA = "0x184FF7D40", Slot = "4")]
	public override Dictionary<string, string> DBFLIDEOLNL(OEEGBKAOPAE<TKey> KIGHMIAOFFO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000125")]
	[Cpp2IlInjected.Address(RVA = "0x4FF8780", Offset = "0x4FF7180", VA = "0x184FF8780")]
	private bool PKMKEPPENKC(string MMJJJBEDOCH)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x4FF7E00", Offset = "0x4FF6800", VA = "0x184FF7E00")]
	public Dictionary<string, string> DBFLIDEOLNL(OEEGBKAOPAE<TKey> KIGHMIAOFFO, NNFCOCIKKBL KPOCIOFCGNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000127")]
	[Cpp2IlInjected.Address(RVA = "0x4FF8550", Offset = "0x4FF6F50", VA = "0x184FF8550")]
	private string PIAEBAOBPHH(StringBuilder EHDOHEHEEMP, List<TKey> HNOFLFPKILG, NNFCOCIKKBL KPOCIOFCGNF, bool JPNBNHDLFAK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000128")]
	[Cpp2IlInjected.Address(RVA = "0x4FF83F0", Offset = "0x4FF6DF0", VA = "0x184FF83F0")]
	private static void IAGDHILEDLN(StringBuilder BBDFBAOBJFB, string NJOPCMCDMGF, bool HGHINBAMFAC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public class GBCLKJAKFKE<TKey> : NNNOFFFICLE<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	[CompilerGenerated]
	private struct EHHDIEBOBEN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009C")]
		public CBAACGCJJLM keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x400009A")]
	public static GBCLKJAKFKE<TKey> FLGHCDNLMND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400009B")]
	private readonly string[] CJAJFNMDCIN;

	[Cpp2IlInjected.Token(Token = "0x600012B")]
	[Cpp2IlInjected.Address(RVA = "0x5121610", Offset = "0x5120010", VA = "0x185121610")]
	private GBCLKJAKFKE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600012C")]
	[Cpp2IlInjected.Address(RVA = "0x51205B0", Offset = "0x511EFB0", VA = "0x1851205B0", Slot = "5")]
	protected override string KAOFLCANJJC(OEEGBKAOPAE<TKey> KIGHMIAOFFO, CBAACGCJJLM KPOCIOFCGNF)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600012E")]
	[Cpp2IlInjected.Address(RVA = "0x51213E0", Offset = "0x511FDE0", VA = "0x1851213E0")]
	[CompilerGenerated]
	internal static string MBLHBBKCCDB(string BOCHMKHJCEG, TKey HPFHOBCPNEF, EHHDIEBOBEN P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public sealed class LBBOOFEPGPE : OEEGBKAOPAE<string>
{
	[Cpp2IlInjected.Token(Token = "0x200003E")]
	[CompilerGenerated]
	private sealed class MEHJCBBALNP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		public Action<LBBOOFEPGPE, OLFEOKKCIEG> callback;

		[Cpp2IlInjected.Token(Token = "0x6000131")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public MEHJCBBALNP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000132")]
		[Cpp2IlInjected.Address(RVA = "0x84B4990", Offset = "0x84B3390", VA = "0x1884B4990")]
		internal void GEKEIAMONHE(OEEGBKAOPAE<string> timer, OLFEOKKCIEG log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x84B4750", Offset = "0x84B3150", VA = "0x1884B4750")]
	public LBBOOFEPGPE(OLFEOKKCIEG JHGFKLHHPJD, [Optional] string KMAGHMJNLBB, [Optional] int? NDKEOPOAEBO, [Optional] Stopwatch BIDELJPMOKB, [Optional] Action<string, CPIBCMIEOFL, OLFEOKKCIEG> IGMIKEEJFNP, [Optional] Action<string, CPIBCMIEOFL, OLFEOKKCIEG> CPGAKGNHPHE, [Optional] Action<LBBOOFEPGPE, OLFEOKKCIEG> FKENPHAOBIP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x84B4690", Offset = "0x84B3090", VA = "0x1884B4690")]
	private static Action<OEEGBKAOPAE<string>, OLFEOKKCIEG> JKEBKFPDDCP(Action<LBBOOFEPGPE, OLFEOKKCIEG> AEPCPKCINPI)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public abstract class KOBLGAJEGPI
{
	[Cpp2IlInjected.Token(Token = "0x2000040")]
	private class BAHJNOMCPPO : KOBLGAJEGPI
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public static KOBLGAJEGPI FLGHCDNLMND
		{
			[Cpp2IlInjected.Token(Token = "0x6000137")]
			[Cpp2IlInjected.Address(RVA = "0x84B1DF0", Offset = "0x84B07F0", VA = "0x1884B1DF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override float CJMAJLKJKHN
		{
			[Cpp2IlInjected.Token(Token = "0x6000138")]
			[Cpp2IlInjected.Address(RVA = "0x13F35F0", Offset = "0x13F1FF0", VA = "0x1813F35F0", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000139")]
		[Cpp2IlInjected.Address(RVA = "0x84B1EF0", Offset = "0x84B08F0", VA = "0x1884B1EF0")]
		public BAHJNOMCPPO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x400009E")]
	private static KOBLGAJEGPI PLECPJMNOAM;

	[Cpp2IlInjected.Token(Token = "0x1700003A")]
	public static KOBLGAJEGPI IIDHIFPMCOA
	{
		[Cpp2IlInjected.Token(Token = "0x6000133")]
		[Cpp2IlInjected.Address(RVA = "0x84B4520", Offset = "0x84B2F20", VA = "0x1884B4520")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700003B")]
	public abstract float CJMAJLKJKHN
	{
		[Cpp2IlInjected.Token(Token = "0x6000134")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000135")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	protected KOBLGAJEGPI()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000041")]
public interface HPBHBMMEHME : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003E")]
	bool DOGEECCMHOL
	{
		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000042")]
public interface AACADPLMCLK<T> : HPBHBMMEHME, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x1700003F")]
	[NotNull]
	Task<T> GLNBMPPKHIM
	{
		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000040")]
	[NotNull]
	FKFADEBPFBK<T> JOMCHNHPFKG
	{
		[Cpp2IlInjected.Token(Token = "0x600013D")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000043")]
public static class FIKKIOBANKG
{
	[Cpp2IlInjected.Token(Token = "0x600013E")]
	[Cpp2IlInjected.Address(RVA = "0x3D6E5E0", Offset = "0x3D6CFE0", VA = "0x183D6E5E0")]
	public static AACADPLMCLK<TResource> PEJPJJIKOOB<TResource, TId>(this GGPPGEPMEPL<TId, TResource> DMBGDIBKIKH, TId NMAIBBDGPCD, [Optional] Func<TId, CancellationToken, Task<TResource>>? ENBGCKLPPGL) where TResource : notnull where TId : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000044")]
public static class ABMAIBEICLH
{
	[Cpp2IlInjected.Token(Token = "0x2000045")]
	private sealed class BDEOIBJHFAL<T> : CGNDLDCBLDI<T?> where T : class
	{
		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override Task<T?> GLNBMPPKHIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000144")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000042")]
		public override FKFADEBPFBK<T?> JOMCHNHPFKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000145")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x6683690", Offset = "0x6682090", VA = "0x186683690")]
		public BDEOIBJHFAL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000147")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "10")]
		protected override void INJOKNFPAOB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000046")]
	private sealed class CHPLJCIILDM<T> : CGNDLDCBLDI<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A3")]
		private readonly T JHFCBDNEEJN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A4")]
		private readonly Action<T>? KNEOKAFDOBG;

		[Cpp2IlInjected.Token(Token = "0x17000043")]
		public override Task<T> GLNBMPPKHIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0xAB5C70", Offset = "0xAB4670", VA = "0x180AB5C70", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000044")]
		public override FKFADEBPFBK<T> JOMCHNHPFKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0xABA900", Offset = "0xAB9300", VA = "0x180ABA900", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014A")]
		[Cpp2IlInjected.Address(RVA = "0x6CE4060", Offset = "0x6CE2A60", VA = "0x186CE4060")]
		public CHPLJCIILDM(T FOJLDKCOGHI, Action<T>? CHDFLAOCICG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014B")]
		[Cpp2IlInjected.Address(RVA = "0x6CE3EB0", Offset = "0x6CE28B0", VA = "0x186CE3EB0", Slot = "10")]
		protected override void INJOKNFPAOB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private sealed class LDMAHGFFEDL<T> : CGNDLDCBLDI<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x17000045")]
		public override Task<T> GLNBMPPKHIM
		{
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000046")]
		public override FKFADEBPFBK<T> JOMCHNHPFKG
		{
			[Cpp2IlInjected.Token(Token = "0x600014D")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x571A450", Offset = "0x5718E50", VA = "0x18571A450")]
		public LDMAHGFFEDL(Exception ILHCGNGICHE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "10")]
		protected override void INJOKNFPAOB()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000048")]
	private sealed class NHKHGDGNNCB<T> : CGNDLDCBLDI<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000049")]
		[CompilerGenerated]
		private struct NFICHCDDBBO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AC")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AD")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AE")]
			public Task<AACADPLMCLK<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000AF")]
			private TaskAwaiter<AACADPLMCLK<T>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B0")]
			private TaskAwaiter<T> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000156")]
			[Cpp2IlInjected.Address(RVA = "0x5A4FF30", Offset = "0x5A4E930", VA = "0x185A4FF30", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000157")]
			[Cpp2IlInjected.Address(RVA = "0x5A50440", Offset = "0x5A4EE40", VA = "0x185A50440", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004A")]
		[CompilerGenerated]
		private struct FGNAJPDBOLA : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B1")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B2")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B3")]
			public Task<AACADPLMCLK<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B4")]
			private TaskAwaiter<AACADPLMCLK<T>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000158")]
			[Cpp2IlInjected.Address(RVA = "0x4FF60B0", Offset = "0x4FF4AB0", VA = "0x184FF60B0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000159")]
			[Cpp2IlInjected.Address(RVA = "0x4FF62E0", Offset = "0x4FF4CE0", VA = "0x184FF62E0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private readonly Task<AACADPLMCLK<T>> IAFBGNGKCDO;

		[Cpp2IlInjected.Token(Token = "0x17000047")]
		public override Task<T> GLNBMPPKHIM
		{
			[Cpp2IlInjected.Token(Token = "0x6000150")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000048")]
		public override FKFADEBPFBK<T> JOMCHNHPFKG
		{
			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0x5A5F3E0", Offset = "0x5A5DDE0", VA = "0x185A5F3E0")]
		public NHKHGDGNNCB(Task<AACADPLMCLK<T>> FLAIIHBKGBI)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(RVA = "0x5A5EEC0", Offset = "0x5A5D8C0", VA = "0x185A5EEC0", Slot = "10")]
		protected override void INJOKNFPAOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(RVA = "0x5A5F120", Offset = "0x5A5DB20", VA = "0x185A5F120")]
		[AsyncStateMachine(typeof(NHKHGDGNNCB<>.NFICHCDDBBO))]
		[CompilerGenerated]
		internal static Task<T> LIOPAKPDBGB(Task<AACADPLMCLK<T>> FLAIIHBKGBI)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000155")]
		[Cpp2IlInjected.Address(RVA = "0x5A5EF40", Offset = "0x5A5D940", VA = "0x185A5EF40")]
		[CompilerGenerated]
		[AsyncStateMachine(typeof(NHKHGDGNNCB<>.FGNAJPDBOLA))]
		internal static Task JEHDGCOIENO(Task<AACADPLMCLK<T>> FLAIIHBKGBI)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200004B")]
	private sealed class GINDMMNJBEB<TIn, TOut> : CGNDLDCBLDI<TOut> where TIn : notnull where TOut : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200004C")]
		[CompilerGenerated]
		private struct GMKCLFHOANO : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B8")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000B9")]
			public AsyncTaskMethodBuilder<TOut> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BA")]
			public Func<TIn, TOut> transformFunc;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BB")]
			public Task<TIn> innerTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BC")]
			private Func<TIn, TOut> <>7__wrap1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BD")]
			private TaskAwaiter<TIn> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x600015F")]
			[Cpp2IlInjected.Address(RVA = "0x5151230", Offset = "0x514FC30", VA = "0x185151230", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000160")]
			[Cpp2IlInjected.Address(RVA = "0x5151590", Offset = "0x514FF90", VA = "0x185151590", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B5")]
		private readonly AACADPLMCLK<TIn> ONEKGPBKIOF;

		[Cpp2IlInjected.Token(Token = "0x17000049")]
		public override Task<TOut> GLNBMPPKHIM
		{
			[Cpp2IlInjected.Token(Token = "0x600015A")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700004A")]
		public override FKFADEBPFBK<TOut> JOMCHNHPFKG
		{
			[Cpp2IlInjected.Token(Token = "0x600015B")]
			[Cpp2IlInjected.Address(RVA = "0xAAE190", Offset = "0xAACB90", VA = "0x180AAE190", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600015C")]
		[Cpp2IlInjected.Address(RVA = "0x512FBE0", Offset = "0x512E5E0", VA = "0x18512FBE0")]
		public GINDMMNJBEB(AACADPLMCLK<TIn> CKOPPFNMJOI, Func<TIn, TOut> PPDBENNPGFA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015D")]
		[Cpp2IlInjected.Address(RVA = "0x512FB40", Offset = "0x512E540", VA = "0x18512FB40", Slot = "10")]
		protected override void INJOKNFPAOB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600015E")]
		[Cpp2IlInjected.Address(RVA = "0x512F9C0", Offset = "0x512E3C0", VA = "0x18512F9C0")]
		[AsyncStateMachine(typeof(GINDMMNJBEB<, >.GMKCLFHOANO))]
		[CompilerGenerated]
		internal static Task<TOut> DFBAMBBIPAI(Task<TIn> CPIDIMIFIPK, Func<TIn, TOut> PPDBENNPGFA)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600013F")]
	[Cpp2IlInjected.Address(RVA = "0x32D1EB0", Offset = "0x32D08B0", VA = "0x1832D1EB0")]
	public static AACADPLMCLK<T> BENGIKOEPPE<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000140")]
	[Cpp2IlInjected.Address(RVA = "0x32D1F10", Offset = "0x32D0910", VA = "0x1832D1F10")]
	public static AACADPLMCLK<T> MAIDJMFLDAF<T>(T GGIKEMCHAAA, [Optional] Action<T>? CHDFLAOCICG) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000141")]
	[Cpp2IlInjected.Address(RVA = "0x32D1CC0", Offset = "0x32D06C0", VA = "0x1832D1CC0")]
	public static AACADPLMCLK<T> BAJPNLGFBIP<T>(Exception ILHCGNGICHE) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000142")]
	[Cpp2IlInjected.Address(RVA = "0x32D1CC0", Offset = "0x32D06C0", VA = "0x1832D1CC0")]
	public static AACADPLMCLK<T> HNJIDFDECAH<T>(Task<AACADPLMCLK<T>> FLAIIHBKGBI) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000143")]
	[Cpp2IlInjected.Address(RVA = "0x32D1E30", Offset = "0x32D0830", VA = "0x1832D1E30")]
	public static AACADPLMCLK<TOut> AJEDGAAHNKE<TOut, TIn>(AACADPLMCLK<TIn> NOJLBGFGHBD, Func<TIn, TOut> PPDBENNPGFA) where TOut : notnull where TIn : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public abstract class CGNDLDCBLDI<T> : AACADPLMCLK<T>, HPBHBMMEHME, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000BE")]
	private static readonly string CGILGPCPJKH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly HHIPOMEIBHM KMPNPOPOEDL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C0")]
	private bool ICPNMNBNLKA;

	[Cpp2IlInjected.Token(Token = "0x1700004B")]
	public bool DOGEECCMHOL
	{
		[Cpp2IlInjected.Token(Token = "0x6000161")]
		[Cpp2IlInjected.Address(RVA = "0xB8BA70", Offset = "0xB8A470", VA = "0x180B8BA70", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004C")]
	public abstract Task<T> GLNBMPPKHIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000162")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public abstract FKFADEBPFBK<T> JOMCHNHPFKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000164")]
	[Cpp2IlInjected.Address(RVA = "0x6CDD8A0", Offset = "0x6CDC2A0", VA = "0x186CDD8A0")]
	public CGNDLDCBLDI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x6CDD560", Offset = "0x6CDBF60", VA = "0x186CDD560", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void INJOKNFPAOB();
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public abstract class GIIKODNJIFI<TTask, T> : CGNDLDCBLDI<T> where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x200004F")]
	[CompilerGenerated]
	private sealed class DFDEMLCCINI
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000050")]
		private struct <<-ctor>g__AwaitThenTransformTaskResult|0>d : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C6")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C7")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C8")]
			public TTask originalTask;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000C9")]
			public DFDEMLCCINI <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000CA")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000170")]
			[Cpp2IlInjected.Address(RVA = "0x45A9230", Offset = "0x45A7C30", VA = "0x1845A9230", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000171")]
			[Cpp2IlInjected.Address(RVA = "0x45A9500", Offset = "0x45A7F00", VA = "0x1845A9500", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C4")]
		public GIIKODNJIFI<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000C5")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x600016E")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public DFDEMLCCINI()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600016F")]
		[Cpp2IlInjected.Address(RVA = "0x45EA180", Offset = "0x45E8B80", VA = "0x1845EA180")]
		[AsyncStateMachine(typeof(GIIKODNJIFI<, >.DFDEMLCCINI.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> MKLLOGLFJLG(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	private readonly Task<T> FLAIIHBKGBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000C3")]
	protected readonly CancellationTokenSource CFDOKKENJBP;

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public override Task<T> GLNBMPPKHIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000168")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004F")]
	public override FKFADEBPFBK<T> JOMCHNHPFKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000169")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x512F410", Offset = "0x512DE10", VA = "0x18512F410")]
	protected GIIKODNJIFI(TTask FLAIIHBKGBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x512F1F0", Offset = "0x512DBF0", VA = "0x18512F1F0", Slot = "10")]
	protected override void INJOKNFPAOB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600016C")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract T NBPJMAMEEPL(TTask FHIOMBJHFCB);

	[Cpp2IlInjected.Token(Token = "0x600016D")]
	[Cpp2IlInjected.Address(Slot = "12")]
	protected abstract void OJPNDDKCELO();
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public class JMOMEIPKHBK<T> : CGNDLDCBLDI<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private readonly MDANMGHNNOC<Task<T>> MNBPMBINLKO;

	[Cpp2IlInjected.Token(Token = "0x17000050")]
	public override Task<T> GLNBMPPKHIM
	{
		[Cpp2IlInjected.Token(Token = "0x6000172")]
		[Cpp2IlInjected.Address(RVA = "0x5548DD0", Offset = "0x55477D0", VA = "0x185548DD0", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public override FKFADEBPFBK<T> JOMCHNHPFKG
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000174")]
	[Cpp2IlInjected.Address(RVA = "0x5548E10", Offset = "0x5547810", VA = "0x185548E10")]
	public JMOMEIPKHBK(MDANMGHNNOC<Task<T>> MIOIBAMKIBK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x5548DB0", Offset = "0x55477B0", VA = "0x185548DB0", Slot = "10")]
	protected override void INJOKNFPAOB()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public static class KIMCNFKGFBG
{
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	public static readonly HashAlgorithmName HNDIGEOJOGB;

	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	private static readonly ThreadLocal<IncrementalHash> OIEGFCPHLLL;

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x84B4340", Offset = "0x84B2D40", VA = "0x1884B4340")]
	public static int NNHKJGIDDMK(this JMJMLMPFNDK PPKCCMJCMGB, IncrementalHash LMLHBIBFOGI, byte[] DLPGLOPAPIB)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x84B3C90", Offset = "0x84B2690", VA = "0x1884B3C90")]
	public static bool HGOGNHBJKNI([CanBeNull] this JMJMLMPFNDK PPKCCMJCMGB)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x84B3CF0", Offset = "0x84B26F0", VA = "0x1884B3CF0")]
	public static bool HGOGNHBJKNI([CanBeNull] this JMJMLMPFNDK PPKCCMJCMGB, [Out] string IHPAEKNOMOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x84B4000", Offset = "0x84B2A00", VA = "0x1884B4000")]
	public static bool HGOGNHBJKNI([CanBeNull] this JMJMLMPFNDK PPKCCMJCMGB, IncrementalHash LMLHBIBFOGI, byte[] DLPGLOPAPIB, [Out] string IHPAEKNOMOJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x84B3C00", Offset = "0x84B2600", VA = "0x1884B3C00")]
	private static bool BAFENLNIADH(byte[] LNCJJFLDFDB, Span<byte> FPNKCCIHGOF)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000054")]
public static class EJOPHHOADIF
{
	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x84B23F0", Offset = "0x84B0DF0", VA = "0x1884B23F0")]
	public static int OIHKNHDCOCF(HashAlgorithmName DMHGCOMEFHG)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x3C11DF0", Offset = "0x3C107F0", VA = "0x183C11DF0")]
	public static int NNHKJGIDDMK<T>(this T JAFHHGKIBLA, byte[] KIBJOGNIOJA, IncrementalHash LMLHBIBFOGI, byte[] OGGNLNGJMNO) where T : GGAIAGHDLPJ
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public interface GGAIAGHDLPJ
{
	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash LMLHBIBFOGI);
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public interface JMJMLMPFNDK : GGAIAGHDLPJ
{
	[Cpp2IlInjected.Token(Token = "0x17000052")]
	[CanBeNull]
	byte[] DLMEJEAONML
	{
		[Cpp2IlInjected.Token(Token = "0x6000182")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000053")]
	[CanBeNull]
	byte[] DKFBMMFDNLN
	{
		[Cpp2IlInjected.Token(Token = "0x6000183")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000057")]
public static class EODMDKIALLI
{
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private static bool GDELCLIIFBE;

	[Cpp2IlInjected.Token(Token = "0x40000D1")]
	private static readonly ArrayPool<byte> DFFFEMJPEKG;

	[Cpp2IlInjected.Token(Token = "0x40000D2")]
	private static readonly ArrayPool<char> HIMKMOLOAKI;

	[Cpp2IlInjected.Token(Token = "0x40000D3")]
	private static readonly Encoding ACKCNNPEINK;

	[Cpp2IlInjected.Token(Token = "0x40000D4")]
	private static readonly ThreadLocal<Encoder> GJEINODIHAH;

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x3C16050", Offset = "0x3C14A50", VA = "0x183C16050")]
	public static void MMHBJEIPIEK<T>(this IncrementalHash NFNOFLAOEMK, [CanBeNull] T ADKKEOFFDMM) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000185")]
	[Cpp2IlInjected.Address(RVA = "0x3C15FC0", Offset = "0x3C149C0", VA = "0x183C15FC0")]
	public static void LEIGOHAIHLD<T>(this IncrementalHash NFNOFLAOEMK, [CanBeNull] T JAFHHGKIBLA) where T : GGAIAGHDLPJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000186")]
	[Cpp2IlInjected.Address(RVA = "0x3C14E40", Offset = "0x3C13840", VA = "0x183C14E40")]
	public static void BFEKIFMBMII<T>(this IncrementalHash NFNOFLAOEMK, [CanBeNull] IList<T> CLCMLNBCJHL) where T : GGAIAGHDLPJ
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000187")]
	[Cpp2IlInjected.Address(RVA = "0x84B2770", Offset = "0x84B1170", VA = "0x1884B2770")]
	private static bool CMMFIDFPDFF([CanBeNull] GGAIAGHDLPJ JAFHHGKIBLA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000188")]
	[Cpp2IlInjected.Address(RVA = "0x84B3010", Offset = "0x84B1A10", VA = "0x1884B3010")]
	public static void MLAKJNHKDPL(this IncrementalHash LMLHBIBFOGI, string? LHBEOGCNNFD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x84B2C70", Offset = "0x84B1670", VA = "0x1884B2C70")]
	public static void KJMHLCJBANP(this IncrementalHash LMLHBIBFOGI, long AFAPOCFGNMK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(RVA = "0x84B2970", Offset = "0x84B1370", VA = "0x1884B2970")]
	public static void FPJLNJOBHBP(this IncrementalHash LMLHBIBFOGI, int BOLHMNOFHJF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(RVA = "0x84B2E40", Offset = "0x84B1840", VA = "0x1884B2E40")]
	public static void MDHIHANIAHP(this IncrementalHash LMLHBIBFOGI, short CPPEBLMOLNL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x84B2800", Offset = "0x84B1200", VA = "0x1884B2800")]
	public static void DNAFJECIMDB(this IncrementalHash LMLHBIBFOGI, byte FCGOLLIPLEF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x84B2600", Offset = "0x84B1000", VA = "0x1884B2600")]
	public static void BLHFPOOBEKA(this IncrementalHash LMLHBIBFOGI, bool PEMKBPFDOCH, bool OBGFBJKDCAA = false, bool EOECAFONAIK = false, bool OOBEBBDCGIB = false, bool BJAGLPIBFJL = false, bool EKIMIPIEGOC = false, bool AKJNOBNKBFL = false, bool LJAGMPFFCDC = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x3C15360", Offset = "0x3C13D60", VA = "0x183C15360")]
	public static void FBCCHEKCMMK<T>(this IncrementalHash LMLHBIBFOGI, T OGMIMHJKKEG) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x84B2910", Offset = "0x84B1310", VA = "0x1884B2910")]
	public static void EAKHBHPAGHA(this IncrementalHash LMLHBIBFOGI, float MMGDPKDJJAJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x84B3420", Offset = "0x84B1E20", VA = "0x1884B3420")]
	public static void NFCKEIBKMMC(this IncrementalHash LMLHBIBFOGI, ulong PPFINMEIAMN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x84B25A0", Offset = "0x84B0FA0", VA = "0x1884B25A0")]
	public static void BDDCKEDHMOH(this IncrementalHash LMLHBIBFOGI, uint NJBDIEHINMJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x84B2540", Offset = "0x84B0F40", VA = "0x1884B2540")]
	public static void AJNKAPBEFKJ(this IncrementalHash LMLHBIBFOGI, ushort PJEBMOCNOEB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x84B2B40", Offset = "0x84B1540", VA = "0x1884B2B40")]
	public static void JMJGFGJFBJD(this IncrementalHash LMLHBIBFOGI, Vector3 AFCFFEEHJCL)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000059")]
public class JEOADADBEKM : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x84B3AB0", Offset = "0x84B24B0", VA = "0x1884B3AB0")]
	public JEOADADBEKM(string JEBOHIALEMJ)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005A")]
public abstract class GLODAJCCIGG
{
	[Cpp2IlInjected.Token(Token = "0x200005B")]
	public delegate void NNJHADKBCMO(ushort AGBPIDAFDMM, ushort HNFAMCBAIMC, ushort OMFMBKAANOM, ushort FBNHCMENPLL);

	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public delegate void LCIGLCPOLML(ushort AOJDDMCFPPC, ushort GPEKMDMPCDD);

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public delegate void NDEFPPDPBIF();

	[Cpp2IlInjected.Token(Token = "0x40000D6")]
	public const ushort OJCILHCBCLN = ushort.MaxValue;

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
	protected GLODAJCCIGG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005E")]
public abstract class BAFEJDENKBC<T> : GLODAJCCIGG where T : BAFEJDENKBC<T>.FPCLDCDMHNN
{
	[Cpp2IlInjected.Token(Token = "0x200005F")]
	public interface FPCLDCDMHNN
	{
		[Cpp2IlInjected.Token(Token = "0x1700005B")]
		LCIGLCPOLML KEHHKCNFCNI
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(Slot = "0")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005C")]
		LCIGLCPOLML IEIFHJNICND
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(Slot = "1")]
			get;
		}

		[Cpp2IlInjected.Token(Token = "0x1700005D")]
		NDEFPPDPBIF CJJIOMHGCPM
		{
			[Cpp2IlInjected.Token(Token = "0x60001BE")]
			[Cpp2IlInjected.Address(Slot = "2")]
			get;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D7")]
	private Dictionary<uint, T> BMLOFKLICPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DE")]
	private NDEFPPDPBIF MHHLBBEPBMJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000DF")]
	private NDEFPPDPBIF OPNPDBGKNLM;

	[Cpp2IlInjected.Token(Token = "0x17000054")]
	public bool IBCKAGHCJJH
	{
		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0xB36DB0", Offset = "0xB357B0", VA = "0x180B36DB0")]
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0xAB2B80", Offset = "0xAB1580", VA = "0x180AB2B80")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000055")]
	public ushort OEPFGANFKFK
	{
		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x12B66F0", Offset = "0x12B50F0", VA = "0x1812B66F0")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x12B66D0", Offset = "0x12B50D0", VA = "0x1812B66D0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000056")]
	public ushort FGKPELNHIBP
	{
		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x65971A0", Offset = "0x6595BA0", VA = "0x1865971A0")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A7")]
		[Cpp2IlInjected.Address(RVA = "0x6597C50", Offset = "0x6596650", VA = "0x186597C50")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000057")]
	public ushort ABHOAMCBLIL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0xF8DAD0", Offset = "0xF8C4D0", VA = "0x180F8DAD0")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001A9")]
		[Cpp2IlInjected.Address(RVA = "0xF8DB90", Offset = "0xF8C590", VA = "0x180F8DB90")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public ushort GDKDLFHAAGD
	{
		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x65973A0", Offset = "0x6595DA0", VA = "0x1865973A0")]
		[CompilerGenerated]
		get
		{
			return default(ushort);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x6597C60", Offset = "0x6596660", VA = "0x186597C60")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	protected bool ANMOPAPNKEL
	{
		[Cpp2IlInjected.Token(Token = "0x60001AF")]
		[Cpp2IlInjected.Address(RVA = "0x12B66E0", Offset = "0x12B50E0", VA = "0x1812B66E0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	protected bool ENAOMDKPBKH
	{
		[Cpp2IlInjected.Token(Token = "0x60001B0")]
		[Cpp2IlInjected.Address(RVA = "0x23516C0", Offset = "0x23500C0", VA = "0x1823516C0")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x14000001")]
	public event NNJHADKBCMO CAGCLPHEILL
	{
		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x6597300", Offset = "0x6595D00", VA = "0x186597300")]
		[CompilerGenerated]
		add
		{
		}
		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x65973B0", Offset = "0x6595DB0", VA = "0x1865973B0")]
		[CompilerGenerated]
		remove
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AC")]
	[Cpp2IlInjected.Address(RVA = "0x6597F00", Offset = "0x6596900", VA = "0x186597F00")]
	private T MNADOKABNKL(ushort MOJPKDNFGBO)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AD")]
	[Cpp2IlInjected.Address(RVA = "0x6597BC0", Offset = "0x65965C0", VA = "0x186597BC0")]
	private T JFEPPHIAGBH(ushort MOJPKDNFGBO, ushort GNMACOIJDEM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001AE")]
	[Cpp2IlInjected.Address(RVA = "0x6597C70", Offset = "0x6596670", VA = "0x186597C70")]
	protected T LJBACFKHABO(uint CFGGHEHMDDF)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x6598020", Offset = "0x6596A20", VA = "0x186598020")]
	protected BAFEJDENKBC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x65971B0", Offset = "0x6595BB0", VA = "0x1865971B0")]
	public void EGOONAPELHK(ushort BFELCHBPMEK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x65972A0", Offset = "0x6595CA0", VA = "0x1865972A0")]
	public void EGOONAPELHK(ushort BFELCHBPMEK, ushort PDIADGDHOFB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x65971D0", Offset = "0x6595BD0", VA = "0x1865971D0", Slot = "4")]
	protected virtual void EGOONAPELHK(uint JJDGBOHFOFK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x6597450", Offset = "0x6595E50", VA = "0x186597450")]
	protected void JAGGKPEJCLN(uint JJDGBOHFOFK, uint EJDENAKHHDI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x6597F90", Offset = "0x6596990", VA = "0x186597F90")]
	protected void NJIILECNHIM(ushort MOJPKDNFGBO, ushort GNMACOIJDEM, T IMNBLKDCAKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x6597170", Offset = "0x6595B70", VA = "0x186597170")]
	private void AOOMKMJMALD(uint CFGGHEHMDDF, T IMNBLKDCAKA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x6597CB0", Offset = "0x65966B0", VA = "0x186597CB0")]
	protected void MLCIKOPBNOD(float LHPALOIPBAI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x6598010", Offset = "0x6596A10", VA = "0x186598010")]
	protected uint PICFIHFMEJO(ushort MOJPKDNFGBO, ushort GNMACOIJDEM)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x65972F0", Offset = "0x6595CF0", VA = "0x1865972F0")]
	protected ushort FCFLHMPGGPB(uint GKKOKLLDHBO)
	{
		return default(ushort);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x6598000", Offset = "0x6596A00", VA = "0x186598000")]
	protected ushort PEBBJANBKKF(uint GKKOKLLDHBO)
	{
		return default(ushort);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public abstract class HMEKAAFALHL : BAFEJDENKBC<HMEKAAFALHL.BONMFMOEACM>
{
	[Cpp2IlInjected.Token(Token = "0x2000061")]
	public class BONMFMOEACM : FPCLDCDMHNN
	{
		[Cpp2IlInjected.Token(Token = "0x1700005E")]
		public LCIGLCPOLML KEHHKCNFCNI
		{
			[Cpp2IlInjected.Token(Token = "0x60001C3")]
			[Cpp2IlInjected.Address(RVA = "0xAAE170", Offset = "0xAACB70", VA = "0x180AAE170", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C4")]
			[Cpp2IlInjected.Address(RVA = "0xAAE140", Offset = "0xAACB40", VA = "0x180AAE140")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700005F")]
		public LCIGLCPOLML IEIFHJNICND
		{
			[Cpp2IlInjected.Token(Token = "0x60001C5")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "5")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C6")]
			[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000060")]
		public NDEFPPDPBIF CJJIOMHGCPM
		{
			[Cpp2IlInjected.Token(Token = "0x60001C7")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1A0", Offset = "0xAACBA0", VA = "0x180AAE1A0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Cpp2IlInjected.Token(Token = "0x60001C8")]
			[Cpp2IlInjected.Address(RVA = "0xAAE130", Offset = "0xAACB30", VA = "0x180AAE130")]
			[CompilerGenerated]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001C9")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public BONMFMOEACM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001BF")]
	[Cpp2IlInjected.Address(RVA = "0x84B39D0", Offset = "0x84B23D0", VA = "0x1884B39D0")]
	public void EPAHBABMLIA(ushort JNKMLJPMEKL, LCIGLCPOLML OPOLNBIEKCF, LCIGLCPOLML HLHLNBDNCNF, NDEFPPDPBIF OJPIGJKKDFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C0")]
	[Cpp2IlInjected.Address(RVA = "0x84B38F0", Offset = "0x84B22F0", VA = "0x1884B38F0")]
	public void EPAHBABMLIA(ushort MOJPKDNFGBO, ushort GNMACOIJDEM, LCIGLCPOLML OPOLNBIEKCF, LCIGLCPOLML HLHLNBDNCNF, NDEFPPDPBIF OJPIGJKKDFO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C1")]
	[Cpp2IlInjected.Address(RVA = "0x84B38A0", Offset = "0x84B22A0", VA = "0x1884B38A0")]
	public void DBIPLKHEHMB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x84B3860", Offset = "0x84B2260", VA = "0x1884B3860")]
	protected HMEKAAFALHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000062")]
public class GGGFJJCDJPN : HMEKAAFALHL
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x40000E3")]
	private bool MDJGPDAKFFD;

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public bool FHLCJJBHDMI
	{
		[Cpp2IlInjected.Token(Token = "0x60001CA")]
		[Cpp2IlInjected.Address(RVA = "0xDB85B0", Offset = "0xDB6FB0", VA = "0x180DB85B0")]
		get
		{
			return default(bool);
		}
		[Cpp2IlInjected.Token(Token = "0x60001CB")]
		[Cpp2IlInjected.Address(RVA = "0xEA4E70", Offset = "0xEA3870", VA = "0x180EA4E70")]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CC")]
	[Cpp2IlInjected.Address(RVA = "0x84B37A0", Offset = "0x84B21A0", VA = "0x1884B37A0")]
	public void GFALNPPLGKO(ushort OGJODDMACCM)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CD")]
	[Cpp2IlInjected.Address(RVA = "0x84B3800", Offset = "0x84B2200", VA = "0x1884B3800")]
	public void GFALNPPLGKO(ushort OGJODDMACCM, ushort BGOPBILKJIF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x84B3860", Offset = "0x84B2260", VA = "0x1884B3860")]
	public GGGFJJCDJPN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000063")]
public abstract class FJCCPLBLAGN<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000064")]
	internal class DHBGOPIKIMP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		public TNode DKGBCFDLMOI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		public TNode AEMEEJKFKNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public ECOPGGNAJEC HJCIABFMGKM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public List<ECOPGGNAJEC> JDFNMACAEBG;

		[Cpp2IlInjected.Token(Token = "0x60001E3")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public DHBGOPIKIMP()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000065")]
	internal struct ECOPGGNAJEC : IComparable<ECOPGGNAJEC>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EF")]
		public int GMCNPLKBPIA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F0")]
		public TClaimant PIFCENMHGDO;

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x199CE10", Offset = "0x199B810", VA = "0x18199CE10")]
		public ECOPGGNAJEC(int GMCNPLKBPIA, TClaimant PIFCENMHGDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x4AFCA50", Offset = "0x4AFB450", VA = "0x184AFCA50")]
		public bool HIGHCNEKOAA([In] ECOPGGNAJEC GOCNHGEHNFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x4AFCA30", Offset = "0x4AFB430", VA = "0x184AFCA30")]
		public bool CBBGPOIFNAK([In] ECOPGGNAJEC GOCNHGEHNFD)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0x4AFCA40", Offset = "0x4AFB440", VA = "0x184AFCA40", Slot = "4")]
		public int CompareTo(ECOPGGNAJEC GOCNHGEHNFD)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x4AFCAB0", Offset = "0x4AFB4B0", VA = "0x184AFCAB0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000066")]
	public enum JFPLDEINCKO
	{
		[Cpp2IlInjected.Token(Token = "0x40000F2")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000F3")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x2000067")]
	[CompilerGenerated]
	private sealed class AFHPMEAAMGK : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F4")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F5")]
		private TNode <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		private TNode descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F8")]
		public TNode <>3__descendent;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F9")]
		public FJCCPLBLAGN<TClaimant, TNode> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FA")]
		private TNode ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FB")]
		public TNode <>3__ancestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FC")]
		private bool includeAncestor;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000FD")]
		public bool <>3__includeAncestor;

		[Cpp2IlInjected.Token(Token = "0x17000062")]
		TNode IEnumerator<TNode>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001EC")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000063")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001EE")]
			[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0xBE39C0", Offset = "0xBE23C0", VA = "0x180BE39C0")]
		[DebuggerHidden]
		public AFHPMEAAMGK(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0xAAD680", Offset = "0xAAC080", VA = "0x180AAD680", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x530DAE0", Offset = "0x530C4E0", VA = "0x18530DAE0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x530DCA0", Offset = "0x530C6A0", VA = "0x18530DCA0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001EF")]
		[Cpp2IlInjected.Address(RVA = "0x530DBC0", Offset = "0x530C5C0", VA = "0x18530DBC0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001F0")]
		[Cpp2IlInjected.Address(RVA = "0x5066830", Offset = "0x5065230", VA = "0x185066830", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private static readonly CNAMKBJAJEE<DHBGOPIKIMP> JFALPJOLCEH;

	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private static readonly CNAMKBJAJEE<List<ECOPGGNAJEC>> PJPEABEOMNE;

	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private static int JLEJHJMODPB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	internal readonly Dictionary<TClaimant, TNode> HCNHLLLCGNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E8")]
	internal readonly Dictionary<TNode, DHBGOPIKIMP> HMHHOHELPJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E9")]
	private JFPLDEINCKO GDIJNLEACAN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EA")]
	private bool JPNPFIIDGCJ;

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode GICCPKEANJD(TNode MNHKIMAOFNO);

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void CIFAFBEFLJD(TNode MNHKIMAOFNO, TClaimant HNNKBKLJENJ, TClaimant HMNEOGGCNMA);

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x50008A0", Offset = "0x4FFF2A0", VA = "0x1850008A0")]
	public FJCCPLBLAGN(JFPLDEINCKO GDIJNLEACAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x50005D0", Offset = "0x4FFEFD0", VA = "0x1850005D0")]
	public void MBODKIOEAMJ(TNode MNHKIMAOFNO, TNode CCBBLDBOMGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x4FFF160", Offset = "0x4FFDB60", VA = "0x184FFF160")]
	public void DADLBCDHOKC(TClaimant PIFCENMHGDO, TNode OBIKHPJFENC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D4")]
	[Cpp2IlInjected.Address(RVA = "0x4FFF800", Offset = "0x4FFE200", VA = "0x184FFF800", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x50002F0", Offset = "0x4FFECF0", VA = "0x1850002F0")]
	private void GCANOPALIID(TClaimant PIFCENMHGDO, TNode OPGBBIAACLN, TNode OBIKHPJFENC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x5000470", Offset = "0x4FFEE70", VA = "0x185000470")]
	private int KGJIILFIMCB()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x4FFFC50", Offset = "0x4FFE650", VA = "0x184FFFC50")]
	private void FFAEPCPKGMG(TClaimant PIFCENMHGDO, TNode OGPGLCOIEFM, TNode DEEBILEDKDG, int NCNHPJPMCHP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x5000660", Offset = "0x4FFF060", VA = "0x185000660")]
	private void PCMEPBMLOMC(ECOPGGNAJEC IOIDLBINJHA, DHBGOPIKIMP ADCKJPAFCJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x4FFF280", Offset = "0x4FFDC80", VA = "0x184FFF280")]
	private void DGIGGJBJBKJ(TClaimant PIFCENMHGDO, TNode OGPGLCOIEFM, TNode DEEBILEDKDG, int NCNHPJPMCHP = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x4FFFB40", Offset = "0x4FFE540", VA = "0x184FFFB40")]
	private void EDEKGPADDLA(ECOPGGNAJEC IOIDLBINJHA, TNode MNHKIMAOFNO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x50004E0", Offset = "0x4FFEEE0", VA = "0x1850004E0")]
	private void LEGJKLPPOCP(ECOPGGNAJEC IOIDLBINJHA, DHBGOPIKIMP ADCKJPAFCJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DC")]
	[Cpp2IlInjected.Address(RVA = "0x4FFF560", Offset = "0x4FFDF60", VA = "0x184FFF560")]
	private void DMKEOAPCIJJ(DHBGOPIKIMP ADCKJPAFCJG, bool OMFJNOAANLG = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DD")]
	[Cpp2IlInjected.Address(RVA = "0x4FFFF90", Offset = "0x4FFE990", VA = "0x184FFFF90")]
	private void FLMBNHGIJCJ(DHBGOPIKIMP ADCKJPAFCJG, TNode CCBBLDBOMGE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DE")]
	[Cpp2IlInjected.Address(RVA = "0x4FFF080", Offset = "0x4FFDA80", VA = "0x184FFF080")]
	[IteratorStateMachine(typeof(FJCCPLBLAGN<, >.AFHPMEAAMGK))]
	private IEnumerable<TNode> AFPMHBKOPNJ(TNode OGPGLCOIEFM, TNode DEEBILEDKDG, bool ELLDAHDFOMB = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DF")]
	[Cpp2IlInjected.Address(RVA = "0x5000380", Offset = "0x4FFED80", VA = "0x185000380")]
	private DHBGOPIKIMP JMPHMEDDADM(TNode MNHKIMAOFNO, TNode AEMEEJKFKNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E0")]
	[Cpp2IlInjected.Address(RVA = "0x4FFF9D0", Offset = "0x4FFE3D0", VA = "0x184FFF9D0")]
	private DHBGOPIKIMP EBGJGLKICMD(TNode MNHKIMAOFNO, TNode AEMEEJKFKNN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001E1")]
	[Cpp2IlInjected.Address(RVA = "0x4FFF690", Offset = "0x4FFE090", VA = "0x184FFF690")]
	private void DPAGGEPCAJK(DHBGOPIKIMP ADCKJPAFCJG)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000068")]
public class IEICPJBCMAE<T> : IEnumerable<IEICPJBCMAE<T>.OCJLOJGAFAE>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x2000069")]
	public struct OCJLOJGAFAE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000103")]
		public T KMAFNKGMDCF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000104")]
		public int KABGMIEBEFC;
	}

	[Cpp2IlInjected.Token(Token = "0x200006A")]
	public class MEHNNLHJLKP : IEnumerator<OCJLOJGAFAE>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000105")]
		private IEICPJBCMAE<T> HJAOHCJPEIK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000106")]
		private int KABGMIEBEFC;

		[Cpp2IlInjected.Token(Token = "0x17000066")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000201")]
			[Cpp2IlInjected.Address(RVA = "0x4B485C0", Offset = "0x4B46FC0", VA = "0x184B485C0", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000067")]
		public OCJLOJGAFAE IGCJDJEKHNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000202")]
			[Cpp2IlInjected.Address(RVA = "0x5936270", Offset = "0x5934C70", VA = "0x185936270", Slot = "4")]
			get
			{
				return default(OCJLOJGAFAE);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x5936180", Offset = "0x5934B80", VA = "0x185936180")]
		public MEHNNLHJLKP(IEICPJBCMAE<T> HJAOHCJPEIK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x5936080", Offset = "0x5934A80", VA = "0x185936080", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x4BB8D20", Offset = "0x4BB7720", VA = "0x184BB8D20", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x1366D10", Offset = "0x1365710", VA = "0x181366D10", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200006B")]
	private struct BJOEJOBJENG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000107")]
		public bool LPDGDGPFILJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000108")]
		public T KMAFNKGMDCF;
	}

	[Cpp2IlInjected.Token(Token = "0x40000FE")]
	private const int PKPEPDBNGCG = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000FF")]
	private readonly Dictionary<T, int> NPNOGHOGFJB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000100")]
	private BJOEJOBJENG[] BDMAPKFBMEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000101")]
	private int JMAOOJENAPH;

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public int GPGMHOGIHMO
	{
		[Cpp2IlInjected.Token(Token = "0x60001F1")]
		[Cpp2IlInjected.Address(RVA = "0xC5E970", Offset = "0xC5D370", VA = "0x180C5E970")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001F2")]
		[Cpp2IlInjected.Address(RVA = "0x10BA490", Offset = "0x10B8E90", VA = "0x1810BA490")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public int BEFNAMGOJCC
	{
		[Cpp2IlInjected.Token(Token = "0x60001F3")]
		[Cpp2IlInjected.Address(RVA = "0x45C05E0", Offset = "0x45BEFE0", VA = "0x1845C05E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x52D71F0", Offset = "0x52D5BF0", VA = "0x1852D71F0")]
	public IEICPJBCMAE(int JHAGJEMJCCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x52D7690", Offset = "0x52D6090", VA = "0x1852D7690")]
	public IEICPJBCMAE(OCJLOJGAFAE[] OMAFAAHMFAA, bool AGDDAMDKICE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x52D65F0", Offset = "0x52D4FF0", VA = "0x1852D65F0")]
	public int DGJDHDGJCBO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x52D6730", Offset = "0x52D5130", VA = "0x1852D6730")]
	private int HBCMKDBKGPK()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x52D7110", Offset = "0x52D5B10", VA = "0x1852D7110", Slot = "6")]
	protected virtual uint OOKIHJHEOLL(uint LMLHBIBFOGI, T KMAFNKGMDCF)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x52D6550", Offset = "0x52D4F50", VA = "0x1852D6550")]
	public bool CMCJLINPDGM(T KMAFNKGMDCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x52D7040", Offset = "0x52D5A40", VA = "0x1852D7040")]
	public int LNGHAAJOPOA(T KMAFNKGMDCF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x52D66C0", Offset = "0x52D50C0", VA = "0x1852D66C0")]
	public T ECELJOPBPCF(int KABGMIEBEFC)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x52D6DA0", Offset = "0x52D57A0", VA = "0x1852D6DA0")]
	public bool JILDHIFEDKN(T KMAFNKGMDCF, bool PADJEFIBFPA = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x52D6E30", Offset = "0x52D5830", VA = "0x1852D6E30")]
	public bool JILDHIFEDKN(T KMAFNKGMDCF, int KABGMIEBEFC, bool PADJEFIBFPA = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x52D64B0", Offset = "0x52D4EB0", VA = "0x1852D64B0")]
	private int AALNFDCFNMF(int MHADOGLMBLF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x52D7170", Offset = "0x52D5B70", VA = "0x1852D7170", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000200")]
	[Cpp2IlInjected.Address(RVA = "0x52D7170", Offset = "0x52D5B70", VA = "0x1852D7170", Slot = "4")]
	private IEnumerator<OCJLOJGAFAE> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class CNAMKBJAJEE<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	private readonly Stack<T> DDFKDPINPIO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	private readonly List<T> BHHFIGAFCLM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	private readonly int KKLKBCAADMH;

	[Cpp2IlInjected.Token(Token = "0x6000207")]
	[Cpp2IlInjected.Address(RVA = "0x6EB90F0", Offset = "0x6EB7AF0", VA = "0x186EB90F0")]
	public static CNAMKBJAJEE<T> ECAOGFOINAF(int JHAGJEMJCCP = 0, int KKLKBCAADMH = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000208")]
	[Cpp2IlInjected.Address(RVA = "0x6EB9740", Offset = "0x6EB8140", VA = "0x186EB9740")]
	public CNAMKBJAJEE()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000209")]
	[Cpp2IlInjected.Address(RVA = "0x6EB9770", Offset = "0x6EB8170", VA = "0x186EB9770")]
	public CNAMKBJAJEE(int JHAGJEMJCCP, int KKLKBCAADMH = int.MaxValue, bool DKBMMFHNJOC = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020A")]
	[Cpp2IlInjected.Address(RVA = "0x6EB95B0", Offset = "0x6EB7FB0", VA = "0x186EB95B0")]
	public T MEFJCANOAEB()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600020B")]
	[Cpp2IlInjected.Address(RVA = "0x6EB94D0", Offset = "0x6EB7ED0", VA = "0x186EB94D0")]
	public void KKMANOPBDMJ(T KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020C")]
	[Cpp2IlInjected.Address(RVA = "0x6EB93F0", Offset = "0x6EB7DF0", VA = "0x186EB93F0")]
	private void JJJENPIABFE(T KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020D")]
	[Cpp2IlInjected.Address(RVA = "0x6EB93D0", Offset = "0x6EB7DD0", VA = "0x186EB93D0")]
	private void JHFPILMPIEP(T KMAFNKGMDCF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020E")]
	[Cpp2IlInjected.Address(RVA = "0x6EB8FA0", Offset = "0x6EB79A0", VA = "0x186EB8FA0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600020F")]
	[Cpp2IlInjected.Address(RVA = "0x6EB91D0", Offset = "0x6EB7BD0", VA = "0x186EB91D0")]
	private void EIKLOCDOHHP(IEnumerable<T> FDOLNIMJMJM)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class EBILNPIBLFA<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	private Dictionary<int, T> DDMHDBLMGFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	private T BLOIOKEAIGE;

	[Cpp2IlInjected.Token(Token = "0x17000068")]
	public virtual T MKFHEMFALOH
	{
		[Cpp2IlInjected.Token(Token = "0x6000210")]
		[Cpp2IlInjected.Address(RVA = "0xAAE110", Offset = "0xAACB10", VA = "0x180AAE110", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000211")]
		[Cpp2IlInjected.Address(RVA = "0xAAE180", Offset = "0xAACB80", VA = "0x180AAE180", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000212")]
	[Cpp2IlInjected.Address(RVA = "0x4AF5890", Offset = "0x4AF4290", VA = "0x184AF5890")]
	public bool BIIEMNLFGJN(T KMAFNKGMDCF, int GMCNPLKBPIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000213")]
	[Cpp2IlInjected.Address(RVA = "0x4AF5DD0", Offset = "0x4AF47D0", VA = "0x184AF5DD0")]
	public bool OECGJOECOOH(int GMCNPLKBPIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000214")]
	[Cpp2IlInjected.Address(RVA = "0x4AF5BD0", Offset = "0x4AF45D0", VA = "0x184AF5BD0")]
	public T IILKPLPLBCG(int PIMLJJFJHFM)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000215")]
	[Cpp2IlInjected.Address(RVA = "0x4AF5750", Offset = "0x4AF4150", VA = "0x184AF5750")]
	private bool APLODEHIMMM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000216")]
	[Cpp2IlInjected.Address(RVA = "0x4AF5970", Offset = "0x4AF4370", VA = "0x184AF5970")]
	public bool BMFHANOLGIO(int GMCNPLKBPIA, [Out] T KMAFNKGMDCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000217")]
	[Cpp2IlInjected.Address(RVA = "0x4AF5E40", Offset = "0x4AF4840", VA = "0x184AF5E40")]
	public EBILNPIBLFA()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006E")]
public class MPGAMALHONK<T>
{
	[Cpp2IlInjected.Token(Token = "0x200006F")]
	protected struct GNDNEJKJOLP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		public T AFPBILBCKEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		public int BAJJHIOFCHK;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010E")]
	protected readonly List<GNDNEJKJOLP> AIBKAFMFLDI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400010F")]
	private T FAIEIGFBNHA;

	[Cpp2IlInjected.Token(Token = "0x17000069")]
	public int BEFNAMGOJCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x45C05E0", Offset = "0x45BEFE0", VA = "0x1845C05E0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000219")]
	[Cpp2IlInjected.Address(RVA = "0x59F5BE0", Offset = "0x59F45E0", VA = "0x1859F5BE0")]
	public bool GMMHHEEELIA(T KMAFNKGMDCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x59F5E30", Offset = "0x59F4830", VA = "0x1859F5E30")]
	public void HMDNMGBNKIA(T KMAFNKGMDCF, int GMCNPLKBPIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x59F6090", Offset = "0x59F4A90", VA = "0x1859F6090")]
	public bool MCKODPOBNPM(T KMAFNKGMDCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x59F59F0", Offset = "0x59F43F0", VA = "0x1859F59F0")]
	public void EMMOLKMNHIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x59F58D0", Offset = "0x59F42D0", VA = "0x1859F58D0")]
	public T ECHLKDDBKJL()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x59F55C0", Offset = "0x59F3FC0", VA = "0x1859F55C0")]
	protected void BDPDKGIGPDM()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x59F6250", Offset = "0x59F4C50", VA = "0x1859F6250")]
	public MPGAMALHONK()
	{
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000070")]
	public class ReferencePoint
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000112")]
		public Vector3 localPosition;

		[Cpp2IlInjected.FieldOffset(Offset = "0x1C")]
		[Cpp2IlInjected.Token(Token = "0x4000113")]
		public Quaternion localRotation;

		[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
		[Cpp2IlInjected.Token(Token = "0x4000114")]
		public bool ignoreScale;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x4000115")]
		[IHBEENDFBCJ(EAHEBLGAGFP.Self, false, false, false)]
		[SerializeField]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x1700006A")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x6000220")]
			[Cpp2IlInjected.Address(RVA = "0x84B4D90", Offset = "0x84B3790", VA = "0x1884B4D90")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x6000221")]
			[Cpp2IlInjected.Address(RVA = "0x84B5060", Offset = "0x84B3A60", VA = "0x1884B5060")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006B")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x6000222")]
			[Cpp2IlInjected.Address(RVA = "0x84B4F70", Offset = "0x84B3970", VA = "0x1884B4F70")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006C")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x6000223")]
			[Cpp2IlInjected.Address(RVA = "0x84B4CE0", Offset = "0x84B36E0", VA = "0x1884B4CE0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006D")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x6000224")]
			[Cpp2IlInjected.Address(RVA = "0x84B4FB0", Offset = "0x84B39B0", VA = "0x1884B4FB0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700006E")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x6000225")]
			[Cpp2IlInjected.Address(RVA = "0x84B4EC0", Offset = "0x84B38C0", VA = "0x1884B4EC0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000226")]
		[Cpp2IlInjected.Address(RVA = "0x84B4C50", Offset = "0x84B3650", VA = "0x1884B4C50")]
		public ReferencePoint()
		{
		}
	}
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000071")]
	public abstract class ResourcePrefabReference<T> where T : Component
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000116")]
		[SerializeField]
		protected string prefabName;

		[Cpp2IlInjected.Token(Token = "0x6000227")]
		[Cpp2IlInjected.Address(RVA = "0x5EB3360", Offset = "0x5EB1D60", VA = "0x185EB3360", Slot = "4")]
		public virtual T AFLFDGCHLIH()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000228")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000072")]
public interface KJIOGAFOACE
{
	[Cpp2IlInjected.Token(Token = "0x1700006F")]
	ToolHierarchyCache EMHNONCEPMA
	{
		[Cpp2IlInjected.Token(Token = "0x6000229")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
namespace RecRoom.Core.DataStructures
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000073")]
	public class ToolHierarchyCache : IEqualityComparer<ToolHierarchyCache>
	{
		[Cpp2IlInjected.Token(Token = "0x2000074")]
		public struct HCCOOMDEAHI<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			private readonly List<Component> GBEHGKLEJFE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			private readonly bool BLDKFBGEJPE;

			[Cpp2IlInjected.Token(Token = "0x6000236")]
			[Cpp2IlInjected.Address(RVA = "0x1B11FE0", Offset = "0x1B109E0", VA = "0x181B11FE0")]
			public HCCOOMDEAHI(List<Component> GBEHGKLEJFE, bool BLDKFBGEJPE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000237")]
			[Cpp2IlInjected.Address(RVA = "0x5193760", Offset = "0x5192160", VA = "0x185193760")]
			public PHODONCELNP<T> FIIFAFDLDFC()
			{
				return default(PHODONCELNP<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x6000238")]
			[Cpp2IlInjected.Address(RVA = "0x51937D0", Offset = "0x51921D0", VA = "0x1851937D0", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000239")]
			[Cpp2IlInjected.Address(RVA = "0x51937D0", Offset = "0x51921D0", VA = "0x1851937D0", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x2000075")]
		public struct PHODONCELNP<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			private readonly List<Component> GBEHGKLEJFE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			private readonly bool BLDKFBGEJPE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			private int KABGMIEBEFC;

			[Cpp2IlInjected.Token(Token = "0x17000071")]
			public T IGCJDJEKHNM
			{
				[Cpp2IlInjected.Token(Token = "0x600023B")]
				[Cpp2IlInjected.Address(RVA = "0x5CAC5C0", Offset = "0x5CAAFC0", VA = "0x185CAC5C0", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000072")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x600023C")]
				[Cpp2IlInjected.Address(RVA = "0x5CAC550", Offset = "0x5CAAF50", VA = "0x185CAC550", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600023A")]
			[Cpp2IlInjected.Address(RVA = "0x5CAC590", Offset = "0x5CAAF90", VA = "0x185CAC590")]
			public PHODONCELNP(List<Component> GBEHGKLEJFE, bool BLDKFBGEJPE)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023D")]
			[Cpp2IlInjected.Address(RVA = "0x5CAC490", Offset = "0x5CAAE90", VA = "0x185CAC490", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600023E")]
			[Cpp2IlInjected.Address(RVA = "0x5CAC4A0", Offset = "0x5CAAEA0", VA = "0x185CAC4A0", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x600023F")]
			[Cpp2IlInjected.Address(RVA = "0x4B9CCF0", Offset = "0x4B9B6F0", VA = "0x184B9CCF0", Slot = "8")]
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

		[Cpp2IlInjected.Token(Token = "0x17000070")]
		public bool IsInitialized
		{
			[Cpp2IlInjected.Token(Token = "0x600022A")]
			[Cpp2IlInjected.Address(RVA = "0x84B6AC0", Offset = "0x84B54C0", VA = "0x1884B6AC0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600022B")]
		[Cpp2IlInjected.Address(RVA = "0xAAE100", Offset = "0xAACB00", VA = "0x180AAE100")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022C")]
		[Cpp2IlInjected.Address(RVA = "0x84B64B0", Offset = "0x84B4EB0", VA = "0x1884B64B0")]
		private void GFALNPPLGKO(GameObject CFNIACIFDFN, bool KEJIJALNLAM = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022D")]
		[Cpp2IlInjected.Address(RVA = "0x84B6420", Offset = "0x84B4E20", VA = "0x1884B6420")]
		public static void GFALNPPLGKO(GameObject CFNIACIFDFN, ToolHierarchyCache DMBGDIBKIKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022E")]
		[Cpp2IlInjected.Address(RVA = "0x84B6A20", Offset = "0x84B5420", VA = "0x1884B6A20")]
		public void OLGKJIKJDDF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600022F")]
		[Cpp2IlInjected.Address(RVA = "0x4143B70", Offset = "0x4142570", VA = "0x184143B70")]
		public void LHKLDNMJLLJ<T>(Action<T> FCCCPABHDPG)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000230")]
		[Cpp2IlInjected.Address(RVA = "0x4143B00", Offset = "0x4142500", VA = "0x184143B00")]
		public T GFJECODPGHD<T>(bool BLDKFBGEJPE = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000231")]
		[Cpp2IlInjected.Address(RVA = "0x4143D90", Offset = "0x4142790", VA = "0x184143D90")]
		public HCCOOMDEAHI<T> NEKIIOCLBDD<T>(bool BLDKFBGEJPE = false) where T : class
		{
			return default(HCCOOMDEAHI<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000232")]
		[Cpp2IlInjected.Address(RVA = "0x84B6690", Offset = "0x84B5090", VA = "0x1884B6690")]
		public List<Component> NIGJMEIBLEM(Type DGNODDPLLPC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000233")]
		[Cpp2IlInjected.Address(RVA = "0x84B63A0", Offset = "0x84B4DA0", VA = "0x1884B63A0", Slot = "4")]
		public bool Equals(ToolHierarchyCache FKPKEFAKAOE, ToolHierarchyCache KEEMKILMOML)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000234")]
		[Cpp2IlInjected.Address(RVA = "0x84B6620", Offset = "0x84B5020", VA = "0x1884B6620", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache PMNHIPACJLN)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000076")]
public class KEDMLNCPEDK<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private int JHAGJEMJCCP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private int ADFBGOFFJHC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private List<T> ENCMPDIEHPC;

	[Cpp2IlInjected.Token(Token = "0x17000073")]
	public int BEFNAMGOJCC
	{
		[Cpp2IlInjected.Token(Token = "0x6000240")]
		[Cpp2IlInjected.Address(RVA = "0x5548DD0", Offset = "0x55477D0", VA = "0x185548DD0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000074")]
	public T BPADAMHNFHG
	{
		[Cpp2IlInjected.Token(Token = "0x6000241")]
		[Cpp2IlInjected.Address(RVA = "0x564B5A0", Offset = "0x5649FA0", VA = "0x18564B5A0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000075")]
	public T NIBHEICONGP
	{
		[Cpp2IlInjected.Token(Token = "0x6000242")]
		[Cpp2IlInjected.Address(RVA = "0x564B190", Offset = "0x5649B90", VA = "0x18564B190")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000076")]
	public T JMDLCNOIOPP
	{
		[Cpp2IlInjected.Token(Token = "0x6000243")]
		[Cpp2IlInjected.Address(RVA = "0x564B0A0", Offset = "0x5649AA0", VA = "0x18564B0A0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000244")]
	[Cpp2IlInjected.Address(RVA = "0x564B720", Offset = "0x564A120", VA = "0x18564B720")]
	public KEDMLNCPEDK(int JHAGJEMJCCP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000245")]
	[Cpp2IlInjected.Address(RVA = "0x564B4A0", Offset = "0x5649EA0", VA = "0x18564B4A0")]
	public void HMDNMGBNKIA(T JCMALLELNNK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000246")]
	[Cpp2IlInjected.Address(RVA = "0x564B310", Offset = "0x5649D10", VA = "0x18564B310")]
	public void EMMOLKMNHIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000247")]
	[Cpp2IlInjected.Address(RVA = "0x564AFE0", Offset = "0x56499E0", VA = "0x18564AFE0")]
	public void ADGJHJEJOEN()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000248")]
	[Cpp2IlInjected.Address(RVA = "0x564B350", Offset = "0x5649D50", VA = "0x18564B350")]
	public void HJLHJMIDNHC()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000249")]
	[Cpp2IlInjected.Address(RVA = "0x564B300", Offset = "0x5649D00", VA = "0x18564B300")]
	public void CPLLKBONJKL()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600024A")]
	[Cpp2IlInjected.Address(RVA = "0x564B280", Offset = "0x5649C80", VA = "0x18564B280")]
	public List<T> BELEHMEJDNM()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000077")]
public class PBMHLLBNIIC<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000078")]
	private struct FCABDBAEGHG
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public int BAJJHIOFCHK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public T AFPBILBCKEL;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private readonly Dictionary<object, FCABDBAEGHG> DDMHDBLMGFA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private readonly EqualityComparer<T> JDOBPCNONNC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private T BLOIOKEAIGE;

	[Cpp2IlInjected.Token(Token = "0x17000077")]
	public virtual T MKFHEMFALOH
	{
		[Cpp2IlInjected.Token(Token = "0x600024B")]
		[Cpp2IlInjected.Address(RVA = "0xEC9A60", Offset = "0xEC8460", VA = "0x180EC9A60", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600024C")]
		[Cpp2IlInjected.Address(RVA = "0x5C92FD0", Offset = "0x5C919D0", VA = "0x185C92FD0", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000078")]
	public bool MCCKGLPLJJB
	{
		[Cpp2IlInjected.Token(Token = "0x600024D")]
		[Cpp2IlInjected.Address(RVA = "0x5C93040", Offset = "0x5C91A40", VA = "0x185C93040")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000079")]
	public object HJNDCLMMMAD
	{
		[Cpp2IlInjected.Token(Token = "0x600024E")]
		[Cpp2IlInjected.Address(RVA = "0xAAE120", Offset = "0xAACB20", VA = "0x180AAE120")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x600024F")]
		[Cpp2IlInjected.Address(RVA = "0xAAE160", Offset = "0xAACB60", VA = "0x180AAE160")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000250")]
	[Cpp2IlInjected.Address(RVA = "0x5C92290", Offset = "0x5C90C90", VA = "0x185C92290")]
	public bool BIIEMNLFGJN(T KMAFNKGMDCF, object MFKHKDDANII, int GMCNPLKBPIA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000251")]
	[Cpp2IlInjected.Address(RVA = "0x5C93090", Offset = "0x5C91A90", VA = "0x185C93090")]
	public bool OECGJOECOOH(object MFKHKDDANII)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000252")]
	[Cpp2IlInjected.Address(RVA = "0x5C92A70", Offset = "0x5C91470", VA = "0x185C92A70")]
	public bool BMFHANOLGIO(object MFKHKDDANII, [Out] T KMAFNKGMDCF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000253")]
	[Cpp2IlInjected.Address(RVA = "0x5C92F60", Offset = "0x5C91960", VA = "0x185C92F60")]
	public void EMMOLKMNHIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000254")]
	[Cpp2IlInjected.Address(RVA = "0x5C8F550", Offset = "0x5C8DF50", VA = "0x185C8F550")]
	private bool APLODEHIMMM()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000255")]
	[Cpp2IlInjected.Address(RVA = "0x5C93120", Offset = "0x5C91B20", VA = "0x185C93120")]
	public PBMHLLBNIIC()
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
