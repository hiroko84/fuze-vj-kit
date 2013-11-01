﻿/* 
 * fuZe vjkit
 * 
 * Copyright (C) 2013 Unity Technologies Japan, G.K.
 * 
 * Permission is hereby granted, free of charge, to any 
 * person obtaining a copy of this software and associated 
 * documentation files (the "Software"), to deal in the 
 * Software without restriction, including without limitation 
 * the rights to use, copy, modify, merge, publish, distribute, 
 * sublicense, and/or sell copies of the Software, and to permit 
 * persons to whom the Software is furnished to do so, subject 
 * to the following conditions: The above copyright notice and 
 * this permission notice shall be included in all copies or 
 * substantial portions of the Software.
 * 
 * THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, 
 * EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES 
 * OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND 
 * NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT 
 * HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, 
 * WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING 
 * FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR 
 * OTHER DEALINGS IN THE SOFTWARE.
 * 
 * Special Thanks:
 * The original software design and architecture of fuZe vjkit 
 * is inspired by Visualizer Studio, created by Altered Reality 
 * Entertainment LLC.
 */
using UnityEngine;
using System.Collections;

[AddComponentMenu("VJKit/System/Midi Manager")]
public class VJMidiManager : VJAbstractManager {
	
//	Queue<MidiMessage> messageQueue;
//	
//	public bool IsEmpty {
//		get { return messageQueue.Count == 0; }
//	}
//	
//	public MidiMessage PopMessage ()
//	{
//		return messageQueue.Dequeue ();
//	}
//	
//	#if UNITY_EDITOR
//	Queue<MidiMessage> messageHistory;
//	
//	public Queue<MidiMessage> History {
//		get { return messageHistory; }
//	}
//	#endif
//	

	public override void Awake() {
		base.Awake();		
	}
//
//	void Update ()
//	{
//		while (true) {
//			var data = UnityMidiReceiver.DequeueIncomingData ();
//			if (data == 0) {
//				break;
//			}
//			
//			var message = new MidiMessage (data);
//			messageQueue.Enqueue (message);
//			#if UNITY_EDITOR
//			messageHistory.Enqueue (message);
//			#endif
//		}
//		#if UNITY_EDITOR
//		while (messageHistory.Count > 8) {
//			messageHistory.Dequeue ();
//		}
//		#endif
//	}
}