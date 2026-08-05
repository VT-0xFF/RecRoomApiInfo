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
		[Cpp2IlInjected.Address(RVA = "0x890220", Offset = "0x88EE20", VA = "0x180890220")]
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
		[Cpp2IlInjected.Address(RVA = "0x69A3390", Offset = "0x69A1F90", VA = "0x1869A3390")]
		public NullableAttribute(byte P_0)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000003")]
		[Cpp2IlInjected.Address(RVA = "0x890890", Offset = "0x88F490", VA = "0x180890890")]
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
		[Cpp2IlInjected.Address(RVA = "0x8908D0", Offset = "0x88F4D0", VA = "0x1808908D0")]
		public NullableContextAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000005")]
public class OAKOPEMKIHE : PropertyAttribute
{
	[Cpp2IlInjected.Token(Token = "0x6000005")]
	[Cpp2IlInjected.Address(RVA = "0x14EC7A0", Offset = "0x14EB3A0", VA = "0x1814EC7A0")]
	public OAKOPEMKIHE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000006")]
public abstract class HashableScriptableObject : ScriptableObject, NCACCCFGOPK, EDFJOAOCNCD, ISerializationCallbackReceiver
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
		[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990", Slot = "4")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x868D60", Offset = "0x867960", VA = "0x180868D60", Slot = "9")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000002")]
	public byte[] Seed
	{
		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x867590", Offset = "0x866190", VA = "0x180867590", Slot = "5")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x867D20", Offset = "0x866920", VA = "0x180867D20", Slot = "10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000003")]
	public UnityEngine.Object Asset
	{
		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x932F10", Offset = "0x931B10", VA = "0x180932F10", Slot = "11")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600000B")]
	[Cpp2IlInjected.Address(Slot = "12")]
	public abstract void AppendToHash(IncrementalHash FJHEHEDBGNJ);

	[Cpp2IlInjected.Token(Token = "0x600000C")]
	[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "13")]
	public virtual void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000D")]
	[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "14")]
	public virtual void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600000E")]
	[Cpp2IlInjected.Address(RVA = "0x8D15E0", Offset = "0x8D01E0", VA = "0x1808D15E0")]
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
		[Cpp2IlInjected.Address(RVA = "0x69A4A50", Offset = "0x69A3650", VA = "0x1869A4A50")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000005")]
	public Vector3 LocalSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000010")]
		[Cpp2IlInjected.Address(RVA = "0x69A4A10", Offset = "0x69A3610", VA = "0x1869A4A10")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000006")]
	public Vector3 LocalSpaceSize
	{
		[Cpp2IlInjected.Token(Token = "0x6000011")]
		[Cpp2IlInjected.Address(RVA = "0x69A4A90", Offset = "0x69A3690", VA = "0x1869A4A90")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000007")]
	public Vector3 WorldSpaceMin
	{
		[Cpp2IlInjected.Token(Token = "0x6000012")]
		[Cpp2IlInjected.Address(RVA = "0x69A4C40", Offset = "0x69A3840", VA = "0x1869A4C40")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000008")]
	public Vector3 WorldSpaceMax
	{
		[Cpp2IlInjected.Token(Token = "0x6000013")]
		[Cpp2IlInjected.Address(RVA = "0x69A4BB0", Offset = "0x69A37B0", VA = "0x1869A4BB0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000009")]
	public float MaxLocalSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000014")]
		[Cpp2IlInjected.Address(RVA = "0x8D15D0", Offset = "0x8D01D0", VA = "0x1808D15D0")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000A")]
	public float MaxWorldSpaceRadius
	{
		[Cpp2IlInjected.Token(Token = "0x6000015")]
		[Cpp2IlInjected.Address(RVA = "0x8D1590", Offset = "0x8D0190", VA = "0x1808D1590")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000B")]
	public Vector3 LocalSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000016")]
		[Cpp2IlInjected.Address(RVA = "0x69A49D0", Offset = "0x69A35D0", VA = "0x1869A49D0")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000C")]
	public Vector3 WorldSpaceCenter
	{
		[Cpp2IlInjected.Token(Token = "0x6000017")]
		[Cpp2IlInjected.Address(RVA = "0x69A4B20", Offset = "0x69A3720", VA = "0x1869A4B20")]
		get
		{
			return default(Vector3);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000018")]
	[Cpp2IlInjected.Address(RVA = "0x69A4440", Offset = "0x69A3040", VA = "0x1869A4440")]
	public void CopyBounds(SavedExtents HEIGABGMPLJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000019")]
	[Cpp2IlInjected.Address(RVA = "0x69A4920", Offset = "0x69A3520", VA = "0x1869A4920")]
	public void SetLocalSpaceBounds(Bounds DNGFKKMDPAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001A")]
	[Cpp2IlInjected.Address(RVA = "0xBAB3C0", Offset = "0xBA9FC0", VA = "0x180BAB3C0")]
	public Bounds AsLocalSpaceBounds()
	{
		return default(Bounds);
	}

	[Cpp2IlInjected.Token(Token = "0x600001B")]
	[Cpp2IlInjected.Address(RVA = "0x69A4910", Offset = "0x69A3510", VA = "0x1869A4910")]
	private void OnEnable()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001C")]
	[Cpp2IlInjected.Address(RVA = "0x69A4470", Offset = "0x69A3070", VA = "0x1869A4470")]
	private void FCGJBHDONCG()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001D")]
	[Cpp2IlInjected.Address(RVA = "0x69A46F0", Offset = "0x69A32F0", VA = "0x1869A46F0")]
	private void OnDrawGizmosSelected()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001E")]
	[Cpp2IlInjected.Address(RVA = "0x69A3DD0", Offset = "0x69A29D0", VA = "0x1869A3DD0")]
	public static void CalculateLocalBoundsFor(GameObject OJCNPGOLEHK, [Out] Bounds DNGFKKMDPAD)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600001F")]
	[Cpp2IlInjected.Address(RVA = "0x69A4630", Offset = "0x69A3230", VA = "0x1869A4630")]
	private static void HCLKBLCFBFC(Bounds GCHHKKAJBGE, Color KOBLLIODAMP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000020")]
	[Cpp2IlInjected.Address(RVA = "0x69A4940", Offset = "0x69A3540", VA = "0x1869A4940")]
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
		[Cpp2IlInjected.Address(RVA = "0x8651A0", Offset = "0x863DA0", VA = "0x1808651A0")]
		get
		{
			return (TKey)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x868D10", Offset = "0x867910", VA = "0x180868D10")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700000E")]
	public TVal Val
	{
		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0xFEE9D0", Offset = "0xFED5D0", VA = "0x180FEE9D0")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000029")]
		[Cpp2IlInjected.Address(RVA = "0x4999300", Offset = "0x4997F00", VA = "0x184999300")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002A")]
	[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "4")]
	public virtual void AOCHFFEJAIK()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002B")]
	[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
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
	[OAKOPEMKIHE]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.Token(Token = "0x600002C")]
	[Cpp2IlInjected.Address(RVA = "0x4998E30", Offset = "0x4997A30", VA = "0x184998E30", Slot = "46")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002D")]
	[Cpp2IlInjected.Address(RVA = "0x49974E0", Offset = "0x49960E0", VA = "0x1849974E0", Slot = "47")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600002E")]
	[Cpp2IlInjected.Address(RVA = "0x49991F0", Offset = "0x4997DF0", VA = "0x1849991F0")]
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
	private sealed class MHBBIEJCLFF
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		public Comparer<TKey> comparer;

		[Cpp2IlInjected.Token(Token = "0x600003C")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public MHBBIEJCLFF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600003D")]
		[Cpp2IlInjected.Address(RVA = "0x448BD10", Offset = "0x448A910", VA = "0x18448BD10")]
		internal int KNAOCALKKDO(TKeyVal lhs, TKeyVal rhs)
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000010")]
	[SerializeField]
	[OAKOPEMKIHE]
	private List<TKeyVal> serializedData;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000011")]
	private readonly Dictionary<TKey, TVal> impl;

	[Cpp2IlInjected.Token(Token = "0x1700000F")]
	public IEnumerable<TKey> Keys
	{
		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x38628E0", Offset = "0x38614E0", VA = "0x1838628E0", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000010")]
	public IEnumerable<TVal> Values
	{
		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x3862940", Offset = "0x3861540", VA = "0x183862940", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000011")]
	public int Count
	{
		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x38627B0", Offset = "0x38613B0", VA = "0x1838627B0", Slot = "9")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000012")]
	public TVal this[TKey NCMHANGAILD]
	{
		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x3862870", Offset = "0x3861470", VA = "0x183862870", Slot = "6")]
		get
		{
			return (TVal)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000013")]
	protected virtual Comparison<TKeyVal> Comparison
	{
		[Cpp2IlInjected.Token(Token = "0x600003A")]
		[Cpp2IlInjected.Address(RVA = "0x3862650", Offset = "0x3861250", VA = "0x183862650", Slot = "15")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600002F")]
	[Cpp2IlInjected.Address(RVA = "0x3862260", Offset = "0x3860E60", VA = "0x183862260", Slot = "12")]
	public void OnBeforeSerialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000030")]
	[Cpp2IlInjected.Address(RVA = "0x3861620", Offset = "0x3860220", VA = "0x183861620", Slot = "13")]
	public void OnAfterDeserialize()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000031")]
	[Cpp2IlInjected.Address(RVA = "0x3862460", Offset = "0x3861060", VA = "0x183862460", Slot = "14")]
	protected virtual string PAKPLLNFJAE(TKeyVal KALEMCMHEGE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000036")]
	[Cpp2IlInjected.Address(RVA = "0x3861510", Offset = "0x3860110", VA = "0x183861510", Slot = "4")]
	public bool ContainsKey(TKey NCMHANGAILD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000037")]
	[Cpp2IlInjected.Address(RVA = "0x38624C0", Offset = "0x38610C0", VA = "0x1838624C0", Slot = "5")]
	public bool TryGetValue(TKey NCMHANGAILD, [Out] TVal IIPLJLPCLBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000038")]
	[Cpp2IlInjected.Address(RVA = "0x3861570", Offset = "0x3860170", VA = "0x183861570", Slot = "10")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000039")]
	[Cpp2IlInjected.Address(RVA = "0x3861570", Offset = "0x3860170", VA = "0x183861570", Slot = "11")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600003B")]
	[Cpp2IlInjected.Address(RVA = "0x3862520", Offset = "0x3861120", VA = "0x183862520")]
	protected EditableSerializedDictionary()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200000D")]
public class NCBGLCBIMML<T>
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	private class MOPJODPONAJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000017")]
		public float NGGCJHKHKIP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000018")]
		public T JCMGPEFMEMP;

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public MOPJODPONAJ()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200000F")]
	[CompilerGenerated]
	private sealed class CPOCJKLHHEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000019")]
		public float? minTime;

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public CPOCJKLHHEE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x56BBFB0", Offset = "0x56BABB0", VA = "0x1856BBFB0")]
		internal bool CDMJLAINCLP(MOPJODPONAJ sample)
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000013")]
	public readonly float NNAGEODHGDF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000014")]
	public readonly float EKEBEDOFGJH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000015")]
	private List<MOPJODPONAJ> KFONCJHINLP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000016")]
	private APELDPIDBDH<MOPJODPONAJ> ELCBBBLCGCG;

	[Cpp2IlInjected.Token(Token = "0x17000014")]
	public int BDEIHENINAO
	{
		[Cpp2IlInjected.Token(Token = "0x600003E")]
		[Cpp2IlInjected.Address(RVA = "0x44DCD30", Offset = "0x44DB930", VA = "0x1844DCD30")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600003F")]
	[Cpp2IlInjected.Address(RVA = "0x44DD8B0", Offset = "0x44DC4B0", VA = "0x1844DD8B0")]
	public NCBGLCBIMML(float LECFFBMOMFC, float IMNIFIIHFHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000040")]
	[Cpp2IlInjected.Address(RVA = "0x44DD6C0", Offset = "0x44DC2C0", VA = "0x1844DD6C0")]
	public bool KEHKEBDMDPM(float GHOMDKPGIGE, T IIPLJLPCLBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000041")]
	[Cpp2IlInjected.Address(RVA = "0x44DCDA0", Offset = "0x44DB9A0", VA = "0x1844DCDA0")]
	public IEnumerable<T> IBEFINNFHEB(float GHOMDKPGIGE, [Optional] float? MNLAJDPNJIB)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000042")]
	[Cpp2IlInjected.Address(RVA = "0x44DCC00", Offset = "0x44DB800", VA = "0x1844DCC00")]
	public void AFPCPCPKMJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000043")]
	[Cpp2IlInjected.Address(RVA = "0x44DCA40", Offset = "0x44DB640", VA = "0x1844DCA40")]
	private void AFDCCNKCGDI(float GHOMDKPGIGE)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000011")]
public abstract class IJGKIGEMNIA<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000012")]
	public struct AOFNOOLBLAP
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000022")]
		public T JCMGPEFMEMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000023")]
		public float JNHHIFMHCCA;
	}

	[Cpp2IlInjected.Token(Token = "0x400001D")]
	private static float APCINKCNGNO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400001E")]
	private List<T> COBBMPNFDMD;

	[Cpp2IlInjected.Token(Token = "0x400001F")]
	private const int EGPEBBGLBPA = 16;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000020")]
	private AOFNOOLBLAP[] DKCMKELIAPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000021")]
	private int DHBLEKPHMGK;

	[Cpp2IlInjected.Token(Token = "0x17000015")]
	public float NKBDILAPMGC
	{
		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9B4840", Offset = "0x9B3440", VA = "0x1809B4840")]
		[CompilerGenerated]
		get
		{
			return default(float);
		}
		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9C1A20", Offset = "0x9C0620", VA = "0x1809C1A20")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600004C")]
	[Cpp2IlInjected.Address(RVA = "0x3EAE220", Offset = "0x3EACE20", VA = "0x183EAE220")]
	public IJGKIGEMNIA()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004D")]
	[Cpp2IlInjected.Address(RVA = "0x3EAE260", Offset = "0x3EACE60", VA = "0x183EAE260")]
	public IJGKIGEMNIA(int INGCLKPLIOP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004E")]
	[Cpp2IlInjected.Address(RVA = "0x3EAD950", Offset = "0x3EAC550", VA = "0x183EAD950")]
	public void LKPJOLMECIF(float GHOMDKPGIGE, T IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600004F")]
	[Cpp2IlInjected.Address(RVA = "0x3EAD1D0", Offset = "0x3EABDD0", VA = "0x183EAD1D0")]
	public void AFPCPCPKMJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000050")]
	[Cpp2IlInjected.Address(RVA = "0x3EAD310", Offset = "0x3EABF10", VA = "0x183EAD310")]
	public bool LKJMLGKGOCD(float CMLKPGPBFBC, float NLHHOLAAEOF, [Out] T IIPLJLPCLBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000051")]
	[Cpp2IlInjected.Address(RVA = "0x3EADFF0", Offset = "0x3EACBF0", VA = "0x183EADFF0")]
	public bool NGEPPICHMGK(float CMLKPGPBFBC, float NLHHOLAAEOF, [Out] T IIPLJLPCLBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000052")]
	[Cpp2IlInjected.Address(RVA = "0x3EADA60", Offset = "0x3EAC660", VA = "0x183EADA60")]
	public void MIGDGLJLLAL(float CMLKPGPBFBC, float NLHHOLAAEOF, List<T> EBPAODHLEDO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000053")]
	[Cpp2IlInjected.Address(RVA = "0x3EADD90", Offset = "0x3EAC990", VA = "0x183EADD90")]
	private int NEHCEEPNMEF(int IDCIDGDMGPJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000054")]
	[Cpp2IlInjected.Address(RVA = "0x3EAD2C0", Offset = "0x3EABEC0", VA = "0x183EAD2C0")]
	private void CHIPEEIPAKH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000055")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T DDAKCIGLPKP();

	[Cpp2IlInjected.Token(Token = "0x6000056")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract T GDGBLDGCHNO(T IIPLJLPCLBC, float GLMCDBEDNLG);

	[Cpp2IlInjected.Token(Token = "0x6000057")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract T OGFJFNIKMBO(T HFIDNJCGLJB, T MGPFNHKFBHO);

	[Cpp2IlInjected.Token(Token = "0x6000058")]
	[Cpp2IlInjected.Address(Slot = "7")]
	protected abstract T OPCFACMJPIG(T HFIDNJCGLJB, T MGPFNHKFBHO);
}
[Cpp2IlInjected.Token(Token = "0x2000013")]
public class NMLFEMJIEKK : IJGKIGEMNIA<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x600005A")]
	[Cpp2IlInjected.Address(RVA = "0x875CE0", Offset = "0x8748E0", VA = "0x180875CE0", Slot = "4")]
	protected override Vector3 DDAKCIGLPKP()
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005B")]
	[Cpp2IlInjected.Address(RVA = "0x69A31C0", Offset = "0x69A1DC0", VA = "0x1869A31C0", Slot = "5")]
	protected override Vector3 GDGBLDGCHNO(Vector3 IIPLJLPCLBC, float GLMCDBEDNLG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005C")]
	[Cpp2IlInjected.Address(RVA = "0x69A3200", Offset = "0x69A1E00", VA = "0x1869A3200", Slot = "6")]
	protected override Vector3 OGFJFNIKMBO(Vector3 HFIDNJCGLJB, Vector3 MGPFNHKFBHO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005D")]
	[Cpp2IlInjected.Address(RVA = "0x69A3250", Offset = "0x69A1E50", VA = "0x1869A3250", Slot = "7")]
	protected override Vector3 OPCFACMJPIG(Vector3 HFIDNJCGLJB, Vector3 MGPFNHKFBHO)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x600005E")]
	[Cpp2IlInjected.Address(RVA = "0x69A32D0", Offset = "0x69A1ED0", VA = "0x1869A32D0")]
	public NMLFEMJIEKK()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000014")]
public static class IJFKKINBFNA
{
	[Cpp2IlInjected.Token(Token = "0x600005F")]
	[Cpp2IlInjected.Address(RVA = "0x2B79B70", Offset = "0x2B78770", VA = "0x182B79B70")]
	public static EKIHDDBHECE<T1, T2> NCPDNLLGMJA<T1, T2>(T1 NNLHHBMCMBD, T2 CEJNNMGHCFC)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000060")]
	[Cpp2IlInjected.Address(RVA = "0x2B79C00", Offset = "0x2B78800", VA = "0x182B79C00")]
	public static BBCLBHECJMJ<T1, T2, T3> NCPDNLLGMJA<T1, T2, T3>(T1 NNLHHBMCMBD, T2 CEJNNMGHCFC, T3 FDEGAAHINAN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000061")]
	[Cpp2IlInjected.Address(RVA = "0x44CAFD0", Offset = "0x44C9BD0", VA = "0x1844CAFD0")]
	internal static int GKAKAOOHIGK(int CPLOLBMENFJ, int BJDPBOODJMI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000062")]
	[Cpp2IlInjected.Address(RVA = "0x5D55750", Offset = "0x5D54350", VA = "0x185D55750")]
	internal static int GKAKAOOHIGK(int CPLOLBMENFJ, int BJDPBOODJMI, int EHLKICIIEDH)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000015")]
public class EKIHDDBHECE<T1, T2> : IComparable<EKIHDDBHECE<T1, T2>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000024")]
	public readonly T1 PGBDLDMPFJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000025")]
	public readonly T2 KACKDJLEJCG;

	[Cpp2IlInjected.Token(Token = "0x6000063")]
	[Cpp2IlInjected.Address(RVA = "0x384EEE0", Offset = "0x384DAE0", VA = "0x18384EEE0")]
	public EKIHDDBHECE(T1 NNLHHBMCMBD, T2 CEJNNMGHCFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000064")]
	[Cpp2IlInjected.Address(RVA = "0x384D5D0", Offset = "0x384C1D0", VA = "0x18384D5D0", Slot = "4")]
	public int CompareTo(EKIHDDBHECE<T1, T2> HEIGABGMPLJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000065")]
	[Cpp2IlInjected.Address(RVA = "0x384D830", Offset = "0x384C430", VA = "0x18384D830", Slot = "0")]
	public override bool Equals(object HEIGABGMPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000066")]
	[Cpp2IlInjected.Address(RVA = "0x384E2B0", Offset = "0x384CEB0", VA = "0x18384E2B0", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000067")]
	[Cpp2IlInjected.Address(RVA = "0x384E790", Offset = "0x384D390", VA = "0x18384E790", Slot = "3")]
	public override string ToString()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000016")]
public class BBCLBHECJMJ<T1, T2, T3> : IComparable<BBCLBHECJMJ<T1, T2, T3>>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000026")]
	public readonly T1 PGBDLDMPFJG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000027")]
	public readonly T2 KACKDJLEJCG;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000028")]
	public readonly T3 PJGGFJANOOA;

	[Cpp2IlInjected.Token(Token = "0x6000068")]
	[Cpp2IlInjected.Address(RVA = "0x4E54610", Offset = "0x4E53210", VA = "0x184E54610")]
	public BBCLBHECJMJ(T1 NNLHHBMCMBD, T2 CEJNNMGHCFC, T3 FDEGAAHINAN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000069")]
	[Cpp2IlInjected.Address(RVA = "0x4E53E00", Offset = "0x4E52A00", VA = "0x184E53E00", Slot = "4")]
	public int CompareTo(BBCLBHECJMJ<T1, T2, T3> HEIGABGMPLJ)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006A")]
	[Cpp2IlInjected.Address(RVA = "0x4E54060", Offset = "0x4E52C60", VA = "0x184E54060", Slot = "0")]
	public override bool Equals(object HEIGABGMPLJ)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600006B")]
	[Cpp2IlInjected.Address(RVA = "0x4E54210", Offset = "0x4E52E10", VA = "0x184E54210", Slot = "2")]
	public override int GetHashCode()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x600006C")]
	[Cpp2IlInjected.Address(RVA = "0x4E54450", Offset = "0x4E53050", VA = "0x184E54450", Slot = "3")]
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
	public T JCMGPEFMEMP
	{
		[Cpp2IlInjected.Token(Token = "0x600006D")]
		[Cpp2IlInjected.Address(RVA = "0x230EE70", Offset = "0x230DA70", VA = "0x18230EE70")]
		[CompilerGenerated]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600006E")]
		[Cpp2IlInjected.Address(RVA = "0x230ECF0", Offset = "0x230D8F0", VA = "0x18230ECF0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000017")]
	public float HFBFNDFKOOP
	{
		[Cpp2IlInjected.Token(Token = "0x600006F")]
		[Cpp2IlInjected.Address(RVA = "0x8D1530", Offset = "0x8D0130", VA = "0x1808D1530")]
		get
		{
			return default(float);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000070")]
	[Cpp2IlInjected.Address(RVA = "0x4BD8A50", Offset = "0x4BD7650", VA = "0x184BD8A50")]
	public T PHPPLBMILPN(float GLMCDBEDNLG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000071")]
	[Cpp2IlInjected.Address(RVA = "0x4BD84D0", Offset = "0x4BD70D0", VA = "0x184BD84D0")]
	public T FGHJOBEOJCC(float GLMCDBEDNLG)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000072")]
	[Cpp2IlInjected.Address(Slot = "4")]
	protected abstract T LEODDAJDOCI(T HFIDNJCGLJB, T MGPFNHKFBHO, float GLMCDBEDNLG);

	[Cpp2IlInjected.Token(Token = "0x6000073")]
	[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
	protected ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000018")]
public class FloatValueCurve : ValueCurve<float>
{
	[Cpp2IlInjected.Token(Token = "0x6000074")]
	[Cpp2IlInjected.Address(RVA = "0x69A2A90", Offset = "0x69A1690", VA = "0x1869A2A90", Slot = "4")]
	protected override float LEODDAJDOCI(float HFIDNJCGLJB, float MGPFNHKFBHO, float GLMCDBEDNLG)
	{
		return default(float);
	}

	[Cpp2IlInjected.Token(Token = "0x6000075")]
	[Cpp2IlInjected.Address(RVA = "0x69A2AD0", Offset = "0x69A16D0", VA = "0x1869A2AD0")]
	public FloatValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x2000019")]
public class Vector3ValueCurve : ValueCurve<Vector3>
{
	[Cpp2IlInjected.Token(Token = "0x6000076")]
	[Cpp2IlInjected.Address(RVA = "0xE8A3C0", Offset = "0xE88FC0", VA = "0x180E8A3C0", Slot = "4")]
	protected override Vector3 LEODDAJDOCI(Vector3 HFIDNJCGLJB, Vector3 MGPFNHKFBHO, float GLMCDBEDNLG)
	{
		return default(Vector3);
	}

	[Cpp2IlInjected.Token(Token = "0x6000077")]
	[Cpp2IlInjected.Address(RVA = "0x69A5A50", Offset = "0x69A4650", VA = "0x1869A5A50")]
	public Vector3ValueCurve()
	{
	}
}
[Serializable]
[Cpp2IlInjected.Token(Token = "0x200001A")]
public class ColorValueCurve : ValueCurve<Color>
{
	[Cpp2IlInjected.Token(Token = "0x6000078")]
	[Cpp2IlInjected.Address(RVA = "0x69A0DC0", Offset = "0x699F9C0", VA = "0x1869A0DC0", Slot = "4")]
	protected override Color LEODDAJDOCI(Color HFIDNJCGLJB, Color MGPFNHKFBHO, float GLMCDBEDNLG)
	{
		return default(Color);
	}

	[Cpp2IlInjected.Token(Token = "0x6000079")]
	[Cpp2IlInjected.Address(RVA = "0x69A0E80", Offset = "0x699FA80", VA = "0x1869A0E80")]
	public ColorValueCurve()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001B")]
public class AJPDNCJMICM : LCGABPHAMBI<string>
{
	[Cpp2IlInjected.Token(Token = "0x600007A")]
	[Cpp2IlInjected.Address(RVA = "0x699F990", Offset = "0x699E590", VA = "0x18699F990")]
	public AJPDNCJMICM(int DFJDDCJIBIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007B")]
	[Cpp2IlInjected.Address(RVA = "0x699F920", Offset = "0x699E520", VA = "0x18699F920", Slot = "6")]
	protected override uint EGHKKKAJNIF(uint FJHEHEDBGNJ, string IIPLJLPCLBC)
	{
		return default(uint);
	}
}
[Cpp2IlInjected.Token(Token = "0x200001C")]
public class EKDNDEKHNMO : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x400002E")]
	public static readonly IDisposable NKKNEDDGFMP;

	[Cpp2IlInjected.Token(Token = "0x600007C")]
	[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600007D")]
	[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
	public EKDNDEKHNMO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001D")]
public struct CNHJFMCKLOO<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400002F")]
	private readonly Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> OIJAIMNLBFN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000030")]
	private int AFDFFLHGNLO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000031")]
	private int BODDNIBGDPH;

	[Cpp2IlInjected.Token(Token = "0x600007F")]
	[Cpp2IlInjected.Address(RVA = "0x44CD230", Offset = "0x44CBE30", VA = "0x1844CD230")]
	private CNHJFMCKLOO(Dictionary<(int ActorId, int RequestId), TaskCompletionSource<T>> GAAGCAKCPAI, int OADLOMFCCMN, int MBDHAMANMBF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000080")]
	[Cpp2IlInjected.Address(RVA = "0x56B00F0", Offset = "0x56AECF0", VA = "0x1856B00F0")]
	public static CNHJFMCKLOO<T> FCDPFGJNKNI()
	{
		return default(CNHJFMCKLOO<T>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000081")]
	[Cpp2IlInjected.Address(RVA = "0x56AF1B0", Offset = "0x56ADDB0", VA = "0x1856AF1B0")]
	public (int, int, Task<T>) BLMGMDKAFLI(int KNHDHKABHEK, [Optional] CancellationToken PPKBAEMFIMG, double JACNKEDDJOJ = 60.0)
	{
		return default((int, int, Task<T>));
	}

	[Cpp2IlInjected.Token(Token = "0x6000082")]
	[Cpp2IlInjected.Address(RVA = "0x56AFD00", Offset = "0x56AE900", VA = "0x1856AFD00")]
	public void CCAHNNCMLMC(int KNHDHKABHEK, int MBDHAMANMBF, [In] T KKIOBLFFGJH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001E")]
public static class PHLLPHGPEHE
{
	[Cpp2IlInjected.Token(Token = "0x6000083")]
	[Cpp2IlInjected.Address(RVA = "0x69A3840", Offset = "0x69A2440", VA = "0x1869A3840")]
	public static CNHJFMCKLOO<HGAAMJINHPI> FCDPFGJNKNI()
	{
		return default(CNHJFMCKLOO<HGAAMJINHPI>);
	}

	[Cpp2IlInjected.Token(Token = "0x6000084")]
	[Cpp2IlInjected.Address(RVA = "0x69A37C0", Offset = "0x69A23C0", VA = "0x1869A37C0")]
	public static void CCAHNNCMLMC([In] this CNHJFMCKLOO<HGAAMJINHPI> ENEDBNLKLJL, int KNHDHKABHEK, int MBDHAMANMBF)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200001F")]
[DefaultMember("Item")]
public class FMJOKBECEHL<TKey, TVal> : IDictionary<TKey, TVal>, ICollection<KeyValuePair<TKey, TVal>>, IEnumerable<KeyValuePair<TKey, TVal>>, IEnumerable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000032")]
	private readonly Dictionary<TKey, TVal> LDFAGINEKLK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000033")]
	private readonly Dictionary<TVal, TKey> EJHOGDJACCG;

	[Cpp2IlInjected.Token(Token = "0x17000018")]
	public int NAAONAFFINP
	{
		[Cpp2IlInjected.Token(Token = "0x6000085")]
		[Cpp2IlInjected.Address(RVA = "0x358E2D0", Offset = "0x358CED0", VA = "0x18358E2D0", Slot = "12")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000019")]
	public bool JGMKIDPCBFO
	{
		[Cpp2IlInjected.Token(Token = "0x6000086")]
		[Cpp2IlInjected.Address(RVA = "0x8AE100", Offset = "0x8ACD00", VA = "0x1808AE100", Slot = "13")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001A")]
	public ICollection<TKey> MKLNDMFLBIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000089")]
		[Cpp2IlInjected.Address(RVA = "0x3856E30", Offset = "0x3855A30", VA = "0x183856E30", Slot = "6")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001B")]
	public ICollection<TVal> EGGKJPHIHKK
	{
		[Cpp2IlInjected.Token(Token = "0x600008A")]
		[Cpp2IlInjected.Address(RVA = "0x3C32C70", Offset = "0x3C31870", VA = "0x183C32C70", Slot = "7")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001C")]
	public TVal PJODKJCBOKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000094")]
		[Cpp2IlInjected.Address(RVA = "0x3C32C00", Offset = "0x3C31800", VA = "0x183C32C00", Slot = "4")]
		get
		{
			return (TVal)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000095")]
		[Cpp2IlInjected.Address(RVA = "0x3C32CD0", Offset = "0x3C318D0", VA = "0x183C32CD0", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001D")]
	public TKey PJODKJCBOKO
	{
		[Cpp2IlInjected.Token(Token = "0x6000097")]
		[Cpp2IlInjected.Address(RVA = "0x3C32770", Offset = "0x3C31370", VA = "0x183C32770")]
		get
		{
			return (TKey)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000087")]
	[Cpp2IlInjected.Address(RVA = "0x3C32550", Offset = "0x3C31150", VA = "0x183C32550", Slot = "15")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000088")]
	[Cpp2IlInjected.Address(RVA = "0x3C329B0", Offset = "0x3C315B0", VA = "0x183C329B0", Slot = "20")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600008B")]
	[Cpp2IlInjected.Address(RVA = "0x3C322D0", Offset = "0x3C30ED0", VA = "0x183C322D0", Slot = "9")]
	public void Add(TKey NCMHANGAILD, TVal IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008C")]
	[Cpp2IlInjected.Address(RVA = "0x3C32280", Offset = "0x3C30E80", VA = "0x183C32280", Slot = "14")]
	public void Add(KeyValuePair<TKey, TVal> NLEFMACAEAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600008D")]
	[Cpp2IlInjected.Address(RVA = "0x385BA60", Offset = "0x385A660", VA = "0x18385BA60", Slot = "8")]
	public bool ContainsKey(TKey NCMHANGAILD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008E")]
	[Cpp2IlInjected.Address(RVA = "0x3C32600", Offset = "0x3C31200", VA = "0x183C32600", Slot = "16")]
	public bool Contains(KeyValuePair<TKey, TVal> NLEFMACAEAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600008F")]
	[Cpp2IlInjected.Address(RVA = "0x3C32930", Offset = "0x3C31530", VA = "0x183C32930", Slot = "10")]
	public bool Remove(TKey NCMHANGAILD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000090")]
	[Cpp2IlInjected.Address(RVA = "0x3C32970", Offset = "0x3C31570", VA = "0x183C32970", Slot = "18")]
	public bool Remove(KeyValuePair<TKey, TVal> NLEFMACAEAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000091")]
	[Cpp2IlInjected.Address(RVA = "0x3C32A70", Offset = "0x3C31670", VA = "0x183C32A70", Slot = "11")]
	public bool TryGetValue(TKey NCMHANGAILD, [Out] TVal IIPLJLPCLBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000092")]
	[Cpp2IlInjected.Address(RVA = "0x3C326D0", Offset = "0x3C312D0", VA = "0x183C326D0", Slot = "19")]
	public IEnumerator<KeyValuePair<TKey, TVal>> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000093")]
	[Cpp2IlInjected.Address(RVA = "0x3C32640", Offset = "0x3C31240", VA = "0x183C32640", Slot = "17")]
	public void CopyTo(KeyValuePair<TKey, TVal>[] DKCMKELIAPN, int ELEIFPFNELG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000096")]
	[Cpp2IlInjected.Address(RVA = "0x3C328D0", Offset = "0x3C314D0", VA = "0x183C328D0")]
	public bool PNDEAMPCPGC(TVal NCMHANGAILD, [Out] TKey IIPLJLPCLBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000098")]
	[Cpp2IlInjected.Address(RVA = "0x3C32450", Offset = "0x3C31050", VA = "0x183C32450")]
	private void CNJCKCALJII(TKey NCMHANGAILD, TVal BMEHNBDMOJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000099")]
	[Cpp2IlInjected.Address(RVA = "0x3C327D0", Offset = "0x3C313D0", VA = "0x183C327D0")]
	private void OKNIDAOEKPK(TKey NCMHANGAILD, TVal BMEHNBDMOJG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600009A")]
	[Cpp2IlInjected.Address(RVA = "0x3C32320", Offset = "0x3C30F20", VA = "0x183C32320")]
	private bool CCJMGMLBIJD(TKey NCMHANGAILD)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600009B")]
	[Cpp2IlInjected.Address(RVA = "0x3C32AD0", Offset = "0x3C316D0", VA = "0x183C32AD0")]
	public FMJOKBECEHL()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000020")]
[DefaultMember("Item")]
public class JCMGHEDKBCO<T> : IEnumerable<T>, IEnumerable
{
	[Serializable]
	[Cpp2IlInjected.Token(Token = "0x2000021")]
	public struct Enumerator : IEnumerator<T>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000038")]
		private JCMGHEDKBCO<T> buffer;

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
			[Cpp2IlInjected.Address(RVA = "0x38AB610", Offset = "0x38AA210", VA = "0x1838AB610", Slot = "4")]
			get
			{
				return (T)null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000021")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000AD")]
			[Cpp2IlInjected.Address(RVA = "0x38B8D80", Offset = "0x38B7980", VA = "0x1838B8D80", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000AA")]
		[Cpp2IlInjected.Address(RVA = "0x38BA5B0", Offset = "0x38B91B0", VA = "0x1838BA5B0")]
		public Enumerator(JCMGHEDKBCO<T> EBPAODHLEDO)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AB")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "5")]
		public void Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AC")]
		[Cpp2IlInjected.Address(RVA = "0x38B79B0", Offset = "0x38B65B0", VA = "0x1838B79B0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000AE")]
		[Cpp2IlInjected.Address(RVA = "0x38B84B0", Offset = "0x38B70B0", VA = "0x1838B84B0", Slot = "8")]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000AF")]
		[Cpp2IlInjected.Address(RVA = "0x38B6FA0", Offset = "0x38B5BA0", VA = "0x1838B6FA0")]
		private void GAFODHODKHB()
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000034")]
	private T[] MMKCOHHNKMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000035")]
	private int IPBPNCHALEF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000036")]
	private int HCLLLBPFFBO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000037")]
	private int FAEMFOKJHDK;

	[Cpp2IlInjected.Token(Token = "0x1700001E")]
	public int NAAONAFFINP
	{
		[Cpp2IlInjected.Token(Token = "0x600009C")]
		[Cpp2IlInjected.Address(RVA = "0x407E730", Offset = "0x407D330", VA = "0x18407E730")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700001F")]
	public T PJODKJCBOKO
	{
		[Cpp2IlInjected.Token(Token = "0x600009D")]
		[Cpp2IlInjected.Address(RVA = "0x407F450", Offset = "0x407E050", VA = "0x18407F450")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x600009E")]
		[Cpp2IlInjected.Address(RVA = "0x407F0A0", Offset = "0x407DCA0", VA = "0x18407F0A0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600009F")]
	[Cpp2IlInjected.Address(RVA = "0x4080120", Offset = "0x407ED20", VA = "0x184080120")]
	public JCMGHEDKBCO(int DFJDDCJIBIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A0")]
	[Cpp2IlInjected.Address(RVA = "0x407F8D0", Offset = "0x407E4D0", VA = "0x18407F8D0")]
	public void LKPJOLMECIF(T GLMCDBEDNLG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A1")]
	[Cpp2IlInjected.Address(RVA = "0x407DE10", Offset = "0x407CA10", VA = "0x18407DE10")]
	public void AFPCPCPKMJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A2")]
	[Cpp2IlInjected.Address(RVA = "0x407FD20", Offset = "0x407E920", VA = "0x18407FD20")]
	public void OAIEKEDHLKB(int LLHINFJPPOH)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A3")]
	[Cpp2IlInjected.Address(RVA = "0x407DE30", Offset = "0x407CA30", VA = "0x18407DE30")]
	public void APBAMFDBHOK(T[] DKCMKELIAPN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000A4")]
	[Cpp2IlInjected.Address(RVA = "0x407E7F0", Offset = "0x407D3F0", VA = "0x18407E7F0")]
	public Enumerator DHNABIACCII()
	{
		return default(Enumerator);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A5")]
	[Cpp2IlInjected.Address(RVA = "0x407FF60", Offset = "0x407EB60", VA = "0x18407FF60", Slot = "4")]
	IEnumerator<T> IEnumerable<T>.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A6")]
	[Cpp2IlInjected.Address(RVA = "0x407FF60", Offset = "0x407EB60", VA = "0x18407FF60", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000A7")]
	[Cpp2IlInjected.Address(RVA = "0x407E9E0", Offset = "0x407D5E0", VA = "0x18407E9E0")]
	private int EFEBLHIJEFJ(int BAEBMIBABAE)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000A8")]
	[Cpp2IlInjected.Address(RVA = "0x407FE00", Offset = "0x407EA00", VA = "0x18407FE00")]
	private int PPEEGFNHPHP(int BAEBMIBABAE)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000022")]
public class DDNFDBHENGF<TRequest, TResult> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x2000023")]
	public delegate Task<TResult> FIJDHMKLNDF(TRequest KAIGMLIOMBJ, CancellationToken PPKBAEMFIMG);

	[Cpp2IlInjected.Token(Token = "0x2000024")]
	public enum FLNFDEJJOKO
	{
		[Cpp2IlInjected.Token(Token = "0x4000043")]
		FirstInFirstOut,
		[Cpp2IlInjected.Token(Token = "0x4000044")]
		LastInFirstOut
	}

	[Cpp2IlInjected.Token(Token = "0x2000025")]
	public class PGNHAAELAGC
	{
		[Cpp2IlInjected.Token(Token = "0x4000045")]
		private const float GHBAGHAEIAD = 60f;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000046")]
		private TimeSpan MDNAKENGIMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000047")]
		public int GFNAHKPLEAJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000048")]
		public FLNFDEJJOKO MDIGOODIBBI;

		[Cpp2IlInjected.Token(Token = "0x4000049")]
		public static readonly PGNHAAELAGC APEJJIEJKNM;

		[Cpp2IlInjected.Token(Token = "0x17000022")]
		public float FJABMOBPBKJ
		{
			[Cpp2IlInjected.Token(Token = "0x60000BA")]
			[Cpp2IlInjected.Address(RVA = "0x478E2F0", Offset = "0x478CEF0", VA = "0x18478E2F0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000023")]
		public TimeSpan HEPMIIHPDNP
		{
			[Cpp2IlInjected.Token(Token = "0x60000BB")]
			[Cpp2IlInjected.Address(RVA = "0x867D10", Offset = "0x866910", VA = "0x180867D10")]
			get
			{
				return default(TimeSpan);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000BC")]
		[Cpp2IlInjected.Address(RVA = "0x478E4B0", Offset = "0x478D0B0", VA = "0x18478E4B0")]
		public PGNHAAELAGC()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000026")]
	private readonly struct CHGOGDGEMHI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004A")]
		public readonly TRequest KAIGMLIOMBJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004B")]
		public readonly CancellationToken PPKBAEMFIMG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004C")]
		public readonly TaskCompletionSource<TResult> PCLIDHDNAND;

		[Cpp2IlInjected.Token(Token = "0x60000BE")]
		[Cpp2IlInjected.Address(RVA = "0x5588580", Offset = "0x5587180", VA = "0x185588580")]
		public CHGOGDGEMHI(TRequest KAIGMLIOMBJ, TaskCompletionSource<TResult> PCLIDHDNAND, CancellationToken PPKBAEMFIMG)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000027")]
	[CompilerGenerated]
	private struct POPMOEBCCGJ : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004D")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004E")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400004F")]
		public DDNFDBHENGF<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000050")]
		private TaskAwaiter <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000BF")]
		[Cpp2IlInjected.Address(RVA = "0x47ACEC0", Offset = "0x47ABAC0", VA = "0x1847ACEC0", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C0")]
		[Cpp2IlInjected.Address(RVA = "0x47AD7A0", Offset = "0x47AC3A0", VA = "0x1847AD7A0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000028")]
	[CompilerGenerated]
	private struct DHPJNCGLPGG : IAsyncStateMachine
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000051")]
		public int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000052")]
		public AsyncTaskMethodBuilder <>t__builder;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000053")]
		public DDNFDBHENGF<TRequest, TResult> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000054")]
		private CHGOGDGEMHI <req>5__2;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000055")]
		private TaskAwaiter<TResult> <>u__1;

		[Cpp2IlInjected.Token(Token = "0x60000C1")]
		[Cpp2IlInjected.Address(RVA = "0x58A5550", Offset = "0x58A4150", VA = "0x1858A5550", Slot = "4")]
		private void MoveNext()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000C2")]
		[Cpp2IlInjected.Address(RVA = "0x58A5BB0", Offset = "0x58A47B0", VA = "0x1858A5BB0", Slot = "5")]
		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003C")]
	private readonly CancellationTokenSource OHFNHCBJMHN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003D")]
	private readonly List<CHGOGDGEMHI> AEOCKIPADIN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003E")]
	private readonly PGNHAAELAGC NDBJPAIHOIC;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400003F")]
	private readonly FIJDHMKLNDF AIBJPEGEDLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000040")]
	private Task GLONOJGLGAP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000041")]
	private int PGOMMOPHFMO;

	[Cpp2IlInjected.Token(Token = "0x60000B0")]
	[Cpp2IlInjected.Address(RVA = "0x588CF80", Offset = "0x588BB80", VA = "0x18588CF80")]
	public DDNFDBHENGF(FIJDHMKLNDF AIBJPEGEDLB, [Optional] PGNHAAELAGC NDBJPAIHOIC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B1")]
	[Cpp2IlInjected.Address(RVA = "0x588B5B0", Offset = "0x588A1B0", VA = "0x18588B5B0")]
	public Task<TResult> BLHPKGPBOEM(TRequest KAIGMLIOMBJ, CancellationToken PPKBAEMFIMG)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B2")]
	[Cpp2IlInjected.Address(RVA = "0x588CAA0", Offset = "0x588B6A0", VA = "0x18588CAA0")]
	private void OPFABIFHBHK(CHGOGDGEMHI ILFONJDFLPF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B3")]
	[Cpp2IlInjected.Address(RVA = "0x588B990", Offset = "0x588A590", VA = "0x18588B990")]
	[AsyncStateMachine(typeof(DDNFDBHENGF<, >.POPMOEBCCGJ))]
	private Task BMBFGEBPFML()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B4")]
	[Cpp2IlInjected.Address(RVA = "0x588BD90", Offset = "0x588A990", VA = "0x18588BD90")]
	private CHGOGDGEMHI FMAFPHJCLHK()
	{
		return default(CHGOGDGEMHI);
	}

	[Cpp2IlInjected.Token(Token = "0x60000B5")]
	[Cpp2IlInjected.Address(RVA = "0x588C6D0", Offset = "0x588B2D0", VA = "0x18588C6D0")]
	[AsyncStateMachine(typeof(DDNFDBHENGF<, >.DHPJNCGLPGG))]
	private Task NJBMGHHOAKN()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000B6")]
	[Cpp2IlInjected.Address(RVA = "0x588C4B0", Offset = "0x588B0B0", VA = "0x18588C4B0")]
	private void JIPFLOKJJHB()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000B7")]
	[Cpp2IlInjected.Address(RVA = "0x588BA60", Offset = "0x588A660", VA = "0x18588BA60", Slot = "4")]
	public void Dispose()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000029")]
[DefaultMember("Item")]
public class GNPIJDDOKAN<T> : IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable, IReadOnlyList<T>, IReadOnlyCollection<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000056")]
	private readonly List<T> ELBBNOKMNCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000057")]
	private HashSet<T> APHEJDHCBAG;

	[Cpp2IlInjected.Token(Token = "0x17000024")]
	public int NAAONAFFINP
	{
		[Cpp2IlInjected.Token(Token = "0x60000C3")]
		[Cpp2IlInjected.Address(RVA = "0x358E2D0", Offset = "0x358CED0", VA = "0x18358E2D0", Slot = "19")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000025")]
	public bool JGMKIDPCBFO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C4")]
		[Cpp2IlInjected.Address(RVA = "0x8AE100", Offset = "0x8ACD00", VA = "0x1808AE100", Slot = "10")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000026")]
	public T PJODKJCBOKO
	{
		[Cpp2IlInjected.Token(Token = "0x60000C5")]
		[Cpp2IlInjected.Address(RVA = "0x2A75530", Offset = "0x2A74130", VA = "0x182A75530", Slot = "18")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000C6")]
		[Cpp2IlInjected.Address(RVA = "0x3D7E530", Offset = "0x3D7D130", VA = "0x183D7E530", Slot = "5")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000C7")]
	[Cpp2IlInjected.Address(RVA = "0x3CBCF30", Offset = "0x3CBBB30", VA = "0x183CBCF30", Slot = "11")]
	public void Add(T NLEFMACAEAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000C8")]
	[Cpp2IlInjected.Address(RVA = "0x3D7D730", Offset = "0x3D7C330", VA = "0x183D7D730")]
	public bool AJIDDEEMNPB(T NLEFMACAEAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000C9")]
	[Cpp2IlInjected.Address(RVA = "0x3D7E1E0", Offset = "0x3D7CDE0", VA = "0x183D7E1E0", Slot = "15")]
	public bool Remove(T NLEFMACAEAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CA")]
	[Cpp2IlInjected.Address(RVA = "0x3D7DAC0", Offset = "0x3D7C6C0", VA = "0x183D7DAC0", Slot = "16")]
	public IEnumerator<T> GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CB")]
	[Cpp2IlInjected.Address(RVA = "0x3BDE040", Offset = "0x3BDCC40", VA = "0x183BDE040", Slot = "17")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000CC")]
	[Cpp2IlInjected.Address(RVA = "0x3D7D950", Offset = "0x3D7C550", VA = "0x183D7D950", Slot = "12")]
	public void Clear()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CD")]
	[Cpp2IlInjected.Address(RVA = "0x3D7DA00", Offset = "0x3D7C600", VA = "0x183D7DA00", Slot = "13")]
	public bool Contains(T NLEFMACAEAP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60000CE")]
	[Cpp2IlInjected.Address(RVA = "0x3D7DA60", Offset = "0x3D7C660", VA = "0x183D7DA60", Slot = "14")]
	public void CopyTo(T[] DKCMKELIAPN, int ELEIFPFNELG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000CF")]
	[Cpp2IlInjected.Address(RVA = "0x3D7DB50", Offset = "0x3D7C750", VA = "0x183D7DB50", Slot = "6")]
	public int IndexOf(T NLEFMACAEAP)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60000D0")]
	[Cpp2IlInjected.Address(RVA = "0x3D7DBB0", Offset = "0x3D7C7B0", VA = "0x183D7DBB0", Slot = "7")]
	public void Insert(int BAEBMIBABAE, T NLEFMACAEAP)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D1")]
	[Cpp2IlInjected.Address(RVA = "0x3D7DFB0", Offset = "0x3D7CBB0", VA = "0x183D7DFB0", Slot = "8")]
	public void RemoveAt(int BAEBMIBABAE)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000D2")]
	[Cpp2IlInjected.Address(RVA = "0x3D7E2B0", Offset = "0x3D7CEB0", VA = "0x183D7E2B0")]
	public GNPIJDDOKAN()
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
			[Cpp2IlInjected.Address(RVA = "0x21B9A00", Offset = "0x21B8600", VA = "0x1821B9A00")]
			get
			{
				return default(Guid);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000D4")]
		[Cpp2IlInjected.Address(RVA = "0x69A4FE0", Offset = "0x69A3BE0", VA = "0x1869A4FE0")]
		public SerializedGuid([In] Guid GBCIBJHFOHP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D5")]
		[Cpp2IlInjected.Address(RVA = "0x69A4E40", Offset = "0x69A3A40", VA = "0x1869A4E40")]
		public static SerializedGuid GJGLMCGNGCG()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D6")]
		[Cpp2IlInjected.Address(RVA = "0x69A4DD0", Offset = "0x69A39D0", VA = "0x1869A4DD0")]
		public static SerializedGuid FPLGEFNOCAP()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000D7")]
		[Cpp2IlInjected.Address(RVA = "0x69A4ED0", Offset = "0x69A3AD0", VA = "0x1869A4ED0")]
		public bool IEKHLJNNNBD()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000D8")]
		[Cpp2IlInjected.Address(RVA = "0x69A4FB0", Offset = "0x69A3BB0", VA = "0x1869A4FB0", Slot = "4")]
		public void OnBeforeSerialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000D9")]
		[Cpp2IlInjected.Address(RVA = "0x69A4F30", Offset = "0x69A3B30", VA = "0x1869A4F30", Slot = "5")]
		public void OnAfterDeserialize()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000DA")]
		[Cpp2IlInjected.Address(RVA = "0x69A4D00", Offset = "0x69A3900", VA = "0x1869A4D00", Slot = "7")]
		public bool Equals(SerializedGuid HEIGABGMPLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DB")]
		[Cpp2IlInjected.Address(RVA = "0x69A4D40", Offset = "0x69A3940", VA = "0x1869A4D40", Slot = "0")]
		public override bool Equals(object APKAFMDACKK)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DC")]
		[Cpp2IlInjected.Address(RVA = "0x69A4EC0", Offset = "0x69A3AC0", VA = "0x1869A4EC0", Slot = "2")]
		public override int GetHashCode()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000DD")]
		[Cpp2IlInjected.Address(RVA = "0x69A4CD0", Offset = "0x69A38D0", VA = "0x1869A4CD0", Slot = "6")]
		public int CompareTo(SerializedGuid HEIGABGMPLJ)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200002B")]
public class EKOLPAOCEIB : PropertyAttribute
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
	[Cpp2IlInjected.Token(Token = "0x400005A")]
	public readonly Type IFEIBDFFOFK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x400005B")]
	public readonly string OMBGADJBGHK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
	[Cpp2IlInjected.Token(Token = "0x400005C")]
	public readonly bool NIJJCBMPENO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x29")]
	[Cpp2IlInjected.Token(Token = "0x400005D")]
	public readonly bool DJIHHIDKOHP;

	[Cpp2IlInjected.Token(Token = "0x60000DE")]
	[Cpp2IlInjected.Address(RVA = "0x69A2A20", Offset = "0x69A1620", VA = "0x1869A2A20")]
	public EKOLPAOCEIB(Type MCKOKMBBNFA, string LAKMLIBGLFN, bool CDDAAOEDBIE = false, bool LLOHMLLFPCH = false)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200002C")]
public class BILFBGGHINK<TKey> : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x200002D")]
	public readonly struct CJHJGLCOGMJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000068")]
		public readonly long LONFDNCEAOP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000069")]
		public readonly long IAHCOLPDMGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006A")]
		public readonly int BBFDNADOKHF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006B")]
		public readonly int OLDLEDJLBAK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006C")]
		public readonly bool JKMMCIGAEEL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006D")]
		private readonly string CKDBAIEDEIF;

		[Cpp2IlInjected.Token(Token = "0x60000E7")]
		[Cpp2IlInjected.Address(RVA = "0x5674A30", Offset = "0x5673630", VA = "0x185674A30")]
		public CJHJGLCOGMJ(long LONFDNCEAOP, int BBFDNADOKHF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E8")]
		[Cpp2IlInjected.Address(RVA = "0x5674A00", Offset = "0x5673600", VA = "0x185674A00")]
		public CJHJGLCOGMJ(long LONFDNCEAOP, long IAHCOLPDMGB, int BBFDNADOKHF, int OLDLEDJLBAK, bool JKMMCIGAEEL, string CKDBAIEDEIF)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000E9")]
		[Cpp2IlInjected.Address(RVA = "0x56749B0", Offset = "0x56735B0", VA = "0x1856749B0")]
		public int LBMIGOHHHGH()
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EA")]
		[Cpp2IlInjected.Address(RVA = "0x56748F0", Offset = "0x56734F0", VA = "0x1856748F0")]
		public int HBAOHBJAMKE(int IOIPGHACBJF)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EB")]
		[Cpp2IlInjected.Address(RVA = "0x5674890", Offset = "0x5673490", VA = "0x185674890")]
		public double EFBBFILFMCK()
		{
			return default(double);
		}

		[Cpp2IlInjected.Token(Token = "0x60000EC")]
		[Cpp2IlInjected.Address(RVA = "0x5674910", Offset = "0x5673510", VA = "0x185674910")]
		public CJHJGLCOGMJ IKJLPFNFBCP(long IAHCOLPDMGB, int OLDLEDJLBAK)
		{
			return default(CJHJGLCOGMJ);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200002E")]
	public class OADHIEPGLKH : IDisposable
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x200002F")]
		[CompilerGenerated]
		private struct HDJABMAALOK<T> : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000073")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000074")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000075")]
			public OADHIEPGLKH <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000076")]
			public TKey key;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000077")]
			public Func<OADHIEPGLKH, Task<T>> function;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000078")]
			private OADHIEPGLKH <internalTimer>5__2;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000079")]
			private TaskAwaiter<T> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x60000F5")]
			[Cpp2IlInjected.Address(RVA = "0x3DB4510", Offset = "0x3DB3110", VA = "0x183DB4510", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x60000F6")]
			[Cpp2IlInjected.Address(RVA = "0x3DB4A60", Offset = "0x3DB3660", VA = "0x183DB4A60", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006E")]
		public readonly TKey KNLKLIOEEBP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400006F")]
		private readonly BILFBGGHINK<TKey> IFGCIHPEHMO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000070")]
		public readonly EEGEMFOKJOP IGMINGONOGN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000071")]
		private List<OADHIEPGLKH> MIGAKNFIBFH;

		[Cpp2IlInjected.Token(Token = "0x1700002A")]
		public string ODPBLINBEPC
		{
			[Cpp2IlInjected.Token(Token = "0x60000ED")]
			[Cpp2IlInjected.Address(RVA = "0x4538A90", Offset = "0x4537690", VA = "0x184538A90")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002B")]
		public IEnumerable<OADHIEPGLKH> ICKCFCDEAAK
		{
			[Cpp2IlInjected.Token(Token = "0x60000EE")]
			[Cpp2IlInjected.Address(RVA = "0x460A410", Offset = "0x4609010", VA = "0x18460A410")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002C")]
		public CJHJGLCOGMJ GOFBAFBDMIC
		{
			[Cpp2IlInjected.Token(Token = "0x60000EF")]
			[Cpp2IlInjected.Address(RVA = "0x460A3C0", Offset = "0x4608FC0", VA = "0x18460A3C0")]
			[CompilerGenerated]
			get
			{
				return default(CJHJGLCOGMJ);
			}
			[Cpp2IlInjected.Token(Token = "0x60000F0")]
			[Cpp2IlInjected.Address(RVA = "0x460A3E0", Offset = "0x4608FE0", VA = "0x18460A3E0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F1")]
		[Cpp2IlInjected.Address(RVA = "0x460A870", Offset = "0x4609470", VA = "0x18460A870")]
		internal OADHIEPGLKH(BILFBGGHINK<TKey> IFGCIHPEHMO, TKey NCMHANGAILD, EEGEMFOKJOP IGMINGONOGN)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F2")]
		[Cpp2IlInjected.Address(RVA = "0x460A450", Offset = "0x4609050", VA = "0x18460A450")]
		public OADHIEPGLKH DCAIPKHOELM(TKey NCMHANGAILD, [Optional] EEGEMFOKJOP? CPLLIOBAPMC)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F3")]
		[Cpp2IlInjected.Address(RVA = "0x2BD69E0", Offset = "0x2BD55E0", VA = "0x182BD69E0")]
		[AsyncStateMachine(typeof(HDJABMAALOK<>))]
		public Task<T> FHEAEDOLKJH<T>(TKey NCMHANGAILD, Func<OADHIEPGLKH, Task<T>> FKJLAAGOMNG)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000F4")]
		[Cpp2IlInjected.Address(RVA = "0x460A610", Offset = "0x4609210", VA = "0x18460A610", Slot = "4")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000030")]
	[CompilerGenerated]
	private sealed class ONGHEHKMFGM : IEnumerable<(TKey, List<TKey>, CJHJGLCOGMJ)>, IEnumerable, IEnumerator<(TKey, List<TKey>, CJHJGLCOGMJ)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007A")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007B")]
		private (TKey key, List<TKey> path, CJHJGLCOGMJ timerEntry) <>2__current;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007C")]
		private int <>l__initialThreadId;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007D")]
		public BILFBGGHINK<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007E")]
		private IEnumerator<(TKey key, List<TKey> path, CJHJGLCOGMJ timerEntry)> <>7__wrap1;

		[Cpp2IlInjected.Token(Token = "0x1700002D")]
		private (TKey, List<TKey>, CJHJGLCOGMJ) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FB")]
			[Cpp2IlInjected.Address(RVA = "0x21B4E20", Offset = "0x21B3A20", VA = "0x1821B4E20", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, CJHJGLCOGMJ));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700002E")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60000FD")]
			[Cpp2IlInjected.Address(RVA = "0x46C32A0", Offset = "0x46C1EA0", VA = "0x1846C32A0", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60000F7")]
		[Cpp2IlInjected.Address(RVA = "0x21B4F10", Offset = "0x21B3B10", VA = "0x1821B4F10")]
		[DebuggerHidden]
		public ONGHEHKMFGM(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F8")]
		[Cpp2IlInjected.Address(RVA = "0x3945890", Offset = "0x3944490", VA = "0x183945890", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000F9")]
		[Cpp2IlInjected.Address(RVA = "0x46C2D70", Offset = "0x46C1970", VA = "0x1846C2D70", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60000FA")]
		[Cpp2IlInjected.Address(RVA = "0x46C3120", Offset = "0x46C1D20", VA = "0x1846C3120")]
		private void OPGOEIKMBCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FC")]
		[Cpp2IlInjected.Address(RVA = "0x46C3250", Offset = "0x46C1E50", VA = "0x1846C3250", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60000FE")]
		[Cpp2IlInjected.Address(RVA = "0x46C3170", Offset = "0x46C1D70", VA = "0x1846C3170", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, CJHJGLCOGMJ)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60000FF")]
		[Cpp2IlInjected.Address(RVA = "0x3AA04F0", Offset = "0x3A9F0F0", VA = "0x183AA04F0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000031")]
	[CompilerGenerated]
	private sealed class PCFFINOOMFC : IEnumerable<(TKey, List<TKey>, CJHJGLCOGMJ)>, IEnumerable, IEnumerator<(TKey, List<TKey>, CJHJGLCOGMJ)>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400007F")]
		private int <>1__state;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000080")]
		private (TKey key, List<TKey> path, CJHJGLCOGMJ timerEntry) <>2__current;

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
		private OADHIEPGLKH timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000085")]
		public OADHIEPGLKH <>3__timerScope;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000086")]
		public BILFBGGHINK<TKey> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000087")]
		private IEnumerator<OADHIEPGLKH> <>7__wrap1;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000088")]
		private IEnumerator<(TKey key, List<TKey> path, CJHJGLCOGMJ timerEntry)> <>7__wrap2;

		[Cpp2IlInjected.Token(Token = "0x1700002F")]
		private (TKey, List<TKey>, CJHJGLCOGMJ) System.Collections.Generic.IEnumerator<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000105")]
			[Cpp2IlInjected.Address(RVA = "0x21B4E20", Offset = "0x21B3A20", VA = "0x1821B4E20", Slot = "6")]
			[DebuggerHidden]
			get
			{
				return default((TKey, List<TKey>, CJHJGLCOGMJ));
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000030")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x6000107")]
			[Cpp2IlInjected.Address(RVA = "0x4759440", Offset = "0x4758040", VA = "0x184759440", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000100")]
		[Cpp2IlInjected.Address(RVA = "0x21B4F10", Offset = "0x21B3B10", VA = "0x1821B4F10")]
		[DebuggerHidden]
		public PCFFINOOMFC(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000101")]
		[Cpp2IlInjected.Address(RVA = "0x47594A0", Offset = "0x47580A0", VA = "0x1847594A0", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000102")]
		[Cpp2IlInjected.Address(RVA = "0x4758A70", Offset = "0x4757670", VA = "0x184758A70", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000103")]
		[Cpp2IlInjected.Address(RVA = "0x4759250", Offset = "0x4757E50", VA = "0x184759250")]
		private void OPGOEIKMBCE()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000104")]
		[Cpp2IlInjected.Address(RVA = "0x4758A10", Offset = "0x4757610", VA = "0x184758A10")]
		private void JMPEPBOJIAB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000106")]
		[Cpp2IlInjected.Address(RVA = "0x47593F0", Offset = "0x4757FF0", VA = "0x1847593F0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000108")]
		[Cpp2IlInjected.Address(RVA = "0x47592B0", Offset = "0x4757EB0", VA = "0x1847592B0", Slot = "4")]
		[DebuggerHidden]
		private IEnumerator<(TKey, List<TKey>, CJHJGLCOGMJ)> System.Collections.Generic.IEnumerable<(TKeykey,System.Collections.Generic.List<TKey>path,RecRoom.DataStructures.Times.StackTimer<TKey>.TimerEntrytimerEntry)>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000109")]
		[Cpp2IlInjected.Address(RVA = "0x47593B0", Offset = "0x4757FB0", VA = "0x1847593B0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005E")]
	private readonly Action<TKey, CJHJGLCOGMJ, EEGEMFOKJOP> ADDBOMHMNIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400005F")]
	private readonly Action<TKey, CJHJGLCOGMJ, EEGEMFOKJOP> GPHGCDKALPH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000060")]
	private readonly Action<BILFBGGHINK<TKey>, EEGEMFOKJOP> KMFCBOCDBFJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000061")]
	private readonly EEGEMFOKJOP IGMINGONOGN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000062")]
	private readonly OADHIEPGLKH MANFPBGKBGD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000063")]
	private bool KFHJMPBIANF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000064")]
	private int LIBGPIDHCDP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000065")]
	private readonly Stopwatch KFDMHNJJIHD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000066")]
	public readonly int AOBINHGOOIB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000067")]
	private string CNILKILCKAK;

	[Cpp2IlInjected.Token(Token = "0x17000028")]
	public OADHIEPGLKH HPABDJANBCP
	{
		[Cpp2IlInjected.Token(Token = "0x60000DF")]
		[Cpp2IlInjected.Address(RVA = "0x867CF0", Offset = "0x8668F0", VA = "0x180867CF0")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000029")]
	[NotNull]
	public string ODPBLINBEPC
	{
		[Cpp2IlInjected.Token(Token = "0x60000E0")]
		[Cpp2IlInjected.Address(RVA = "0x86B550", Offset = "0x86A150", VA = "0x18086B550")]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60000E1")]
		[Cpp2IlInjected.Address(RVA = "0x4E7A9C0", Offset = "0x4E795C0", VA = "0x184E7A9C0")]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60000E2")]
	[Cpp2IlInjected.Address(RVA = "0x4E7ABC0", Offset = "0x4E797C0", VA = "0x184E7ABC0")]
	public BILFBGGHINK(TKey HPIPPIFKFPJ, EEGEMFOKJOP IGMINGONOGN, [Optional] int? BBFDNADOKHF, [Optional][CanBeNull] Stopwatch KFDMHNJJIHD, [Optional] Action<TKey, CJHJGLCOGMJ, EEGEMFOKJOP> ADDBOMHMNIB, [Optional] Action<TKey, CJHJGLCOGMJ, EEGEMFOKJOP> GPHGCDKALPH, [Optional] Action<BILFBGGHINK<TKey>, EEGEMFOKJOP> KMFCBOCDBFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E3")]
	[Cpp2IlInjected.Address(RVA = "0x4E7A860", Offset = "0x4E79460", VA = "0x184E7A860", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60000E4")]
	[Cpp2IlInjected.Address(RVA = "0x4E7AA20", Offset = "0x4E79620", VA = "0x184E7AA20")]
	[IteratorStateMachine(typeof(BILFBGGHINK<>.ONGHEHKMFGM))]
	public IEnumerable<(TKey, List<TKey>, CJHJGLCOGMJ)> PDCPNELLBJF()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E5")]
	[Cpp2IlInjected.Address(RVA = "0x4E7AAD0", Offset = "0x4E796D0", VA = "0x184E7AAD0")]
	[IteratorStateMachine(typeof(BILFBGGHINK<>.PCFFINOOMFC))]
	private IEnumerable<(TKey, List<TKey>, CJHJGLCOGMJ)> PDCPNELLBJF(List<TKey> BPMIFKHAMKI, OADHIEPGLKH KAKJIMBKOFN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60000E6")]
	[Cpp2IlInjected.Address(RVA = "0x4E7A940", Offset = "0x4E79540", VA = "0x184E7A940")]
	private (long, int) KBNLNKENEGP()
	{
		return default((long, int));
	}
}
[Cpp2IlInjected.Token(Token = "0x2000032")]
public abstract class BONGFKBEFIJ<TKey, TOut>
{
	[Cpp2IlInjected.Token(Token = "0x600010A")]
	[Cpp2IlInjected.Address(Slot = "4")]
	public abstract TOut FNMIJICAHMD(BILFBGGHINK<TKey> IFGCIHPEHMO);

	[Cpp2IlInjected.Token(Token = "0x600010B")]
	[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
	protected BONGFKBEFIJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000033")]
public abstract class DDBGCEDGPIE<TKey> : BONGFKBEFIJ<TKey, string>
{
	[Cpp2IlInjected.Token(Token = "0x2000034")]
	public delegate string DGGOCAMFPCD(TKey NCMHANGAILD);

	[Cpp2IlInjected.Token(Token = "0x600010C")]
	[Cpp2IlInjected.Address(RVA = "0x5880740", Offset = "0x587F340", VA = "0x185880740")]
	private static string CGECILOELOF(TKey NCMHANGAILD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010D")]
	[Cpp2IlInjected.Address(RVA = "0x5880780", Offset = "0x587F380", VA = "0x185880780", Slot = "4")]
	public override string FNMIJICAHMD(BILFBGGHINK<TKey> IFGCIHPEHMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010E")]
	[Cpp2IlInjected.Address(RVA = "0x5880870", Offset = "0x587F470", VA = "0x185880870")]
	public string FNMIJICAHMD(BILFBGGHINK<TKey> IFGCIHPEHMO, [NotNull] DGGOCAMFPCD CFMMJEFKBIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600010F")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract string JLKDLOMIDCD(BILFBGGHINK<TKey> IFGCIHPEHMO, [NotNull] DGGOCAMFPCD CFMMJEFKBIN);

	[Cpp2IlInjected.Token(Token = "0x6000110")]
	[Cpp2IlInjected.Address(RVA = "0x3ED2080", Offset = "0x3ED0C80", VA = "0x183ED2080")]
	protected DDBGCEDGPIE()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000035")]
public class DCFAFODPDOM<TKey> : BONGFKBEFIJ<TKey, Dictionary<string, string>>
{
	[Cpp2IlInjected.Token(Token = "0x2000036")]
	public delegate string EOPCFLELNAF(TKey NCMHANGAILD);

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000089")]
	private readonly string APOHDPBCLBI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008A")]
	private readonly double GHBGCCEBIAJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008B")]
	private readonly bool PKCFIEHDMOF;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008C")]
	private readonly int LMEHIMHALBM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008D")]
	private readonly ISet<string> AKJMPHNFNFL;

	[Cpp2IlInjected.Token(Token = "0x6000113")]
	[Cpp2IlInjected.Address(RVA = "0x587E780", Offset = "0x587D380", VA = "0x18587E780")]
	private static string CGECILOELOF(TKey NCMHANGAILD)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000114")]
	[Cpp2IlInjected.Address(RVA = "0x587F130", Offset = "0x587DD30", VA = "0x18587F130")]
	public DCFAFODPDOM(string APOHDPBCLBI = "F2", double GHBGCCEBIAJ = double.MaxValue, bool PKCFIEHDMOF = false, int LMEHIMHALBM = int.MaxValue, [Optional] ISet<string> AKJMPHNFNFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000115")]
	[Cpp2IlInjected.Address(RVA = "0x587E7C0", Offset = "0x587D3C0", VA = "0x18587E7C0", Slot = "4")]
	public override Dictionary<string, string> FNMIJICAHMD(BILFBGGHINK<TKey> IFGCIHPEHMO)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000116")]
	[Cpp2IlInjected.Address(RVA = "0x587F060", Offset = "0x587DC60", VA = "0x18587F060")]
	private bool PAOPMFEIEKB(string IKKJBOGPALO)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000117")]
	[Cpp2IlInjected.Address(RVA = "0x587E8B0", Offset = "0x587D4B0", VA = "0x18587E8B0")]
	public Dictionary<string, string> FNMIJICAHMD(BILFBGGHINK<TKey> IFGCIHPEHMO, EOPCFLELNAF CFMMJEFKBIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000118")]
	[Cpp2IlInjected.Address(RVA = "0x587E500", Offset = "0x587D100", VA = "0x18587E500")]
	private string BDJABLKBFHG(StringBuilder IJCLOCJHCBI, List<TKey> FKGAIDDDOEK, EOPCFLELNAF CFMMJEFKBIN, bool JLJJCPBCAEE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000119")]
	[Cpp2IlInjected.Address(RVA = "0x587EF00", Offset = "0x587DB00", VA = "0x18587EF00")]
	private static void LNGMLGKAJBF(StringBuilder KAKPFLIHNME, string HIFKAMOFPPL, bool LMBLIFCCOEK)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000037")]
public class FOKHFHPPLMI<TKey> : DDBGCEDGPIE<TKey>
{
	[StructLayout((LayoutKind)3)]
	[Cpp2IlInjected.Token(Token = "0x2000038")]
	[CompilerGenerated]
	private struct HIBDOMKOOCO
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000090")]
		public DGGOCAMFPCD keyToStringFunc;
	}

	[Cpp2IlInjected.Token(Token = "0x400008E")]
	public static FOKHFHPPLMI<TKey> NKKNEDDGFMP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x400008F")]
	private readonly string[] BCKDMLCJCJF;

	[Cpp2IlInjected.Token(Token = "0x600011C")]
	[Cpp2IlInjected.Address(RVA = "0x3C370B0", Offset = "0x3C35CB0", VA = "0x183C370B0")]
	private FOKHFHPPLMI()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600011D")]
	[Cpp2IlInjected.Address(RVA = "0x3C36110", Offset = "0x3C34D10", VA = "0x183C36110", Slot = "5")]
	protected override string JLKDLOMIDCD(BILFBGGHINK<TKey> IFGCIHPEHMO, DGGOCAMFPCD CFMMJEFKBIN)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600011F")]
	[Cpp2IlInjected.Address(RVA = "0x3C36000", Offset = "0x3C34C00", VA = "0x183C36000")]
	[CompilerGenerated]
	internal static string BILGOMJMGJJ(string INFNALBDIJG, TKey NCMHANGAILD, HIBDOMKOOCO P_2)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000039")]
public sealed class ALNJLBGGPLA : BILFBGGHINK<string>
{
	[Cpp2IlInjected.Token(Token = "0x200003A")]
	[CompilerGenerated]
	private sealed class MJCLMDFKCBN
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000091")]
		public Action<ALNJLBGGPLA, EEGEMFOKJOP> callback;

		[Cpp2IlInjected.Token(Token = "0x6000122")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public MJCLMDFKCBN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000123")]
		[Cpp2IlInjected.Address(RVA = "0x69A3130", Offset = "0x69A1D30", VA = "0x1869A3130")]
		internal void AHMNJKIDKFO(BILFBGGHINK<string> timer, EEGEMFOKJOP log)
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000120")]
	[Cpp2IlInjected.Address(RVA = "0x699FAA0", Offset = "0x699E6A0", VA = "0x18699FAA0")]
	public ALNJLBGGPLA(EEGEMFOKJOP IGMINGONOGN, [Optional] string LPINOKMCMNC, [Optional] int? BBFDNADOKHF, [Optional] Stopwatch KFDMHNJJIHD, [Optional] Action<string, CJHJGLCOGMJ, EEGEMFOKJOP> ADDBOMHMNIB, [Optional] Action<string, CJHJGLCOGMJ, EEGEMFOKJOP> GPHGCDKALPH, [Optional] Action<ALNJLBGGPLA, EEGEMFOKJOP> KMFCBOCDBFJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000121")]
	[Cpp2IlInjected.Address(RVA = "0x699F9E0", Offset = "0x699E5E0", VA = "0x18699F9E0")]
	private static Action<BILFBGGHINK<string>, EEGEMFOKJOP> LKGGGPEGALB(Action<ALNJLBGGPLA, EEGEMFOKJOP> LABOKGHKKOB)
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003B")]
public abstract class KFFIEKBFAHJ
{
	[Cpp2IlInjected.Token(Token = "0x200003C")]
	private class BABCAAFGECH : KFFIEKBFAHJ
	{
		[Cpp2IlInjected.Token(Token = "0x17000033")]
		public static KFFIEKBFAHJ NKKNEDDGFMP
		{
			[Cpp2IlInjected.Token(Token = "0x6000128")]
			[Cpp2IlInjected.Address(RVA = "0x699FBF0", Offset = "0x699E7F0", VA = "0x18699FBF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000034")]
		public override float OKKBIDNJEPI
		{
			[Cpp2IlInjected.Token(Token = "0x6000129")]
			[Cpp2IlInjected.Address(RVA = "0x9ABB60", Offset = "0x9AA760", VA = "0x1809ABB60", Slot = "4")]
			get
			{
				return default(float);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600012A")]
		[Cpp2IlInjected.Address(RVA = "0x699FCF0", Offset = "0x699E8F0", VA = "0x18699FCF0")]
		public BABCAAFGECH()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x4000092")]
	private static KFFIEKBFAHJ NLCAMKJGCCF;

	[Cpp2IlInjected.Token(Token = "0x17000031")]
	public static KFFIEKBFAHJ APEJJIEJKNM
	{
		[Cpp2IlInjected.Token(Token = "0x6000124")]
		[Cpp2IlInjected.Address(RVA = "0x69A2B10", Offset = "0x69A1710", VA = "0x1869A2B10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000032")]
	public abstract float OKKBIDNJEPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000125")]
		[Cpp2IlInjected.Address(Slot = "4")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000126")]
	[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
	protected KFFIEKBFAHJ()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200003D")]
public interface IMGIKIEFFPI : IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000035")]
	bool DLCDMGIPGPC
	{
		[Cpp2IlInjected.Token(Token = "0x600012C")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003E")]
public interface MOKKMPAFINF<T> : IMGIKIEFFPI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x17000036")]
	[NotNull]
	Task<T> MPHKHCCKGCH
	{
		[Cpp2IlInjected.Token(Token = "0x600012D")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000037")]
	[NotNull]
	AMIFHJEHCND<T> HCAJJBHGMHP
	{
		[Cpp2IlInjected.Token(Token = "0x600012E")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x200003F")]
public static class IHAPILFLBJI
{
	[Cpp2IlInjected.Token(Token = "0x600012F")]
	[Cpp2IlInjected.Address(RVA = "0x2B76A30", Offset = "0x2B75630", VA = "0x182B76A30")]
	public static MOKKMPAFINF<TResource> PMFAKODLCFK<TResource, TId>(this GGPGNIIIDFD<TId, TResource> EKDHMOLEJIP, TId CABAGOHBNFK, [Optional] Func<TId, CancellationToken, Task<TResource>>? INKNDJFGBMD) where TResource : notnull where TId : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000040")]
public static class OFLPPPJPPNO
{
	[Cpp2IlInjected.Token(Token = "0x2000041")]
	private sealed class LAPOJNIPDGL<T> : BKNNFBEIGPP<T?> where T : class
	{
		[Cpp2IlInjected.Token(Token = "0x17000038")]
		public override Task<T?> MPHKHCCKGCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000135")]
			[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000039")]
		public override AMIFHJEHCND<T?> HCAJJBHGMHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000136")]
			[Cpp2IlInjected.Address(RVA = "0x867590", Offset = "0x866190", VA = "0x180867590", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000137")]
		[Cpp2IlInjected.Address(RVA = "0x4244520", Offset = "0x4243120", VA = "0x184244520")]
		public LAPOJNIPDGL()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000138")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "10")]
		protected override void GECMKKIMMEO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000042")]
	private sealed class LGMHLNCBLOE<T> : BKNNFBEIGPP<T> where T : notnull
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000097")]
		private readonly T LKLIFGHNDNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000098")]
		private readonly Action<T>? DOHAHAPPGIL;

		[Cpp2IlInjected.Token(Token = "0x1700003A")]
		public override Task<T> MPHKHCCKGCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000139")]
			[Cpp2IlInjected.Address(RVA = "0x86A100", Offset = "0x868D00", VA = "0x18086A100", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003B")]
		public override AMIFHJEHCND<T> HCAJJBHGMHP
		{
			[Cpp2IlInjected.Token(Token = "0x600013A")]
			[Cpp2IlInjected.Address(RVA = "0x86A490", Offset = "0x869090", VA = "0x18086A490", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013B")]
		[Cpp2IlInjected.Address(RVA = "0x4276C90", Offset = "0x4275890", VA = "0x184276C90")]
		public LGMHLNCBLOE(T JPDEDFPDFNF, Action<T>? LCEGNFFKCKH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600013C")]
		[Cpp2IlInjected.Address(RVA = "0x4276A40", Offset = "0x4275640", VA = "0x184276A40", Slot = "10")]
		protected override void GECMKKIMMEO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000043")]
	private sealed class FHOKBLDDAHC<T> : BKNNFBEIGPP<T> where T : notnull
	{
		[Cpp2IlInjected.Token(Token = "0x1700003C")]
		public override Task<T> MPHKHCCKGCH
		{
			[Cpp2IlInjected.Token(Token = "0x600013D")]
			[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003D")]
		public override AMIFHJEHCND<T> HCAJJBHGMHP
		{
			[Cpp2IlInjected.Token(Token = "0x600013E")]
			[Cpp2IlInjected.Address(RVA = "0x867590", Offset = "0x866190", VA = "0x180867590", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600013F")]
		[Cpp2IlInjected.Address(RVA = "0x3C14AD0", Offset = "0x3C136D0", VA = "0x183C14AD0")]
		public FHOKBLDDAHC(Exception HEBIFBBBAHA)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000140")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "10")]
		protected override void GECMKKIMMEO()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000044")]
	private sealed class JLOFGAOFPFG<T> : BKNNFBEIGPP<T> where T : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000045")]
		[CompilerGenerated]
		private struct HGDELELHBGI : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A0")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A1")]
			public AsyncTaskMethodBuilder<T> <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A2")]
			public Task<MOKKMPAFINF<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A3")]
			private TaskAwaiter<MOKKMPAFINF<T>> <>u__1;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A4")]
			private TaskAwaiter<T> <>u__2;

			[Cpp2IlInjected.Token(Token = "0x6000147")]
			[Cpp2IlInjected.Address(RVA = "0x3DB9660", Offset = "0x3DB8260", VA = "0x183DB9660", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000148")]
			[Cpp2IlInjected.Address(RVA = "0x3DB9BA0", Offset = "0x3DB87A0", VA = "0x183DB9BA0", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000046")]
		[CompilerGenerated]
		private struct EJCFGCNMDFP : IAsyncStateMachine
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A5")]
			public int <>1__state;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A6")]
			public AsyncTaskMethodBuilder <>t__builder;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A7")]
			public Task<MOKKMPAFINF<T>> task;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000A8")]
			private TaskAwaiter<MOKKMPAFINF<T>> <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000149")]
			[Cpp2IlInjected.Address(RVA = "0x384A860", Offset = "0x3849460", VA = "0x18384A860", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600014A")]
			[Cpp2IlInjected.Address(RVA = "0x384AB00", Offset = "0x3849700", VA = "0x18384AB00", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x400009D")]
		private readonly Task<MOKKMPAFINF<T>> DBIGGKADLHP;

		[Cpp2IlInjected.Token(Token = "0x1700003E")]
		public override Task<T> MPHKHCCKGCH
		{
			[Cpp2IlInjected.Token(Token = "0x6000141")]
			[Cpp2IlInjected.Address(RVA = "0x867590", Offset = "0x866190", VA = "0x180867590", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x1700003F")]
		public override AMIFHJEHCND<T> HCAJJBHGMHP
		{
			[Cpp2IlInjected.Token(Token = "0x6000142")]
			[Cpp2IlInjected.Address(RVA = "0x86A480", Offset = "0x869080", VA = "0x18086A480", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000143")]
		[Cpp2IlInjected.Address(RVA = "0x40CD580", Offset = "0x40CC180", VA = "0x1840CD580")]
		public JLOFGAOFPFG(Task<MOKKMPAFINF<T>> LJPOAIPEHGB)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000144")]
		[Cpp2IlInjected.Address(RVA = "0x40CCF80", Offset = "0x40CBB80", VA = "0x1840CCF80", Slot = "10")]
		protected override void GECMKKIMMEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000145")]
		[Cpp2IlInjected.Address(RVA = "0x40CD400", Offset = "0x40CC000", VA = "0x1840CD400")]
		[AsyncStateMachine(typeof(JLOFGAOFPFG<>.HGDELELHBGI))]
		[CompilerGenerated]
		internal static Task<T> PPAIAKJCONP(Task<MOKKMPAFINF<T>> LJPOAIPEHGB)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000146")]
		[Cpp2IlInjected.Address(RVA = "0x40CD190", Offset = "0x40CBD90", VA = "0x1840CD190")]
		[AsyncStateMachine(typeof(JLOFGAOFPFG<>.EJCFGCNMDFP))]
		[CompilerGenerated]
		internal static Task HGKNNMJJJFD(Task<MOKKMPAFINF<T>> LJPOAIPEHGB)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000047")]
	private sealed class CCOHDCBOHIF<TIn, TOut> : BKNNFBEIGPP<TOut> where TIn : notnull where TOut : notnull
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000048")]
		[CompilerGenerated]
		private struct IEDDHDMMJMI : IAsyncStateMachine
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
			[Cpp2IlInjected.Address(RVA = "0x3E976C0", Offset = "0x3E962C0", VA = "0x183E976C0", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000151")]
			[Cpp2IlInjected.Address(RVA = "0x3E97D80", Offset = "0x3E96980", VA = "0x183E97D80", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000A9")]
		private readonly MOKKMPAFINF<TIn> OBBEBOIAHMM;

		[Cpp2IlInjected.Token(Token = "0x17000040")]
		public override Task<TOut> MPHKHCCKGCH
		{
			[Cpp2IlInjected.Token(Token = "0x600014B")]
			[Cpp2IlInjected.Address(RVA = "0x867590", Offset = "0x866190", VA = "0x180867590", Slot = "8")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000041")]
		public override AMIFHJEHCND<TOut> HCAJJBHGMHP
		{
			[Cpp2IlInjected.Token(Token = "0x600014C")]
			[Cpp2IlInjected.Address(RVA = "0x86A480", Offset = "0x869080", VA = "0x18086A480", Slot = "9")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600014D")]
		[Cpp2IlInjected.Address(RVA = "0x5572A00", Offset = "0x5571600", VA = "0x185572A00")]
		public CCOHDCBOHIF(MOKKMPAFINF<TIn> BBDBNHHIFDH, Func<TIn, TOut> KKNJLBGGNBE)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014E")]
		[Cpp2IlInjected.Address(RVA = "0x5572640", Offset = "0x5571240", VA = "0x185572640", Slot = "10")]
		protected override void GECMKKIMMEO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600014F")]
		[Cpp2IlInjected.Address(RVA = "0x5572870", Offset = "0x5571470", VA = "0x185572870")]
		[AsyncStateMachine(typeof(CCOHDCBOHIF<, >.IEDDHDMMJMI))]
		[CompilerGenerated]
		internal static Task<TOut> HAMFLJPKDCH(Task<TIn> LHLFKHODEHB, Func<TIn, TOut> KKNJLBGGNBE)
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000130")]
	[Cpp2IlInjected.Address(RVA = "0x2CC9E90", Offset = "0x2CC8A90", VA = "0x182CC9E90")]
	public static MOKKMPAFINF<T> ECELLENMKJP<T>() where T : class
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000131")]
	[Cpp2IlInjected.Address(RVA = "0x2CC9DE0", Offset = "0x2CC89E0", VA = "0x182CC9DE0")]
	public static MOKKMPAFINF<T> DONAEBKHGLF<T>(T KKIOBLFFGJH, [Optional] Action<T>? LCEGNFFKCKH) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000132")]
	[Cpp2IlInjected.Address(RVA = "0x2996690", Offset = "0x2995290", VA = "0x182996690")]
	public static MOKKMPAFINF<T> ALINPJHPDPO<T>(Exception HEBIFBBBAHA) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000133")]
	[Cpp2IlInjected.Address(RVA = "0x2996690", Offset = "0x2995290", VA = "0x182996690")]
	public static MOKKMPAFINF<T> FKAHONNDMHC<T>(Task<MOKKMPAFINF<T>> LJPOAIPEHGB) where T : notnull
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x6000134")]
	[Cpp2IlInjected.Address(RVA = "0x2B38FF0", Offset = "0x2B37BF0", VA = "0x182B38FF0")]
	public static MOKKMPAFINF<TOut> LHELEJKIFMG<TOut, TIn>(MOKKMPAFINF<TIn> MJBLPCEDGPJ, Func<TIn, TOut> KKNJLBGGNBE) where TOut : notnull where TIn : notnull
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000049")]
public abstract class BKNNFBEIGPP<T> : MOKKMPAFINF<T>, IMGIKIEFFPI, IDisposable
{
	[Cpp2IlInjected.Token(Token = "0x40000B2")]
	private static readonly string KNEFAOJNLPA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B3")]
	private readonly BLCDLKBIDPC DNDDNDKONHE;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B4")]
	private bool KFHJMPBIANF;

	[Cpp2IlInjected.Token(Token = "0x17000042")]
	public bool DLCDMGIPGPC
	{
		[Cpp2IlInjected.Token(Token = "0x6000152")]
		[Cpp2IlInjected.Address(RVA = "0xB928D0", Offset = "0xB914D0", VA = "0x180B928D0", Slot = "6")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000043")]
	public abstract Task<T> MPHKHCCKGCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000153")]
		[Cpp2IlInjected.Address(Slot = "8")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x17000044")]
	public abstract AMIFHJEHCND<T> HCAJJBHGMHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000154")]
		[Cpp2IlInjected.Address(Slot = "9")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x6000155")]
	[Cpp2IlInjected.Address(RVA = "0x4E88800", Offset = "0x4E87400", VA = "0x184E88800")]
	public BKNNFBEIGPP()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000156")]
	[Cpp2IlInjected.Address(RVA = "0x4E883D0", Offset = "0x4E86FD0", VA = "0x184E883D0", Slot = "7")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000157")]
	[Cpp2IlInjected.Address(Slot = "10")]
	protected abstract void GECMKKIMMEO();
}
[Cpp2IlInjected.Token(Token = "0x200004A")]
public abstract class KMNBJOHJECJ<TTask, T> : BKNNFBEIGPP<T> where TTask : Task
{
	[Cpp2IlInjected.Token(Token = "0x200004B")]
	[CompilerGenerated]
	private sealed class PPLNADENPOA
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
			public PPLNADENPOA <>4__this;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x40000BE")]
			private TaskAwaiter <>u__1;

			[Cpp2IlInjected.Token(Token = "0x6000161")]
			[Cpp2IlInjected.Address(RVA = "0x357BB80", Offset = "0x357A780", VA = "0x18357BB80", Slot = "4")]
			private void MoveNext()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000162")]
			[Cpp2IlInjected.Address(RVA = "0x357BE50", Offset = "0x357AA50", VA = "0x18357BE50", Slot = "5")]
			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B8")]
		public KMNBJOHJECJ<TTask, T> <>4__this;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000B9")]
		public CancellationToken cancelToken;

		[Cpp2IlInjected.Token(Token = "0x600015F")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public PPLNADENPOA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000160")]
		[Cpp2IlInjected.Address(RVA = "0x47B0330", Offset = "0x47AEF30", VA = "0x1847B0330")]
		[AsyncStateMachine(typeof(KMNBJOHJECJ<, >.PPLNADENPOA.<<-ctor>g__AwaitThenTransformTaskResult|0>d))]
		internal Task<T> NPMOPLIHNHK(TTask originalTask)
		{
			return null;
		}
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B5")]
	private readonly Task<T> LJPOAIPEHGB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000B7")]
	protected readonly CancellationTokenSource GJNGFDIEBMK;

	[Cpp2IlInjected.Token(Token = "0x17000045")]
	public override Task<T> MPHKHCCKGCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000159")]
		[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000046")]
	public override AMIFHJEHCND<T> HCAJJBHGMHP
	{
		[Cpp2IlInjected.Token(Token = "0x600015A")]
		[Cpp2IlInjected.Address(RVA = "0x867590", Offset = "0x866190", VA = "0x180867590", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600015B")]
	[Cpp2IlInjected.Address(RVA = "0x41C6E20", Offset = "0x41C5A20", VA = "0x1841C6E20")]
	protected KMNBJOHJECJ(TTask LJPOAIPEHGB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015C")]
	[Cpp2IlInjected.Address(RVA = "0x41C6BC0", Offset = "0x41C57C0", VA = "0x1841C6BC0", Slot = "10")]
	protected override void GECMKKIMMEO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600015D")]
	[Cpp2IlInjected.Address(Slot = "11")]
	protected abstract T BJPJEBFHILK(TTask PIPGNAIFLGO);

	[Cpp2IlInjected.Token(Token = "0x600015E")]
	[Cpp2IlInjected.Address(Slot = "12")]
	protected abstract void COKLMBDGFJL();
}
[Cpp2IlInjected.Token(Token = "0x200004D")]
public class AGKBEKINPFC<T> : BKNNFBEIGPP<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000BF")]
	private readonly ELKLJFKIONH<Task<T>> EOHJNNLKMDH;

	[Cpp2IlInjected.Token(Token = "0x17000047")]
	public override Task<T> MPHKHCCKGCH
	{
		[Cpp2IlInjected.Token(Token = "0x6000163")]
		[Cpp2IlInjected.Address(RVA = "0x3D0FB80", Offset = "0x3D0E780", VA = "0x183D0FB80", Slot = "8")]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000048")]
	public override AMIFHJEHCND<T> HCAJJBHGMHP
	{
		[Cpp2IlInjected.Token(Token = "0x6000164")]
		[Cpp2IlInjected.Address(RVA = "0x867590", Offset = "0x866190", VA = "0x180867590", Slot = "9")]
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000165")]
	[Cpp2IlInjected.Address(RVA = "0x3D0FBE0", Offset = "0x3D0E7E0", VA = "0x183D0FBE0")]
	public AGKBEKINPFC(ELKLJFKIONH<Task<T>> ALJDAILFIAG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000166")]
	[Cpp2IlInjected.Address(RVA = "0x3D0FB60", Offset = "0x3D0E760", VA = "0x183D0FB60", Slot = "10")]
	protected override void GECMKKIMMEO()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200004E")]
public static class EIDMJLKAFAE
{
	[Cpp2IlInjected.Token(Token = "0x40000C1")]
	public static readonly HashAlgorithmName MFLBMDINKEA;

	[Cpp2IlInjected.Token(Token = "0x40000C2")]
	private static readonly ThreadLocal<IncrementalHash> DLAIGIDAFMK;

	[Cpp2IlInjected.Token(Token = "0x6000167")]
	[Cpp2IlInjected.Address(RVA = "0x69A20A0", Offset = "0x69A0CA0", VA = "0x1869A20A0")]
	public static int GAGJMHHDACM(this NCACCCFGOPK OIMJGGMNAKE, IncrementalHash FJHEHEDBGNJ, byte[] ILCGBICALBK)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000168")]
	[Cpp2IlInjected.Address(RVA = "0x69A2760", Offset = "0x69A1360", VA = "0x1869A2760")]
	public static bool LDDEMKMLKEH([CanBeNull] this NCACCCFGOPK OIMJGGMNAKE)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000169")]
	[Cpp2IlInjected.Address(RVA = "0x69A2120", Offset = "0x69A0D20", VA = "0x1869A2120")]
	public static bool LDDEMKMLKEH([CanBeNull] this NCACCCFGOPK OIMJGGMNAKE, [Out] string JMMBJIBOIFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016A")]
	[Cpp2IlInjected.Address(RVA = "0x69A2430", Offset = "0x69A1030", VA = "0x1869A2430")]
	public static bool LDDEMKMLKEH([CanBeNull] this NCACCCFGOPK OIMJGGMNAKE, IncrementalHash FJHEHEDBGNJ, byte[] ILCGBICALBK, [Out] string JMMBJIBOIFP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600016B")]
	[Cpp2IlInjected.Address(RVA = "0x69A27C0", Offset = "0x69A13C0", VA = "0x1869A27C0")]
	private static bool OLLJMBEJFNG(byte[] CGCALJOPCPI, Span<byte> NJNCOBHBFEJ)
	{
		return default(bool);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000050")]
public static class OJLABJNEDPI
{
	[Cpp2IlInjected.Token(Token = "0x6000170")]
	[Cpp2IlInjected.Address(RVA = "0x69A3410", Offset = "0x69A2010", VA = "0x1869A3410")]
	public static int CMJHGNEJCFG(HashAlgorithmName LDDPAMALMOI)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000171")]
	[Cpp2IlInjected.Address(RVA = "0x69A3560", Offset = "0x69A2160", VA = "0x1869A3560")]
	public static int GAGJMHHDACM(this EDFJOAOCNCD GOIABIGGKJF, byte[] FEOLOJDDMII, IncrementalHash FJHEHEDBGNJ, byte[] KGKHBIPLAII)
	{
		return default(int);
	}
}
[Cpp2IlInjected.Token(Token = "0x2000051")]
public interface EDFJOAOCNCD
{
	[Cpp2IlInjected.Token(Token = "0x6000172")]
	[Cpp2IlInjected.Address(Slot = "0")]
	void AppendToHash([NotNull] IncrementalHash FJHEHEDBGNJ);
}
[Cpp2IlInjected.Token(Token = "0x2000052")]
public interface NCACCCFGOPK : EDFJOAOCNCD
{
	[Cpp2IlInjected.Token(Token = "0x17000049")]
	[CanBeNull]
	byte[] PEOBHEJHMIH
	{
		[Cpp2IlInjected.Token(Token = "0x6000173")]
		[Cpp2IlInjected.Address(Slot = "0")]
		get;
	}

	[Cpp2IlInjected.Token(Token = "0x1700004A")]
	[CanBeNull]
	byte[] ANGFHBAHMPI
	{
		[Cpp2IlInjected.Token(Token = "0x6000174")]
		[Cpp2IlInjected.Address(Slot = "1")]
		get;
	}
}
[Cpp2IlInjected.Token(Token = "0x2000053")]
public static class EGNELBFIALH
{
	[Cpp2IlInjected.Token(Token = "0x40000C4")]
	private static bool PPDJNGEFDAM;

	[Cpp2IlInjected.Token(Token = "0x40000C5")]
	private static readonly ArrayPool<byte> KJJFJDJIHIF;

	[Cpp2IlInjected.Token(Token = "0x40000C6")]
	private static readonly ArrayPool<char> HMDCCKIIDHH;

	[Cpp2IlInjected.Token(Token = "0x40000C7")]
	private static readonly Encoding LNNNOMCBDAM;

	[Cpp2IlInjected.Token(Token = "0x40000C8")]
	private static readonly ThreadLocal<Encoder> OIJDKLEOEMA;

	[Cpp2IlInjected.Token(Token = "0x6000175")]
	[Cpp2IlInjected.Address(RVA = "0x29E06C0", Offset = "0x29DF2C0", VA = "0x1829E06C0")]
	public static void FJPFBDMFEMC<T>(this IncrementalHash DHCAFOGJJPI, [CanBeNull] T BFLHJMMHBCN) where T : Component
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000176")]
	[Cpp2IlInjected.Address(RVA = "0x29E0630", Offset = "0x29DF230", VA = "0x1829E0630")]
	public static void EAKBPJBALPD<T>(this IncrementalHash DHCAFOGJJPI, [CanBeNull] T GOIABIGGKJF) where T : EDFJOAOCNCD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000177")]
	[Cpp2IlInjected.Address(RVA = "0x29E0DA0", Offset = "0x29DF9A0", VA = "0x1829E0DA0")]
	public static void PHIHPPMGBCK<T>(this IncrementalHash DHCAFOGJJPI, [CanBeNull] IList<T> DMKLHAKPFJH) where T : EDFJOAOCNCD
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000178")]
	[Cpp2IlInjected.Address(RVA = "0x69A1C50", Offset = "0x69A0850", VA = "0x1869A1C50")]
	private static bool LFPGLKGPAFH([CanBeNull] EDFJOAOCNCD GOIABIGGKJF)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000179")]
	[Cpp2IlInjected.Address(RVA = "0x69A1840", Offset = "0x69A0440", VA = "0x1869A1840")]
	public static void IKMNJDMIDDM(this IncrementalHash FJHEHEDBGNJ, string? FMGPLIGAHFC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017A")]
	[Cpp2IlInjected.Address(RVA = "0x69A14A0", Offset = "0x69A00A0", VA = "0x1869A14A0")]
	public static void FDNGBKPFCHF(this IncrementalHash FJHEHEDBGNJ, long LEGPLPKANCJ)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017B")]
	[Cpp2IlInjected.Address(RVA = "0x69A1670", Offset = "0x69A0270", VA = "0x1869A1670")]
	public static void IEMAHNHONEO(this IncrementalHash FJHEHEDBGNJ, int OOMHNAPIJAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017C")]
	[Cpp2IlInjected.Address(RVA = "0x69A1140", Offset = "0x699FD40", VA = "0x1869A1140")]
	public static void CHOMKBHIHNH(this IncrementalHash FJHEHEDBGNJ, short DHIDBEOFJAA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017D")]
	[Cpp2IlInjected.Address(RVA = "0x69A0EC0", Offset = "0x699FAC0", VA = "0x1869A0EC0")]
	public static void AECDKKAHOLN(this IncrementalHash FJHEHEDBGNJ, byte KCABBKDHJGI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017E")]
	[Cpp2IlInjected.Address(RVA = "0x69A0FD0", Offset = "0x699FBD0", VA = "0x1869A0FD0")]
	public static void ANLPJGEGGLK(this IncrementalHash FJHEHEDBGNJ, bool PNIFNFGGMEE, bool DEAEIBOFHFA = false, bool OFEPKOBKDAD = false, bool MACOGBNIEJO = false, bool KHDOAKFANED = false, bool BFCODGNJBEE = false, bool PNKCAGKNANP = false, bool NMNJEBEMJMB = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600017F")]
	[Cpp2IlInjected.Address(RVA = "0x29E0780", Offset = "0x29DF380", VA = "0x1829E0780")]
	public static void NMNIKPMCLOJ<T>(this IncrementalHash FJHEHEDBGNJ, T CLDDKGECHDK) where T : struct, Enum, IConvertible
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000180")]
	[Cpp2IlInjected.Address(RVA = "0x69A1CE0", Offset = "0x69A08E0", VA = "0x1869A1CE0")]
	public static void MDACNILDPBK(this IncrementalHash FJHEHEDBGNJ, float KDEPGHNDIMF)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000181")]
	[Cpp2IlInjected.Address(RVA = "0x69A1D40", Offset = "0x69A0940", VA = "0x1869A1D40")]
	public static void OMEPDDCFKMI(this IncrementalHash FJHEHEDBGNJ, ulong ABMFIBECGOB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000182")]
	[Cpp2IlInjected.Address(RVA = "0x69A1DA0", Offset = "0x69A09A0", VA = "0x1869A1DA0")]
	public static void OOBBAIOFMLO(this IncrementalHash FJHEHEDBGNJ, uint HNNEBKJCCOI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000183")]
	[Cpp2IlInjected.Address(RVA = "0x69A1440", Offset = "0x69A0040", VA = "0x1869A1440")]
	public static void FCNKEFMOHGF(this IncrementalHash FJHEHEDBGNJ, ushort KMAENNICOHK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000184")]
	[Cpp2IlInjected.Address(RVA = "0x69A1310", Offset = "0x699FF10", VA = "0x1869A1310")]
	public static void DFPFEKHJDFE(this IncrementalHash FJHEHEDBGNJ, Vector3 DIAJJBCJCDC)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000055")]
public class NODHEMGFNBM : Exception
{
	[Cpp2IlInjected.Token(Token = "0x6000189")]
	[Cpp2IlInjected.Address(RVA = "0x69A3330", Offset = "0x69A1F30", VA = "0x1869A3330")]
	public NODHEMGFNBM(string NKAJDDICLFH)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000056")]
public abstract class GKMFBFKOIAA<TClaimant, TNode> : IDisposable where TClaimant : class where TNode : class
{
	[Cpp2IlInjected.Token(Token = "0x2000057")]
	internal class NLNGHFMIEMM
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D1")]
		public TNode ENEDBNLKLJL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D2")]
		public TNode DELFIACNBGK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D3")]
		public GKIMLJCEPHM DJNHJDCMHHE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D4")]
		public List<GKIMLJCEPHM> EGBAPKBDHFB;

		[Cpp2IlInjected.Token(Token = "0x600019E")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public NLNGHFMIEMM()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000058")]
	internal struct GKIMLJCEPHM : IComparable<GKIMLJCEPHM>
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D5")]
		public int BOCMOELLFNN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000D6")]
		public TClaimant AMHAOCAMLHK;

		[Cpp2IlInjected.Token(Token = "0x600019F")]
		[Cpp2IlInjected.Address(RVA = "0xD98E30", Offset = "0xD97A30", VA = "0x180D98E30")]
		public GKIMLJCEPHM(int BOCMOELLFNN, TClaimant AMHAOCAMLHK)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A0")]
		[Cpp2IlInjected.Address(RVA = "0x3D56730", Offset = "0x3D55330", VA = "0x183D56730")]
		public bool BPMECKLPENK([In] GKIMLJCEPHM HEIGABGMPLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A1")]
		[Cpp2IlInjected.Address(RVA = "0x3D567A0", Offset = "0x3D553A0", VA = "0x183D567A0")]
		public bool KFLLLBDDKDN([In] GKIMLJCEPHM HEIGABGMPLJ)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A2")]
		[Cpp2IlInjected.Address(RVA = "0x3D56790", Offset = "0x3D55390", VA = "0x183D56790", Slot = "4")]
		public int CompareTo(GKIMLJCEPHM HEIGABGMPLJ)
		{
			return default(int);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A3")]
		[Cpp2IlInjected.Address(RVA = "0x3D567B0", Offset = "0x3D553B0", VA = "0x183D567B0", Slot = "3")]
		public override string ToString()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x2000059")]
	public enum LJKFKPLDFDL
	{
		[Cpp2IlInjected.Token(Token = "0x40000D8")]
		FirstOwner,
		[Cpp2IlInjected.Token(Token = "0x40000D9")]
		ClosestAncestor
	}

	[Cpp2IlInjected.Token(Token = "0x200005A")]
	[CompilerGenerated]
	private sealed class DDGBAOPICLE : IEnumerable<TNode>, IEnumerable, IEnumerator<TNode>, IEnumerator, IDisposable
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
		public GKMFBFKOIAA<TClaimant, TNode> <>4__this;

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
			[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990", Slot = "6")]
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
			[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990", Slot = "9")]
			[DebuggerHidden]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001A4")]
		[Cpp2IlInjected.Address(RVA = "0x8BB210", Offset = "0x8B9E10", VA = "0x1808BB210")]
		[DebuggerHidden]
		public DDGBAOPICLE(int <>1__state)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A5")]
		[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20", Slot = "7")]
		[DebuggerHidden]
		void IDisposable.Dispose()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001A6")]
		[Cpp2IlInjected.Address(RVA = "0x58809D0", Offset = "0x587F5D0", VA = "0x1858809D0", Slot = "8")]
		private bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001A8")]
		[Cpp2IlInjected.Address(RVA = "0x5880BB0", Offset = "0x587F7B0", VA = "0x185880BB0", Slot = "10")]
		[DebuggerHidden]
		void IEnumerator.Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001AA")]
		[Cpp2IlInjected.Address(RVA = "0x5880AB0", Offset = "0x587F6B0", VA = "0x185880AB0", Slot = "4")]
		[DebuggerHidden]
		IEnumerator<TNode> IEnumerable<TNode>.GetEnumerator()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001AB")]
		[Cpp2IlInjected.Address(RVA = "0x3946EF0", Offset = "0x3945AF0", VA = "0x183946EF0", Slot = "5")]
		[DebuggerHidden]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x40000CA")]
	private static readonly APELDPIDBDH<NLNGHFMIEMM> HHBPDJGMOLH;

	[Cpp2IlInjected.Token(Token = "0x40000CB")]
	private static readonly APELDPIDBDH<List<GKIMLJCEPHM>> EHCANDCDFFO;

	[Cpp2IlInjected.Token(Token = "0x40000CC")]
	private static int KAAKMNAKLCA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CD")]
	internal readonly Dictionary<TClaimant, TNode> KGIHNAMNPBA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CE")]
	internal readonly Dictionary<TNode, NLNGHFMIEMM> IPEKHLMPLCJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000CF")]
	private LJKFKPLDFDL GIIHAKJPNKL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000D0")]
	private bool KLBJCIGNEHB;

	[Cpp2IlInjected.Token(Token = "0x600018A")]
	[Cpp2IlInjected.Address(Slot = "5")]
	protected abstract TNode BOCPKBOKCHE(TNode AIJMDPAKHCL);

	[Cpp2IlInjected.Token(Token = "0x600018B")]
	[Cpp2IlInjected.Address(Slot = "6")]
	protected abstract void HHBBCEKFMDF(TNode AIJMDPAKHCL, TClaimant LHEACOBLKAF, TClaimant IEDHGMJBCCG);

	[Cpp2IlInjected.Token(Token = "0x600018C")]
	[Cpp2IlInjected.Address(RVA = "0x3D58640", Offset = "0x3D57240", VA = "0x183D58640")]
	public GKMFBFKOIAA(LJKFKPLDFDL GIIHAKJPNKL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018D")]
	[Cpp2IlInjected.Address(RVA = "0x3D577C0", Offset = "0x3D563C0", VA = "0x183D577C0")]
	public void JEGIOOFNNOP(TNode AIJMDPAKHCL, TNode EGKBIIFMAKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018E")]
	[Cpp2IlInjected.Address(RVA = "0x3D56B60", Offset = "0x3D55760", VA = "0x183D56B60")]
	public void AKFPCJAIHJK(TClaimant AMHAOCAMLHK, TNode PBAINNOOMBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600018F")]
	[Cpp2IlInjected.Address(RVA = "0x3D571C0", Offset = "0x3D55DC0", VA = "0x183D571C0", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000190")]
	[Cpp2IlInjected.Address(RVA = "0x3D573F0", Offset = "0x3D55FF0", VA = "0x183D573F0")]
	private void GKLJOBGNAPH(TClaimant AMHAOCAMLHK, TNode BJLCEOFPKLK, TNode PBAINNOOMBI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000191")]
	[Cpp2IlInjected.Address(RVA = "0x3D57750", Offset = "0x3D56350", VA = "0x183D57750")]
	private int JBAHOHOCBGO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x6000192")]
	[Cpp2IlInjected.Address(RVA = "0x3D57E20", Offset = "0x3D56A20", VA = "0x183D57E20")]
	private void MPLDFEBJLHL(TClaimant AMHAOCAMLHK, TNode EGFKGHNGMGI, TNode DKKIKIJGBAJ, int LEONJNLPHJH = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000193")]
	[Cpp2IlInjected.Address(RVA = "0x3D57D40", Offset = "0x3D56940", VA = "0x183D57D40")]
	private void MMJKKCMMGEJ(GKIMLJCEPHM OPGCMMCOBKM, NLNGHFMIEMM OIBBHECAKMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000194")]
	[Cpp2IlInjected.Address(RVA = "0x3D58160", Offset = "0x3D56D60", VA = "0x183D58160")]
	private void OBCANIGIBCC(TClaimant AMHAOCAMLHK, TNode EGFKGHNGMGI, TNode DKKIKIJGBAJ, int LEONJNLPHJH = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000195")]
	[Cpp2IlInjected.Address(RVA = "0x3D57890", Offset = "0x3D56490", VA = "0x183D57890")]
	private void KFALGABLONA(GKIMLJCEPHM OPGCMMCOBKM, TNode AIJMDPAKHCL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000196")]
	[Cpp2IlInjected.Address(RVA = "0x3D57050", Offset = "0x3D55C50", VA = "0x183D57050")]
	private void CMJFPFOELLJ(GKIMLJCEPHM OPGCMMCOBKM, NLNGHFMIEMM OIBBHECAKMI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000197")]
	[Cpp2IlInjected.Address(RVA = "0x3D56D00", Offset = "0x3D55900", VA = "0x183D56D00")]
	private void CCJJMIPCPLB(NLNGHFMIEMM OIBBHECAKMI, bool CLOJDHNNJHF = false)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000198")]
	[Cpp2IlInjected.Address(RVA = "0x3D579D0", Offset = "0x3D565D0", VA = "0x183D579D0")]
	private void LCFDJGPJHDN(NLNGHFMIEMM OIBBHECAKMI, TNode EGKBIIFMAKK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000199")]
	[Cpp2IlInjected.Address(RVA = "0x3D57650", Offset = "0x3D56250", VA = "0x183D57650")]
	[IteratorStateMachine(typeof(GKMFBFKOIAA<, >.DDGBAOPICLE))]
	private IEnumerable<TNode> ICFICCIGIAF(TNode EGFKGHNGMGI, TNode DKKIKIJGBAJ, bool FLEMDGOCCCI = false)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019A")]
	[Cpp2IlInjected.Address(RVA = "0x3D56A40", Offset = "0x3D55640", VA = "0x183D56A40")]
	private NLNGHFMIEMM AGEGJENOPLL(TNode AIJMDPAKHCL, TNode DELFIACNBGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019B")]
	[Cpp2IlInjected.Address(RVA = "0x3D574C0", Offset = "0x3D560C0", VA = "0x183D574C0")]
	private NLNGHFMIEMM HLGOFCNOFDL(TNode AIJMDPAKHCL, TNode DELFIACNBGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x600019C")]
	[Cpp2IlInjected.Address(RVA = "0x3D56E80", Offset = "0x3D55A80", VA = "0x183D56E80")]
	private void CHGGIOEACAB(NLNGHFMIEMM OIBBHECAKMI)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200005B")]
public class LCGABPHAMBI<T> : IEnumerable<LCGABPHAMBI<T>.CKFDHMLNLOB>, IEnumerable
{
	[Cpp2IlInjected.Token(Token = "0x200005C")]
	public struct CKFDHMLNLOB
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000E9")]
		public T IIPLJLPCLBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EA")]
		public int BAEBMIBABAE;
	}

	[Cpp2IlInjected.Token(Token = "0x200005D")]
	public class KMLMJONGDCF : IEnumerator<CKFDHMLNLOB>, IEnumerator, IDisposable
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EB")]
		private LCGABPHAMBI<T> NMKIFNPGKAH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EC")]
		private int BAEBMIBABAE;

		[Cpp2IlInjected.Token(Token = "0x1700004F")]
		object IEnumerator.Current
		{
			[Cpp2IlInjected.Token(Token = "0x60001BC")]
			[Cpp2IlInjected.Address(RVA = "0x3863270", Offset = "0x3861E70", VA = "0x183863270", Slot = "7")]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000050")]
		public CKFDHMLNLOB KENACMDPOBM
		{
			[Cpp2IlInjected.Token(Token = "0x60001BD")]
			[Cpp2IlInjected.Address(RVA = "0x41C6700", Offset = "0x41C5300", VA = "0x1841C6700", Slot = "4")]
			get
			{
				return default(CKFDHMLNLOB);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001BE")]
		[Cpp2IlInjected.Address(RVA = "0x41C66C0", Offset = "0x41C52C0", VA = "0x1841C66C0")]
		public KMLMJONGDCF(LCGABPHAMBI<T> NMKIFNPGKAH)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001BF")]
		[Cpp2IlInjected.Address(RVA = "0x41C65C0", Offset = "0x41C51C0", VA = "0x1841C65C0", Slot = "6")]
		public bool MoveNext()
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x60001C0")]
		[Cpp2IlInjected.Address(RVA = "0x38B84A0", Offset = "0x38B70A0", VA = "0x1838B84A0", Slot = "8")]
		public void Reset()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x60001C1")]
		[Cpp2IlInjected.Address(RVA = "0x9428B0", Offset = "0x9414B0", VA = "0x1809428B0", Slot = "5")]
		public void Dispose()
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x200005E")]
	private struct PLLJJLOPKHJ
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000ED")]
		public bool HPBHBKIHEGB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000EE")]
		public T IIPLJLPCLBC;
	}

	[Cpp2IlInjected.Token(Token = "0x40000E4")]
	private const int CCJLADHNLLL = 32;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E5")]
	private readonly Dictionary<T, int> IPIBNMJIILN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E6")]
	private PLLJJLOPKHJ[] PMNJBLHKEJK;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000E7")]
	private int DCMINLHGIPI;

	[Cpp2IlInjected.Token(Token = "0x1700004D")]
	public int OBCHCJIINGI
	{
		[Cpp2IlInjected.Token(Token = "0x60001AC")]
		[Cpp2IlInjected.Address(RVA = "0x8A5290", Offset = "0x8A3E90", VA = "0x1808A5290")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001AD")]
		[Cpp2IlInjected.Address(RVA = "0x8A4E40", Offset = "0x8A3A40", VA = "0x1808A4E40")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700004E")]
	public int NAAONAFFINP
	{
		[Cpp2IlInjected.Token(Token = "0x60001AE")]
		[Cpp2IlInjected.Address(RVA = "0x358E2D0", Offset = "0x358CED0", VA = "0x18358E2D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001AF")]
	[Cpp2IlInjected.Address(RVA = "0x424A9F0", Offset = "0x42495F0", VA = "0x18424A9F0")]
	public LCGABPHAMBI(int DFJDDCJIBIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B0")]
	[Cpp2IlInjected.Address(RVA = "0x424A160", Offset = "0x4248D60", VA = "0x18424A160")]
	public LCGABPHAMBI(CKFDHMLNLOB[] CCHLLMPEOMJ, bool EEBNPKODNID)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001B1")]
	[Cpp2IlInjected.Address(RVA = "0x4249EE0", Offset = "0x4248AE0", VA = "0x184249EE0")]
	public int OAAAGLFIEDC()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B2")]
	[Cpp2IlInjected.Address(RVA = "0x4249CC0", Offset = "0x42488C0", VA = "0x184249CC0")]
	private int NJFDEHAEJAO()
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B3")]
	[Cpp2IlInjected.Address(RVA = "0x4249820", Offset = "0x4248420", VA = "0x184249820", Slot = "6")]
	protected virtual uint EGHKKKAJNIF(uint FJHEHEDBGNJ, T IIPLJLPCLBC)
	{
		return default(uint);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B4")]
	[Cpp2IlInjected.Address(RVA = "0x4249920", Offset = "0x4248520", VA = "0x184249920")]
	public bool KEKFCKEBLAB(T IIPLJLPCLBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B5")]
	[Cpp2IlInjected.Address(RVA = "0x4249FB0", Offset = "0x4248BB0", VA = "0x184249FB0")]
	public int PAIBFEHFPFK(T IIPLJLPCLBC)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B6")]
	[Cpp2IlInjected.Address(RVA = "0x4249A30", Offset = "0x4248630", VA = "0x184249A30")]
	public T MCDECIHBNJE(int BAEBMIBABAE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001B7")]
	[Cpp2IlInjected.Address(RVA = "0x42497B0", Offset = "0x42483B0", VA = "0x1842497B0")]
	public bool AJIDDEEMNPB(T IIPLJLPCLBC, bool NNACKADBKAE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B8")]
	[Cpp2IlInjected.Address(RVA = "0x4249230", Offset = "0x4247E30", VA = "0x184249230")]
	public bool AJIDDEEMNPB(T IIPLJLPCLBC, int BAEBMIBABAE, bool NNACKADBKAE = false)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001B9")]
	[Cpp2IlInjected.Address(RVA = "0x4249880", Offset = "0x4248480", VA = "0x184249880")]
	private int HCDOJDGJKIK(int IPBPNCHALEF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001BA")]
	[Cpp2IlInjected.Address(RVA = "0x424A0C0", Offset = "0x4248CC0", VA = "0x18424A0C0", Slot = "5")]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001BB")]
	[Cpp2IlInjected.Address(RVA = "0x424A0C0", Offset = "0x4248CC0", VA = "0x18424A0C0", Slot = "4")]
	private IEnumerator<CKFDHMLNLOB> System.Collections.Generic.IEnumerable<RecRoom.Core.DataStructures.IndexedMap<T>.Pair>.GetEnumerator()
	{
		return null;
	}
}
[Cpp2IlInjected.Token(Token = "0x200005F")]
public class APELDPIDBDH<T> : IDisposable where T : new()
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000EF")]
	private readonly Stack<T> LDDBKNFFEFI;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F0")]
	private readonly List<T> JNDOCHDEEOA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F1")]
	private readonly int KPJHMFMLGKC;

	[Cpp2IlInjected.Token(Token = "0x60001C2")]
	[Cpp2IlInjected.Address(RVA = "0x3D46220", Offset = "0x3D44E20", VA = "0x183D46220")]
	public static APELDPIDBDH<T> FDAIKCDONMB(int DFJDDCJIBIA = 0, int KPJHMFMLGKC = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C3")]
	[Cpp2IlInjected.Address(RVA = "0x3D46120", Offset = "0x3D44D20", VA = "0x183D46120")]
	public static APELDPIDBDH<T> EJEDPELOPHH(int DFJDDCJIBIA = 0, int KPJHMFMLGKC = 100)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C4")]
	[Cpp2IlInjected.Address(RVA = "0x3D46930", Offset = "0x3D45530", VA = "0x183D46930")]
	public APELDPIDBDH()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C5")]
	[Cpp2IlInjected.Address(RVA = "0x3D46710", Offset = "0x3D45310", VA = "0x183D46710")]
	public APELDPIDBDH(int DFJDDCJIBIA, int KPJHMFMLGKC = int.MaxValue, bool GJIIDGFLGBI = true)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C6")]
	[Cpp2IlInjected.Address(RVA = "0x3D46370", Offset = "0x3D44F70", VA = "0x183D46370")]
	public T JJDEFHBJCMN()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001C7")]
	[Cpp2IlInjected.Address(RVA = "0x3D46530", Offset = "0x3D45130", VA = "0x183D46530")]
	public void NNDEKLEFPFP(T IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C8")]
	[Cpp2IlInjected.Address(RVA = "0x3D46610", Offset = "0x3D45210", VA = "0x183D46610")]
	private void PABOLLNFPEM(T IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001C9")]
	[Cpp2IlInjected.Address(RVA = "0x3D46320", Offset = "0x3D44F20", VA = "0x183D46320")]
	private void GAGHHAJNANM(T IIPLJLPCLBC)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CA")]
	[Cpp2IlInjected.Address(RVA = "0x3D45F90", Offset = "0x3D44B90", VA = "0x183D45F90", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001CB")]
	[Cpp2IlInjected.Address(RVA = "0x3D45D90", Offset = "0x3D44990", VA = "0x183D45D90")]
	private void BHPEANFFNEK(IEnumerable<T> COOBAOCKFHD)
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000060")]
public class IPEFBEIBGCG<T> where T : IEquatable<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F2")]
	private Dictionary<int, T> CNAIHKDCKLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F3")]
	private T JOKFOFCOCFP;

	[Cpp2IlInjected.Token(Token = "0x17000051")]
	public virtual T NIBJEIJHOIB
	{
		[Cpp2IlInjected.Token(Token = "0x60001CC")]
		[Cpp2IlInjected.Address(RVA = "0x865990", Offset = "0x864590", VA = "0x180865990", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001CD")]
		[Cpp2IlInjected.Address(RVA = "0x868D60", Offset = "0x867960", VA = "0x180868D60", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001CE")]
	[Cpp2IlInjected.Address(RVA = "0x3ECA610", Offset = "0x3EC9210", VA = "0x183ECA610")]
	public bool LCIJIMMMDPD(T IIPLJLPCLBC, int BOCMOELLFNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001CF")]
	[Cpp2IlInjected.Address(RVA = "0x3ECA770", Offset = "0x3EC9370", VA = "0x183ECA770")]
	public bool MHFEADBCBPA(int BOCMOELLFNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D0")]
	[Cpp2IlInjected.Address(RVA = "0x3ECA200", Offset = "0x3EC8E00", VA = "0x183ECA200")]
	public T CMIAHHDBIKI(int PNGLBJEPAAE)
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001D1")]
	[Cpp2IlInjected.Address(RVA = "0x3ECA8E0", Offset = "0x3EC94E0", VA = "0x183ECA8E0")]
	private bool PKFOHKLIEHI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D2")]
	[Cpp2IlInjected.Address(RVA = "0x3ECA9C0", Offset = "0x3EC95C0", VA = "0x183ECA9C0")]
	public bool PNDEAMPCPGC(int BOCMOELLFNN, [Out] T IIPLJLPCLBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D3")]
	[Cpp2IlInjected.Address(RVA = "0x3ECAA20", Offset = "0x3EC9620", VA = "0x183ECAA20")]
	public IPEFBEIBGCG()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000061")]
public class ODGDLPMODHO<T>
{
	[Cpp2IlInjected.Token(Token = "0x2000062")]
	protected struct BBCPJELMPEE
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F6")]
		public T JCMGPEFMEMP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x40000F7")]
		public int DFLLOILDKBC;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F4")]
	protected readonly List<BBCPJELMPEE> MMKCOHHNKMD;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x40000F5")]
	private T KLOBICDGHMA;

	[Cpp2IlInjected.Token(Token = "0x17000052")]
	public int NAAONAFFINP
	{
		[Cpp2IlInjected.Token(Token = "0x60001D4")]
		[Cpp2IlInjected.Address(RVA = "0x358E2D0", Offset = "0x358CED0", VA = "0x18358E2D0")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001D5")]
	[Cpp2IlInjected.Address(RVA = "0x46475A0", Offset = "0x46461A0", VA = "0x1846475A0")]
	public bool CPEFJACKAGC(T IIPLJLPCLBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D6")]
	[Cpp2IlInjected.Address(RVA = "0x4648070", Offset = "0x4646C70", VA = "0x184648070")]
	public void LKPJOLMECIF(T IIPLJLPCLBC, int BOCMOELLFNN)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D7")]
	[Cpp2IlInjected.Address(RVA = "0x46477D0", Offset = "0x46463D0", VA = "0x1846477D0")]
	public bool ECLBFOFCOFL(T IIPLJLPCLBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001D8")]
	[Cpp2IlInjected.Address(RVA = "0x4647370", Offset = "0x4645F70", VA = "0x184647370")]
	public void AFPCPCPKMJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001D9")]
	[Cpp2IlInjected.Address(RVA = "0x4647C00", Offset = "0x4646800", VA = "0x184647C00")]
	public T FMNIIDGOKOD()
	{
		return (T)null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001DA")]
	[Cpp2IlInjected.Address(RVA = "0x4647E10", Offset = "0x4646A10", VA = "0x184647E10")]
	protected void LAHPHPGLINJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001DB")]
	[Cpp2IlInjected.Address(RVA = "0x4648130", Offset = "0x4646D30", VA = "0x184648130")]
	public ODGDLPMODHO()
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
		[KJNKIIMENHL(OBLJNCJJPID.Self, false, false, false)]
		private Transform parentTransform;

		[Cpp2IlInjected.Token(Token = "0x17000053")]
		public Vector3 position
		{
			[Cpp2IlInjected.Token(Token = "0x60001DC")]
			[Cpp2IlInjected.Address(RVA = "0x69A39D0", Offset = "0x69A25D0", VA = "0x1869A39D0")]
			get
			{
				return default(Vector3);
			}
			[Cpp2IlInjected.Token(Token = "0x60001DD")]
			[Cpp2IlInjected.Address(RVA = "0x69A3CA0", Offset = "0x69A28A0", VA = "0x1869A3CA0")]
			set
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000054")]
		public Quaternion rotation
		{
			[Cpp2IlInjected.Token(Token = "0x60001DE")]
			[Cpp2IlInjected.Address(RVA = "0x69A3BB0", Offset = "0x69A27B0", VA = "0x1869A3BB0")]
			get
			{
				return default(Quaternion);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000055")]
		public Vector3 forward
		{
			[Cpp2IlInjected.Token(Token = "0x60001DF")]
			[Cpp2IlInjected.Address(RVA = "0x69A3920", Offset = "0x69A2520", VA = "0x1869A3920")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000056")]
		public Vector3 up
		{
			[Cpp2IlInjected.Token(Token = "0x60001E0")]
			[Cpp2IlInjected.Address(RVA = "0x69A3BF0", Offset = "0x69A27F0", VA = "0x1869A3BF0")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x17000057")]
		public Vector3 right
		{
			[Cpp2IlInjected.Token(Token = "0x60001E1")]
			[Cpp2IlInjected.Address(RVA = "0x69A3B00", Offset = "0x69A2700", VA = "0x1869A3B00")]
			get
			{
				return default(Vector3);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x60001E2")]
		[Cpp2IlInjected.Address(RVA = "0x69A3890", Offset = "0x69A2490", VA = "0x1869A3890")]
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
		[Cpp2IlInjected.Address(RVA = "0x495C8A0", Offset = "0x495B4A0", VA = "0x18495C8A0", Slot = "4")]
		public virtual T EPNJJLCBFOM()
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x60001E4")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		protected ResourcePrefabReference()
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000065")]
public class CPFHNLJLMEN : IDisposable
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000102")]
	private Dictionary<byte, KGLADAHFAHO> HACMDFOKLPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
	[Cpp2IlInjected.Token(Token = "0x4000103")]
	private readonly APELDPIDBDH<KGLADAHFAHO> APECNJLHHMO;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x4000104")]
	private readonly bool HJMOPNBGAOE;

	[Cpp2IlInjected.Token(Token = "0x17000058")]
	public KGLADAHFAHO NJPGOMHGCAA
	{
		[Cpp2IlInjected.Token(Token = "0x60001E5")]
		[Cpp2IlInjected.Address(RVA = "0x867D10", Offset = "0x866910", VA = "0x180867D10")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x60001E6")]
		[Cpp2IlInjected.Address(RVA = "0x867570", Offset = "0x866170", VA = "0x180867570")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000059")]
	public Vector2 HOODKIIEHAL
	{
		[Cpp2IlInjected.Token(Token = "0x60001E7")]
		[Cpp2IlInjected.Address(RVA = "0xD447B0", Offset = "0xD433B0", VA = "0x180D447B0")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001E8")]
		[Cpp2IlInjected.Address(RVA = "0x1029C00", Offset = "0x1028800", VA = "0x181029C00")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005A")]
	private Vector2 MNFAGIAFANI
	{
		[Cpp2IlInjected.Token(Token = "0x60001E9")]
		[Cpp2IlInjected.Address(RVA = "0x1088690", Offset = "0x1087290", VA = "0x181088690")]
		[CompilerGenerated]
		set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005B")]
	public Vector2 MPMJCDLBGMN
	{
		[Cpp2IlInjected.Token(Token = "0x60001EA")]
		[Cpp2IlInjected.Address(RVA = "0x69A0A60", Offset = "0x699F660", VA = "0x1869A0A60")]
		[CompilerGenerated]
		get
		{
			return default(Vector2);
		}
		[Cpp2IlInjected.Token(Token = "0x60001EB")]
		[Cpp2IlInjected.Address(RVA = "0x86C7C0", Offset = "0x86B3C0", VA = "0x18086C7C0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x1700005C")]
	public int GKGLOKHGMNM
	{
		[Cpp2IlInjected.Token(Token = "0x60001EC")]
		[Cpp2IlInjected.Address(RVA = "0x869F00", Offset = "0x868B00", VA = "0x180869F00")]
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[Cpp2IlInjected.Token(Token = "0x60001ED")]
		[Cpp2IlInjected.Address(RVA = "0x86A110", Offset = "0x868D10", VA = "0x18086A110")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x60001EE")]
	[Cpp2IlInjected.Address(RVA = "0x69A0D00", Offset = "0x699F900", VA = "0x1869A0D00")]
	public CPFHNLJLMEN(Bounds PENBPIFKGCL, Vector2[] LJOGOFMHMHK, int HCNEPCJAPKF, byte IPBPNCHALEF, float NDFCDOEPLHG = 0f, [Optional] APELDPIDBDH<KGLADAHFAHO> APECNJLHHMO)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001EF")]
	[Cpp2IlInjected.Address(RVA = "0x699FD40", Offset = "0x699E940", VA = "0x18699FD40")]
	public void CEFNBLJNMKF(Bounds PENBPIFKGCL, Vector2[] LJOGOFMHMHK, int HCNEPCJAPKF, byte IPBPNCHALEF, float NDFCDOEPLHG = 0f)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F0")]
	[Cpp2IlInjected.Address(RVA = "0x69A0CA0", Offset = "0x699F8A0", VA = "0x1869A0CA0")]
	public KGLADAHFAHO POPPFBJJLEO(byte BAEBMIBABAE)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F1")]
	[Cpp2IlInjected.Address(RVA = "0x69A05E0", Offset = "0x699F1E0", VA = "0x1869A05E0")]
	public void HNHLEJDAGEB(Vector3 DCDKACDAEIJ, float MCGIBIPEGNJ, float FPKDIFANGCB, List<byte> IADIJGDDGFL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F2")]
	[Cpp2IlInjected.Address(RVA = "0x69A05C0", Offset = "0x699F1C0", VA = "0x1869A05C0")]
	public void GGIJGJFLBBN(KGLADAHFAHO.PAADHIEAMCF MJJDIFJPIOL)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F3")]
	[Cpp2IlInjected.Address(RVA = "0x69A01E0", Offset = "0x699EDE0", VA = "0x1869A01E0")]
	public static int CLFNPEOFDDL(Vector2[] LJOGOFMHMHK, int HCNEPCJAPKF)
	{
		return default(int);
	}

	[Cpp2IlInjected.Token(Token = "0x60001F4")]
	[Cpp2IlInjected.Address(RVA = "0x69A02D0", Offset = "0x699EED0", VA = "0x1869A02D0")]
	private KGLADAHFAHO DMPFKPIEMJB(byte BAEBMIBABAE, KGLADAHFAHO.EDHNIMAPCAA HPFAGCILPON, KGLADAHFAHO DELFIACNBGK)
	{
		return null;
	}

	[Cpp2IlInjected.Token(Token = "0x60001F5")]
	[Cpp2IlInjected.Address(RVA = "0x69A06B0", Offset = "0x699F2B0", VA = "0x1869A06B0")]
	private void KDGPIBDEPEF(KGLADAHFAHO DELFIACNBGK, Vector2[] LJOGOFMHMHK, int PNJAHNFFHGF, int FEAFEDOENGL, int FLMBOJCJAHG, int LFKNGNLIING, float NDFCDOEPLHG)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F6")]
	[Cpp2IlInjected.Address(RVA = "0x69A0A80", Offset = "0x699F680", VA = "0x1869A0A80")]
	private void PGMEKFBLLFF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F7")]
	[Cpp2IlInjected.Address(RVA = "0x69A0500", Offset = "0x699F100", VA = "0x1869A0500", Slot = "4")]
	public void Dispose()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001F8")]
	[Cpp2IlInjected.Address(RVA = "0x69A0560", Offset = "0x699F160", VA = "0x1869A0560", Slot = "1")]
	~CPFHNLJLMEN()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x2000066")]
public class KGLADAHFAHO
{
	[Cpp2IlInjected.Token(Token = "0x2000067")]
	public enum EDHNIMAPCAA
	{
		[Cpp2IlInjected.Token(Token = "0x400010F")]
		Root,
		[Cpp2IlInjected.Token(Token = "0x4000110")]
		Node,
		[Cpp2IlInjected.Token(Token = "0x4000111")]
		Leaf
	}

	[Cpp2IlInjected.Token(Token = "0x2000068")]
	public enum PAADHIEAMCF
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
	public byte ALHLDKPOGOP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x14")]
	[Cpp2IlInjected.Token(Token = "0x4000106")]
	public Vector3 IFNMGPODDJJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
	[Cpp2IlInjected.Token(Token = "0x4000107")]
	public Vector3 FODIPBCKAJM;

	[Cpp2IlInjected.FieldOffset(Offset = "0x2C")]
	[Cpp2IlInjected.Token(Token = "0x4000108")]
	public Vector3 BJKNBGPHLLN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x38")]
	[Cpp2IlInjected.Token(Token = "0x4000109")]
	public Vector3 HGCMDLFNHEP;

	[Cpp2IlInjected.FieldOffset(Offset = "0x44")]
	[Cpp2IlInjected.Token(Token = "0x400010A")]
	public EDHNIMAPCAA LIHLBMBFKOJ;

	[Cpp2IlInjected.FieldOffset(Offset = "0x48")]
	[Cpp2IlInjected.Token(Token = "0x400010B")]
	public KGLADAHFAHO BBKNDFHDFHL;

	[Cpp2IlInjected.FieldOffset(Offset = "0x50")]
	[Cpp2IlInjected.Token(Token = "0x400010C")]
	public List<KGLADAHFAHO> LGALJAMMJAH;

	[Cpp2IlInjected.FieldOffset(Offset = "0x58")]
	[Cpp2IlInjected.Token(Token = "0x400010D")]
	public bool ONHCLGCAFLE;

	[Cpp2IlInjected.Token(Token = "0x60001F9")]
	[Cpp2IlInjected.Address(RVA = "0x69A3110", Offset = "0x69A1D10", VA = "0x1869A3110")]
	public KGLADAHFAHO()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FA")]
	[Cpp2IlInjected.Address(RVA = "0x69A2C80", Offset = "0x69A1880", VA = "0x1869A2C80")]
	public void HEHNFNCPIPE(KGLADAHFAHO INEKOMJGJNI)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FB")]
	[Cpp2IlInjected.Address(RVA = "0x866B20", Offset = "0x865720", VA = "0x180866B20")]
	public void GGIJGJFLBBN(int ALGBJJEACFE, PAADHIEAMCF MJJDIFJPIOL, int BDLFBJECBPK = 0)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FC")]
	[Cpp2IlInjected.Address(RVA = "0x69A2DC0", Offset = "0x69A19C0", VA = "0x1869A2DC0")]
	public void HNHLEJDAGEB(List<byte> IADIJGDDGFL, Vector3 DCDKACDAEIJ, float MCGIBIPEGNJ, float FPKDIFANGCB)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x60001FD")]
	[Cpp2IlInjected.Address(RVA = "0x69A3020", Offset = "0x69A1C20", VA = "0x1869A3020")]
	public bool KFABBNJHCOL(Vector3 HCMICLBLHLG)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FE")]
	[Cpp2IlInjected.Address(RVA = "0x69A3050", Offset = "0x69A1C50", VA = "0x1869A3050")]
	public bool LLLMIBDIDJE(Vector3 HCMICLBLHLG, float CPOLNNIMILP)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x60001FF")]
	[Cpp2IlInjected.Address(RVA = "0x69A3080", Offset = "0x69A1C80", VA = "0x1869A3080")]
	public void NJFEGHENHFC()
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
		public struct HDHIELLCEJN<T> : IEnumerable<T>, IEnumerable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011B")]
			private readonly List<Component> ELBBNOKMNCJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011C")]
			private readonly bool KNJLMOFJDPD;

			[Cpp2IlInjected.Token(Token = "0x600020C")]
			[Cpp2IlInjected.Address(RVA = "0x3DB44E0", Offset = "0x3DB30E0", VA = "0x183DB44E0")]
			public HDHIELLCEJN(List<Component> ELBBNOKMNCJ, bool KNJLMOFJDPD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600020D")]
			[Cpp2IlInjected.Address(RVA = "0x3DB43A0", Offset = "0x3DB2FA0", VA = "0x183DB43A0")]
			public ONFCHBAPIEG<T> DHNABIACCII()
			{
				return default(ONFCHBAPIEG<T>);
			}

			[Cpp2IlInjected.Token(Token = "0x600020E")]
			[Cpp2IlInjected.Address(RVA = "0x3DB4410", Offset = "0x3DB3010", VA = "0x183DB4410", Slot = "5")]
			IEnumerator IEnumerable.GetEnumerator()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600020F")]
			[Cpp2IlInjected.Address(RVA = "0x3DB4410", Offset = "0x3DB3010", VA = "0x183DB4410", Slot = "4")]
			IEnumerator<T> IEnumerable<T>.GetEnumerator()
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200006B")]
		public struct ONFCHBAPIEG<T> : IEnumerator<T>, IEnumerator, IDisposable where T : class
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011D")]
			private readonly List<Component> ELBBNOKMNCJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011E")]
			private readonly bool KNJLMOFJDPD;

			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x400011F")]
			private int BAEBMIBABAE;

			[Cpp2IlInjected.Token(Token = "0x1700005E")]
			public T KENACMDPOBM
			{
				[Cpp2IlInjected.Token(Token = "0x6000211")]
				[Cpp2IlInjected.Address(RVA = "0x46C2C70", Offset = "0x46C1870", VA = "0x1846C2C70", Slot = "4")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x1700005F")]
			object IEnumerator.Current
			{
				[Cpp2IlInjected.Token(Token = "0x6000212")]
				[Cpp2IlInjected.Address(RVA = "0x46C2C00", Offset = "0x46C1800", VA = "0x1846C2C00", Slot = "7")]
				get
				{
					return null;
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000210")]
			[Cpp2IlInjected.Address(RVA = "0x46C2C40", Offset = "0x46C1840", VA = "0x1846C2C40")]
			public ONFCHBAPIEG(List<Component> ELBBNOKMNCJ, bool KNJLMOFJDPD)
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000213")]
			[Cpp2IlInjected.Address(RVA = "0x46C2B40", Offset = "0x46C1740", VA = "0x1846C2B40", Slot = "5")]
			public void Dispose()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x6000214")]
			[Cpp2IlInjected.Address(RVA = "0x46C2B50", Offset = "0x46C1750", VA = "0x1846C2B50", Slot = "6")]
			public bool MoveNext()
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000215")]
			[Cpp2IlInjected.Address(RVA = "0x38AB6E0", Offset = "0x38AA2E0", VA = "0x1838AB6E0", Slot = "8")]
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
			[Cpp2IlInjected.Address(RVA = "0x69A56F0", Offset = "0x69A42F0", VA = "0x1869A56F0")]
			get
			{
				return default(bool);
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000201")]
		[Cpp2IlInjected.Address(RVA = "0x86FB10", Offset = "0x86E710", VA = "0x18086FB10")]
		public ToolHierarchyCache()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000202")]
		[Cpp2IlInjected.Address(RVA = "0x69A5460", Offset = "0x69A4060", VA = "0x1869A5460")]
		private void NJFEGHENHFC(GameObject OKNHMCBCFPH, bool FPPHGAIAECP = false)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000203")]
		[Cpp2IlInjected.Address(RVA = "0x69A55D0", Offset = "0x69A41D0", VA = "0x1869A55D0")]
		public static void NJFEGHENHFC(GameObject OKNHMCBCFPH, ToolHierarchyCache EKDHMOLEJIP)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000204")]
		[Cpp2IlInjected.Address(RVA = "0x69A5360", Offset = "0x69A3F60", VA = "0x1869A5360")]
		public void DJIPNJHFAHB()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000205")]
		[Cpp2IlInjected.Address(RVA = "0x2E4BD30", Offset = "0x2E4A930", VA = "0x182E4BD30")]
		public void CPBHCAGMGLI<T>(Action<T> OBNFAOABLKL)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000206")]
		[Cpp2IlInjected.Address(RVA = "0x2E4BBE0", Offset = "0x2E4A7E0", VA = "0x182E4BBE0")]
		public T AJNFCGCLPGL<T>(bool KNJLMOFJDPD = false) where T : class
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000207")]
		[Cpp2IlInjected.Address(RVA = "0x2E4BC80", Offset = "0x2E4A880", VA = "0x182E4BC80")]
		public HDHIELLCEJN<T> CCOODJCACBO<T>(bool KNJLMOFJDPD = false) where T : class
		{
			return default(HDHIELLCEJN<T>);
		}

		[Cpp2IlInjected.Token(Token = "0x6000208")]
		[Cpp2IlInjected.Address(RVA = "0x69A5010", Offset = "0x69A3C10", VA = "0x1869A5010")]
		public List<Component> ALNBKIMAEDN(Type HGPIKDLKBHO)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000209")]
		[Cpp2IlInjected.Address(RVA = "0x69A5370", Offset = "0x69A3F70", VA = "0x1869A5370", Slot = "4")]
		public bool Equals(ToolHierarchyCache KIGIELEFAKI, ToolHierarchyCache DKINGMIONNI)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600020A")]
		[Cpp2IlInjected.Address(RVA = "0x69A53F0", Offset = "0x69A3FF0", VA = "0x1869A53F0", Slot = "5")]
		public int GetHashCode(ToolHierarchyCache APKAFMDACKK)
		{
			return default(int);
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x200006C")]
public class GGDAAOGLELB<T>
{
	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000120")]
	private int DFJDDCJIBIA;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000121")]
	private int NFALPOKBAPN;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000122")]
	private List<T> ECEGKELEMNK;

	[Cpp2IlInjected.Token(Token = "0x17000060")]
	public int NAAONAFFINP
	{
		[Cpp2IlInjected.Token(Token = "0x6000216")]
		[Cpp2IlInjected.Address(RVA = "0x3D0FB80", Offset = "0x3D0E780", VA = "0x183D0FB80")]
		get
		{
			return default(int);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000061")]
	public T LMJDMBCGCBD
	{
		[Cpp2IlInjected.Token(Token = "0x6000217")]
		[Cpp2IlInjected.Address(RVA = "0x3D4AB80", Offset = "0x3D49780", VA = "0x183D4AB80")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000062")]
	public T GFDJMLPFLPO
	{
		[Cpp2IlInjected.Token(Token = "0x6000218")]
		[Cpp2IlInjected.Address(RVA = "0x3D4AD30", Offset = "0x3D49930", VA = "0x183D4AD30")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000063")]
	public T ALIBLGGFBEI
	{
		[Cpp2IlInjected.Token(Token = "0x6000219")]
		[Cpp2IlInjected.Address(RVA = "0x3D4AEA0", Offset = "0x3D49AA0", VA = "0x183D4AEA0")]
		get
		{
			return (T)null;
		}
	}

	[Cpp2IlInjected.Token(Token = "0x600021A")]
	[Cpp2IlInjected.Address(RVA = "0x3D4B370", Offset = "0x3D49F70", VA = "0x183D4B370")]
	public GGDAAOGLELB(int DFJDDCJIBIA)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021B")]
	[Cpp2IlInjected.Address(RVA = "0x3D4AF20", Offset = "0x3D49B20", VA = "0x183D4AF20")]
	public void LKPJOLMECIF(T KJBGACHNFPK)
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021C")]
	[Cpp2IlInjected.Address(RVA = "0x3D4AB20", Offset = "0x3D49720", VA = "0x183D4AB20")]
	public void AFPCPCPKMJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021D")]
	[Cpp2IlInjected.Address(RVA = "0x3D4B200", Offset = "0x3D49E00", VA = "0x183D4B200")]
	public void LOINFBMNAPF()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021E")]
	[Cpp2IlInjected.Address(RVA = "0x3D4B300", Offset = "0x3D49F00", VA = "0x183D4B300")]
	public void PBJFIMDIBII()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x600021F")]
	[Cpp2IlInjected.Address(RVA = "0x3D4AE20", Offset = "0x3D49A20", VA = "0x183D4AE20")]
	public void FFINEEDCDCH()
	{
	}
}
[Cpp2IlInjected.Token(Token = "0x200006D")]
public class CJMPCOCFKOM<T>
{
	[Cpp2IlInjected.Token(Token = "0x200006E")]
	private struct BOCICLDGANI
	{
		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000127")]
		public int DFLLOILDKBC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
		[Cpp2IlInjected.Token(Token = "0x4000128")]
		public T JCMGPEFMEMP;
	}

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000123")]
	private readonly Dictionary<object, BOCICLDGANI> CNAIHKDCKLB;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000124")]
	private readonly EqualityComparer<T> MOENACOHOND;

	[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
	[Cpp2IlInjected.Token(Token = "0x4000125")]
	private T JOKFOFCOCFP;

	[Cpp2IlInjected.Token(Token = "0x17000064")]
	public virtual T NIBJEIJHOIB
	{
		[Cpp2IlInjected.Token(Token = "0x6000220")]
		[Cpp2IlInjected.Address(RVA = "0x8DA110", Offset = "0x8D8D10", VA = "0x1808DA110", Slot = "4")]
		get
		{
			return (T)null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000221")]
		[Cpp2IlInjected.Address(RVA = "0x5676E70", Offset = "0x5675A70", VA = "0x185676E70", Slot = "5")]
		protected set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000065")]
	public bool CHELEKHBFFD
	{
		[Cpp2IlInjected.Token(Token = "0x6000222")]
		[Cpp2IlInjected.Address(RVA = "0x5675F20", Offset = "0x5674B20", VA = "0x185675F20")]
		get
		{
			return default(bool);
		}
	}

	[Cpp2IlInjected.Token(Token = "0x17000066")]
	public object NJOBLLPEDLJ
	{
		[Cpp2IlInjected.Token(Token = "0x6000223")]
		[Cpp2IlInjected.Address(RVA = "0x867CF0", Offset = "0x8668F0", VA = "0x180867CF0")]
		[CompilerGenerated]
		get
		{
			return null;
		}
		[Cpp2IlInjected.Token(Token = "0x6000224")]
		[Cpp2IlInjected.Address(RVA = "0x867CC0", Offset = "0x8668C0", VA = "0x180867CC0")]
		[CompilerGenerated]
		private set
		{
		}
	}

	[Cpp2IlInjected.Token(Token = "0x6000225")]
	[Cpp2IlInjected.Address(RVA = "0x5675F80", Offset = "0x5674B80", VA = "0x185675F80")]
	public bool LCIJIMMMDPD(T IIPLJLPCLBC, object GBENACPKFNA, int BOCMOELLFNN)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000226")]
	[Cpp2IlInjected.Address(RVA = "0x5676D80", Offset = "0x5675980", VA = "0x185676D80")]
	public bool MHFEADBCBPA(object GBENACPKFNA)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000227")]
	[Cpp2IlInjected.Address(RVA = "0x567A170", Offset = "0x5678D70", VA = "0x18567A170")]
	public bool PNDEAMPCPGC(object GBENACPKFNA, [Out] T IIPLJLPCLBC)
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x6000228")]
	[Cpp2IlInjected.Address(RVA = "0x3C32C70", Offset = "0x3C31870", VA = "0x183C32C70")]
	public void AFPCPCPKMJJ()
	{
	}

	[Cpp2IlInjected.Token(Token = "0x6000229")]
	[Cpp2IlInjected.Address(RVA = "0x5678610", Offset = "0x5677210", VA = "0x185678610")]
	private bool PKFOHKLIEHI()
	{
		return default(bool);
	}

	[Cpp2IlInjected.Token(Token = "0x600022A")]
	[Cpp2IlInjected.Address(RVA = "0x567A530", Offset = "0x5679130", VA = "0x18567A530")]
	public CJMPCOCFKOM()
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
