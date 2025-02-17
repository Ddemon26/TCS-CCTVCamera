using System;
using UnityEngine;

namespace TCS {
    public class CCTVGroup {
        //groups are of 4 cameras
        public CCTV[] cameras = new CCTV[4];
        
        public void TurnOn(int cameraIndex, RenderTexture rt) {
            cameras[cameraIndex].TurnOn(rt);
        }
        
        public void TurnOff(int cameraIndex) {
            cameras[cameraIndex].TurnOff();
        }
    }
    public class CCTV : MonoBehaviour {
        [SerializeField] Camera camera;
        RenderTexture renderTexture;

        void Awake() {
            camera.enabled = false;
        }

        public void TurnOn(RenderTexture rt) {
            renderTexture = rt;
            camera.targetTexture = rt;
            camera.enabled = true;
        }
        
        public void TurnOff() {
            camera.targetTexture = null;
            camera.enabled = false;
        }
    }
    public class CCTVTerminal : MonoBehaviour {
        public RenderTexture renderTexture1;
        public RenderTexture renderTexture2;
        public RenderTexture renderTexture3;
        public RenderTexture renderTexture4;
    }
}